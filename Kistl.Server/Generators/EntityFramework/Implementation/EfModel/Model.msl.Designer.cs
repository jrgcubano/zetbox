using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;
using Kistl.Server.Movables;


namespace Kistl.Server.Generators.EntityFramework.Implementation.EfModel
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst")]
    public partial class ModelMsl : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;


        public ModelMsl(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }
        
        public override void Generate()
        {
#line 16 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
this.WriteObjects("<Mapping Space=\"C-S\" xmlns=\"urn:schemas-microsoft-com:windows:storage:mapping:CS\">\r\n");
this.WriteObjects("  <EntityContainerMapping StorageEntityContainer=\"dbo\" CdmEntityContainer=\"Entities\">\r\n");
this.WriteObjects("    \r\n");
this.WriteObjects("    <!-- EntitySetMappings for classes -->\r\n");
#line 22 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
foreach(var cls in ctx.GetBaseClasses())
	{

#line 25 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    <EntitySetMapping Name=\"",  cls.ClassName , "\">\r\n");
#line 26 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
ApplyEntityTypeMapping(cls); 
#line 27 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    </EntitySetMapping>\r\n");
#line 29 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}

#line 31 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySetMappings and AssociationSetMappings for object-object relations with a CollectionEntry -->\r\n");
#line 35 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
foreach(var rel in NewRelation.GetAll(ctx)
        .Where(r => r.GetPreferredStorage() == StorageHint.Separate)
        .OrderBy(r => r.GetAssociationName()))
	{

#line 40 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    <!--\r\n");
#line 42 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
CallTemplate("Implementation.RelationDebugTemplate", ctx, rel);

#line 44 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    -->\r\n");
this.WriteObjects("    <EntitySetMapping Name=\"",  rel.GetCollectionEntryClassName() , "\">\r\n");
this.WriteObjects("      <EntityTypeMapping TypeName=\"IsTypeOf(Model.",  rel.GetCollectionEntryClassName() , ")\">\r\n");
this.WriteObjects("        <MappingFragment StoreEntitySet=\"",  rel.GetCollectionEntryClassName() , "\">\r\n");
this.WriteObjects("          <ScalarProperty Name=\"ID\" ColumnName=\"ID\" />\r\n");
#line 50 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
if (rel.A.HasPersistentOrder)
	{

#line 53 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("          <ScalarProperty Name=\"AIndex\" ColumnName=\"AIndex\" />\r\n");
#line 55 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}

	if (rel.B.HasPersistentOrder)
	{

#line 60 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("          <ScalarProperty Name=\"BIndex\" ColumnName=\"BIndex\" />\r\n");
#line 62 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}

#line 64 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("        </MappingFragment>\r\n");
this.WriteObjects("      </EntityTypeMapping>\r\n");
this.WriteObjects("    </EntitySetMapping>\r\n");
this.WriteObjects("    <!-- A to CollectionEntry -->\r\n");
this.WriteObjects("    <AssociationSetMapping Name=\"",  rel.GetCollectionEntryAssociationName(rel.A) , "\"\r\n");
this.WriteObjects("                           TypeName=\"Model.",  rel.GetCollectionEntryAssociationName(rel.A) , "\"\r\n");
this.WriteObjects("                           StoreEntitySet=\"",  rel.GetCollectionEntryClassName() , "\" >\r\n");
this.WriteObjects("      <EndProperty Name=\"",  rel.A.RoleName , "\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"fk_A\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <EndProperty Name=\"CollectionEntry\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"ID\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <Condition ColumnName=\"fk_A\" IsNull=\"false\"/>\r\n");
this.WriteObjects("    </AssociationSetMapping>\r\n");
this.WriteObjects("    <!-- B to CollectionEntry -->\r\n");
this.WriteObjects("    <AssociationSetMapping Name=\"",  rel.GetCollectionEntryAssociationName(rel.B) , "\"\r\n");
this.WriteObjects("                           TypeName=\"Model.",  rel.GetCollectionEntryAssociationName(rel.B) , "\"\r\n");
this.WriteObjects("                           StoreEntitySet=\"",  rel.GetCollectionEntryClassName() , "\" >\r\n");
this.WriteObjects("      <EndProperty Name=\"",  rel.B.RoleName , "\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"fk_B\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <EndProperty Name=\"CollectionEntry\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"ID\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <Condition ColumnName=\"fk_B\" IsNull=\"false\"/>\r\n");
this.WriteObjects("    </AssociationSetMapping>\r\n");
this.WriteObjects("\r\n");
#line 93 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}
	

#line 96 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- AssociationSetMappings for direct object-object relations without a CollectionEntry -->\r\n");
#line 100 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
foreach(var rel in NewRelation.GetAll(ctx)
        .Where(r => r.GetPreferredStorage() != StorageHint.Separate)
        .OrderBy(r => r.GetAssociationName()))
	{
		RelationEnd principal, dependent;
	
		switch(rel.GetPreferredStorage())
		{
			case StorageHint.MergeA:
				principal = rel.B;
				dependent = rel.A;
				break;
			case StorageHint.MergeB:
				principal = rel.A;
				dependent = rel.B;
				break;
			default:
				throw new NotImplementedException();
		}

#line 120 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    <!--\r\n");
#line 122 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
CallTemplate("Implementation.RelationDebugTemplate", ctx, rel);

#line 124 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    -->\r\n");
this.WriteObjects("    <AssociationSetMapping Name=\"",  rel.GetAssociationName() , "\"\r\n");
this.WriteObjects("                           TypeName=\"Model.",  rel.GetAssociationName() , "\"\r\n");
this.WriteObjects("                           StoreEntitySet=\"",  dependent.Type.ClassName , "\" >\r\n");
this.WriteObjects("      <EndProperty Name=\"",  principal.RoleName , "\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"fk_",  principal.RoleName , "\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <EndProperty Name=\"",  dependent.RoleName , "\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"ID\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <Condition ColumnName=\"fk_",  principal.RoleName , "\" IsNull=\"false\"/>\r\n");
this.WriteObjects("    </AssociationSetMapping>\r\n");
#line 137 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}
	

#line 140 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySetMappings and AssociationSetMappings for ValueType lists -->\r\n");
#line 143 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
foreach(var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList)
        .OrderBy(p => p.ObjectClass.ClassName)
        .OrderBy(p => p.PropertyName))
	{ 

#line 149 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("    <EntitySetMapping Name=\"",  prop.GetCollectionEntryClassName() , "\">\r\n");
this.WriteObjects("      <EntityTypeMapping TypeName=\"IsTypeOf(Model.",  prop.GetCollectionEntryClassName() , ")\">\r\n");
this.WriteObjects("        <MappingFragment StoreEntitySet=\"",  prop.GetCollectionEntryClassName() , "\">\r\n");
this.WriteObjects("          <ScalarProperty Name=\"ID\" ColumnName=\"ID\" />\r\n");
this.WriteObjects("          <ScalarProperty Name=\"",  prop.PropertyName , "\" ColumnName=\"",  prop.PropertyName , "\" />\r\n");
#line 155 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
if (prop.IsIndexed)
	{

#line 158 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("          <ScalarProperty Name=\"BIndex\" ColumnName=\"BIndex\" />\r\n");
#line 160 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}

#line 162 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("        </MappingFragment>\r\n");
this.WriteObjects("      </EntityTypeMapping>\r\n");
this.WriteObjects("    </EntitySetMapping>\r\n");
this.WriteObjects("    <AssociationSetMapping Name=\"",  prop.GetAssociationName() , "\"\r\n");
this.WriteObjects("                           TypeName=\"Model.",  prop.GetAssociationName() , "\"\r\n");
this.WriteObjects("                           StoreEntitySet=\"",  prop.GetCollectionEntryClassName() , "\" >\r\n");
this.WriteObjects("      <EndProperty Name=\"",  prop.ObjectClass.ClassName , "\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"fk_",  prop.ObjectClass.ClassName , "\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <EndProperty Name=\"CollectionEntry\">\r\n");
this.WriteObjects("        <ScalarProperty Name=\"ID\" ColumnName=\"ID\"/>\r\n");
this.WriteObjects("      </EndProperty>\r\n");
this.WriteObjects("      <Condition ColumnName=\"fk_",  prop.ObjectClass.ClassName , "\" IsNull=\"false\"/>\r\n");
this.WriteObjects("    </AssociationSetMapping>\r\n");
#line 177 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
}
	

#line 180 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\EfModel\Model.msl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("  </EntityContainerMapping>\r\n");
this.WriteObjects("</Mapping>");

        }



    }
}