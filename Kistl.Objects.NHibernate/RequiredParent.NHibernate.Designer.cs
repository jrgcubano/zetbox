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
    /// Testclass for the required_parent tests: parent
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("RequiredParent")]
    public class RequiredParentNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, RequiredParent
    {
        private static readonly Guid _objectClassID = new Guid("0d753d7d-b023-43ce-9189-2ea6d03b70a1");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public RequiredParentNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public RequiredParentNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new RequiredParentProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public RequiredParentNHibernateImpl(Func<IFrozenContext> lazyCtx, RequiredParentProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly RequiredParentProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // object list property

        // Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.RequiredParentChild> Children
        {
            get
            {
                if (_Children == null)
                {
                    _Children = new OneNRelationList<Kistl.App.Test.RequiredParentChild>(
                        "Parent",
                        null,
                        this,
                        () => this.NotifyPropertyChanging("Children", null, null),
                        () => { this.NotifyPropertyChanged("Children", null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); },
                        new ProjectedCollection<Kistl.App.Test.RequiredParentChildNHibernateImpl.RequiredParentChildProxy, Kistl.App.Test.RequiredParentChild>(
                            () => Proxy.Children,
                            p => (Kistl.App.Test.RequiredParentChild)OurContext.AttachAndWrap(p),
                            d => (Kistl.App.Test.RequiredParentChildNHibernateImpl.RequiredParentChildProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _Children;
            }
        }
    
        private OneNRelationList<Kistl.App.Test.RequiredParentChild> _Children;
public static event PropertyListChangedHandler<Kistl.App.Test.RequiredParent> OnChildren_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParent> OnChildren_IsValid;

        /// <summary>
        /// dummy property
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Name != value)
                {
                    var __oldValue = Proxy.Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    Proxy.Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Name");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParent, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParent, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParent, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParent> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(RequiredParent);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RequiredParent)obj;
            var otherImpl = (RequiredParentNHibernateImpl)obj;
            var me = (RequiredParent)this;

            me.Name = other.Name;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Name":
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
                    new PropertyDescriptorNHibernateImpl<RequiredParent, ICollection<Kistl.App.Test.RequiredParentChild>>(
                        lazyCtx,
                        new Guid("e452deb2-1f35-4b7c-9adc-1f904dfbfc6d"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null, // lists are read-only properties
                        obj => OnChildren_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<RequiredParent, string>(
                        lazyCtx,
                        new Guid("22abc57e-581f-49f1-8eff-747e126a6480"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_RequiredParent")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RequiredParent != null)
            {
                OnToString_RequiredParent(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RequiredParent> OnToString_RequiredParent;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_RequiredParent")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_RequiredParent != null)
            {
                OnObjectIsValid_RequiredParent(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<RequiredParent> OnObjectIsValid_RequiredParent;

        [EventBasedMethod("OnNotifyPreSave_RequiredParent")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_RequiredParent != null) OnNotifyPreSave_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnNotifyPreSave_RequiredParent;

        [EventBasedMethod("OnNotifyPostSave_RequiredParent")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_RequiredParent != null) OnNotifyPostSave_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnNotifyPostSave_RequiredParent;

        [EventBasedMethod("OnNotifyCreated_RequiredParent")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_RequiredParent != null) OnNotifyCreated_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnNotifyCreated_RequiredParent;

        [EventBasedMethod("OnNotifyDeleting_RequiredParent")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_RequiredParent != null) OnNotifyDeleting_RequiredParent(this);

            foreach(NHibernatePersistenceObject x in Children) {
                x.ParentsToDelete.Add(this);
                ChildrenToDelete.Add(x);
            }

            Children.Clear();
        }
        public static event ObjectEventHandler<RequiredParent> OnNotifyDeleting_RequiredParent;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class RequiredParentProxy
            : IProxyObject, ISortKey<int>
        {
            public RequiredParentProxy()
            {
                Children = new Collection<Kistl.App.Test.RequiredParentChildNHibernateImpl.RequiredParentChildProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(RequiredParentNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(RequiredParentProxy); } }

            public virtual ICollection<Kistl.App.Test.RequiredParentChildNHibernateImpl.RequiredParentChildProxy> Children { get; set; }

            public virtual string Name { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                string tmp;
                binStream.Read(out tmp);
                this.Proxy.Name = tmp;
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
            XmlStreamer.ToStream(this.Proxy.Name, xml, "Name", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                string tmp = this.Proxy.Name;
                XmlStreamer.FromStream(ref tmp, xml, "Name", "Kistl.App.Test");
                this.Proxy.Name = tmp;
            }
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