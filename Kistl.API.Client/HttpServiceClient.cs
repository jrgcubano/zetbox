
namespace Kistl.API.Client
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    public sealed class HttpServiceClient
        : Kistl.API.Client.KistlService.IKistlService
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Kistl.API.Client.HttpServiceClient");
        private readonly static byte[] Empty = new byte[0];

        private readonly ICredentialsResolver _credentialsResolver;

        private readonly Uri SetObjectsUri;
        private readonly Uri GetListUri;
        private readonly Uri GetListOfUri;
        private readonly Uri FetchRelationUri;
        private readonly Uri GetBlobStreamUri;
        private readonly Uri SetBlobStreamUri;
        private readonly Uri InvokeServerMethodUri;

        public HttpServiceClient(ICredentialsResolver credentialsResolver)
        {
            _credentialsResolver = credentialsResolver;

            SetObjectsUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/SetObjects");
            GetListUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/GetList");
            GetListOfUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/GetListOf");
            FetchRelationUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/FetchRelation");
            GetBlobStreamUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/GetBlobStream");
            SetBlobStreamUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/SetBlobStream");
            InvokeServerMethodUri = new Uri(ConfigurationManager.AppSettings["serviceUri"] + "/InvokeServerMethod");
        }

        private byte[] MakeRequest(Uri destination, Action<Stream> sendRequest)
        {
            var req = WebRequest.Create(destination);

            _credentialsResolver.InitWebRequest(req);

            req.Method = "POST";
            using (var reqStream = req.GetRequestStream())
            {
                sendRequest(reqStream);
            }
            try
            {
                using (var response = req.GetResponse())
                using (var input = response.GetResponseStream())
                {
                    return (bool)new BinaryFormatter().Deserialize(input)
                        ? (byte[])new BinaryFormatter().Deserialize(input)
                        : Empty;
                }
            }
            catch (WebException ex)
            {
                var errorMsg = String.Format("Error when accessing server({0}): {1}", destination, ex.Status);
                Log.Error(errorMsg);
                var httpResponse = ex.Response as HttpWebResponse;
                if (httpResponse != null)
                {
                    Log.ErrorFormat("HTTP Error: {0}: {1}", httpResponse.StatusCode, httpResponse.StatusDescription);
                    foreach (var header in ex.Response.Headers)
                    {
                        Log.Error(header.ToString());
                    }
                }
                else
                {
                    Log.Error("No headers");
                }
                throw new ApplicationException(errorMsg, ex);
            }
        }

        private void SerializeArray<T>(Stream reqStream, T[] array)
        {
            var haveArray = array != null && array.Length > 0;
            new BinaryFormatter().Serialize(reqStream, haveArray);
            if (haveArray)
                new BinaryFormatter().Serialize(reqStream, array);
        }

        public byte[] SetObjects(byte[] msg, ObjectNotificationRequest[] notificationRequests)
        {
            return MakeRequest(SetObjectsUri,
                reqStream =>
                {
                    SerializeArray(reqStream, msg);
                    SerializeArray(reqStream, notificationRequests);
                });
        }

        public byte[] GetList(SerializableType type, int maxListCount, bool eagerLoadLists, SerializableExpression[] filter, OrderByContract[] orderBy)
        {
            if (type == null) throw new ArgumentNullException("type");

            return MakeRequest(GetListUri,
                reqStream =>
                {
                    new BinaryFormatter().Serialize(reqStream, type);
                    new BinaryFormatter().Serialize(reqStream, maxListCount);
                    new BinaryFormatter().Serialize(reqStream, eagerLoadLists);
                    SerializeArray(reqStream, filter);
                    SerializeArray(reqStream, orderBy);
                });
        }

        public byte[] GetListOf(SerializableType type, int ID, string property)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (String.IsNullOrEmpty(property)) throw new ArgumentNullException("property");

            return MakeRequest(GetListOfUri,
                reqStream =>
                {
                    new BinaryFormatter().Serialize(reqStream, type);
                    new BinaryFormatter().Serialize(reqStream, ID);
                    new BinaryFormatter().Serialize(reqStream, property);
                });
        }

        public byte[] FetchRelation(Guid relId, int role, int ID)
        {
            return MakeRequest(FetchRelationUri,
                reqStream =>
                {
                    new BinaryFormatter().Serialize(reqStream, relId);
                    new BinaryFormatter().Serialize(reqStream, role);
                    new BinaryFormatter().Serialize(reqStream, ID);
                });
        }

        public Stream GetBlobStream(int ID)
        {
            var req = WebRequest.Create(GetBlobStreamUri);
            req.Method = "POST";
            using (var reqStream = req.GetRequestStream())
            {
                new BinaryFormatter().Serialize(reqStream, ID);
            }
            try
            {
                using (var response = req.GetResponse())
                {
                    return response.GetResponseStream();
                }
            }
            catch (WebException ex)
            {
                var errorMsg = String.Format("Error when accessing server({0}): {1}: {2}", GetBlobStreamUri, ex.Status, ex.Response);
                Log.Error(errorMsg);
                throw new ApplicationException(errorMsg, ex);
            }
        }

        public KistlService.BlobResponse SetBlobStream(KistlService.BlobMessage request)
        {
            if (request == null) throw new ArgumentNullException("request");

            var req = WebRequest.Create(SetBlobStreamUri);
            req.Method = "POST";
            using (var reqStream = req.GetRequestStream())
            {
                new BinaryFormatter().Serialize(reqStream, request.FileName);
                new BinaryFormatter().Serialize(reqStream, request.MimeType);
                request.Stream.CopyTo(reqStream);
            }
            try
            {
                using (var response = req.GetResponse())
                {
                    var input = response.GetResponseStream();
                    return new KistlService.BlobResponse()
                    {
                        ID = (int)new BinaryFormatter().Deserialize(input),
                        BlobInstance = input
                    };
                }
            }
            catch (WebException ex)
            {
                var errorMsg = String.Format("Error when accessing server({0}): {1}: {2}", SetBlobStreamUri, ex.Status, ex.Response);
                Log.Error(errorMsg);
                throw new ApplicationException(errorMsg, ex);
            }
        }

        public byte[] InvokeServerMethod(out byte[] retChangedObjects, SerializableType type, int ID, string method, SerializableType[] parameterTypes, byte[] parameter, byte[] changedObjects, ObjectNotificationRequest[] notificationRequests)
        {
            if (type == null) throw new ArgumentNullException("type");

            var req = WebRequest.Create(InvokeServerMethodUri);
            req.Method = "POST";
            using (var reqStream = req.GetRequestStream())
            {
                new BinaryFormatter().Serialize(reqStream, type);
                new BinaryFormatter().Serialize(reqStream, ID);
                new BinaryFormatter().Serialize(reqStream, method);
                SerializeArray(reqStream, parameterTypes);
                SerializeArray(reqStream, parameter);
                SerializeArray(reqStream, changedObjects);
                SerializeArray(reqStream, notificationRequests);
            }
            try
            {
                using (var response = req.GetResponse())
                using (var input = response.GetResponseStream())
                {
                    retChangedObjects = (bool)new BinaryFormatter().Deserialize(input)
                        ? (byte[])new BinaryFormatter().Deserialize(input)
                        : retChangedObjects = Empty;

                    return (bool)new BinaryFormatter().Deserialize(input)
                        ? (byte[])new BinaryFormatter().Deserialize(input)
                        : Empty;
                }
            }
            catch (WebException ex)
            {
                var errorMsg = String.Format("Error when accessing server({0}): {1}: {2}", InvokeServerMethodUri, ex.Status, ex.Response);
                Log.Error(errorMsg);
                throw new ApplicationException(errorMsg, ex);
            }
        }
    }
}