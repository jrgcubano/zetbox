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
    /// Metadefinition Object for Double Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DoubleParameter")]
    [System.Diagnostics.DebuggerDisplay("DoubleParameter")]
    public class DoubleParameterEfImpl : Kistl.App.Base.BaseParameterEfImpl, DoubleParameter
    {
        private static readonly Guid _objectClassID = new Guid("74aa31e4-4dcf-46d5-a8b4-aa02b82bd2df");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public DoubleParameterEfImpl()
            : base(null)
        {
        }

        public DoubleParameterEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DoubleParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DoubleParameter != null)
            {
                OnGetLabel_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DoubleParameter> OnGetLabel_DoubleParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DoubleParameter> OnGetLabel_DoubleParameter_CanExec;

        [EventBasedMethod("OnGetLabel_DoubleParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_DoubleParameter_CanExec != null)
				{
					OnGetLabel_DoubleParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DoubleParameter> OnGetLabel_DoubleParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_DoubleParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_DoubleParameter_CanExecReason != null)
				{
					OnGetLabel_DoubleParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_DoubleParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_DoubleParameter != null)
            {
                OnGetParameterType_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<DoubleParameter> OnGetParameterType_DoubleParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DoubleParameter> OnGetParameterType_DoubleParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_DoubleParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_DoubleParameter_CanExec != null)
				{
					OnGetParameterType_DoubleParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DoubleParameter> OnGetParameterType_DoubleParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_DoubleParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_DoubleParameter_CanExecReason != null)
				{
					OnGetParameterType_DoubleParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_DoubleParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_DoubleParameter != null)
            {
                OnGetParameterTypeString_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<DoubleParameter> OnGetParameterTypeString_DoubleParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DoubleParameter> OnGetParameterTypeString_DoubleParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_DoubleParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_DoubleParameter_CanExec != null)
				{
					OnGetParameterTypeString_DoubleParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DoubleParameter> OnGetParameterTypeString_DoubleParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_DoubleParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_DoubleParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_DoubleParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(DoubleParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DoubleParameter)obj;
            var otherImpl = (DoubleParameterEfImpl)obj;
            var me = (DoubleParameter)this;

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
        [EventBasedMethod("OnToString_DoubleParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleParameter != null)
            {
                OnToString_DoubleParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DoubleParameter> OnToString_DoubleParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DoubleParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DoubleParameter != null)
            {
                OnObjectIsValid_DoubleParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DoubleParameter> OnObjectIsValid_DoubleParameter;

        [EventBasedMethod("OnNotifyPreSave_DoubleParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DoubleParameter != null) OnNotifyPreSave_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnNotifyPreSave_DoubleParameter;

        [EventBasedMethod("OnNotifyPostSave_DoubleParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DoubleParameter != null) OnNotifyPostSave_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnNotifyPostSave_DoubleParameter;

        [EventBasedMethod("OnNotifyCreated_DoubleParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_DoubleParameter != null) OnNotifyCreated_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnNotifyCreated_DoubleParameter;

        [EventBasedMethod("OnNotifyDeleting_DoubleParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DoubleParameter != null) OnNotifyDeleting_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnNotifyDeleting_DoubleParameter;

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