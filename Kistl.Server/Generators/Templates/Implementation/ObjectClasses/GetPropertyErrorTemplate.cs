using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arebis.CodeGeneration;
using Kistl.API;
using Kistl.App.Base;

namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    public partial class GetPropertyErrorTemplate
    {
        public static void Call(IGenerationHost host, IKistlContext ctx, ObjectClass cls)
        {
            if (host == null) { throw new ArgumentNullException("host"); }

            host.CallTemplate("Implementation.ObjectClasses.GetPropertyErrorTemplate", ctx, cls);
        }
    }
}
