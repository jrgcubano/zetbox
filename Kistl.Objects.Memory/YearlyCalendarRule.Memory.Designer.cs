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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// This rule applies every year. This class is abstract.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("YearlyCalendarRule")]
    public abstract class YearlyCalendarRuleMemoryImpl : Kistl.App.Calendar.CalendarRuleMemoryImpl, YearlyCalendarRule
    {
        [Obsolete]
        public YearlyCalendarRuleMemoryImpl()
            : base(null)
        {
        }

        public YearlyCalendarRuleMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_YearlyCalendarRule")]
        public override bool AppliesTo(System.DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_YearlyCalendarRule != null)
            {
                OnAppliesTo_YearlyCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<YearlyCalendarRule> OnAppliesTo_YearlyCalendarRule;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(YearlyCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (YearlyCalendarRule)obj;
            var otherImpl = (YearlyCalendarRuleMemoryImpl)obj;
            var me = (YearlyCalendarRule)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_YearlyCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_YearlyCalendarRule != null)
            {
                OnToString_YearlyCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<YearlyCalendarRule> OnToString_YearlyCalendarRule;

        [EventBasedMethod("OnPreSave_YearlyCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_YearlyCalendarRule != null) OnPreSave_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnPreSave_YearlyCalendarRule;

        [EventBasedMethod("OnPostSave_YearlyCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_YearlyCalendarRule != null) OnPostSave_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnPostSave_YearlyCalendarRule;

        [EventBasedMethod("OnCreated_YearlyCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_YearlyCalendarRule != null) OnCreated_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnCreated_YearlyCalendarRule;

        [EventBasedMethod("OnDeleting_YearlyCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_YearlyCalendarRule != null) OnDeleting_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnDeleting_YearlyCalendarRule;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
        }

        #endregion

    }
}