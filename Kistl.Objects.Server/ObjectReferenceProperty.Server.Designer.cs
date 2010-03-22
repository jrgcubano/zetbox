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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectReferenceProperty")]
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceProperty")]
    public class ObjectReferenceProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, ObjectReferenceProperty
    {
    
		public ObjectReferenceProperty__Implementation__()
		{
        }


        /// <summary>
        /// Whether or not this reference should be loaded eagerly
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool EagerLoading
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _EagerLoading;
                if (OnEagerLoading_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnEagerLoading_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_EagerLoading != value)
                {
                    var __oldValue = _EagerLoading;
                    var __newValue = value;
                    if(OnEagerLoading_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("EagerLoading", __oldValue, __newValue);
                    _EagerLoading = __newValue;
                    NotifyPropertyChanged("EagerLoading", __oldValue, __newValue);
                    if(OnEagerLoading_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _EagerLoading;
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PostSetter;

        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
    /*
    Relation: FK_RelationEnd_has_Navigator
    A: ZeroOrOne RelationEnd as RelationEnd
    B: ZeroOrOne ObjectReferenceProperty as Navigator
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd RelationEnd
        {
            get
            {
                return RelationEnd__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_RelationEnd;
        private Guid? _fk_guid_RelationEnd = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_RelationEnd_has_Navigator", "RelationEnd")]
        public Kistl.App.Base.RelationEnd__Implementation__ RelationEnd__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_RelationEnd_has_Navigator",
                        "RelationEnd");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnRelationEnd_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
					OnRelationEnd_Getter(this, e);
					__value = (Kistl.App.Base.RelationEnd__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_RelationEnd_has_Navigator",
                        "RelationEnd");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.RelationEnd __oldValue = (Kistl.App.Base.RelationEnd)r.Value;
                Kistl.App.Base.RelationEnd __newValue = (Kistl.App.Base.RelationEnd)value;

                if(OnRelationEnd_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnRelationEnd_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)__newValue;
                if(OnRelationEnd_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
					OnRelationEnd_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PostSetter;

        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetIsList_ObjectReferenceProperty")]
		public virtual bool GetIsList() 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnGetIsList_ObjectReferenceProperty != null)
            {
                OnGetIsList_ObjectReferenceProperty(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectReferenceProperty.GetIsList");
            }
            return e.Result;
        }
		public delegate void GetIsList_Handler<T>(T obj, MethodReturnEventArgs<bool> ret);
		public static event GetIsList_Handler<ObjectReferenceProperty> OnGetIsList_ObjectReferenceProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_ObjectReferenceProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ObjectReferenceProperty != null)
            {
                OnGetPropertyType_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public static event GetPropertyType_Handler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_ObjectReferenceProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public static event GetPropertyTypeString_Handler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ObjectReferenceProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ObjectReferenceProperty)obj;
			var otherImpl = (ObjectReferenceProperty__Implementation__)obj;
			var me = (ObjectReferenceProperty)this;

			me.EagerLoading = other.EagerLoading;
			this._fk_RelationEnd = otherImpl._fk_RelationEnd;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceProperty != null)
            {
                OnToString_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;

        [EventBasedMethod("OnPreSave_ObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceProperty != null) OnPreSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_ObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceProperty != null) OnPostSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;

        [EventBasedMethod("OnCreated_ObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectReferenceProperty != null) OnCreated_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnCreated_ObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_ObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectReferenceProperty != null) OnDeleting_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnDeleting_ObjectReferenceProperty;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<ObjectReferenceProperty__Implementation__, bool>(
				new Guid("373f0036-42d6-41e2-a2a4-74462537f426"),
				"EagerLoading",
				null,
				obj => obj.EagerLoading,
				(obj, val) => obj.EagerLoading = val),
			// else
			new CustomPropertyDescriptor<ObjectReferenceProperty__Implementation__, Kistl.App.Base.RelationEnd>(
				new Guid("63ba109d-92c6-4ced-980b-0a52aabfaec0"),
				"RelationEnd",
				null,
				obj => obj.RelationEnd,
				(obj, val) => obj.RelationEnd = val),
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_RelationEnd.HasValue)
				RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_RelationEnd.Value);
			else if (_fk_RelationEnd.HasValue)
				RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value);
			else
				RelationEnd__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._EagerLoading, binStream);
            BinarySerializer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._EagerLoading, binStream);
            BinarySerializer.FromStream(out this._fk_RelationEnd, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ExportGuid : (Guid?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

#endregion

    }


}