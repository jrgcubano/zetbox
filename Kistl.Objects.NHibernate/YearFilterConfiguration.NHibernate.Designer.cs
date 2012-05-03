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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("YearFilterConfiguration")]
    public class YearFilterConfigurationNHibernateImpl : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl, YearFilterConfiguration
    {
        private static readonly Guid _objectClassID = new Guid("96297bd7-7182-4446-8aed-23079250f408");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public YearFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public YearFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new YearFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public YearFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, YearFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly YearFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsCurrentYearDefault
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IsCurrentYearDefault;
                if (OnIsCurrentYearDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentYearDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IsCurrentYearDefault != value)
                {
                    var __oldValue = Proxy.IsCurrentYearDefault;
                    var __newValue = value;
                    if (OnIsCurrentYearDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentYearDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentYearDefault", __oldValue, __newValue);
                    Proxy.IsCurrentYearDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentYearDefault", __oldValue, __newValue);

                    if (OnIsCurrentYearDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentYearDefault_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("IsCurrentYearDefault");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.YearFilterConfiguration> OnIsCurrentYearDefault_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_YearFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_YearFilterConfiguration != null)
            {
                OnCreateFilterModel_YearFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<YearFilterConfiguration> OnCreateFilterModel_YearFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<YearFilterConfiguration> OnCreateFilterModel_YearFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_YearFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_YearFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_YearFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<YearFilterConfiguration> OnCreateFilterModel_YearFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_YearFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_YearFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_YearFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_YearFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_YearFilterConfiguration != null)
            {
                OnGetLabel_YearFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<YearFilterConfiguration> OnGetLabel_YearFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<YearFilterConfiguration> OnGetLabel_YearFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_YearFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_YearFilterConfiguration_CanExec != null)
				{
					OnGetLabel_YearFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<YearFilterConfiguration> OnGetLabel_YearFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_YearFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_YearFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_YearFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(YearFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (YearFilterConfiguration)obj;
            var otherImpl = (YearFilterConfigurationNHibernateImpl)obj;
            var me = (YearFilterConfiguration)this;

            me.IsCurrentYearDefault = other.IsCurrentYearDefault;
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
                case "IsCurrentYearDefault":
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
                    new PropertyDescriptorNHibernateImpl<YearFilterConfiguration, bool?>(
                        lazyCtx,
                        new Guid("495159f4-a983-4a2a-a8f1-2291647673fd"),
                        "IsCurrentYearDefault",
                        null,
                        obj => obj.IsCurrentYearDefault,
                        (obj, val) => obj.IsCurrentYearDefault = val,
						obj => OnIsCurrentYearDefault_IsValid), 
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
        [EventBasedMethod("OnToString_YearFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_YearFilterConfiguration != null)
            {
                OnToString_YearFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<YearFilterConfiguration> OnToString_YearFilterConfiguration;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_YearFilterConfiguration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_YearFilterConfiguration != null)
            {
                OnObjectIsValid_YearFilterConfiguration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<YearFilterConfiguration> OnObjectIsValid_YearFilterConfiguration;

        [EventBasedMethod("OnNotifyPreSave_YearFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_YearFilterConfiguration != null) OnNotifyPreSave_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnNotifyPreSave_YearFilterConfiguration;

        [EventBasedMethod("OnNotifyPostSave_YearFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_YearFilterConfiguration != null) OnNotifyPostSave_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnNotifyPostSave_YearFilterConfiguration;

        [EventBasedMethod("OnNotifyCreated_YearFilterConfiguration")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("IsCurrentYearDefault");
            base.NotifyCreated();
            if (OnNotifyCreated_YearFilterConfiguration != null) OnNotifyCreated_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnNotifyCreated_YearFilterConfiguration;

        [EventBasedMethod("OnNotifyDeleting_YearFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_YearFilterConfiguration != null) OnNotifyDeleting_YearFilterConfiguration(this);


        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnNotifyDeleting_YearFilterConfiguration;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class YearFilterConfigurationProxy
            : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl.PropertyFilterConfigurationProxy
        {
            public YearFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(YearFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(YearFilterConfigurationProxy); } }

            public virtual bool? IsCurrentYearDefault { get; set; }

        }

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.IsCurrentYearDefault);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            this.Proxy.IsCurrentYearDefault = binStream.ReadNullableBoolean();
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Kistl.App.GUI|IsCurrentYearDefault":
                this.Proxy.IsCurrentYearDefault = XmlStreamer.ReadNullableBoolean(xml);
                break;
            }
        }

        #endregion

    }
}