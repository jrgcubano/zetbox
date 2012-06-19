using System;
using System.Collections.Generic;
using System.Linq;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.Generator.InterfaceTemplates.CollectionEntries
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\zetbox\Zetbox.Generator\InterfaceTemplates\CollectionEntries\CollectionEntries.cst")]
    public partial class CollectionEntries : Zetbox.Generator.ResourceTemplate
    {
		protected IZetboxContext ctx;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("CollectionEntries.CollectionEntries", ctx);
        }

        public CollectionEntries(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }

        public override void Generate()
        {
#line 30 "P:\zetbox\Zetbox.Generator\InterfaceTemplates\CollectionEntries\CollectionEntries.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.Xml;\r\n");
this.WriteObjects("using System.Xml.Serialization;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Zetbox.API;\r\n");
this.WriteObjects("\r\n");
#line 41 "P:\zetbox\Zetbox.Generator\InterfaceTemplates\CollectionEntries\CollectionEntries.cst"
foreach (var rel in ctx.GetQuery<Relation>()
        .Where(r => r.Storage == StorageType.Separate)
        .ToList() // GetRelationClassName is not mapped
        .OrderBy(r => r.GetRelationClassName()))
    {
        ObjectCollectionEntry.Call(Host, ctx, rel);
    }


    foreach (var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
        .ToList() // NHibernate-on-linux workaround
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
    {
        ValueCollectionEntry.Call(Host, ctx, prop);
    }
    
    foreach (var prop in ctx.GetQuery<CompoundObjectProperty>()
        .Where(p => p.IsList) // && !p.IsCalculated
        .Where(p => p.ObjectClass is ObjectClass)
        .ToList() // NHibernate-on-linux workaround
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
    {
        ValueCollectionEntry.Call(Host, ctx, prop);
    }


        }

    }
}