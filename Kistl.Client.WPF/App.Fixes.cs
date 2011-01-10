// <copyright file="App.Fixes.cs" company="dasz.at OG">
//     Copyright (C) 2009 dasz.at OG. All rights reserved.
// </copyright>

namespace Kistl.Client.WPF
{
    using System;
    using System.Linq;

    using Kistl.API;
    using Kistl.API.Client;
    using Kistl.API.Utils;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using System.Windows;
    using Kistl.App.GUI;

    /// <content>Contains various and temporary fixes needed to clean the database</content>
    public partial class App
    {
        ///// <summary>
        ///// Fix broken TypeRefs.
        ///// </summary>
        //private static void FixupTypeRefParents(IKistlContext ctx)
        //{
        //    if (ctx == null) throw new ArgumentNullException("ctx");
        //    using (Logging.Log.DebugTraceMethodCall("FixupTypeRefParents"))
        //    {
        //        var typeRefs = ctx.GetQuery<TypeRef>();
        //        foreach (var tr in typeRefs)
        //        {
        //            if (tr.Parent != null)
        //            {
        //                continue;
        //            }

        //            UpdateParent(ctx, tr);
        //            ctx.SubmitChanges();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Creates the parent chain for a given TypeRef.
        ///// </summary>
        ///// <param name="ctx">the context to use</param>
        ///// <param name="tr">the <see cref="TypeRef"/> to fix</param>
        //private static void UpdateParent(IKistlContext ctx, TypeRef tr)
        //{
        //    var type = tr.AsType(false);
        //    if (type != null
        //        && type != typeof(object)
        //        && !type.IsGenericTypeDefinition
        //        && type.BaseType != null)
        //    {
        //        tr.Parent = type.BaseType.ToRef(ctx);
        //        UpdateParent(ctx, tr.Parent);
        //    }
        //}

        //private static void PrintEagerLoadingGraphViz()
        //{
        //    using (Logging.Log.DebugTraceMethodCall("PrintEagerLoadingGraphViz"))
        //    {
        //        // Create output suitable for graphviz
        //        Console.WriteLine("---------------------------------------------------------------");
        //        Console.WriteLine();
        //        Console.WriteLine("graph A{");
        //        using (IKistlContext ctx = GetContext())
        //        {
        //            var relations = ctx.GetQuery<Relation>();

        //            foreach (var rel in relations.Where(r => r.A.Navigator != null && r.A.Navigator.EagerLoading))
        //            {
        //                Console.WriteLine("{0} -> {1};", rel.A.Type.Name, rel.B.Type.Name);
        //            }

        //            relations = ctx.GetQuery<Relation>();
        //            foreach (var rel in relations.Where(r => r.B.Navigator != null && r.B.Navigator.EagerLoading))
        //            {
        //                Console.WriteLine("{0} -> {1};", rel.B.Type.Name, rel.A.Type.Name);
        //            }
        //        }
        //        Console.WriteLine("}");
        //        Console.WriteLine(String.Empty);
        //        Console.WriteLine("---------------------------------------------------------------");
        //    }
        //}

        //private static void CreateTestFragebögen()
        //{
        //    using (Logging.Log.DebugTraceMethodCall("FixupTypeRefParents"))
        //    using (IKistlContext ctx = GetContext())
        //    {
        //        ctx.GetQuery<Kistl.App.Test.Antwort>().ForEach(a => ctx.Delete(a));
        //        ctx.GetQuery<Kistl.App.Test.Fragebogen>().ForEach(a => ctx.Delete(a));

        //        var fb1 = ctx.Create<Kistl.App.Test.Fragebogen>();
        //        fb1.BogenNummer = 1;
        //        fb1.Antworten.Add(ctx.Create<Kistl.App.Test.Antwort>());
        //        fb1.Antworten[0].Frage = "Erste Frage";
        //        fb1.Antworten[0].FragenNummer = 1;
        //        fb1.Antworten[0].GegebeneAntwort = 2;
        //        fb1.Antworten.Add(ctx.Create<Kistl.App.Test.Antwort>());
        //        fb1.Antworten[1].Frage = "Zweite Frage";
        //        fb1.Antworten[1].FragenNummer = 2;
        //        fb1.Antworten[1].GegebeneAntwort = 4;

        //        ctx.SubmitChanges();
        //    }
        //}

        //private static void PrintControlKindTypes()
        //{
        //    using (IKistlContext ctx = GetContext())
        //    {
        //        foreach (var ck in ctx.GetQuery<ControlKind>())
        //        {
        //            Logging.Log.InfoFormat("ID = {0}, Type = {1}", ck.ID, ck.GetType().Name);
        //        }
        //    }
        //}
        /// <summary>
        /// Calls currently needed Database fixes
        /// </summary>
        internal static void FixupDatabase(Func<IKistlContext> ctxFactory)
        {
            //ImportIcons(ctxFactory());
            //FixIcons(ctxFactory());
            //FixupTypeRefParents(ctxFactory());
            // PrintEagerLoadingGraphViz();
            // CreateTestFragebögen();
            //PrintControlKindTypes();
            //FixupCallImplementInterfaces(ctx);
            //RegenerateTypeRefs(ctxFactory());
        }

        //private static void ImportIcons(IKistlContext ctx)
        //{
        //    if (ctx == null) throw new ArgumentNullException("ctx");

        //    var kistlBase = ctx.FindPersistenceObject<Module>(NamedObjects.Module_KistlBase);

        //    foreach (var f in System.IO.Directory.GetFiles("C:\\temp\\Icons"))
        //    {
        //        var fi = new System.IO.FileInfo(f);
        //        var icon = ctx.Create<Icon>();
        //        icon.IconFile = System.IO.Path.GetFileName(f);
        //        icon.Module = kistlBase;
        //        icon.Blob = ctx.Find<Blob>(ctx.CreateBlob(fi, fi.GetMimeType()));
        //    }
        //    ctx.SubmitChanges();
        //}

        //private static string GetIconPath(string name)
        //{
        //    string result = @"P:\Kistl\DocumentStore\Client"
        //        + @"\GUI.Icons\"
        //        + name;
        //    result = System.IO.Path.IsPathRooted(result) ? result : Environment.CurrentDirectory + "\\" + result;
        //    return result;
        //}

        //private static void FixIcons(IKistlContext ctx)
        //{
        //    foreach(var i in ctx.GetQuery<Icon>().Where(i => i.Blob == null))
        //    {
        //        var fi = new System.IO.FileInfo(GetIconPath(i.IconFile));
        //        i.Blob = ctx.Find<Blob>(ctx.CreateBlob(fi, fi.GetMimeType()));
        //    }
        //    ctx.SubmitChanges();
        //}

        //private static void RegenerateTypeRefs(IKistlContext ctx)
        //{
        //    foreach (var a in ctx.GetQuery<Assembly>())
        //    {
        //        a.RegenerateTypeRefs();
        //        ctx.SubmitChanges();
        //    }
        //}

        //private static void FixupCallImplementInterfaces(Func<IKistlContext> ctxFactory)
        //{
        //    foreach (var objClass in ctx.GetQuery<ObjectClass>())
        //    {
        //        objClass.ImplementInterfaces();
        //    }
        //    ctx.SubmitChanges();
        //}
    }
}