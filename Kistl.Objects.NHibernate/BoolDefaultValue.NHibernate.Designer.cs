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
    /// Sets an boolean property with an configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("BoolDefaultValue")]
    public class BoolDefaultValueNHibernateImpl : Kistl.App.Base.DefaultPropertyValueNHibernateImpl, BoolDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("47838e25-d8f7-4d18-a913-eeb4095bb862");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public BoolDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public BoolDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new BoolDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public BoolDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, BoolDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly BoolDefaultValueProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool BoolValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.BoolValue;
                if (OnBoolValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnBoolValue_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.BoolValue != value)
                {
                    var __oldValue = Proxy.BoolValue;
                    var __newValue = value;
                    if (OnBoolValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BoolValue", __oldValue, __newValue);
                    Proxy.BoolValue = __newValue;
                    NotifyPropertyChanged("BoolValue", __oldValue, __newValue);

                    if (OnBoolValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("BoolValue");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.BoolDefaultValue> OnBoolValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_BoolDefaultValue != null)
            {
                OnGetDefaultValue_BoolDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_BoolDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_BoolDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_BoolDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_BoolDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(BoolDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (BoolDefaultValue)obj;
            var otherImpl = (BoolDefaultValueNHibernateImpl)obj;
            var me = (BoolDefaultValue)this;

            me.BoolValue = other.BoolValue;
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

        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "BoolValue":
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
                    new PropertyDescriptorNHibernateImpl<BoolDefaultValue, bool>(
                        lazyCtx,
                        new Guid("635818b4-065f-456c-b57e-4a7cdc8b3378"),
                        "BoolValue",
                        null,
                        obj => obj.BoolValue,
                        (obj, val) => obj.BoolValue = val,
						obj => OnBoolValue_IsValid), 
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
        [EventBasedMethod("OnToString_BoolDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolDefaultValue != null)
            {
                OnToString_BoolDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<BoolDefaultValue> OnToString_BoolDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_BoolDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_BoolDefaultValue != null)
            {
                OnObjectIsValid_BoolDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<BoolDefaultValue> OnObjectIsValid_BoolDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_BoolDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_BoolDefaultValue != null) OnNotifyPreSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyPreSave_BoolDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_BoolDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_BoolDefaultValue != null) OnNotifyPostSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyPostSave_BoolDefaultValue;

        [EventBasedMethod("OnNotifyCreated_BoolDefaultValue")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("BoolValue");
            base.NotifyCreated();
            if (OnNotifyCreated_BoolDefaultValue != null) OnNotifyCreated_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyCreated_BoolDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_BoolDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_BoolDefaultValue != null) OnNotifyDeleting_BoolDefaultValue(this);


        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyDeleting_BoolDefaultValue;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class BoolDefaultValueProxy
            : Kistl.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public BoolDefaultValueProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(BoolDefaultValueNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(BoolDefaultValueProxy); } }

            public virtual bool BoolValue { get; set; }

        }

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.BoolValue);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                bool tmp;
                binStream.Read(out tmp);
                this.Proxy.BoolValue = tmp;
            }
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
            XmlStreamer.ToStream(this.Proxy.BoolValue, xml, "BoolValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                bool tmp = this.Proxy.BoolValue;
                XmlStreamer.FromStream(ref tmp, xml, "BoolValue", "Kistl.App.Base");
                this.Proxy.BoolValue = tmp;
            }
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.BoolValue, xml, "BoolValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                // yuck
                bool tmp = this.Proxy.BoolValue;
                XmlStreamer.FromStream(ref tmp, xml, "BoolValue", "Kistl.App.Base");
                this.Proxy.BoolValue = tmp;
            }
        }

        #endregion

    }
}