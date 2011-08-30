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
    [System.Diagnostics.DebuggerDisplay("IndexConstraint")]
    public class IndexConstraintNHibernateImpl : Kistl.App.Base.InstanceConstraintNHibernateImpl, IndexConstraint
    {
        public IndexConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IndexConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IndexConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IndexConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, IndexConstraintProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
            _isIsUniqueSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly IndexConstraintProxy Proxy;

        /// <summary>
        /// Index is created as a Unique Index
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool IsUnique
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchIsUniqueOrDefault();
                if (OnIsUnique_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsUnique_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsUniqueSet = true;
                if (Proxy.IsUnique != value)
                {
                    var __oldValue = Proxy.IsUnique;
                    var __newValue = value;
                    if (OnIsUnique_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsUnique_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsUnique", __oldValue, __newValue);
                    Proxy.IsUnique = __newValue;
                    NotifyPropertyChanged("IsUnique", __oldValue, __newValue);
                    if (OnIsUnique_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsUnique_PostSetter(this, __e);
                    }
                }
            }
        }

        private bool FetchIsUniqueOrDefault()
        {
            var __result = Proxy.IsUnique;
                if (!_isIsUniqueSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("2cc6e028-e01f-4879-bda8-78d459c0eaf4"));
                    if (__p != null) {
                        _isIsUniqueSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.IsUnique = (bool)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Kistl.App.Base.IndexConstraint.IsUnique'");
                    }
                }
            return __result;
        }

        private bool _isIsUniqueSet = false;
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Base.Property> Properties
		{
			get
			{
				if (_Properties == null)
				{
					_Properties 
						= new NHibernateBSideCollectionWrapper<Kistl.App.Base.IndexConstraint, Kistl.App.Base.Property, IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl.IndexConstraint_ensures_unique_on_Property_RelationEntryProxy, IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl>(
                                this.Proxy.Properties,
                                p => (IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl.IndexConstraint_ensures_unique_on_Property_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl>)null);
                    if (Properties_was_eagerLoaded) { Properties_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.Base.Property>)_Properties;
			}
		}

		private NHibernateBSideCollectionWrapper<Kistl.App.Base.IndexConstraint, Kistl.App.Base.Property, IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl> _Properties;
		// ignored, but required for Serialization
        private bool Properties_was_eagerLoaded = false;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IndexConstraint")]
        public override string GetErrorText(Kistl.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IndexConstraint != null)
            {
                OnGetErrorText_IndexConstraint(this, e, constrainedObject);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IndexConstraint> OnGetErrorText_IndexConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_IndexConstraint")]
        public override bool IsValid(Kistl.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IndexConstraint != null)
            {
                OnIsValid_IndexConstraint(this, e, constrainedObject);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IndexConstraint> OnIsValid_IndexConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(IndexConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IndexConstraint)obj;
            var otherImpl = (IndexConstraintNHibernateImpl)obj;
            var me = (IndexConstraint)this;

            me.IsUnique = other.IsUnique;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
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
                    new PropertyDescriptorNHibernateImpl<IndexConstraintNHibernateImpl, bool>(
                        lazyCtx,
                        new Guid("2cc6e028-e01f-4879-bda8-78d459c0eaf4"),
                        "IsUnique",
                        null,
                        obj => obj.IsUnique,
                        (obj, val) => obj.IsUnique = val),
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<IndexConstraintNHibernateImpl, ICollection<Kistl.App.Base.Property>>(
                        lazyCtx,
                        new Guid("3e4bfd37-1037-472b-a5d7-2c20a777e6fd"),
                        "Properties",
                        null,
                        obj => obj.Properties,
                        null), // lists are read-only properties
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
        [EventBasedMethod("OnToString_IndexConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IndexConstraint != null)
            {
                OnToString_IndexConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IndexConstraint> OnToString_IndexConstraint;

        [EventBasedMethod("OnPreSave_IndexConstraint")]
        public override void NotifyPreSave()
        {
            FetchIsUniqueOrDefault();
            base.NotifyPreSave();
            if (OnPreSave_IndexConstraint != null) OnPreSave_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnPreSave_IndexConstraint;

        [EventBasedMethod("OnPostSave_IndexConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IndexConstraint != null) OnPostSave_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnPostSave_IndexConstraint;

        [EventBasedMethod("OnCreated_IndexConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IndexConstraint != null) OnCreated_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnCreated_IndexConstraint;

        [EventBasedMethod("OnDeleting_IndexConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IndexConstraint != null) OnDeleting_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnDeleting_IndexConstraint;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();


            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();


            return result;
        }


        public class IndexConstraintProxy
            : Kistl.App.Base.InstanceConstraintNHibernateImpl.InstanceConstraintProxy
        {
            public IndexConstraintProxy()
            {
                Properties = new Collection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl.IndexConstraint_ensures_unique_on_Property_RelationEntryProxy>();
            }

            public override Type ZBoxWrapper { get { return typeof(IndexConstraintNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(IndexConstraintProxy); } }

            public virtual bool IsUnique { get; set; }

            public virtual ICollection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryNHibernateImpl.IndexConstraint_ensures_unique_on_Property_RelationEntryProxy> Properties { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._isIsUniqueSet, binStream);
            if (this._isIsUniqueSet) {
                BinarySerializer.ToStream(this.Proxy.IsUnique, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._isIsUniqueSet, binStream);
            if (this._isIsUniqueSet) {
                bool tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsUnique = tmp;
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
            XmlStreamer.ToStream(this._isIsUniqueSet, xml, "IsIsUniqueSet", "Kistl.App.Base");
            if (this._isIsUniqueSet) {
                XmlStreamer.ToStream(this.Proxy.IsUnique, xml, "IsUnique", "Kistl.App.Base");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._isIsUniqueSet, xml, "IsIsUniqueSet", "Kistl.App.Base");
            if (this._isIsUniqueSet) {
                // yuck
                bool tmp = this.Proxy.IsUnique;
                XmlStreamer.FromStream(ref tmp, xml, "IsUnique", "Kistl.App.Base");
                this.Proxy.IsUnique = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            System.Diagnostics.Debug.Assert(this._isIsUniqueSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.IsUnique, xml, "IsUnique", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // Import must have default value set
            {
                // yuck
                bool tmp = this.Proxy.IsUnique;
                XmlStreamer.FromStream(ref tmp, xml, "IsUnique", "Kistl.App.Base");
                this.Proxy.IsUnique = tmp;
                this._isIsUniqueSet = true;
            }
        }

        #endregion

    }
}