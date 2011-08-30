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
    /// Testclass for Decimal DataType
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestDecimal")]
    [System.Diagnostics.DebuggerDisplay("TestDecimal")]
    public class TestDecimalEfImpl : BaseServerDataObject_EntityFramework, TestDecimal
    {
        [Obsolete]
        public TestDecimalEfImpl()
            : base(null)
        {
        }

        public TestDecimalEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public decimal? Large
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Large;
                if (OnLarge_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnLarge_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Large != value)
                {
                    var __oldValue = _Large;
                    var __newValue = value;
                    if (OnLarge_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Large", __oldValue, __newValue);
                    _Large = __newValue;
                    NotifyPropertyChanged("Large", __oldValue, __newValue);
                    if (OnLarge_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PostSetter(this, __e);
                    }
                }
            }
        }
        private decimal? _Large;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public decimal? NoScale
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NoScale;
                if (OnNoScale_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnNoScale_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_NoScale != value)
                {
                    var __oldValue = _NoScale;
                    var __newValue = value;
                    if (OnNoScale_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NoScale", __oldValue, __newValue);
                    _NoScale = __newValue;
                    NotifyPropertyChanged("NoScale", __oldValue, __newValue);
                    if (OnNoScale_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PostSetter(this, __e);
                    }
                }
            }
        }
        private decimal? _NoScale;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public decimal? SmallDecimal
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SmallDecimal;
                if (OnSmallDecimal_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnSmallDecimal_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SmallDecimal != value)
                {
                    var __oldValue = _SmallDecimal;
                    var __newValue = value;
                    if (OnSmallDecimal_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SmallDecimal", __oldValue, __newValue);
                    _SmallDecimal = __newValue;
                    NotifyPropertyChanged("SmallDecimal", __oldValue, __newValue);
                    if (OnSmallDecimal_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PostSetter(this, __e);
                    }
                }
            }
        }
        private decimal? _SmallDecimal;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(TestDecimal);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestDecimal)obj;
            var otherImpl = (TestDecimalEfImpl)obj;
            var me = (TestDecimal)this;

            me.Large = other.Large;
            me.NoScale = other.NoScale;
            me.SmallDecimal = other.SmallDecimal;
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
                    new PropertyDescriptorEfImpl<TestDecimalEfImpl, decimal?>(
                        lazyCtx,
                        new Guid("14a1eeb9-26b1-4913-bae1-228edfd1c9de"),
                        "Large",
                        null,
                        obj => obj.Large,
                        (obj, val) => obj.Large = val),
                    // else
                    new PropertyDescriptorEfImpl<TestDecimalEfImpl, decimal?>(
                        lazyCtx,
                        new Guid("dbad0130-bfb8-4475-afb8-e26f1124395b"),
                        "NoScale",
                        null,
                        obj => obj.NoScale,
                        (obj, val) => obj.NoScale = val),
                    // else
                    new PropertyDescriptorEfImpl<TestDecimalEfImpl, decimal?>(
                        lazyCtx,
                        new Guid("734795e4-4e0f-4175-b153-e465acafd609"),
                        "SmallDecimal",
                        null,
                        obj => obj.SmallDecimal,
                        (obj, val) => obj.SmallDecimal = val),
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
        [EventBasedMethod("OnToString_TestDecimal")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestDecimal != null)
            {
                OnToString_TestDecimal(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestDecimal> OnToString_TestDecimal;

        [EventBasedMethod("OnPreSave_TestDecimal")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestDecimal != null) OnPreSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnPreSave_TestDecimal;

        [EventBasedMethod("OnPostSave_TestDecimal")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestDecimal != null) OnPostSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnPostSave_TestDecimal;

        [EventBasedMethod("OnCreated_TestDecimal")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestDecimal != null) OnCreated_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnCreated_TestDecimal;

        [EventBasedMethod("OnDeleting_TestDecimal")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestDecimal != null) OnDeleting_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnDeleting_TestDecimal;

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
            BinarySerializer.ToStream(this._Large, binStream);
            BinarySerializer.ToStream(this._NoScale, binStream);
            BinarySerializer.ToStream(this._SmallDecimal, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._Large, binStream);
            BinarySerializer.FromStream(out this._NoScale, binStream);
            BinarySerializer.FromStream(out this._SmallDecimal, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Large, xml, "Large", "Kistl.App.Test");
            XmlStreamer.ToStream(this._NoScale, xml, "NoScale", "Kistl.App.Test");
            XmlStreamer.ToStream(this._SmallDecimal, xml, "SmallDecimal", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._Large, xml, "Large", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._NoScale, xml, "NoScale", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._SmallDecimal, xml, "SmallDecimal", "Kistl.App.Test");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}