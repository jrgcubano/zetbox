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
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CLRObjectParameter")]
    public class CLRObjectParameterNHibernateImpl : Kistl.App.Base.BaseParameterNHibernateImpl, CLRObjectParameter
    {
        private static readonly Guid _objectClassID = new Guid("012dfab4-934b-443e-853a-11a5da5b0627");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public CLRObjectParameterNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CLRObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CLRObjectParameterProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CLRObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx, CLRObjectParameterProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CLRObjectParameterProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
        // fkBackingName=this.Proxy.Type; fkGuidBackingName=_fk_guid_Type;
        // referencedInterface=Kistl.App.Base.TypeRef; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Type
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.TypeRefNHibernateImpl __value = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);

                if (OnType_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
                    OnType_Getter(this, e);
                    __value = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Type == null)
				{
					SetInitializedProperty("Type");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Type");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Type", __oldValue, __newValue);

                if (OnType_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnType_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Type = null;
                }
                else
                {
                    this.Proxy.Type = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Type", __oldValue, __newValue);

                if (OnType_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnType_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Type's id, used on dehydration only</summary>
        private int? _fk_Type = null;

        /// <summary>Backing store for Type's guid, used on import only</summary>
        private Guid? _fk_guid_Type = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
		public static event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.CLRObjectParameter> OnType_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_CLRObjectParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CLRObjectParameter != null)
            {
                OnGetLabel_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CLRObjectParameter> OnGetLabel_CLRObjectParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CLRObjectParameter> OnGetLabel_CLRObjectParameter_CanExec;

        [EventBasedMethod("OnGetLabel_CLRObjectParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_CLRObjectParameter_CanExec != null)
				{
					OnGetLabel_CLRObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CLRObjectParameter> OnGetLabel_CLRObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_CLRObjectParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_CLRObjectParameter_CanExecReason != null)
				{
					OnGetLabel_CLRObjectParameter_CanExecReason(this, e);
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
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_CLRObjectParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CLRObjectParameter != null)
            {
                OnGetParameterType_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_CLRObjectParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_CLRObjectParameter_CanExec != null)
				{
					OnGetParameterType_CLRObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_CLRObjectParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_CLRObjectParameter_CanExecReason != null)
				{
					OnGetParameterType_CLRObjectParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CLRObjectParameter != null)
            {
                OnGetParameterTypeString_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_CLRObjectParameter_CanExec != null)
				{
					OnGetParameterTypeString_CLRObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_CLRObjectParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_CLRObjectParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(CLRObjectParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CLRObjectParameter)obj;
            var otherImpl = (CLRObjectParameterNHibernateImpl)obj;
            var me = (CLRObjectParameter)this;

            this._fk_Type = otherImpl._fk_Type;
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
                case "Type":
                    {
                        var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                        var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Type", __oldValue, __newValue);
                        this.Proxy.Type = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Type", __oldValue, __newValue);
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
                case "Type":
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

            if (_fk_guid_Type.HasValue)
                this.Type = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Type.Value));
            else
            if (_fk_Type.HasValue)
                this.Type = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_Type.Value));
            else
                this.Type = null;
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
                    new PropertyDescriptorNHibernateImpl<CLRObjectParameter, Kistl.App.Base.TypeRef>(
                        lazyCtx,
                        new Guid("137292ce-4493-451d-a7fa-1b7cc7df03dd"),
                        "Type",
                        null,
                        obj => obj.Type,
                        (obj, val) => obj.Type = val,
						obj => OnType_IsValid), 
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
        [EventBasedMethod("OnToString_CLRObjectParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CLRObjectParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CLRObjectParameter != null)
            {
                OnObjectIsValid_CLRObjectParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CLRObjectParameter> OnObjectIsValid_CLRObjectParameter;

        [EventBasedMethod("OnNotifyPreSave_CLRObjectParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CLRObjectParameter != null) OnNotifyPreSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnNotifyPreSave_CLRObjectParameter;

        [EventBasedMethod("OnNotifyPostSave_CLRObjectParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CLRObjectParameter != null) OnNotifyPostSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnNotifyPostSave_CLRObjectParameter;

        [EventBasedMethod("OnNotifyCreated_CLRObjectParameter")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Type");
            base.NotifyCreated();
            if (OnNotifyCreated_CLRObjectParameter != null) OnNotifyCreated_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnNotifyCreated_CLRObjectParameter;

        [EventBasedMethod("OnNotifyDeleting_CLRObjectParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CLRObjectParameter != null) OnNotifyDeleting_CLRObjectParameter(this);

            if (Type != null) {
                ((NHibernatePersistenceObject)Type).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Type);
            }

        }
        public static event ObjectEventHandler<CLRObjectParameter> OnNotifyDeleting_CLRObjectParameter;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class CLRObjectParameterProxy
            : Kistl.App.Base.BaseParameterNHibernateImpl.BaseParameterProxy
        {
            public CLRObjectParameterProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(CLRObjectParameterNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CLRObjectParameterProxy); } }

            public virtual Kistl.App.Base.TypeRefNHibernateImpl.TypeRefProxy Type { get; set; }

        }

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Type != null ? OurContext.GetIdFromProxy(this.Proxy.Type) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            binStream.Read(out this._fk_Type);
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
            XmlStreamer.ToStream(this.Proxy.Type != null ? OurContext.GetIdFromProxy(this.Proxy.Type) : (int?)null, xml, "Type", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Type, xml, "Type", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Type != null ? this.Proxy.Type.ExportGuid : (Guid?)null, xml, "Type", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_Type, xml, "Type", "Kistl.App.Base");
        }

        #endregion

    }
}