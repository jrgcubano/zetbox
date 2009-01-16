using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.EntityFramework.Implementation.EfModel
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.EntityTypeMapping.cst")]
    public partial class ModelMslEntityTypeMapping : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected ObjectClass cls;


        public ModelMslEntityTypeMapping(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ObjectClass cls)
            : base(_host)
        {
			this.ctx = ctx;
			this.cls = cls;

        }
        
        public override void Generate()
        {
#line 16 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.EntityTypeMapping.cst"
this.WriteObjects("      <EntityTypeMapping TypeName=\"IsTypeOf(Model.",  cls.ClassName , ")\">\r\n");
this.WriteObjects("	    <MappingFragment StoreEntitySet=\"",  cls.ClassName , "\">\r\n");
this.WriteObjects("	      <ScalarProperty Name=\"ID\" ColumnName=\"ID\" />\r\n");
#line 20 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.EntityTypeMapping.cst"
foreach(var prop in cls.Properties.OfType<Property>().Where(p => !p.IsList))
		{
			ApplyScalarProperty(prop, "");
		}

		foreach(var prop in cls.Properties.OfType<StructProperty>().Where(p => !p.IsList))
		{
			ApplyComplexProperty(prop, "");
		}

#line 30 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.EntityTypeMapping.cst"
this.WriteObjects("	    </MappingFragment>\r\n");
this.WriteObjects("      </EntityTypeMapping>\r\n");
#line 33 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.EntityTypeMapping.cst"
foreach(var subCls in cls.SubClasses)
	{
		ApplyEntityTypeMapping(subCls);	
	}


        }



    }
}