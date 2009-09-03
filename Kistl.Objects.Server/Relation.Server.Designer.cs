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
    /// Describes a Relation between two Object Classes
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Relation")]
    [System.Diagnostics.DebuggerDisplay("Relation")]
    public class Relation__Implementation__ : BaseServerDataObject_EntityFramework, Kistl.API.IExportableInternal, Relation
    {
    
		public Relation__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
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
        /// The A-side of this Relation.
        /// </summary>
    /*
    Relation: FK_Relation_hasA_RelationEnd
    A: ZeroOrOne Relation as Relation
    B: ZeroOrOne RelationEnd as A
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd A
        {
            get
            {
                return A__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_A;
        private Guid? _fk_guid_A = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Relation_hasA_RelationEnd", "A")]
        public Kistl.App.Base.RelationEnd__Implementation__ A__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasA_RelationEnd",
                        "A");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnA_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
					OnA_Getter(this, e);
					__value = (Kistl.App.Base.RelationEnd__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasA_RelationEnd",
                        "A");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.RelationEnd __oldValue = (Kistl.App.Base.RelationEnd)r.Value;
                Kistl.App.Base.RelationEnd __newValue = (Kistl.App.Base.RelationEnd)value;

                if(OnA_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnA_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)__newValue;
                if(OnA_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnA_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnA_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnA_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnA_PostSetter;
        /// <summary>
        /// The B-side of this Relation.
        /// </summary>
    /*
    Relation: FK_Relation_hasB_RelationEnd
    A: ZeroOrOne Relation as Relation
    B: ZeroOrOne RelationEnd as B
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd B
        {
            get
            {
                return B__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_B;
        private Guid? _fk_guid_B = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Relation_hasB_RelationEnd", "B")]
        public Kistl.App.Base.RelationEnd__Implementation__ B__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasB_RelationEnd",
                        "B");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnB_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
					OnB_Getter(this, e);
					__value = (Kistl.App.Base.RelationEnd__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasB_RelationEnd",
                        "B");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.RelationEnd __oldValue = (Kistl.App.Base.RelationEnd)r.Value;
                Kistl.App.Base.RelationEnd __newValue = (Kistl.App.Base.RelationEnd)value;

                if(OnB_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnB_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)__newValue;
                if(OnB_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnB_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnB_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnB_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.RelationEnd> OnB_PostSetter;
        /// <summary>
        /// Description of this Relation
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Description
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Description;
                if (OnDescription_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDescription_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
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
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Description", __oldValue, __newValue);
                    _Description = __newValue;
                    NotifyPropertyChanged("Description", __oldValue, __newValue);
                    if(OnDescription_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Description;
		public event PropertyGetterHandler<Kistl.App.Base.Relation, string> OnDescription_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, string> OnDescription_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, string> OnDescription_PostSetter;
        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("1e600012-3b35-4dc6-af28-1f858b095a15"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'Relation.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if(OnExportGuid_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(OnExportGuid_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public event PropertyGetterHandler<Kistl.App.Base.Relation, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Module_has_Relation
    A: One Module as Module
    B: ZeroOrMore Relation as Relation
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
        [EdmRelationshipNavigationProperty("Model", "FK_Module_has_Relation", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_Relation",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnModule_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
					OnModule_Getter(this, e);
					__value = (Kistl.App.Base.Module__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_Relation",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Module __oldValue = (Kistl.App.Base.Module)r.Value;
                Kistl.App.Base.Module __newValue = (Kistl.App.Base.Module)value;

                if(OnModule_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)__newValue;
                if(OnModule_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.Module> OnModule_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.Module> OnModule_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.Module> OnModule_PostSetter;
        /// <summary>
        /// Storagetype for 1:1 Relations. Must be null for non 1:1 Relations.
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Base.StorageType Storage
        {
            get
            {
				var __value = _Storage;
				if(OnStorage_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.StorageType>(__value);
					OnStorage_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Storage != value)
                {
					var __oldValue = _Storage;
					var __newValue = value;
                    if(OnStorage_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.Base.StorageType>(__oldValue, __newValue);
						OnStorage_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("Storage", "Storage__Implementation__", __oldValue, __newValue);
                    _Storage = value;
                    NotifyPropertyChanged("Storage", "Storage__Implementation__", __oldValue, __newValue);
                    if(OnStorage_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.Base.StorageType>(__oldValue, __newValue);
						OnStorage_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for Storage</summary>
        private Kistl.App.Base.StorageType _Storage;
        
        /// <summary>EF sees only this property, for Storage</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int Storage__Implementation__
        {
            get
            {
                return (int)this.Storage;
            }
            set
            {
                this.Storage = (Kistl.App.Base.StorageType)value;
            }
        }
        
		public event PropertyGetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.StorageType> OnStorage_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.StorageType> OnStorage_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, Kistl.App.Base.StorageType> OnStorage_PostSetter;
        /// <summary>
        /// Verb of this Relation
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Verb
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Verb;
                if (OnVerb_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnVerb_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Verb != value)
                {
                    var __oldValue = _Verb;
                    var __newValue = value;
                    if(OnVerb_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnVerb_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Verb", __oldValue, __newValue);
                    _Verb = __newValue;
                    NotifyPropertyChanged("Verb", __oldValue, __newValue);
                    if(OnVerb_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnVerb_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Verb;
		public event PropertyGetterHandler<Kistl.App.Base.Relation, string> OnVerb_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Relation, string> OnVerb_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Relation, string> OnVerb_PostSetter;
        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetEnd_Relation")]
		public virtual Kistl.App.Base.RelationEnd GetEnd(Kistl.App.Base.ObjectReferenceProperty prop) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.RelationEnd>();
            if (OnGetEnd_Relation != null)
            {
                OnGetEnd_Relation(this, e, prop);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Relation.GetEnd");
            }
            return e.Result;
        }
		public delegate void GetEnd_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.RelationEnd> ret, Kistl.App.Base.ObjectReferenceProperty prop);
		public event GetEnd_Handler<Relation> OnGetEnd_Relation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetEndFromRole_Relation")]
		public virtual Kistl.App.Base.RelationEnd GetEndFromRole(Kistl.API.RelationEndRole role) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.RelationEnd>();
            if (OnGetEndFromRole_Relation != null)
            {
                OnGetEndFromRole_Relation(this, e, role);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Relation.GetEndFromRole");
            }
            return e.Result;
        }
		public delegate void GetEndFromRole_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.RelationEnd> ret, Kistl.API.RelationEndRole role);
		public event GetEndFromRole_Handler<Relation> OnGetEndFromRole_Relation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetOtherEnd_Relation")]
		public virtual Kistl.App.Base.RelationEnd GetOtherEnd(Kistl.App.Base.RelationEnd relEnd) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.RelationEnd>();
            if (OnGetOtherEnd_Relation != null)
            {
                OnGetOtherEnd_Relation(this, e, relEnd);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Relation.GetOtherEnd");
            }
            return e.Result;
        }
		public delegate void GetOtherEnd_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.RelationEnd> ret, Kistl.App.Base.RelationEnd relEnd);
		public event GetOtherEnd_Handler<Relation> OnGetOtherEnd_Relation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetRelationType_Relation")]
		public virtual Kistl.API.RelationType GetRelationType() 
        {
            var e = new MethodReturnEventArgs<Kistl.API.RelationType>();
            if (OnGetRelationType_Relation != null)
            {
                OnGetRelationType_Relation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Relation.GetRelationType");
            }
            return e.Result;
        }
		public delegate void GetRelationType_Handler<T>(T obj, MethodReturnEventArgs<Kistl.API.RelationType> ret);
		public event GetRelationType_Handler<Relation> OnGetRelationType_Relation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnNeedsPositionStorage_Relation")]
		public virtual bool NeedsPositionStorage(Kistl.API.RelationEndRole endRole) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnNeedsPositionStorage_Relation != null)
            {
                OnNeedsPositionStorage_Relation(this, e, endRole);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Relation.NeedsPositionStorage");
            }
            return e.Result;
        }
		public delegate void NeedsPositionStorage_Handler<T>(T obj, MethodReturnEventArgs<bool> ret, Kistl.API.RelationEndRole endRole);
		public event NeedsPositionStorage_Handler<Relation> OnNeedsPositionStorage_Relation;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Relation));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Relation)obj;
			var otherImpl = (Relation__Implementation__)obj;
			var me = (Relation)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.Storage = other.Storage;
			me.Verb = other.Verb;
			this._fk_A = otherImpl._fk_A;
			this._fk_B = otherImpl._fk_B;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Relation")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Relation != null)
            {
                OnToString_Relation(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Relation> OnToString_Relation;

        [EventBasedMethod("OnPreSave_Relation")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Relation != null) OnPreSave_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnPreSave_Relation;

        [EventBasedMethod("OnPostSave_Relation")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Relation != null) OnPostSave_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnPostSave_Relation;

        [EventBasedMethod("OnCreated_Relation")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Relation != null) OnCreated_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnCreated_Relation;

        [EventBasedMethod("OnDeleting_Relation")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Relation != null) OnDeleting_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnDeleting_Relation;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "A":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("d4429d3c-8fd1-468e-88d5-17abfd658d04")).Constraints
						.Where(c => !c.IsValid(this, this.A))
						.Select(c => c.GetErrorText(this, this.A))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "B":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("20331803-079e-471e-ae45-f4d004aef48e")).Constraints
						.Where(c => !c.IsValid(this, this.B))
						.Select(c => c.GetErrorText(this, this.B))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("56948ee3-f1a7-44c3-956a-9baa863c5092")).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("1e600012-3b35-4dc6-af28-1f858b095a15")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("2a1a99a4-7dd5-4244-913f-06315f3de831")).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Storage":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("ba4f10fd-f7cf-4237-93a6-734e7e5c6b8a")).Constraints
						.Where(c => !c.IsValid(this, this.Storage))
						.Select(c => c.GetErrorText(this, this.Storage))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Verb":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("cd7a8de3-a1bf-4043-93d9-d9874b40bb69")).Constraints
						.Where(c => !c.IsValid(this, this.Verb))
						.Select(c => c.GetErrorText(this, this.Verb))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_A.HasValue)
				A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_A.Value);
			else if (_fk_A.HasValue)
				A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_A.Value);
			else
				A__Implementation__ = null;

			if (_fk_guid_B.HasValue)
				B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_B.Value);
			else if (_fk_B.HasValue)
				B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_B.Value);
			else
				B__Implementation__ = null;

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
            BinarySerializer.ToStream(A != null ? A.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(A);
			}
            BinarySerializer.ToStream(B != null ? B.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(B);
			}
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream((int)((Relation)this).Storage, binStream);
            BinarySerializer.ToStream(this._Verb, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_A, binStream);
            BinarySerializer.FromStream(out this._fk_B, binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, binStream);
            BinarySerializer.FromStream(out this._Verb, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(A != null ? A.ID : (int?)null, xml, "A", "Kistl.App.Base");
            XmlStreamer.ToStream(B != null ? B.ID : (int?)null, xml, "B", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
            XmlStreamer.ToStream((int)this.Storage, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_A, xml, "A", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_B, xml, "B", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(A != null ? A.ExportGuid : (Guid?)null, xml, "A", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(B != null ? B.ExportGuid : (Guid?)null, xml, "B", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream((int)this.Storage, xml, "Storage", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_A, xml, "A", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_B, xml, "B", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Verb, xml, "Verb", "Kistl.App.Base");
        }

#endregion

    }


}