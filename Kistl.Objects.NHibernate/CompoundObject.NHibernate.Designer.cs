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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Metadefinition Object for Compound Objects.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CompoundObject")]
    public class CompoundObjectNHibernateImpl : Kistl.App.Base.DataTypeNHibernateImpl, CompoundObject
    {
        private static readonly Guid _objectClassID = new Guid("2cb3f778-dd6a-46c7-ad2b-5f8691313035");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public CompoundObjectNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CompoundObjectNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CompoundObjectProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CompoundObjectNHibernateImpl(Func<IFrozenContext> lazyCtx, CompoundObjectProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CompoundObjectProxy Proxy;

        /// <summary>
        /// An optional default ViewModelDescriptor for Properties of this type
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DefaultPropertyViewModelDescriptor
        // fkBackingName=this.Proxy.DefaultPropertyViewModelDescriptor; fkGuidBackingName=_fk_guid_DefaultPropertyViewModelDescriptor;
        // referencedInterface=Kistl.App.GUI.ViewModelDescriptor; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.ViewModelDescriptor DefaultPropertyViewModelDescriptor
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.ViewModelDescriptorNHibernateImpl __value = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);

                if (OnDefaultPropertyViewModelDescriptor_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__value);
                    OnDefaultPropertyViewModelDescriptor_Getter(this, e);
                    __value = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.DefaultPropertyViewModelDescriptor == null)
				{
					SetInitializedProperty("DefaultPropertyViewModelDescriptor");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);
                var __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("DefaultPropertyViewModelDescriptor");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);

                if (OnDefaultPropertyViewModelDescriptor_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__oldValue, __newValue);
                    OnDefaultPropertyViewModelDescriptor_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.DefaultPropertyViewModelDescriptor = null;
                }
                else
                {
                    this.Proxy.DefaultPropertyViewModelDescriptor = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);

                if (OnDefaultPropertyViewModelDescriptor_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__oldValue, __newValue);
                    OnDefaultPropertyViewModelDescriptor_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for DefaultPropertyViewModelDescriptor's id, used on dehydration only</summary>
        private int? _fk_DefaultPropertyViewModelDescriptor = null;

        /// <summary>Backing store for DefaultPropertyViewModelDescriptor's guid, used on import only</summary>
        private Guid? _fk_guid_DefaultPropertyViewModelDescriptor = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DefaultPropertyViewModelDescriptor
		public static event PropertyGetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.CompoundObject> OnDefaultPropertyViewModelDescriptor_IsValid;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataType_CompoundObject")]
        public override System.Type GetDataType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_CompoundObject != null)
            {
                OnGetDataType_CompoundObject(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
        public static event GetDataType_Handler<CompoundObject> OnGetDataType_CompoundObject;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObject> OnGetDataType_CompoundObject_CanExec;

        [EventBasedMethod("OnGetDataType_CompoundObject_CanExec")]
        public override bool GetDataTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDataType_CompoundObject_CanExec != null)
				{
					OnGetDataType_CompoundObject_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObject> OnGetDataType_CompoundObject_CanExecReason;

        [EventBasedMethod("OnGetDataType_CompoundObject_CanExecReason")]
        public override string GetDataTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDataType_CompoundObject_CanExecReason != null)
				{
					OnGetDataType_CompoundObject_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataTypeString_CompoundObject")]
        public override string GetDataTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_CompoundObject != null)
            {
                OnGetDataTypeString_CompoundObject(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
        public static event GetDataTypeString_Handler<CompoundObject> OnGetDataTypeString_CompoundObject;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObject> OnGetDataTypeString_CompoundObject_CanExec;

        [EventBasedMethod("OnGetDataTypeString_CompoundObject_CanExec")]
        public override bool GetDataTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDataTypeString_CompoundObject_CanExec != null)
				{
					OnGetDataTypeString_CompoundObject_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObject> OnGetDataTypeString_CompoundObject_CanExecReason;

        [EventBasedMethod("OnGetDataTypeString_CompoundObject_CanExecReason")]
        public override string GetDataTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDataTypeString_CompoundObject_CanExecReason != null)
				{
					OnGetDataTypeString_CompoundObject_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Implements all available interfaces as Properties and Methods
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnImplementInterfaces_CompoundObject")]
        public override void ImplementInterfaces()
        {
            // base.ImplementInterfaces();
            if (OnImplementInterfaces_CompoundObject != null)
            {
                OnImplementInterfaces_CompoundObject(this);
            }
            else
            {
                base.ImplementInterfaces();
            }
        }
        public static event ImplementInterfaces_Handler<CompoundObject> OnImplementInterfaces_CompoundObject;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObject> OnImplementInterfaces_CompoundObject_CanExec;

        [EventBasedMethod("OnImplementInterfaces_CompoundObject_CanExec")]
        public override bool ImplementInterfacesCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnImplementInterfaces_CompoundObject_CanExec != null)
				{
					OnImplementInterfaces_CompoundObject_CanExec(this, e);
				}
				else
				{
					e.Result = base.ImplementInterfacesCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObject> OnImplementInterfaces_CompoundObject_CanExecReason;

        [EventBasedMethod("OnImplementInterfaces_CompoundObject_CanExecReason")]
        public override string ImplementInterfacesCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnImplementInterfaces_CompoundObject_CanExecReason != null)
				{
					OnImplementInterfaces_CompoundObject_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.ImplementInterfacesCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(CompoundObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CompoundObject)obj;
            var otherImpl = (CompoundObjectNHibernateImpl)obj;
            var me = (CompoundObject)this;

            this._fk_DefaultPropertyViewModelDescriptor = otherImpl._fk_DefaultPropertyViewModelDescriptor;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "DefaultPropertyViewModelDescriptor":
                    {
                        var __oldValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);
                        var __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)parentObj;
                        NotifyPropertyChanging("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);
                        this.Proxy.DefaultPropertyViewModelDescriptor = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "DefaultPropertyViewModelDescriptor":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_DefaultPropertyViewModelDescriptor.HasValue)
                this.DefaultPropertyViewModelDescriptor = ((Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.GUI.ViewModelDescriptor>(_fk_guid_DefaultPropertyViewModelDescriptor.Value));
            else
            if (_fk_DefaultPropertyViewModelDescriptor.HasValue)
                this.DefaultPropertyViewModelDescriptor = ((Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.GUI.ViewModelDescriptor>(_fk_DefaultPropertyViewModelDescriptor.Value));
            else
                this.DefaultPropertyViewModelDescriptor = null;
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
                    new PropertyDescriptorNHibernateImpl<CompoundObject, Kistl.App.GUI.ViewModelDescriptor>(
                        lazyCtx,
                        new Guid("908757d2-053b-40c5-89f8-9e5f79b5fe83"),
                        "DefaultPropertyViewModelDescriptor",
                        null,
                        obj => obj.DefaultPropertyViewModelDescriptor,
                        (obj, val) => obj.DefaultPropertyViewModelDescriptor = val,
						obj => OnDefaultPropertyViewModelDescriptor_IsValid), 
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CompoundObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CompoundObject != null)
            {
                OnToString_CompoundObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CompoundObject> OnToString_CompoundObject;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CompoundObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CompoundObject != null)
            {
                OnObjectIsValid_CompoundObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CompoundObject> OnObjectIsValid_CompoundObject;

        [EventBasedMethod("OnNotifyPreSave_CompoundObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CompoundObject != null) OnNotifyPreSave_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnNotifyPreSave_CompoundObject;

        [EventBasedMethod("OnNotifyPostSave_CompoundObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CompoundObject != null) OnNotifyPostSave_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnNotifyPostSave_CompoundObject;

        [EventBasedMethod("OnNotifyCreated_CompoundObject")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DefaultPropertyViewModelDescriptor");
            base.NotifyCreated();
            if (OnNotifyCreated_CompoundObject != null) OnNotifyCreated_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnNotifyCreated_CompoundObject;

        [EventBasedMethod("OnNotifyDeleting_CompoundObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CompoundObject != null) OnNotifyDeleting_CompoundObject(this);

            // should fetch && remember parent for CompoundObjectProperty_has_CompoundObject_RelationEntry
            // should fetch && remember parent for CompoundObjectParameter_has_CompoundObject_RelationEntry
            // FK_Presentable_may_has_DefaultPropViewModelDescriptor
            if (DefaultPropertyViewModelDescriptor != null) {
                ((NHibernatePersistenceObject)DefaultPropertyViewModelDescriptor).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)DefaultPropertyViewModelDescriptor);
            }

            DefaultPropertyViewModelDescriptor = null;
        }
        public static event ObjectEventHandler<CompoundObject> OnNotifyDeleting_CompoundObject;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class CompoundObjectProxy
            : Kistl.App.Base.DataTypeNHibernateImpl.DataTypeProxy
        {
            public CompoundObjectProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(CompoundObjectNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CompoundObjectProxy); } }

            public virtual Kistl.App.GUI.ViewModelDescriptorNHibernateImpl.ViewModelDescriptorProxy DefaultPropertyViewModelDescriptor { get; set; }

        }

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.DefaultPropertyViewModelDescriptor != null ? OurContext.GetIdFromProxy(this.Proxy.DefaultPropertyViewModelDescriptor) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            binStream.Read(out this._fk_DefaultPropertyViewModelDescriptor);
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.DefaultPropertyViewModelDescriptor != null ? this.Proxy.DefaultPropertyViewModelDescriptor.ExportGuid : (Guid?)null, xml, "DefaultPropertyViewModelDescriptor", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Kistl.App.Base|DefaultPropertyViewModelDescriptor":
                this._fk_guid_DefaultPropertyViewModelDescriptor = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}