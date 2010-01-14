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
    /// Metadefinition Object for Struct Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StructProperty")]
    [System.Diagnostics.DebuggerDisplay("StructProperty")]
    public class StructProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, StructProperty
    {
    
		public StructProperty__Implementation__()
		{
        }


        /// <summary>
        /// Whether or not the list has a persistent ordering of elements
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool HasPersistentOrder
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _HasPersistentOrder;
                if (OnHasPersistentOrder_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnHasPersistentOrder_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_HasPersistentOrder != value)
                {
                    var __oldValue = _HasPersistentOrder;
                    var __newValue = value;
                    if(OnHasPersistentOrder_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("HasPersistentOrder", __oldValue, __newValue);
                    _HasPersistentOrder = __newValue;
                    NotifyPropertyChanged("HasPersistentOrder", __oldValue, __newValue);
                    if(OnHasPersistentOrder_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _HasPersistentOrder;
		public static event PropertyGetterHandler<Kistl.App.Base.StructProperty, bool> OnHasPersistentOrder_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StructProperty, bool> OnHasPersistentOrder_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StructProperty, bool> OnHasPersistentOrder_PostSetter;

        /// <summary>
        /// Whether or not this struct property is list valued
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool IsList
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsList;
                if (OnIsList_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsList_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsList != value)
                {
                    var __oldValue = _IsList;
                    var __newValue = value;
                    if(OnIsList_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsList", __oldValue, __newValue);
                    _IsList = __newValue;
                    NotifyPropertyChanged("IsList", __oldValue, __newValue);
                    if(OnIsList_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsList;
		public static event PropertyGetterHandler<Kistl.App.Base.StructProperty, bool> OnIsList_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StructProperty, bool> OnIsList_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StructProperty, bool> OnIsList_PostSetter;

        /// <summary>
        /// Definition of this Struct
        /// </summary>
    /*
    Relation: FK_StructProperty_has_StructDefinition
    A: ZeroOrMore StructProperty as StructProperty
    B: ZeroOrOne Struct as StructDefinition
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Struct StructDefinition
        {
            get
            {
                return StructDefinition__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)value;
            }
        }
        
        private int? _fk_StructDefinition;
        private Guid? _fk_guid_StructDefinition = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_StructProperty_has_StructDefinition", "StructDefinition")]
        public Kistl.App.Base.Struct__Implementation__ StructDefinition__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Struct__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Struct__Implementation__>(
                        "Model.FK_StructProperty_has_StructDefinition",
                        "StructDefinition");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnStructDefinition_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Struct>(__value);
					OnStructDefinition_Getter(this, e);
					__value = (Kistl.App.Base.Struct__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Struct__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Struct__Implementation__>(
                        "Model.FK_StructProperty_has_StructDefinition",
                        "StructDefinition");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Struct __oldValue = (Kistl.App.Base.Struct)r.Value;
                Kistl.App.Base.Struct __newValue = (Kistl.App.Base.Struct)value;

                if(OnStructDefinition_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Struct>(__oldValue, __newValue);
					OnStructDefinition_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Struct__Implementation__)__newValue;
                if(OnStructDefinition_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Struct>(__oldValue, __newValue);
					OnStructDefinition_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_PostSetter;

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_StructProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_StructProperty != null)
            {
                OnGetPropertyType_StructProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public static event GetPropertyType_Handler<StructProperty> OnGetPropertyType_StructProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_StructProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_StructProperty != null)
            {
                OnGetPropertyTypeString_StructProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public static event GetPropertyTypeString_Handler<StructProperty> OnGetPropertyTypeString_StructProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StructProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StructProperty)obj;
			var otherImpl = (StructProperty__Implementation__)obj;
			var me = (StructProperty)this;

			me.HasPersistentOrder = other.HasPersistentOrder;
			me.IsList = other.IsList;
			this._fk_StructDefinition = otherImpl._fk_StructDefinition;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_StructProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StructProperty != null)
            {
                OnToString_StructProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StructProperty> OnToString_StructProperty;

        [EventBasedMethod("OnPreSave_StructProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StructProperty != null) OnPreSave_StructProperty(this);
        }
        public static event ObjectEventHandler<StructProperty> OnPreSave_StructProperty;

        [EventBasedMethod("OnPostSave_StructProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StructProperty != null) OnPostSave_StructProperty(this);
        }
        public static event ObjectEventHandler<StructProperty> OnPostSave_StructProperty;

        [EventBasedMethod("OnCreated_StructProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StructProperty != null) OnCreated_StructProperty(this);
        }
        public static event ObjectEventHandler<StructProperty> OnCreated_StructProperty;

        [EventBasedMethod("OnDeleting_StructProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StructProperty != null) OnDeleting_StructProperty(this);
        }
        public static event ObjectEventHandler<StructProperty> OnDeleting_StructProperty;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "HasPersistentOrder":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("7c806f25-d85e-4d9f-b082-0cdaa7b60790")).Constraints
						.Where(c => !c.IsValid(this, this.HasPersistentOrder))
						.Select(c => c.GetErrorText(this, this.HasPersistentOrder))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsList":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("8a861113-a48a-40c5-bdec-6ceafef86f48")).Constraints
						.Where(c => !c.IsValid(this, this.IsList))
						.Select(c => c.GetErrorText(this, this.IsList))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "StructDefinition":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("0d78c157-c106-4728-9af2-7992da7c935d")).Constraints
						.Where(c => !c.IsValid(this, this.StructDefinition))
						.Select(c => c.GetErrorText(this, this.StructDefinition))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_StructDefinition.HasValue)
				StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Struct>(_fk_guid_StructDefinition.Value);
			else if (_fk_StructDefinition.HasValue)
				StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)Context.Find<Kistl.App.Base.Struct>(_fk_StructDefinition.Value);
			else
				StructDefinition__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._HasPersistentOrder, binStream);
            BinarySerializer.ToStream(this._IsList, binStream);
            BinarySerializer.ToStream(StructDefinition != null ? StructDefinition.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._HasPersistentOrder, binStream);
            BinarySerializer.FromStream(out this._IsList, binStream);
            BinarySerializer.FromStream(out this._fk_StructDefinition, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.ToStream(StructDefinition != null ? StructDefinition.ID : (int?)null, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_StructDefinition, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(StructDefinition != null ? StructDefinition.ExportGuid : (Guid?)null, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_StructDefinition, xml, "StructDefinition", "Kistl.App.Base");
        }

#endregion

    }


}