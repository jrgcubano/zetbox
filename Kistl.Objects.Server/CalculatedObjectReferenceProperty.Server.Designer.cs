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
    /// a object reference that is calculated from the contents of the containing class
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CalculatedObjectReferenceProperty")]
    [System.Diagnostics.DebuggerDisplay("CalculatedObjectReferenceProperty")]
    public class CalculatedObjectReferenceProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, CalculatedObjectReferenceProperty
    {
    
		public CalculatedObjectReferenceProperty__Implementation__()
		{
        }


        /// <summary>
        /// The properties on which the calculation depends. This is used to propagate change notifications.
        /// </summary>
    /*
    Relation: FK_CalculatedReference_dependsOn_InputProperties
    A: ZeroOrMore CalculatedObjectReferenceProperty as CalculatedReference
    B: ZeroOrMore Property as InputProperties
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Property> Inputs
        {
            get
            {
                if (_InputsWrapper == null)
                {
                    _InputsWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry__Implementation__>(
                            this,
                            Inputs__Implementation__);
                }
                return _InputsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_CalculatedReference_dependsOn_InputProperties_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry__Implementation__> Inputs__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry__Implementation__>(
                        "Model.FK_CalculatedReference_dependsOn_InputProperties_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntry__Implementation__> _InputsWrapper;


        /// <summary>
        /// the referenced class of objects
        /// </summary>
    /*
    Relation: FK_CalculatedReference_references_ReferencedClass
    A: ZeroOrMore CalculatedObjectReferenceProperty as CalculatedReference
    B: One ObjectClass as ReferencedClass
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ReferencedClass
        {
            get
            {
                return ReferencedClass__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                ReferencedClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        private int? _fk_ReferencedClass;
        private Guid? _fk_guid_ReferencedClass = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_CalculatedReference_references_ReferencedClass", "ReferencedClass")]
        public Kistl.App.Base.ObjectClass__Implementation__ ReferencedClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_CalculatedReference_references_ReferencedClass",
                        "ReferencedClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnReferencedClass_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
					OnReferencedClass_Getter(this, e);
					__value = (Kistl.App.Base.ObjectClass__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_CalculatedReference_references_ReferencedClass",
                        "ReferencedClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.ObjectClass __oldValue = (Kistl.App.Base.ObjectClass)r.Value;
                Kistl.App.Base.ObjectClass __newValue = (Kistl.App.Base.ObjectClass)value;

                if(OnReferencedClass_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
					OnReferencedClass_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.ObjectClass__Implementation__)__newValue;
                if(OnReferencedClass_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
					OnReferencedClass_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PostSetter;

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_CalculatedObjectReferenceProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyType_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public static event GetPropertyType_Handler<CalculatedObjectReferenceProperty> OnGetPropertyType_CalculatedObjectReferenceProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_CalculatedObjectReferenceProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public static event GetPropertyTypeString_Handler<CalculatedObjectReferenceProperty> OnGetPropertyTypeString_CalculatedObjectReferenceProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(CalculatedObjectReferenceProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (CalculatedObjectReferenceProperty)obj;
			var otherImpl = (CalculatedObjectReferenceProperty__Implementation__)obj;
			var me = (CalculatedObjectReferenceProperty)this;

			this._fk_ReferencedClass = otherImpl._fk_ReferencedClass;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CalculatedObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CalculatedObjectReferenceProperty != null)
            {
                OnToString_CalculatedObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CalculatedObjectReferenceProperty> OnToString_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnPreSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CalculatedObjectReferenceProperty != null) OnPreSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPreSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CalculatedObjectReferenceProperty != null) OnPostSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPostSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnCreated_CalculatedObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CalculatedObjectReferenceProperty != null) OnCreated_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnCreated_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_CalculatedObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CalculatedObjectReferenceProperty != null) OnDeleting_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnDeleting_CalculatedObjectReferenceProperty;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<CalculatedObjectReferenceProperty__Implementation__, ICollection<Kistl.App.Base.Property>>(
				new Guid("bfda6511-087d-4381-9780-1f76f3abcffe"),
				"Inputs",
				null,
				obj => obj.Inputs,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<CalculatedObjectReferenceProperty__Implementation__, Kistl.App.Base.ObjectClass>(
				new Guid("cd62d769-0752-4a72-832f-5935ece1198b"),
				"ReferencedClass",
				null,
				obj => obj.ReferencedClass,
				(obj, val) => obj.ReferencedClass = val),
			// rel: CalculatedReference references ReferencedClass (6c207cc8-d6a2-49b5-81f3-743d261b7411)
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

			if (_fk_guid_ReferencedClass.HasValue)
				ReferencedClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ReferencedClass.Value);
			else if (_fk_ReferencedClass.HasValue)
				ReferencedClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ReferencedClass.Value);
			else
				ReferencedClass__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
			{
				foreach(var obj in Inputs__Implementation__)
				{
					if (auxObjects != null) {
						auxObjects.Add(obj);
					}
				}
			}
            BinarySerializer.ToStream(ReferencedClass != null ? ReferencedClass.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(ReferencedClass);
			}
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_ReferencedClass, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(ReferencedClass != null ? ReferencedClass.ID : (int?)null, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(ReferencedClass != null ? ReferencedClass.ExportGuid : (Guid?)null, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
        }

#endregion

    }


}