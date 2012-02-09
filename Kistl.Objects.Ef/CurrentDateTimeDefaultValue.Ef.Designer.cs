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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Sets the newly created DatetTme Property to DateTime.Now
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CurrentDateTimeDefaultValue")]
    [System.Diagnostics.DebuggerDisplay("CurrentDateTimeDefaultValue")]
    public class CurrentDateTimeDefaultValueEfImpl : Kistl.App.Base.DefaultPropertyValueEfImpl, CurrentDateTimeDefaultValue
    {
        [Obsolete]
        public CurrentDateTimeDefaultValueEfImpl()
            : base(null)
        {
        }

        public CurrentDateTimeDefaultValueEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_CurrentDateTimeDefaultValue != null)
            {
                OnGetDefaultValue_CurrentDateTimeDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason(this, e);
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
            return typeof(CurrentDateTimeDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CurrentDateTimeDefaultValue)obj;
            var otherImpl = (CurrentDateTimeDefaultValueEfImpl)obj;
            var me = (CurrentDateTimeDefaultValue)this;

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
        [EventBasedMethod("OnToString_CurrentDateTimeDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CurrentDateTimeDefaultValue != null)
            {
                OnToString_CurrentDateTimeDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CurrentDateTimeDefaultValue> OnToString_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_CurrentDateTimeDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CurrentDateTimeDefaultValue != null) OnNotifyPreSave_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyPreSave_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_CurrentDateTimeDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CurrentDateTimeDefaultValue != null) OnNotifyPostSave_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyPostSave_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyCreated_CurrentDateTimeDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_CurrentDateTimeDefaultValue != null) OnNotifyCreated_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyCreated_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_CurrentDateTimeDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CurrentDateTimeDefaultValue != null) OnNotifyDeleting_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyDeleting_CurrentDateTimeDefaultValue;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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