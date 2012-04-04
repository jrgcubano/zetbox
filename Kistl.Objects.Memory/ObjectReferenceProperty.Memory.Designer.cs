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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceProperty")]
    public class ObjectReferencePropertyMemoryImpl : Kistl.App.Base.PropertyMemoryImpl, ObjectReferenceProperty
    {
        [Obsolete]
        public ObjectReferencePropertyMemoryImpl()
            : base(null)
        {
        }

        public ObjectReferencePropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Whether or not this reference should be loaded eagerly
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool EagerLoading
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
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
				else 
				{
					SetInitializedProperty("EagerLoading");
				}
            }
        }
        private bool _EagerLoading;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.ObjectReferenceProperty> OnEagerLoading_IsValid;

        /// <summary>
        /// Simple objects are inline editable in lists. Use this property to override this default. If true, the referenced instances are editable in lists, otherwise not.
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool? IsInlineEditable
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool?);
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
				else 
				{
					SetInitializedProperty("IsInlineEditable");
				}
            }
        }
        private bool? _IsInlineEditable;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.ObjectReferenceProperty> OnIsInlineEditable_IsValid;

        /// <summary>
        /// This property will show these methods
        /// </summary>
        // collection entry list property
   		// Kistl.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Base.Method> Methods
		{
			get
			{
				if (_Methods == null)
				{
					Context.FetchRelation<Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl>(new Guid("02b3e9d5-fc2e-4ffe-8867-0977b88437cc"), RelationEndRole.A, this);
					_Methods 
						= new ObservableBSideCollectionWrapper<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.Method, Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl, ICollection<Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl>>(
							this, 
							new RelationshipFilterASideCollection<Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl>(this.Context, this));
				}
				return (ICollection<Kistl.App.Base.Method>)_Methods;
			}
		}

		private ObservableBSideCollectionWrapper<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.Method, Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl, ICollection<Kistl.App.GUI.ObjectReferenceProperty_shows_Method_RelationEntryMemoryImpl>> _Methods;

        public static event PropertyIsValidHandler<Kistl.App.Base.ObjectReferenceProperty> OnMethods_IsValid;

        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
	        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
        // fkBackingName=_fk_RelationEnd; fkGuidBackingName=_fk_guid_RelationEnd;
        // referencedInterface=Kistl.App.Base.RelationEnd; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=Navigator; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.RelationEnd RelationEnd
        {
            get { return RelationEndImpl; }
            set { RelationEndImpl = (Kistl.App.Base.RelationEndMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_RelationEnd;

        private Guid? _fk_guid_RelationEnd = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.RelationEndMemoryImpl RelationEndImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.RelationEndMemoryImpl __value;
                if (_fk_RelationEnd.HasValue)
                    __value = (Kistl.App.Base.RelationEndMemoryImpl)Context.Find<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value);
                else
                    __value = null;

                if (OnRelationEnd_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
                    OnRelationEnd_Getter(this, e);
                    __value = (Kistl.App.Base.RelationEndMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_RelationEnd == null)
                    return;
                else if (value != null && value.ID == _fk_RelationEnd)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = RelationEndImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("RelationEnd", __oldValue, __newValue);

                if (OnRelationEnd_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.RelationEndMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_RelationEnd = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.Navigator = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.Navigator = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("RelationEnd", __oldValue, __newValue);

                if (OnRelationEnd_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.ObjectReferenceProperty> OnRelationEnd_IsValid;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_ObjectReferenceProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_ObjectReferenceProperty != null)
            {
                OnGetElementTypeString_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<ObjectReferenceProperty> OnGetElementTypeString_ObjectReferenceProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetElementTypeString_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_ObjectReferenceProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_ObjectReferenceProperty_CanExec != null)
				{
					OnGetElementTypeString_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetElementTypeString_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_ObjectReferenceProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetElementTypeString_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetIsList_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetIsList_ObjectReferenceProperty_CanExec")]
        public virtual bool GetIsListCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetIsList_ObjectReferenceProperty_CanExec != null)
				{
					OnGetIsList_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetIsList_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetIsList_ObjectReferenceProperty_CanExecReason")]
        public virtual string GetIsListCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetIsList_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetIsList_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetLabel_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetLabel_ObjectReferenceProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_ObjectReferenceProperty_CanExec != null)
				{
					OnGetLabel_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetLabel_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_ObjectReferenceProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetLabel_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_ObjectReferenceProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_ObjectReferenceProperty != null)
            {
                OnGetName_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<ObjectReferenceProperty> OnGetName_ObjectReferenceProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetName_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetName_ObjectReferenceProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_ObjectReferenceProperty_CanExec != null)
				{
					OnGetName_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetName_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetName_ObjectReferenceProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetName_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_ObjectReferenceProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_ObjectReferenceProperty_CanExec != null)
				{
					OnGetPropertyType_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_ObjectReferenceProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetPropertyType_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_ObjectReferenceProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_ObjectReferenceProperty_CanExec != null)
				{
					OnGetPropertyTypeString_ObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_ObjectReferenceProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_ObjectReferenceProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_ObjectReferenceProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectReferenceProperty)obj;
            var otherImpl = (ObjectReferencePropertyMemoryImpl)obj;
            var me = (ObjectReferenceProperty)this;

            me.EagerLoading = other.EagerLoading;
            me.IsInlineEditable = other.IsInlineEditable;
            this._fk_RelationEnd = otherImpl._fk_RelationEnd;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "RelationEnd":
                    {
                        var __oldValue = _fk_RelationEnd;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("RelationEnd", __oldValue, __newValue);
                        _fk_RelationEnd = __newValue;
                        NotifyPropertyChanged("RelationEnd", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
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
                RelationEndImpl = (Kistl.App.Base.RelationEndMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_RelationEnd.Value);
            else
            if (_fk_RelationEnd.HasValue)
                RelationEndImpl = (Kistl.App.Base.RelationEndMemoryImpl)Context.Find<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value);
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
                    new PropertyDescriptorMemoryImpl<ObjectReferenceProperty, bool>(
                        lazyCtx,
                        new Guid("373f0036-42d6-41e2-a2a4-74462537f426"),
                        "EagerLoading",
                        null,
                        obj => obj.EagerLoading,
                        (obj, val) => obj.EagerLoading = val,
						obj => OnEagerLoading_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ObjectReferenceProperty, bool?>(
                        lazyCtx,
                        new Guid("f7183d87-8cc8-4703-b148-02db9f5bf9bc"),
                        "IsInlineEditable",
                        null,
                        obj => obj.IsInlineEditable,
                        (obj, val) => obj.IsInlineEditable = val,
						obj => OnIsInlineEditable_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<ObjectReferenceProperty, ICollection<Kistl.App.Base.Method>>(
                        lazyCtx,
                        new Guid("6d8fd10e-90d8-46e4-80ab-198b94537e2f"),
                        "Methods",
                        null,
                        obj => obj.Methods,
                        null, // lists are read-only properties
                        obj => OnMethods_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ObjectReferenceProperty, Kistl.App.Base.RelationEnd>(
                        lazyCtx,
                        new Guid("63ba109d-92c6-4ced-980b-0a52aabfaec0"),
                        "RelationEnd",
                        null,
                        obj => obj.RelationEnd,
                        (obj, val) => obj.RelationEnd = val,
						obj => OnRelationEnd_IsValid), 
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

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ObjectReferenceProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ObjectReferenceProperty != null)
            {
                OnObjectIsValid_ObjectReferenceProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ObjectReferenceProperty> OnObjectIsValid_ObjectReferenceProperty;

        [EventBasedMethod("OnNotifyPreSave_ObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ObjectReferenceProperty != null) OnNotifyPreSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnNotifyPreSave_ObjectReferenceProperty;

        [EventBasedMethod("OnNotifyPostSave_ObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ObjectReferenceProperty != null) OnNotifyPostSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnNotifyPostSave_ObjectReferenceProperty;

        [EventBasedMethod("OnNotifyCreated_ObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("EagerLoading");
            SetNotInitializedProperty("IsInlineEditable");
            SetNotInitializedProperty("RelationEnd");
            base.NotifyCreated();
            if (OnNotifyCreated_ObjectReferenceProperty != null) OnNotifyCreated_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnNotifyCreated_ObjectReferenceProperty;

        [EventBasedMethod("OnNotifyDeleting_ObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ObjectReferenceProperty != null) OnNotifyDeleting_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnNotifyDeleting_ObjectReferenceProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._EagerLoading, binStream);
            BinarySerializer.ToStream(this._IsInlineEditable, binStream);
            BinarySerializer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._EagerLoading, binStream);
            BinarySerializer.FromStream(out this._IsInlineEditable, binStream);
            BinarySerializer.FromStream(out this._fk_RelationEnd, binStream);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ExportGuid : (Guid?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

        #endregion

    }
}