using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Templates.CollectionEntries;
using Kistl.Generator.Extensions;


namespace Kistl.Generator.Templates.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst")]
    public partial class CollectionEntries : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("ObjectClasses.CollectionEntries", ctx);
        }

        public CollectionEntries(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }

        public override void Generate()
        {
#line 16 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.ComponentModel;\r\n");
this.WriteObjects("using System.Xml;\r\n");
this.WriteObjects("using System.Xml.Serialization;\r\n");
this.WriteObjects("using System.Linq;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("using Kistl.DalProvider.Base.RelationWrappers;\r\n");
#line 29 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
foreach(string ns in GetAdditionalImports().Distinct().OrderBy(s => s))
    {

#line 32 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("using ",  ns , ";\r\n");
#line 34 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
}

	foreach (var rel in ctx.GetQuery<Relation>()
	    .Where(r => r.Storage == StorageType.Separate)
	    .ToList()
	    .OrderBy(r => r.GetRelationClassName()))
	{


#line 43 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  rel.A.Type.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
#line 47 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
if (rel.A.Type.Module.Namespace != rel.B.Type.Module.Namespace)
		{

#line 50 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("	using ",  rel.B.Type.Module.Namespace , ";\r\n");
#line 52 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
}

		RelationEntry.Call(Host, ctx, rel);

#line 56 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 58 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
}

#line 61 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
foreach (var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
        .ToList() // NHibernate-on-linux workaround
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
	{


#line 70 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  prop.GetCollectionEntryNamespace() , "\r\n");
this.WriteObjects("{\r\n");
#line 74 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
ValueCollectionEntry.Call(Host, ctx, prop);

#line 76 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 78 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
}

#line 81 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
foreach (var prop in ctx.GetQuery<CompoundObjectProperty>()
        .Where(p => p.IsList) // && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
        .ToList() // NHibernate-on-linux workaround
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
	{

#line 89 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  prop.GetCollectionEntryNamespace() , "\r\n");
this.WriteObjects("{\r\n");
#line 93 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
ValueCollectionEntry.Call(Host, ctx, prop);

#line 95 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 97 "P:\Kistl\Kistl.Generator\Templates\ObjectClasses\CollectionEntries.cst"
}


        }

    }
}