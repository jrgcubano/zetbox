// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Zetbox.API;
    using Zetbox.DalProvider.Base.RelationWrappers;

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// Sets an enumeration property with an configured default value
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="EnumDefaultValueEfImpl")]
    [System.Diagnostics.DebuggerDisplay("EnumDefaultValue")]
    public class EnumDefaultValueEfImpl : Zetbox.App.Base.DefaultPropertyValueEfImpl, EnumDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("4f35c5da-924c-4114-a011-4d736faa3ae2");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public EnumDefaultValueEfImpl()
            : base(null)
        {
        }

        public EnumDefaultValueEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_EnumDefaultValue_defaults_to_EnumValue
    A: ZeroOrMore EnumDefaultValue as EnumDefaultValue
    B: One EnumerationEntry as EnumValue
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
        // fkBackingName=_fk_EnumValue; fkGuidBackingName=_fk_guid_EnumValue;
        // referencedInterface=Zetbox.App.Base.EnumerationEntry; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.EnumerationEntry EnumValue
        {
            get { return EnumValueImpl; }
            set { EnumValueImpl = (Zetbox.App.Base.EnumerationEntryEfImpl)value; }
        }

        private int? _fk_EnumValue;

        private Guid? _fk_guid_EnumValue = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_EnumDefaultValue_defaults_to_EnumValue", "EnumValue")]
        public Zetbox.App.Base.EnumerationEntryEfImpl EnumValueImpl
        {
            get
            {
                Zetbox.App.Base.EnumerationEntryEfImpl __value;
                EntityReference<Zetbox.App.Base.EnumerationEntryEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.EnumerationEntryEfImpl>(
                        "Model.FK_EnumDefaultValue_defaults_to_EnumValue",
                        "EnumValue");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnEnumValue_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__value);
                    OnEnumValue_Getter(this, e);
                    __value = (Zetbox.App.Base.EnumerationEntryEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.EnumerationEntryEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.EnumerationEntryEfImpl>(
                        "Model.FK_EnumDefaultValue_defaults_to_EnumValue",
                        "EnumValue");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.EnumerationEntryEfImpl __oldValue = (Zetbox.App.Base.EnumerationEntryEfImpl)r.Value;
                Zetbox.App.Base.EnumerationEntryEfImpl __newValue = (Zetbox.App.Base.EnumerationEntryEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("EnumValue", __oldValue, __newValue);

                if (OnEnumValue_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.EnumerationEntryEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.EnumerationEntryEfImpl)__newValue;

                if (OnEnumValue_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("EnumValue", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
		public static event PropertyGetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.EnumDefaultValue> OnEnumValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_EnumDefaultValue != null)
            {
                OnGetDefaultValue_EnumDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_EnumDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_EnumDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_EnumDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_EnumDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(EnumDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumDefaultValue)obj;
            var otherImpl = (EnumDefaultValueEfImpl)obj;
            var me = (EnumDefaultValue)this;

            this._fk_EnumValue = otherImpl._fk_EnumValue;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "EnumValue":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_EnumValue.HasValue)
                EnumValueImpl = (Zetbox.App.Base.EnumerationEntryEfImpl)Context.FindPersistenceObject<Zetbox.App.Base.EnumerationEntry>(_fk_guid_EnumValue.Value);
            else
            if (_fk_EnumValue.HasValue)
                EnumValueImpl = (Zetbox.App.Base.EnumerationEntryEfImpl)Context.Find<Zetbox.App.Base.EnumerationEntry>(_fk_EnumValue.Value);
            else
                EnumValueImpl = null;
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    new PropertyDescriptorEfImpl<EnumDefaultValue, Zetbox.App.Base.EnumerationEntry>(
                        lazyCtx,
                        new Guid("d072423b-f723-4342-8111-79fb563c8ab4"),
                        "EnumValue",
                        null,
                        obj => obj.EnumValue,
                        (obj, val) => obj.EnumValue = val,
						obj => OnEnumValue_IsValid), 
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_EnumDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumDefaultValue != null)
            {
                OnToString_EnumDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumDefaultValue> OnToString_EnumDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EnumDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EnumDefaultValue != null)
            {
                OnObjectIsValid_EnumDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EnumDefaultValue> OnObjectIsValid_EnumDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_EnumDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EnumDefaultValue != null) OnNotifyPreSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyPreSave_EnumDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_EnumDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EnumDefaultValue != null) OnNotifyPostSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyPostSave_EnumDefaultValue;

        [EventBasedMethod("OnNotifyCreated_EnumDefaultValue")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("EnumValue");
            base.NotifyCreated();
            if (OnNotifyCreated_EnumDefaultValue != null) OnNotifyCreated_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyCreated_EnumDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_EnumDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EnumDefaultValue != null) OnNotifyDeleting_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyDeleting_EnumDefaultValue;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var r = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.EnumerationEntryEfImpl>("Model.FK_EnumDefaultValue_defaults_to_EnumValue", "EnumValue");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_EnumValue);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(EnumValue != null ? EnumValue.ExportGuid : (Guid?)null, xml, "EnumValue", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|EnumValue":
                this._fk_guid_EnumValue = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}