using System.Collections.Generic;
using Kistl.App.Base;


namespace Kistl.Server.Generators.Interfaces.Interface.Repositories
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst")]
    public partial class ModuleRepository : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected List<Module> modules;


        public ModuleRepository(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, List<Module> modules)
            : base(_host)
        {
			this.ctx = ctx;
			this.modules = modules;

        }
        
        public override void Generate()
        {
#line 9 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst"
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace Kistl.App\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("	public class ModuleRepository\r\n");
this.WriteObjects("	{\r\n");
this.WriteObjects("		public ModuleRepository(IKistlContext ctx)\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			this.Context = ctx;\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
this.WriteObjects("		public IKistlContext Context { get; private set; }\r\n");
this.WriteObjects("	\r\n");
#line 24 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst"
foreach(var module in modules)
	{

#line 27 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst"
this.WriteObjects("		/// <summary>Repository for ",  module.ModuleName , "</summary>\r\n");
this.WriteObjects("		/// ",  module.Description , "\r\n");
this.WriteObjects("		public ",  module.Namespace , ".",  module.ModuleName , "Repository ",  module.ModuleName , "\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			get\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				return new ",  module.Namespace , ".",  module.ModuleName , "Repository(Context);\r\n");
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("		\r\n");
#line 38 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst"
}

#line 40 "P:\Kistl\Kistl.Server\Generators\Interfaces\Repositories\ModuleRepository.cst"
this.WriteObjects("	\r\n");
this.WriteObjects("	}\r\n");
this.WriteObjects("	\r\n");
this.WriteObjects("}");

        }



    }
}