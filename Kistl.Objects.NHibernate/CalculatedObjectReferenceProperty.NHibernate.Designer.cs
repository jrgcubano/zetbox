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
    /// a object reference that is calculated from the contents of the containing class
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CalculatedObjectReferenceProperty")]
    public class CalculatedObjectReferencePropertyNHibernateImpl : Kistl.App.Base.PropertyNHibernateImpl, CalculatedObjectReferenceProperty
    {
        public CalculatedObjectReferencePropertyNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CalculatedObjectReferencePropertyNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CalculatedObjectReferencePropertyProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CalculatedObjectReferencePropertyNHibernateImpl(Func<IFrozenContext> lazyCtx, CalculatedObjectReferencePropertyProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CalculatedObjectReferencePropertyProxy Proxy;

        /// <summary>
        /// The properties on which the calculation depends. This is used to propagate change notifications.
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Base.Property> Inputs
		{
			get
			{
				if (_Inputs == null)
				{
					_Inputs 
						= new NHibernateBSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryProxy, CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl>(
                                this.Proxy.Inputs,
                                p => (CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl>)null);
                    if (Inputs_was_eagerLoaded) { Inputs_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.Base.Property>)_Inputs;
			}
		}

		private NHibernateBSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl> _Inputs;
		// ignored, but required for Serialization
        private bool Inputs_was_eagerLoaded = false;

        /// <summary>
        /// the referenced class of objects
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
        // fkBackingName=this.Proxy.ReferencedClass; fkGuidBackingName=_fk_guid_ReferencedClass;
        // referencedInterface=Kistl.App.Base.ObjectClass; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ReferencedClass
        {
            get
            {
                Kistl.App.Base.ObjectClassNHibernateImpl __value = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ReferencedClass);

                if (OnReferencedClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
                    OnReferencedClass_Getter(this, e);
                    __value = (Kistl.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.ReferencedClass == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ReferencedClass);
                var __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ReferencedClass", __oldValue, __newValue);

                if (OnReferencedClass_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.ReferencedClass = null;
                }
                else
                {
                    this.Proxy.ReferencedClass = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ReferencedClass", __oldValue, __newValue);

                if (OnReferencedClass_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for ReferencedClass's id, used on dehydration only</summary>
        private int? _fk_ReferencedClass = null;

        /// <summary>Backing store for ReferencedClass's guid, used on import only</summary>
        private Guid? _fk_guid_ReferencedClass = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
		public static event PropertyGetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_CalculatedObjectReferenceProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CalculatedObjectReferenceProperty != null)
            {
                OnGetLabel_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CalculatedObjectReferenceProperty> OnGetLabel_CalculatedObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_CalculatedObjectReferenceProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyType_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<CalculatedObjectReferenceProperty> OnGetPropertyType_CalculatedObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_CalculatedObjectReferenceProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<CalculatedObjectReferenceProperty> OnGetPropertyTypeString_CalculatedObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(CalculatedObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CalculatedObjectReferenceProperty)obj;
            var otherImpl = (CalculatedObjectReferencePropertyNHibernateImpl)obj;
            var me = (CalculatedObjectReferenceProperty)this;

            this._fk_ReferencedClass = otherImpl._fk_ReferencedClass;
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
                case "ReferencedClass":
                    {
                        var __oldValue = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ReferencedClass);
                        var __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)(id == null ? null : OurContext.Find<Kistl.App.Base.ObjectClass>(id.Value));
                        NotifyPropertyChanging("ReferencedClass", __oldValue, __newValue);
                        this.Proxy.ReferencedClass = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("ReferencedClass", __oldValue, __newValue);
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

            if (_fk_guid_ReferencedClass.HasValue)
                this.Proxy.ReferencedClass = ((Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ReferencedClass.Value)).Proxy;
            else
            if (_fk_ReferencedClass.HasValue)
                this.Proxy.ReferencedClass = ((Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_ReferencedClass.Value)).Proxy;
            else
                this.Proxy.ReferencedClass = null;
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
                    new PropertyDescriptorNHibernateImpl<CalculatedObjectReferencePropertyNHibernateImpl, ICollection<Kistl.App.Base.Property>>(
                        lazyCtx,
                        new Guid("bfda6511-087d-4381-9780-1f76f3abcffe"),
                        "Inputs",
                        null,
                        obj => obj.Inputs,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorNHibernateImpl<CalculatedObjectReferencePropertyNHibernateImpl, Kistl.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("cd62d769-0752-4a72-832f-5935ece1198b"),
                        "ReferencedClass",
                        null,
                        obj => obj.ReferencedClass,
                        (obj, val) => obj.ReferencedClass = val),
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
        [EventBasedMethod("OnToString_CalculatedObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CalculatedObjectReferenceProperty != null)
            {
                OnToString_CalculatedObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CalculatedObjectReferenceProperty> OnToString_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnPreSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CalculatedObjectReferenceProperty != null) OnPreSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPreSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CalculatedObjectReferenceProperty != null) OnPostSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPostSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnCreated_CalculatedObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CalculatedObjectReferenceProperty != null) OnCreated_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnCreated_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_CalculatedObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CalculatedObjectReferenceProperty != null) OnDeleting_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnDeleting_CalculatedObjectReferenceProperty;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();


            if (this.ReferencedClass != null && this.ReferencedClass.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.ReferencedClass);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();


            return result;
        }


        public class CalculatedObjectReferencePropertyProxy
            : Kistl.App.Base.PropertyNHibernateImpl.PropertyProxy
        {
            public CalculatedObjectReferencePropertyProxy()
            {
                Inputs = new Collection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryProxy>();
            }

            public override Type ZBoxWrapper { get { return typeof(CalculatedObjectReferencePropertyNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CalculatedObjectReferencePropertyProxy); } }

            public virtual ICollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryNHibernateImpl.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryProxy> Inputs { get; set; }

            public virtual Kistl.App.Base.ObjectClassNHibernateImpl.ObjectClassProxy ReferencedClass { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);

			BinarySerializer.ToStream(eagerLoadLists, binStream);
			if (eagerLoadLists && auxObjects != null)
			{
				foreach(var obj in Inputs)
				{
					auxObjects.Add(obj);
				}
				foreach(var relEntry in this.Proxy.Inputs)
				{
					auxObjects.Add(OurContext.AttachAndWrap(relEntry));
				}
			}
            BinarySerializer.ToStream(this.Proxy.ReferencedClass != null ? this.Proxy.ReferencedClass.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();

			BinarySerializer.FromStream(out Inputs_was_eagerLoaded, binStream);
            BinarySerializer.FromStream(out this._fk_ReferencedClass, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this.Proxy.ReferencedClass != null ? this.Proxy.ReferencedClass.ID : (int?)null, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.ReferencedClass != null ? this.Proxy.ReferencedClass.ExportGuid : (Guid?)null, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
        }

        #endregion

    }
}