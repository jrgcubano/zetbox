// <autogenerated/>

namespace Kistl.App.Calendar
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
    /// This rule applies every year on the same date
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("FixedYearlyCalendarRule")]
    public class FixedYearlyCalendarRuleNHibernateImpl : Kistl.App.Calendar.YearlyCalendarRuleNHibernateImpl, FixedYearlyCalendarRule
    {
        public FixedYearlyCalendarRuleNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public FixedYearlyCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new FixedYearlyCalendarRuleProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public FixedYearlyCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx, FixedYearlyCalendarRuleProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly FixedYearlyCalendarRuleProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Day
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Day;
                if (OnDay_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnDay_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Day != value)
                {
                    var __oldValue = Proxy.Day;
                    var __newValue = value;
                    if (OnDay_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnDay_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Day", __oldValue, __newValue);
                    Proxy.Day = __newValue;
                    NotifyPropertyChanged("Day", __oldValue, __newValue);
                    if (OnDay_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnDay_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnDay_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnDay_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnDay_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Month
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Month;
                if (OnMonth_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMonth_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Month != value)
                {
                    var __oldValue = Proxy.Month;
                    var __newValue = value;
                    if (OnMonth_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMonth_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Month", __oldValue, __newValue);
                    Proxy.Month = __newValue;
                    NotifyPropertyChanged("Month", __oldValue, __newValue);
                    if (OnMonth_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMonth_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnMonth_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnMonth_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Calendar.FixedYearlyCalendarRule, int> OnMonth_PostSetter;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_FixedYearlyCalendarRule")]
        public override bool AppliesTo(System.DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_FixedYearlyCalendarRule != null)
            {
                OnAppliesTo_FixedYearlyCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<FixedYearlyCalendarRule> OnAppliesTo_FixedYearlyCalendarRule;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(FixedYearlyCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (FixedYearlyCalendarRule)obj;
            var otherImpl = (FixedYearlyCalendarRuleNHibernateImpl)obj;
            var me = (FixedYearlyCalendarRule)this;

            me.Day = other.Day;
            me.Month = other.Month;
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
                    new PropertyDescriptorNHibernateImpl<FixedYearlyCalendarRuleNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("7d16cd01-93ce-44d2-bb69-ac06f5b61aaf"),
                        "Day",
                        null,
                        obj => obj.Day,
                        (obj, val) => obj.Day = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<FixedYearlyCalendarRuleNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("43be3542-1b21-4423-aeb4-f9e411b2453f"),
                        "Month",
                        null,
                        obj => obj.Month,
                        (obj, val) => obj.Month = val),
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
        [EventBasedMethod("OnToString_FixedYearlyCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_FixedYearlyCalendarRule != null)
            {
                OnToString_FixedYearlyCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<FixedYearlyCalendarRule> OnToString_FixedYearlyCalendarRule;

        [EventBasedMethod("OnPreSave_FixedYearlyCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_FixedYearlyCalendarRule != null) OnPreSave_FixedYearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<FixedYearlyCalendarRule> OnPreSave_FixedYearlyCalendarRule;

        [EventBasedMethod("OnPostSave_FixedYearlyCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_FixedYearlyCalendarRule != null) OnPostSave_FixedYearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<FixedYearlyCalendarRule> OnPostSave_FixedYearlyCalendarRule;

        [EventBasedMethod("OnCreated_FixedYearlyCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_FixedYearlyCalendarRule != null) OnCreated_FixedYearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<FixedYearlyCalendarRule> OnCreated_FixedYearlyCalendarRule;

        [EventBasedMethod("OnDeleting_FixedYearlyCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_FixedYearlyCalendarRule != null) OnDeleting_FixedYearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<FixedYearlyCalendarRule> OnDeleting_FixedYearlyCalendarRule;

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


        public class FixedYearlyCalendarRuleProxy
            : Kistl.App.Calendar.YearlyCalendarRuleNHibernateImpl.YearlyCalendarRuleProxy
        {
            public FixedYearlyCalendarRuleProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(FixedYearlyCalendarRuleNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(FixedYearlyCalendarRuleProxy); } }

            public virtual int Day { get; set; }

            public virtual int Month { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.Day, binStream);
            BinarySerializer.ToStream(this.Proxy.Month, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Day = tmp;
            }
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Month = tmp;
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
            XmlStreamer.ToStream(this.Proxy.Day, xml, "Day", "Kistl.App.Calendar");
            XmlStreamer.ToStream(this.Proxy.Month, xml, "Month", "Kistl.App.Calendar");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                int tmp = this.Proxy.Day;
                XmlStreamer.FromStream(ref tmp, xml, "Day", "Kistl.App.Calendar");
                this.Proxy.Day = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.Month;
                XmlStreamer.FromStream(ref tmp, xml, "Month", "Kistl.App.Calendar");
                this.Proxy.Month = tmp;
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Calendar")) XmlStreamer.ToStream(this.Proxy.Day, xml, "Day", "Kistl.App.Calendar");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Calendar")) XmlStreamer.ToStream(this.Proxy.Month, xml, "Month", "Kistl.App.Calendar");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                int tmp = this.Proxy.Day;
                XmlStreamer.FromStream(ref tmp, xml, "Day", "Kistl.App.Calendar");
                this.Proxy.Day = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.Month;
                XmlStreamer.FromStream(ref tmp, xml, "Month", "Kistl.App.Calendar");
                this.Proxy.Month = tmp;
            }
        }

        #endregion

    }
}