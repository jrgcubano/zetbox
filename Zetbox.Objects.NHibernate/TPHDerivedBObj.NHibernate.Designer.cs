// <autogenerated/>

namespace Zetbox.App.Test
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
    /// TPH derived object named &quot;B&quot;
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TPHDerivedBObj")]
    public class TPHDerivedBObjNHibernateImpl : Zetbox.App.Test.TPHBaseObjNHibernateImpl, TPHDerivedBObj
    {
        private static readonly Guid _objectClassID = new Guid("fffa3cf5-af12-43ec-861c-dff618aa8fb8");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public TPHDerivedBObjNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public TPHDerivedBObjNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new TPHDerivedBObjProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TPHDerivedBObjNHibernateImpl(Func<IFrozenContext> lazyCtx, TPHDerivedBObjProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly TPHDerivedBObjProxy Proxy;

        /// <summary>
        /// Not the &quot;good old BSTR&quot; from MS Com Objects - just a string called B
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string BString
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.BString;
                if (OnBString_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnBString_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.BString != value)
                {
                    var __oldValue = Proxy.BString;
                    var __newValue = value;
                    if (OnBString_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnBString_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BString", __oldValue, __newValue);
                    Proxy.BString = __newValue;
                    NotifyPropertyChanged("BString", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnBString_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnBString_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("BString");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHDerivedBObj, string> OnBString_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHDerivedBObj, string> OnBString_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHDerivedBObj, string> OnBString_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHDerivedBObj> OnBString_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(TPHDerivedBObj);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TPHDerivedBObj)obj;
            var otherImpl = (TPHDerivedBObjNHibernateImpl)obj;
            var me = (TPHDerivedBObj)this;

            me.BString = other.BString;
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
                case "BString":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
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
                    new PropertyDescriptorNHibernateImpl<TPHDerivedBObj, string>(
                        lazyCtx,
                        new Guid("53eb4787-b8e4-4b28-9746-27166857a566"),
                        "BString",
                        null,
                        obj => obj.BString,
                        (obj, val) => obj.BString = val,
						obj => OnBString_IsValid), 
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
        [EventBasedMethod("OnToString_TPHDerivedBObj")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TPHDerivedBObj != null)
            {
                OnToString_TPHDerivedBObj(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TPHDerivedBObj> OnToString_TPHDerivedBObj;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TPHDerivedBObj")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TPHDerivedBObj != null)
            {
                OnObjectIsValid_TPHDerivedBObj(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TPHDerivedBObj> OnObjectIsValid_TPHDerivedBObj;

        [EventBasedMethod("OnNotifyPreSave_TPHDerivedBObj")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_TPHDerivedBObj != null) OnNotifyPreSave_TPHDerivedBObj(this);
        }
        public static event ObjectEventHandler<TPHDerivedBObj> OnNotifyPreSave_TPHDerivedBObj;

        [EventBasedMethod("OnNotifyPostSave_TPHDerivedBObj")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TPHDerivedBObj != null) OnNotifyPostSave_TPHDerivedBObj(this);
        }
        public static event ObjectEventHandler<TPHDerivedBObj> OnNotifyPostSave_TPHDerivedBObj;

        [EventBasedMethod("OnNotifyCreated_TPHDerivedBObj")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("BString");
            base.NotifyCreated();
            if (OnNotifyCreated_TPHDerivedBObj != null) OnNotifyCreated_TPHDerivedBObj(this);
        }
        public static event ObjectEventHandler<TPHDerivedBObj> OnNotifyCreated_TPHDerivedBObj;

        [EventBasedMethod("OnNotifyDeleting_TPHDerivedBObj")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TPHDerivedBObj != null) OnNotifyDeleting_TPHDerivedBObj(this);


        }
        public static event ObjectEventHandler<TPHDerivedBObj> OnNotifyDeleting_TPHDerivedBObj;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class TPHDerivedBObjProxy
            : Zetbox.App.Test.TPHBaseObjNHibernateImpl.TPHBaseObjProxy
        {
            public TPHDerivedBObjProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(TPHDerivedBObjNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(TPHDerivedBObjProxy); } }

            public virtual string BString { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.BString);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.BString = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this.Proxy.BString, xml, "BString", "Zetbox.App.Test");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Test|BString":
                this.Proxy.BString = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}