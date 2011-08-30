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
    /// Logentry for exceptions
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ExceptionLogEntry")]
    public class ExceptionLogEntryNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, ExceptionLogEntry
    {
        public ExceptionLogEntryNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ExceptionLogEntryNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ExceptionLogEntryProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ExceptionLogEntryNHibernateImpl(Func<IFrozenContext> lazyCtx, ExceptionLogEntryProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly ExceptionLogEntryProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public DateTime Date
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Date;
                if (OnDate_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnDate_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Date != value)
                {
                    var __oldValue = Proxy.Date;
                    var __newValue = value;
                    if (OnDate_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnDate_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Date", __oldValue, __newValue);
                    Proxy.Date = __newValue;
                    NotifyPropertyChanged("Date", __oldValue, __newValue);
                    if (OnDate_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnDate_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, DateTime> OnDate_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, DateTime> OnDate_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, DateTime> OnDate_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Exception
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Exception;
                if (OnException_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnException_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Exception != value)
                {
                    var __oldValue = Proxy.Exception;
                    var __newValue = value;
                    if (OnException_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnException_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Exception", __oldValue, __newValue);
                    Proxy.Exception = __newValue;
                    NotifyPropertyChanged("Exception", __oldValue, __newValue);
                    if (OnException_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnException_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnException_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnException_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnException_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Level
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Level;
                if (OnLevel_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnLevel_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Level != value)
                {
                    var __oldValue = Proxy.Level;
                    var __newValue = value;
                    if (OnLevel_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnLevel_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Level", __oldValue, __newValue);
                    Proxy.Level = __newValue;
                    NotifyPropertyChanged("Level", __oldValue, __newValue);
                    if (OnLevel_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnLevel_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLevel_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLevel_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLevel_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Logger
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Logger;
                if (OnLogger_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnLogger_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Logger != value)
                {
                    var __oldValue = Proxy.Logger;
                    var __newValue = value;
                    if (OnLogger_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnLogger_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Logger", __oldValue, __newValue);
                    Proxy.Logger = __newValue;
                    NotifyPropertyChanged("Logger", __oldValue, __newValue);
                    if (OnLogger_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnLogger_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLogger_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLogger_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnLogger_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Message
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Message;
                if (OnMessage_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMessage_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Message != value)
                {
                    var __oldValue = Proxy.Message;
                    var __newValue = value;
                    if (OnMessage_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessage_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Message", __oldValue, __newValue);
                    Proxy.Message = __newValue;
                    NotifyPropertyChanged("Message", __oldValue, __newValue);
                    if (OnMessage_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessage_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnMessage_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnMessage_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnMessage_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Thread
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Thread;
                if (OnThread_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnThread_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Thread != value)
                {
                    var __oldValue = Proxy.Thread;
                    var __newValue = value;
                    if (OnThread_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnThread_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Thread", __oldValue, __newValue);
                    Proxy.Thread = __newValue;
                    NotifyPropertyChanged("Thread", __oldValue, __newValue);
                    if (OnThread_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnThread_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnThread_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnThread_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ExceptionLogEntry, string> OnThread_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(ExceptionLogEntry);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ExceptionLogEntry)obj;
            var otherImpl = (ExceptionLogEntryNHibernateImpl)obj;
            var me = (ExceptionLogEntry)this;

            me.Date = other.Date;
            me.Exception = other.Exception;
            me.Level = other.Level;
            me.Logger = other.Logger;
            me.Message = other.Message;
            me.Thread = other.Thread;
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
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, DateTime>(
                        lazyCtx,
                        new Guid("e093679e-1939-4a7d-97db-e48b5103062a"),
                        "Date",
                        null,
                        obj => obj.Date,
                        (obj, val) => obj.Date = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("203915b1-5bbf-49ff-864b-b66098b39481"),
                        "Exception",
                        null,
                        obj => obj.Exception,
                        (obj, val) => obj.Exception = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("f8becad3-4bb8-47b2-b30c-1c7fc94eac12"),
                        "Level",
                        null,
                        obj => obj.Level,
                        (obj, val) => obj.Level = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("fdf063e0-66f9-421d-9e60-e6aa9fa73d8e"),
                        "Logger",
                        null,
                        obj => obj.Logger,
                        (obj, val) => obj.Logger = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("d80639ab-d40f-41db-a51f-c1a71440654e"),
                        "Message",
                        null,
                        obj => obj.Message,
                        (obj, val) => obj.Message = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ExceptionLogEntryNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("24ab22e0-7dd3-4535-9abd-a94102f9ca80"),
                        "Thread",
                        null,
                        obj => obj.Thread,
                        (obj, val) => obj.Thread = val),
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
        [EventBasedMethod("OnToString_ExceptionLogEntry")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ExceptionLogEntry != null)
            {
                OnToString_ExceptionLogEntry(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ExceptionLogEntry> OnToString_ExceptionLogEntry;

        [EventBasedMethod("OnPreSave_ExceptionLogEntry")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ExceptionLogEntry != null) OnPreSave_ExceptionLogEntry(this);
        }
        public static event ObjectEventHandler<ExceptionLogEntry> OnPreSave_ExceptionLogEntry;

        [EventBasedMethod("OnPostSave_ExceptionLogEntry")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ExceptionLogEntry != null) OnPostSave_ExceptionLogEntry(this);
        }
        public static event ObjectEventHandler<ExceptionLogEntry> OnPostSave_ExceptionLogEntry;

        [EventBasedMethod("OnCreated_ExceptionLogEntry")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ExceptionLogEntry != null) OnCreated_ExceptionLogEntry(this);
        }
        public static event ObjectEventHandler<ExceptionLogEntry> OnCreated_ExceptionLogEntry;

        [EventBasedMethod("OnDeleting_ExceptionLogEntry")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ExceptionLogEntry != null) OnDeleting_ExceptionLogEntry(this);
        }
        public static event ObjectEventHandler<ExceptionLogEntry> OnDeleting_ExceptionLogEntry;

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


        public class ExceptionLogEntryProxy
            : IProxyObject, ISortKey<int>
        {
            public ExceptionLogEntryProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(ExceptionLogEntryNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(ExceptionLogEntryProxy); } }

            public virtual DateTime Date { get; set; }

            public virtual string Exception { get; set; }

            public virtual string Level { get; set; }

            public virtual string Logger { get; set; }

            public virtual string Message { get; set; }

            public virtual string Thread { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.Date, binStream);
            BinarySerializer.ToStream(this.Proxy.Exception, binStream);
            BinarySerializer.ToStream(this.Proxy.Level, binStream);
            BinarySerializer.ToStream(this.Proxy.Logger, binStream);
            BinarySerializer.ToStream(this.Proxy.Message, binStream);
            BinarySerializer.ToStream(this.Proxy.Thread, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                DateTime tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Date = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Exception = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Level = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Logger = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Message = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Thread = tmp;
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
            XmlStreamer.ToStream(this.Proxy.Date, xml, "Date", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Exception, xml, "Exception", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Level, xml, "Level", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Logger, xml, "Logger", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Message, xml, "Message", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Thread, xml, "Thread", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                DateTime tmp = this.Proxy.Date;
                XmlStreamer.FromStream(ref tmp, xml, "Date", "Kistl.App.Base");
                this.Proxy.Date = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Exception;
                XmlStreamer.FromStream(ref tmp, xml, "Exception", "Kistl.App.Base");
                this.Proxy.Exception = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Level;
                XmlStreamer.FromStream(ref tmp, xml, "Level", "Kistl.App.Base");
                this.Proxy.Level = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Logger;
                XmlStreamer.FromStream(ref tmp, xml, "Logger", "Kistl.App.Base");
                this.Proxy.Logger = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Message;
                XmlStreamer.FromStream(ref tmp, xml, "Message", "Kistl.App.Base");
                this.Proxy.Message = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Thread;
                XmlStreamer.FromStream(ref tmp, xml, "Thread", "Kistl.App.Base");
                this.Proxy.Thread = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}