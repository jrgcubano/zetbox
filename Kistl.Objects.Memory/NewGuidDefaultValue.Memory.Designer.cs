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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Creates a new Guid
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("NewGuidDefaultValue")]
    public class NewGuidDefaultValueMemoryImpl : Kistl.App.Base.DefaultPropertyValueMemoryImpl, NewGuidDefaultValue
    {
        [Obsolete]
        public NewGuidDefaultValueMemoryImpl()
            : base(null)
        {
        }

        public NewGuidDefaultValueMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_NewGuidDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_NewGuidDefaultValue != null)
            {
                OnGetDefaultValue_NewGuidDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<NewGuidDefaultValue> OnGetDefaultValue_NewGuidDefaultValue;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<NewGuidDefaultValue> OnGetDefaultValue_NewGuidDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_NewGuidDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_NewGuidDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_NewGuidDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<NewGuidDefaultValue> OnGetDefaultValue_NewGuidDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_NewGuidDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_NewGuidDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_NewGuidDefaultValue_CanExecReason(this, e);
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
            return typeof(NewGuidDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (NewGuidDefaultValue)obj;
            var otherImpl = (NewGuidDefaultValueMemoryImpl)obj;
            var me = (NewGuidDefaultValue)this;

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
        [EventBasedMethod("OnToString_NewGuidDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NewGuidDefaultValue != null)
            {
                OnToString_NewGuidDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<NewGuidDefaultValue> OnToString_NewGuidDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_NewGuidDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_NewGuidDefaultValue != null) OnNotifyPreSave_NewGuidDefaultValue(this);
        }
        public static event ObjectEventHandler<NewGuidDefaultValue> OnNotifyPreSave_NewGuidDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_NewGuidDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_NewGuidDefaultValue != null) OnNotifyPostSave_NewGuidDefaultValue(this);
        }
        public static event ObjectEventHandler<NewGuidDefaultValue> OnNotifyPostSave_NewGuidDefaultValue;

        [EventBasedMethod("OnNotifyCreated_NewGuidDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_NewGuidDefaultValue != null) OnNotifyCreated_NewGuidDefaultValue(this);
        }
        public static event ObjectEventHandler<NewGuidDefaultValue> OnNotifyCreated_NewGuidDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_NewGuidDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_NewGuidDefaultValue != null) OnNotifyDeleting_NewGuidDefaultValue(this);
        }
        public static event ObjectEventHandler<NewGuidDefaultValue> OnNotifyDeleting_NewGuidDefaultValue;

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