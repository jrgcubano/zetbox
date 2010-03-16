using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Extensions;


namespace Kistl.DalProvider.Frozen.Generator.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst")]
    public partial class DataStore : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected Kistl.API.IKistlContext ctx;
		protected ObjectClass cls;


        public DataStore(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx, ObjectClass cls)
            : base(_host)
        {
			this.ctx = ctx;
			this.cls = cls;

        }
        
        public override void Generate()
        {
#line 15 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
// list of all instances of exactly this class
	//var instanceList = ctx.GetQuery(t)
	//    .ToList() // remove this, if possible
	//    .Where(o => o.GetInterfaceType() == t)
	//    .OrderBy(o => o.ID)
	//    .ToList(); // cache sorted list, not expensive query
	
	IEnumerable<IDataObject> instanceList = null;
	
	InterfaceType t;
	try
	{
		t = cls.GetDescribedInterfaceType();
		if(FreezingGenerator.FrozenInstances.ContainsKey(t.Type))
		{
			instanceList = FreezingGenerator.FrozenInstances[t.Type].OrderBy(o => o.ID);
		}
		else
		{
			instanceList = new List<IDataObject>();
		}
	}
	catch(TypeLoadException ex)
	{
		// presumably the type was new and thus unknown, ignore the error for now.
		Logging.Log.Warn(String.Format("TypeLoadException for [{0}]", cls.Name), ex);
		instanceList = new List<IDataObject>();
	}

#line 44 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		private readonly static log4net.ILog Log = log4net.LogManager.GetLogger(\"Kistl.Provider.Frozen\");\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("		internal ",  cls.BaseObjectClass == null ? String.Empty : "new " , "static Dictionary<int, ",  Template.GetClassName(cls) , "> DataStore = new Dictionary<int, ",  Template.GetClassName(cls) , ">(",  instanceList.Count() , ");\r\n");
this.WriteObjects("		internal ",  cls.BaseObjectClass == null ? String.Empty : "new " , "static void CreateInstances()\r\n");
this.WriteObjects("		{\r\n");
this.WriteObjects("			using (Log.DebugTraceMethodCall())\r\n");
this.WriteObjects("			{\r\n");
#line 54 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
string classname = Template.GetClassName(cls);
	foreach(var obj in instanceList) 
	{
		// store inherited objects also in base class' DataStore to short-circuit polymorphic queries.
		var baseCls = cls.BaseObjectClass;
		var parents = new List<ObjectClass>();
		while (baseCls != null)
		{
			parents.Add(baseCls);
			baseCls = baseCls.BaseObjectClass;
		}
		// to get "right" type order, the root class has to be the "left-most", i.e. first, assigned one
		parents.Reverse();
		foreach(var parent in parents)
		{

#line 70 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("			",  parent.Module.Namespace , ".",  Template.GetClassName(parent) , ".DataStore[",  obj.ID , "] = \r\n");
#line 72 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
}

#line 74 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("			DataStore[",  obj.ID , "] = new ",  classname , "(",  obj.ID , ");\r\n");
this.WriteObjects("\r\n");
#line 77 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
}

#line 79 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("			}\r\n");
this.WriteObjects("		}\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("		public ",  cls.BaseObjectClass == null ? String.Empty : "new " , "static void FillDataStore() {\r\n");
this.WriteObjects("			using (Log.DebugTraceMethodCall())\r\n");
this.WriteObjects("			{\r\n");
#line 86 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
foreach(var obj in instanceList) 
	{

#line 89 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("			{\r\n");
this.WriteObjects("				var item = DataStore[",  obj.ID , "];\r\n");
#line 92 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
foreach(var baseCls in cls.GetObjectHierarchie()) {
			foreach(var prop in baseCls.Properties.Cast<Property>().OrderBy(p => p.Name))
			{
				string value = GetPropertyValueAsCSharp(obj, prop);
				if (!String.IsNullOrEmpty(value) && !value.Equals("null"))
				{

#line 99 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("				item.",  prop.Name , " = ",  value , ";\r\n");
#line 101 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
}
			}
		}

#line 105 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("				item.Seal();\r\n");
this.WriteObjects("			}\r\n");
#line 108 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
}

#line 110 "P:\Kistl\Kistl.DalProvider.Frozen\Generator\Implementation\ObjectClasses\DataStore.cst"
this.WriteObjects("			}\r\n");
this.WriteObjects("		}");

        }



    }
}