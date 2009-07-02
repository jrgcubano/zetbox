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
    /// Metadefinition Object for Double Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DoubleProperty")]
    public class DoubleProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, DoubleProperty
    {
    
		public DoubleProperty__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DoubleProperty != null)
            {
                OnGetPropertyType_DoubleProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<DoubleProperty> OnGetPropertyType_DoubleProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DoubleProperty != null)
            {
                OnGetPropertyTypeString_DoubleProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<DoubleProperty> OnGetPropertyTypeString_DoubleProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DoubleProperty));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleProperty != null)
            {
                OnToString_DoubleProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DoubleProperty> OnToString_DoubleProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleProperty != null) OnPreSave_DoubleProperty(this);
        }
        public event ObjectEventHandler<DoubleProperty> OnPreSave_DoubleProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleProperty != null) OnPostSave_DoubleProperty(this);
        }
        public event ObjectEventHandler<DoubleProperty> OnPostSave_DoubleProperty;


        internal DoubleProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, DoubleProperty__Implementation__Frozen> DataStore = new Dictionary<int, DoubleProperty__Implementation__Frozen>(5);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[134] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[134] = 
			DataStore[134] = new DoubleProperty__Implementation__Frozen(134);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[135] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[135] = 
			DataStore[135] = new DoubleProperty__Implementation__Frozen(135);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[136] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[136] = 
			DataStore[136] = new DoubleProperty__Implementation__Frozen(136);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[142] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[142] = 
			DataStore[142] = new DoubleProperty__Implementation__Frozen(142);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[149] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[149] = 
			DataStore[149] = new DoubleProperty__Implementation__Frozen(149);

		}

		internal new static void FillDataStore() {
			DataStore[134].AltText = @"Number of already spent hours";
			DataStore[134].CategoryTags = @"Summary,Main";
			DataStore[134].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[134].Description = @"Aktuell gebuchte Stunden";
			DataStore[134].ExportGuid = new Guid("f7816f8a-0b07-429c-9161-47ca495a2e41");
			DataStore[134].IsIndexed = false;
			DataStore[134].IsList = false;
			DataStore[134].IsNullable = true;
			DataStore[134].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[134].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[34];
			DataStore[134].PropertyName = @"SpentHours";
			DataStore[134].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[19];
			DataStore[134].Seal();
			DataStore[135].AltText = @"Wert in EUR des Auftrages";
			DataStore[135].CategoryTags = null;
			DataStore[135].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[135].Description = @"Wert in EUR des Auftrages";
			DataStore[135].ExportGuid = new Guid("f252395f-7867-4299-9965-66f7a7b8f3c5");
			DataStore[135].IsIndexed = false;
			DataStore[135].IsList = false;
			DataStore[135].IsNullable = true;
			DataStore[135].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[135].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[25];
			DataStore[135].PropertyName = @"Auftragswert";
			DataStore[135].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[19];
			DataStore[135].Seal();
			DataStore[136].AltText = @"Number of currently allocated hours";
			DataStore[136].CategoryTags = @"Summary,Main";
			DataStore[136].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[136].Description = @"Maximal erlaubte Stundenanzahl";
			DataStore[136].ExportGuid = new Guid("2f57b6c8-d798-43de-b9c8-29675ff0c65f");
			DataStore[136].IsIndexed = false;
			DataStore[136].IsList = false;
			DataStore[136].IsNullable = true;
			DataStore[136].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[136].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[34];
			DataStore[136].PropertyName = @"BudgetHours";
			DataStore[136].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[19];
			DataStore[136].Seal();
			DataStore[142].AltText = null;
			DataStore[142].CategoryTags = null;
			DataStore[142].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[142].Description = @"";
			DataStore[142].ExportGuid = new Guid("a26cec7d-1e5c-44f5-9c56-92af595739eb");
			DataStore[142].IsIndexed = false;
			DataStore[142].IsList = false;
			DataStore[142].IsNullable = true;
			DataStore[142].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[142].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[55];
			DataStore[142].PropertyName = @"AufwandGes";
			DataStore[142].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[19];
			DataStore[142].Seal();
			DataStore[149].AltText = @"Aufwand in Stunden";
			DataStore[149].CategoryTags = null;
			DataStore[149].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[149].Description = @"Aufwand in Stunden";
			DataStore[149].ExportGuid = new Guid("a28f7536-9b8a-49ca-bc97-d28e1c2c4d3e");
			DataStore[149].IsIndexed = false;
			DataStore[149].IsList = false;
			DataStore[149].IsNullable = true;
			DataStore[149].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[149].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[22];
			DataStore[149].PropertyName = @"Aufwand";
			DataStore[149].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[19];
			DataStore[149].Seal();
	
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