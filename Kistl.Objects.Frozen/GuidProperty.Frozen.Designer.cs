// <autogenerated/>


namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;

    using Kistl.DalProvider.Frozen;

    /// <summary>
    /// Guid Property
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("GuidProperty")]
    public class GuidProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, GuidProperty
    {
    
		public GuidProperty__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_GuidProperty != null)
            {
                OnGetPropertyType_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<GuidProperty> OnGetPropertyType_GuidProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_GuidProperty != null)
            {
                OnGetPropertyTypeString_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<GuidProperty> OnGetPropertyTypeString_GuidProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(GuidProperty));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_GuidProperty != null)
            {
                OnToString_GuidProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<GuidProperty> OnToString_GuidProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_GuidProperty != null) OnPreSave_GuidProperty(this);
        }
        public event ObjectEventHandler<GuidProperty> OnPreSave_GuidProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_GuidProperty != null) OnPostSave_GuidProperty(this);
        }
        public event ObjectEventHandler<GuidProperty> OnPostSave_GuidProperty;


        internal GuidProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, GuidProperty__Implementation__Frozen> DataStore = new Dictionary<int, GuidProperty__Implementation__Frozen>(14);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[251] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[251] = 
			DataStore[251] = new GuidProperty__Implementation__Frozen(251);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[252] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[252] = 
			DataStore[252] = new GuidProperty__Implementation__Frozen(252);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[253] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[253] = 
			DataStore[253] = new GuidProperty__Implementation__Frozen(253);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[254] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[254] = 
			DataStore[254] = new GuidProperty__Implementation__Frozen(254);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[255] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[255] = 
			DataStore[255] = new GuidProperty__Implementation__Frozen(255);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[256] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[256] = 
			DataStore[256] = new GuidProperty__Implementation__Frozen(256);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[257] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[257] = 
			DataStore[257] = new GuidProperty__Implementation__Frozen(257);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[259] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[259] = 
			DataStore[259] = new GuidProperty__Implementation__Frozen(259);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[260] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[260] = 
			DataStore[260] = new GuidProperty__Implementation__Frozen(260);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[261] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[261] = 
			DataStore[261] = new GuidProperty__Implementation__Frozen(261);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[262] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[262] = 
			DataStore[262] = new GuidProperty__Implementation__Frozen(262);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[263] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[263] = 
			DataStore[263] = new GuidProperty__Implementation__Frozen(263);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[272] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[272] = 
			DataStore[272] = new GuidProperty__Implementation__Frozen(272);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[273] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[273] = 
			DataStore[273] = new GuidProperty__Implementation__Frozen(273);

		}

		internal new static void FillDataStore() {
			DataStore[251].AltText = @"Export Guid";
			DataStore[251].CategoryTags = @"Export";
			DataStore[251].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[255],
});
			DataStore[251].Description = @"Export Guid";
			DataStore[251].ExportGuid = new Guid("59ce9855-9e67-455f-b6fa-636c47da5ae2");
			DataStore[251].IsIndexed = false;
			DataStore[251].IsList = false;
			DataStore[251].IsNullable = false;
			DataStore[251].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[251].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[88];
			DataStore[251].PropertyName = @"ExportGuid";
			DataStore[251].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[251].Seal();
			DataStore[252].AltText = @"Export Guid";
			DataStore[252].CategoryTags = @"Export";
			DataStore[252].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[254],
});
			DataStore[252].Description = @"Export Guid";
			DataStore[252].ExportGuid = new Guid("1fdb011e-2098-4077-b5e9-dd2eeafa727c");
			DataStore[252].IsIndexed = false;
			DataStore[252].IsList = false;
			DataStore[252].IsNullable = false;
			DataStore[252].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[252].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[33];
			DataStore[252].PropertyName = @"ExportGuid";
			DataStore[252].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[252].Seal();
			DataStore[253].AltText = @"Export Guid";
			DataStore[253].CategoryTags = @"Export";
			DataStore[253].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[256],
});
			DataStore[253].Description = @"Export Guid";
			DataStore[253].ExportGuid = new Guid("ca0a099d-3f4c-4604-8303-d751e57041bb");
			DataStore[253].IsIndexed = false;
			DataStore[253].IsList = false;
			DataStore[253].IsNullable = false;
			DataStore[253].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[253].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[7];
			DataStore[253].PropertyName = @"ExportGuid";
			DataStore[253].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[253].Seal();
			DataStore[254].AltText = @"Export Guid";
			DataStore[254].CategoryTags = @"Export";
			DataStore[254].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[257],
});
			DataStore[254].Description = @"Export Guid";
			DataStore[254].ExportGuid = new Guid("74265fbf-2340-4828-82fa-cff4a0d18ffa");
			DataStore[254].IsIndexed = false;
			DataStore[254].IsList = false;
			DataStore[254].IsNullable = false;
			DataStore[254].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[254].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[36];
			DataStore[254].PropertyName = @"ExportGuid";
			DataStore[254].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[254].Seal();
			DataStore[255].AltText = @"Export Guid";
			DataStore[255].CategoryTags = @"Export";
			DataStore[255].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[258],
});
			DataStore[255].Description = @"Export Guid";
			DataStore[255].ExportGuid = new Guid("9c1ddbcf-24b9-47cb-a27d-043fc47e4002");
			DataStore[255].IsIndexed = false;
			DataStore[255].IsList = false;
			DataStore[255].IsNullable = false;
			DataStore[255].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[255].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[29];
			DataStore[255].PropertyName = @"ExportGuid";
			DataStore[255].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[255].Seal();
			DataStore[256].AltText = @"Export Guid";
			DataStore[256].CategoryTags = @"Export";
			DataStore[256].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[259],
});
			DataStore[256].Description = @"Export Guid";
			DataStore[256].ExportGuid = new Guid("8da6d02c-9d9e-4db8-91ee-24a3fd1c74e1");
			DataStore[256].IsIndexed = false;
			DataStore[256].IsList = false;
			DataStore[256].IsNullable = false;
			DataStore[256].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[256].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[69];
			DataStore[256].PropertyName = @"ExportGuid";
			DataStore[256].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[256].Seal();
			DataStore[257].AltText = @"Export Guid";
			DataStore[257].CategoryTags = @"Export";
			DataStore[257].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[260],
});
			DataStore[257].Description = @"Export Guid";
			DataStore[257].ExportGuid = new Guid("842eb3fc-3c8f-47d6-a59f-225c75ec2439");
			DataStore[257].IsIndexed = false;
			DataStore[257].IsList = false;
			DataStore[257].IsNullable = false;
			DataStore[257].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[257].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[10];
			DataStore[257].PropertyName = @"ExportGuid";
			DataStore[257].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[257].Seal();
			DataStore[259].AltText = @"Export Guid";
			DataStore[259].CategoryTags = @"Export";
			DataStore[259].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[261],
});
			DataStore[259].Description = @"Export Guid";
			DataStore[259].ExportGuid = new Guid("53e7daa2-aba7-4cd0-bab6-3c0d07648b2e");
			DataStore[259].IsIndexed = false;
			DataStore[259].IsList = false;
			DataStore[259].IsNullable = false;
			DataStore[259].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[259].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[30];
			DataStore[259].PropertyName = @"ExportGuid";
			DataStore[259].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[259].Seal();
			DataStore[260].AltText = @"Export Guid";
			DataStore[260].CategoryTags = @"Export";
			DataStore[260].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[262],
});
			DataStore[260].Description = @"Export Guid";
			DataStore[260].ExportGuid = new Guid("75e3db82-220c-474e-973a-ceb65fd8386d");
			DataStore[260].IsIndexed = false;
			DataStore[260].IsList = false;
			DataStore[260].IsNullable = false;
			DataStore[260].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[260].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[18];
			DataStore[260].PropertyName = @"ExportGuid";
			DataStore[260].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[260].Seal();
			DataStore[261].AltText = @"Export Guid";
			DataStore[261].CategoryTags = @"Export";
			DataStore[261].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[263],
});
			DataStore[261].Description = @"Export Guid";
			DataStore[261].ExportGuid = new Guid("1e600012-3b35-4dc6-af28-1f858b095a15");
			DataStore[261].IsIndexed = false;
			DataStore[261].IsList = false;
			DataStore[261].IsNullable = false;
			DataStore[261].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[261].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[77];
			DataStore[261].PropertyName = @"ExportGuid";
			DataStore[261].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[261].Seal();
			DataStore[262].AltText = @"Export Guid";
			DataStore[262].CategoryTags = @"Export";
			DataStore[262].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[264],
});
			DataStore[262].Description = @"Export Guid";
			DataStore[262].ExportGuid = new Guid("4bbe4a44-dc99-4455-9c03-ae78903fcee2");
			DataStore[262].IsIndexed = false;
			DataStore[262].IsList = false;
			DataStore[262].IsNullable = false;
			DataStore[262].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[262].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[82];
			DataStore[262].PropertyName = @"ExportGuid";
			DataStore[262].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[262].Seal();
			DataStore[263].AltText = @"Export Guid";
			DataStore[263].CategoryTags = @"Export";
			DataStore[263].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[265],
});
			DataStore[263].Description = @"Export Guid";
			DataStore[263].ExportGuid = new Guid("48430be7-e17f-48ad-ac8b-7f9cb5341318");
			DataStore[263].IsIndexed = false;
			DataStore[263].IsList = false;
			DataStore[263].IsNullable = false;
			DataStore[263].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[263].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[79];
			DataStore[263].PropertyName = @"ExportGuid";
			DataStore[263].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[263].Seal();
			DataStore[272].AltText = @"Export Guid";
			DataStore[272].CategoryTags = @"Export";
			DataStore[272].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[268],
});
			DataStore[272].Description = @"Export Guid";
			DataStore[272].ExportGuid = new Guid("00000000-0000-0000-0000-000000000000");
			DataStore[272].IsIndexed = false;
			DataStore[272].IsList = false;
			DataStore[272].IsNullable = false;
			DataStore[272].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[272].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[85];
			DataStore[272].PropertyName = @"ExportGuid";
			DataStore[272].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[272].Seal();
			DataStore[273].AltText = @"Export Guid";
			DataStore[273].CategoryTags = @"Export";
			DataStore[273].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[269],
});
			DataStore[273].Description = @"Export Guid";
			DataStore[273].ExportGuid = new Guid("00000000-0000-0000-0000-000000000000");
			DataStore[273].IsIndexed = false;
			DataStore[273].IsList = false;
			DataStore[273].IsNullable = false;
			DataStore[273].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[273].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[83];
			DataStore[273].PropertyName = @"ExportGuid";
			DataStore[273].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[39];
			DataStore[273].Seal();
	
		}
#region Serializer

        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.IO.BinaryReader binStream)
        {
            throw new NotImplementedException();
        }
        public override void ToStream(System.Xml.XmlWriter xml)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }
        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public override void MergeImport(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}