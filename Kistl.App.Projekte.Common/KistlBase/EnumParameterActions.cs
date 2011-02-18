namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Kistl.API;

    [Implementor]
    public static class EnumParameterActions
    {
        [Invocation]
        public static void GetParameterTypeString(Kistl.App.Base.EnumParameter obj, MethodReturnEventArgs<System.String> e)
        {
            if (obj.Enumeration == null)
            {
                e.Result = "<no enum>";
            }
            else if (obj.Enumeration.Module == null)
            {
                e.Result = "<no namespace>." + obj.Enumeration.Name;
            }
            else
            {
                e.Result = obj.Enumeration.Module.Namespace + "." + obj.Enumeration.Name;
            }
        }

    }
}
