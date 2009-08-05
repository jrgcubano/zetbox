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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for String Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringProperty")]
    [System.Diagnostics.DebuggerDisplay("StringProperty")]
    public class StringProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, StringProperty
    {
    
		public StringProperty__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int Length
        {
            get
            {
				var __value = _Length;
				if(OnLength_Getter != null)
				{
					var e = new PropertyGetterEventArgs<int>(__value);
					OnLength_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Length != value)
                {
					var __oldValue = _Length;
					var __newValue = value;
                    if(OnLength_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
						OnLength_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Length", __oldValue, __newValue);
                    _Length = __newValue;
                    NotifyPropertyChanged("Length", __oldValue, __newValue);

                    if(OnLength_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
						OnLength_PostSetter(this, e);
                    }
                }
            }
        }
        private int _Length;
		public event PropertyGetterHandler<Kistl.App.Base.StringProperty, int> OnLength_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.StringProperty, int> OnLength_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.StringProperty, int> OnLength_PostSetter;
        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_StringProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_StringProperty != null)
            {
                OnGetPropertyType_StringProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<StringProperty> OnGetPropertyType_StringProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_StringProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_StringProperty != null)
            {
                OnGetPropertyTypeString_StringProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<StringProperty> OnGetPropertyTypeString_StringProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StringProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StringProperty)obj;
			var otherImpl = (StringProperty__Implementation__)obj;
			var me = (StringProperty)this;

			me.Length = other.Length;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringProperty != null)
            {
                OnToString_StringProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<StringProperty> OnToString_StringProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringProperty != null) OnPreSave_StringProperty(this);
        }
        public event ObjectEventHandler<StringProperty> OnPreSave_StringProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringProperty != null) OnPostSave_StringProperty(this);
        }
        public event ObjectEventHandler<StringProperty> OnPostSave_StringProperty;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringProperty != null) OnCreated_StringProperty(this);
        }
        public event ObjectEventHandler<StringProperty> OnCreated_StringProperty;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringProperty != null) OnDeleting_StringProperty(this);
        }
        public event ObjectEventHandler<StringProperty> OnDeleting_StringProperty;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Length":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("3588888e-b280-4e8d-8a7b-53f452b81bf0")).Constraints
						.Where(c => !c.IsValid(this, this.Length))
						.Select(c => c.GetErrorText(this, this.Length))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Length, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Length, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Length, xml, "Length", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Length, xml, "Length", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Length, xml, "Length", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._Length, xml, "Length", "Kistl.App.Base");
        }

#endregion

    }


}