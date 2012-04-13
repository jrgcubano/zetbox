using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.Generator.Templates.Serialization
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst")]
    public partial class EagerLoadingSerialization : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected SerializerDirection direction;
		protected string streamName;
		protected string xmlnamespace;
		protected string xmlname;
		protected string collectionName;
		protected bool serializeIds;
		protected bool serializeRelationEntries;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string collectionName, bool serializeIds, bool serializeRelationEntries)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Serialization.EagerLoadingSerialization", ctx, direction, streamName, xmlnamespace, xmlname, collectionName, serializeIds, serializeRelationEntries);
        }

        public EagerLoadingSerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string collectionName, bool serializeIds, bool serializeRelationEntries)
            : base(_host)
        {
			this.ctx = ctx;
			this.direction = direction;
			this.streamName = streamName;
			this.xmlnamespace = xmlnamespace;
			this.xmlname = xmlname;
			this.collectionName = collectionName;
			this.serializeIds = serializeIds;
			this.serializeRelationEntries = serializeRelationEntries;

        }

        public override void Generate()
        {
#line 20 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("\r\n");
#line 22 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
switch(direction)
	{
		case SerializerDirection.ToStream:

#line 26 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("			",  streamName , ".Write(eagerLoadLists);\r\n");
this.WriteObjects("			if (eagerLoadLists && auxObjects != null)\r\n");
this.WriteObjects("			{\r\n");
#line 29 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
if (serializeIds) {                                                          
#line 30 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("				",  streamName , ".Write(true);\r\n");
this.WriteObjects("				",  streamName , ".Write(",  collectionName , ".Count);\r\n");
#line 32 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
}                                                                            
#line 33 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("				foreach(var obj in ",  collectionName , ")\r\n");
this.WriteObjects("				{\r\n");
this.WriteObjects("					auxObjects.Add(obj);\r\n");
#line 36 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
if (serializeIds) {                                                          
#line 37 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("					",  streamName , ".Write(obj.ID);\r\n");
#line 38 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
}                                                                            
#line 39 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("				}\r\n");
#line 40 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
if (serializeRelationEntries) { ApplyRelationEntrySerialization(); }         
#line 41 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("			}\r\n");
#line 42 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
if (serializeIds) {                                                          
#line 43 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("			else\r\n");
this.WriteObjects("			{\r\n");
this.WriteObjects("				",  streamName , ".Write(false);\r\n");
this.WriteObjects("			}\r\n");
#line 47 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
}                                                                            
#line 49 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
break;
		case SerializerDirection.FromStream:

#line 52 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("			",  streamName , ".Read(out ",  collectionName , "_was_eagerLoaded);\r\n");
#line 53 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
if (serializeIds) {                                                          
#line 54 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
this.WriteObjects("			{\r\n");
this.WriteObjects("				bool containsList;\r\n");
this.WriteObjects("				",  streamName , ".Read(out containsList);\r\n");
this.WriteObjects("				if (containsList)\r\n");
this.WriteObjects("				{\r\n");
this.WriteObjects("					int numElements;\r\n");
this.WriteObjects("					",  streamName , ".Read(out numElements);\r\n");
this.WriteObjects("					",  collectionName , "Ids = new List<int>(numElements);\r\n");
this.WriteObjects("					while (numElements-- > 0) \r\n");
this.WriteObjects("					{\r\n");
this.WriteObjects("						int id;\r\n");
this.WriteObjects("						",  streamName , ".Read(out id);\r\n");
this.WriteObjects("						",  collectionName , "Ids.Add(id);\r\n");
this.WriteObjects("					}\r\n");
this.WriteObjects("				}\r\n");
this.WriteObjects("			}\r\n");
#line 70 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
}                                                                            
#line 72 "P:\Kistl\Kistl.Generator\Templates\Serialization\EagerLoadingSerialization.cst"
break;
		default:
			throw new ArgumentOutOfRangeException("direction");
	}


        }

    }
}