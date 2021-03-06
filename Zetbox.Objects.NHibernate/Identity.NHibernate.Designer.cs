// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Zetbox.API;
    using Zetbox.DalProvider.Base.RelationWrappers;

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Represents an Identity
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Identity")]
    public class IdentityNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, Identity
    {
        private static readonly Guid _objectClassID = new Guid("31d8890a-67fc-4a78-9d35-9ff0b9e09b4c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public IdentityNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IdentityNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IdentityProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IdentityNHibernateImpl(Func<IFrozenContext> lazyCtx, IdentityProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly IdentityProxy Proxy;

        /// <summary>
        /// Displayname of this identity
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string DisplayName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.DisplayName != value)
                {
                    var __oldValue = Proxy.DisplayName;
                    var __newValue = value;
                    if (OnDisplayName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    Proxy.DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);

                    if (OnDisplayName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("DisplayName");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnDisplayName_IsValid;

        /// <summary>
        /// Identites are member of groups
        /// </summary>
        // collection entry list property
   		// Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Zetbox.App.Base.Group> Groups
		{
			get
			{
				if (_Groups == null)
				{
					_Groups 
						= new NHibernateBSideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>(
                                () => this.Proxy.Groups,
                                p => (Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>)entry.B.Member);
                    if (Groups_was_eagerLoaded) { Groups_was_eagerLoaded = false; }
				}
				return (ICollection<Zetbox.App.Base.Group>)_Groups;
			}
		}

		private NHibernateBSideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl> _Groups;
		// ignored, but required for Serialization
        private bool Groups_was_eagerLoaded = false;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnGroups_IsValid;

        /// <summary>
        /// Password of a generic identity
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Password
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Password;
                if (OnPassword_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPassword_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Password != value)
                {
                    var __oldValue = Proxy.Password;
                    var __newValue = value;
                    if (OnPassword_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Password", __oldValue, __newValue);
                    Proxy.Password = __newValue;
                    NotifyPropertyChanged("Password", __oldValue, __newValue);

                    if (OnPassword_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Password");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnPassword_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnPassword_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnPassword_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnPassword_IsValid;

        /// <summary>
        /// Username of a generic identity
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string UserName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.UserName;
                if (OnUserName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnUserName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.UserName != value)
                {
                    var __oldValue = Proxy.UserName;
                    var __newValue = value;
                    if (OnUserName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("UserName", __oldValue, __newValue);
                    Proxy.UserName = __newValue;
                    NotifyPropertyChanged("UserName", __oldValue, __newValue);

                    if (OnUserName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("UserName");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnUserName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnUserName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnUserName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnUserName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Identity);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Identity)obj;
            var otherImpl = (IdentityNHibernateImpl)obj;
            var me = (Identity)this;

            me.DisplayName = other.DisplayName;
            me.Password = other.Password;
            me.UserName = other.UserName;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "DisplayName":
                case "Password":
                case "UserName":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Groups":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    new PropertyDescriptorNHibernateImpl<Identity, string>(
                        lazyCtx,
                        new Guid("f93e6dbb-a704-460c-8183-ce8b1c2c47a2"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val,
						obj => OnDisplayName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<Identity, ICollection<Zetbox.App.Base.Group>>(
                        lazyCtx,
                        new Guid("5f534204-f0d5-4d6f-8efa-7ff248580ba3"),
                        "Groups",
                        null,
                        obj => obj.Groups,
                        null, // lists are read-only properties
                        obj => OnGroups_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Identity, string>(
                        lazyCtx,
                        new Guid("0d499610-99e3-42cc-b71b-49ed1a356355"),
                        "Password",
                        null,
                        obj => obj.Password,
                        (obj, val) => obj.Password = val,
						obj => OnPassword_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Identity, string>(
                        lazyCtx,
                        new Guid("a4ce1f5f-311b-4510-8817-4cca40f0bf0f"),
                        "UserName",
                        null,
                        obj => obj.UserName,
                        (obj, val) => obj.UserName = val,
						obj => OnUserName_IsValid), 
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Identity")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Identity != null)
            {
                OnToString_Identity(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Identity> OnToString_Identity;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Identity")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Identity != null)
            {
                OnObjectIsValid_Identity(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Identity> OnObjectIsValid_Identity;

        [EventBasedMethod("OnNotifyPreSave_Identity")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Identity != null) OnNotifyPreSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyPreSave_Identity;

        [EventBasedMethod("OnNotifyPostSave_Identity")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Identity != null) OnNotifyPostSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyPostSave_Identity;

        [EventBasedMethod("OnNotifyCreated_Identity")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DisplayName");
            SetNotInitializedProperty("Password");
            SetNotInitializedProperty("UserName");
            base.NotifyCreated();
            if (OnNotifyCreated_Identity != null) OnNotifyCreated_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyCreated_Identity;

        [EventBasedMethod("OnNotifyDeleting_Identity")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Identity != null) OnNotifyDeleting_Identity(this);

            // should fetch && remember parent for AbstractModuleMember_was_Identity_RelationEntry
            // should fetch && remember parent for AbstractModuleMember_was_Identity_RelationEntry
            // should fetch && remember parent for AccessControl_was_Identity_RelationEntry
            // should fetch && remember parent for AccessControl_was_Identity_RelationEntry
            // should fetch && remember parent for Application_was_Identity_RelationEntry
            // should fetch && remember parent for Application_was_Identity_RelationEntry
            // should fetch && remember parent for Assembly_was_Identity_RelationEntry
            // should fetch && remember parent for Assembly_was_Identity_RelationEntry
            // should fetch && remember parent for Auftrag_ChangedBy_Identity_RelationEntry
            // should fetch && remember parent for Auftrag_CreatedBy_Identity_RelationEntry
            // should fetch && remember parent for BaseParameter_was_Identity_RelationEntry
            // should fetch && remember parent for BaseParameter_was_Identity_RelationEntry
            // should fetch && remember parent for Calendar_was_Identity_RelationEntry
            // should fetch && remember parent for Calendar_was_Identity_RelationEntry
            // should fetch && remember parent for CalendarRule_was_Identity_RelationEntry
            // should fetch && remember parent for CalendarRule_was_Identity_RelationEntry
            // should fetch && remember parent for SecurityTestChild_allow_Identity_RelationEntry
            // should fetch && remember parent for FileImportConfiguration_of_Identity_RelationEntry
            // should fetch && remember parent for Constraint_was_Identity_RelationEntry
            // should fetch && remember parent for Constraint_was_Identity_RelationEntry
            // should fetch && remember parent for DataType_was_Identity_RelationEntry
            // should fetch && remember parent for DataType_was_Identity_RelationEntry
            // should fetch && remember parent for DefaultPropertyValue_was_Identity_RelationEntry
            // should fetch && remember parent for DefaultPropertyValue_was_Identity_RelationEntry
            // should fetch && remember parent for Blob_was_Identity_RelationEntry
            // should fetch && remember parent for Blob_was_Identity_RelationEntry
            // should fetch && remember parent for EnumerationEntry_was_Identity_RelationEntry
            // should fetch && remember parent for EnumerationEntry_was_Identity_RelationEntry
            // should fetch && remember parent for File_was_Identity_RelationEntry
            // should fetch && remember parent for File_was_Identity_RelationEntry
            // should fetch && remember parent for FileImportConfiguration_was_Identity_RelationEntry
            // should fetch && remember parent for FileImportConfiguration_was_Identity_RelationEntry
            // should fetch && remember parent for FilterConfiguration_was_Identity_RelationEntry
            // should fetch && remember parent for FilterConfiguration_was_Identity_RelationEntry
            // should fetch && remember parent for Kunde_was_Identity_RelationEntry
            // should fetch && remember parent for Kunde_was_Identity_RelationEntry
            // should fetch && remember parent for SavedListConfiguration_of_Identity_RelationEntry
            // should fetch && remember parent for Method_was_Identity_RelationEntry
            // should fetch && remember parent for Method_was_Identity_RelationEntry
            // should fetch && remember parent for MigrationProject_was_Identity_RelationEntry
            // should fetch && remember parent for MigrationProject_was_Identity_RelationEntry
            // should fetch && remember children for Mitarbeiter_is_a_Identity_RelationEntry
            // should fetch && remember parent for Mitarbeiter_was_Identity_RelationEntry
            // should fetch && remember parent for Mitarbeiter_was_Identity_RelationEntry
            // should fetch && remember parent for Module_was_Identity_RelationEntry
            // should fetch && remember parent for Module_was_Identity_RelationEntry
            // should fetch && remember parent for NavigationEntry_was_Identity_RelationEntry
            // should fetch && remember parent for NavigationEntry_was_Identity_RelationEntry
            // should fetch && remember parent for Projekt_was_Identity_RelationEntry
            // should fetch && remember parent for Projekt_was_Identity_RelationEntry
            // should fetch && remember parent for Property_was_Identity_RelationEntry
            // should fetch && remember parent for Property_was_Identity_RelationEntry
            // should fetch && remember parent for Relation_was_Identity_RelationEntry
            // should fetch && remember parent for Relation_was_Identity_RelationEntry
            // should fetch && remember parent for RelationEnd_was_Identity_RelationEntry
            // should fetch && remember parent for RelationEnd_was_Identity_RelationEntry
            // should fetch && remember parent for Sequence_was_Identity_RelationEntry
            // should fetch && remember parent for Sequence_was_Identity_RelationEntry
            // should fetch && remember parent for ServiceDescriptor_was_Identity_RelationEntry
            // should fetch && remember parent for ServiceDescriptor_was_Identity_RelationEntry
            // should fetch && remember parent for SourceColumn_was_Identity_RelationEntry
            // should fetch && remember parent for SourceColumn_was_Identity_RelationEntry
            // should fetch && remember parent for SourceEnum_was_Identity_RelationEntry
            // should fetch && remember parent for SourceEnum_was_Identity_RelationEntry
            // should fetch && remember parent for SourceTable_was_Identity_RelationEntry
            // should fetch && remember parent for SourceTable_was_Identity_RelationEntry
            // should fetch && remember parent for StagingDatabase_was_Identity_RelationEntry
            // should fetch && remember parent for StagingDatabase_was_Identity_RelationEntry
            // should fetch && remember parent for Task_was_Identity_RelationEntry
            // should fetch && remember parent for Task_was_Identity_RelationEntry
            // should fetch && remember parent for TypeRef_was_Identity_RelationEntry
            // should fetch && remember parent for TypeRef_was_Identity_RelationEntry

            Groups.Clear();
        }
        public static event ObjectEventHandler<Identity> OnNotifyDeleting_Identity;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class IdentityProxy
            : IProxyObject, ISortKey<int>
        {
            public IdentityProxy()
            {
                Groups = new Collection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(IdentityNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(IdentityProxy); } }

            public virtual string DisplayName { get; set; }

            public virtual ICollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy> Groups { get; set; }

            public virtual string Password { get; set; }

            public virtual string UserName { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.DisplayName);
            binStream.Write(this.Proxy.Password);
            binStream.Write(this.Proxy.UserName);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.DisplayName = binStream.ReadString();
            this.Proxy.Password = binStream.ReadString();
            this.Proxy.UserName = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}