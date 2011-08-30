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
    [System.Diagnostics.DebuggerDisplay("DateRangeFilterConfiguration")]
    public class DateRangeFilterConfigurationNHibernateImpl : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl, DateRangeFilterConfiguration
    {
        public DateRangeFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public DateRangeFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new DateRangeFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DateRangeFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, DateRangeFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly DateRangeFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsCurrentMonthDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IsCurrentMonthDefault;
                if (OnIsCurrentMonthDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentMonthDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IsCurrentMonthDefault != value)
                {
                    var __oldValue = Proxy.IsCurrentMonthDefault;
                    var __newValue = value;
                    if (OnIsCurrentMonthDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentMonthDefault", __oldValue, __newValue);
                    Proxy.IsCurrentMonthDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentMonthDefault", __oldValue, __newValue);
                    if (OnIsCurrentMonthDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsCurrentQuaterDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IsCurrentQuaterDefault;
                if (OnIsCurrentQuaterDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentQuaterDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IsCurrentQuaterDefault != value)
                {
                    var __oldValue = Proxy.IsCurrentQuaterDefault;
                    var __newValue = value;
                    if (OnIsCurrentQuaterDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentQuaterDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentQuaterDefault", __oldValue, __newValue);
                    Proxy.IsCurrentQuaterDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentQuaterDefault", __oldValue, __newValue);
                    if (OnIsCurrentQuaterDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentQuaterDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsCurrentYearDefault
        {
            get
            {
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
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_DateRangeFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_DateRangeFilterConfiguration != null)
            {
                OnCreateFilterModel_DateRangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<DateRangeFilterConfiguration> OnCreateFilterModel_DateRangeFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DateRangeFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DateRangeFilterConfiguration != null)
            {
                OnGetLabel_DateRangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DateRangeFilterConfiguration> OnGetLabel_DateRangeFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DateRangeFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateRangeFilterConfiguration)obj;
            var otherImpl = (DateRangeFilterConfigurationNHibernateImpl)obj;
            var me = (DateRangeFilterConfiguration)this;

            me.IsCurrentMonthDefault = other.IsCurrentMonthDefault;
            me.IsCurrentQuaterDefault = other.IsCurrentQuaterDefault;
            me.IsCurrentYearDefault = other.IsCurrentYearDefault;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }


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
                    new PropertyDescriptorNHibernateImpl<DateRangeFilterConfigurationNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("c38eda0e-59b7-4e37-9d16-5f4fb7ae0b2d"),
                        "IsCurrentMonthDefault",
                        null,
                        obj => obj.IsCurrentMonthDefault,
                        (obj, val) => obj.IsCurrentMonthDefault = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<DateRangeFilterConfigurationNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("edb97f39-355d-4a87-9aa1-ad9eccafb369"),
                        "IsCurrentQuaterDefault",
                        null,
                        obj => obj.IsCurrentQuaterDefault,
                        (obj, val) => obj.IsCurrentQuaterDefault = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<DateRangeFilterConfigurationNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("8f9bbaf8-4624-49d9-9b49-878142189cf7"),
                        "IsCurrentYearDefault",
                        null,
                        obj => obj.IsCurrentYearDefault,
                        (obj, val) => obj.IsCurrentYearDefault = val),
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
        [EventBasedMethod("OnToString_DateRangeFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateRangeFilterConfiguration != null)
            {
                OnToString_DateRangeFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateRangeFilterConfiguration> OnToString_DateRangeFilterConfiguration;

        [EventBasedMethod("OnPreSave_DateRangeFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateRangeFilterConfiguration != null) OnPreSave_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnPreSave_DateRangeFilterConfiguration;

        [EventBasedMethod("OnPostSave_DateRangeFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateRangeFilterConfiguration != null) OnPostSave_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnPostSave_DateRangeFilterConfiguration;

        [EventBasedMethod("OnCreated_DateRangeFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DateRangeFilterConfiguration != null) OnCreated_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnCreated_DateRangeFilterConfiguration;

        [EventBasedMethod("OnDeleting_DateRangeFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DateRangeFilterConfiguration != null) OnDeleting_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnDeleting_DateRangeFilterConfiguration;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();


            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();


            return result;
        }


        public class DateRangeFilterConfigurationProxy
            : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl.PropertyFilterConfigurationProxy
        {
            public DateRangeFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(DateRangeFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(DateRangeFilterConfigurationProxy); } }

            public virtual bool? IsCurrentMonthDefault { get; set; }

            public virtual bool? IsCurrentQuaterDefault { get; set; }

            public virtual bool? IsCurrentYearDefault { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.IsCurrentMonthDefault, binStream);
            BinarySerializer.ToStream(this.Proxy.IsCurrentQuaterDefault, binStream);
            BinarySerializer.ToStream(this.Proxy.IsCurrentYearDefault, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                bool? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsCurrentMonthDefault = tmp;
            }
            {
                bool? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsCurrentQuaterDefault = tmp;
            }
            {
                bool? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsCurrentYearDefault = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this.Proxy.IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentMonthDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentMonthDefault = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentQuaterDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentQuaterDefault = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentYearDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentYearDefault = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentMonthDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentMonthDefault = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentQuaterDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentQuaterDefault = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentYearDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentYearDefault = tmp;
            }
        }

        #endregion

    }
}