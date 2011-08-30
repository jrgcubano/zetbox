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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ControlKind")]
    [System.Diagnostics.DebuggerDisplay("ControlKind")]
    public class ControlKindEfImpl : BaseServerDataObject_EntityFramework, ControlKind, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public ControlKindEfImpl()
            : base(null)
        {
        }

        public ControlKindEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ChildControlKinds_have_a_Parent
    A: ZeroOrMore ControlKind as ChildControlKinds
    B: ZeroOrOne ControlKind as Parent
    Preferred Storage: MergeIntoA
    */
        // object list property
        // object list property
           // Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.ControlKind> ChildControlKinds
        {
            get
            {
                if (_ChildControlKinds == null)
                {
                    _ChildControlKinds = new EntityCollectionWrapper<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKindEfImpl>(
                            this.Context, ChildControlKindsImpl,
                            () => this.NotifyPropertyChanging("ChildControlKinds", null, null, null),
                            () => this.NotifyPropertyChanged("ChildControlKinds", null, null, null),
                            (item) => item.NotifyPropertyChanging("Parent", null, null, null),
                            (item) => item.NotifyPropertyChanged("Parent", null, null, null));
                }
                return _ChildControlKinds;
            }
        }
    
        [EdmRelationshipNavigationProperty("Model", "FK_ChildControlKinds_have_a_Parent", "ChildControlKinds")]
        public EntityCollection<Kistl.App.GUI.ControlKindEfImpl> ChildControlKindsImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.GUI.ControlKindEfImpl>(
                        "Model.FK_ChildControlKinds_have_a_Parent",
                        "ChildControlKinds");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKindEfImpl> _ChildControlKinds;



        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("758d8eba-b458-4cd4-98a8-e08713912654"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ControlKind.ExportGuid'");
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
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ControlKind_has_Module
    A: ZeroOrMore ControlKind as ControlKind
    B: One Module as Module
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Kistl.App.Base.Module; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Kistl.App.Base.ModuleEfImpl)value; }
        }

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ControlKind_has_Module", "Module")]
        public Kistl.App.Base.ModuleEfImpl ModuleImpl
        {
            get
            {
                Kistl.App.Base.ModuleEfImpl __value;
                EntityReference<Kistl.App.Base.ModuleEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleEfImpl>(
                        "Model.FK_ControlKind_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Kistl.App.Base.ModuleEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.ModuleEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleEfImpl>(
                        "Model.FK_ControlKind_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.ModuleEfImpl __oldValue = (Kistl.App.Base.ModuleEfImpl)r.Value;
                Kistl.App.Base.ModuleEfImpl __newValue = (Kistl.App.Base.ModuleEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Module", null, __oldValue, __newValue);

                if (OnModule_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ModuleEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.ModuleEfImpl)__newValue;

                if (OnModule_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Module", null, __oldValue, __newValue);
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_PostSetter;

        /// <summary>
        /// Name of this ControlKind
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, string> OnName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ChildControlKinds_have_a_Parent
    A: ZeroOrMore ControlKind as ChildControlKinds
    B: ZeroOrOne ControlKind as Parent
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=_fk_Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Kistl.App.GUI.ControlKind; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=ChildControlKinds; is list;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.ControlKind Parent
        {
            get { return ParentImpl; }
            set { ParentImpl = (Kistl.App.GUI.ControlKindEfImpl)value; }
        }

        private int? _fk_Parent;

        private Guid? _fk_guid_Parent = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ChildControlKinds_have_a_Parent", "Parent")]
        public Kistl.App.GUI.ControlKindEfImpl ParentImpl
        {
            get
            {
                Kistl.App.GUI.ControlKindEfImpl __value;
                EntityReference<Kistl.App.GUI.ControlKindEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindEfImpl>(
                        "Model.FK_ChildControlKinds_have_a_Parent",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.ControlKind>(__value);
                    OnParent_Getter(this, e);
                    __value = (Kistl.App.GUI.ControlKindEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.GUI.ControlKindEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindEfImpl>(
                        "Model.FK_ChildControlKinds_have_a_Parent",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.GUI.ControlKindEfImpl __oldValue = (Kistl.App.GUI.ControlKindEfImpl)r.Value;
                Kistl.App.GUI.ControlKindEfImpl __newValue = (Kistl.App.GUI.ControlKindEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("ChildControlKinds", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("ChildControlKinds", null, null, null);
                }

                if (OnParent_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.ControlKindEfImpl)e.Result;
                }

                r.Value = (Kistl.App.GUI.ControlKindEfImpl)__newValue;

                if (OnParent_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("ChildControlKinds", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("ChildControlKinds", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(ControlKind);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ControlKind)obj;
            var otherImpl = (ControlKindEfImpl)obj;
            var me = (ControlKind)this;

            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_Module = otherImpl._fk_Module;
            this._fk_Parent = otherImpl._fk_Parent;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "Module":
                    __oldValue = _fk_Module;
                    NotifyPropertyChanging("Module", __oldValue, __newValue);
                    _fk_Module = __newValue;
                    NotifyPropertyChanged("Module", __oldValue, __newValue);
                    break;
                case "Parent":
                    __oldValue = _fk_Parent;
                    NotifyPropertyChanging("Parent", __oldValue, __newValue);
                    _fk_Parent = __newValue;
                    NotifyPropertyChanged("Parent", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleEfImpl)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleEfImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;

            if (_fk_guid_Parent.HasValue)
                ParentImpl = (Kistl.App.GUI.ControlKindEfImpl)Context.FindPersistenceObject<Kistl.App.GUI.ControlKind>(_fk_guid_Parent.Value);
            else
            if (_fk_Parent.HasValue)
                ParentImpl = (Kistl.App.GUI.ControlKindEfImpl)Context.Find<Kistl.App.GUI.ControlKind>(_fk_Parent.Value);
            else
                ParentImpl = null;
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<ControlKindEfImpl, ICollection<Kistl.App.GUI.ControlKind>>(
                        lazyCtx,
                        new Guid("bf073bb5-eaa8-4e3d-b019-60b47ba6a088"),
                        "ChildControlKinds",
                        null,
                        obj => obj.ChildControlKinds,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorEfImpl<ControlKindEfImpl, Guid>(
                        lazyCtx,
                        new Guid("758d8eba-b458-4cd4-98a8-e08713912654"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val),
                    // else
                    new PropertyDescriptorEfImpl<ControlKindEfImpl, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("e4cf2c2d-be50-4954-a43c-b8df2dedecec"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val),
                    // else
                    new PropertyDescriptorEfImpl<ControlKindEfImpl, string>(
                        lazyCtx,
                        new Guid("438ab847-c5d1-4072-9449-96e3d4e92b1f"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val),
                    // else
                    new PropertyDescriptorEfImpl<ControlKindEfImpl, Kistl.App.GUI.ControlKind>(
                        lazyCtx,
                        new Guid("5d75bf4f-29dd-4d00-8e4f-b40a1b9ad92c"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val),
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ControlKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ControlKind != null)
            {
                OnToString_ControlKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ControlKind> OnToString_ControlKind;

        [EventBasedMethod("OnPreSave_ControlKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ControlKind != null) OnPreSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnPreSave_ControlKind;

        [EventBasedMethod("OnPostSave_ControlKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ControlKind != null) OnPostSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnPostSave_ControlKind;

        [EventBasedMethod("OnCreated_ControlKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ControlKind != null) OnCreated_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnCreated_ControlKind;

        [EventBasedMethod("OnDeleting_ControlKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ControlKind != null) OnDeleting_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnDeleting_ControlKind;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
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
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleEfImpl>("Model.FK_ControlKind_has_Module", "Module").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
            BinarySerializer.ToStream(this._Name, binStream);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindEfImpl>("Model.FK_ChildControlKinds_have_a_Parent", "Parent").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleEfImpl>("Model.FK_ControlKind_has_Module", "Module").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Module", "Kistl.App.GUI");
            }
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.GUI");
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindEfImpl>("Model.FK_ChildControlKinds_have_a_Parent", "Parent").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Parent", "Kistl.App.GUI");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.GUI");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Parent != null ? Parent.ExportGuid : (Guid?)null, xml, "Parent", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // Import must have default value set
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Parent, xml, "Parent", "Kistl.App.GUI");
        }

        #endregion

    }
}