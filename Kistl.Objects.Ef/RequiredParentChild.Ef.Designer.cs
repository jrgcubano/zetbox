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
    /// Testclass for the required_parent tests: child
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="RequiredParentChild")]
    [System.Diagnostics.DebuggerDisplay("RequiredParentChild")]
    public class RequiredParentChildEfImpl : BaseServerDataObject_EntityFramework, RequiredParentChild
    {
        private static readonly Guid _objectClassID = new Guid("3e7f2f55-ff5c-4a13-ba58-74368e9c8780");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public RequiredParentChildEfImpl()
            : base(null)
        {
        }

        public RequiredParentChildEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// dummy property
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
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParentChild> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Parent_of_Children
    A: One RequiredParent as Parent
    B: ZeroOrMore RequiredParentChild as Children
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=_fk_Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Kistl.App.Test.RequiredParent; moduleNamespace=Kistl.App.Test;
        // inverse Navigator=Children; is list;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.RequiredParent Parent
        {
            get { return ParentImpl; }
            set { ParentImpl = (Kistl.App.Test.RequiredParentEfImpl)value; }
        }

        private int? _fk_Parent;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Parent_of_Children", "Parent")]
        public Kistl.App.Test.RequiredParentEfImpl ParentImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Test.RequiredParentEfImpl __value;
                EntityReference<Kistl.App.Test.RequiredParentEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.RequiredParentEfImpl>(
                        "Model.FK_Parent_of_Children",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Test.RequiredParent>(__value);
                    OnParent_Getter(this, e);
                    __value = (Kistl.App.Test.RequiredParentEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Test.RequiredParentEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.RequiredParentEfImpl>(
                        "Model.FK_Parent_of_Children",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Test.RequiredParentEfImpl __oldValue = (Kistl.App.Test.RequiredParentEfImpl)r.Value;
                Kistl.App.Test.RequiredParentEfImpl __newValue = (Kistl.App.Test.RequiredParentEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Children", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Children", null, null, null);
                }

                if (OnParent_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Test.RequiredParent>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Kistl.App.Test.RequiredParentEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Test.RequiredParentEfImpl)__newValue;

                if (OnParent_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Test.RequiredParent>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("Children", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("Children", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParentChild> OnParent_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(RequiredParentChild);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RequiredParentChild)obj;
            var otherImpl = (RequiredParentChildEfImpl)obj;
            var me = (RequiredParentChild)this;

            me.Name = other.Name;
            this._fk_Parent = otherImpl._fk_Parent;
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
                case "Parent":
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

            if (_fk_Parent.HasValue)
                ParentImpl = (Kistl.App.Test.RequiredParentEfImpl)Context.Find<Kistl.App.Test.RequiredParent>(_fk_Parent.Value);
            else
                ParentImpl = null;
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
                    new PropertyDescriptorEfImpl<RequiredParentChild, string>(
                        lazyCtx,
                        new Guid("82dc687e-3915-4f03-9a1f-75e42fcbe7cd"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<RequiredParentChild, Kistl.App.Test.RequiredParent>(
                        lazyCtx,
                        new Guid("09fb9f88-7a59-4dae-8cad-9fbab99f32c3"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val,
						obj => OnParent_IsValid), 
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
        [EventBasedMethod("OnToString_RequiredParentChild")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RequiredParentChild != null)
            {
                OnToString_RequiredParentChild(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RequiredParentChild> OnToString_RequiredParentChild;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_RequiredParentChild")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_RequiredParentChild != null)
            {
                OnObjectIsValid_RequiredParentChild(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<RequiredParentChild> OnObjectIsValid_RequiredParentChild;

        [EventBasedMethod("OnNotifyPreSave_RequiredParentChild")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_RequiredParentChild != null) OnNotifyPreSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyPreSave_RequiredParentChild;

        [EventBasedMethod("OnNotifyPostSave_RequiredParentChild")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_RequiredParentChild != null) OnNotifyPostSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyPostSave_RequiredParentChild;

        [EventBasedMethod("OnNotifyCreated_RequiredParentChild")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            SetNotInitializedProperty("Parent");
            base.NotifyCreated();
            if (OnNotifyCreated_RequiredParentChild != null) OnNotifyCreated_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyCreated_RequiredParentChild;

        [EventBasedMethod("OnNotifyDeleting_RequiredParentChild")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_RequiredParentChild != null) OnNotifyDeleting_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyDeleting_RequiredParentChild;

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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Test.RequiredParentEfImpl>("Model.FK_Parent_of_Children", "Parent").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            this._Name = binStream.ReadString();
            binStream.Read(out this._fk_Parent);
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