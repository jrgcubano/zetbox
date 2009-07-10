using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

using Kistl.API;
using Kistl.API.Server;
using Kistl.API.Utils;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;
using System.Collections;

namespace Kistl.Server.Packaging
{
    public class Exporter
    {
        public static void Publish(string filename, string[] moduleNamespaces)
        {
            using (TraceClient.TraceHelper.TraceMethodCall())
            {
                Trace.TraceInformation("Starting Publish for Modules {0}", string.Join(", ", moduleNamespaces));
                using (IKistlContext ctx = KistlContext.GetContext())
                {
                    using (FileStream fs = File.OpenWrite(filename))
                    {
                        fs.SetLength(0);
                        Publish(ctx, fs, moduleNamespaces);
                    }

                    // Save ExportGuids
                    ctx.SubmitChanges();
                }
                Trace.TraceInformation("Export finished");
            }
        }

        public static void Publish(IKistlContext ctx, Stream s, string[] moduleNamespaces)
        {
            using (XmlTextWriter xml = new XmlTextWriter(s, Encoding.UTF8))
            {
                var moduleList = GetModules(ctx, moduleNamespaces);
                WriteStartDocument(xml, new Kistl.App.Base.Module[] 
                        { 
                            ctx.GetQuery<Kistl.App.Base.Module>().First(m => m.Namespace == "Kistl.App.Base"),
                            ctx.GetQuery<Kistl.App.Base.Module>().First(m => m.Namespace == "Kistl.App.GUI"),
                        });

                var propNamespaces = new string[] { "Kistl.App.Base", "Kistl.App.GUI" };

                foreach (var module in moduleList)
                {
                    var objects = PackagingHelper.GetMetaObjects(ctx, module);
                    foreach (IPersistenceObject obj in objects.Values)
                    {
                        Console.Write(".");
                        ExportObject(xml, obj, propNamespaces);
                    }
                }
            }
        }

        public static void Export(string filename, string[] moduleNamespaces)
        {
            using (TraceClient.TraceHelper.TraceMethodCall())
            {
                Trace.TraceInformation("Starting Export for Modules {0}", string.Join(", ", moduleNamespaces));
                using (IKistlContext ctx = KistlContext.GetContext())
                {
                    using (FileStream fs = File.OpenWrite(filename))
                    {
                        fs.SetLength(0);
                        Export(ctx, fs, moduleNamespaces);
                    }

                    // Save ExportGuids
                    ctx.SubmitChanges();
                }
                Trace.TraceInformation("Export finished");
            }
        }

        public static void Export(IKistlContext ctx, Stream s, string[] moduleNamespaces)
        {
            using (XmlTextWriter xml = new XmlTextWriter(s, Encoding.UTF8))
            {
                var moduleList = GetModules(ctx, moduleNamespaces);
                WriteStartDocument(xml, moduleList);

                var iexpIf = ctx.GetIExportableInterface();
                foreach (var module in moduleList)
                {
                    Trace.TraceInformation("  exporting {0}", module.ModuleName);
                    foreach (var objClass in module.DataTypes.OfType<Kistl.App.Base.ObjectClass>().Where(o => o.ImplementsInterfaces.Contains(iexpIf)))
                    {
                        Trace.TraceInformation("    {0} ", objClass.ClassName);
                        foreach (var obj in ctx.GetQuery(objClass.GetDescribedInterfaceType()))
                        {
                            Console.Write(".");
                            ExportObject(xml, obj, moduleNamespaces);
                        }
                        Console.WriteLine();
                    }

                    int moduleID = module.ID; // Dont ask
                    foreach (var rel in ctx.GetQuery<Kistl.App.Base.Relation>().Where(r => r.Module.ID == moduleID))
                    {
                        if (rel.GetRelationType() != RelationType.n_m) continue;
                        if (!rel.A.Type.ImplementsIExportable(ctx)) continue;
                        if (!rel.B.Type.ImplementsIExportable(ctx)) continue;

                        string ifTypeName = string.Format("{0}, {1}", rel.GetRelationFullName(), ApplicationContext.Current.InterfaceAssembly);
                        Trace.TraceInformation("    {0} ", ifTypeName);
                        Type ifType = Type.GetType(ifTypeName);
                        if (ifType == null)
                        {
                            Trace.TraceWarning("RelationType {0} not found", ifTypeName);
                            continue;
                        }

                        MethodInfo mi = ctx.GetType().FindGenericMethod("FetchRelation", new Type[] { ifType }, new Type[] { typeof(int), typeof(RelationEndRole), typeof(IDataObject) });
                        var relations = MagicCollectionFactory.WrapAsCollection<IPersistenceObject>(mi.Invoke(ctx, new object[] { rel.ID, RelationEndRole.A, null }));

                        foreach (var obj in relations)
                        {
                            Console.Write(".");
                            ExportObject(xml, obj, moduleNamespaces);
                        }
                    }
                }
                xml.WriteEndElement();
                xml.WriteEndDocument();
            }
        }

        #region Xml/Export private Methods
        private static void ExportObject(XmlTextWriter xml, IPersistenceObject obj, string[] propNamespaces)
        {
            Type t = obj.GetInterfaceType().Type;
            xml.WriteStartElement(t.Name, t.Namespace);
            // TODO: Let a Constructor do that job
            if (((Kistl.App.Base.IExportable)obj).ExportGuid == Guid.Empty)
            {
                ((Kistl.App.Base.IExportable)obj).ExportGuid = Guid.NewGuid();
            }
            ((IExportableInternal)obj).Export(xml, propNamespaces);
            xml.WriteEndElement();
        }

        private static void WriteStartDocument(XmlTextWriter xml, IEnumerable<Kistl.App.Base.Module> moduleList)
        {
            xml.Formatting = Formatting.Indented;
            xml.WriteStartDocument();
            xml.WriteStartElement("KistlPackaging");
            xml.WriteAttributeString("xmlns", "http://dasz.at/Kistl");
            foreach (var module in moduleList)
            {
                xml.WriteAttributeString("xmlns", module.ModuleName, null, module.Namespace);
            }

            xml.WriteAttributeString("date", XmlConvert.ToString(DateTime.Now, XmlDateTimeSerializationMode.Utc));
        }

        private static List<Kistl.App.Base.Module> GetModules(IKistlContext ctx, string[] moduleNamespaces)
        {
            var moduleList = new List<Kistl.App.Base.Module>();
            if (moduleNamespaces.Contains("*"))
            {
                moduleList.AddRange(ctx.GetQuery<Kistl.App.Base.Module>().OrderBy(m => m.Namespace));
            }
            else
            {
                foreach (var ns in moduleNamespaces)
                {
                    var module = ctx.GetQuery<Kistl.App.Base.Module>().Where(m => m.Namespace == ns).FirstOrDefault();
                    if (module == null)
                    {
                        Trace.TraceWarning("Module {0} not found", ns);
                        continue;
                    }
                    moduleList.Add(module);
                }
            }
            return moduleList;
        }
        #endregion
    }
}
