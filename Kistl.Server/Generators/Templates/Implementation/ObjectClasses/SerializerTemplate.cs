using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arebis.CodeGeneration;
using Kistl.API;

namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    public partial class SerializerTemplate
    {
        public static void Call(IGenerationHost host, IKistlContext ctx, SerializerDirection direction, SerializationMembersList membersToSerialize,
            bool overrideAndCallBase, bool writeExportGuidAttribute)
        {
            host.CallTemplate("Implementation.ObjectClasses.SerializerTemplate", ctx,
                direction, membersToSerialize, overrideAndCallBase, writeExportGuidAttribute);
        }

        protected virtual void ApplySerializer(SerializerDirection direction, SerializationMember member, string streamName)
        {
            this.CallTemplate(member.TemplateName, new object[] { this.ctx, direction, streamName, member.XmlNamespace, member.XmlName }.Concat(member.TemplateParams).ToArray());
        }
    }
}
