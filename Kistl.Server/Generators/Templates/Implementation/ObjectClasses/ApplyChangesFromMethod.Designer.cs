using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst")]
    public partial class ApplyChangesFromMethod : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected ObjectClass cls;


        public ApplyChangesFromMethod(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ObjectClass cls)
            : base(_host)
        {
			this.ctx = ctx;
			this.cls = cls;

        }
        
        public override void Generate()
        {
#line 15 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		public override void ApplyChangesFrom(IPersistenceObject obj)\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			base.ApplyChangesFrom(obj);\r\n");
this.WriteObjects("			var other = (",  cls.Name , ")obj;\r\n");
this.WriteObjects("			var otherImpl = (",  cls.Name + Kistl.API.Helper.ImplementationSuffix , ")obj;\r\n");
this.WriteObjects("			var me = (",  cls.Name , ")this;\r\n");
this.WriteObjects("\r\n");
#line 24 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
foreach(var prop in cls.Properties.OfType<ValueTypeProperty>().Where(p => !p.IsList).OrderBy(p => p.Name))
			{

#line 27 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("			me.",  prop.Name , " = other.",  prop.Name , ";\r\n");
#line 29 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
}

			foreach(var prop in cls.Properties.OfType<CompoundObjectProperty>().Where(p => !p.IsList).OrderBy(p => p.Name))
			{

#line 34 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("			me.",  prop.Name , " = other.",  prop.Name , " != null ? (",  prop.GetPropertyTypeString() , ")other.",  prop.Name , ".Clone() : null;\r\n");
#line 36 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
}

			foreach(var prop in cls.Properties.OfType<ObjectReferenceProperty>().Where(p => !p.IsList()).OrderBy(p => p.Name))
			{
				if (prop.RelationEnd.HasPersistentOrder) {
					var positionPropertyName = Construct.ListPositionPropertyName(prop.RelationEnd);

#line 43 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("			this.",  positionPropertyName , " = otherImpl.",  positionPropertyName , ";\r\n");
#line 45 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
}

#line 47 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("			this._fk_",  prop.Name , " = otherImpl._fk_",  prop.Name , ";\r\n");
#line 49 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
}

#line 51 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\ApplyChangesFromMethod.cst"
this.WriteObjects("		}\r\n");

        }



    }
}