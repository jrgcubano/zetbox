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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AnyReferenceTestObject")]
    public class AnyReferenceTestObjectMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, AnyReferenceTestObject, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("3a8d152e-b8d1-4439-bfe4-367731218ce9");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public AnyReferenceTestObjectMemoryImpl()
            : base(null)
        {
            AnyImpl = new Zetbox.App.Base.AnyReferenceMemoryImpl(null, this, "Any");
        }

        public AnyReferenceTestObjectMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
            AnyImpl = new Zetbox.App.Base.AnyReferenceMemoryImpl(lazyCtx, this, "Any");
        }

        /// <summary>
        /// 
        /// </summary>
        // CompoundObject property
        // BEGIN Zetbox.Generator.Templates.Properties.CompoundObjectPropertyTemplate
        // implement the user-visible interface
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.AnyReference Any
        {
            get { return AnyImpl; }
            set { AnyImpl = (Zetbox.App.Base.AnyReferenceMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        /// <summary>backing store for Any</summary>
        private Zetbox.App.Base.AnyReferenceMemoryImpl _Any;

        /// <summary>backing property for Any, takes care of attaching/detaching the values</summary>
        public Zetbox.App.Base.AnyReferenceMemoryImpl AnyImpl
        {
            get 
			{ 
				return _Any; 
			}
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value == null)
                    throw new ArgumentNullException("value");
                if (!object.Equals(_Any, value))
                {
					var __oldValue = _Any;
					var __newValue = value;

					NotifyPropertyChanging("Any", __oldValue, __newValue);

					if (_Any != null)
					{ 
						_Any.DetachFromObject(this, "Any");
					}
					__newValue = (Zetbox.App.Base.AnyReferenceMemoryImpl)__newValue.Clone();
					_Any = __newValue;
					_Any.AttachToObject(this, "Any");

					NotifyPropertyChanged("Any", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;
				}
				else
				{
					SetInitializedProperty("Any");
				}
            }
        }
        // END Zetbox.Generator.Templates.Properties.CompoundObjectPropertyTemplate
        public static event PropertyIsValidHandler<Zetbox.App.Test.AnyReferenceTestObject> OnAny_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string DisplayName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = _DisplayName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayName != value)
                {
                    var __oldValue = _DisplayName;
                    var __newValue = value;
                    if (OnDisplayName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    _DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDisplayName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("DisplayName");
				}
            }
        }
        private string _DisplayName;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.AnyReferenceTestObject, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.AnyReferenceTestObject, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.AnyReferenceTestObject, string> OnDisplayName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.AnyReferenceTestObject> OnDisplayName_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("65839be9-d3b7-4910-9812-c2d44d008c41"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AnyReferenceTestObject.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = _ExportGuid = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
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
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.AnyReferenceTestObject, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.AnyReferenceTestObject, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.AnyReferenceTestObject, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.AnyReferenceTestObject> OnExportGuid_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(AnyReferenceTestObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AnyReferenceTestObject)obj;
            var otherImpl = (AnyReferenceTestObjectMemoryImpl)obj;
            var me = (AnyReferenceTestObject)this;

            me.DisplayName = other.DisplayName;
            me.ExportGuid = other.ExportGuid;
            if (me.Any == null && other.Any != null) {
                me.Any = (Zetbox.App.Base.AnyReference)other.Any.Clone();
            } else if (me.Any != null && other.Any == null) {
                me.Any = null;
            } else if (me.Any != null && other.Any != null) {
                me.Any.ApplyChangesFrom(other.Any);
            }
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Any":
                case "DisplayName":
                case "ExportGuid":
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
                    new PropertyDescriptorMemoryImpl<AnyReferenceTestObject, Zetbox.App.Base.AnyReference>(
                        lazyCtx,
                        new Guid("de93b394-d1e8-4c17-a1df-30aaff7f27f5"),
                        "Any",
                        null,
                        obj => obj.Any,
                        (obj, val) => obj.Any = val,
						obj => OnAny_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AnyReferenceTestObject, string>(
                        lazyCtx,
                        new Guid("3e806c0f-5ef0-47d1-b504-47b5d2dd59fb"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val,
						obj => OnDisplayName_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AnyReferenceTestObject, Guid>(
                        lazyCtx,
                        new Guid("65839be9-d3b7-4910-9812-c2d44d008c41"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
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
        [EventBasedMethod("OnToString_AnyReferenceTestObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AnyReferenceTestObject != null)
            {
                OnToString_AnyReferenceTestObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AnyReferenceTestObject> OnToString_AnyReferenceTestObject;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_AnyReferenceTestObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_AnyReferenceTestObject != null)
            {
                OnObjectIsValid_AnyReferenceTestObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<AnyReferenceTestObject> OnObjectIsValid_AnyReferenceTestObject;

        [EventBasedMethod("OnNotifyPreSave_AnyReferenceTestObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_AnyReferenceTestObject != null) OnNotifyPreSave_AnyReferenceTestObject(this);
        }
        public static event ObjectEventHandler<AnyReferenceTestObject> OnNotifyPreSave_AnyReferenceTestObject;

        [EventBasedMethod("OnNotifyPostSave_AnyReferenceTestObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_AnyReferenceTestObject != null) OnNotifyPostSave_AnyReferenceTestObject(this);
        }
        public static event ObjectEventHandler<AnyReferenceTestObject> OnNotifyPostSave_AnyReferenceTestObject;

        [EventBasedMethod("OnNotifyCreated_AnyReferenceTestObject")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Any");
            SetNotInitializedProperty("DisplayName");
            base.NotifyCreated();
            if (OnNotifyCreated_AnyReferenceTestObject != null) OnNotifyCreated_AnyReferenceTestObject(this);
        }
        public static event ObjectEventHandler<AnyReferenceTestObject> OnNotifyCreated_AnyReferenceTestObject;

        [EventBasedMethod("OnNotifyDeleting_AnyReferenceTestObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_AnyReferenceTestObject != null) OnNotifyDeleting_AnyReferenceTestObject(this);
        }
        public static event ObjectEventHandler<AnyReferenceTestObject> OnNotifyDeleting_AnyReferenceTestObject;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Any);
            binStream.Write(this._DisplayName);
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            {
                // use backing store to avoid notifications
                this.AnyImpl = binStream.ReadCompoundObject<Zetbox.App.Base.AnyReferenceMemoryImpl>();
                this.AnyImpl.AttachToObject(this, "Any");
            }
            this._DisplayName = binStream.ReadString();
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ExportCompoundObject(this.Any, xml, "Any", "Zetbox.App.Test");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._DisplayName, xml, "DisplayName", "Zetbox.App.Test");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Test|Any":
                XmlStreamer.MergeImportCompoundObject(this.AnyImpl, xml);
                break;
            case "Zetbox.App.Test|DisplayName":
                this._DisplayName = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.Test|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            }
        }

        #endregion

    }
}