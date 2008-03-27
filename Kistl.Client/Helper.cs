using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Client;
using System.ServiceModel;

namespace Kistl.Client
{
    /// <summary>
    /// Client Helper Methods
    /// </summary>
    public class Helper
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
            lock (typeof(Helper))
            {
                _ObjectClasses = null;
                _Modules = null;
            }
        }

        private static void FetchObjectClasses()
        {
            lock (typeof(Helper))
            {
                if (_ObjectClasses == null)
                {
                    FetchModules();
                    using (TraceClient.TraceHelper.TraceMethodCall("Getting Object Classes"))
                    {
                        // Prefetch Modules
                        using (KistlContext ctx = new KistlContext())
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
            lock (typeof(Helper))
            {
                if (_Modules == null)
                {
                    using (TraceClient.TraceHelper.TraceMethodCall("Getting Modules"))
                    {
                        using (KistlContext ctx = new KistlContext())
                        {
                            _Modules = ctx.GetQuery<Kistl.App.Base.Module>().ToDictionary(m => m.ModuleName);

                            // Test!! Legal
                            var test = from m in ctx.GetQuery<Kistl.App.Base.Module>()
                                       where 
                                           m.ModuleName.StartsWith("K") 
                                           && m.Namespace.Length > 1 
                                           && m.ModuleName == "KistlBase" 
                                           && m.ModuleName.EndsWith("e")
                                       select m;
                            foreach (var t in test)
                            {
                                System.Diagnostics.Debug.WriteLine(string.Format("TestFetch: {0}", t.ModuleName));
                            }

                            // Test!! Illegal? 
                            var test2 = from m in ctx.GetQuery<Kistl.App.Base.Module>()
                                        where m.Assemblies.Sum(a => a.AssemblyName.Length) > 0
                                        select m;
                            foreach (var t in test2)
                            {
                                System.Diagnostics.Debug.WriteLine(string.Format("TestFetch: {0}", t.ModuleName));
                            }

                            // Test!! Illegal!!
                            var test3 = from z in ctx.GetQuery<Kistl.App.Zeiterfassung.Zeitkonto>()
                                        where z.Taetigkeiten.Select(tt => tt.Mitarbeiter.Geburtstag > new DateTime(1978, 1, 1)).Count() > 0
                                        select z;
                            foreach (var z in test3)
                            {
                                System.Diagnostics.Debug.WriteLine(string.Format("TestFetch: {0}", z.Kontoname));
                            }

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
                    objClass = Helper.ObjectClasses.Values.First(o => o.ID == objClass.fk_BaseObjectClass);
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
                    objClass = Helper.ObjectClasses.Values.First(o => o.ID == objClass.fk_BaseObjectClass);
                }
            }

            result.Reverse();
            return result;
        }
    }
}
