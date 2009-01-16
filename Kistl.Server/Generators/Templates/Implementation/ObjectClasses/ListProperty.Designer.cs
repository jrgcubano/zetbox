using System;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst")]
    public partial class ListProperty : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected DataType containingType;
		protected Type type;
		protected String name;
		protected Property property;


        public ListProperty(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, DataType containingType, Type type, String name, Property property)
            : base(_host)
        {
			this.ctx = ctx;
			this.containingType = containingType;
			this.type = type;
			this.name = name;
			this.property = property;

        }
        
        public override void Generate()
        {
#line 12 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
this.WriteObjects("\r\n");
#line 19 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
ApplyRequisitesTemplate();
	
	ApplyAttributesTemplate();

    var backingName = MungeNameToBacking(name);

#line 25 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
this.WriteObjects("        ",  GetModifiers() , " ",  GetPropertyTypeString() , " ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("				if (",  backingName , " == null)\r\n");
this.WriteObjects("					",  backingName , " = ",  GetInitialisationExpression() , ";\r\n");
this.WriteObjects("                return ",  backingName , ";\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        private ",  GetBackingTypeString() , " ",  backingName , ";");

        }



    }
}