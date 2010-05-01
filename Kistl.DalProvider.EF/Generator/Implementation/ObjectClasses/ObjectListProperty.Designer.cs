using System;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst")]
    public partial class ObjectListProperty : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Kistl.Server.Generators.Templates.Implementation.SerializationMembersList serializationList;
		protected Relation rel;
		protected RelationEndRole endRole;


        public ObjectListProperty(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Kistl.Server.Generators.Templates.Implementation.SerializationMembersList serializationList, Relation rel, RelationEndRole endRole)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.rel = rel;
			this.endRole = endRole;

        }
        
        public override void Generate()
        {
#line 17 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
RelationEnd relEnd = rel.GetEndFromRole(endRole);
    RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

	// the name of the property to create
	string name = relEnd.Navigator.Name;
	// the ef-visible property's name
	string efName = name + Kistl.API.Helper.ImplementationSuffix;
	// the name of the private backing store for the conversion wrapper list
	string wrapperName = "_" + name + "Wrapper";
	// the name of the wrapper class for wrapping the EntityCollection
	string wrapperClass = rel.NeedsPositionStorage(otherEnd.GetRole()) ? "EntityListWrapper" : "EntityCollectionWrapper";
	// the name of the position property as string argument
	string positionPropertyNameArgument = rel.NeedsPositionStorage(otherEnd.GetRole()) ? String.Format(@", ""{0}""", Construct.ListPositionPropertyName(otherEnd)) : String.Empty;
	
	// the name of the EF association
	string assocName = rel.GetAssociationName();
	string targetRoleName = otherEnd.RoleName;

	// which generic interface to use for the collection
	string exposedListType = rel.NeedsPositionStorage(otherEnd.GetRole()) ? "IList" : "ICollection";

	// which Kistl interface this is 
	string thisInterface = relEnd.Type.GetDataTypeString();
	// which Kistl interface this list contains
	string referencedInterface = otherEnd.Type.GetDataTypeString();
	// the actual implementation class of the list's elements
	string referencedImplementation = otherEnd.Type.GetDataTypeString() + Kistl.API.Helper.ImplementationSuffix;

	// whether or not the collection will be eagerly loaded
	bool eagerLoading = relEnd.Navigator != null && relEnd.Navigator.EagerLoading;


#line 49 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
this.WriteObjects("   		// ",  this.GetType() , "\r\n");
this.WriteObjects("	    // implement the user-visible interface\r\n");
this.WriteObjects("        [XmlIgnore()]\r\n");
this.WriteObjects("        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]\r\n");
this.WriteObjects("        public ",  exposedListType , "<",  referencedInterface , "> ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (",  wrapperName , " == null)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    ",  wrapperName , " = new ",  wrapperClass , "<",  referencedInterface , ", ",  referencedImplementation , ">(\r\n");
this.WriteObjects("                            this.Context, ",  efName , "");
#line 61 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
// TODO: improve this!
	if (rel.NeedsPositionStorage(otherEnd.GetRole()))
	{
		this.WriteObjects(", \"", relEnd.RoleName, "\"");
	}
                            
#line 66 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
this.WriteObjects("",  positionPropertyNameArgument , ");\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                return ",  wrapperName , ";\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        \r\n");
this.WriteObjects("        [EdmRelationshipNavigationProperty(\"Model\", \"",  assocName , "\", \"",  targetRoleName , "\")]\r\n");
this.WriteObjects("        public EntityCollection<",  referencedImplementation , "> ",  efName , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                var c = ((IEntityWithRelationships)(this)).RelationshipManager\r\n");
this.WriteObjects("                    .GetRelatedCollection<",  referencedImplementation , ">(\r\n");
this.WriteObjects("                        \"Model.",  assocName , "\",\r\n");
this.WriteObjects("                        \"",  targetRoleName , "\");\r\n");
this.WriteObjects("                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)\r\n");
this.WriteObjects("                    && !c.IsLoaded)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    c.Load();\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                c.ForEach(i => i.AttachToContext(Context));\r\n");
this.WriteObjects("                return c;\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        private ",  wrapperClass , "<",  referencedInterface , ", ",  referencedImplementation , "> ",  wrapperName , ";\r\n");
this.WriteObjects("\r\n");
#line 93 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
if (eagerLoading)
	{

#line 96 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
this.WriteObjects("		private List<int> ",  name , "Ids;\r\n");
this.WriteObjects("		private bool ",  name , "_was_eagerLoaded = false;\r\n");
#line 100 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
if (serializationList != null)
		{
			serializationList.Add("Implementation.ObjectClasses.EagerLoadingSerialization", Kistl.Server.Generators.Templates.Implementation.SerializerType.Binary, null, null, name, true);
		}
	}

#line 106 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\ObjectListProperty.cst"
this.WriteObjects("\r\n");

        }



    }
}