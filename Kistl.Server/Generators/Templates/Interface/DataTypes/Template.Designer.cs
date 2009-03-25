using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Interface.DataTypes
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst")]
    public partial class Template : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Kistl.App.Base.DataType dataType;


        public Template(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Kistl.App.Base.DataType dataType)
            : base(_host)
        {
			this.ctx = ctx;
			this.dataType = dataType;

        }
        
        public override void Generate()
        {
#line 14 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  dataType.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("    using System;\r\n");
this.WriteObjects("    using System.Collections.Generic;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    /// <summary>\r\n");
this.WriteObjects("    /// ",  dataType.Description , "\r\n");
this.WriteObjects("    /// </summary>\r\n");
this.WriteObjects("    public interface ",  dataType.ClassName , " ",  GetInheritance() , " \r\n");
this.WriteObjects("    {\r\n");
#line 28 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
foreach(Property p in dataType.Properties.OrderBy(p => p.PropertyName))
    {

#line 31 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// ",  p.Description , "\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 36 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
ApplyPropertyTemplate(p);
    }



    foreach(var m in MethodsToGenerate().OrderBy(m => m.MethodName))
    {

#line 44 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        /// <summary>\r\n");
this.WriteObjects("        /// ",  m.Description , "\r\n");
this.WriteObjects("        /// </summary>\r\n");
#line 49 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
ApplyMethodTemplate(m);
    }

#line 52 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\DataTypes\Template.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    }\r\n");
this.WriteObjects("}");

        }



    }
}