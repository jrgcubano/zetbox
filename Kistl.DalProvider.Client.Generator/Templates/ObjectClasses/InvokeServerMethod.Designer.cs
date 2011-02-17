using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.DalProvider.Client.Generator.Templates.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst")]
    public partial class InvokeServerMethod : Kistl.Generator.Templates.ObjectClasses.Method
    {


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("ObjectClasses.InvokeServerMethod");
        }

        public InvokeServerMethod(Arebis.CodeGeneration.IGenerationHost _host)
            : base(_host)
        {

        }

        public override void Generate()
        {
#line 12 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
this.WriteObjects("        // BEGIN ",  this.GetType() , "\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        ",  GetModifiers() , " ",  GetReturnType() , " ",  m.Name , "(",  GetParameterDefinitions() , ")\r\n");
#line 16 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
var returnParam = m.Parameter.SingleOrDefault(parameter => parameter.IsReturnParameter);

    string argumentDefs = m.GetArguments();
    if (!String.IsNullOrEmpty(argumentDefs))
    {
        // add leading comma for later usage
        argumentDefs = ", " + argumentDefs;
    }

    string argumentTypes = m.GetArgumentTypes();
    // add leading comma for later usage
    argumentTypes = "new Type[] {" + argumentTypes + "}";


    if (returnParam == null)
    {

#line 33 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
this.WriteObjects("        {\r\n");
this.WriteObjects("            Context.ClientInternals().InvokeServerMethod(this, \"",  m.Name , "\", typeof(",  GetReturnType() , "), ",  argumentTypes, "",  argumentDefs , ");\r\n");
this.WriteObjects("        }\r\n");
#line 37 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
}
    else
    {

#line 41 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
this.WriteObjects("        {\r\n");
this.WriteObjects("            return (",  GetReturnType() , ")Context.ClientInternals().InvokeServerMethod(this, \"",  m.Name , "\", typeof(",  GetReturnType() , "), ",  argumentTypes , "",  argumentDefs , ");\r\n");
this.WriteObjects("        }\r\n");
#line 45 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
}

#line 47 "P:\Kistl\Kistl.DalProvider.Client.Generator\Templates\ObjectClasses\InvokeServerMethod.cst"
this.WriteObjects("        // END ",  this.GetType() , "\r\n");

        }

    }
}