// <autogenerated/>

namespace Kistl.App.Base
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
    /// Sets an boolean property with an configured default value
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="BoolDefaultValue")]
    [System.Diagnostics.DebuggerDisplay("BoolDefaultValue")]
    public class BoolDefaultValueEfImpl : Kistl.App.Base.DefaultPropertyValueEfImpl, BoolDefaultValue
    {
        [Obsolete]
        public BoolDefaultValueEfImpl()
            : base(null)
        {
        }

        public BoolDefaultValueEfImpl(Func<IFrozenContext> lazyCtx)
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
        public bool BoolValue
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _BoolValue;
                if (OnBoolValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnBoolValue_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_BoolValue != value)
                {
                    var __oldValue = _BoolValue;
                    var __newValue = value;
                    if (OnBoolValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BoolValue", __oldValue, __newValue);
                    _BoolValue = __newValue;
                    NotifyPropertyChanged("BoolValue", __oldValue, __newValue);
                    if (OnBoolValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _BoolValue;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolDefaultValue, bool> OnBoolValue_PostSetter;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_BoolDefaultValue != null)
            {
                OnGetDefaultValue_BoolDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(BoolDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (BoolDefaultValue)obj;
            var otherImpl = (BoolDefaultValueEfImpl)obj;
            var me = (BoolDefaultValue)this;

            me.BoolValue = other.BoolValue;
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
                    new PropertyDescriptorEfImpl<BoolDefaultValueEfImpl, bool>(
                        lazyCtx,
                        new Guid("635818b4-065f-456c-b57e-4a7cdc8b3378"),
                        "BoolValue",
                        null,
                        obj => obj.BoolValue,
                        (obj, val) => obj.BoolValue = val),
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
        [EventBasedMethod("OnToString_BoolDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolDefaultValue != null)
            {
                OnToString_BoolDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<BoolDefaultValue> OnToString_BoolDefaultValue;

        [EventBasedMethod("OnPreSave_BoolDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BoolDefaultValue != null) OnPreSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnPreSave_BoolDefaultValue;

        [EventBasedMethod("OnPostSave_BoolDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BoolDefaultValue != null) OnPostSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnPostSave_BoolDefaultValue;

        [EventBasedMethod("OnCreated_BoolDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_BoolDefaultValue != null) OnCreated_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnCreated_BoolDefaultValue;

        [EventBasedMethod("OnDeleting_BoolDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_BoolDefaultValue != null) OnDeleting_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnDeleting_BoolDefaultValue;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._BoolValue, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._BoolValue, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._BoolValue, xml, "BoolValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._BoolValue, xml, "BoolValue", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._BoolValue, xml, "BoolValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._BoolValue, xml, "BoolValue", "Kistl.App.Base");
        }

        #endregion

    }
}