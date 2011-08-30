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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// A test class for persistently ordered 1:N relations
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("OrderedOneEnd")]
    public class OrderedOneEndMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, OrderedOneEnd
    {
        [Obsolete]
        public OrderedOneEndMemoryImpl()
            : base(null)
        {
        }

        public OrderedOneEndMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // Kistl.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Test.OrderedNEnd> NEnds
        {
            get
            {
                if (_NEnds == null)
                {
                    List<Kistl.App.Test.OrderedNEnd> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
                        serverList = Context.GetListOf<Kistl.App.Test.OrderedNEnd>(this, "NEnds");
                    }
                    else
                    {
                        serverList = new List<Kistl.App.Test.OrderedNEnd>();
                    }
    
                    _NEnds = new OneNRelationList<Kistl.App.Test.OrderedNEnd>(
                        "OneEnd",
                        "NEnds_pos",
                        this,
                        () => this.NotifyPropertyChanged("NEnds", null, null),
                        serverList);
                }
                return _NEnds;
            }
        }
    
        private OneNRelationList<Kistl.App.Test.OrderedNEnd> _NEnds;


        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int? SomeInt
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SomeInt;
                if (OnSomeInt_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnSomeInt_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SomeInt != value)
                {
                    var __oldValue = _SomeInt;
                    var __newValue = value;
                    if (OnSomeInt_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SomeInt", __oldValue, __newValue);
                    _SomeInt = __newValue;
                    NotifyPropertyChanged("SomeInt", __oldValue, __newValue);
                    if (OnSomeInt_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _SomeInt;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.OrderedOneEnd, int?> OnSomeInt_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.OrderedOneEnd, int?> OnSomeInt_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.OrderedOneEnd, int?> OnSomeInt_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(OrderedOneEnd);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (OrderedOneEnd)obj;
            var otherImpl = (OrderedOneEndMemoryImpl)obj;
            var me = (OrderedOneEnd)this;

            me.SomeInt = other.SomeInt;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<OrderedOneEndMemoryImpl, IList<Kistl.App.Test.OrderedNEnd>>(
                        lazyCtx,
                        new Guid("7b7a227b-462a-4923-bda6-15264f0af841"),
                        "NEnds",
                        null,
                        obj => obj.NEnds,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorMemoryImpl<OrderedOneEndMemoryImpl, int?>(
                        lazyCtx,
                        new Guid("1062a9d3-b936-42b8-99ba-2353087cbce1"),
                        "SomeInt",
                        null,
                        obj => obj.SomeInt,
                        (obj, val) => obj.SomeInt = val),
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
        [EventBasedMethod("OnToString_OrderedOneEnd")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_OrderedOneEnd != null)
            {
                OnToString_OrderedOneEnd(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<OrderedOneEnd> OnToString_OrderedOneEnd;

        [EventBasedMethod("OnPreSave_OrderedOneEnd")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_OrderedOneEnd != null) OnPreSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnPreSave_OrderedOneEnd;

        [EventBasedMethod("OnPostSave_OrderedOneEnd")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_OrderedOneEnd != null) OnPostSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnPostSave_OrderedOneEnd;

        [EventBasedMethod("OnCreated_OrderedOneEnd")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_OrderedOneEnd != null) OnCreated_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnCreated_OrderedOneEnd;

        [EventBasedMethod("OnDeleting_OrderedOneEnd")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_OrderedOneEnd != null) OnDeleting_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnDeleting_OrderedOneEnd;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._SomeInt, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._SomeInt, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._SomeInt, xml, "SomeInt", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._SomeInt, xml, "SomeInt", "Kistl.App.Test");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}