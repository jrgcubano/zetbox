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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Sets an enumeration property with an configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumDefaultValue")]
    public class EnumDefaultValueNHibernateImpl : Kistl.App.Base.DefaultPropertyValueNHibernateImpl, EnumDefaultValue
    {
        public EnumDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EnumDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EnumDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EnumDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, EnumDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly EnumDefaultValueProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
        // fkBackingName=this.Proxy.EnumValue; fkGuidBackingName=_fk_guid_EnumValue;
        // referencedInterface=Kistl.App.Base.EnumerationEntry; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.EnumerationEntry EnumValue
        {
            get
            {
                Kistl.App.Base.EnumerationEntryNHibernateImpl __value = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);

                if (OnEnumValue_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.EnumerationEntry>(__value);
                    OnEnumValue_Getter(this, e);
                    __value = (Kistl.App.Base.EnumerationEntryNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.EnumValue == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                var __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("EnumValue", __oldValue, __newValue);

                if (OnEnumValue_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.EnumValue = null;
                }
                else
                {
                    this.Proxy.EnumValue = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("EnumValue", __oldValue, __newValue);

                if (OnEnumValue_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for EnumValue's id, used on dehydration only</summary>
        private int? _fk_EnumValue = null;

        /// <summary>Backing store for EnumValue's guid, used on import only</summary>
        private Guid? _fk_guid_EnumValue = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
		public static event PropertyGetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_PostSetter;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_EnumDefaultValue != null)
            {
                OnGetDefaultValue_EnumDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(EnumDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumDefaultValue)obj;
            var otherImpl = (EnumDefaultValueNHibernateImpl)obj;
            var me = (EnumDefaultValue)this;

            this._fk_EnumValue = otherImpl._fk_EnumValue;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, int? id)
        {
            switch(propertyName)
            {
                case "EnumValue":
                    {
                        var __oldValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                        var __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)(id == null ? null : OurContext.Find<Kistl.App.Base.EnumerationEntry>(id.Value));
                        NotifyPropertyChanging("EnumValue", __oldValue, __newValue);
                        this.Proxy.EnumValue = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("EnumValue", __oldValue, __newValue);
                    }
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

            if (_fk_guid_EnumValue.HasValue)
                this.Proxy.EnumValue = ((Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.EnumerationEntry>(_fk_guid_EnumValue.Value)).Proxy;
            else
            if (_fk_EnumValue.HasValue)
                this.Proxy.EnumValue = ((Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.EnumerationEntry>(_fk_EnumValue.Value)).Proxy;
            else
                this.Proxy.EnumValue = null;
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
                    new PropertyDescriptorNHibernateImpl<EnumDefaultValueNHibernateImpl, Kistl.App.Base.EnumerationEntry>(
                        lazyCtx,
                        new Guid("d072423b-f723-4342-8111-79fb563c8ab4"),
                        "EnumValue",
                        null,
                        obj => obj.EnumValue,
                        (obj, val) => obj.EnumValue = val),
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
        [EventBasedMethod("OnToString_EnumDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumDefaultValue != null)
            {
                OnToString_EnumDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumDefaultValue> OnToString_EnumDefaultValue;

        [EventBasedMethod("OnPreSave_EnumDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumDefaultValue != null) OnPreSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnPreSave_EnumDefaultValue;

        [EventBasedMethod("OnPostSave_EnumDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumDefaultValue != null) OnPostSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnPostSave_EnumDefaultValue;

        [EventBasedMethod("OnCreated_EnumDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_EnumDefaultValue != null) OnCreated_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnCreated_EnumDefaultValue;

        [EventBasedMethod("OnDeleting_EnumDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_EnumDefaultValue != null) OnDeleting_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnDeleting_EnumDefaultValue;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();


            if (this.EnumValue != null && this.EnumValue.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.EnumValue);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();


            return result;
        }


        public class EnumDefaultValueProxy
            : Kistl.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public EnumDefaultValueProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(EnumDefaultValueNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(EnumDefaultValueProxy); } }

            public virtual Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy EnumValue { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.EnumValue != null ? this.Proxy.EnumValue.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_EnumValue, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this.Proxy.EnumValue != null ? this.Proxy.EnumValue.ID : (int?)null, xml, "EnumValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_EnumValue, xml, "EnumValue", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.EnumValue != null ? this.Proxy.EnumValue.ExportGuid : (Guid?)null, xml, "EnumValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_EnumValue, xml, "EnumValue", "Kistl.App.Base");
        }

        #endregion

    }
}