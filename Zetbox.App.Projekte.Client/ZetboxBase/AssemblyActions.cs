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
namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Utils;
    using Zetbox.App.GUI;
    using Zetbox.Client.Presentables;
    using System.IO;
    using Zetbox.Client.GUI;
    using Zetbox.App.Extensions;

    /// <summary>
    /// Client implementation
    /// </summary>
    [Implementor]
    public class AssemblyActions
    {
        private static IViewModelFactory _mdlFactory;

        public AssemblyActions(IViewModelFactory mdlFactory)
        {
            _mdlFactory = mdlFactory;
        }

        [Invocation]
        public static void RegenerateTypeRefs(Assembly assembly, MethodReturnEventArgs<System.Boolean> e)
        {
            using (Logging.Log.InfoTraceMethodCall(assembly.Name))
            {
                var ctx = assembly.Context;

                // pre-load context
                var oldTypes = ctx.GetQuery<TypeRef>()
                    .WithEagerLoading()
                    .Where(tr => tr.Assembly.ID == assembly.ID)
                    .ToLookup(tr => tr.FullName);

                try
                {
                    var newTypes = LoadAndCreateTypes(assembly, ctx);
                    MarkOldTypesAsDeleted(ctx, oldTypes, newTypes);
                    UpdateTypeParents(newTypes);

                    CreateViewModelDescriptors(ctx, newTypes);
                    CreateViewDescriptors(ctx, newTypes);

                    var newDescriptors = new List<IDataObject>();
                    newDescriptors.AddRange(ctx.AttachedObjects.OfType<ViewModelDescriptor>().Where(d => d.ObjectState == DataObjectState.New).Cast<IDataObject>().ToList());
                    newDescriptors.AddRange(ctx.AttachedObjects.OfType<ViewDescriptor>().Where(d => d.ObjectState == DataObjectState.New).Cast<IDataObject>().ToList());
                    newDescriptors.AddRange(ctx.AttachedObjects.OfType<ServiceDescriptor>().Where(d => d.ObjectState == DataObjectState.New).Cast<IDataObject>().ToList());
                    newDescriptors.AddRange(ctx.AttachedObjects.OfType<Assembly>().Where(d => d.ObjectState == DataObjectState.New).Cast<IDataObject>().ToList());

                    if (newDescriptors.Count > 0)
                    {
                        var workSpace = _mdlFactory.CreateViewModel<Zetbox.Client.Presentables.ObjectEditor.WorkspaceViewModel.Factory>().Invoke(ctx, null);
                        foreach (IDataObject i in newDescriptors)
                        {
                            workSpace.AddItem(DataObjectViewModel.Fetch(_mdlFactory, ctx, workSpace, i));
                        }

                        _mdlFactory.ShowModel(workSpace, true);
                        e.Result = true;
                    }
                    else
                    {
                        _mdlFactory.ShowMessage("Regenerating TypeRefs finished successfully, no new Descriptors or Assemblies found", "Success");
                        e.Result = false;
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Logging.Log.Warn("Failed to RegenerateTypeRefs", ex);
                    e.Result = false;
                }
            }
        }

        private static void CreateViewModelDescriptors(IZetboxContext ctx, Dictionary<int, TypeRef> newTypes)
        {
            using (Logging.Log.InfoTraceMethodCallFormat("CreateViewModelDescriptors", "Creating ViewModelDescriptors"))
            {
                foreach (var tr in newTypes.Values)
                {
                    var type = tr.AsType(false);
                    if (type != null)
                    {
                        object attr;
                        // http://blogs.msdn.com/b/kaevans/archive/2005/10/24/484186.aspx
                        if (type.Assembly.ReflectionOnly)
                        {
                            attr = System.Reflection.CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(i => i.Constructor.DeclaringType.FullName == typeof(ViewModelDescriptorAttribute).FullName);
                        }
                        else
                        {
                            attr = type.GetCustomAttributes(typeof(ViewModelDescriptorAttribute), false).FirstOrDefault() as ViewModelDescriptorAttribute;
                        }
                        if (attr != null)
                        {
                            var descr = ctx.GetQuery<ViewModelDescriptor>().FirstOrDefault(i => i.ViewModelRef == tr);
                            if (descr == null)
                            {
                                descr = ctx.Create<ViewModelDescriptor>();
                                descr.ViewModelRef = tr;
                                descr.Description = "TODO: Add description";
                            }
                        }
                    }
                }
            }
        }

        private static void CreateViewDescriptors(IZetboxContext ctx, Dictionary<int, TypeRef> newTypes)
        {
            using (Logging.Log.InfoTraceMethodCallFormat("CreateViewDescriptors", "Creating ViewDescriptors"))
            {
                foreach (var tr in newTypes.Values)
                {
                    var type = tr.AsType(false);
                    if (type != null)
                    {
                        object attr;
                        Toolkit? tk = null;
                        // http://blogs.msdn.com/b/kaevans/archive/2005/10/24/484186.aspx
                        if (type.Assembly.ReflectionOnly)
                        {
                            attr = System.Reflection.CustomAttributeData.GetCustomAttributes(type).FirstOrDefault(i => i.Constructor.DeclaringType.FullName == typeof(ViewDescriptorAttribute).FullName);
                            if (attr != null) tk = (Toolkit)((System.Reflection.CustomAttributeData)attr).ConstructorArguments.Single().Value;
                        }
                        else
                        {
                            attr = type.GetCustomAttributes(typeof(ViewDescriptorAttribute), false).FirstOrDefault() as ViewDescriptorAttribute;
                            if (attr != null) tk = ((ViewDescriptorAttribute)attr).Toolkit;
                        }
                        if (attr != null)
                        {
                            var descr = ctx.GetQuery<ViewDescriptor>().FirstOrDefault(i => i.ControlRef == tr);
                            if (descr == null)
                            {
                                descr = ctx.Create<ViewDescriptor>();
                                descr.ControlRef = tr;
                                if (tk != null) descr.Toolkit = tk.Value;
                            }
                        }
                    }
                }
            }
        }

        private static void UpdateTypeParents(Dictionary<int, TypeRef> newTypes)
        {
            using (Logging.Log.InfoTraceMethodCallFormat("UpdateTypeParents", "Updating parents"))
            {
                // update parent infos
                foreach (var tr in newTypes.Values)
                {
                    tr.UpdateParent();
                }
            }
        }

        private static void MarkOldTypesAsDeleted(IZetboxContext ctx, ILookup<string, TypeRef> oldTypes, Dictionary<int, TypeRef> newTypes)
        {
            using (Logging.Log.InfoTraceMethodCallFormat("MarkOldTypesAsDeleted", "Updating refs"))
            {
                // Delete unused Refs
                foreach (var tr in oldTypes.SelectMany(g => g))
                {
                    var type = tr.AsType(false);
                    if (type == null)
                    {
                        Logging.Log.Warn("Should delete " + tr.FullName);
                        tr.Deleted = true;
                    }
                    else if (!type.IsGenericType)
                    {
                        if (!newTypes.ContainsKey(tr.ID))
                        {
                            Logging.Log.Warn("Should delete " + tr.FullName);
                            tr.Deleted = true;
                        }
                    }
                    else
                    {
                        tr.Deleted = null;
                    }
                }
            }
        }

        private static Dictionary<int, TypeRef> LoadAndCreateTypes(Assembly assembly, IZetboxContext ctx)
        {
            using (Logging.Log.InfoTraceMethodCall("Loading new types"))
            {
                System.Reflection.Assembly a = null;
                try
                {
                    a = System.Reflection.Assembly.ReflectionOnlyLoad(assembly.Name);
                }
                catch (FileNotFoundException)
                {
                }
                if (a == null)
                {
                    // Try AssemblyLoader directly
                    a = AssemblyLoader.ReflectionOnlyLoadFrom(assembly.Name);
                }
                if (a == null)
                {
                    // Ask user
                    var f = _mdlFactory.GetSourceFileNameFromUser("Assembly files|*.dll;*.exe", "All files|*.*");
                    if (!string.IsNullOrEmpty(f))
                    {
                        a = System.Reflection.Assembly.ReflectionOnlyLoadFrom(f);
                    }
                }
                if (a == null)
                {
                    // Give it up
                    throw new InvalidOperationException("Unable to load assembly: " + assembly.Name);
                }
                var newTypes = a
                    .GetExportedTypes()
                    .Where(t => !t.IsGenericTypeDefinition)
                    .Select(t => t.ToRef(ctx))
                    .ToDictionary(tr => tr.ID);
                return newTypes;
            }
        }

    }
}
