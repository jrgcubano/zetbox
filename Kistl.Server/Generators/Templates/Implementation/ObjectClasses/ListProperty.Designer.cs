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
		protected SerializationMembersList serializationList;
		protected DataType containingType;
		protected String name;
		protected Property property;


        public ListProperty(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializationMembersList serializationList, DataType containingType, String name, Property property)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.containingType = containingType;
			this.name = name;
			this.property = property;

        }
        
        public override void Generate()
        {
#line 17 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
ApplyAttributesTemplate();

	var backingName = BackingMemberFromName(name);

#line 21 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
this.WriteObjects("   		// ",  this.GetType() , "\r\n");
this.WriteObjects("        ",  GetModifiers() , " ",  GetPropertyTypeString() , " ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (",  backingName , " == null)\r\n");
this.WriteObjects("                    ",  backingName , " = ",  GetInitialisationExpression() , ";\r\n");
this.WriteObjects("                return ",  backingName , ";\r\n");
this.WriteObjects("            }\r\n");
#line 31 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
ApplySettor();

#line 33 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
this.WriteObjects("        }\r\n");
this.WriteObjects("        private ",  GetBackingTypeString() , " ",  backingName , ";\r\n");
#line 36 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ListProperty.cst"
AddSerialization(serializationList, name);


	ApplyRequisitesTemplate();


        }



    }
}