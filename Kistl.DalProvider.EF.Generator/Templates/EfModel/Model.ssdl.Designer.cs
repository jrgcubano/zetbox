using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.DalProvider.Ef.Generator.Templates.EfModel
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst")]
    public partial class ModelSsdl : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected ISchemaProvider schemaProvider;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ISchemaProvider schemaProvider)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("EfModel.ModelSsdl", ctx, schemaProvider);
        }

        public ModelSsdl(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ISchemaProvider schemaProvider)
            : base(_host)
        {
			this.ctx = ctx;
			this.schemaProvider = schemaProvider;

        }

        public override void Generate()
        {
#line 17 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
this.WriteObjects("<Schema xmlns=\"http://schemas.microsoft.com/ado/2006/04/edm/ssdl\"\r\n");
this.WriteObjects("        Namespace=\"Model.Store\"\r\n");
this.WriteObjects("        Alias=\"Self\"\r\n");
this.WriteObjects("        Provider=\"",  schemaProvider.AdoNetProvider , "\"\r\n");
this.WriteObjects("        ProviderManifestToken=\"",  schemaProvider.ManifestToken , "\" >\r\n");
this.WriteObjects("  <EntityContainer Name=\"dbo\">\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySets for all Base Classes -->\r\n");
#line 27 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var cls in ctx.GetBaseClasses().OrderBy(c => c.Name))
	{

#line 30 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntitySet Name=\"",  cls.Name , "\" EntityType=\"Model.Store.",  cls.Name , "\" Table=\"",  cls.TableName , "\"/>\r\n");
#line 32 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (cls.NeedsRightsTable())
		{

#line 35 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntitySet Name=\"",  Construct.SecurityRulesClassName(cls) , "\" EntityType=\"Model.Store.",  Construct.SecurityRulesClassName(cls) , "\" Table=\"",  Construct.SecurityRulesTableName(cls) , "\"/>\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  Construct.SecurityRulesFKName(cls) , "\" Association=\"Model.Store.",  Construct.SecurityRulesFKName(cls) , "\">\r\n");
this.WriteObjects("      <End Role=\"",  cls.Name , "\" EntitySet=\"",  cls.Name , "\" />\r\n");
this.WriteObjects("      <End Role=\"",  Construct.SecurityRulesClassName(cls) , "\" EntitySet=\"",  Construct.SecurityRulesClassName(cls) , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
#line 41 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}
	}

#line 44 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySets for all derived classes and their inheritance AssociationSets -->\r\n");
#line 47 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var cls in ctx.GetDerivedClasses().OrderBy(c => c.Name))
	{
		var info = new InheritanceStorageAssociationInfo(cls);

#line 51 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntitySet Name=\"",  cls.Name , "\" EntityType=\"Model.Store.",  cls.Name , "\" Table=\"",  cls.TableName , "\"/>\r\n");
this.WriteObjects("    <!-- inherits from ",  info.ParentEntitySetName , " -->\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  info.AssociationName , "\" Association=\"Model.Store.",  info.AssociationName , "\" >\r\n");
this.WriteObjects("      <End Role=\"",  info.ParentRoleName , "\" EntitySet=\"",  info.ParentEntitySetName , "\" />\r\n");
this.WriteObjects("      <End Role=\"",  info.ChildRoleName , "\" EntitySet=\"",  info.ChildEntitySetName , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
#line 58 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 60 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySets and AssociationSet for all object-object CollectionEntrys -->\r\n");
#line 63 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var rel in ctx.GetRelationsWithSeparateStorage())
	{
		string assocNameA = rel.GetRelationAssociationName(RelationEndRole.A);
		string assocNameB = rel.GetRelationAssociationName(RelationEndRole.B);
		string esName = rel.GetRelationClassName();
		string esTableName = rel.GetRelationTableName();
		

#line 71 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <!-- \r\n");
#line 73 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
RelationDebugTemplate.Call(Host, ctx, rel);

#line 75 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    -->\r\n");
this.WriteObjects("    <EntitySet Name=\"",  esName , "\" EntityType=\"Model.Store.",  esName , "\" Table=\"",  esTableName , "\" />\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  assocNameA , "\" Association=\"Model.Store.",  assocNameA , "\" >\r\n");
this.WriteObjects("      <End Role=\"",  rel.A.RoleName , "\" EntitySet=\"",  rel.A.Type.Name , "\" />\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" EntitySet=\"",  esName , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  assocNameB , "\" Association=\"Model.Store.",  assocNameB , "\" >\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" EntitySet=\"",  esName , "\" />\r\n");
this.WriteObjects("      <End Role=\"",  rel.B.RoleName , "\" EntitySet=\"",  rel.B.Type.Name , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
this.WriteObjects("    \r\n");
#line 87 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 89 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- AssociationSets for all object-object relations which do not need CollectionEntrys -->\r\n");
#line 93 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach (var rel in ctx.GetRelationsWithoutSeparateStorage())
	{
		string assocName = rel.GetAssociationName();
		

#line 98 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <AssociationSet Name=\"",  assocName , "\" Association=\"Model.Store.",  assocName , "\" >\r\n");
this.WriteObjects("      <End Role=\"",  rel.A.RoleName , "\" EntitySet=\"",  rel.A.Type.Name , "\" />\r\n");
this.WriteObjects("      <End Role=\"",  rel.B.RoleName , "\" EntitySet=\"",  rel.B.Type.Name , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
#line 103 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 105 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySets and AssociationSet for all object-value CollectionEntrys -->\r\n");
#line 108 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.Name))
	{
		string assocName = prop.GetAssociationName();
		string esName = prop.GetCollectionEntryClassName();

#line 117 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntitySet Name=\"",  esName , "\" EntityType=\"Model.Store.",  esName , "\" Table=\"",  prop.GetCollectionEntryTable() , "\" />\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  assocName , "\" Association=\"Model.Store.",  assocName , "\" >\r\n");
this.WriteObjects("      <End Role=\"",  prop.ObjectClass.Name , "\" EntitySet=\"",  prop.ObjectClass.Name , "\" />\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" EntitySet=\"",  esName , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
this.WriteObjects("    \r\n");
#line 124 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 126 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntitySets and AssociationSet for all object-struct CollectionEntrys -->\r\n");
#line 129 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var prop in ctx.GetQuery<CompoundObjectProperty>()
        .Where(p => p.IsList) // && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.Name))
	{
		string assocName = prop.GetAssociationName();
		string esName = prop.GetCollectionEntryClassName();

#line 138 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntitySet Name=\"",  esName , "\" EntityType=\"Model.Store.",  esName , "\" Table=\"",  prop.GetCollectionEntryTable() , "\" />\r\n");
this.WriteObjects("    <AssociationSet Name=\"",  assocName , "\" Association=\"Model.Store.",  assocName , "\" >\r\n");
this.WriteObjects("      <End Role=\"",  prop.ObjectClass.Name , "\" EntitySet=\"",  prop.ObjectClass.Name , "\" />\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" EntitySet=\"",  esName , "\" />\r\n");
this.WriteObjects("    </AssociationSet>\r\n");
this.WriteObjects("    \r\n");
#line 145 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 147 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  </EntityContainer>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- EntityTypes for all classes -->\r\n");
#line 153 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var cls in ctx.GetQuery<ObjectClass>()
		.OrderBy(cls => cls.Name))
	{

#line 156 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("	\r\n");
this.WriteObjects("  <EntityType Name=\"",  cls.Name , "\">\r\n");
this.WriteObjects("    <Key>\r\n");
this.WriteObjects("      <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("    </Key>\r\n");
this.WriteObjects("    <Property Name=\"ID\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" ",  (cls.BaseObjectClass == null) ? "StoreGeneratedPattern=\"Identity\" " : String.Empty , "/>\r\n");
#line 163 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
ApplyEntityTypeColumnDefs(cls);

#line 165 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("  </EntityType>\r\n");
#line 167 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (cls.NeedsRightsTable())
		{

#line 170 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntityType Name=\"",  Construct.SecurityRulesClassName(cls) , "\">\r\n");
this.WriteObjects("      <Key>\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("        <PropertyRef Name=\"Identity\" />\r\n");
this.WriteObjects("      </Key>\r\n");
this.WriteObjects("      <Property Name=\"ID\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" />\r\n");
this.WriteObjects("      <Property Name=\"Identity\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" />\r\n");
this.WriteObjects("      <Property Name=\"Right\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" />\r\n");
this.WriteObjects("    </EntityType>\r\n");
this.WriteObjects("    <Association Name=\"",  Construct.SecurityRulesFKName(cls) , "\">\r\n");
this.WriteObjects("      <End Role=\"",  cls.Name , "\" Type=\"Model.Store.",  cls.Name , "\" Multiplicity=\"1\" />\r\n");
this.WriteObjects("      <End Role=\"",  Construct.SecurityRulesClassName(cls) , "\" Type=\"Model.Store.",  Construct.SecurityRulesClassName(cls) , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("      <ReferentialConstraint>\r\n");
this.WriteObjects("        <Principal Role=\"",  cls.Name , "\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("        </Principal>\r\n");
this.WriteObjects("        <Dependent Role=\"",  Construct.SecurityRulesClassName(cls) , "\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("        </Dependent>\r\n");
this.WriteObjects("      </ReferentialConstraint>\r\n");
this.WriteObjects("    </Association>\r\n");
#line 192 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

	}

#line 196 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- EntityTypes for all object-object CollectionEntrys with their associations -->\r\n");
#line 199 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var rel in ctx.GetRelationsWithSeparateStorage())
	{
		string ceName = rel.GetRelationClassName();
		string fkAName = rel.GetRelationFkColumnName(RelationEndRole.A);
		string fkBName = rel.GetRelationFkColumnName(RelationEndRole.B);

#line 204 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("	\r\n");
this.WriteObjects("  <EntityType Name=\"",  ceName , "\">\r\n");
this.WriteObjects("    <Key>\r\n");
this.WriteObjects("      <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("    </Key>\r\n");
this.WriteObjects("    <Property Name=\"ID\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" StoreGeneratedPattern=\"Identity\" />\r\n");
#line 211 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (rel.A.Type.ImplementsIExportable() && rel.B.Type.ImplementsIExportable())
		{

#line 214 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("	<Property Name=\"ExportGuid\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Guid) , "\" Nullable=\"false\" />\r\n");
#line 216 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 218 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  fkAName , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 220 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (rel.NeedsPositionStorage(RelationEndRole.A))
		{

#line 223 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  fkAName , "",  Kistl.API.Helper.PositionSuffix , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 225 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 227 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  fkBName , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 229 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (rel.NeedsPositionStorage(RelationEndRole.B))
		{

#line 232 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  fkBName , "",  Kistl.API.Helper.PositionSuffix , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 234 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 236 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("  </EntityType>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- A to CollectionEntry -->\r\n");
this.WriteObjects("  <Association Name=\"",  rel.GetRelationAssociationName(RelationEndRole.A) , "\">\r\n");
this.WriteObjects("    <End Role=\"",  rel.A.RoleName , "\" Type=\"Model.Store.",  rel.A.Type.Name , "\" Multiplicity=\"0..1\" />\r\n");
this.WriteObjects("    <End Role=\"CollectionEntry\" Type=\"Model.Store.",  ceName , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("    <ReferentialConstraint>\r\n");
this.WriteObjects("      <Principal Role=\"",  rel.A.RoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Principal>\r\n");
this.WriteObjects("      <Dependent Role=\"CollectionEntry\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"",  fkAName , "\" />\r\n");
this.WriteObjects("      </Dependent>\r\n");
this.WriteObjects("    </ReferentialConstraint>\r\n");
this.WriteObjects("  </Association>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- B to CollectionEntry -->\r\n");
this.WriteObjects("  <Association Name=\"",  rel.GetRelationAssociationName(RelationEndRole.B) , "\">\r\n");
this.WriteObjects("    <End Role=\"",  rel.B.RoleName , "\" Type=\"Model.Store.",  rel.B.Type.Name , "\" Multiplicity=\"0..1\" />\r\n");
this.WriteObjects("    <End Role=\"CollectionEntry\" Type=\"Model.Store.",  ceName , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("    <ReferentialConstraint>\r\n");
this.WriteObjects("      <Principal Role=\"",  rel.B.RoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Principal>\r\n");
this.WriteObjects("      <Dependent Role=\"CollectionEntry\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"",  fkBName , "\" />\r\n");
this.WriteObjects("      </Dependent>\r\n");
this.WriteObjects("    </ReferentialConstraint>\r\n");
this.WriteObjects("  </Association>\r\n");
this.WriteObjects("\r\n");
#line 267 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 269 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- Associations for all object-object relations without CollectionEntry (1:1, 1:N) -->\r\n");
#line 273 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var rel in ctx.GetRelationsWithoutSeparateStorage())
	{
		RelationEnd principal, dependent;
	
		switch(rel.Storage)
		{
			case StorageType.MergeIntoA:
				principal = rel.B;
				dependent = rel.A;
				break;
			case StorageType.MergeIntoB:
				principal = rel.A;
				dependent = rel.B;
				break;
			default:
				throw new NotImplementedException();
		}

#line 291 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("  <Association Name=\"",  rel.GetAssociationName() , "\">\r\n");
this.WriteObjects("    <End Role=\"",  principal.RoleName , "\" Type=\"Model.Store.",  principal.Type.Name , "\" Multiplicity=\"",  principal.Multiplicity.ToSsdlMultiplicity().ToXmlValue() , "\" />\r\n");
this.WriteObjects("    <End Role=\"",  dependent.RoleName , "\" Type=\"Model.Store.",  dependent.Type.Name , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("    <ReferentialConstraint>\r\n");
this.WriteObjects("      <Principal Role=\"",  principal.RoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Principal>\r\n");
this.WriteObjects("      <Dependent Role=\"",  dependent.RoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"fk_",  principal.RoleName , "\" />\r\n");
this.WriteObjects("      </Dependent>\r\n");
this.WriteObjects("    </ReferentialConstraint>\r\n");
this.WriteObjects("  </Association>\r\n");
this.WriteObjects("\r\n");
#line 306 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 308 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("  <!-- derived->base ObjectClass references -->\r\n");
#line 312 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var cls in ctx.GetDerivedClasses().OrderBy(c => c.Name))
	{
		var parentType = cls.BaseObjectClass;
		var childType = cls;
		
		string parentRoleName = Construct.AssociationParentRoleName(parentType);
		string childRoleName = Construct.AssociationChildRoleName(childType);

#line 320 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("  <Association Name=\"",  Construct.InheritanceAssociationName(parentType, childType) , "\">\r\n");
this.WriteObjects("    <End Role=\"",  parentRoleName , "\" Type=\"Model.Store.",  parentType.Name , "\" Multiplicity=\"1\" />\r\n");
this.WriteObjects("    <End Role=\"",  childRoleName , "\" Type=\"Model.Store.",  childType.Name , "\" Multiplicity=\"0..1\" />\r\n");
this.WriteObjects("    <ReferentialConstraint>\r\n");
this.WriteObjects("      <Principal Role=\"",  parentRoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Principal>\r\n");
this.WriteObjects("      <Dependent Role=\"",  childRoleName , "\">\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Dependent>\r\n");
this.WriteObjects("    </ReferentialConstraint>\r\n");
this.WriteObjects("  </Association>\r\n");
#line 332 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 334 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntityTypes and Associations for all object-value CollectionEntrys -->\r\n");
#line 338 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var prop in ctx.GetQuery<ValueTypeProperty>()
		.Where(p => p.IsList && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.Name))
	{
		string assocName = prop.GetAssociationName();
		
		// the name of the class containing this list
		string containerTypeName = prop.ObjectClass.Name;
		// the name of the CollectionEntry class
		string entryTypeName = prop.GetCollectionEntryClassName();
		// the name of the contained type
		string itemTypeName = schemaProvider.DbTypeToNative(DbTypeMapper.GetDbTypeForProperty(prop.GetType()));
		
		string constraint = String.Empty;
		if (prop is StringProperty) {
			var sProp = (StringProperty)prop;
			constraint += String.Format("MaxLength=\"{0}\" ", sProp.GetMaxLength());
		}
		if (prop is DecimalProperty) {
			var dProp = (DecimalProperty)prop;
			constraint += String.Format("Precision=\"{0}\" Scale=\"{1}\" ", dProp.Precision, dProp.Scale);
		}


#line 364 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntityType Name=\"",  entryTypeName , "\" >\r\n");
this.WriteObjects("      <Key>\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Key>\r\n");
this.WriteObjects("      <Property Name=\"ID\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" StoreGeneratedPattern=\"Identity\" />\r\n");
this.WriteObjects("      <Property Name=\"fk_",  containerTypeName , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
this.WriteObjects("      <Property Name=\"",  prop.Name , "\" Type=\"",  itemTypeName , "\" ",  constraint , "/>\r\n");
#line 372 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (prop.HasPersistentOrder)
		{

#line 375 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  prop.Name , "Index\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 377 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 379 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    </EntityType>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <Association Name=\"",  prop.GetAssociationName() , "\">\r\n");
this.WriteObjects("      <End Role=\"",  containerTypeName , "\" Type=\"Model.Store.",  containerTypeName , "\" Multiplicity=\"0..1\">\r\n");
this.WriteObjects("        <OnDelete Action=\"Cascade\" />\r\n");
this.WriteObjects("      </End>\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" Type=\"Model.Store.",  entryTypeName , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("      <ReferentialConstraint>\r\n");
this.WriteObjects("        <Principal Role=\"",  containerTypeName , "\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("        </Principal>\r\n");
this.WriteObjects("        <Dependent Role=\"CollectionEntry\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"fk_",  containerTypeName , "\" />\r\n");
this.WriteObjects("        </Dependent>\r\n");
this.WriteObjects("      </ReferentialConstraint>\r\n");
this.WriteObjects("    </Association>\r\n");
this.WriteObjects("\r\n");
#line 397 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 399 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    <!-- EntityTypes and Associations for all object-struct CollectionEntrys -->\r\n");
#line 402 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
foreach(var prop in ctx.GetQuery<CompoundObjectProperty>()
		.Where(p => p.IsList) // && !p.IsCalculated)
        .Where(p => p.ObjectClass is ObjectClass)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.Name))
	{
		string assocName = prop.GetAssociationName();
		
		// the name of the class containing this list
		string containerTypeName = prop.ObjectClass.Name;
		// the name of the CollectionEntry class
		string entryTypeName = prop.GetCollectionEntryClassName();

#line 415 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <EntityType Name=\"",  entryTypeName , "\" >\r\n");
this.WriteObjects("      <Key>\r\n");
this.WriteObjects("        <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("      </Key>\r\n");
this.WriteObjects("      <Property Name=\"ID\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"false\" StoreGeneratedPattern=\"Identity\" />\r\n");
this.WriteObjects("      <Property Name=\"fk_",  containerTypeName , "\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 422 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
ApplyEntityTypeColumnDefs(prop);

#line 425 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
if (prop.HasPersistentOrder)
		{

#line 428 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    <Property Name=\"",  prop.Name , "Index\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Nullable=\"true\" />\r\n");
#line 430 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 432 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("    </EntityType>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    <Association Name=\"",  prop.GetAssociationName() , "\">\r\n");
this.WriteObjects("      <End Role=\"",  containerTypeName , "\" Type=\"Model.Store.",  containerTypeName , "\" Multiplicity=\"0..1\">\r\n");
this.WriteObjects("        <OnDelete Action=\"Cascade\" />\r\n");
this.WriteObjects("      </End>\r\n");
this.WriteObjects("      <End Role=\"CollectionEntry\" Type=\"Model.Store.",  entryTypeName , "\" Multiplicity=\"*\" />\r\n");
this.WriteObjects("      <ReferentialConstraint>\r\n");
this.WriteObjects("        <Principal Role=\"",  containerTypeName , "\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"ID\" />\r\n");
this.WriteObjects("        </Principal>\r\n");
this.WriteObjects("        <Dependent Role=\"CollectionEntry\">\r\n");
this.WriteObjects("          <PropertyRef Name=\"fk_",  containerTypeName , "\" />\r\n");
this.WriteObjects("        </Dependent>\r\n");
this.WriteObjects("      </ReferentialConstraint>\r\n");
this.WriteObjects("    </Association>\r\n");
this.WriteObjects("\r\n");
#line 450 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
}

#line 452 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\EfModel\Model.ssdl.cst"
this.WriteObjects("	<Function Name=\"GetContinuousSequenceNumber\" Aggregate=\"false\" BuiltIn=\"false\" NiladicFunction=\"false\" IsComposable=\"false\" ParameterTypeSemantics=\"AllowImplicitConversion\" Schema=\"dbo\">\r\n");
this.WriteObjects("          <Parameter Name=\"seqNumber\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Guid) , "\" Mode=\"In\" />\r\n");
this.WriteObjects("		  <Parameter Name=\"result\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Mode=\"Out\" />\r\n");
this.WriteObjects("    </Function>\r\n");
this.WriteObjects("    <Function Name=\"GetSequenceNumber\" Aggregate=\"false\" BuiltIn=\"false\" NiladicFunction=\"false\" IsComposable=\"false\" ParameterTypeSemantics=\"AllowImplicitConversion\" Schema=\"dbo\">\r\n");
this.WriteObjects("        <Parameter Name=\"seqNumber\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Guid) , "\" Mode=\"In\" />\r\n");
this.WriteObjects("		<Parameter Name=\"result\" Type=\"",  schemaProvider.DbTypeToNative(DbType.Int32) , "\" Mode=\"Out\" />\r\n");
this.WriteObjects("    </Function>\r\n");
this.WriteObjects("</Schema>");

        }

    }
}