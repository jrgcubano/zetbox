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
    /// This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TypeRef")]
    [System.Diagnostics.DebuggerDisplay("TypeRef")]
    public class TypeRef__Implementation__ : BaseServerDataObject_EntityFramework, TypeRef, Kistl.API.IExportableInternal
    {
    
		public TypeRef__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// The assembly containing the referenced Type.
        /// </summary>
    /*
    Relation: FK_TypeRef_has_Assembly
    A: ZeroOrMore TypeRef as TypeRef
    B: ZeroOrOne Assembly as Assembly
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return Assembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        private int? _fk_Assembly;
        private Guid? _fk_guid_Assembly = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TypeRef_has_Assembly", "Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ Assembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_TypeRef_has_Assembly",
                        "Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_TypeRef_has_Assembly",
                        "Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Guid ExportGuid
        {
            get
            {
                return _ExportGuid;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_FullName != value)
                {
					var __oldValue = _FullName;
                    NotifyPropertyChanging("FullName", __oldValue, value);
                    _FullName = value;
                    NotifyPropertyChanged("FullName", __oldValue, value);
                }
            }
        }
        private string _FullName;

        /// <summary>
        /// list of type arguments
        /// </summary>
    /*
    Relation: FK_TypeRef_hasGenericArguments_TypeRef
    A: ZeroOrMore TypeRef as TypeRef
    B: ZeroOrMore TypeRef as GenericArguments
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.TypeRef> GenericArguments
        {
            get
            {
                if (_GenericArgumentsWrapper == null)
                {
                    _GenericArgumentsWrapper = new EntityRelationBSideListWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__>(
                            this,
                            GenericArguments__Implementation__);
                }
                return _GenericArgumentsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_TypeRef_hasGenericArguments_TypeRef_TypeRef", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__> GenericArguments__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__>(
                        "Model.FK_TypeRef_hasGenericArguments_TypeRef_TypeRef",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideListWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__> _GenericArgumentsWrapper;


        /// <summary>
        /// The TypeRef of the BaseClass of the referenced Type
        /// </summary>
    /*
    Relation: FK_TypeRef_has_TypeRef
    A: ZeroOrMore TypeRef as Child
    B: One TypeRef as Parent
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Parent
        {
            get
            {
                return Parent__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Parent__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        private int? _fk_Parent;
        private Guid? _fk_guid_Parent = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TypeRef_has_TypeRef", "Parent")]
        public Kistl.App.Base.TypeRef__Implementation__ Parent__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_TypeRef_has_TypeRef",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_TypeRef_has_TypeRef",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// get the referenced <see cref="System.Type"/>
        /// </summary>

		public virtual System.Type AsType(System.Boolean throwOnError) 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnAsType_TypeRef != null)
            {
                OnAsType_TypeRef(this, e, throwOnError);
            }
            else
            {
                throw new NotImplementedException("No handler registered on TypeRef.AsType");
            }
            return e.Result;
        }
		public delegate void AsType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret, System.Boolean throwOnError);
		public event AsType_Handler<TypeRef> OnAsType_TypeRef;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TypeRef));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TypeRef)obj;
			var otherImpl = (TypeRef__Implementation__)obj;
			var me = (TypeRef)this;

			me.ExportGuid = other.ExportGuid;
			me.FullName = other.FullName;
			this._fk_Assembly = otherImpl._fk_Assembly;
			this._fk_Parent = otherImpl._fk_Parent;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TypeRef != null)
            {
                OnToString_TypeRef(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<TypeRef> OnToString_TypeRef;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TypeRef != null) OnPreSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPreSave_TypeRef;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TypeRef != null) OnPostSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPostSave_TypeRef;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assembly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(91).Constraints
						.Where(c => !c.IsValid(this, this.Assembly))
						.Select(c => c.GetErrorText(this, this.Assembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(25).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "FullName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(36).Constraints
						.Where(c => !c.IsValid(this, this.FullName))
						.Select(c => c.GetErrorText(this, this.FullName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "GenericArguments":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(79).Constraints
						.Where(c => !c.IsValid(this, this.GenericArguments))
						.Select(c => c.GetErrorText(this, this.GenericArguments))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Parent":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(131).Constraints
						.Where(c => !c.IsValid(this, this.Parent))
						.Select(c => c.GetErrorText(this, this.Parent))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// fix direct object references

			if (_fk_guid_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_guid_Assembly.Value);
			else if (_fk_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.Find<Kistl.App.Base.Assembly>(_fk_Assembly.Value);
			else
				Assembly__Implementation__ = null;

			if (_fk_guid_Parent.HasValue)
				Parent__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Parent.Value);
			else if (_fk_Parent.HasValue)
				Parent__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.Find<Kistl.App.Base.TypeRef>(_fk_Parent.Value);
			else
				Parent__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(Assembly != null ? Assembly.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._FullName, binStream);
			{
				foreach(var obj in GenericArguments__Implementation__)
				{
					auxObjects.Add(obj);
				}
			}
            BinarySerializer.ToStream(Parent != null ? Parent.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Assembly, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._FullName, binStream);
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(Assembly != null ? Assembly.ID : (int?)null, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._FullName, xml, "FullName", "Kistl.App.Base");
            XmlStreamer.ToStream(Parent != null ? Parent.ID : (int?)null, xml, "Parent", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Assembly, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullName, xml, "FullName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Assembly != null ? Assembly.ExportGuid : (Guid?)null, xml, "Assembly", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._FullName, xml, "FullName", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Parent != null ? Parent.ExportGuid : (Guid?)null, xml, "Parent", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_Assembly, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullName, xml, "FullName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Parent, xml, "Parent", "Kistl.App.Base");
        }

#endregion

    }


}