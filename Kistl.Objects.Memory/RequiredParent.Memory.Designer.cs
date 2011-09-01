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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Testclass for the required_parent tests: parent
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("RequiredParent")]
    public class RequiredParentMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, RequiredParent
    {
        [Obsolete]
        public RequiredParentMemoryImpl()
            : base(null)
        {
        }

        public RequiredParentMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // Kistl.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.RequiredParentChild> Children
        {
            get
            {
                if (_Children == null)
                {
                    List<Kistl.App.Test.RequiredParentChild> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
                        serverList = Context.GetListOf<Kistl.App.Test.RequiredParentChild>(this, "Children");
                    }
                    else
                    {
                        serverList = new List<Kistl.App.Test.RequiredParentChild>();
                    }
    
                    _Children = new OneNRelationList<Kistl.App.Test.RequiredParentChild>(
                        "Parent",
                        null,
                        this,
                        () => { this.NotifyPropertyChanged("Children", null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); },
                        serverList);
                }
                return _Children;
            }
        }
    
        private OneNRelationList<Kistl.App.Test.RequiredParentChild> _Children;

public static event PropertyListChangedHandler<Kistl.App.Test.RequiredParent> OnChildren_PostSetter;

        /// <summary>
        /// dummy property
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
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
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParent, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParent, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParent, string> OnName_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(RequiredParent);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RequiredParent)obj;
            var otherImpl = (RequiredParentMemoryImpl)obj;
            var me = (RequiredParent)this;

            me.Name = other.Name;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<RequiredParentMemoryImpl, ICollection<Kistl.App.Test.RequiredParentChild>>(
                        lazyCtx,
                        new Guid("e452deb2-1f35-4b7c-9adc-1f904dfbfc6d"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorMemoryImpl<RequiredParentMemoryImpl, string>(
                        lazyCtx,
                        new Guid("22abc57e-581f-49f1-8eff-747e126a6480"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val),
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

        [EventBasedMethod("OnPreSave_RequiredParent")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_RequiredParent != null) OnPreSave_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnPreSave_RequiredParent;

        [EventBasedMethod("OnPostSave_RequiredParent")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_RequiredParent != null) OnPostSave_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnPostSave_RequiredParent;

        [EventBasedMethod("OnCreated_RequiredParent")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_RequiredParent != null) OnCreated_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnCreated_RequiredParent;

        [EventBasedMethod("OnDeleting_RequiredParent")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_RequiredParent != null) OnDeleting_RequiredParent(this);
        }
        public static event ObjectEventHandler<RequiredParent> OnDeleting_RequiredParent;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._Name, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Test");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}