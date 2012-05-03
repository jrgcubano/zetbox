using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;
using Kistl.Generator.Templates.Serialization;


namespace Kistl.DalProvider.NHibernate.Generator.Templates.Serialization
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst")]
    public partial class ObjectReferencePropertySerialization : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected SerializerDirection direction;
		protected string streamName;
		protected string xmlnamespace;
		protected string xmlname;
		protected string sourceMember;
		protected string targetMember;
		protected string targetGuidMember;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string sourceMember, string targetMember, string targetGuidMember)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Serialization.ObjectReferencePropertySerialization", ctx, direction, streamName, xmlnamespace, xmlname, sourceMember, targetMember, targetGuidMember);
        }

        public ObjectReferencePropertySerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string sourceMember, string targetMember, string targetGuidMember)
            : base(_host)
        {
			this.ctx = ctx;
			this.direction = direction;
			this.streamName = streamName;
			this.xmlnamespace = xmlnamespace;
			this.xmlname = xmlname;
			this.sourceMember = sourceMember;
			this.targetMember = targetMember;
			this.targetGuidMember = targetGuidMember;

        }

        public override void Generate()
        {
#line 22 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
switch(direction)
    {
        case SerializerDirection.ToStream:

#line 26 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            ",  streamName , ".Write(",  sourceMember , " != null ? OurContext.GetIdFromProxy(",  sourceMember , ") : (int?)null);\r\n");
#line 28 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.FromStream:

#line 31 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            ",  streamName , ".Read(out this.",  targetMember , ");\r\n");
#line 33 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.Export:

#line 36 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            if (modules.Contains(\"*\") || modules.Contains(\"",  xmlnamespace , "\")) XmlStreamer.ToStream(",  sourceMember , " != null ? ",  sourceMember , ".ExportGuid : (Guid?)null, ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 38 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.MergeImport:

#line 41 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            case \"",  xmlnamespace , "|",  xmlname , "\":\r\n");
this.WriteObjects("                this.",  targetGuidMember , " = XmlStreamer.ReadNullableGuid(",  streamName , ");\r\n");
this.WriteObjects("                break;\r\n");
#line 45 "P:\Kistl\Kistl.DalProvider.NHibernate.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        default:
            throw new ArgumentOutOfRangeException("direction");
    }


        }

    }
}