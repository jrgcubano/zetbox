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
    /// This rule applies every year, n days relative to easter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EasterCalendarRule")]
    public class EasterCalendarRuleNHibernateImpl : Kistl.App.Calendar.YearlyCalendarRuleNHibernateImpl, EasterCalendarRule
    {
        private static readonly Guid _objectClassID = new Guid("d321c926-952d-4810-904b-a57251dd5e9d");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public EasterCalendarRuleNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EasterCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EasterCalendarRuleProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EasterCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx, EasterCalendarRuleProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly EasterCalendarRuleProxy Proxy;

        /// <summary>
        /// Offset to eater. Null or zero, if easter is meant. Negative numbers are before easter.
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? Offset
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Offset;
                if (OnOffset_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnOffset_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Offset != value)
                {
                    var __oldValue = Proxy.Offset;
                    var __newValue = value;
                    if (OnOffset_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnOffset_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Offset", __oldValue, __newValue);
                    Proxy.Offset = __newValue;
                    NotifyPropertyChanged("Offset", __oldValue, __newValue);

                    if (OnOffset_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnOffset_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Offset");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Calendar.EasterCalendarRule, int?> OnOffset_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Calendar.EasterCalendarRule, int?> OnOffset_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Calendar.EasterCalendarRule, int?> OnOffset_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Calendar.EasterCalendarRule> OnOffset_IsValid;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_EasterCalendarRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_EasterCalendarRule != null)
            {
                OnAppliesTo_EasterCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<EasterCalendarRule> OnAppliesTo_EasterCalendarRule;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EasterCalendarRule> OnAppliesTo_EasterCalendarRule_CanExec;

        [EventBasedMethod("OnAppliesTo_EasterCalendarRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_EasterCalendarRule_CanExec != null)
				{
					OnAppliesTo_EasterCalendarRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EasterCalendarRule> OnAppliesTo_EasterCalendarRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_EasterCalendarRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_EasterCalendarRule_CanExecReason != null)
				{
					OnAppliesTo_EasterCalendarRule_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(EasterCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EasterCalendarRule)obj;
            var otherImpl = (EasterCalendarRuleNHibernateImpl)obj;
            var me = (EasterCalendarRule)this;

            me.Offset = other.Offset;
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
                case "Offset":
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
                    new PropertyDescriptorNHibernateImpl<EasterCalendarRule, int?>(
                        lazyCtx,
                        new Guid("0fdcab86-001e-429d-af31-a5d0df5e6c75"),
                        "Offset",
                        null,
                        obj => obj.Offset,
                        (obj, val) => obj.Offset = val,
						obj => OnOffset_IsValid), 
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
        [EventBasedMethod("OnToString_EasterCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EasterCalendarRule != null)
            {
                OnToString_EasterCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EasterCalendarRule> OnToString_EasterCalendarRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EasterCalendarRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EasterCalendarRule != null)
            {
                OnObjectIsValid_EasterCalendarRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EasterCalendarRule> OnObjectIsValid_EasterCalendarRule;

        [EventBasedMethod("OnNotifyPreSave_EasterCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EasterCalendarRule != null) OnNotifyPreSave_EasterCalendarRule(this);
        }
        public static event ObjectEventHandler<EasterCalendarRule> OnNotifyPreSave_EasterCalendarRule;

        [EventBasedMethod("OnNotifyPostSave_EasterCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EasterCalendarRule != null) OnNotifyPostSave_EasterCalendarRule(this);
        }
        public static event ObjectEventHandler<EasterCalendarRule> OnNotifyPostSave_EasterCalendarRule;

        [EventBasedMethod("OnNotifyCreated_EasterCalendarRule")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Offset");
            base.NotifyCreated();
            if (OnNotifyCreated_EasterCalendarRule != null) OnNotifyCreated_EasterCalendarRule(this);
        }
        public static event ObjectEventHandler<EasterCalendarRule> OnNotifyCreated_EasterCalendarRule;

        [EventBasedMethod("OnNotifyDeleting_EasterCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EasterCalendarRule != null) OnNotifyDeleting_EasterCalendarRule(this);


        }
        public static event ObjectEventHandler<EasterCalendarRule> OnNotifyDeleting_EasterCalendarRule;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class EasterCalendarRuleProxy
            : Kistl.App.Calendar.YearlyCalendarRuleNHibernateImpl.YearlyCalendarRuleProxy
        {
            public EasterCalendarRuleProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(EasterCalendarRuleNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(EasterCalendarRuleProxy); } }

            public virtual int? Offset { get; set; }

        }

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Offset);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            this.Proxy.Offset = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Calendar")) XmlStreamer.ToStream(this.Proxy.Offset, xml, "Offset", "Kistl.App.Calendar");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Kistl.App.Calendar|Offset":
                this.Proxy.Offset = XmlStreamer.ReadNullableInt32(xml);
                break;
            }
        }

        #endregion

    }
}