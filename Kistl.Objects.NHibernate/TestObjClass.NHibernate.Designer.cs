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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TestObjClass")]
    public class TestObjClassNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, TestObjClass
    {
        public TestObjClassNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public TestObjClassNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new TestObjClassProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TestObjClassNHibernateImpl(Func<IFrozenContext> lazyCtx, TestObjClassProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly TestObjClassProxy Proxy;

        /// <summary>
        /// test
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? MyIntProperty
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.MyIntProperty;
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
                if (Proxy.MyIntProperty != value)
                {
                    var __oldValue = Proxy.MyIntProperty;
                    var __newValue = value;
                    if (OnMyIntProperty_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MyIntProperty", __oldValue, __newValue);
                    Proxy.MyIntProperty = __newValue;
                    NotifyPropertyChanged("MyIntProperty", __oldValue, __newValue);
                    if (OnMyIntProperty_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.TestObjClass> OnMyIntProperty_IsValid;

        /// <summary>
        /// testtest
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
        // fkBackingName=this.Proxy.ObjectProp; fkGuidBackingName=_fk_guid_ObjectProp;
        // referencedInterface=Kistl.App.Projekte.Kunde; moduleNamespace=Kistl.App.Test;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Projekte.KundeNHibernateImpl __value = (Kistl.App.Projekte.KundeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectProp);

                if (OnObjectProp_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Kunde>(__value);
                    OnObjectProp_Getter(this, e);
                    __value = (Kistl.App.Projekte.KundeNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.ObjectProp == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Projekte.KundeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectProp);
                var __newValue = (Kistl.App.Projekte.KundeNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectProp", __oldValue, __newValue);

                if (OnObjectProp_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PreSetter(this, e);
                    __newValue = (Kistl.App.Projekte.KundeNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.ObjectProp = null;
                }
                else
                {
                    this.Proxy.ObjectProp = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectProp", __oldValue, __newValue);

                if (OnObjectProp_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for ObjectProp's id, used on dehydration only</summary>
        private int? _fk_ObjectProp = null;


        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.TestObjClass> OnObjectProp_IsValid;

        /// <summary>
        /// String Property
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string StringProp
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.StringProp;
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
                if (Proxy.StringProp != value)
                {
                    var __oldValue = Proxy.StringProp;
                    var __newValue = value;
                    if (OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    Proxy.StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);
                    if (OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.TestObjClass> OnStringProp_IsValid;

        /// <summary>
        /// Test Enumeration Property
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Kistl.App.Test.TestEnum TestEnumProp
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Kistl.App.Test.TestEnum);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.TestEnumProp;
                if (OnTestEnumProp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Kistl.App.Test.TestEnum>(__result);
                    OnTestEnumProp_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.TestEnumProp != value)
                {
                    var __oldValue = Proxy.TestEnumProp;
                    var __newValue = value;
                    if (OnTestEnumProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
                        OnTestEnumProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestEnumProp", __oldValue, __newValue);
                    Proxy.TestEnumProp = __newValue;
                    NotifyPropertyChanged("TestEnumProp", __oldValue, __newValue);
                    if (OnTestEnumProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
                        OnTestEnumProp_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.TestObjClass> OnTestEnumProp_IsValid;

        /// <summary>
        /// testmethod
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnTestMethod_TestObjClass")]
        public virtual void TestMethod(DateTime DateTimeParamForTestMethod)
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
        public delegate void TestMethod_Handler<T>(T obj, DateTime DateTimeParamForTestMethod);
        public static event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<TestObjClass> OnTestMethod_TestObjClass_CanExec;

        [EventBasedMethod("OnTestMethod_TestObjClass_CanExec")]
        public virtual bool TestMethodCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnTestMethod_TestObjClass_CanExec != null)
				{
					OnTestMethod_TestObjClass_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<TestObjClass> OnTestMethod_TestObjClass_CanExecReason;

        [EventBasedMethod("OnTestMethod_TestObjClass_CanExecReason")]
        public virtual string TestMethodCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnTestMethod_TestObjClass_CanExecReason != null)
				{
					OnTestMethod_TestObjClass_CanExecReason(this, e);
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
            return typeof(TestObjClass);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestObjClass)obj;
            var otherImpl = (TestObjClassNHibernateImpl)obj;
            var me = (TestObjClass)this;

            me.MyIntProperty = other.MyIntProperty;
            me.StringProp = other.StringProp;
            me.TestEnumProp = other.TestEnumProp;
            this._fk_ObjectProp = otherImpl._fk_ObjectProp;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "ObjectProp":
                    {
                        var __oldValue = (Kistl.App.Projekte.KundeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectProp);
                        var __newValue = (Kistl.App.Projekte.KundeNHibernateImpl)parentObj;
                        NotifyPropertyChanging("ObjectProp", __oldValue, __newValue);
                        this.Proxy.ObjectProp = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("ObjectProp", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
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
                this.Proxy.ObjectProp = ((Kistl.App.Projekte.KundeNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Projekte.Kunde>(_fk_ObjectProp.Value)).Proxy;
            else
                this.Proxy.ObjectProp = null;
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
                    new PropertyDescriptorNHibernateImpl<TestObjClass, int?>(
                        lazyCtx,
                        new Guid("29c0242b-cd1c-42b4-8ca0-be0a209afcbf"),
                        "MyIntProperty",
                        null,
                        obj => obj.MyIntProperty,
                        (obj, val) => obj.MyIntProperty = val,
						obj => OnMyIntProperty_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TestObjClass, Kistl.App.Projekte.Kunde>(
                        lazyCtx,
                        new Guid("e93b3fc2-2fc9-4577-9a93-a51ed2a4190f"),
                        "ObjectProp",
                        null,
                        obj => obj.ObjectProp,
                        (obj, val) => obj.ObjectProp = val,
						obj => OnObjectProp_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TestObjClass, string>(
                        lazyCtx,
                        new Guid("c9a3769e-7a53-4e1d-b894-72dc1b4e9aea"),
                        "StringProp",
                        null,
                        obj => obj.StringProp,
                        (obj, val) => obj.StringProp = val,
						obj => OnStringProp_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<TestObjClass, Kistl.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("89470dda-4ac6-4bb4-9221-d16f80f8d95a"),
                        "TestEnumProp",
                        null,
                        obj => obj.TestEnumProp,
                        (obj, val) => obj.TestEnumProp = val,
						obj => OnTestEnumProp_IsValid), 
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

        [EventBasedMethod("OnNotifyPreSave_TestObjClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_TestObjClass != null) OnNotifyPreSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyPreSave_TestObjClass;

        [EventBasedMethod("OnNotifyPostSave_TestObjClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TestObjClass != null) OnNotifyPostSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyPostSave_TestObjClass;

        [EventBasedMethod("OnNotifyCreated_TestObjClass")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_TestObjClass != null) OnNotifyCreated_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyCreated_TestObjClass;

        [EventBasedMethod("OnNotifyDeleting_TestObjClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TestObjClass != null) OnNotifyDeleting_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyDeleting_TestObjClass;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow TestObjClass_has_ObjectProp
            if (this.ObjectProp != null && this.ObjectProp.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.ObjectProp);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class TestObjClassProxy
            : IProxyObject, ISortKey<int>
        {
            public TestObjClassProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(TestObjClassNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(TestObjClassProxy); } }

            public virtual int? MyIntProperty { get; set; }

            public virtual Kistl.App.Projekte.KundeNHibernateImpl.KundeProxy ObjectProp { get; set; }

            public virtual string StringProp { get; set; }

            public virtual Kistl.App.Test.TestEnum TestEnumProp { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.MyIntProperty, binStream);
            BinarySerializer.ToStream(this.Proxy.ObjectProp != null ? OurContext.GetIdFromProxy(this.Proxy.ObjectProp) : (int?)null, binStream);
            BinarySerializer.ToStream(this.Proxy.StringProp, binStream);
            BinarySerializer.ToStream((int?)Proxy.TestEnumProp, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.MyIntProperty = tmp;
            }
            BinarySerializer.FromStream(out this._fk_ObjectProp, binStream);
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.StringProp = tmp;
            }
            {
                int? baseValue;
                BinarySerializer.FromStream(out baseValue, binStream);
                Proxy.TestEnumProp = (Kistl.App.Test.TestEnum)baseValue;
            }
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
            XmlStreamer.ToStream(this.Proxy.MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.ToStream(this.Proxy.ObjectProp != null ? OurContext.GetIdFromProxy(this.Proxy.ObjectProp) : (int?)null, xml, "ObjectProp", "Kistl.App.Test");
            XmlStreamer.ToStream(this.Proxy.StringProp, xml, "StringProp", "Kistl.App.Test");
            XmlStreamer.ToStream((int?)Proxy.TestEnumProp, xml, "TestEnumProp", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                int? tmp = this.Proxy.MyIntProperty;
                XmlStreamer.FromStream(ref tmp, xml, "MyIntProperty", "Kistl.App.Test");
                this.Proxy.MyIntProperty = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_ObjectProp, xml, "ObjectProp", "Kistl.App.Test");
            {
                // yuck
                string tmp = this.Proxy.StringProp;
                XmlStreamer.FromStream(ref tmp, xml, "StringProp", "Kistl.App.Test");
                this.Proxy.StringProp = tmp;
            }
            XmlStreamer.FromStreamConverter(v => Proxy.TestEnumProp = (Kistl.App.Test.TestEnum)v, xml, "TestEnumProp", "Kistl.App.Test");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}