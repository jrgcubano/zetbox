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
    /// This rule applies every day
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CommonCalendarRule")]
    public class CommonCalendarRuleNHibernateImpl : Kistl.App.Calendar.CalendarRuleNHibernateImpl, CommonCalendarRule
    {
        public CommonCalendarRuleNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CommonCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CommonCalendarRuleProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CommonCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx, CommonCalendarRuleProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CommonCalendarRuleProxy Proxy;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_CommonCalendarRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_CommonCalendarRule != null)
            {
                OnAppliesTo_CommonCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule_CanExec;

        [EventBasedMethod("OnAppliesTo_CommonCalendarRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_CommonCalendarRule_CanExec != null)
				{
					OnAppliesTo_CommonCalendarRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_CommonCalendarRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_CommonCalendarRule_CanExecReason != null)
				{
					OnAppliesTo_CommonCalendarRule_CanExecReason(this, e);
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
            return typeof(CommonCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CommonCalendarRule)obj;
            var otherImpl = (CommonCalendarRuleNHibernateImpl)obj;
            var me = (CommonCalendarRule)this;

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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CommonCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CommonCalendarRule != null)
            {
                OnToString_CommonCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CommonCalendarRule> OnToString_CommonCalendarRule;

        [EventBasedMethod("OnNotifyPreSave_CommonCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CommonCalendarRule != null) OnNotifyPreSave_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyPreSave_CommonCalendarRule;

        [EventBasedMethod("OnNotifyPostSave_CommonCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CommonCalendarRule != null) OnNotifyPostSave_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyPostSave_CommonCalendarRule;

        [EventBasedMethod("OnNotifyCreated_CommonCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_CommonCalendarRule != null) OnNotifyCreated_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyCreated_CommonCalendarRule;

        [EventBasedMethod("OnNotifyDeleting_CommonCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CommonCalendarRule != null) OnNotifyDeleting_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyDeleting_CommonCalendarRule;

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


        public class CommonCalendarRuleProxy
            : Kistl.App.Calendar.CalendarRuleNHibernateImpl.CalendarRuleProxy
        {
            public CommonCalendarRuleProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(CommonCalendarRuleNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CommonCalendarRuleProxy); } }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
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
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
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
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        #endregion

    }
}