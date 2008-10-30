using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Kistl.API;
using Kistl.API.Client;
using Kistl.App.Base;

namespace Kistl.Client
{
    /// <summary>
    /// Implementation of the client-side CustomActionsManager
    /// </summary>
    internal class CustomActionsManagerClient : API.ICustomActionsManager
    {
        private class InvokeInfo
        {
            public MethodInfo CLRMethod { get; set; }
            public object Instance { get; set; }
            public EventInfo CLREvent { get; set; }
        }

        /// <summary>
        /// List of Custom Actions
        /// </summary>
        private Dictionary<Type, List<InvokeInfo>> customAction = new Dictionary<Type, List<InvokeInfo>>();

        /// <summary>
        /// Indicates that initializing is done
        /// </summary>
        private bool initialized = false;

        /// <summary>
        /// Attach using Metadata
        /// Detaching is done through the Garbage Collector
        /// see Unsubscribing at http://msdn2.microsoft.com/en-us/library/ms366768.aspx
        /// </summary>
        /// <param name="obj"></param>
        public void AttachEvents(IDataObject obj)
        {
            if (!initialized) return;

            // New Method
            if (customAction.ContainsKey(obj.GetType()))
            {
                foreach (InvokeInfo ii in customAction[obj.GetType()])
                {
                    // TODO: Fix Case 316
                    ii.CLREvent.AddEventHandler(obj, Delegate.CreateDelegate(
                        ii.CLREvent.EventHandlerType, ii.Instance, ii.CLRMethod));
                }
            }
        }

        /// <summary>
        /// Load Metadata, create an Instance and save
        /// Note: The Assembly type is loaded, but _without_ actions!
        /// </summary>
        public void Init()
        {
            try
            {
                using (TraceClient.TraceHelper.TraceMethodCall())
                {
                    using (IKistlContext ctx = KistlContext.GetContext())
                    {
                        // Prepare Modules
                        List<Kistl.App.Base.Module> moduleList = ctx.GetQuery<Kistl.App.Base.Module>().ToList();

                        // Prepare ObjectClasses
                        List<Kistl.App.Base.ObjectClass> classList = ctx.GetQuery<Kistl.App.Base.ObjectClass>().ToList();

                        // Prepare Methods
                        List<Method> mList = ctx.GetQuery<Method>().ToList();

                        // Prepare Assemblies
                        List<Kistl.App.Base.Assembly> aList = ctx.GetQuery<Kistl.App.Base.Assembly>().ToList();

                        StringBuilder warnings = new StringBuilder();

                        foreach (ObjectClass baseObjClass in classList)
                        {
                            try
                            {
                                // baseObjClass.GetDataType(); is not possible here, because this
                                // Method is currently attaching
                                Type objType = Type.GetType(baseObjClass.Module.Namespace + "." + baseObjClass.ClassName + Kistl.API.Helper.ImplementationSuffix + ", " + ApplicationContext.Current.ImplementationAssembly);
                                if (objType == null)
                                {
                                    warnings.AppendLine(string.Format("DataType '{0}, Kistl.Objects.Client' not found", baseObjClass.Module.Namespace + "." + baseObjClass.ClassName));
                                    continue;
                                }
                                foreach (ObjectClass objClass in baseObjClass.GetObjectHierarchie())
                                {
                                    foreach (MethodInvocation mi in objClass.MethodInvocations)
                                    {
                                        try
                                        {
                                            if (!mi.Assembly.IsClientAssembly) continue;

                                            Type t = Type.GetType(mi.FullTypeName + ", " + mi.Assembly.AssemblyName);
                                            if (t == null)
                                            {
                                                warnings.AppendLine(string.Format("Warning: Type {0}, {1} not found", mi.FullTypeName, mi.Assembly.AssemblyName));
                                                continue;
                                            }

                                            MethodInfo clrMethod = t.GetMethod(mi.MemberName);
                                            if (clrMethod == null)
                                            {
                                                warnings.AppendLine(string.Format("Warning: CLR Method {0} not found", mi.MemberName));
                                                continue;
                                            }

                                            EventInfo ei = objType.GetEvent(
                                                "On" + mi.Method.MethodName + "_" + mi.InvokeOnObjectClass.ClassName);

                                            if (ei == null)
                                            {
                                                warnings.AppendLine(string.Format("Warning: CLR Event On{0}_{1} not found", mi.Method.MethodName, mi.InvokeOnObjectClass.ClassName));
                                                continue;
                                            }

                                            InvokeInfo ii = new InvokeInfo();
                                            ii.CLRMethod = clrMethod;
                                            ii.Instance = Activator.CreateInstance(t);
                                            ii.CLREvent = ei;

                                            if (!customAction.ContainsKey(objType))
                                            {
                                                customAction.Add(objType, new List<InvokeInfo>());
                                            }
                                            customAction[objType].Add(ii);
                                        }
                                        catch (Exception ex)
                                        {
                                            warnings.AppendLine(ex.Message);
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                warnings.AppendLine(ex.Message);
                            }
                        }

                        // TODO create and use Logging API to invert control here
                        if (warnings.Length > 0)
                        {
                            System.Diagnostics.Debug.WriteLine(warnings.ToString());
                            if (GuiApplicationContext.Current.Renderer != null)
                            {
                                GuiApplicationContext.Current.Renderer.ShowMessage(warnings.ToString());
                            }
                        }
                    }
                }
            }
            finally
            {
                initialized = true;
                // Clean up Helper Caches
                ClientHelper.CleanCaches();
            }
        }
    }
}
