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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectReferenceProperty")]
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceProperty")]
    public class ObjectReferencePropertyEfImpl : Kistl.App.Base.PropertyEfImpl, ObjectReferenceProperty
    {
        [Obsolete]
        public ObjectReferencePropertyEfImpl()
            : base(null)
        {
        }

        public ObjectReferencePropertyEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Whether or not this reference should be loaded eagerly
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public bool EagerLoading
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _EagerLoading;
                if (OnEagerLoading_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnEagerLoading_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_EagerLoading != value)
                {
                    var __oldValue = _EagerLoading;
                    var __newValue = value;
                    if (OnEagerLoading_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("EagerLoading", __oldValue, __newValue);
                    _EagerLoading = __newValue;
                    NotifyPropertyChanged("EagerLoading", __oldValue, __newValue);
                    if (OnEagerLoading_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _EagerLoading;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PostSetter;

        /// <summary>
        /// Simple objects are inline editable in lists. Use this property to override this default. If true, the referenced instances are editable in lists, otherwise not.
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public bool? IsInlineEditable
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsInlineEditable;
                if (OnIsInlineEditable_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsInlineEditable_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsInlineEditable != value)
                {
                    var __oldValue = _IsInlineEditable;
                    var __newValue = value;
                    if (OnIsInlineEditable_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsInlineEditable_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsInlineEditable", __oldValue, __newValue);
                    _IsInlineEditable = __newValue;
                    NotifyPropertyChanged("IsInlineEditable", __oldValue, __newValue);
                    if (OnIsInlineEditable_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsInlineEditable_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool? _IsInlineEditable;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PostSetter;

        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
    /*
    Relation: FK_RelationEnd_has_Navigator
    A: ZeroOrOne RelationEnd as RelationEnd
    B: ZeroOrOne ObjectReferenceProperty as Navigator
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
        // fkBackingName=_fk_RelationEnd; fkGuidBackingName=_fk_guid_RelationEnd;
        // referencedInterface=Kistl.App.Base.RelationEnd; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=Navigator; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd RelationEnd
        {
            get { return RelationEndImpl; }
            set { RelationEndImpl = (Kistl.App.Base.RelationEndEfImpl)value; }
        }

        private int? _fk_RelationEnd;

        private Guid? _fk_guid_RelationEnd = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_RelationEnd_has_Navigator", "RelationEnd")]
        public Kistl.App.Base.RelationEndEfImpl RelationEndImpl
        {
            get
            {
                Kistl.App.Base.RelationEndEfImpl __value;
                EntityReference<Kistl.App.Base.RelationEndEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEndEfImpl>(
                        "Model.FK_RelationEnd_has_Navigator",
                        "RelationEnd");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnRelationEnd_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
                    OnRelationEnd_Getter(this, e);
                    __value = (Kistl.App.Base.RelationEndEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.RelationEndEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEndEfImpl>(
                        "Model.FK_RelationEnd_has_Navigator",
                        "RelationEnd");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.RelationEndEfImpl __oldValue = (Kistl.App.Base.RelationEndEfImpl)r.Value;
                Kistl.App.Base.RelationEndEfImpl __newValue = (Kistl.App.Base.RelationEndEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("RelationEnd", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Navigator", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Navigator", null, null, null);
                }

                if (OnRelationEnd_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.RelationEndEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.RelationEndEfImpl)__newValue;

                if (OnRelationEnd_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("RelationEnd", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("Navigator", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("Navigator", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetIsList_ObjectReferenceProperty")]
        public virtual bool GetIsList()
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnGetIsList_ObjectReferenceProperty != null)
            {
                OnGetIsList_ObjectReferenceProperty(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectReferenceProperty.GetIsList");
            }
            return e.Result;
        }
        public delegate void GetIsList_Handler<T>(T obj, MethodReturnEventArgs<bool> ret);
        public static event GetIsList_Handler<ObjectReferenceProperty> OnGetIsList_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ObjectReferenceProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ObjectReferenceProperty != null)
            {
                OnGetLabel_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ObjectReferenceProperty> OnGetLabel_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_ObjectReferenceProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ObjectReferenceProperty != null)
            {
                OnGetPropertyType_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_ObjectReferenceProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectReferenceProperty)obj;
            var otherImpl = (ObjectReferencePropertyEfImpl)obj;
            var me = (ObjectReferenceProperty)this;

            me.EagerLoading = other.EagerLoading;
            me.IsInlineEditable = other.IsInlineEditable;
            this._fk_RelationEnd = otherImpl._fk_RelationEnd;
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
                case "RelationEnd":
                    __oldValue = _fk_RelationEnd;
                    NotifyPropertyChanging("RelationEnd", __oldValue, __newValue);
                    _fk_RelationEnd = __newValue;
                    NotifyPropertyChanged("RelationEnd", __oldValue, __newValue);
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

            if (_fk_guid_RelationEnd.HasValue)
                RelationEndImpl = (Kistl.App.Base.RelationEndEfImpl)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_RelationEnd.Value);
            else
            if (_fk_RelationEnd.HasValue)
                RelationEndImpl = (Kistl.App.Base.RelationEndEfImpl)Context.Find<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value);
            else
                RelationEndImpl = null;
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
                    // else
                    new PropertyDescriptorEfImpl<ObjectReferencePropertyEfImpl, bool>(
                        lazyCtx,
                        new Guid("373f0036-42d6-41e2-a2a4-74462537f426"),
                        "EagerLoading",
                        null,
                        obj => obj.EagerLoading,
                        (obj, val) => obj.EagerLoading = val),
                    // else
                    new PropertyDescriptorEfImpl<ObjectReferencePropertyEfImpl, bool?>(
                        lazyCtx,
                        new Guid("f7183d87-8cc8-4703-b148-02db9f5bf9bc"),
                        "IsInlineEditable",
                        null,
                        obj => obj.IsInlineEditable,
                        (obj, val) => obj.IsInlineEditable = val),
                    // else
                    new PropertyDescriptorEfImpl<ObjectReferencePropertyEfImpl, Kistl.App.Base.RelationEnd>(
                        lazyCtx,
                        new Guid("63ba109d-92c6-4ced-980b-0a52aabfaec0"),
                        "RelationEnd",
                        null,
                        obj => obj.RelationEnd,
                        (obj, val) => obj.RelationEnd = val),
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
        [EventBasedMethod("OnToString_ObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceProperty != null)
            {
                OnToString_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;

        [EventBasedMethod("OnPreSave_ObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceProperty != null) OnPreSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_ObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceProperty != null) OnPostSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;

        [EventBasedMethod("OnCreated_ObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectReferenceProperty != null) OnCreated_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnCreated_ObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_ObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectReferenceProperty != null) OnDeleting_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnDeleting_ObjectReferenceProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._EagerLoading, binStream);
            BinarySerializer.ToStream(this._IsInlineEditable, binStream);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEndEfImpl>("Model.FK_RelationEnd_has_Navigator", "RelationEnd").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._EagerLoading, binStream);
            BinarySerializer.FromStream(out this._IsInlineEditable, binStream);
            BinarySerializer.FromStream(out this._fk_RelationEnd, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEndEfImpl>("Model.FK_RelationEnd_has_Navigator", "RelationEnd").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "RelationEnd", "Kistl.App.Base");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ExportGuid : (Guid?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

        #endregion

    }
}