using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;
using Kistl.Server.GeneratorsOld;


namespace Kistl.Server.Generators.EntityFramework.Server.EfModel
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst")]
    public partial class ModelCsdlEntityTypeFields : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IEnumerable<Property> properties;


        public ModelCsdlEntityTypeFields(Arebis.CodeGeneration.IGenerationHost _host, IEnumerable<Property> properties)
            : base(_host)
        {
			this.properties = properties;

        }
        
        public override void Generate()
        {
#line 18 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
/*
	 * TODO: Actually, all this should die and become a bunch of polymorphic calls.
	 */

	foreach(var p in properties)
	{
		// TODO: implement IsNullable everywhere
		if (p.IsObjectReferencePropertyList() && !p.HasStorage())
		{
            // BackReferenceProperty
			TypeMoniker parentType = p.ObjectClass.GetTypeMoniker();
			TypeMoniker childType = Construct.AssociationChildType((Property)p);

#line 31 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  Construct.AssociationName(parentType, childType, ((ObjectReferenceProperty)p).GetOpposite().PropertyName) , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  Construct.AssociationParentRoleName(parentType) , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  Construct.AssociationChildRoleName(childType) , "\" />\r\n");
#line 36 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		else if (p.IsObjectReferencePropertyList() && p.HasStorage())
		{
			// ObjectReferenceProperty List
			TypeMoniker parentType = p.ObjectClass.GetTypeMoniker();
			TypeMoniker childType = Construct.PropertyCollectionEntryType((ObjectReferenceProperty)p);

#line 43 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  Construct.AssociationName(parentType, childType, "fk_Parent") , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  Construct.AssociationParentRoleName(parentType) , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  Construct.AssociationChildRoleName(childType) , "\" />\r\n");
#line 48 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		else if (p.IsObjectReferencePropertySingle() && p.HasStorage())
		{
			// ObjectReferenceProperty
			TypeMoniker parentType = new TypeMoniker(p.GetPropertyTypeString());
			TypeMoniker childType = Construct.AssociationChildType(p as ObjectReferenceProperty);

#line 55 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  Construct.AssociationName(parentType, childType, p.PropertyName) , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  Construct.AssociationChildRoleName(childType) , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  Construct.AssociationParentRoleName(parentType) , "\" />\r\n");
#line 60 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
if (p.NeedsPositionColumn())
			{

#line 63 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <Property Name=\"",  p.PropertyName + Kistl.API.Helper.PositionSuffix , "\" Type=\"Int32\" Nullable=\"true\" />\r\n");
#line 65 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		}
		else if (p.IsObjectReferencePropertySingle() && !p.HasStorage())
		{
			// ObjectReferenceProperty
			TypeMoniker parentType = p.ObjectClass.GetTypeMoniker();
			TypeMoniker childType = new TypeMoniker(p.GetPropertyTypeString());

#line 73 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  Construct.AssociationName(parentType, childType, ((ObjectReferenceProperty)p).GetOpposite().PropertyName) , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  Construct.AssociationParentRoleName(parentType) , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  Construct.AssociationChildRoleName(childType) , "\" />\r\n");
#line 78 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		else if (p.IsValueTypePropertySingle())
		{
			// ValueTypeProperty
			string name = p.PropertyName;
			string type = p.GetPropertyTypeString();
			string maxlength = "";
			
			if (p is EnumerationProperty)
			{
				name += Kistl.API.Helper.ImplementationSuffix;
				type = "Int32";
			}
			else
			{
				// translate to short name
				type = Type.GetType(type).Name;
			}

			if (p is StringProperty)
			{
				maxlength = String.Format("MaxLength=\"{0}\" ",((StringProperty)p).Length.ToString());
			}


#line 103 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <Property Name=\"",  name , "\" Type=\"",  type , "\" Nullable=\"",  ((ValueTypeProperty)p).IsNullable.ToString().ToLowerInvariant() , "\" ",  maxlength , "/>\r\n");
#line 105 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		else if (p.IsValueTypePropertyList())
		{
			// ValueTypeProperty List
			TypeMoniker parentType = p.ObjectClass.GetTypeMoniker();
			TypeMoniker childType = Construct.PropertyCollectionEntryType((ValueTypeProperty)p);

#line 112 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <NavigationProperty Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("                        Relationship=\"Model.",  Construct.AssociationName(parentType, childType, "fk_Parent") , "\"\r\n");
this.WriteObjects("                        FromRole=\"",  Construct.AssociationParentRoleName(parentType) , "\"\r\n");
this.WriteObjects("                        ToRole=\"",  Construct.AssociationChildRoleName(childType) , "\" />\r\n");
#line 117 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}
		else if (p.IsStructPropertySingle())
		{
			// ValueTypeProperty
			// Nullable Complex types are not supported by EF

#line 123 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
this.WriteObjects("    <Property Name=\"",  p.PropertyName + Kistl.API.Helper.ImplementationSuffix , "\"\r\n");
this.WriteObjects("              Type=\"Model.",  ((StructProperty)p).StructDefinition.ClassName , "\"\r\n");
this.WriteObjects("              Nullable=\"false\" />\r\n");
#line 127 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Server\EfModel\Model.csdl.EntityTypeFields.cst"
}	
	}


        }



    }
}