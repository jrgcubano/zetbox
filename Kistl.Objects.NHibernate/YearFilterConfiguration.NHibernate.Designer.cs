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
		public static event PropertyGetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.YearFilterConfiguration, bool?> OnIsCurrentYearDefault_PostSetter;

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
        // END Kistl.Generator.Templates.ObjectClasses.Method

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
        // END Kistl.Generator.Templates.ObjectClasses.Method

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
                    new PropertyDescriptorNHibernateImpl<YearFilterConfigurationNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("495159f4-a983-4a2a-a8f1-2291647673fd"),
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

        [EventBasedMethod("OnPreSave_YearFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_YearFilterConfiguration != null) OnPreSave_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnPreSave_YearFilterConfiguration;

        [EventBasedMethod("OnPostSave_YearFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_YearFilterConfiguration != null) OnPostSave_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnPostSave_YearFilterConfiguration;

        [EventBasedMethod("OnCreated_YearFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_YearFilterConfiguration != null) OnCreated_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnCreated_YearFilterConfiguration;

        [EventBasedMethod("OnDeleting_YearFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_YearFilterConfiguration != null) OnDeleting_YearFilterConfiguration(this);
        }
        public static event ObjectEventHandler<YearFilterConfiguration> OnDeleting_YearFilterConfiguration;

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


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.IsCurrentYearDefault, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
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
            XmlStreamer.ToStream(this.Proxy.IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
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