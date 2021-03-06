using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.App.Extensions;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.DalProvider.Ef.Generator.Templates.EfModel
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst")]
    public partial class ModelCsdlEntityTypeFields : Zetbox.Generator.ResourceTemplate
    {
		protected IZetboxContext ctx;
		protected IEnumerable<Property> properties;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, IEnumerable<Property> properties)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("EfModel.ModelCsdlEntityTypeFields", ctx, properties);
        }

        public ModelCsdlEntityTypeFields(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, IEnumerable<Property> properties)
            : base(_host)
        {
			this.ctx = ctx;
			this.properties = properties;

        }

        public override void Generate()
        {
#line 35 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
/*
	 * TODO: Actually, all this should die and become a bunch of polymorphic calls.
     * See also Zetbox.DalProvider.NHibernate.Generator.Templates.Mappings.PropertiesHbm
	 */

	foreach(var p in properties.OrderBy(p => p.Name))
	{
		// TODO: implement IsNullable everywhere
		if (p is ObjectReferenceProperty)
		{
		    var prop = p as ObjectReferenceProperty;
		    var rel = Zetbox.App.Extensions.RelationExtensions.Lookup(ctx, prop);
			var relEnd = rel.GetEnd(prop);
			var otherEnd = rel.GetOtherEnd(relEnd);
			
			if (rel.Storage == StorageType.Separate)
			{
				Debug.Assert(relEnd != null);

#line 54 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.Name + ImplementationPropertySuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  rel.GetRelationAssociationName(relEnd.GetRole()) , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  relEnd.RoleName , "\"\r\n");
this.WriteObjects("                        ToRole=\"CollectionEntry\" />\r\n");
#line 59 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
			else
			{

#line 63 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.Name + ImplementationPropertySuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  rel.GetAssociationName() , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  relEnd.RoleName , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  otherEnd.RoleName , "\" />\r\n");
#line 69 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
if (rel.NeedsPositionStorage(relEnd.GetRole()))
				{

#line 72 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <Property Name=\"",  Construct.ListPositionPropertyName(relEnd) , "\" Type=\"Int32\" Nullable=\"true\" />\r\n");
#line 74 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
			}
		}
		else if (p is ValueTypeProperty)
		{
			var prop = (ValueTypeProperty)p;
			if (prop.IsList && !prop.IsCalculated)
			{

#line 83 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  prop.Name + ImplementationPropertySuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  prop.GetAssociationName() , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  prop.ObjectClass.Name , "\"\r\n");
this.WriteObjects("                        ToRole=\"CollectionEntry\" />\r\n");
#line 88 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
			else
			{

#line 92 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    ",  ModelCsdl.PlainPropertyDefinitionFromValueType((ValueTypeProperty)p, p.Name, ImplementationPropertySuffix) , "\r\n");
#line 94 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
		}
		else if (p is CompoundObjectProperty)
		{
			var prop = (CompoundObjectProperty)p;
			if (prop.IsList)
			{

#line 102 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  prop.Name + ImplementationPropertySuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  prop.GetAssociationName() , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  prop.ObjectClass.Name , "\"\r\n");
this.WriteObjects("                        ToRole=\"CollectionEntry\" />\r\n");
#line 107 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
			else
			{
			// Nullable Complex types are not supported by EF

#line 112 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <Property Name=\"",  p.Name + ImplementationPropertySuffix , "\"\r\n");
this.WriteObjects("              Type=\"Model.",  prop.CompoundObjectDefinition.Name , "\"\r\n");
this.WriteObjects("              Nullable=\"false\" />\r\n");
#line 116 "P:\zetbox\Zetbox.DalProvider.EF.Generator\Templates\EfModel\Model.csdl.EntityTypeFields.cst"
}
		}	
	}


        }

    }
}