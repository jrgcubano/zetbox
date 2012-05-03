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
    /// Metadefinition Object for Enum Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="EnumParameter")]
    [System.Diagnostics.DebuggerDisplay("EnumParameter")]
    public class EnumParameterEfImpl : Kistl.App.Base.BaseParameterEfImpl, EnumParameter
    {
        private static readonly Guid _objectClassID = new Guid("041eaa58-84cb-405f-a6ea-c3d77e4acd82");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public EnumParameterEfImpl()
            : base(null)
        {
        }

        public EnumParameterEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_EnumParameter_has_Enumeration
    A: ZeroOrMore EnumParameter as EnumParameter
    B: One Enumeration as Enumeration
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
        // fkBackingName=_fk_Enumeration; fkGuidBackingName=_fk_guid_Enumeration;
        // referencedInterface=Kistl.App.Base.Enumeration; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get { return EnumerationImpl; }
            set { EnumerationImpl = (Kistl.App.Base.EnumerationEfImpl)value; }
        }

        private int? _fk_Enumeration;

        private Guid? _fk_guid_Enumeration = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_EnumParameter_has_Enumeration", "Enumeration")]
        public Kistl.App.Base.EnumerationEfImpl EnumerationImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.EnumerationEfImpl __value;
                EntityReference<Kistl.App.Base.EnumerationEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.EnumerationEfImpl>(
                        "Model.FK_EnumParameter_has_Enumeration",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnEnumeration_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Enumeration>(__value);
                    OnEnumeration_Getter(this, e);
                    __value = (Kistl.App.Base.EnumerationEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.EnumerationEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.EnumerationEfImpl>(
                        "Model.FK_EnumParameter_has_Enumeration",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.EnumerationEfImpl __oldValue = (Kistl.App.Base.EnumerationEfImpl)r.Value;
                Kistl.App.Base.EnumerationEfImpl __newValue = (Kistl.App.Base.EnumerationEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Enumeration", null, __oldValue, __newValue);

                if (OnEnumeration_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.EnumerationEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.EnumerationEfImpl)__newValue;

                if (OnEnumeration_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Enumeration", null, __oldValue, __newValue);
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
		public static event PropertyGetterHandler<Kistl.App.Base.EnumParameter, Kistl.App.Base.Enumeration> OnEnumeration_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.EnumParameter, Kistl.App.Base.Enumeration> OnEnumeration_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.EnumParameter, Kistl.App.Base.Enumeration> OnEnumeration_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.EnumParameter> OnEnumeration_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_EnumParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_EnumParameter != null)
            {
                OnGetLabel_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<EnumParameter> OnGetLabel_EnumParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetLabel_EnumParameter_CanExec;

        [EventBasedMethod("OnGetLabel_EnumParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_EnumParameter_CanExec != null)
				{
					OnGetLabel_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetLabel_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_EnumParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_EnumParameter_CanExecReason != null)
				{
					OnGetLabel_EnumParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterType_EnumParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_EnumParameter != null)
            {
                OnGetParameterType_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<EnumParameter> OnGetParameterType_EnumParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetParameterType_EnumParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_EnumParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_EnumParameter_CanExec != null)
				{
					OnGetParameterType_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetParameterType_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_EnumParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_EnumParameter_CanExecReason != null)
				{
					OnGetParameterType_EnumParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterTypeString_EnumParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_EnumParameter != null)
            {
                OnGetParameterTypeString_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<EnumParameter> OnGetParameterTypeString_EnumParameter;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetParameterTypeString_EnumParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_EnumParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_EnumParameter_CanExec != null)
				{
					OnGetParameterTypeString_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetParameterTypeString_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_EnumParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_EnumParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_EnumParameter_CanExecReason(this, e);
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
            return typeof(EnumParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumParameter)obj;
            var otherImpl = (EnumParameterEfImpl)obj;
            var me = (EnumParameter)this;

            this._fk_Enumeration = otherImpl._fk_Enumeration;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
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
                case "Enumeration":
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

            if (_fk_guid_Enumeration.HasValue)
                EnumerationImpl = (Kistl.App.Base.EnumerationEfImpl)Context.FindPersistenceObject<Kistl.App.Base.Enumeration>(_fk_guid_Enumeration.Value);
            else
            if (_fk_Enumeration.HasValue)
                EnumerationImpl = (Kistl.App.Base.EnumerationEfImpl)Context.Find<Kistl.App.Base.Enumeration>(_fk_Enumeration.Value);
            else
                EnumerationImpl = null;
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
                    new PropertyDescriptorEfImpl<EnumParameter, Kistl.App.Base.Enumeration>(
                        lazyCtx,
                        new Guid("b5212dc9-376e-4414-a400-d994779fda18"),
                        "Enumeration",
                        null,
                        obj => obj.Enumeration,
                        (obj, val) => obj.Enumeration = val,
						obj => OnEnumeration_IsValid), 
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_EnumParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumParameter != null)
            {
                OnToString_EnumParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumParameter> OnToString_EnumParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EnumParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EnumParameter != null)
            {
                OnObjectIsValid_EnumParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EnumParameter> OnObjectIsValid_EnumParameter;

        [EventBasedMethod("OnNotifyPreSave_EnumParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EnumParameter != null) OnNotifyPreSave_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyPreSave_EnumParameter;

        [EventBasedMethod("OnNotifyPostSave_EnumParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EnumParameter != null) OnNotifyPostSave_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyPostSave_EnumParameter;

        [EventBasedMethod("OnNotifyCreated_EnumParameter")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Enumeration");
            base.NotifyCreated();
            if (OnNotifyCreated_EnumParameter != null) OnNotifyCreated_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyCreated_EnumParameter;

        [EventBasedMethod("OnNotifyDeleting_EnumParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EnumParameter != null) OnNotifyDeleting_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyDeleting_EnumParameter;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.EnumerationEfImpl>("Model.FK_EnumParameter_has_Enumeration", "Enumeration").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            binStream.Read(out this._fk_Enumeration);
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Enumeration != null ? Enumeration.ExportGuid : (Guid?)null, xml, "Enumeration", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Kistl.App.Base|Enumeration":
                this._fk_guid_Enumeration = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}