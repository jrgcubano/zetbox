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
    [System.Diagnostics.DebuggerDisplay("Muhblah")]
    public class MuhblahMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, Muhblah
    {
        private static readonly Guid _objectClassID = new Guid("fd357e42-2c2c-4bef-8110-69a466d09af0");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public MuhblahMemoryImpl()
            : base(null)
        {
        }

        public MuhblahMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public bool? TestBool
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestBool;
                if (OnTestBool_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnTestBool_Getter(this, __e);
                    __result = _TestBool = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestBool != value)
                {
                    var __oldValue = _TestBool;
                    var __newValue = value;
                    if (OnTestBool_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnTestBool_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestBool", __oldValue, __newValue);
                    _TestBool = __newValue;
                    NotifyPropertyChanged("TestBool", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnTestBool_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnTestBool_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("TestBool");
				}
            }
        }
        private bool? _TestBool;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, bool?> OnTestBool_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, bool?> OnTestBool_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, bool?> OnTestBool_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestBool_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // Zetbox.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.Test.TestCustomObject> TestCustomObjects_List_Nav
        {
            get
            {
                if (_TestCustomObjects_List_Nav == null)
                {
                    List<Zetbox.App.Test.TestCustomObject> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
                        serverList = Context.GetListOf<Zetbox.App.Test.TestCustomObject>(this, "TestCustomObjects_List_Nav");
                    }
                    else
                    {
                        serverList = new List<Zetbox.App.Test.TestCustomObject>();
                    }
    
                    _TestCustomObjects_List_Nav = new OneNRelationList<Zetbox.App.Test.TestCustomObject>(
                        "MubBlah_Nav",
                        null,
                        this,
                        () => { this.NotifyPropertyChanged("TestCustomObjects_List_Nav", null, null); if(OnTestCustomObjects_List_Nav_PostSetter != null && IsAttached) OnTestCustomObjects_List_Nav_PostSetter(this); },
                        serverList);
                }
                return _TestCustomObjects_List_Nav;
            }
        }
    
        private OneNRelationList<Zetbox.App.Test.TestCustomObject> _TestCustomObjects_List_Nav;

public static event PropertyListChangedHandler<Zetbox.App.Test.Muhblah> OnTestCustomObjects_List_Nav_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestCustomObjects_List_Nav_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Zetbox.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Zetbox.App.Test.TestCustomObject> TestCustomObjects_ManyList_Nav
		{
			get
			{
				if (_TestCustomObjects_ManyList_Nav == null)
				{
					Context.FetchRelation<Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl>(new Guid("d1e0da3e-ce64-4587-b62d-70c0f4371d97"), RelationEndRole.A, this);
					_TestCustomObjects_ManyList_Nav 
						= new ObservableBSideCollectionWrapper<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject, Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl, ICollection<Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl>>(
							this, 
							new RelationshipFilterASideCollection<Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl>(this.Context, this));
				}
				return (ICollection<Zetbox.App.Test.TestCustomObject>)_TestCustomObjects_ManyList_Nav;
			}
		}

		private ObservableBSideCollectionWrapper<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject, Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl, ICollection<Zetbox.App.Test.Muhblah_has_TestCustomObject_RelationEntryMemoryImpl>> _TestCustomObjects_ManyList_Nav;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestCustomObjects_ManyList_Nav_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TestCustomObjects_Nav
        // fkBackingName=_fk_TestCustomObjects_Nav; fkGuidBackingName=_fk_guid_TestCustomObjects_Nav;
        // referencedInterface=Zetbox.App.Test.TestCustomObject; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=MubBlah_List_Nav; is list;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Test.TestCustomObject TestCustomObjects_Nav
        {
            get { return TestCustomObjects_NavImpl; }
            set { TestCustomObjects_NavImpl = (Zetbox.App.Test.TestCustomObjectMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_TestCustomObjects_Nav;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Test.TestCustomObjectMemoryImpl TestCustomObjects_NavImpl
        {
            get
            {
                Zetbox.App.Test.TestCustomObjectMemoryImpl __value;
                if (_fk_TestCustomObjects_Nav.HasValue)
                    __value = (Zetbox.App.Test.TestCustomObjectMemoryImpl)Context.Find<Zetbox.App.Test.TestCustomObject>(_fk_TestCustomObjects_Nav.Value);
                else
                    __value = null;

                if (OnTestCustomObjects_Nav_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.TestCustomObject>(__value);
                    OnTestCustomObjects_Nav_Getter(this, e);
                    __value = (Zetbox.App.Test.TestCustomObjectMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_TestCustomObjects_Nav == null) || (value != null && value.ID == _fk_TestCustomObjects_Nav))
				{
					SetInitializedProperty("TestCustomObjects_Nav");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = TestCustomObjects_NavImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("TestCustomObjects_Nav", __oldValue, __newValue);

                if (OnTestCustomObjects_Nav_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestCustomObject>(__oldValue, __newValue);
                    OnTestCustomObjects_Nav_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.TestCustomObjectMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_TestCustomObjects_Nav = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.MubBlah_List_Nav as IRelationListSync<Zetbox.App.Test.Muhblah>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.MubBlah_List_Nav as IRelationListSync<Zetbox.App.Test.Muhblah>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("TestCustomObjects_Nav", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnTestCustomObjects_Nav_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestCustomObject>(__oldValue, __newValue);
                    OnTestCustomObjects_Nav_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TestCustomObjects_Nav
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_Nav_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_Nav_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_Nav_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestCustomObjects_Nav_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TestCustomObjects_One_Nav
        // fkBackingName=_fk_TestCustomObjects_One_Nav; fkGuidBackingName=_fk_guid_TestCustomObjects_One_Nav;
        // referencedInterface=Zetbox.App.Test.TestCustomObject; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=MuhBlah_One_Nav; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Test.TestCustomObject TestCustomObjects_One_Nav
        {
            get { return TestCustomObjects_One_NavImpl; }
            set { TestCustomObjects_One_NavImpl = (Zetbox.App.Test.TestCustomObjectMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_TestCustomObjects_One_Nav;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Test.TestCustomObjectMemoryImpl TestCustomObjects_One_NavImpl
        {
            get
            {
                Zetbox.App.Test.TestCustomObjectMemoryImpl __value;
                if (_fk_TestCustomObjects_One_Nav.HasValue)
                    __value = (Zetbox.App.Test.TestCustomObjectMemoryImpl)Context.Find<Zetbox.App.Test.TestCustomObject>(_fk_TestCustomObjects_One_Nav.Value);
                else
                    __value = null;

                if (OnTestCustomObjects_One_Nav_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.TestCustomObject>(__value);
                    OnTestCustomObjects_One_Nav_Getter(this, e);
                    __value = (Zetbox.App.Test.TestCustomObjectMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_TestCustomObjects_One_Nav == null) || (value != null && value.ID == _fk_TestCustomObjects_One_Nav))
				{
					SetInitializedProperty("TestCustomObjects_One_Nav");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = TestCustomObjects_One_NavImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("TestCustomObjects_One_Nav", __oldValue, __newValue);

                if (OnTestCustomObjects_One_Nav_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestCustomObject>(__oldValue, __newValue);
                    OnTestCustomObjects_One_Nav_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.TestCustomObjectMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_TestCustomObjects_One_Nav = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.MuhBlah_One_Nav = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.MuhBlah_One_Nav = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("TestCustomObjects_One_Nav", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnTestCustomObjects_One_Nav_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestCustomObject>(__oldValue, __newValue);
                    OnTestCustomObjects_One_Nav_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TestCustomObjects_One_Nav
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestCustomObjects_One_Nav_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime? TestDateTime
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestDateTime;
                if (OnTestDateTime_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnTestDateTime_Getter(this, __e);
                    __result = _TestDateTime = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestDateTime != value)
                {
                    var __oldValue = _TestDateTime;
                    var __newValue = value;
                    if (__newValue.HasValue && __newValue.Value.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue.Value, DateTimeKind.Local);
                    if (OnTestDateTime_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTestDateTime_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestDateTime", __oldValue, __newValue);
                    _TestDateTime = __newValue;
                    NotifyPropertyChanged("TestDateTime", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnTestDateTime_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTestDateTime_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("TestDateTime");
				}
            }
        }
        private DateTime? _TestDateTime;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, DateTime?> OnTestDateTime_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, DateTime?> OnTestDateTime_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, DateTime?> OnTestDateTime_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestDateTime_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Zetbox.App.Test.TestEnum TestEnum
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestEnum;
                if (OnTestEnum_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum>(__result);
                    OnTestEnum_Getter(this, __e);
                    __result = _TestEnum = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnum != value)
                {
                    var __oldValue = _TestEnum;
                    var __newValue = value;
                    if (OnTestEnum_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnTestEnum_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestEnum", __oldValue, __newValue);
                    _TestEnum = __newValue;
                    NotifyPropertyChanged("TestEnum", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnTestEnum_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnTestEnum_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("TestEnum");
				}
            }
        }
        private Zetbox.App.Test.TestEnum _TestEnum;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestEnum> OnTestEnum_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestEnum> OnTestEnum_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, Zetbox.App.Test.TestEnum> OnTestEnum_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestEnum_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string TestString
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestString;
                if (OnTestString_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTestString_Getter(this, __e);
                    __result = _TestString = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestString != value)
                {
                    var __oldValue = _TestString;
                    var __newValue = value;
                    if (OnTestString_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestString", __oldValue, __newValue);
                    _TestString = __newValue;
                    NotifyPropertyChanged("TestString", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnTestString_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("TestString");
				}
            }
        }
        private string _TestString;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.Muhblah, string> OnTestString_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.Muhblah, string> OnTestString_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.Muhblah, string> OnTestString_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.Muhblah> OnTestString_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Muhblah);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Muhblah)obj;
            var otherImpl = (MuhblahMemoryImpl)obj;
            var me = (Muhblah)this;

            me.TestBool = other.TestBool;
            me.TestDateTime = other.TestDateTime;
            me.TestEnum = other.TestEnum;
            me.TestString = other.TestString;
            this._fk_TestCustomObjects_Nav = otherImpl._fk_TestCustomObjects_Nav;
            this._fk_TestCustomObjects_One_Nav = otherImpl._fk_TestCustomObjects_One_Nav;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "TestCustomObjects_Nav":
                    {
                        var __oldValue = _fk_TestCustomObjects_Nav;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("TestCustomObjects_Nav", __oldValue, __newValue);
                        _fk_TestCustomObjects_Nav = __newValue;
                        NotifyPropertyChanged("TestCustomObjects_Nav", __oldValue, __newValue);
                    }
                    break;
                case "TestCustomObjects_One_Nav":
                    {
                        var __oldValue = _fk_TestCustomObjects_One_Nav;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("TestCustomObjects_One_Nav", __oldValue, __newValue);
                        _fk_TestCustomObjects_One_Nav = __newValue;
                        NotifyPropertyChanged("TestCustomObjects_One_Nav", __oldValue, __newValue);
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
                case "TestBool":
                case "TestCustomObjects_Nav":
                case "TestCustomObjects_One_Nav":
                case "TestDateTime":
                case "TestEnum":
                case "TestString":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "TestCustomObjects_List_Nav":
                case "TestCustomObjects_ManyList_Nav":
                    return false;
                default:
                    return base.ShouldSetModified(property);
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

            if (_fk_TestCustomObjects_Nav.HasValue)
                TestCustomObjects_NavImpl = (Zetbox.App.Test.TestCustomObjectMemoryImpl)Context.Find<Zetbox.App.Test.TestCustomObject>(_fk_TestCustomObjects_Nav.Value);
            else
                TestCustomObjects_NavImpl = null;

            if (_fk_TestCustomObjects_One_Nav.HasValue)
                TestCustomObjects_One_NavImpl = (Zetbox.App.Test.TestCustomObjectMemoryImpl)Context.Find<Zetbox.App.Test.TestCustomObject>(_fk_TestCustomObjects_One_Nav.Value);
            else
                TestCustomObjects_One_NavImpl = null;
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
                    new PropertyDescriptorMemoryImpl<Muhblah, bool?>(
                        lazyCtx,
                        new Guid("9206e71e-85ea-4d74-85ea-59ee2484ed2a"),
                        "TestBool",
                        null,
                        obj => obj.TestBool,
                        (obj, val) => obj.TestBool = val,
						obj => OnTestBool_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<Muhblah, ICollection<Zetbox.App.Test.TestCustomObject>>(
                        lazyCtx,
                        new Guid("1f944324-673f-4f14-94c8-dc570ea3022d"),
                        "TestCustomObjects_List_Nav",
                        null,
                        obj => obj.TestCustomObjects_List_Nav,
                        null, // lists are read-only properties
                        obj => OnTestCustomObjects_List_Nav_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<Muhblah, ICollection<Zetbox.App.Test.TestCustomObject>>(
                        lazyCtx,
                        new Guid("a3ad7340-4dc1-488c-bc9a-29ac931b1f0d"),
                        "TestCustomObjects_ManyList_Nav",
                        null,
                        obj => obj.TestCustomObjects_ManyList_Nav,
                        null, // lists are read-only properties
                        obj => OnTestCustomObjects_ManyList_Nav_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Muhblah, Zetbox.App.Test.TestCustomObject>(
                        lazyCtx,
                        new Guid("aabd7cb7-c45e-43c9-97fd-76e50c310ab3"),
                        "TestCustomObjects_Nav",
                        null,
                        obj => obj.TestCustomObjects_Nav,
                        (obj, val) => obj.TestCustomObjects_Nav = val,
						obj => OnTestCustomObjects_Nav_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Muhblah, Zetbox.App.Test.TestCustomObject>(
                        lazyCtx,
                        new Guid("42c6bc2f-0428-488a-b928-539c4c6e3e65"),
                        "TestCustomObjects_One_Nav",
                        null,
                        obj => obj.TestCustomObjects_One_Nav,
                        (obj, val) => obj.TestCustomObjects_One_Nav = val,
						obj => OnTestCustomObjects_One_Nav_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Muhblah, DateTime?>(
                        lazyCtx,
                        new Guid("c5a66e0b-1fdb-45e4-b9e4-2ae4ee35a201"),
                        "TestDateTime",
                        null,
                        obj => obj.TestDateTime,
                        (obj, val) => obj.TestDateTime = val,
						obj => OnTestDateTime_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Muhblah, Zetbox.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("1a5484e4-4be0-4641-9c25-1aa30d1c0e7a"),
                        "TestEnum",
                        null,
                        obj => obj.TestEnum,
                        (obj, val) => obj.TestEnum = val,
						obj => OnTestEnum_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Muhblah, string>(
                        lazyCtx,
                        new Guid("e9516350-fa66-426b-808a-bd8a5f432427"),
                        "TestString",
                        null,
                        obj => obj.TestString,
                        (obj, val) => obj.TestString = val,
						obj => OnTestString_IsValid), 
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
        [EventBasedMethod("OnToString_Muhblah")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Muhblah != null)
            {
                OnToString_Muhblah(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Muhblah> OnToString_Muhblah;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Muhblah")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Muhblah != null)
            {
                OnObjectIsValid_Muhblah(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Muhblah> OnObjectIsValid_Muhblah;

        [EventBasedMethod("OnNotifyPreSave_Muhblah")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Muhblah != null) OnNotifyPreSave_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnNotifyPreSave_Muhblah;

        [EventBasedMethod("OnNotifyPostSave_Muhblah")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Muhblah != null) OnNotifyPostSave_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnNotifyPostSave_Muhblah;

        [EventBasedMethod("OnNotifyCreated_Muhblah")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("TestBool");
            SetNotInitializedProperty("TestCustomObjects_Nav");
            SetNotInitializedProperty("TestCustomObjects_One_Nav");
            SetNotInitializedProperty("TestDateTime");
            SetNotInitializedProperty("TestEnum");
            SetNotInitializedProperty("TestString");
            base.NotifyCreated();
            if (OnNotifyCreated_Muhblah != null) OnNotifyCreated_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnNotifyCreated_Muhblah;

        [EventBasedMethod("OnNotifyDeleting_Muhblah")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Muhblah != null) OnNotifyDeleting_Muhblah(this);
            TestCustomObjects_List_Nav.Clear();
            TestCustomObjects_ManyList_Nav.Clear();
            TestCustomObjects_Nav = null;
            TestCustomObjects_One_Nav = null;
        }
        public static event ObjectEventHandler<Muhblah> OnNotifyDeleting_Muhblah;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._TestBool);
            binStream.Write(TestCustomObjects_Nav != null ? TestCustomObjects_Nav.ID : (int?)null);
            binStream.Write(TestCustomObjects_One_Nav != null ? TestCustomObjects_One_Nav.ID : (int?)null);
            binStream.Write(this._TestDateTime);
            binStream.Write((int?)((Zetbox.App.Test.Muhblah)this).TestEnum);
            binStream.Write(this._TestString);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._TestBool = binStream.ReadNullableBoolean();
            this._fk_TestCustomObjects_Nav = binStream.ReadNullableInt32();
            this._fk_TestCustomObjects_One_Nav = binStream.ReadNullableInt32();
            this._TestDateTime = binStream.ReadNullableDateTime();
            ((Zetbox.App.Test.Muhblah)this).TestEnum = (Zetbox.App.Test.TestEnum)binStream.ReadNullableInt32();
            this._TestString = binStream.ReadString();
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