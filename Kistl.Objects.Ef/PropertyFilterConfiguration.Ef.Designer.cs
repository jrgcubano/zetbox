// <autogenerated/>

namespace Kistl.App.GUI
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
    /// Abstract base class for Property Filter
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="PropertyFilterConfiguration")]
    [System.Diagnostics.DebuggerDisplay("PropertyFilterConfiguration")]
    public abstract class PropertyFilterConfigurationEfImpl : Kistl.App.GUI.FilterConfigurationEfImpl, PropertyFilterConfiguration
    {
        [Obsolete]
        public PropertyFilterConfigurationEfImpl()
            : base(null)
        {
        }

        public PropertyFilterConfigurationEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Property_Has_PropertyFilterConfiguration
    A: One Property as Property
    B: ZeroOrOne PropertyFilterConfiguration as PropertyFilterConfiguration
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
        // fkBackingName=_fk_Property; fkGuidBackingName=_fk_guid_Property;
        // referencedInterface=Kistl.App.Base.Property; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=FilterConfiguration; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Property Property
        {
            get { return PropertyImpl; }
            set { PropertyImpl = (Kistl.App.Base.PropertyEfImpl)value; }
        }

        private int? _fk_Property;

        private Guid? _fk_guid_Property = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Property_Has_PropertyFilterConfiguration", "Property")]
        public Kistl.App.Base.PropertyEfImpl PropertyImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.PropertyEfImpl __value;
                EntityReference<Kistl.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>(
                        "Model.FK_Property_Has_PropertyFilterConfiguration",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnProperty_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Property>(__value);
                    OnProperty_Getter(this, e);
                    __value = (Kistl.App.Base.PropertyEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>(
                        "Model.FK_Property_Has_PropertyFilterConfiguration",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.PropertyEfImpl __oldValue = (Kistl.App.Base.PropertyEfImpl)r.Value;
                Kistl.App.Base.PropertyEfImpl __newValue = (Kistl.App.Base.PropertyEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Property", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("FilterConfiguration", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("FilterConfiguration", null, null, null);
                }

                if (OnProperty_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.PropertyEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.PropertyEfImpl)__newValue;

                if (OnProperty_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Property", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("FilterConfiguration", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("FilterConfiguration", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
		public static event PropertyGetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.PropertyFilterConfiguration> OnProperty_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_PropertyFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_PropertyFilterConfiguration != null)
            {
                OnCreateFilterModel_PropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<PropertyFilterConfiguration> OnCreateFilterModel_PropertyFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<PropertyFilterConfiguration> OnCreateFilterModel_PropertyFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_PropertyFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_PropertyFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_PropertyFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<PropertyFilterConfiguration> OnCreateFilterModel_PropertyFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_PropertyFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_PropertyFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_PropertyFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_PropertyFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_PropertyFilterConfiguration != null)
            {
                OnGetLabel_PropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<PropertyFilterConfiguration> OnGetLabel_PropertyFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<PropertyFilterConfiguration> OnGetLabel_PropertyFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_PropertyFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_PropertyFilterConfiguration_CanExec != null)
				{
					OnGetLabel_PropertyFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<PropertyFilterConfiguration> OnGetLabel_PropertyFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_PropertyFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_PropertyFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_PropertyFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(PropertyFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (PropertyFilterConfiguration)obj;
            var otherImpl = (PropertyFilterConfigurationEfImpl)obj;
            var me = (PropertyFilterConfiguration)this;

            this._fk_Property = otherImpl._fk_Property;
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

            if (_fk_guid_Property.HasValue)
                PropertyImpl = (Kistl.App.Base.PropertyEfImpl)Context.FindPersistenceObject<Kistl.App.Base.Property>(_fk_guid_Property.Value);
            else
            if (_fk_Property.HasValue)
                PropertyImpl = (Kistl.App.Base.PropertyEfImpl)Context.Find<Kistl.App.Base.Property>(_fk_Property.Value);
            else
                PropertyImpl = null;
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
                    new PropertyDescriptorEfImpl<PropertyFilterConfiguration, Kistl.App.Base.Property>(
                        lazyCtx,
                        new Guid("384208e7-eb27-41f1-ac12-b05822c0a2ad"),
                        "Property",
                        null,
                        obj => obj.Property,
                        (obj, val) => obj.Property = val,
						obj => OnProperty_IsValid), 
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
        [EventBasedMethod("OnToString_PropertyFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PropertyFilterConfiguration != null)
            {
                OnToString_PropertyFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<PropertyFilterConfiguration> OnToString_PropertyFilterConfiguration;

        [EventBasedMethod("OnNotifyPreSave_PropertyFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_PropertyFilterConfiguration != null) OnNotifyPreSave_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnNotifyPreSave_PropertyFilterConfiguration;

        [EventBasedMethod("OnNotifyPostSave_PropertyFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_PropertyFilterConfiguration != null) OnNotifyPostSave_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnNotifyPostSave_PropertyFilterConfiguration;

        [EventBasedMethod("OnNotifyCreated_PropertyFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_PropertyFilterConfiguration != null) OnNotifyCreated_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnNotifyCreated_PropertyFilterConfiguration;

        [EventBasedMethod("OnNotifyDeleting_PropertyFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_PropertyFilterConfiguration != null) OnNotifyDeleting_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnNotifyDeleting_PropertyFilterConfiguration;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>("Model.FK_Property_Has_PropertyFilterConfiguration", "Property").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_Property, binStream);
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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>("Model.FK_Property_Has_PropertyFilterConfiguration", "Property").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Property", "Kistl.App.GUI");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Property, xml, "Property", "Kistl.App.GUI");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Property != null ? Property.ExportGuid : (Guid?)null, xml, "Property", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_Property, xml, "Property", "Kistl.App.GUI");
        }

        #endregion

    }
}