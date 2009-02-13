using System.Collections.Generic;
using System.Linq;
using Kistl.App.Base;


namespace Kistl.Server.Generators.Interfaces.Interface.Repositories
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst")]
    public partial class Repository : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected Module module;


        public Repository(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, Module module)
            : base(_host)
        {
			this.ctx = ctx;
			this.module = module;

        }
        
        public override void Generate()
        {
#line 10 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst"
this.WriteObjects("using System.Linq;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("	public class ",  module.ModuleName , "Repository\r\n");
this.WriteObjects("	{\r\n");
this.WriteObjects("		public ",  module.ModuleName , "Repository(IKistlContext ctx)\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			this.Context = ctx;\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		public IKistlContext Context { get; private set; }\r\n");
this.WriteObjects("		\r\n");
#line 27 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst"
foreach(var cls in module.DataTypes.OfType<ObjectClass>())
	{

#line 30 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst"
this.WriteObjects("		/// <summary>List of all ",  cls.ClassName , "</summary>\r\n");
this.WriteObjects("		/// ",  cls.Description , "\r\n");
this.WriteObjects("		public IQueryable<",  cls.ClassName , "> ",  cls.TableName , "\r\n");
this.WriteObjects("		{ \r\n");
this.WriteObjects("			get\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				return Context.GetQuery<",  cls.ClassName , ">();\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
#line 41 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst"
}

#line 43 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\Repository.cst"
this.WriteObjects("	\r\n");
this.WriteObjects("	}\r\n");
this.WriteObjects("	\r\n");
this.WriteObjects("}");

        }



    }
}