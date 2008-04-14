using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Xml;
using Kistl.API.Server;
using Kistl.API;
using System.Diagnostics;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;

namespace Kistl.Server
{
    /// <summary>
    /// Implementierung des KistlServices
    /// Error are handled by the KistlServiceErrorHandler
    /// </summary>
    public class KistlService : IKistlService
    {
        #region XmlSerializer
        private interface IXmlSerializer
        {
            string XmlFromList(IEnumerable lst);
            string XmlFromObject(IDataObject obj);
            IDataObject ObjectFromXml(string xml);
        }

        private class XmlSerializer<XMLCOLLECTION, XMLOBJECT> : IXmlSerializer
            where XMLCOLLECTION : IXmlObjectCollection, new()
            where XMLOBJECT : IXmlObject, new()
        {
            public string XmlFromList(IEnumerable lst)
            {
                XMLCOLLECTION list = new XMLCOLLECTION();
                list.Objects.AddRange(lst.OfType<object>());
                return list.ToXmlString();
            }

            public string XmlFromObject(IDataObject obj)
            {
                XMLOBJECT result = new XMLOBJECT();
                result.Object = obj;
                return result.ToXmlString();
            }

            public IDataObject ObjectFromXml(string xml)
            {
                return xml.FromXmlString<XMLOBJECT>().Object as IDataObject;
            }
        }

        private static IXmlSerializer _CurrentSerializer = null;
        private static IXmlSerializer CurrentSerializer
        {
            get
            {
                if (_CurrentSerializer == null)
                {
                    Type t = typeof(XmlSerializer<,>);
                    Type xmlCollection = Type.GetType("Kistl.API.XMLObjectCollection, Kistl.Objects.Server");
                    Type xmlObj = Type.GetType("Kistl.API.XMLObject, Kistl.Objects.Server");

                    Type result = t.MakeGenericType(xmlCollection, xmlObj);

                    _CurrentSerializer = Activator.CreateInstance(result) as IXmlSerializer;
                    if (_CurrentSerializer == null) throw new ApplicationException("Cannot create instance of KistlService.XmlSerializer");
                }

                return _CurrentSerializer;
            }
        }
        #endregion

        /// <summary>
        /// Implementierung der GetList Methode
        /// Holt sich vom ObjektBroker das richtige Server BL Objekt & 
        /// delegiert den Aufruf weiter
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetList(ObjectType type, int maxListCount, SerializableExpression filter, SerializableExpression orderBy)
        {
            try
            {
                using (TraceClient.TraceHelper.TraceMethodCall(type.ToString()))
                {
                    using (IKistlContext ctx = KistlDataContext.InitSession())
                    {
                        // TODO: Add filter to Interface!!
                        IEnumerable lst = ServerObjectHandlerFactory.GetServerObjectHandler(type)
                            .GetList(maxListCount, 
                            filter != null ? filter.ToExpression() : null, 
                            orderBy != null ? orderBy.ToExpression() : null);
                        return CurrentSerializer.XmlFromList(lst);
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
                // Never called, Handle errors throws an Exception
                return null;
            }
        }

        /// <summary>
        /// Implementierung der GetListOf Methode
        /// Holt sich vom ObjektBroker das richtige Server BL Objekt & 
        /// delegiert den Aufruf weiter
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ID"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public string GetListOf(ObjectType type, int ID, string property)
        {
            try
            {
                if (type == null) throw new ArgumentNullException("type");
                if (ID == API.Helper.INVALIDID) throw new ArgumentOutOfRangeException("xmlObj");
                if (string.IsNullOrEmpty(property)) throw new ArgumentNullException("property");

                using (TraceClient.TraceHelper.TraceMethodCall("{0} [{1}].{2}", type, ID, property))
                {
                    using (IKistlContext ctx = KistlDataContext.InitSession())
                    {
                        IEnumerable lst = ServerObjectHandlerFactory.GetServerObjectHandler(type).GetListOf(ID, property);
                        return CurrentSerializer.XmlFromList(lst);
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
                // Never called, Handle errors throws an Exception
                return null;
            }
        }

        /// <summary>
        /// Implementierung der GetObject Methode
        /// Holt sich vom ObjektBroker das richtige Server BL Objekt & 
        /// delegiert den Aufruf weiter
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetObject(ObjectType type, int ID)
        {
            try
            {
                if (type == null) throw new ArgumentNullException("type");
                if (ID == API.Helper.INVALIDID) throw new ArgumentOutOfRangeException("xmlObj");

                using (TraceClient.TraceHelper.TraceMethodCall("{0} [{1}]", type, ID))
                {
                    using (IKistlContext ctx = KistlDataContext.InitSession())
                    {
                        IDataObject obj = ServerObjectHandlerFactory.GetServerObjectHandler(type).GetObject(ID);
                        return CurrentSerializer.XmlFromObject(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
                // Never called, Handle errors throws an Exception
                return null;
            }
        }

        /// <summary>
        /// Implementierung der SetObject Methode
        /// Holt sich vom ObjektBroker das richtige Server BL Objekt & 
        /// delegiert den Aufruf weiter
        /// </summary>
        /// <param name="type"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string SetObject(ObjectType type, string xmlObj)
        {
            try
            {
                if (type == null) throw new ArgumentNullException("type");
                if (string.IsNullOrEmpty(xmlObj)) throw new ArgumentNullException("xmlObj");

                using (TraceClient.TraceHelper.TraceMethodCall("{0}", type))
                {
                    using (IKistlContext ctx = KistlDataContext.InitSession())
                    {
                        IDataObject obj = CurrentSerializer.ObjectFromXml(xmlObj);
                        obj = ServerObjectHandlerFactory.GetServerObjectHandler(type).SetObject(obj);
                        return CurrentSerializer.XmlFromObject(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
                // Never called, Handle errors throws an Exception
                return null;
            }
        }

        /// <summary>
        /// Implements the Generate Method
        /// </summary>
        public void Generate()
        {
            try
            {
                using (TraceClient.TraceHelper.TraceMethodCall())
                {
                    Generators.Generator.GenerateCode();
                    Generators.Generator.GenerateDatabase();
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
            }
        }

        /// <summary>
        /// Implementierung der HelloWorld Methode
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string HelloWorld(string name)
        {
            try
            {
                using (TraceClient.TraceHelper.TraceMethodCall(name))
                {
                    return "Hello " + name;
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex, true);
                // Never called, Handle errors throws an Exception
                return null;
            }
        }
    }
}
