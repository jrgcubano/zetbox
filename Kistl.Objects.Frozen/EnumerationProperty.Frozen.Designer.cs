
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
    /// Metadefinition Object for Enumeration Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumerationProperty")]
    public class EnumerationProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, EnumerationProperty
    {


        /// <summary>
        /// Enumeration der Eigenschaft
        /// </summary>
        // object reference property
        public virtual Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                return _Enumeration;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Enumeration != value)
                {
                    NotifyPropertyChanging("Enumeration");
                    _Enumeration = value;
                    NotifyPropertyChanged("Enumeration");
                }
            }
        }
        private Kistl.App.Base.Enumeration _Enumeration;

        /// <summary>
        /// 
        /// </summary>

		public override string GetGUIRepresentation() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_EnumerationProperty != null)
            {
                OnGetGUIRepresentation_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetGUIRepresentation();
            }
            return e.Result;
        }
		public event GetGUIRepresentation_Handler<EnumerationProperty> OnGetGUIRepresentation_EnumerationProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_EnumerationProperty != null)
            {
                OnGetPropertyType_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<EnumerationProperty> OnGetPropertyType_EnumerationProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_EnumerationProperty != null)
            {
                OnGetPropertyTypeString_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty;



		public override Type GetInterfaceType()
		{
			return typeof(EnumerationProperty);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationProperty != null)
            {
                OnToString_EnumerationProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<EnumerationProperty> OnToString_EnumerationProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationProperty != null) OnPreSave_EnumerationProperty(this);
        }
        public event ObjectEventHandler<EnumerationProperty> OnPreSave_EnumerationProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationProperty != null) OnPostSave_EnumerationProperty(this);
        }
        public event ObjectEventHandler<EnumerationProperty> OnPostSave_EnumerationProperty;


        internal EnumerationProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, EnumerationProperty__Implementation__Frozen> DataStore = new Dictionary<int, EnumerationProperty__Implementation__Frozen>(9);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[110] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[110] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[110] = 
			DataStore[110] = new EnumerationProperty__Implementation__Frozen(110);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[111] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[111] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[111] = 
			DataStore[111] = new EnumerationProperty__Implementation__Frozen(111);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[113] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[113] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[113] = 
			DataStore[113] = new EnumerationProperty__Implementation__Frozen(113);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[117] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[117] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[117] = 
			DataStore[117] = new EnumerationProperty__Implementation__Frozen(117);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[118] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[118] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[118] = 
			DataStore[118] = new EnumerationProperty__Implementation__Frozen(118);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[137] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[137] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[137] = 
			DataStore[137] = new EnumerationProperty__Implementation__Frozen(137);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[150] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[150] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[150] = 
			DataStore[150] = new EnumerationProperty__Implementation__Frozen(150);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[183] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[183] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[183] = 
			DataStore[183] = new EnumerationProperty__Implementation__Frozen(183);

			Kistl.App.Base.BaseProperty__Implementation__Frozen.DataStore[210] = 
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[210] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[210] = 
			DataStore[210] = new EnumerationProperty__Implementation__Frozen(210);

		}

		internal new static void FillDataStore() {
			DataStore[110].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[51];
			DataStore[110].PropertyName = @"TestEnumProp";
			DataStore[110].AltText = @"Test Enumeration Property";
			DataStore[110].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[5];
			DataStore[110].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[102],
});
			DataStore[110].Description = @"Test Enumeration Property";
			DataStore[110].IsList = false;
			DataStore[110].IsNullable = false;
			DataStore[110].IsIndexed = false;
			DataStore[110].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[50];
			DataStore[110].Seal();
			DataStore[111].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[48];
			DataStore[111].PropertyName = @"TestEnumProp";
			DataStore[111].AltText = @"Test Enum Property";
			DataStore[111].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[5];
			DataStore[111].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[101],
});
			DataStore[111].Description = @"Test Enum Property";
			DataStore[111].IsList = false;
			DataStore[111].IsNullable = false;
			DataStore[111].IsIndexed = false;
			DataStore[111].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[50];
			DataStore[111].Seal();
			DataStore[113].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[52];
			DataStore[113].PropertyName = @"Platform";
			DataStore[113].AltText = @"The Toolkit used by this Renderer";
			DataStore[113].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[113].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[99],
});
			DataStore[113].Description = @"The Toolkit used by this Renderer";
			DataStore[113].IsList = false;
			DataStore[113].IsNullable = false;
			DataStore[113].IsIndexed = false;
			DataStore[113].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[53];
			DataStore[113].Seal();
			DataStore[117].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[54];
			DataStore[117].PropertyName = @"Platform";
			DataStore[117].AltText = @"The toolkit of this Control.";
			DataStore[117].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[117].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[95],
});
			DataStore[117].Description = @"The toolkit of this Control.";
			DataStore[117].IsList = false;
			DataStore[117].IsNullable = false;
			DataStore[117].IsIndexed = false;
			DataStore[117].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[53];
			DataStore[117].Seal();
			DataStore[118].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[54];
			DataStore[118].PropertyName = @"ControlType";
			DataStore[118].AltText = @"The type of Control of this implementation";
			DataStore[118].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[118].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[94],
});
			DataStore[118].Description = @"The type of Control of this implementation";
			DataStore[118].IsList = false;
			DataStore[118].IsNullable = false;
			DataStore[118].IsIndexed = false;
			DataStore[118].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[55];
			DataStore[118].Seal();
			DataStore[137].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[66];
			DataStore[137].PropertyName = @"ControlType";
			DataStore[137].AltText = @"which controls are handled by this Presenter";
			DataStore[137].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[137].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[87],
});
			DataStore[137].Description = @"which controls are handled by this Presenter";
			DataStore[137].IsList = false;
			DataStore[137].IsNullable = false;
			DataStore[137].IsIndexed = false;
			DataStore[137].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[55];
			DataStore[137].Seal();
			DataStore[150].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[67];
			DataStore[150].PropertyName = @"ControlType";
			DataStore[150].AltText = @"Which visual is represented here";
			DataStore[150].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[150].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[82],
});
			DataStore[150].Description = @"Which visual is represented here";
			DataStore[150].IsList = false;
			DataStore[150].IsNullable = false;
			DataStore[150].IsIndexed = false;
			DataStore[150].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[55];
			DataStore[150].Seal();
			DataStore[183].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[77];
			DataStore[183].PropertyName = @"Storage";
			DataStore[183].AltText = @"Storagetype for 1:1 Relations";
			DataStore[183].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[183].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[183].Description = @"Storagetype for 1:1 Relations. Must be null for non 1:1 Relations.";
			DataStore[183].IsList = false;
			DataStore[183].IsNullable = true;
			DataStore[183].IsIndexed = false;
			DataStore[183].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[78];
			DataStore[183].Seal();
			DataStore[210].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[80];
			DataStore[210].PropertyName = @"Toolkit";
			DataStore[210].AltText = @"";
			DataStore[210].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[210].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[214],
});
			DataStore[210].Description = null;
			DataStore[210].IsList = false;
			DataStore[210].IsNullable = false;
			DataStore[210].IsIndexed = false;
			DataStore[210].Enumeration = Kistl.App.Base.Enumeration__Implementation__Frozen.DataStore[53];
			DataStore[210].Seal();
	
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

#endregion

    }


}