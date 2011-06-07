using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Templates.Serialization;
using Kistl.Generator.Extensions;


namespace Kistl.DalProvider.Ef.Generator.Templates.Serialization
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst")]
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
		protected string clsFullName;
		protected string assocName;
		protected string targetRoleName;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string sourceMember, string targetMember, string targetGuidMember, string clsFullName, string assocName, string targetRoleName)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Serialization.ObjectReferencePropertySerialization", ctx, direction, streamName, xmlnamespace, xmlname, sourceMember, targetMember, targetGuidMember, clsFullName, assocName, targetRoleName);
        }

        public ObjectReferencePropertySerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string sourceMember, string targetMember, string targetGuidMember, string clsFullName, string assocName, string targetRoleName)
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
			this.clsFullName = clsFullName;
			this.assocName = assocName;
			this.targetRoleName = targetRoleName;

        }

        public override void Generate()
        {
#line 25 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
switch(direction)
    {
        case SerializerDirection.ToStream:

#line 29 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            {\r\n");
this.WriteObjects("                var key = this.RelationshipManager.GetRelatedReference<",  clsFullName , ">(\"Model.",  assocName , "\", \"",  targetRoleName , "\").EntityKey;\r\n");
this.WriteObjects("                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, ",  streamName , ");\r\n");
this.WriteObjects("            }\r\n");
#line 34 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.FromStream:

#line 37 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            BinarySerializer.FromStream(out this.",  targetMember , ", ",  streamName , ");\r\n");
#line 39 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.ToXmlStream:

#line 42 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            {\r\n");
this.WriteObjects("                var key = this.RelationshipManager.GetRelatedReference<",  clsFullName , ">(\"Model.",  assocName , "\", \"",  targetRoleName , "\").EntityKey;\r\n");
this.WriteObjects("                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
this.WriteObjects("            }\r\n");
#line 47 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.FromXmlStream:

#line 50 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            XmlStreamer.FromStream(ref this.",  targetMember , ", ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 52 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.Export:

#line 55 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            if (modules.Contains(\"*\") || modules.Contains(\"",  xmlnamespace , "\")) XmlStreamer.ToStream(",  sourceMember , " != null ? ",  sourceMember , ".ExportGuid : (Guid?)null, ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 57 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        case SerializerDirection.MergeImport:

#line 60 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
this.WriteObjects("            XmlStreamer.FromStream(ref this.",  targetGuidMember , ", ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 62 "P:\Kistl\Kistl.DalProvider.EF.Generator\Templates\Serialization\ObjectReferencePropertySerialization.cst"
break;
        default:
            throw new ArgumentOutOfRangeException("direction");
    }


        }

    }
}