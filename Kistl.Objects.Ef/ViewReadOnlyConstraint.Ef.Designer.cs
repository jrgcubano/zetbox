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
    /// Item is readonly in view but changable on the server/client
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ViewReadOnlyConstraint")]
    [System.Diagnostics.DebuggerDisplay("ViewReadOnlyConstraint")]
    public class ViewReadOnlyConstraintEfImpl : Kistl.App.Base.ReadOnlyConstraintEfImpl, ViewReadOnlyConstraint
    {
        private static readonly Guid _objectClassID = new Guid("3ccd892a-17f7-4cf5-95bd-b25b3f6fa785");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public ViewReadOnlyConstraintEfImpl()
            : base(null)
        {
        }

        public ViewReadOnlyConstraintEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_ViewReadOnlyConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_ViewReadOnlyConstraint != null)
            {
                OnGetErrorText_ViewReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<ViewReadOnlyConstraint> OnGetErrorText_ViewReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ViewReadOnlyConstraint> OnGetErrorText_ViewReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_ViewReadOnlyConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_ViewReadOnlyConstraint_CanExec != null)
				{
					OnGetErrorText_ViewReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ViewReadOnlyConstraint> OnGetErrorText_ViewReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_ViewReadOnlyConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_ViewReadOnlyConstraint_CanExecReason != null)
				{
					OnGetErrorText_ViewReadOnlyConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_ViewReadOnlyConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_ViewReadOnlyConstraint != null)
            {
                OnIsValid_ViewReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<ViewReadOnlyConstraint> OnIsValid_ViewReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ViewReadOnlyConstraint> OnIsValid_ViewReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnIsValid_ViewReadOnlyConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_ViewReadOnlyConstraint_CanExec != null)
				{
					OnIsValid_ViewReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ViewReadOnlyConstraint> OnIsValid_ViewReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_ViewReadOnlyConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_ViewReadOnlyConstraint_CanExecReason != null)
				{
					OnIsValid_ViewReadOnlyConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ViewReadOnlyConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ViewReadOnlyConstraint)obj;
            var otherImpl = (ViewReadOnlyConstraintEfImpl)obj;
            var me = (ViewReadOnlyConstraint)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Kistl.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        #endregion // Kistl.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

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
        [EventBasedMethod("OnToString_ViewReadOnlyConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ViewReadOnlyConstraint != null)
            {
                OnToString_ViewReadOnlyConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ViewReadOnlyConstraint> OnToString_ViewReadOnlyConstraint;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ViewReadOnlyConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ViewReadOnlyConstraint != null)
            {
                OnObjectIsValid_ViewReadOnlyConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ViewReadOnlyConstraint> OnObjectIsValid_ViewReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPreSave_ViewReadOnlyConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ViewReadOnlyConstraint != null) OnNotifyPreSave_ViewReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ViewReadOnlyConstraint> OnNotifyPreSave_ViewReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPostSave_ViewReadOnlyConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ViewReadOnlyConstraint != null) OnNotifyPostSave_ViewReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ViewReadOnlyConstraint> OnNotifyPostSave_ViewReadOnlyConstraint;

        [EventBasedMethod("OnNotifyCreated_ViewReadOnlyConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_ViewReadOnlyConstraint != null) OnNotifyCreated_ViewReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ViewReadOnlyConstraint> OnNotifyCreated_ViewReadOnlyConstraint;

        [EventBasedMethod("OnNotifyDeleting_ViewReadOnlyConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ViewReadOnlyConstraint != null) OnNotifyDeleting_ViewReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ViewReadOnlyConstraint> OnNotifyDeleting_ViewReadOnlyConstraint;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
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