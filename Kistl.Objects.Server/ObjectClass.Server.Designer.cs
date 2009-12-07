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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for ObjectClasses.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectClass")]
    [System.Diagnostics.DebuggerDisplay("ObjectClass")]
    public class ObjectClass__Implementation__ : Kistl.App.Base.DataType__Implementation__, ObjectClass
    {
    
		public ObjectClass__Implementation__()
		{
        }


        /// <summary>
        /// Pointer auf die Basisklasse
        /// </summary>
    /*
    Relation: FK_BaseObjectClass_has_SubClasses
    A: ZeroOrOne ObjectClass as BaseObjectClass
    B: ZeroOrMore ObjectClass as SubClasses
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass BaseObjectClass
        {
            get
            {
                return BaseObjectClass__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                BaseObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        private int? _fk_BaseObjectClass;
        private Guid? _fk_guid_BaseObjectClass = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_BaseObjectClass_has_SubClasses", "BaseObjectClass")]
        public Kistl.App.Base.ObjectClass__Implementation__ BaseObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_BaseObjectClass_has_SubClasses",
                        "BaseObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnBaseObjectClass_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
					OnBaseObjectClass_Getter(this, e);
					__value = (Kistl.App.Base.ObjectClass__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_BaseObjectClass_has_SubClasses",
                        "BaseObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.ObjectClass __oldValue = (Kistl.App.Base.ObjectClass)r.Value;
                Kistl.App.Base.ObjectClass __newValue = (Kistl.App.Base.ObjectClass)value;

                if(OnBaseObjectClass_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
					OnBaseObjectClass_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.ObjectClass__Implementation__)__newValue;
                if(OnBaseObjectClass_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
					OnBaseObjectClass_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass> OnBaseObjectClass_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass> OnBaseObjectClass_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass> OnBaseObjectClass_PostSetter;
        /// <summary>
        /// The default PresentableModel to use for this ObjectClass
        /// </summary>
    /*
    Relation: FK_Presentable_has_DefaultPresentableModelDescriptor
    A: ZeroOrMore ObjectClass as Presentable
    B: One PresentableModelDescriptor as DefaultPresentableModelDescriptor
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.PresentableModelDescriptor DefaultPresentableModelDescriptor
        {
            get
            {
                return DefaultPresentableModelDescriptor__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                DefaultPresentableModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)value;
            }
        }
        
        private int? _fk_DefaultPresentableModelDescriptor;
        private Guid? _fk_guid_DefaultPresentableModelDescriptor = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Presentable_has_DefaultPresentableModelDescriptor", "DefaultPresentableModelDescriptor")]
        public Kistl.App.GUI.PresentableModelDescriptor__Implementation__ DefaultPresentableModelDescriptor__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_Presentable_has_DefaultPresentableModelDescriptor",
                        "DefaultPresentableModelDescriptor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnDefaultPresentableModelDescriptor_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.GUI.PresentableModelDescriptor>(__value);
					OnDefaultPresentableModelDescriptor_Getter(this, e);
					__value = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_Presentable_has_DefaultPresentableModelDescriptor",
                        "DefaultPresentableModelDescriptor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.GUI.PresentableModelDescriptor __oldValue = (Kistl.App.GUI.PresentableModelDescriptor)r.Value;
                Kistl.App.GUI.PresentableModelDescriptor __newValue = (Kistl.App.GUI.PresentableModelDescriptor)value;

                if(OnDefaultPresentableModelDescriptor_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.PresentableModelDescriptor>(__oldValue, __newValue);
					OnDefaultPresentableModelDescriptor_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)__newValue;
                if(OnDefaultPresentableModelDescriptor_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.PresentableModelDescriptor>(__oldValue, __newValue);
					OnDefaultPresentableModelDescriptor_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.GUI.PresentableModelDescriptor> OnDefaultPresentableModelDescriptor_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.GUI.PresentableModelDescriptor> OnDefaultPresentableModelDescriptor_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectClass, Kistl.App.GUI.PresentableModelDescriptor> OnDefaultPresentableModelDescriptor_PostSetter;
        /// <summary>
        /// Interfaces der Objektklasse
        /// </summary>
    /*
    Relation: FK_ObjectClass_implements_ImplementsInterfaces
    A: ZeroOrMore ObjectClass as ObjectClass
    B: ZeroOrMore Interface as ImplementsInterfaces
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Interface> ImplementsInterfaces
        {
            get
            {
                if (_ImplementsInterfacesWrapper == null)
                {
                    _ImplementsInterfacesWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.Interface, Kistl.App.Base.ObjectClass_implements_Interface_RelationEntry__Implementation__>(
                            this,
                            ImplementsInterfaces__Implementation__);
                }
                return _ImplementsInterfacesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_ObjectClass_implements_ImplementsInterfaces_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.ObjectClass_implements_Interface_RelationEntry__Implementation__> ImplementsInterfaces__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.ObjectClass_implements_Interface_RelationEntry__Implementation__>(
                        "Model.FK_ObjectClass_implements_ImplementsInterfaces_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.Interface, Kistl.App.Base.ObjectClass_implements_Interface_RelationEntry__Implementation__> _ImplementsInterfacesWrapper;


        /// <summary>
        /// if true then all Instances appear in FozenContext.
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool IsFrozenObject
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsFrozenObject;
                if (OnIsFrozenObject_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsFrozenObject_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsFrozenObject != value)
                {
                    var __oldValue = _IsFrozenObject;
                    var __newValue = value;
                    if(OnIsFrozenObject_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsFrozenObject_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsFrozenObject", __oldValue, __newValue);
                    _IsFrozenObject = __newValue;
                    NotifyPropertyChanged("IsFrozenObject", __oldValue, __newValue);
                    if(OnIsFrozenObject_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsFrozenObject_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsFrozenObject;
		public event PropertyGetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsFrozenObject_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsFrozenObject_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsFrozenObject_PostSetter;
        /// <summary>
        /// Setting this to true marks the instances of this class as &quot;simple.&quot; At first this will only mean that they'll be displayed inline.
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool IsSimpleObject
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsSimpleObject;
                if (OnIsSimpleObject_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsSimpleObject_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsSimpleObject != value)
                {
                    var __oldValue = _IsSimpleObject;
                    var __newValue = value;
                    if(OnIsSimpleObject_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsSimpleObject_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsSimpleObject", __oldValue, __newValue);
                    _IsSimpleObject = __newValue;
                    NotifyPropertyChanged("IsSimpleObject", __oldValue, __newValue);
                    if(OnIsSimpleObject_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsSimpleObject_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsSimpleObject;
		public event PropertyGetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsSimpleObject_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsSimpleObject_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectClass, bool> OnIsSimpleObject_PostSetter;
        /// <summary>
        /// Liste der vererbten Klassen
        /// </summary>
    /*
    Relation: FK_BaseObjectClass_has_SubClasses
    A: ZeroOrOne ObjectClass as BaseObjectClass
    B: ZeroOrMore ObjectClass as SubClasses
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.ObjectClass> SubClasses
        {
            get
            {
                if (_SubClassesWrapper == null)
                {
                    _SubClassesWrapper = new EntityCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass__Implementation__>(
                            this.Context, SubClasses__Implementation__);
                }
                return _SubClassesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_BaseObjectClass_has_SubClasses", "SubClasses")]
        public EntityCollection<Kistl.App.Base.ObjectClass__Implementation__> SubClasses__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_BaseObjectClass_has_SubClasses",
                        "SubClasses");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass__Implementation__> _SubClassesWrapper;



        /// <summary>
        /// Tabellenname in der Datenbank
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string TableName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TableName;
                if (OnTableName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTableName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TableName != value)
                {
                    var __oldValue = _TableName;
                    var __newValue = value;
                    if(OnTableName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTableName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TableName", __oldValue, __newValue);
                    _TableName = __newValue;
                    NotifyPropertyChanged("TableName", __oldValue, __newValue);
                    if(OnTableName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTableName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _TableName;
		public event PropertyGetterHandler<Kistl.App.Base.ObjectClass, string> OnTableName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectClass, string> OnTableName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectClass, string> OnTableName_PostSetter;
        /// <summary>
        /// Creates, if needed, all default  Methods
        /// </summary>
		[EventBasedMethod("OnCreateDefaultMethods_ObjectClass")]
		public virtual void CreateDefaultMethods() 
		{
            // base.CreateDefaultMethods();
            if (OnCreateDefaultMethods_ObjectClass != null)
            {
				OnCreateDefaultMethods_ObjectClass(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on ObjectClass.CreateDefaultMethods");
			}
        }
		public delegate void CreateDefaultMethods_Handler<T>(T obj);
		public event CreateDefaultMethods_Handler<ObjectClass> OnCreateDefaultMethods_ObjectClass;



        /// <summary>
        /// Creates a new Method for this class
        /// </summary>
		[EventBasedMethod("OnCreateMethod_ObjectClass")]
		public virtual Kistl.App.Base.Method CreateMethod() 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Method>();
            if (OnCreateMethod_ObjectClass != null)
            {
                OnCreateMethod_ObjectClass(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectClass.CreateMethod");
            }
            return e.Result;
        }
		public delegate void CreateMethod_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.Method> ret);
		public event CreateMethod_Handler<ObjectClass> OnCreateMethod_ObjectClass;



        /// <summary>
        /// Implements the "Create new Relation" use case
        /// </summary>
		[EventBasedMethod("OnCreateRelation_ObjectClass")]
		public virtual Kistl.App.Base.Relation CreateRelation() 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Relation>();
            if (OnCreateRelation_ObjectClass != null)
            {
                OnCreateRelation_ObjectClass(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectClass.CreateRelation");
            }
            return e.Result;
        }
		public delegate void CreateRelation_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.Relation> ret);
		public event CreateRelation_Handler<ObjectClass> OnCreateRelation_ObjectClass;



        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetDataType_ObjectClass")]
		public override System.Type GetDataType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_ObjectClass != null)
            {
                OnGetDataType_ObjectClass(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
		public event GetDataType_Handler<ObjectClass> OnGetDataType_ObjectClass;



        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetDataTypeString_ObjectClass")]
		public override string GetDataTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_ObjectClass != null)
            {
                OnGetDataTypeString_ObjectClass(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
		public event GetDataTypeString_Handler<ObjectClass> OnGetDataTypeString_ObjectClass;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetInheritedMethods_ObjectClass")]
		public virtual IList<Kistl.App.Base.Method> GetInheritedMethods() 
        {
            var e = new MethodReturnEventArgs<IList<Kistl.App.Base.Method>>();
            if (OnGetInheritedMethods_ObjectClass != null)
            {
                OnGetInheritedMethods_ObjectClass(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectClass.GetInheritedMethods");
            }
            return e.Result;
        }
		public delegate void GetInheritedMethods_Handler<T>(T obj, MethodReturnEventArgs<IList<Kistl.App.Base.Method>> ret);
		public event GetInheritedMethods_Handler<ObjectClass> OnGetInheritedMethods_ObjectClass;



        /// <summary>
        /// Implements all available interfaces as Properties and Methods
        /// </summary>
		[EventBasedMethod("OnImplementInterfaces_ObjectClass")]
		public virtual void ImplementInterfaces() 
		{
            // base.ImplementInterfaces();
            if (OnImplementInterfaces_ObjectClass != null)
            {
				OnImplementInterfaces_ObjectClass(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on ObjectClass.ImplementInterfaces");
			}
        }
		public delegate void ImplementInterfaces_Handler<T>(T obj);
		public event ImplementInterfaces_Handler<ObjectClass> OnImplementInterfaces_ObjectClass;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ObjectClass));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ObjectClass)obj;
			var otherImpl = (ObjectClass__Implementation__)obj;
			var me = (ObjectClass)this;

			me.IsFrozenObject = other.IsFrozenObject;
			me.IsSimpleObject = other.IsSimpleObject;
			me.TableName = other.TableName;
			this._fk_BaseObjectClass = otherImpl._fk_BaseObjectClass;
			this._fk_DefaultPresentableModelDescriptor = otherImpl._fk_DefaultPresentableModelDescriptor;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ObjectClass")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectClass != null)
            {
                OnToString_ObjectClass(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ObjectClass> OnToString_ObjectClass;

        [EventBasedMethod("OnPreSave_ObjectClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectClass != null) OnPreSave_ObjectClass(this);
        }
        public event ObjectEventHandler<ObjectClass> OnPreSave_ObjectClass;

        [EventBasedMethod("OnPostSave_ObjectClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectClass != null) OnPostSave_ObjectClass(this);
        }
        public event ObjectEventHandler<ObjectClass> OnPostSave_ObjectClass;

        [EventBasedMethod("OnCreated_ObjectClass")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectClass != null) OnCreated_ObjectClass(this);
        }
        public event ObjectEventHandler<ObjectClass> OnCreated_ObjectClass;

        [EventBasedMethod("OnDeleting_ObjectClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectClass != null) OnDeleting_ObjectClass(this);
        }
        public event ObjectEventHandler<ObjectClass> OnDeleting_ObjectClass;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "BaseObjectClass":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("ad060d41-bc7a-41b8-a3e3-ec9302c8c714")).Constraints
						.Where(c => !c.IsValid(this, this.BaseObjectClass))
						.Select(c => c.GetErrorText(this, this.BaseObjectClass))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DefaultPresentableModelDescriptor":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("11adedb9-d32a-4da9-b986-0534e65df760")).Constraints
						.Where(c => !c.IsValid(this, this.DefaultPresentableModelDescriptor))
						.Select(c => c.GetErrorText(this, this.DefaultPresentableModelDescriptor))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ImplementsInterfaces":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("a9ec04c2-0807-4d6c-a96a-824d13e5c571")).Constraints
						.Where(c => !c.IsValid(this, this.ImplementsInterfaces))
						.Select(c => c.GetErrorText(this, this.ImplementsInterfaces))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsFrozenObject":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("13c33710-ea02-4621-ad50-294a1f36b07d")).Constraints
						.Where(c => !c.IsValid(this, this.IsFrozenObject))
						.Select(c => c.GetErrorText(this, this.IsFrozenObject))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsSimpleObject":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("edc853d3-0d02-4492-9159-c548c7713e9b")).Constraints
						.Where(c => !c.IsValid(this, this.IsSimpleObject))
						.Select(c => c.GetErrorText(this, this.IsSimpleObject))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "SubClasses":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("0914de6e-966c-46fc-9359-e4da6c3608b1")).Constraints
						.Where(c => !c.IsValid(this, this.SubClasses))
						.Select(c => c.GetErrorText(this, this.SubClasses))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "TableName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("2a5e5111-199c-4dce-8369-ce35ee741568")).Constraints
						.Where(c => !c.IsValid(this, this.TableName))
						.Select(c => c.GetErrorText(this, this.TableName))
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

			if (_fk_guid_BaseObjectClass.HasValue)
				BaseObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_BaseObjectClass.Value);
			else if (_fk_BaseObjectClass.HasValue)
				BaseObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.Find<Kistl.App.Base.ObjectClass>(_fk_BaseObjectClass.Value);
			else
				BaseObjectClass__Implementation__ = null;

			if (_fk_guid_DefaultPresentableModelDescriptor.HasValue)
				DefaultPresentableModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.PresentableModelDescriptor>(_fk_guid_DefaultPresentableModelDescriptor.Value);
			else if (_fk_DefaultPresentableModelDescriptor.HasValue)
				DefaultPresentableModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.Find<Kistl.App.GUI.PresentableModelDescriptor>(_fk_DefaultPresentableModelDescriptor.Value);
			else
				DefaultPresentableModelDescriptor__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(BaseObjectClass != null ? BaseObjectClass.ID : (int?)null, binStream);
            BinarySerializer.ToStream(DefaultPresentableModelDescriptor != null ? DefaultPresentableModelDescriptor.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._IsFrozenObject, binStream);
            BinarySerializer.ToStream(this._IsSimpleObject, binStream);
            BinarySerializer.ToStream(this._TableName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_BaseObjectClass, binStream);
            BinarySerializer.FromStream(out this._fk_DefaultPresentableModelDescriptor, binStream);
            BinarySerializer.FromStream(out this._IsFrozenObject, binStream);
            BinarySerializer.FromStream(out this._IsSimpleObject, binStream);
            BinarySerializer.FromStream(out this._TableName, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(BaseObjectClass != null ? BaseObjectClass.ID : (int?)null, xml, "BaseObjectClass", "Kistl.App.Base");
            XmlStreamer.ToStream(DefaultPresentableModelDescriptor != null ? DefaultPresentableModelDescriptor.ID : (int?)null, xml, "DefaultPresentableModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._IsFrozenObject, xml, "IsFrozenObject", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsSimpleObject, xml, "IsSimpleObject", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._TableName, xml, "TableName", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_BaseObjectClass, xml, "BaseObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_DefaultPresentableModelDescriptor, xml, "DefaultPresentableModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsFrozenObject, xml, "IsFrozenObject", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsSimpleObject, xml, "IsSimpleObject", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._TableName, xml, "TableName", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(BaseObjectClass != null ? BaseObjectClass.ExportGuid : (Guid?)null, xml, "BaseObjectClass", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(DefaultPresentableModelDescriptor != null ? DefaultPresentableModelDescriptor.ExportGuid : (Guid?)null, xml, "DefaultPresentableModelDescriptor", "Kistl.App.GUI");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsFrozenObject, xml, "IsFrozenObject", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsSimpleObject, xml, "IsSimpleObject", "Kistl.App.GUI");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._TableName, xml, "TableName", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_BaseObjectClass, xml, "BaseObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_DefaultPresentableModelDescriptor, xml, "DefaultPresentableModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsFrozenObject, xml, "IsFrozenObject", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsSimpleObject, xml, "IsSimpleObject", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._TableName, xml, "TableName", "Kistl.App.Base");
        }

#endregion

    }


}