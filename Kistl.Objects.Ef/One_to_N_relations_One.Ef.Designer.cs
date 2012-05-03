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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// The One-Side of the classes for the One_to_N_relations Tests
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="One_to_N_relations_One")]
    [System.Diagnostics.DebuggerDisplay("One_to_N_relations_One")]
    public class One_to_N_relations_OneEfImpl : BaseServerDataObject_EntityFramework, One_to_N_relations_One
    {
        private static readonly Guid _objectClassID = new Guid("e98ca434-19be-4daa-8920-d979a1d98522");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public One_to_N_relations_OneEfImpl()
            : base(null)
        {
        }

        public One_to_N_relations_OneEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// A property to test queries across the Relation
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = _Name = __e.Result;
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
				else 
				{
					SetInitializedProperty("Name");
				}
            }
        }
        private string _Name_store;
        private string _Name {
            get { return _Name_store; }
            set {
                _Name_store = value;
            }
        }
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.One_to_N_relations_One, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.One_to_N_relations_One, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.One_to_N_relations_One, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.One_to_N_relations_One> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_OneSide_connectsTo_NSide
    A: ZeroOrOne One_to_N_relations_One as OneSide
    B: ZeroOrMore One_to_N_relations_N as NSide
    Preferred Storage: MergeIntoB
    */
        // object list property
        // object list property
           // Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.One_to_N_relations_N> NSide
        {
            get
            {
                if (_NSide == null)
                {
                    _NSide = new EntityCollectionWrapper<Kistl.App.Test.One_to_N_relations_N, Kistl.App.Test.One_to_N_relations_NEfImpl>(
                            this.Context, NSideImpl,
                            () => this.NotifyPropertyChanging("NSide", null, null, null),
                            () => { this.NotifyPropertyChanged("NSide", null, null, null); if(OnNSide_PostSetter != null && IsAttached) OnNSide_PostSetter(this); },
                            (item) => item.NotifyPropertyChanging("OneSide", null, null, null),
                            (item) => item.NotifyPropertyChanged("OneSide", null, null, null));
                }
                return _NSide;
            }
        }
    
        [EdmRelationshipNavigationProperty("Model", "FK_OneSide_connectsTo_NSide", "NSide")]
        public EntityCollection<Kistl.App.Test.One_to_N_relations_NEfImpl> NSideImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.One_to_N_relations_NEfImpl>(
                        "Model.FK_OneSide_connectsTo_NSide",
                        "NSide");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Test.One_to_N_relations_N, Kistl.App.Test.One_to_N_relations_NEfImpl> _NSide;


public static event PropertyListChangedHandler<Kistl.App.Test.One_to_N_relations_One> OnNSide_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.One_to_N_relations_One> OnNSide_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(One_to_N_relations_One);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (One_to_N_relations_One)obj;
            var otherImpl = (One_to_N_relations_OneEfImpl)obj;
            var me = (One_to_N_relations_One)this;

            me.Name = other.Name;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
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
                    // else
                    new PropertyDescriptorEfImpl<One_to_N_relations_One, string>(
                        lazyCtx,
                        new Guid("eea22954-2845-4b34-a721-358469fd0740"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<One_to_N_relations_One, ICollection<Kistl.App.Test.One_to_N_relations_N>>(
                        lazyCtx,
                        new Guid("00c825ba-6df2-4739-8074-2a85aae274a4"),
                        "NSide",
                        null,
                        obj => obj.NSide,
                        null, // lists are read-only properties
                        obj => OnNSide_IsValid), 
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
        [EventBasedMethod("OnToString_One_to_N_relations_One")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_One_to_N_relations_One != null)
            {
                OnToString_One_to_N_relations_One(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<One_to_N_relations_One> OnToString_One_to_N_relations_One;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_One_to_N_relations_One")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_One_to_N_relations_One != null)
            {
                OnObjectIsValid_One_to_N_relations_One(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<One_to_N_relations_One> OnObjectIsValid_One_to_N_relations_One;

        [EventBasedMethod("OnNotifyPreSave_One_to_N_relations_One")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_One_to_N_relations_One != null) OnNotifyPreSave_One_to_N_relations_One(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_One> OnNotifyPreSave_One_to_N_relations_One;

        [EventBasedMethod("OnNotifyPostSave_One_to_N_relations_One")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_One_to_N_relations_One != null) OnNotifyPostSave_One_to_N_relations_One(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_One> OnNotifyPostSave_One_to_N_relations_One;

        [EventBasedMethod("OnNotifyCreated_One_to_N_relations_One")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_One_to_N_relations_One != null) OnNotifyCreated_One_to_N_relations_One(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_One> OnNotifyCreated_One_to_N_relations_One;

        [EventBasedMethod("OnNotifyDeleting_One_to_N_relations_One")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_One_to_N_relations_One != null) OnNotifyDeleting_One_to_N_relations_One(this);
            NSide.Clear();
        }
        public static event ObjectEventHandler<One_to_N_relations_One> OnNotifyDeleting_One_to_N_relations_One;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);

                }
				else 
				{
					SetInitializedProperty("ID");
				}
            }
        }
        private int _ID;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            this._Name = binStream.ReadString();
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