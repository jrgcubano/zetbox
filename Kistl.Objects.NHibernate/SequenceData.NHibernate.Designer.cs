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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SequenceData")]
    public class SequenceDataNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, SequenceData
    {
        private static readonly Guid _objectClassID = new Guid("6efc1387-cffc-4cff-9af3-19365d888f4b");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public SequenceDataNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public SequenceDataNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new SequenceDataProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public SequenceDataNHibernateImpl(Func<IFrozenContext> lazyCtx, SequenceDataProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly SequenceDataProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int CurrentNumber
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.CurrentNumber;
                if (OnCurrentNumber_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnCurrentNumber_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.CurrentNumber != value)
                {
                    var __oldValue = Proxy.CurrentNumber;
                    var __newValue = value;
                    if (OnCurrentNumber_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnCurrentNumber_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CurrentNumber", __oldValue, __newValue);
                    Proxy.CurrentNumber = __newValue;
                    NotifyPropertyChanged("CurrentNumber", __oldValue, __newValue);

                    if (OnCurrentNumber_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnCurrentNumber_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("CurrentNumber");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.SequenceData> OnCurrentNumber_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Sequence
        // fkBackingName=this.Proxy.Sequence; fkGuidBackingName=_fk_guid_Sequence;
        // referencedInterface=Kistl.App.Base.Sequence; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=Data; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Sequence Sequence
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.SequenceNHibernateImpl __value = (Kistl.App.Base.SequenceNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Sequence);

                if (OnSequence_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Sequence>(__value);
                    OnSequence_Getter(this, e);
                    __value = (Kistl.App.Base.SequenceNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Sequence == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.SequenceNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Sequence);
                var __newValue = (Kistl.App.Base.SequenceNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Sequence", __oldValue, __newValue);

                if (OnSequence_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Sequence>(__oldValue, __newValue);
                    OnSequence_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.SequenceNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Sequence = null;
                }
                else
                {
                    this.Proxy.Sequence = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.Data = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.Data = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Sequence", __oldValue, __newValue);

                if (OnSequence_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Sequence>(__oldValue, __newValue);
                    OnSequence_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Sequence's id, used on dehydration only</summary>
        private int? _fk_Sequence = null;


        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Sequence
		public static event PropertyGetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.SequenceData> OnSequence_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(SequenceData);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SequenceData)obj;
            var otherImpl = (SequenceDataNHibernateImpl)obj;
            var me = (SequenceData)this;

            me.CurrentNumber = other.CurrentNumber;
            this._fk_Sequence = otherImpl._fk_Sequence;
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
                case "Sequence":
                    {
                        var __oldValue = (Kistl.App.Base.SequenceNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Sequence);
                        var __newValue = (Kistl.App.Base.SequenceNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Sequence", __oldValue, __newValue);
                        this.Proxy.Sequence = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Sequence", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "CurrentNumber":
                case "Sequence":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_Sequence.HasValue)
                this.Sequence = ((Kistl.App.Base.SequenceNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Sequence>(_fk_Sequence.Value));
            else
                this.Sequence = null;
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
                    new PropertyDescriptorNHibernateImpl<SequenceData, int>(
                        lazyCtx,
                        new Guid("e557569b-1ed8-49a6-959e-0a6bc3ffa591"),
                        "CurrentNumber",
                        null,
                        obj => obj.CurrentNumber,
                        (obj, val) => obj.CurrentNumber = val,
						obj => OnCurrentNumber_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<SequenceData, Kistl.App.Base.Sequence>(
                        lazyCtx,
                        new Guid("98a20549-d4ff-4caf-bae2-10951b04c6f1"),
                        "Sequence",
                        null,
                        obj => obj.Sequence,
                        (obj, val) => obj.Sequence = val,
						obj => OnSequence_IsValid), 
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
        [EventBasedMethod("OnToString_SequenceData")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SequenceData != null)
            {
                OnToString_SequenceData(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SequenceData> OnToString_SequenceData;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_SequenceData")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_SequenceData != null)
            {
                OnObjectIsValid_SequenceData(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<SequenceData> OnObjectIsValid_SequenceData;

        [EventBasedMethod("OnNotifyPreSave_SequenceData")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_SequenceData != null) OnNotifyPreSave_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnNotifyPreSave_SequenceData;

        [EventBasedMethod("OnNotifyPostSave_SequenceData")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_SequenceData != null) OnNotifyPostSave_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnNotifyPostSave_SequenceData;

        [EventBasedMethod("OnNotifyCreated_SequenceData")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("CurrentNumber");
            SetNotInitializedProperty("Sequence");
            base.NotifyCreated();
            if (OnNotifyCreated_SequenceData != null) OnNotifyCreated_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnNotifyCreated_SequenceData;

        [EventBasedMethod("OnNotifyDeleting_SequenceData")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_SequenceData != null) OnNotifyDeleting_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnNotifyDeleting_SequenceData;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Sequence_has_Data
            if (this.Sequence != null && this.Sequence.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Sequence);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class SequenceDataProxy
            : IProxyObject, ISortKey<int>
        {
            public SequenceDataProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(SequenceDataNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(SequenceDataProxy); } }

            public virtual int CurrentNumber { get; set; }

            public virtual Kistl.App.Base.SequenceNHibernateImpl.SequenceProxy Sequence { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.CurrentNumber, binStream);
            BinarySerializer.ToStream(this.Proxy.Sequence != null ? OurContext.GetIdFromProxy(this.Proxy.Sequence) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.CurrentNumber = tmp;
            }
            BinarySerializer.FromStream(out this._fk_Sequence, binStream);
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
            XmlStreamer.ToStream(this.Proxy.CurrentNumber, xml, "CurrentNumber", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Sequence != null ? OurContext.GetIdFromProxy(this.Proxy.Sequence) : (int?)null, xml, "Sequence", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                int tmp = this.Proxy.CurrentNumber;
                XmlStreamer.FromStream(ref tmp, xml, "CurrentNumber", "Kistl.App.Base");
                this.Proxy.CurrentNumber = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_Sequence, xml, "Sequence", "Kistl.App.Base");
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