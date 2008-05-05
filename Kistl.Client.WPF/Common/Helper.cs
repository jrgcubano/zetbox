using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using Kistl.API;
using Kistl.API.Client;

namespace Kistl.Client.WPF
{
    /// <summary>
    /// Client Helper Methods
    /// </summary>
    internal class ClientHelper
    {
        /// <summary>
        /// Auch das könnte man besser implementieren
        /// </summary>
        /// <param name="ex"></param>
        public static void HandleError(Exception ex)
        {
            if (ex is FaultException<ApplicationException>)
            {
                System.Windows.MessageBox.Show((ex as ApplicationException).Message);
            }
            else if (ex is FaultException)
            {
                System.Windows.MessageBox.Show((ex as FaultException).Message);
            }
            else
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }

        private static Dictionary<ObjectType, Kistl.App.Base.ObjectClass> _ObjectClasses = null;
        private static Dictionary<string, Kistl.App.Base.Module> _Modules = null;

        public static void CleanCaches()
        {
            lock (typeof(ClientHelper))
            {
                _ObjectClasses = null;
                _Modules = null;
            }
        }

        private static void FetchObjectClasses()
        {
            lock (typeof(ClientHelper))
            {
                if (_ObjectClasses == null)
                {
                    FetchModules();
                    using (TraceClient.TraceHelper.TraceMethodCall("Getting Object Classes"))
                    {
                        // Prefetch Modules
                        using (IKistlContext ctx = KistlContext.GetContext())
                        {
                            _ObjectClasses = ctx.GetQuery<Kistl.App.Base.ObjectClass>()
                                .ToDictionary(o => new ObjectType(o.Module.Namespace, o.ClassName));
                        }
                    }
                }
            }
        }

        public static Dictionary<ObjectType, Kistl.App.Base.ObjectClass> ObjectClasses
        {
            get
            {
                FetchObjectClasses();
                return _ObjectClasses;
            }
        }

        private static void FetchModules()
        {
            lock (typeof(ClientHelper))
            {
                if (_Modules == null)
                {
                    using (TraceClient.TraceHelper.TraceMethodCall("Getting Modules"))
                    {
                        using (IKistlContext ctx = KistlContext.GetContext())
                        {
                            _Modules = ctx.GetQuery<Kistl.App.Base.Module>().ToDictionary(m => m.ModuleName);
                        }
                    }
                }
            }
        }

        public static Dictionary<string, Kistl.App.Base.Module> Modules
        {
            get
            {
                FetchModules();
                return _Modules;
            }
        }

        public static List<Kistl.App.Base.ObjectClass> GetObjectHierarchie(Kistl.App.Base.ObjectClass objClass)
        {
            return GetObjectHierarchie(new ObjectType(objClass.Module.Namespace, objClass.ClassName));
        }

        public static List<Kistl.App.Base.ObjectClass> GetObjectHierarchie(ObjectType type)
        {
            Kistl.App.Base.ObjectClass objClass = ObjectClasses[type];
            List<Kistl.App.Base.ObjectClass> result = new List<Kistl.App.Base.ObjectClass>();
            while (objClass != null)
            {
                result.Add(objClass);

                if (objClass.fk_BaseObjectClass == API.Helper.INVALIDID)
                {
                    objClass = null;
                }
                else
                {
                    objClass = ClientHelper.ObjectClasses.Values.First(o => o.ID == objClass.fk_BaseObjectClass);
                }
            }

            result.Reverse();
            return result;
        }

        public static List<ObjectType> GetTypeHierarchie(ObjectType type)
        {
            Kistl.App.Base.ObjectClass objClass = ObjectClasses[type];
            List<ObjectType> result = new List<ObjectType>();
            while (objClass != null)
            {
                result.Add(new ObjectType(objClass.Module.Namespace, objClass.ClassName));

                if (objClass.fk_BaseObjectClass == API.Helper.INVALIDID)
                {
                    objClass = null;
                }
                else
                {
                    objClass = ClientHelper.ObjectClasses.Values.First(o => o.ID == objClass.fk_BaseObjectClass);
                }
            }

            result.Reverse();
            return result;
        }
    }
}
