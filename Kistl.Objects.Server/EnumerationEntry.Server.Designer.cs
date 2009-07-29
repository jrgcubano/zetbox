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
    /// Metadefinition Object for an Enumeration Entry.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="EnumerationEntry")]
    [System.Diagnostics.DebuggerDisplay("EnumerationEntry")]
    public class EnumerationEntry__Implementation__ : BaseServerDataObject_EntityFramework, EnumerationEntry, Kistl.API.IExportableInternal
    {
    
		public EnumerationEntry__Implementation__()
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
        /// Description of this Enumeration Entry
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
				var __value = _Description;
				if(OnDescription_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnDescription_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
					var __newValue = value;
                    if(OnDescription_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnDescription_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Description", __oldValue, __newValue);
                    _Description = __newValue;
                    NotifyPropertyChanged("Description", __oldValue, __newValue);

                    if(OnDescription_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnDescription_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Description;
		public event PropertyGetterHandler<Kistl.App.Base.EnumerationEntry, string> OnDescription_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.EnumerationEntry, string> OnDescription_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.EnumerationEntry, string> OnDescription_PostSetter;
        /// <summary>
        /// Übergeordnete Enumeration
        /// </summary>
    /*
    Relation: FK_Enumeration_has_EnumerationEntry
    A: One Enumeration as Enumeration
    B: ZeroOrMore EnumerationEntry as EnumerationEntries
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                return Enumeration__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Enumeration__Implementation__ = (Kistl.App.Base.Enumeration__Implementation__)value;
            }
        }
        
        private int? _fk_Enumeration;
        private Guid? _fk_guid_Enumeration = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Enumeration_has_EnumerationEntry", "Enumeration")]
        public Kistl.App.Base.Enumeration__Implementation__ Enumeration__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Enumeration__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration__Implementation__>(
                        "Model.FK_Enumeration_has_EnumerationEntry",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnEnumeration_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Enumeration>(__value);
					OnEnumeration_Getter(this, e);
					__value = (Kistl.App.Base.Enumeration__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Enumeration__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration__Implementation__>(
                        "Model.FK_Enumeration_has_EnumerationEntry",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Enumeration __oldValue = (Kistl.App.Base.Enumeration)r.Value;
                Kistl.App.Base.Enumeration __newValue = (Kistl.App.Base.Enumeration)value;

                if(OnEnumeration_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Enumeration>(__oldValue, __newValue);
					OnEnumeration_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Enumeration__Implementation__)__newValue;
                if(OnEnumeration_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Enumeration>(__oldValue, __newValue);
					OnEnumeration_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.Enumeration> OnEnumeration_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.Enumeration> OnEnumeration_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.Enumeration> OnEnumeration_PostSetter;
        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Guid ExportGuid
        {
            get
            {
				var __value = _ExportGuid;
				if(OnExportGuid_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Guid>(__value);
					OnExportGuid_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
					var __newValue = value;
                    if(OnExportGuid_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
						OnExportGuid_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);

                    if(OnExportGuid_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
						OnExportGuid_PostSetter(this, e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public event PropertyGetterHandler<Kistl.App.Base.EnumerationEntry, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.EnumerationEntry, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.EnumerationEntry, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// CLR name of this entry
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Name
        {
            get
            {
				var __value = _Name;
				if(OnName_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnName_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
					var __oldValue = _Name;
					var __newValue = value;
                    if(OnName_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnName_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);

                    if(OnName_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnName_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Name;
		public event PropertyGetterHandler<Kistl.App.Base.EnumerationEntry, string> OnName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.EnumerationEntry, string> OnName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.EnumerationEntry, string> OnName_PostSetter;
        /// <summary>
        /// The CLR value of this entry
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int Value
        {
            get
            {
				var __value = _Value;
				if(OnValue_Getter != null)
				{
					var e = new PropertyGetterEventArgs<int>(__value);
					OnValue_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Value != value)
                {
					var __oldValue = _Value;
					var __newValue = value;
                    if(OnValue_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
						OnValue_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Value", __oldValue, __newValue);
                    _Value = __newValue;
                    NotifyPropertyChanged("Value", __oldValue, __newValue);

                    if(OnValue_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
						OnValue_PostSetter(this, e);
                    }
                }
            }
        }
        private int _Value;
		public event PropertyGetterHandler<Kistl.App.Base.EnumerationEntry, int> OnValue_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.EnumerationEntry, int> OnValue_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.EnumerationEntry, int> OnValue_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(EnumerationEntry));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (EnumerationEntry)obj;
			var otherImpl = (EnumerationEntry__Implementation__)obj;
			var me = (EnumerationEntry)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.Name = other.Name;
			me.Value = other.Value;
			this._fk_Enumeration = otherImpl._fk_Enumeration;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationEntry != null)
            {
                OnToString_EnumerationEntry(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<EnumerationEntry> OnToString_EnumerationEntry;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationEntry != null) OnPreSave_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnPreSave_EnumerationEntry;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationEntry != null) OnPostSave_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnPostSave_EnumerationEntry;

        public override void NotifyCreated()
        {
            try
            {
				this.ExportGuid = (Guid)FrozenContext.Single.Find<Kistl.App.Base.Property>(47).DefaultValue.GetDefaultValue();
            }
            catch (TypeLoadException)
            {
                // TODO: Find a better way to ignore bootstrap errors.
                // During bootstrapping no MethodInvocation is registred
            }
            catch (NotImplementedException)
            {
                // TODO: Find a better way to ignore bootstrap errors.
                // During bootstrapping no MethodInvocation is registred
            }
            base.NotifyCreated();
            if (OnCreated_EnumerationEntry != null) OnCreated_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnCreated_EnumerationEntry;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_EnumerationEntry != null) OnDeleting_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnDeleting_EnumerationEntry;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(166).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Enumeration":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(30).Constraints
						.Where(c => !c.IsValid(this, this.Enumeration))
						.Select(c => c.GetErrorText(this, this.Enumeration))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(47).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(132).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Value":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(33).Constraints
						.Where(c => !c.IsValid(this, this.Value))
						.Select(c => c.GetErrorText(this, this.Value))
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

			if (_fk_guid_Enumeration.HasValue)
				Enumeration__Implementation__ = (Kistl.App.Base.Enumeration__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Enumeration>(_fk_guid_Enumeration.Value);
			else if (_fk_Enumeration.HasValue)
				Enumeration__Implementation__ = (Kistl.App.Base.Enumeration__Implementation__)Context.Find<Kistl.App.Base.Enumeration>(_fk_Enumeration.Value);
			else
				Enumeration__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(Enumeration != null ? Enumeration.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Value, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._fk_Enumeration, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Value, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(Enumeration != null ? Enumeration.ID : (int?)null, xml, "Enumeration", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Value, xml, "Value", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Enumeration, xml, "Enumeration", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Value, xml, "Value", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Enumeration != null ? Enumeration.ExportGuid : (Guid?)null, xml, "Enumeration", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Value, xml, "Value", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Enumeration, xml, "Enumeration", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Value, xml, "Value", "Kistl.App.Base");
        }

#endregion

    }


}