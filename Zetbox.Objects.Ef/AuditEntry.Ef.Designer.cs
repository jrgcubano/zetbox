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
    /// A single entry in the auditing table of a class
    /// </summary>
    [EdmComplexType(NamespaceName="Model", Name="AuditEntry")]
    [System.Diagnostics.DebuggerDisplay("AuditEntry")]
    public class AuditEntryEfImpl : BaseServerCompoundObject_EntityFramework, AuditEntry, ICompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("84d3d914-cb79-41fe-8aae-54128e7edb87");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        public AuditEntryEfImpl()
            : base(null) // TODO: pass parent's lazyCtx
        {

        }
        public AuditEntryEfImpl(IPersistenceObject parent, string property)
            : base(null) // TODO: pass parent's lazyCtx
        {
            AttachToObject(parent, property);
        }
        public AuditEntryEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {

        }
        public AuditEntryEfImpl(Func<IFrozenContext> lazyCtx, IPersistenceObject parent, string property)
            : base(lazyCtx)
        {
            AttachToObject(parent, property);
        }

        /// <summary>
        /// The identity that caued this audit
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Identity
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Identity;
                if (OnIdentity_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnIdentity_Getter(this, __e);
                    __result = _Identity = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Identity != value)
                {
                    var __oldValue = _Identity;
                    var __newValue = value;
                    if (OnIdentity_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIdentity_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Identity", __oldValue, __newValue);
                    _Identity = __newValue;
                    NotifyPropertyChanged("Identity", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIdentity_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIdentity_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Identity");
				}
            }
        }
        private string _Identity_store;
        private string _Identity {
            get { return _Identity_store; }
            set {
                ReportEfPropertyChanging("Identity");
                _Identity_store = value;
                ReportEfPropertyChanged("Identity");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_PostSetter;

        /// <summary>
        /// The default format to display this change to the user
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string MessageFormat
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MessageFormat;
                if (OnMessageFormat_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMessageFormat_Getter(this, __e);
                    __result = _MessageFormat = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MessageFormat != value)
                {
                    var __oldValue = _MessageFormat;
                    var __newValue = value;
                    if (OnMessageFormat_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessageFormat_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MessageFormat", __oldValue, __newValue);
                    _MessageFormat = __newValue;
                    NotifyPropertyChanged("MessageFormat", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMessageFormat_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessageFormat_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("MessageFormat");
				}
            }
        }
        private string _MessageFormat_store;
        private string _MessageFormat {
            get { return _MessageFormat_store; }
            set {
                ReportEfPropertyChanging("MessageFormat");
                _MessageFormat_store = value;
                ReportEfPropertyChanged("MessageFormat");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string NewValue
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NewValue;
                if (OnNewValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNewValue_Getter(this, __e);
                    __result = _NewValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_NewValue != value)
                {
                    var __oldValue = _NewValue;
                    var __newValue = value;
                    if (OnNewValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNewValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NewValue", __oldValue, __newValue);
                    _NewValue = __newValue;
                    NotifyPropertyChanged("NewValue", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNewValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNewValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("NewValue");
				}
            }
        }
        private string _NewValue_store;
        private string _NewValue {
            get { return _NewValue_store; }
            set {
                ReportEfPropertyChanging("NewValue");
                _NewValue_store = value;
                ReportEfPropertyChanged("NewValue");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string OldValue
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _OldValue;
                if (OnOldValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnOldValue_Getter(this, __e);
                    __result = _OldValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_OldValue != value)
                {
                    var __oldValue = _OldValue;
                    var __newValue = value;
                    if (OnOldValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnOldValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("OldValue", __oldValue, __newValue);
                    _OldValue = __newValue;
                    NotifyPropertyChanged("OldValue", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnOldValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnOldValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("OldValue");
				}
            }
        }
        private string _OldValue_store;
        private string _OldValue {
            get { return _OldValue_store; }
            set {
                ReportEfPropertyChanging("OldValue");
                _OldValue_store = value;
                ReportEfPropertyChanged("OldValue");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_PostSetter;

        /// <summary>
        /// The name of the changed property
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string PropertyName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _PropertyName;
                if (OnPropertyName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPropertyName_Getter(this, __e);
                    __result = _PropertyName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_PropertyName != value)
                {
                    var __oldValue = _PropertyName;
                    var __newValue = value;
                    if (OnPropertyName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPropertyName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("PropertyName", __oldValue, __newValue);
                    _PropertyName = __newValue;
                    NotifyPropertyChanged("PropertyName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnPropertyName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPropertyName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("PropertyName");
				}
            }
        }
        private string _PropertyName_store;
        private string _PropertyName {
            get { return _PropertyName_store; }
            set {
                ReportEfPropertyChanging("PropertyName");
                _PropertyName_store = value;
                ReportEfPropertyChanged("PropertyName");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_PostSetter;

        /// <summary>
        /// The time when the change was made
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public DateTime? Timestamp
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Timestamp;
                if (!_isTimestampSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("c9461d28-4594-443e-82ec-a2ddc9664742"));
                    if (__p != null) {
                        _isTimestampSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                            if (__tmp_value == null)
                                __result = this._Timestamp = null;
                            else
                            __result = this._Timestamp = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AuditEntry.Timestamp'");
                    }
                }
                if (OnTimestamp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnTimestamp_Getter(this, __e);
                    __result = _Timestamp = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isTimestampSet = true;
                if (_Timestamp != value)
                {
                    var __oldValue = _Timestamp;
                    var __newValue = value;
                    if (__newValue.HasValue && __newValue.Value.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue.Value, DateTimeKind.Local);
                    if (OnTimestamp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTimestamp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Timestamp", __oldValue, __newValue);
                    _Timestamp = __newValue;
                    NotifyPropertyChanged("Timestamp", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnTimestamp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTimestamp_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Timestamp");
				}
            }
        }
        private DateTime? _Timestamp_store;
        private DateTime? _Timestamp {
            get { return _Timestamp_store; }
            set {
                ReportEfPropertyChanging("Timestamp");
                _Timestamp_store = value;
                ReportEfPropertyChanged("Timestamp");
            }
        }
        private bool _isTimestampSet = false;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(AuditEntry);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AuditEntry)obj;
            var otherImpl = (AuditEntryEfImpl)obj;
            var me = (AuditEntry)this;

            me.Identity = other.Identity;
            me.MessageFormat = other.MessageFormat;
            me.NewValue = other.NewValue;
            me.OldValue = other.OldValue;
            me.PropertyName = other.PropertyName;
            me.Timestamp = other.Timestamp;
        }
        #region Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_AuditEntry")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AuditEntry != null)
            {
                OnToString_AuditEntry(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AuditEntry> OnToString_AuditEntry;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_AuditEntry")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_AuditEntry != null)
            {
                OnObjectIsValid_AuditEntry(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<AuditEntry> OnObjectIsValid_AuditEntry;

        #endregion // Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Identity);
            binStream.Write(this._MessageFormat);
            binStream.Write(this._NewValue);
            binStream.Write(this._OldValue);
            binStream.Write(this._PropertyName);
            binStream.Write(this._isTimestampSet);
            if (this._isTimestampSet) {
                binStream.Write(this._Timestamp);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Identity = binStream.ReadString();
            this._MessageFormat = binStream.ReadString();
            this._NewValue = binStream.ReadString();
            this._OldValue = binStream.ReadString();
            this._PropertyName = binStream.ReadString();
            this._isTimestampSet = binStream.ReadBoolean();
            if (this._isTimestampSet) {
                this._Timestamp = binStream.ReadNullableDateTime();
            }
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}