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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("PropertyIntTest")]
    public class PropertyIntTestNHibernateImpl : Zetbox.App.Test.PropertyTestBaseNHibernateImpl, PropertyIntTest
    {
        private static readonly Guid _objectClassID = new Guid("d32de06d-b6d6-4adf-974a-aca5f3fc4e2c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public PropertyIntTestNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public PropertyIntTestNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new PropertyIntTestProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public PropertyIntTestNHibernateImpl(Func<IFrozenContext> lazyCtx, PropertyIntTestProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
            _isStandardWithDefaultSet = Proxy.ID > 0;
            _isNullableWithDefaultSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly PropertyIntTestProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? Nullable
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Nullable;
                if (OnNullable_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnNullable_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Nullable != value)
                {
                    var __oldValue = Proxy.Nullable;
                    var __newValue = value;
                    if (OnNullable_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnNullable_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Nullable", __oldValue, __newValue);
                    Proxy.Nullable = __newValue;
                    NotifyPropertyChanged("Nullable", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullable_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnNullable_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Nullable");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullable_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullable_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullable_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyIntTest> OnNullable_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? NullableWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchNullableWithDefaultOrDefault();
                if (OnNullableWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnNullableWithDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isNullableWithDefaultSet = true;
                if (Proxy.NullableWithDefault != value)
                {
                    var __oldValue = Proxy.NullableWithDefault;
                    var __newValue = value;
                    if (OnNullableWithDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnNullableWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NullableWithDefault", __oldValue, __newValue);
                    Proxy.NullableWithDefault = __newValue;
                    NotifyPropertyChanged("NullableWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullableWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnNullableWithDefault_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("NullableWithDefault");
				}
            }
        }


        private int? FetchNullableWithDefaultOrDefault()
        {
            var __result = Proxy.NullableWithDefault;
                if (!_isNullableWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("6286a77c-f934-4059-b506-576c026f1e41"));
                    if (__p != null) {
                        _isNullableWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                            if (__tmp_value == null)
                                __result = this.Proxy.NullableWithDefault = null;
                            else
                            __result = this.Proxy.NullableWithDefault = (int)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.PropertyIntTest.NullableWithDefault'");
                    }
                }
            return __result;
        }

        private bool _isNullableWithDefaultSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullableWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullableWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyIntTest, int?> OnNullableWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyIntTest> OnNullableWithDefault_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Standard
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Standard;
                if (OnStandard_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnStandard_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Standard != value)
                {
                    var __oldValue = Proxy.Standard;
                    var __newValue = value;
                    if (OnStandard_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnStandard_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Standard", __oldValue, __newValue);
                    Proxy.Standard = __newValue;
                    NotifyPropertyChanged("Standard", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandard_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnStandard_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Standard");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandard_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandard_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandard_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyIntTest> OnStandard_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int StandardWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchStandardWithDefaultOrDefault();
                if (OnStandardWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnStandardWithDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isStandardWithDefaultSet = true;
                if (Proxy.StandardWithDefault != value)
                {
                    var __oldValue = Proxy.StandardWithDefault;
                    var __newValue = value;
                    if (OnStandardWithDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnStandardWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StandardWithDefault", __oldValue, __newValue);
                    Proxy.StandardWithDefault = __newValue;
                    NotifyPropertyChanged("StandardWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandardWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnStandardWithDefault_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("StandardWithDefault");
				}
            }
        }


        private int FetchStandardWithDefaultOrDefault()
        {
            var __result = Proxy.StandardWithDefault;
                if (!_isStandardWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("e27dc7f9-c45f-46a1-87ef-6afdc78c2b4d"));
                    if (__p != null) {
                        _isStandardWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.StandardWithDefault = (int)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.PropertyIntTest.StandardWithDefault'");
                    }
                }
            return __result;
        }

        private bool _isStandardWithDefaultSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandardWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandardWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyIntTest, int> OnStandardWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyIntTest> OnStandardWithDefault_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(PropertyIntTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (PropertyIntTest)obj;
            var otherImpl = (PropertyIntTestNHibernateImpl)obj;
            var me = (PropertyIntTest)this;

            me.Nullable = other.Nullable;
            me.NullableWithDefault = other.NullableWithDefault;
            me.Standard = other.Standard;
            me.StandardWithDefault = other.StandardWithDefault;
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
                case "Nullable":
                case "NullableWithDefault":
                case "Standard":
                case "StandardWithDefault":
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
                    new PropertyDescriptorNHibernateImpl<PropertyIntTest, int?>(
                        lazyCtx,
                        new Guid("5e697eb6-d998-4833-8193-7838e28945cd"),
                        "Nullable",
                        null,
                        obj => obj.Nullable,
                        (obj, val) => obj.Nullable = val,
						obj => OnNullable_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<PropertyIntTest, int?>(
                        lazyCtx,
                        new Guid("6286a77c-f934-4059-b506-576c026f1e41"),
                        "NullableWithDefault",
                        null,
                        obj => obj.NullableWithDefault,
                        (obj, val) => obj.NullableWithDefault = val,
						obj => OnNullableWithDefault_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<PropertyIntTest, int>(
                        lazyCtx,
                        new Guid("3fbf17a8-98c3-45d3-9da6-a398d34e8b3f"),
                        "Standard",
                        null,
                        obj => obj.Standard,
                        (obj, val) => obj.Standard = val,
						obj => OnStandard_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<PropertyIntTest, int>(
                        lazyCtx,
                        new Guid("e27dc7f9-c45f-46a1-87ef-6afdc78c2b4d"),
                        "StandardWithDefault",
                        null,
                        obj => obj.StandardWithDefault,
                        (obj, val) => obj.StandardWithDefault = val,
						obj => OnStandardWithDefault_IsValid), 
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
        [EventBasedMethod("OnToString_PropertyIntTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PropertyIntTest != null)
            {
                OnToString_PropertyIntTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<PropertyIntTest> OnToString_PropertyIntTest;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_PropertyIntTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_PropertyIntTest != null)
            {
                OnObjectIsValid_PropertyIntTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<PropertyIntTest> OnObjectIsValid_PropertyIntTest;

        [EventBasedMethod("OnNotifyPreSave_PropertyIntTest")]
        public override void NotifyPreSave()
        {
            FetchNullableWithDefaultOrDefault();
            FetchStandardWithDefaultOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_PropertyIntTest != null) OnNotifyPreSave_PropertyIntTest(this);
        }
        public static event ObjectEventHandler<PropertyIntTest> OnNotifyPreSave_PropertyIntTest;

        [EventBasedMethod("OnNotifyPostSave_PropertyIntTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_PropertyIntTest != null) OnNotifyPostSave_PropertyIntTest(this);
        }
        public static event ObjectEventHandler<PropertyIntTest> OnNotifyPostSave_PropertyIntTest;

        [EventBasedMethod("OnNotifyCreated_PropertyIntTest")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Nullable");
            SetNotInitializedProperty("Standard");
            base.NotifyCreated();
            if (OnNotifyCreated_PropertyIntTest != null) OnNotifyCreated_PropertyIntTest(this);
        }
        public static event ObjectEventHandler<PropertyIntTest> OnNotifyCreated_PropertyIntTest;

        [EventBasedMethod("OnNotifyDeleting_PropertyIntTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_PropertyIntTest != null) OnNotifyDeleting_PropertyIntTest(this);


        }
        public static event ObjectEventHandler<PropertyIntTest> OnNotifyDeleting_PropertyIntTest;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class PropertyIntTestProxy
            : Zetbox.App.Test.PropertyTestBaseNHibernateImpl.PropertyTestBaseProxy
        {
            public PropertyIntTestProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(PropertyIntTestNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(PropertyIntTestProxy); } }

            public virtual int? Nullable { get; set; }

            public virtual int? NullableWithDefault { get; set; }

            public virtual int Standard { get; set; }

            public virtual int StandardWithDefault { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Nullable);
            binStream.Write(this._isNullableWithDefaultSet);
            if (this._isNullableWithDefaultSet) {
                binStream.Write(this.Proxy.NullableWithDefault);
            }
            binStream.Write(this.Proxy.Standard);
            binStream.Write(this._isStandardWithDefaultSet);
            if (this._isStandardWithDefaultSet) {
                binStream.Write(this.Proxy.StandardWithDefault);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Nullable = binStream.ReadNullableInt32();
            this._isNullableWithDefaultSet = binStream.ReadBoolean();
            if (this._isNullableWithDefaultSet) {
                this.Proxy.NullableWithDefault = binStream.ReadNullableInt32();
            }
            this.Proxy.Standard = binStream.ReadInt32();
            this._isStandardWithDefaultSet = binStream.ReadBoolean();
            if (this._isStandardWithDefaultSet) {
                this.Proxy.StandardWithDefault = binStream.ReadInt32();
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