// <autogenerated/>

namespace Zetbox.App.Test
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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Base object for testing TPH
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TPHBaseObj")]
    public class TPHBaseObjNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, TPHBaseObj, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("430ba80a-a9e4-4700-a0c3-06b21f2c77fe");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public TPHBaseObjNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public TPHBaseObjNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new TPHBaseObjProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TPHBaseObjNHibernateImpl(Func<IFrozenContext> lazyCtx, TPHBaseObjProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isCreatedOnSet = Proxy.ID > 0;
            _isChangedOnSet = Proxy.ID > 0;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly TPHBaseObjProxy Proxy;

        /// <summary>
        /// Identity which changed this object
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
        // fkBackingName=this.Proxy.ChangedBy; fkGuidBackingName=_fk_guid_ChangedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Identity ChangedBy
        {
            get
            {
                Zetbox.App.Base.IdentityNHibernateImpl __value = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ChangedBy);

                if (OnChangedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(__value);
                    OnChangedBy_Getter(this, e);
                    __value = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.ChangedBy == null)
				{
					SetInitializedProperty("ChangedBy");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ChangedBy);
                var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("ChangedBy");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);

                if (OnChangedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.ChangedBy = null;
                }
                else
                {
                    this.Proxy.ChangedBy = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnChangedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for ChangedBy's id, used on dehydration only</summary>
        private int? _fk_ChangedBy = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnChangedBy_IsValid;

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public DateTime ChangedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchChangedOnOrDefault();
                if (OnChangedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnChangedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isChangedOnSet = true;
                if (Proxy.ChangedOn != value)
                {
                    var __oldValue = Proxy.ChangedOn;
                    var __newValue = value;
                    if (OnChangedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnChangedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ChangedOn", __oldValue, __newValue);
                    Proxy.ChangedOn = __newValue;
                    NotifyPropertyChanged("ChangedOn", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnChangedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnChangedOn_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("ChangedOn");
				}
            }
        }


        private DateTime FetchChangedOnOrDefault()
        {
            var __result = Proxy.ChangedOn;
                if (!_isChangedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("07bcf241-16d2-45e1-9d59-d1098af5ecbc"));
                    if (__p != null) {
                        _isChangedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ChangedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.TPHBaseObj.ChangedOn'");
                    }
                }
            return __result;
        }

        private bool _isChangedOnSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnChangedOn_IsValid;

        /// <summary>
        /// Identity which created this object
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
        // fkBackingName=this.Proxy.CreatedBy; fkGuidBackingName=_fk_guid_CreatedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Identity CreatedBy
        {
            get
            {
                Zetbox.App.Base.IdentityNHibernateImpl __value = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CreatedBy);

                if (OnCreatedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(__value);
                    OnCreatedBy_Getter(this, e);
                    __value = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.CreatedBy == null)
				{
					SetInitializedProperty("CreatedBy");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CreatedBy);
                var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("CreatedBy");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);

                if (OnCreatedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.CreatedBy = null;
                }
                else
                {
                    this.Proxy.CreatedBy = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnCreatedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for CreatedBy's id, used on dehydration only</summary>
        private int? _fk_CreatedBy = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnCreatedBy_IsValid;

        /// <summary>
        /// Date and time where this object was created
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public DateTime CreatedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchCreatedOnOrDefault();
                if (OnCreatedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnCreatedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isCreatedOnSet = true;
                if (Proxy.CreatedOn != value)
                {
                    var __oldValue = Proxy.CreatedOn;
                    var __newValue = value;
                    if (OnCreatedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnCreatedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CreatedOn", __oldValue, __newValue);
                    Proxy.CreatedOn = __newValue;
                    NotifyPropertyChanged("CreatedOn", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnCreatedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnCreatedOn_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("CreatedOn");
				}
            }
        }


        private DateTime FetchCreatedOnOrDefault()
        {
            var __result = Proxy.CreatedOn;
                if (!_isCreatedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("d51a5e63-2bcb-47bb-9c9e-46caf563e8a6"));
                    if (__p != null) {
                        _isCreatedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.CreatedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.TPHBaseObj.CreatedOn'");
                    }
                }
            return __result;
        }

        private bool _isCreatedOnSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnCreatedOn_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchExportGuidOrDefault();
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (Proxy.ExportGuid != value)
                {
                    var __oldValue = Proxy.ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    Proxy.ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("ExportGuid");
				}
            }
        }


        private Guid FetchExportGuidOrDefault()
        {
            var __result = Proxy.ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("73f5e7ac-1dfc-4149-9995-8e3b04a95614"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.TPHBaseObj.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Name != value)
                {
                    var __oldValue = Proxy.Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    Proxy.Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Name");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(TPHBaseObj);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TPHBaseObj)obj;
            var otherImpl = (TPHBaseObjNHibernateImpl)obj;
            var me = (TPHBaseObj)this;

            me.ChangedOn = other.ChangedOn;
            me.CreatedOn = other.CreatedOn;
            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_ChangedBy = otherImpl._fk_ChangedBy;
            this._fk_CreatedBy = otherImpl._fk_CreatedBy;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "ChangedBy":
                    {
                        var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ChangedBy);
                        var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)parentObj;
                        NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);
                        this.Proxy.ChangedBy = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);
                    }
                    break;
                case "CreatedBy":
                    {
                        var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CreatedBy);
                        var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)parentObj;
                        NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);
                        this.Proxy.CreatedBy = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "ChangedBy":
                case "ChangedOn":
                case "CreatedBy":
                case "CreatedOn":
                case "ExportGuid":
                case "Name":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_ChangedBy.HasValue)
                this.ChangedBy = ((Zetbox.App.Base.IdentityNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Identity>(_fk_ChangedBy.Value));
            else
                this.ChangedBy = null;

            if (_fk_CreatedBy.HasValue)
                this.CreatedBy = ((Zetbox.App.Base.IdentityNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Identity>(_fk_CreatedBy.Value));
            else
                this.CreatedBy = null;
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
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("a8c0f966-ae75-4634-9958-612b4f8d8de0"),
                        "ChangedBy",
                        null,
                        obj => obj.ChangedBy,
                        (obj, val) => obj.ChangedBy = val,
						obj => OnChangedBy_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, DateTime>(
                        lazyCtx,
                        new Guid("07bcf241-16d2-45e1-9d59-d1098af5ecbc"),
                        "ChangedOn",
                        null,
                        obj => obj.ChangedOn,
                        (obj, val) => obj.ChangedOn = val,
						obj => OnChangedOn_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("d810d56c-0fac-4525-b0c6-cf2bfaa43e61"),
                        "CreatedBy",
                        null,
                        obj => obj.CreatedBy,
                        (obj, val) => obj.CreatedBy = val,
						obj => OnCreatedBy_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, DateTime>(
                        lazyCtx,
                        new Guid("d51a5e63-2bcb-47bb-9c9e-46caf563e8a6"),
                        "CreatedOn",
                        null,
                        obj => obj.CreatedOn,
                        (obj, val) => obj.CreatedOn = val,
						obj => OnCreatedOn_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, Guid>(
                        lazyCtx,
                        new Guid("73f5e7ac-1dfc-4149-9995-8e3b04a95614"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TPHBaseObj, string>(
                        lazyCtx,
                        new Guid("ad7feae4-cbeb-4bb5-a87c-5eb24c130e6d"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TPHBaseObj")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TPHBaseObj != null)
            {
                OnToString_TPHBaseObj(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TPHBaseObj> OnToString_TPHBaseObj;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TPHBaseObj")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TPHBaseObj != null)
            {
                OnObjectIsValid_TPHBaseObj(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TPHBaseObj> OnObjectIsValid_TPHBaseObj;

        [EventBasedMethod("OnNotifyPreSave_TPHBaseObj")]
        public override void NotifyPreSave()
        {
            FetchChangedOnOrDefault();
            FetchCreatedOnOrDefault();
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_TPHBaseObj != null) OnNotifyPreSave_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyPreSave_TPHBaseObj;

        [EventBasedMethod("OnNotifyPostSave_TPHBaseObj")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TPHBaseObj != null) OnNotifyPostSave_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyPostSave_TPHBaseObj;

        [EventBasedMethod("OnNotifyCreated_TPHBaseObj")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ChangedBy");
            SetNotInitializedProperty("CreatedBy");
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_TPHBaseObj != null) OnNotifyCreated_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyCreated_TPHBaseObj;

        [EventBasedMethod("OnNotifyDeleting_TPHBaseObj")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TPHBaseObj != null) OnNotifyDeleting_TPHBaseObj(this);

            // FK_TPHBaseObj_was_ChangedBy
            if (ChangedBy != null) {
                ((NHibernatePersistenceObject)ChangedBy).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)ChangedBy);
            }
            // FK_TPHBaseObj_was_CreatedBy
            if (CreatedBy != null) {
                ((NHibernatePersistenceObject)CreatedBy).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)CreatedBy);
            }

            ChangedBy = null;
            CreatedBy = null;
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyDeleting_TPHBaseObj;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class TPHBaseObjProxy
            : IProxyObject, ISortKey<int>
        {
            public TPHBaseObjProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(TPHBaseObjNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(TPHBaseObjProxy); } }

            public virtual Zetbox.App.Base.IdentityNHibernateImpl.IdentityProxy ChangedBy { get; set; }

            public virtual DateTime ChangedOn { get; set; }

            public virtual Zetbox.App.Base.IdentityNHibernateImpl.IdentityProxy CreatedBy { get; set; }

            public virtual DateTime CreatedOn { get; set; }

            public virtual Guid ExportGuid { get; set; }

            public virtual string Name { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.ChangedBy != null ? OurContext.GetIdFromProxy(this.Proxy.ChangedBy) : (int?)null);
            binStream.Write(this._isChangedOnSet);
            if (this._isChangedOnSet) {
                binStream.Write(this.Proxy.ChangedOn);
            }
            binStream.Write(this.Proxy.CreatedBy != null ? OurContext.GetIdFromProxy(this.Proxy.CreatedBy) : (int?)null);
            binStream.Write(this._isCreatedOnSet);
            if (this._isCreatedOnSet) {
                binStream.Write(this.Proxy.CreatedOn);
            }
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this.Proxy.ExportGuid);
            }
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_ChangedBy);
            this._isChangedOnSet = binStream.ReadBoolean();
            if (this._isChangedOnSet) {
                this.Proxy.ChangedOn = binStream.ReadDateTime();
            }
            binStream.Read(out this._fk_CreatedBy);
            this._isCreatedOnSet = binStream.ReadBoolean();
            if (this._isCreatedOnSet) {
                this.Proxy.CreatedOn = binStream.ReadDateTime();
            }
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this.Proxy.ExportGuid = binStream.ReadGuid();
            }
            this.Proxy.Name = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this.Proxy.ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            System.Diagnostics.Debug.Assert(this._isChangedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this.Proxy.ChangedOn, xml, "ChangedOn", "Zetbox.App.Test");
            System.Diagnostics.Debug.Assert(this._isCreatedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this.Proxy.CreatedOn, xml, "CreatedOn", "Zetbox.App.Test");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this.Proxy.Name, xml, "Name", "Zetbox.App.Test");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Test|ChangedOn":
                // Import must have default value set
                this.Proxy.ChangedOn = XmlStreamer.ReadDateTime(xml);
                this._isChangedOnSet = true;
                break;
            case "Zetbox.App.Test|CreatedOn":
                // Import must have default value set
                this.Proxy.CreatedOn = XmlStreamer.ReadDateTime(xml);
                this._isCreatedOnSet = true;
                break;
            case "Zetbox.App.Test|ExportGuid":
                // Import must have default value set
                this.Proxy.ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Test|Name":
                this.Proxy.Name = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}