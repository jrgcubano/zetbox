using System.Collections.Generic;
using System.Linq;
using Kistl.App.Base;


namespace Kistl.Server.Generators.FrozenObjects.Repositories
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst")]
    public partial class FrozenRepository : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected Module module;


        public FrozenRepository(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, Module module)
            : base(_host)
        {
			this.ctx = ctx;
			this.module = module;

        }
        
        public override void Generate()
        {
#line 11 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
string classname = "Frozen" + module.ModuleName + "Repository";
    // TODO: remove ToList when IsFrozenObject correctly inherits across meta-data
	var frozenClasses = module.DataTypes.OfType<ObjectClass>().ToList().Where(cls => cls.IsFrozen());

#line 15 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.Linq;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("	public static class ",  classname , "\r\n");
this.WriteObjects("	{\r\n");
this.WriteObjects("		\r\n");
#line 28 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
foreach(var cls in frozenClasses)
	{
		string implementationName = Implementation.ObjectClasses.Template.GetClassName(cls);

#line 32 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("		/// <summary>Frozen List of all ",  cls.ClassName , "</summary>\r\n");
this.WriteObjects("		/// ",  cls.Description , "\r\n");
this.WriteObjects("		public static IQueryable<",  cls.ClassName , "> ",  cls.TableName , "\r\n");
this.WriteObjects("		{ \r\n");
this.WriteObjects("			get\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				return ",  implementationName , ".DataStore.Values.AsQueryable().Cast<",  cls.ClassName , ">();\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
#line 43 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
}

#line 45 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		internal static void CreateInstances()\r\n");
this.WriteObjects("		{\r\n");
#line 49 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
foreach(var cls in frozenClasses)
	{
		string implementationName = Implementation.ObjectClasses.Template.GetClassName(cls);

#line 53 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("				",  implementationName , ".CreateInstances();\r\n");
#line 55 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
}

#line 57 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("		internal static void FillDataStore()\r\n");
this.WriteObjects("		{\r\n");
#line 63 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
foreach(var cls in frozenClasses)
	{
		string implementationName = Implementation.ObjectClasses.Template.GetClassName(cls);

#line 67 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("				",  implementationName , ".FillDataStore();\r\n");
#line 69 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
}

#line 71 "P:\Kistl\Kistl.Server\Generators\FrozenObjects\Repositories\FrozenRepository.cst"
this.WriteObjects("		}\r\n");
this.WriteObjects("	}\r\n");
this.WriteObjects("	\r\n");
this.WriteObjects("}");

        }



    }
}