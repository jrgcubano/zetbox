// <autogenerated/>


namespace Kistl.App.GUI
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
    [EdmEntityType(NamespaceName="Model", Name="ViewDescriptor")]
    [System.Diagnostics.DebuggerDisplay("ViewDescriptor")]
    public class ViewDescriptor__Implementation__ : BaseServerDataObject_EntityFramework, Kistl.API.IExportableInternal, ViewDescriptor
    {
    
		public ViewDescriptor__Implementation__()
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
        /// The control implementing this View
        /// </summary>
    /*
    Relation: FK_View_has_ControlRef
    A: ZeroOrMore ViewDescriptor as View
    B: One TypeRef as ControlRef
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef ControlRef
        {
            get
            {
                return ControlRef__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        private int? _fk_ControlRef;
        private Guid? _fk_guid_ControlRef = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_View_has_ControlRef", "ControlRef")]
        public Kistl.App.Base.TypeRef__Implementation__ ControlRef__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_View_has_ControlRef",
                        "ControlRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnControlRef_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
					OnControlRef_Getter(this, e);
					__value = (Kistl.App.Base.TypeRef__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_View_has_ControlRef",
                        "ControlRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.TypeRef __oldValue = (Kistl.App.Base.TypeRef)r.Value;
                Kistl.App.Base.TypeRef __newValue = (Kistl.App.Base.TypeRef)value;

                if(OnControlRef_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnControlRef_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)__newValue;
                if(OnControlRef_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnControlRef_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.TypeRef> OnControlRef_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.TypeRef> OnControlRef_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.TypeRef> OnControlRef_PostSetter;
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
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("94140a56-9fed-4d65-8c2c-cb8e658dff96"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'ViewDescriptor.ExportGuid'");
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
		public event PropertyGetterHandler<Kistl.App.GUI.ViewDescriptor, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.ViewDescriptor, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.ViewDescriptor, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Control_isof_Kind
    A: ZeroOrMore ViewDescriptor as Control
    B: ZeroOrOne ControlKindClass as Kind
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.ControlKindClass Kind
        {
            get
            {
                return Kind__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Kind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)value;
            }
        }
        
        private int? _fk_Kind;
        private Guid? _fk_guid_Kind = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Control_isof_Kind", "Kind")]
        public Kistl.App.GUI.ControlKindClass__Implementation__ Kind__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.ControlKindClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindClass__Implementation__>(
                        "Model.FK_Control_isof_Kind",
                        "Kind");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnKind_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.GUI.ControlKindClass>(__value);
					OnKind_Getter(this, e);
					__value = (Kistl.App.GUI.ControlKindClass__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.ControlKindClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindClass__Implementation__>(
                        "Model.FK_Control_isof_Kind",
                        "Kind");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.GUI.ControlKindClass __oldValue = (Kistl.App.GUI.ControlKindClass)r.Value;
                Kistl.App.GUI.ControlKindClass __newValue = (Kistl.App.GUI.ControlKindClass)value;

                if(OnKind_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ControlKindClass>(__oldValue, __newValue);
					OnKind_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.GUI.ControlKindClass__Implementation__)__newValue;
                if(OnKind_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ControlKindClass>(__oldValue, __newValue);
					OnKind_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.ControlKindClass> OnKind_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.ControlKindClass> OnKind_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.ControlKindClass> OnKind_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ViewDescriptor_has_Module
    A: ZeroOrMore ViewDescriptor as ViewDescriptor
    B: ZeroOrOne Module as Module
    Preferred Storage: MergeIntoA
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
        [EdmRelationshipNavigationProperty("Model", "FK_ViewDescriptor_has_Module", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_ViewDescriptor_has_Module",
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
                        "Model.FK_ViewDescriptor_has_Module",
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
        
        
		public event PropertyGetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.Module> OnModule_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.Module> OnModule_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.Base.Module> OnModule_PostSetter;
        /// <summary>
        /// Which toolkit provides this View
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.GUI.Toolkit Toolkit
        {
            get
            {
				var __value = _Toolkit;
				if(OnToolkit_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.GUI.Toolkit>(__value);
					OnToolkit_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Toolkit != value)
                {
					var __oldValue = _Toolkit;
					var __newValue = value;
                    if(OnToolkit_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Toolkit>(__oldValue, __newValue);
						OnToolkit_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("Toolkit", "Toolkit__Implementation__", __oldValue, __newValue);
                    _Toolkit = value;
                    NotifyPropertyChanged("Toolkit", "Toolkit__Implementation__", __oldValue, __newValue);
                    if(OnToolkit_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Toolkit>(__oldValue, __newValue);
						OnToolkit_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for Toolkit</summary>
        private Kistl.App.GUI.Toolkit _Toolkit;
        
        /// <summary>EF sees only this property, for Toolkit</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int Toolkit__Implementation__
        {
            get
            {
                return (int)this.Toolkit;
            }
            set
            {
                this.Toolkit = (Kistl.App.GUI.Toolkit)value;
            }
        }
        
		public event PropertyGetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.Toolkit> OnToolkit_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.Toolkit> OnToolkit_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.ViewDescriptor, Kistl.App.GUI.Toolkit> OnToolkit_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ViewDescriptor));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ViewDescriptor)obj;
			var otherImpl = (ViewDescriptor__Implementation__)obj;
			var me = (ViewDescriptor)this;

			me.ExportGuid = other.ExportGuid;
			me.Toolkit = other.Toolkit;
			this._fk_ControlRef = otherImpl._fk_ControlRef;
			this._fk_Kind = otherImpl._fk_Kind;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ViewDescriptor")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ViewDescriptor != null)
            {
                OnToString_ViewDescriptor(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ViewDescriptor> OnToString_ViewDescriptor;

        [EventBasedMethod("OnPreSave_ViewDescriptor")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ViewDescriptor != null) OnPreSave_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnPreSave_ViewDescriptor;

        [EventBasedMethod("OnPostSave_ViewDescriptor")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ViewDescriptor != null) OnPostSave_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnPostSave_ViewDescriptor;

        [EventBasedMethod("OnCreated_ViewDescriptor")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ViewDescriptor != null) OnCreated_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnCreated_ViewDescriptor;

        [EventBasedMethod("OnDeleting_ViewDescriptor")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ViewDescriptor != null) OnDeleting_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnDeleting_ViewDescriptor;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ControlRef":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("eff6276d-975b-4a0d-bd3c-ad76af2189c3")).Constraints
						.Where(c => !c.IsValid(this, this.ControlRef))
						.Select(c => c.GetErrorText(this, this.ControlRef))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("94140a56-9fed-4d65-8c2c-cb8e658dff96")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kind":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("b7548d0b-f503-47fc-9808-52c491b8f2dd")).Constraints
						.Where(c => !c.IsValid(this, this.Kind))
						.Select(c => c.GetErrorText(this, this.Kind))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("25da3568-f362-4441-841e-7c163b10b983")).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Toolkit":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("2a798728-d79d-471f-be51-1f488beb8dc1")).Constraints
						.Where(c => !c.IsValid(this, this.Toolkit))
						.Select(c => c.GetErrorText(this, this.Toolkit))
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

			if (_fk_guid_ControlRef.HasValue)
				ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_ControlRef.Value);
			else if (_fk_ControlRef.HasValue)
				ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.Find<Kistl.App.Base.TypeRef>(_fk_ControlRef.Value);
			else
				ControlRef__Implementation__ = null;

			if (_fk_guid_Kind.HasValue)
				Kind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.ControlKindClass>(_fk_guid_Kind.Value);
			else if (_fk_Kind.HasValue)
				Kind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)Context.Find<Kistl.App.GUI.ControlKindClass>(_fk_Kind.Value);
			else
				Kind__Implementation__ = null;

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
            BinarySerializer.ToStream(ControlRef != null ? ControlRef.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(Kind != null ? Kind.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(Kind);
			}
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream((int)((ViewDescriptor)this).Toolkit, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_ControlRef, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Kind, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(ControlRef != null ? ControlRef.ID : (int?)null, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.GUI");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            }
            XmlStreamer.ToStream(Kind != null ? Kind.ID : (int?)null, xml, "Kind", "Kistl.App.GUI");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.ToStream((int)this.Toolkit, xml, "Toolkit", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_ControlRef, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.GUI");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            }
            XmlStreamer.FromStream(ref this._fk_Kind, xml, "Kind", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, xml, "Toolkit", "Kistl.App.GUI");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(ControlRef != null ? ControlRef.ExportGuid : (Guid?)null, xml, "ControlRef", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Kind != null ? Kind.ExportGuid : (Guid?)null, xml, "Kind", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream((int)this.Toolkit, xml, "Toolkit", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_ControlRef, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Kind, xml, "Kind", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, xml, "Toolkit", "Kistl.App.GUI");
        }

#endregion

    }


}