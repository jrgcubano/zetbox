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
    /// Base Metadefinition Object for Objectclasses, Interfaces, Structs and Enumerations.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DataType")]
    [System.Diagnostics.DebuggerDisplay("DataType")]
    public class DataType__Implementation__ : BaseServerDataObject_EntityFramework, DataType, Kistl.API.IExportableInternal
    {
    
		public DataType__Implementation__()
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
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// Der Name der Objektklasse
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ClassName != value)
                {
					var __oldValue = _ClassName;
                    NotifyPropertyChanging("ClassName", __oldValue, value);
                    _ClassName = value;
                    NotifyPropertyChanged("ClassName", __oldValue, value);
                }
            }
        }
        private string _ClassName;

        /// <summary>
        /// Standard Icon wenn IIcon nicht implementiert ist
        /// </summary>
    /*
    Relation: FK_DataType_has_Icon
    A: ZeroOrMore DataType as DataType
    B: ZeroOrOne Icon as DefaultIcon
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.Icon DefaultIcon
        {
            get
            {
                return DefaultIcon__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                DefaultIcon__Implementation__ = (Kistl.App.GUI.Icon__Implementation__)value;
            }
        }
        
        private int? _fk_DefaultIcon;
        private Guid? _fk_guid_DefaultIcon = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_has_Icon", "DefaultIcon")]
        public Kistl.App.GUI.Icon__Implementation__ DefaultIcon__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.Icon__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Icon__Implementation__>(
                        "Model.FK_DataType_has_Icon",
                        "DefaultIcon");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.Icon__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Icon__Implementation__>(
                        "Model.FK_DataType_has_Icon",
                        "DefaultIcon");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.GUI.Icon__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Description of this DataType
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
                return _Description;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

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
                return _ExportGuid;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// all implemented Methods in this DataType
        /// </summary>
    /*
    Relation: FK_DataType_has_MethodInvocation
    A: One DataType as InvokeOnObjectClass
    B: ZeroOrMore MethodInvocation as MethodInvocations
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.MethodInvocation> MethodInvocations
        {
            get
            {
                if (_MethodInvocationsWrapper == null)
                {
                    _MethodInvocationsWrapper = new EntityCollectionWrapper<Kistl.App.Base.MethodInvocation, Kistl.App.Base.MethodInvocation__Implementation__>(
                            this.Context, MethodInvocations__Implementation__);
                }
                return _MethodInvocationsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_has_MethodInvocation", "MethodInvocations")]
        public EntityCollection<Kistl.App.Base.MethodInvocation__Implementation__> MethodInvocations__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.MethodInvocation__Implementation__>(
                        "Model.FK_DataType_has_MethodInvocation",
                        "MethodInvocations");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.MethodInvocation, Kistl.App.Base.MethodInvocation__Implementation__> _MethodInvocationsWrapper;



        /// <summary>
        /// Liste aller Methoden der Objektklasse.
        /// </summary>
    /*
    Relation: FK_DataType_has_Method
    A: One DataType as ObjectClass
    B: ZeroOrMore Method as Methods
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Method> Methods
        {
            get
            {
                if (_MethodsWrapper == null)
                {
                    _MethodsWrapper = new EntityCollectionWrapper<Kistl.App.Base.Method, Kistl.App.Base.Method__Implementation__>(
                            this.Context, Methods__Implementation__);
                }
                return _MethodsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_has_Method", "Methods")]
        public EntityCollection<Kistl.App.Base.Method__Implementation__> Methods__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_DataType_has_Method",
                        "Methods");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.Method, Kistl.App.Base.Method__Implementation__> _MethodsWrapper;



        /// <summary>
        /// Modul der Objektklasse
        /// </summary>
    /*
    Relation: FK_Module_has_DataType
    A: One Module as Module
    B: ZeroOrMore DataType as DataTypes
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Module__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        private int? _fk_Module;
        private Guid? _fk_guid_Module = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Module_has_DataType", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_DataType",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_DataType",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Eigenschaften der Objektklasse
        /// </summary>
    /*
    Relation: FK_DataType_has_Property
    A: One DataType as ObjectClass
    B: ZeroOrMore Property as Properties
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Property> Properties
        {
            get
            {
                if (_PropertiesWrapper == null)
                {
                    _PropertiesWrapper = new EntityCollectionWrapper<Kistl.App.Base.Property, Kistl.App.Base.Property__Implementation__>(
                            this.Context, Properties__Implementation__);
                }
                return _PropertiesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_has_Property", "Properties")]
        public EntityCollection<Kistl.App.Base.Property__Implementation__> Properties__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.Property__Implementation__>(
                        "Model.FK_DataType_has_Property",
                        "Properties");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.Property, Kistl.App.Base.Property__Implementation__> _PropertiesWrapper;



        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowIconInLists
        {
            get
            {
                return _ShowIconInLists;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIconInLists != value)
                {
					var __oldValue = _ShowIconInLists;
                    NotifyPropertyChanging("ShowIconInLists", __oldValue, value);
                    _ShowIconInLists = value;
                    NotifyPropertyChanged("ShowIconInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIconInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowIdInLists
        {
            get
            {
                return _ShowIdInLists;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIdInLists != value)
                {
					var __oldValue = _ShowIdInLists;
                    NotifyPropertyChanging("ShowIdInLists", __oldValue, value);
                    _ShowIdInLists = value;
                    NotifyPropertyChanged("ShowIdInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIdInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowNameInLists
        {
            get
            {
                return _ShowNameInLists;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowNameInLists != value)
                {
					var __oldValue = _ShowNameInLists;
                    NotifyPropertyChanging("ShowNameInLists", __oldValue, value);
                    _ShowNameInLists = value;
                    NotifyPropertyChanged("ShowNameInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowNameInLists;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>

		public virtual System.Type GetDataType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_DataType != null)
            {
                OnGetDataType_DataType(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DataType.GetDataType");
            }
            return e.Result;
        }
		public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret);
		public event GetDataType_Handler<DataType> OnGetDataType_DataType;



        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>

		public virtual string GetDataTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_DataType != null)
            {
                OnGetDataTypeString_DataType(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DataType.GetDataTypeString");
            }
            return e.Result;
        }
		public delegate void GetDataTypeString_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetDataTypeString_Handler<DataType> OnGetDataTypeString_DataType;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DataType));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DataType)obj;
			var otherImpl = (DataType__Implementation__)obj;
			var me = (DataType)this;

			me.ClassName = other.ClassName;
			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.ShowIconInLists = other.ShowIconInLists;
			me.ShowIdInLists = other.ShowIdInLists;
			me.ShowNameInLists = other.ShowNameInLists;
			this._fk_DefaultIcon = otherImpl._fk_DefaultIcon;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DataType != null)
            {
                OnToString_DataType(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DataType> OnToString_DataType;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DataType != null) OnPreSave_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnPreSave_DataType;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DataType != null) OnPostSave_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnPostSave_DataType;

        public override void NotifyCreated()
        {
            try
            {
				this.ExportGuid = (Guid)FrozenContext.Single.Find<Kistl.App.Base.Property>(17).DefaultValue.GetDefaultValue();
            }
            catch (NotImplementedException)
            {
                // TODO: Find a better way to ignore bootstrap errors.
                // During bootstrapping no MethodInvocation is registred
            }
            base.NotifyCreated();
            if (OnCreated_DataType != null) OnCreated_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnCreated_DataType;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DataType != null) OnDeleting_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnDeleting_DataType;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ClassName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(163).Constraints
						.Where(c => !c.IsValid(this, this.ClassName))
						.Select(c => c.GetErrorText(this, this.ClassName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DefaultIcon":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(140).Constraints
						.Where(c => !c.IsValid(this, this.DefaultIcon))
						.Select(c => c.GetErrorText(this, this.DefaultIcon))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(160).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(17).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MethodInvocations":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(55).Constraints
						.Where(c => !c.IsValid(this, this.MethodInvocations))
						.Select(c => c.GetErrorText(this, this.MethodInvocations))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Methods":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(49).Constraints
						.Where(c => !c.IsValid(this, this.Methods))
						.Select(c => c.GetErrorText(this, this.Methods))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(148).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Properties":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(43).Constraints
						.Where(c => !c.IsValid(this, this.Properties))
						.Select(c => c.GetErrorText(this, this.Properties))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIconInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(61).Constraints
						.Where(c => !c.IsValid(this, this.ShowIconInLists))
						.Select(c => c.GetErrorText(this, this.ShowIconInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIdInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(64).Constraints
						.Where(c => !c.IsValid(this, this.ShowIdInLists))
						.Select(c => c.GetErrorText(this, this.ShowIdInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowNameInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(67).Constraints
						.Where(c => !c.IsValid(this, this.ShowNameInLists))
						.Select(c => c.GetErrorText(this, this.ShowNameInLists))
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

			if (_fk_guid_DefaultIcon.HasValue)
				DefaultIcon__Implementation__ = (Kistl.App.GUI.Icon__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.Icon>(_fk_guid_DefaultIcon.Value);
			else if (_fk_DefaultIcon.HasValue)
				DefaultIcon__Implementation__ = (Kistl.App.GUI.Icon__Implementation__)Context.Find<Kistl.App.GUI.Icon>(_fk_DefaultIcon.Value);
			else
				DefaultIcon__Implementation__ = null;

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._ClassName, binStream);
            BinarySerializer.ToStream(DefaultIcon != null ? DefaultIcon.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(DefaultIcon);
			}
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ShowIconInLists, binStream);
            BinarySerializer.ToStream(this._ShowIdInLists, binStream);
            BinarySerializer.ToStream(this._ShowNameInLists, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._ClassName, binStream);
            BinarySerializer.FromStream(out this._fk_DefaultIcon, binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._ShowIconInLists, binStream);
            BinarySerializer.FromStream(out this._ShowIdInLists, binStream);
            BinarySerializer.FromStream(out this._ShowNameInLists, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._ClassName, xml, "ClassName", "Kistl.App.Base");
            XmlStreamer.ToStream(DefaultIcon != null ? DefaultIcon.ID : (int?)null, xml, "DefaultIcon", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._ClassName, xml, "ClassName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_DefaultIcon, xml, "DefaultIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ClassName, xml, "ClassName", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(DefaultIcon != null ? DefaultIcon.ExportGuid : (Guid?)null, xml, "DefaultIcon", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ClassName, xml, "ClassName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_DefaultIcon, xml, "DefaultIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

#endregion

    }


}