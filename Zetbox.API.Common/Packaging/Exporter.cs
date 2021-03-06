// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.App.Packaging
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;
    using System.Xml;
    using Zetbox.API;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;
    using Zetbox.App.Extensions;

    public class Exporter
    {
        private readonly static log4net.ILog Log = Logging.Exporter;

        public static void PublishFromContext(IZetboxContext ctx, string filename, string[] ownerModules)
        {
            using (var s = new FileSystemPackageProvider(filename, BasePackageProvider.Modes.Write))
            {
                PublishFromContext(ctx, s, ownerModules);
            }
        }

        public static void PublishFromContext(IZetboxContext ctx, Stream stream, string[] ownerModules, string streamDescription)
        {
            using (var s = new StreamPackageProvider(stream, BasePackageProvider.Modes.Write, streamDescription))
            {
                PublishFromContext(ctx, s, ownerModules);
            }
        }

        public static void PublishFromContext(IZetboxContext ctx, IPackageProvider s, string[] ownerModules)
        {
            using (Log.DebugTraceMethodCall("PublishFromContext"))
            {
                Log.InfoFormat("Starting Publish for Modules {0}", string.Join(", ", ownerModules));
                Log.Debug("Loading modulelist");
                var moduleList = GetModules(ctx, ownerModules);
                WriteStartDocument(s, ctx, new Zetbox.App.Base.Module[] 
                        { 
                            ctx.GetQuery<Zetbox.App.Base.Module>().First(m => m.Name == "ZetboxBase"),
                            ctx.GetQuery<Zetbox.App.Base.Module>().First(m => m.Name == "GUI"),
                        });

                var propNamespaces = new string[] { "Zetbox.App.Base", "Zetbox.App.GUI" };

                foreach (var module in moduleList)
                {
                    Log.DebugFormat("Publishing objects for module {0}", module.Name);
                    var objects = PackagingHelper.GetMetaObjects(ctx, module);

                    Stopwatch watch = new Stopwatch();
                    watch.Start();

                    int counter = 0;
                    foreach (var obj in objects)
                    {
                        ExportObject(s, obj, propNamespaces);

                        counter++;
                        if (watch.ElapsedMilliseconds > 1000)
                        {
                            watch.Reset();
                            watch.Start();
                            Log.DebugFormat("{0:n0}% finished", (double)counter / (double)objects.Count * 100.0);
                        }
                    }
                    Log.Debug("100% finished");
                }
                Log.Info("Export finished");
            }
        }

        public static void ExportFromContext(IReadOnlyZetboxContext ctx, string filename, string[] schemaModules, string[] ownerModules)
        {
            using (var s = new FileSystemPackageProvider(filename, BasePackageProvider.Modes.Write))
            {
                ExportFromContext(ctx, s, schemaModules, ownerModules);
            }
        }

        public static void ExportFromContext(IReadOnlyZetboxContext ctx, Stream stream, string[] schemaModules, string[] ownerModules, string streamDescription)
        {
            using (var s = new StreamPackageProvider(stream, BasePackageProvider.Modes.Write, streamDescription))
            {
                ExportFromContext(ctx, s, schemaModules, ownerModules);
            }
        }

        /// <summary>
        /// Exports data from the specified context into the specified package provider. Data is selected by defining
        /// schema and owning module.
        /// </summary>
        /// <remarks>
        /// <para>For example, exporting {"ZetboxBase", "GUI"}/{"*"} will export all schema information to recreate the
        /// current database. Exporting {"Calendar"}/{"MyApplication"} will export all calendar data specific to the
        /// "MyApplication" module.
        /// </para>
        /// </remarks>
        /// <param name="ctx">The data source</param>
        /// <param name="s">The export target</param>
        /// <param name="schemaModules">A list of strings naming the schema-defining modules. This selects which data
        /// (-classes) should be exported. Specify a single asterisk (<code>"*"</code>) to select all available
        /// modules.</param>
        /// <param name="ownerModules">A list of strings naming the data-owning modules. This selects whose data should
        /// be exported.  Specify a single asterisk (<code>"*"</code>) to select all available data, independent of
        /// module-membership. This also includes data that is not member of any module.</param>
        public static void ExportFromContext(IReadOnlyZetboxContext ctx, IPackageProvider s, string[] schemaModules, string[] ownerModules)
        {
            using (Log.DebugTraceMethodCall("ExportFromContext"))
            {
                Log.InfoFormat("Starting Export for Modules [{0}], data owned by [{1}]", string.Join(", ", schemaModules), string.Join(", ", ownerModules));

                var allData = ownerModules.Contains("*");

                var schemaList = GetModules(ctx, schemaModules);
                var schemaNamespaces = schemaList.Select(m => m.Namespace).ToArray();

                WriteStartDocument(s, ctx, schemaList);

                var iexpIf = ctx.GetIExportableInterface();
                foreach (var module in schemaList)
                {
                    Log.InfoFormat("  exporting module {0}", module.Name);
                    foreach (var objClass in ctx.GetQuery<ObjectClass>().Where(o => o.Module == module).OrderBy(o => o.Name).ToList())
                    {
                        if (objClass.SubClasses.Count > 0)
                        {
                            Log.DebugFormat("    skipping {0}: not a leaf class", objClass.Name);
                        }
                        else if (!objClass.AndParents(cls => new[] { cls }, cls => cls.BaseObjectClass).SelectMany(cls => cls.ImplementsInterfaces).Contains(iexpIf))
                        {
                            Log.DebugFormat("    skipping {0}: not exportable", objClass.Name);
                        }
                        else if (allData)
                        {
                            Log.InfoFormat("    exporting class {0}", objClass.Name);
                            foreach (var obj in ctx.Internals().GetAll(objClass.GetDescribedInterfaceType()).OrderBy(obj => ((IExportable)obj).ExportGuid))
                            {
                                ExportObject(s, obj, schemaNamespaces);
                            }
                        }
                        else if (objClass.ImplementsIModuleMember())
                        {
                            Log.InfoFormat("    exporting parts of class {0}", objClass.Name);
                            foreach (var obj in ctx.Internals().GetAll(objClass.GetDescribedInterfaceType())
                                .Cast<IModuleMember>()
                                .Where(mm => mm.Module != null && ownerModules.Contains(mm.Module.Name))
                                .Cast<IExportable>()
                                .OrderBy(obj => obj.ExportGuid)
                                .Cast<IPersistenceObject>())
                            {
                                ExportObject(s, obj, schemaNamespaces);
                            }
                        }
                        else
                        {
                            Log.DebugFormat("    skipping {0}", objClass.Name);
                        }
                    }

                    int moduleID = module.ID; // Dont ask
                    foreach (var rel in ctx.GetQuery<Relation>().Where(r => r.Module.ID == moduleID)
                        .OrderBy(r => r.A.Type.Name).ThenBy(r => r.A.RoleName).ThenBy(r => r.B.Type.Name).ThenBy(r => r.B.RoleName).ThenBy(r => r.ExportGuid))
                    {
                        if (rel.GetRelationType() != RelationType.n_m)
                            continue;
                        if (!rel.A.Type.ImplementsIExportable())
                            continue;
                        if (!rel.B.Type.ImplementsIExportable())
                            continue;

                        try
                        {
                            var ifType = rel.GetEntryInterfaceType();
                            Log.InfoFormat("    {0} ", ifType.Type.Name);

                            MethodInfo mi = ctx.GetType().FindGenericMethod("FetchRelation", new Type[] { ifType.Type }, new Type[] { typeof(Guid), typeof(RelationEndRole), typeof(IDataObject) });
                            var relations = MagicCollectionFactory.WrapAsCollection<IPersistenceObject>(mi.Invoke(ctx, new object[] { rel.ExportGuid, RelationEndRole.A, null }));

                            foreach (var obj in relations.OrderBy(obj => ((IExportable)obj).ExportGuid))
                            {
                                ExportObject(s, obj, schemaNamespaces);
                            }
                        }
                        catch (TypeLoadException ex)
                        {
                            var message = String.Format("Failed to load InterfaceType for entries of {0}", rel);
                            Log.Warn(message, ex);
                        }
                    }
                }
                s.Writer.WriteEndElement();
                s.Writer.WriteEndDocument();

                Log.Info("Export finished");
            }
        }

        #region Xml/Export private Methods
        private static void ExportObject(IPackageProvider s, IPersistenceObject obj, string[] propNamespaces)
        {
            XmlWriter writer = s.Writer;
            Type t = obj.ReadOnlyContext.GetInterfaceType(obj).Type;
            writer.WriteStartElement(t.Name, t.Namespace);
            if (((IExportable)obj).ExportGuid == Guid.Empty)
            {
                throw new InvalidOperationException(string.Format("At least one object of type {0} has an empty ExportGuid (ID={1})", t.FullName, obj.ID));
            }
            ((IExportableInternal)obj).Export(writer, propNamespaces);

            if (obj is Blob && s.SupportsBlobs)
            {
                var blob = (Blob)obj;
                s.PutBlob(blob.ExportGuid, blob.OriginalName, blob.GetStream());
            }
            writer.WriteEndElement();
        }

        private static void WriteStartDocument(IPackageProvider s, IReadOnlyZetboxContext ctx, IEnumerable<Zetbox.App.Base.Module> moduleList)
        {
            XmlWriter writer = s.Writer;
            writer.WriteStartDocument();
            if (moduleList.Count() == 1)
            {
                // use exported module as default namespace
                writer.WriteStartElement("ZetboxPackaging", "http://dasz.at/Zetbox");
                foreach (var module in moduleList)
                {
                    writer.WriteAttributeString("xmlns", module.Name, null, module.Namespace);
                }
            }
            else
            {
                writer.WriteStartElement("ZetboxPackaging", "http://dasz.at/Zetbox");
                foreach (var module in moduleList)
                {
                    writer.WriteAttributeString("xmlns", module.Name, null, module.Namespace);
                }
            }

            DateTime? lastChanged = new DateTime?[] { 
                ctx.GetQuery<Zetbox.App.Base.Assembly>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.BaseParameter>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.Constraint>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.DataType>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.DefaultPropertyValue>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.EnumerationEntry>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.Method>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.Module>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.Property>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.Relation>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.RelationEnd>().Max(d => d.ChangedOn),
                ctx.GetQuery<Zetbox.App.Base.TypeRef>().Max(d => d.ChangedOn)
            }.Max();

            writer.WriteAttributeString("date", XmlConvert.ToString(lastChanged ?? DateTime.Now, XmlDateTimeSerializationMode.Utc));
        }

        private static List<Zetbox.App.Base.Module> GetModules(IReadOnlyZetboxContext ctx, string[] moduleNames)
        {
            var moduleList = new List<Zetbox.App.Base.Module>();
            if (moduleNames.Contains("*"))
            {
                moduleList.AddRange(ctx.GetQuery<Zetbox.App.Base.Module>());
            }
            else
            {
                foreach (var name in moduleNames)
                {
                    var module = ctx.GetQuery<Zetbox.App.Base.Module>().Where(m => m.Name == name).FirstOrDefault();
                    if (module == null)
                    {
                        Log.WarnFormat("Module {0} not found, skipping entry", name);
                        continue;
                    }
                    moduleList.Add(module);
                }
            }
            return moduleList.OrderBy(m => m.Name).ToList();
        }
        #endregion
    }
}
