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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Icon")]
    public class IconNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, Icon, Kistl.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("78b6f354-013b-4129-a390-7f3a5a5e28e9");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public IconNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IconNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IconProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IconNHibernateImpl(Func<IFrozenContext> lazyCtx, IconProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly IconProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
        // fkBackingName=this.Proxy.Blob; fkGuidBackingName=_fk_guid_Blob;
        // referencedInterface=Kistl.App.Base.Blob; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Blob Blob
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.BlobNHibernateImpl __value = (Kistl.App.Base.BlobNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Blob);

                if (OnBlob_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Blob>(__value);
                    OnBlob_Getter(this, e);
                    __value = (Kistl.App.Base.BlobNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Blob == null)
				{
					SetInitializedProperty("Blob");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.BlobNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Blob);
                var __newValue = (Kistl.App.Base.BlobNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Blob");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Blob", __oldValue, __newValue);

                if (OnBlob_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.BlobNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Blob = null;
                }
                else
                {
                    this.Proxy.Blob = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Blob", __oldValue, __newValue);

                if (OnBlob_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Blob's id, used on dehydration only</summary>
        private int? _fk_Blob = null;

        /// <summary>Backing store for Blob's guid, used on import only</summary>
        private Guid? _fk_guid_Blob = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.Icon> OnBlob_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Guid ExportGuid
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Guid);
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
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Kistl.App.GUI.Icon.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.Icon> OnExportGuid_IsValid;

        /// <summary>
        /// Filename of the Icon
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string IconFile
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IconFile;
                if (OnIconFile_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnIconFile_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IconFile != value)
                {
                    var __oldValue = Proxy.IconFile;
                    var __newValue = value;
                    if (OnIconFile_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IconFile", __oldValue, __newValue);
                    Proxy.IconFile = __newValue;
                    NotifyPropertyChanged("IconFile", __oldValue, __newValue);

                    if (OnIconFile_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("IconFile");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.Icon> OnIconFile_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=this.Proxy.Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Kistl.App.Base.Module; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.ModuleNHibernateImpl __value = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Kistl.App.Base.ModuleNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Module == null)
				{
					SetInitializedProperty("Module");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);
                var __newValue = (Kistl.App.Base.ModuleNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Module");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ModuleNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Module = null;
                }
                else
                {
                    this.Proxy.Module = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Module's id, used on dehydration only</summary>
        private int? _fk_Module = null;

        /// <summary>Backing store for Module's guid, used on import only</summary>
        private Guid? _fk_guid_Module = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.Icon> OnModule_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_Icon")]
        public virtual string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_Icon != null)
            {
                OnGetName_Icon(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Icon.GetName");
            }
            return e.Result;
        }
        public delegate void GetName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetName_Handler<Icon> OnGetName_Icon;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnGetName_Icon_CanExec;

        [EventBasedMethod("OnGetName_Icon_CanExec")]
        public virtual bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_Icon_CanExec != null)
				{
					OnGetName_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnGetName_Icon_CanExecReason;

        [EventBasedMethod("OnGetName_Icon_CanExecReason")]
        public virtual string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_Icon_CanExecReason != null)
				{
					OnGetName_Icon_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_Icon")]
        public virtual void Open()
        {
            // base.Open();
            if (OnOpen_Icon != null)
            {
                OnOpen_Icon(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method Icon.Open");
            }
        }
        public delegate void Open_Handler<T>(T obj);
        public static event Open_Handler<Icon> OnOpen_Icon;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnOpen_Icon_CanExec;

        [EventBasedMethod("OnOpen_Icon_CanExec")]
        public virtual bool OpenCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnOpen_Icon_CanExec != null)
				{
					OnOpen_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnOpen_Icon_CanExecReason;

        [EventBasedMethod("OnOpen_Icon_CanExecReason")]
        public virtual string OpenCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnOpen_Icon_CanExecReason != null)
				{
					OnOpen_Icon_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_Icon")]
        public virtual void Upload()
        {
            // base.Upload();
            if (OnUpload_Icon != null)
            {
                OnUpload_Icon(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method Icon.Upload");
            }
        }
        public delegate void Upload_Handler<T>(T obj);
        public static event Upload_Handler<Icon> OnUpload_Icon;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnUpload_Icon_CanExec;

        [EventBasedMethod("OnUpload_Icon_CanExec")]
        public virtual bool UploadCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnUpload_Icon_CanExec != null)
				{
					OnUpload_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnUpload_Icon_CanExecReason;

        [EventBasedMethod("OnUpload_Icon_CanExecReason")]
        public virtual string UploadCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnUpload_Icon_CanExecReason != null)
				{
					OnUpload_Icon_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(Icon);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Icon)obj;
            var otherImpl = (IconNHibernateImpl)obj;
            var me = (Icon)this;

            me.ExportGuid = other.ExportGuid;
            me.IconFile = other.IconFile;
            this._fk_Blob = otherImpl._fk_Blob;
            this._fk_Module = otherImpl._fk_Module;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Blob":
                    {
                        var __oldValue = (Kistl.App.Base.BlobNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Blob);
                        var __newValue = (Kistl.App.Base.BlobNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Blob", __oldValue, __newValue);
                        this.Proxy.Blob = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Blob", __oldValue, __newValue);
                    }
                    break;
                case "Module":
                    {
                        var __oldValue = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);
                        var __newValue = (Kistl.App.Base.ModuleNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Module", __oldValue, __newValue);
                        this.Proxy.Module = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Module", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Blob":
                case "ExportGuid":
                case "IconFile":
                case "Module":
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

            if (_fk_guid_Blob.HasValue)
                this.Blob = ((Kistl.App.Base.BlobNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Blob>(_fk_guid_Blob.Value));
            else
            if (_fk_Blob.HasValue)
                this.Blob = ((Kistl.App.Base.BlobNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Blob>(_fk_Blob.Value));
            else
                this.Blob = null;

            if (_fk_guid_Module.HasValue)
                this.Module = ((Kistl.App.Base.ModuleNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value));
            else
            if (_fk_Module.HasValue)
                this.Module = ((Kistl.App.Base.ModuleNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Module>(_fk_Module.Value));
            else
                this.Module = null;
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
                    new PropertyDescriptorNHibernateImpl<Icon, Kistl.App.Base.Blob>(
                        lazyCtx,
                        new Guid("f4dfb868-260d-450b-84b8-833dac4d25ee"),
                        "Blob",
                        null,
                        obj => obj.Blob,
                        (obj, val) => obj.Blob = val,
						obj => OnBlob_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Icon, Guid>(
                        lazyCtx,
                        new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Icon, string>(
                        lazyCtx,
                        new Guid("cdbdfc01-5faa-416b-960f-2eb220f268fe"),
                        "IconFile",
                        null,
                        obj => obj.IconFile,
                        (obj, val) => obj.IconFile = val,
						obj => OnIconFile_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Icon, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("052273ac-706a-446b-bb86-83c726ee66d6"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Icon")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Icon != null)
            {
                OnToString_Icon(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Icon> OnToString_Icon;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Icon")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Icon != null)
            {
                OnObjectIsValid_Icon(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Icon> OnObjectIsValid_Icon;

        [EventBasedMethod("OnNotifyPreSave_Icon")]
        public override void NotifyPreSave()
        {
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_Icon != null) OnNotifyPreSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyPreSave_Icon;

        [EventBasedMethod("OnNotifyPostSave_Icon")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Icon != null) OnNotifyPostSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyPostSave_Icon;

        [EventBasedMethod("OnNotifyCreated_Icon")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Blob");
            SetNotInitializedProperty("IconFile");
            SetNotInitializedProperty("Module");
            base.NotifyCreated();
            if (OnNotifyCreated_Icon != null) OnNotifyCreated_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyCreated_Icon;

        [EventBasedMethod("OnNotifyDeleting_Icon")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Icon != null) OnNotifyDeleting_Icon(this);

            // should fetch && remember parent for BoolProperty_has_Icon_RelationEntry
            // should fetch && remember parent for BoolProperty_has_Icon_RelationEntry
            // should fetch && remember parent for BoolProperty_has_Icon_RelationEntry
            // should fetch && remember parent for DataType_has_Icon_RelationEntry
            // FK_Icon_has_Blob
            if (Blob != null) {
                ((NHibernatePersistenceObject)Blob).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Blob);
            }
            // FK_Icon_has_Module
            if (Module != null) {
                ((NHibernatePersistenceObject)Module).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Module);
            }
            // should fetch && remember parent for Method_has_Icon_RelationEntry

        }
        public static event ObjectEventHandler<Icon> OnNotifyDeleting_Icon;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class IconProxy
            : IProxyObject, ISortKey<int>
        {
            public IconProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(IconNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(IconProxy); } }

            public virtual Kistl.App.Base.BlobNHibernateImpl.BlobProxy Blob { get; set; }

            public virtual Guid ExportGuid { get; set; }

            public virtual string IconFile { get; set; }

            public virtual Kistl.App.Base.ModuleNHibernateImpl.ModuleProxy Module { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Blob != null ? OurContext.GetIdFromProxy(this.Proxy.Blob) : (int?)null);
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this.Proxy.ExportGuid);
            }
            binStream.Write(this.Proxy.IconFile);
            binStream.Write(this.Proxy.Module != null ? OurContext.GetIdFromProxy(this.Proxy.Module) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            binStream.Read(out this._fk_Blob);
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this.Proxy.ExportGuid = binStream.ReadGuid();
            }
            this.Proxy.IconFile = binStream.ReadString();
            binStream.Read(out this._fk_Module);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.Blob != null ? this.Proxy.Blob.ExportGuid : (Guid?)null, xml, "Blob", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IconFile, xml, "IconFile", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.Module != null ? this.Proxy.Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Kistl.App.GUI|Blob":
                this._fk_guid_Blob = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Kistl.App.Base|ExportGuid":
                // Import must have default value set
                this.Proxy.ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Kistl.App.GUI|IconFile":
                this.Proxy.IconFile = XmlStreamer.ReadString(xml);
                break;
            case "Kistl.App.GUI|Module":
                this._fk_guid_Module = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}