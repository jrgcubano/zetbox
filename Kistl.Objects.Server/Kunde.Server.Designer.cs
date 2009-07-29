// <autogenerated/>


namespace Kistl.App.Projekte
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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Kunde")]
    [System.Diagnostics.DebuggerDisplay("Kunde")]
    public class Kunde__Implementation__ : BaseServerDataObject_EntityFramework, Kunde
    {
    
		public Kunde__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
				return _ID;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
					var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);

                }
            }
        }
        private int _ID;

        /// <summary>
        /// Adresse &amp; Hausnummer
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Adresse
        {
            get
            {
				var __value = _Adresse;
				if(OnAdresse_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnAdresse_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Adresse != value)
                {
					var __oldValue = _Adresse;
					var __newValue = value;
                    if(OnAdresse_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnAdresse_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Adresse", __oldValue, __newValue);
                    _Adresse = __newValue;
                    NotifyPropertyChanged("Adresse", __oldValue, __newValue);

                    if(OnAdresse_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnAdresse_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Adresse;
		public event PropertyGetterHandler<Kistl.App.Projekte.Kunde, string> OnAdresse_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Kunde, string> OnAdresse_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Kunde, string> OnAdresse_PostSetter;
        /// <summary>
        /// EMails des Kunden - können mehrere sein
        /// </summary>
        // value list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ValueCollectionProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<string> EMails
        {
            get
            {
                if (_EMailsWrapper == null)
                {
                    _EMailsWrapper = new EFValueCollectionWrapper<Kunde, string, Kunde_EMails_CollectionEntry__Implementation__, EntityCollection<Kunde_EMails_CollectionEntry__Implementation__>>(
						this.Context,
                        this,
                        EMails__Implementation__);
                }
                return _EMailsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Kunde_value_EMails", "CollectionEntry")]
        public EntityCollection<Kunde_EMails_CollectionEntry__Implementation__> EMails__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kunde_EMails_CollectionEntry__Implementation__>(
                        "Model.FK_Kunde_value_EMails",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EFValueCollectionWrapper<Kunde, string, Kunde_EMails_CollectionEntry__Implementation__, EntityCollection<Kunde_EMails_CollectionEntry__Implementation__>> _EMailsWrapper;

        /// <summary>
        /// Name des Kunden
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Kundenname
        {
            get
            {
				var __value = _Kundenname;
				if(OnKundenname_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnKundenname_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Kundenname != value)
                {
					var __oldValue = _Kundenname;
					var __newValue = value;
                    if(OnKundenname_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnKundenname_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Kundenname", __oldValue, __newValue);
                    _Kundenname = __newValue;
                    NotifyPropertyChanged("Kundenname", __oldValue, __newValue);

                    if(OnKundenname_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnKundenname_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Kundenname;
		public event PropertyGetterHandler<Kistl.App.Projekte.Kunde, string> OnKundenname_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Kunde, string> OnKundenname_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Kunde, string> OnKundenname_PostSetter;
        /// <summary>
        /// Land
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Land
        {
            get
            {
				var __value = _Land;
				if(OnLand_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnLand_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Land != value)
                {
					var __oldValue = _Land;
					var __newValue = value;
                    if(OnLand_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnLand_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Land", __oldValue, __newValue);
                    _Land = __newValue;
                    NotifyPropertyChanged("Land", __oldValue, __newValue);

                    if(OnLand_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnLand_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Land;
		public event PropertyGetterHandler<Kistl.App.Projekte.Kunde, string> OnLand_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Kunde, string> OnLand_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Kunde, string> OnLand_PostSetter;
        /// <summary>
        /// Ort
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Ort
        {
            get
            {
				var __value = _Ort;
				if(OnOrt_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnOrt_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Ort != value)
                {
					var __oldValue = _Ort;
					var __newValue = value;
                    if(OnOrt_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnOrt_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Ort", __oldValue, __newValue);
                    _Ort = __newValue;
                    NotifyPropertyChanged("Ort", __oldValue, __newValue);

                    if(OnOrt_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnOrt_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Ort;
		public event PropertyGetterHandler<Kistl.App.Projekte.Kunde, string> OnOrt_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Kunde, string> OnOrt_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Kunde, string> OnOrt_PostSetter;
        /// <summary>
        /// Postleitzahl
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string PLZ
        {
            get
            {
				var __value = _PLZ;
				if(OnPLZ_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnPLZ_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_PLZ != value)
                {
					var __oldValue = _PLZ;
					var __newValue = value;
                    if(OnPLZ_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnPLZ_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("PLZ", __oldValue, __newValue);
                    _PLZ = __newValue;
                    NotifyPropertyChanged("PLZ", __oldValue, __newValue);

                    if(OnPLZ_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnPLZ_PostSetter(this, e);
                    }
                }
            }
        }
        private string _PLZ;
		public event PropertyGetterHandler<Kistl.App.Projekte.Kunde, string> OnPLZ_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Kunde, string> OnPLZ_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Kunde, string> OnPLZ_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Kunde));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Kunde)obj;
			var otherImpl = (Kunde__Implementation__)obj;
			var me = (Kunde)this;

			me.Adresse = other.Adresse;
			me.Kundenname = other.Kundenname;
			me.Land = other.Land;
			me.Ort = other.Ort;
			me.PLZ = other.PLZ;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kunde != null)
            {
                OnToString_Kunde(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Kunde> OnToString_Kunde;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kunde != null) OnPreSave_Kunde(this);
        }
        public event ObjectEventHandler<Kunde> OnPreSave_Kunde;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kunde != null) OnPostSave_Kunde(this);
        }
        public event ObjectEventHandler<Kunde> OnPostSave_Kunde;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Kunde != null) OnCreated_Kunde(this);
        }
        public event ObjectEventHandler<Kunde> OnCreated_Kunde;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Kunde != null) OnDeleting_Kunde(this);
        }
        public event ObjectEventHandler<Kunde> OnDeleting_Kunde;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Adresse":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(120).Constraints
						.Where(c => !c.IsValid(this, this.Adresse))
						.Select(c => c.GetErrorText(this, this.Adresse))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "EMails":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(3).Constraints
						.Where(c => !c.IsValid(this, this.EMails))
						.Select(c => c.GetErrorText(this, this.EMails))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kundenname":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(121).Constraints
						.Where(c => !c.IsValid(this, this.Kundenname))
						.Select(c => c.GetErrorText(this, this.Kundenname))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Land":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(122).Constraints
						.Where(c => !c.IsValid(this, this.Land))
						.Select(c => c.GetErrorText(this, this.Land))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Ort":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(129).Constraints
						.Where(c => !c.IsValid(this, this.Ort))
						.Select(c => c.GetErrorText(this, this.Ort))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "PLZ":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(130).Constraints
						.Where(c => !c.IsValid(this, this.PLZ))
						.Select(c => c.GetErrorText(this, this.PLZ))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Adresse, binStream);
            BinarySerializer.ToStreamCollectionEntries(this.EMails__Implementation__, binStream);
            BinarySerializer.ToStream(this._Kundenname, binStream);
            BinarySerializer.ToStream(this._Land, binStream);
            BinarySerializer.ToStream(this._Ort, binStream);
            BinarySerializer.ToStream(this._PLZ, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Adresse, binStream);
            BinarySerializer.FromStream(out this._Kundenname, binStream);
            BinarySerializer.FromStream(out this._Land, binStream);
            BinarySerializer.FromStream(out this._Ort, binStream);
            BinarySerializer.FromStream(out this._PLZ, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Adresse, xml, "Adresse", "Kistl.App.Projekte");
            XmlStreamer.ToStreamCollectionEntries(this.EMails__Implementation__, xml, "EMails", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Kundenname, xml, "Kundenname", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Land, xml, "Land", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Ort, xml, "Ort", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._PLZ, xml, "PLZ", "Kistl.App.Projekte");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Adresse, xml, "Adresse", "Kistl.App.Projekte");
            XmlStreamer.FromStreamCollectionEntries(this.EMails__Implementation__, xml, "EMails", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Kundenname, xml, "Kundenname", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Land, xml, "Land", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Ort, xml, "Ort", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._PLZ, xml, "PLZ", "Kistl.App.Projekte");
        }

#endregion

    }


}