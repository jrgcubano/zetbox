using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.Server.Generators.Templates.Implementation;
using Arebis.CodeGeneration;
using Kistl.API;
using Kistl.App.Base;

namespace Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses
{
    public partial class StructPropertyTemplate
    {
        public static void Call(IGenerationHost host, IKistlContext ctx,
            Templates.Implementation.SerializationMembersList serializationList,
            StructProperty prop)
        {
            if (host == null) { throw new ArgumentNullException("host"); }

            host.CallTemplate("Implementation.ObjectClasses.StructPropertyTemplate", ctx,
                serializationList, prop);
        }

        protected virtual void AddSerialization(Templates.Implementation.SerializationMembersList list, string memberName)
        {
            if (list != null)
                list.Add("Implementation.ObjectClasses.StructSerialization", SerializerType.All, this.prop.Module.Namespace, this.prop.PropertyName, memberName);
        }
    }
}
