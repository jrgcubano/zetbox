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
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PostSetter;

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

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "Parent":
                    __oldValue = _fk_Parent;
                    NotifyPropertyChanging("Parent", __oldValue, __newValue);
                    _fk_Parent = __newValue;
                    NotifyPropertyChanged("Parent", __oldValue, __newValue);
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
                    new PropertyDescriptorEfImpl<RequiredParentChildEfImpl, string>(
                        lazyCtx,
                        new Guid("82dc687e-3915-4f03-9a1f-75e42fcbe7cd"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val),
                    // else
                    new PropertyDescriptorEfImpl<RequiredParentChildEfImpl, Kistl.App.Test.RequiredParent>(
                        lazyCtx,
                        new Guid("09fb9f88-7a59-4dae-8cad-9fbab99f32c3"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val),
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

        [EventBasedMethod("OnPreSave_RequiredParentChild")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_RequiredParentChild != null) OnPreSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnPreSave_RequiredParentChild;

        [EventBasedMethod("OnPostSave_RequiredParentChild")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_RequiredParentChild != null) OnPostSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnPostSave_RequiredParentChild;

        [EventBasedMethod("OnCreated_RequiredParentChild")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_RequiredParentChild != null) OnCreated_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnCreated_RequiredParentChild;

        [EventBasedMethod("OnDeleting_RequiredParentChild")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_RequiredParentChild != null) OnDeleting_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnDeleting_RequiredParentChild;

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
            }
        }
        private int _ID;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._Name, binStream);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Test.RequiredParentEfImpl>("Model.FK_Parent_of_Children", "Parent").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Test.RequiredParentEfImpl>("Model.FK_Parent_of_Children", "Parent").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Parent", "Kistl.App.Test");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.Test");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}