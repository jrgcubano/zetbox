// <autogenerated/>

namespace Kistl.App.Test
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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestObjClass")]
    [System.Diagnostics.DebuggerDisplay("TestObjClass")]
    public class TestObjClassEfImpl : BaseServerDataObject_EntityFramework, TestObjClass
    {
        [Obsolete]
        public TestObjClassEfImpl()
            : base(null)
        {
        }

        public TestObjClassEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// test
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int? MyIntProperty
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MyIntProperty;
                if (OnMyIntProperty_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnMyIntProperty_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MyIntProperty != value)
                {
                    var __oldValue = _MyIntProperty;
                    var __newValue = value;
                    if (OnMyIntProperty_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MyIntProperty", __oldValue, __newValue);
                    _MyIntProperty = __newValue;
                    NotifyPropertyChanged("MyIntProperty", __oldValue, __newValue);
                    if (OnMyIntProperty_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _MyIntProperty;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PostSetter;

        /// <summary>
        /// testtest
        /// </summary>
    /*
    Relation: FK_TestObjClass_has_ObjectProp
    A: ZeroOrMore TestObjClass as TestObjClass
    B: ZeroOrOne Kunde as ObjectProp
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
        // fkBackingName=_fk_ObjectProp; fkGuidBackingName=_fk_guid_ObjectProp;
        // referencedInterface=Kistl.App.Projekte.Kunde; moduleNamespace=Kistl.App.Test;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get { return ObjectPropImpl; }
            set { ObjectPropImpl = (Kistl.App.Projekte.KundeEfImpl)value; }
        }

        private int? _fk_ObjectProp;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TestObjClass_has_ObjectProp", "ObjectProp")]
        public Kistl.App.Projekte.KundeEfImpl ObjectPropImpl
        {
            get
            {
                Kistl.App.Projekte.KundeEfImpl __value;
                EntityReference<Kistl.App.Projekte.KundeEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.KundeEfImpl>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnObjectProp_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Kunde>(__value);
                    OnObjectProp_Getter(this, e);
                    __value = (Kistl.App.Projekte.KundeEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Projekte.KundeEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.KundeEfImpl>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Projekte.KundeEfImpl __oldValue = (Kistl.App.Projekte.KundeEfImpl)r.Value;
                Kistl.App.Projekte.KundeEfImpl __newValue = (Kistl.App.Projekte.KundeEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("ObjectProp", null, __oldValue, __newValue);

                if (OnObjectProp_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PreSetter(this, e);
                    __newValue = (Kistl.App.Projekte.KundeEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Projekte.KundeEfImpl)__newValue;

                if (OnObjectProp_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("ObjectProp", null, __oldValue, __newValue);
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PostSetter;

        /// <summary>
        /// String Property
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string StringProp
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _StringProp;
                if (OnStringProp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnStringProp_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_StringProp != value)
                {
                    var __oldValue = _StringProp;
                    var __newValue = value;
                    if (OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    _StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);
                    if (OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _StringProp;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PostSetter;

        /// <summary>
        /// Test Enumeration Property
        /// </summary>
        // enumeration property
   		// Kistl.DalProvider.Ef.Generator.Templates.Properties.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Test.TestEnum TestEnumProp
        {
            get
            {
				var __value = _TestEnumProp;
				if(OnTestEnumProp_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestEnum>(__value);
					OnTestEnumProp_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnumProp != value)
                {
					var __oldValue = _TestEnumProp;
					var __newValue = value;
                    if(OnTestEnumProp_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("TestEnumProp", "TestEnumPropImpl", __oldValue, __newValue);
                    _TestEnumProp = value;
                    NotifyPropertyChanged("TestEnumProp", "TestEnumPropImpl", __oldValue, __newValue);
                    if(OnTestEnumProp_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for TestEnumProp</summary>
        private Kistl.App.Test.TestEnum _TestEnumProp;
        
        /// <summary>EF sees only this property, for TestEnumProp</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int TestEnumPropImpl
        {
            get
            {
                return (int)this.TestEnumProp;
            }
            set
            {
                this.TestEnumProp = (Kistl.App.Test.TestEnum)value;
            }
        }
        
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PostSetter;

        /// <summary>
        /// testmethod
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnTestMethod_TestObjClass")]
        public virtual void TestMethod(System.DateTime DateTimeParamForTestMethod)
        {
            // base.TestMethod();
            if (OnTestMethod_TestObjClass != null)
            {
                OnTestMethod_TestObjClass(this, DateTimeParamForTestMethod);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method TestObjClass.TestMethod");
            }
        }
        public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
        public static event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(TestObjClass);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestObjClass)obj;
            var otherImpl = (TestObjClassEfImpl)obj;
            var me = (TestObjClass)this;

            me.MyIntProperty = other.MyIntProperty;
            me.StringProp = other.StringProp;
            me.TestEnumProp = other.TestEnumProp;
            this._fk_ObjectProp = otherImpl._fk_ObjectProp;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "ObjectProp":
                    __oldValue = _fk_ObjectProp;
                    NotifyPropertyChanging("ObjectProp", __oldValue, __newValue);
                    _fk_ObjectProp = __newValue;
                    NotifyPropertyChanged("ObjectProp", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_ObjectProp.HasValue)
                ObjectPropImpl = (Kistl.App.Projekte.KundeEfImpl)Context.Find<Kistl.App.Projekte.Kunde>(_fk_ObjectProp.Value);
            else
                ObjectPropImpl = null;
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
                    new PropertyDescriptorEfImpl<TestObjClassEfImpl, int?>(
                        lazyCtx,
                        new Guid("29c0242b-cd1c-42b4-8ca0-be0a209afcbf"),
                        "MyIntProperty",
                        null,
                        obj => obj.MyIntProperty,
                        (obj, val) => obj.MyIntProperty = val),
                    // else
                    new PropertyDescriptorEfImpl<TestObjClassEfImpl, Kistl.App.Projekte.Kunde>(
                        lazyCtx,
                        new Guid("e93b3fc2-2fc9-4577-9a93-a51ed2a4190f"),
                        "ObjectProp",
                        null,
                        obj => obj.ObjectProp,
                        (obj, val) => obj.ObjectProp = val),
                    // else
                    new PropertyDescriptorEfImpl<TestObjClassEfImpl, string>(
                        lazyCtx,
                        new Guid("c9a3769e-7a53-4e1d-b894-72dc1b4e9aea"),
                        "StringProp",
                        null,
                        obj => obj.StringProp,
                        (obj, val) => obj.StringProp = val),
                    // else
                    new PropertyDescriptorEfImpl<TestObjClassEfImpl, Kistl.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("89470dda-4ac6-4bb4-9221-d16f80f8d95a"),
                        "TestEnumProp",
                        null,
                        obj => obj.TestEnumProp,
                        (obj, val) => obj.TestEnumProp = val),
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
        [EventBasedMethod("OnToString_TestObjClass")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestObjClass != null)
            {
                OnToString_TestObjClass(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestObjClass> OnToString_TestObjClass;

        [EventBasedMethod("OnPreSave_TestObjClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestObjClass != null) OnPreSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnPreSave_TestObjClass;

        [EventBasedMethod("OnPostSave_TestObjClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestObjClass != null) OnPostSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnPostSave_TestObjClass;

        [EventBasedMethod("OnCreated_TestObjClass")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestObjClass != null) OnCreated_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnCreated_TestObjClass;

        [EventBasedMethod("OnDeleting_TestObjClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestObjClass != null) OnDeleting_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnDeleting_TestObjClass;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                }
            }
        }
        private int _ID;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._MyIntProperty, binStream);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Projekte.KundeEfImpl>("Model.FK_TestObjClass_has_ObjectProp", "ObjectProp").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
            BinarySerializer.ToStream(this._StringProp, binStream);
            BinarySerializer.ToStream((int?)((Kistl.App.Test.TestObjClass)this).TestEnumProp, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._MyIntProperty, binStream);
            BinarySerializer.FromStream(out this._fk_ObjectProp, binStream);
            BinarySerializer.FromStream(out this._StringProp, binStream);
            {
                int? baseValue;
                BinarySerializer.FromStream(out baseValue, binStream);
                ((Kistl.App.Test.TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)baseValue;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Projekte.KundeEfImpl>("Model.FK_TestObjClass_has_ObjectProp", "ObjectProp").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "ObjectProp", "Kistl.App.Test");
            }
            XmlStreamer.ToStream(this._StringProp, xml, "StringProp", "Kistl.App.Test");
            XmlStreamer.ToStream((int?)((Kistl.App.Test.TestObjClass)this).TestEnumProp, xml, "TestEnumProp", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_ObjectProp, xml, "ObjectProp", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._StringProp, xml, "StringProp", "Kistl.App.Test");
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Test.TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)v, xml, "TestEnumProp", "Kistl.App.Test");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}