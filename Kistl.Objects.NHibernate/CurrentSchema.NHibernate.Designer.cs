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
    /// Describes the currently loaded physical database schema
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CurrentSchema")]
    public class CurrentSchemaNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, CurrentSchema
    {
        private static readonly Guid _objectClassID = new Guid("b276a0f6-cc89-473d-9dce-2efcf3efdd37");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public CurrentSchemaNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CurrentSchemaNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CurrentSchemaProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CurrentSchemaNHibernateImpl(Func<IFrozenContext> lazyCtx, CurrentSchemaProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly CurrentSchemaProxy Proxy;

        /// <summary>
        /// XML descriptor of the current schema
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Schema
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Schema;
                if (OnSchema_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnSchema_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Schema != value)
                {
                    var __oldValue = Proxy.Schema;
                    var __newValue = value;
                    if (OnSchema_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Schema", __oldValue, __newValue);
                    Proxy.Schema = __newValue;
                    NotifyPropertyChanged("Schema", __oldValue, __newValue);

                    if (OnSchema_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Schema");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.CurrentSchema> OnSchema_IsValid;

        /// <summary>
        /// Version number of this schema
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Version
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Version;
                if (OnVersion_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnVersion_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Version != value)
                {
                    var __oldValue = Proxy.Version;
                    var __newValue = value;
                    if (OnVersion_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Version", __oldValue, __newValue);
                    Proxy.Version = __newValue;
                    NotifyPropertyChanged("Version", __oldValue, __newValue);

                    if (OnVersion_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Version");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.CurrentSchema> OnVersion_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(CurrentSchema);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CurrentSchema)obj;
            var otherImpl = (CurrentSchemaNHibernateImpl)obj;
            var me = (CurrentSchema)this;

            me.Schema = other.Schema;
            me.Version = other.Version;
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
                case "Schema":
                case "Version":
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
                    // else
                    new PropertyDescriptorNHibernateImpl<CurrentSchema, string>(
                        lazyCtx,
                        new Guid("175143b9-dd09-4b49-a633-e9cdb508c4c5"),
                        "Schema",
                        null,
                        obj => obj.Schema,
                        (obj, val) => obj.Schema = val,
						obj => OnSchema_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<CurrentSchema, int>(
                        lazyCtx,
                        new Guid("193c24c4-5a42-418e-8ed8-6e1689beca50"),
                        "Version",
                        null,
                        obj => obj.Version,
                        (obj, val) => obj.Version = val,
						obj => OnVersion_IsValid), 
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
        [EventBasedMethod("OnToString_CurrentSchema")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CurrentSchema != null)
            {
                OnToString_CurrentSchema(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CurrentSchema> OnToString_CurrentSchema;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CurrentSchema")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CurrentSchema != null)
            {
                OnObjectIsValid_CurrentSchema(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CurrentSchema> OnObjectIsValid_CurrentSchema;

        [EventBasedMethod("OnNotifyPreSave_CurrentSchema")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CurrentSchema != null) OnNotifyPreSave_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnNotifyPreSave_CurrentSchema;

        [EventBasedMethod("OnNotifyPostSave_CurrentSchema")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CurrentSchema != null) OnNotifyPostSave_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnNotifyPostSave_CurrentSchema;

        [EventBasedMethod("OnNotifyCreated_CurrentSchema")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Schema");
            SetNotInitializedProperty("Version");
            base.NotifyCreated();
            if (OnNotifyCreated_CurrentSchema != null) OnNotifyCreated_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnNotifyCreated_CurrentSchema;

        [EventBasedMethod("OnNotifyDeleting_CurrentSchema")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CurrentSchema != null) OnNotifyDeleting_CurrentSchema(this);


        }
        public static event ObjectEventHandler<CurrentSchema> OnNotifyDeleting_CurrentSchema;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class CurrentSchemaProxy
            : IProxyObject, ISortKey<int>
        {
            public CurrentSchemaProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(CurrentSchemaNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(CurrentSchemaProxy); } }

            public virtual string Schema { get; set; }

            public virtual int Version { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Schema);
            binStream.Write(this.Proxy.Version);
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
                this.Proxy.Schema = tmp;
            }
            {
                int tmp;
                binStream.Read(out tmp);
                this.Proxy.Version = tmp;
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
            XmlStreamer.ToStream(this.Proxy.Schema, xml, "Schema", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Version, xml, "Version", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                string tmp = this.Proxy.Schema;
                XmlStreamer.FromStream(ref tmp, xml, "Schema", "Kistl.App.Base");
                this.Proxy.Schema = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.Version;
                XmlStreamer.FromStream(ref tmp, xml, "Version", "Kistl.App.Base");
                this.Proxy.Version = tmp;
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