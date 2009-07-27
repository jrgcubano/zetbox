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
    /// Describes a Relation between two Object Classes
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Relation")]
    [System.Diagnostics.DebuggerDisplay("Relation")]
    public class Relation__Implementation__ : BaseServerDataObject_EntityFramework, Relation, Kistl.API.IExportableInternal
    {
    
		public Relation__Implementation__()
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
                if (this.IsReadonly) throw new ReadOnlyObjectException();
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
        /// The A-side of this Relation.
        /// </summary>
    /*
    Relation: FK_Relation_hasA_RelationEnd
    A: ZeroOrOne Relation as Relation
    B: ZeroOrOne RelationEnd as A
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd A
        {
            get
            {
                return A__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_A;
        private Guid? _fk_guid_A = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Relation_hasA_RelationEnd", "A")]
        public Kistl.App.Base.RelationEnd__Implementation__ A__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasA_RelationEnd",
                        "A");
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
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasA_RelationEnd",
                        "A");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// The B-side of this Relation.
        /// </summary>
    /*
    Relation: FK_Relation_hasB_RelationEnd
    A: ZeroOrOne Relation as Relation
    B: ZeroOrOne RelationEnd as B
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd B
        {
            get
            {
                return B__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_B;
        private Guid? _fk_guid_B = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Relation_hasB_RelationEnd", "B")]
        public Kistl.App.Base.RelationEnd__Implementation__ B__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasB_RelationEnd",
                        "B");
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
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_Relation_hasB_RelationEnd",
                        "B");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Description of this Relation
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

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
                if (this.IsReadonly) throw new ReadOnlyObjectException();
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
    /*
    Relation: FK_Module_has_Relation
    A: One Module as Module
    B: ZeroOrMore Relation as Relation
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Module__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        private int? _fk_Module;
        private Guid? _fk_guid_Module = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Module_has_Relation", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_Relation",
                        "Module");
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
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Module_has_Relation",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Storagetype for 1:1 Relations. Must be null for non 1:1 Relations.
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Base.StorageType? Storage
        {
            get
            {
                return _Storage;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Storage != value)
                {
					var __oldValue = _Storage;
                    NotifyPropertyChanging("Storage", "Storage__Implementation__", __oldValue, value);
                    _Storage = value;
                    NotifyPropertyChanged("Storage", "Storage__Implementation__", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for Storage</summary>
        private Kistl.App.Base.StorageType? _Storage;
        
        /// <summary>EF sees only this property, for Storage</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int Storage__Implementation__
        {
            get
            {
                return (int)this.Storage;
            }
            set
            {
                this.Storage = (Kistl.App.Base.StorageType?)value;
            }
        }
        

        /// <summary>
        /// Verb of this Relation
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Verb
        {
            get
            {
                return _Verb;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Verb != value)
                {
					var __oldValue = _Verb;
                    NotifyPropertyChanging("Verb", __oldValue, value);
                    _Verb = value;
                    NotifyPropertyChanged("Verb", __oldValue, value);
                }
            }
        }
        private string _Verb;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Relation));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Relation)obj;
			var otherImpl = (Relation__Implementation__)obj;
			var me = (Relation)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.Storage = other.Storage;
			me.Verb = other.Verb;
			this._fk_A = otherImpl._fk_A;
			this._fk_B = otherImpl._fk_B;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Relation != null)
            {
                OnToString_Relation(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Relation> OnToString_Relation;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Relation != null) OnPreSave_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnPreSave_Relation;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Relation != null) OnPostSave_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnPostSave_Relation;

        public override void NotifyCreated()
        {
            try
            {
				this.ExportGuid = (Guid)FrozenContext.Single.Find<Kistl.App.Base.Property>(30).DefaultValue.GetDefaultValue();
            }
            catch (NotImplementedException)
            {
                // TODO: Find a better way to ignore bootstrap errors.
                // During bootstrapping no MethodInvocation is registred
            }
            base.NotifyCreated();
            if (OnCreated_Relation != null) OnCreated_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnCreated_Relation;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Relation != null) OnDeleting_Relation(this);
        }
        public event ObjectEventHandler<Relation> OnDeleting_Relation;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "A":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(22).Constraints
						.Where(c => !c.IsValid(this, this.A))
						.Select(c => c.GetErrorText(this, this.A))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "B":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(26).Constraints
						.Where(c => !c.IsValid(this, this.B))
						.Select(c => c.GetErrorText(this, this.B))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(161).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(30).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(150).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Storage":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(181).Constraints
						.Where(c => !c.IsValid(this, this.Storage))
						.Select(c => c.GetErrorText(this, this.Storage))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Verb":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(81).Constraints
						.Where(c => !c.IsValid(this, this.Verb))
						.Select(c => c.GetErrorText(this, this.Verb))
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

			if (_fk_guid_A.HasValue)
				A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_A.Value);
			else if (_fk_A.HasValue)
				A__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_A.Value);
			else
				A__Implementation__ = null;

			if (_fk_guid_B.HasValue)
				B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_B.Value);
			else if (_fk_B.HasValue)
				B__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_B.Value);
			else
				B__Implementation__ = null;

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(A != null ? A.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(A);
			}
            BinarySerializer.ToStream(B != null ? B.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(B);
			}
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream((int)((Relation)this).Storage, binStream);
            BinarySerializer.ToStream(this._Verb, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_A, binStream);
            BinarySerializer.FromStream(out this._fk_B, binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, binStream);
            BinarySerializer.FromStream(out this._Verb, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(A != null ? A.ID : (int?)null, xml, "A", "Kistl.App.Base");
            XmlStreamer.ToStream(B != null ? B.ID : (int?)null, xml, "B", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
            XmlStreamer.ToStream((int)this.Storage, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_A, xml, "A", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_B, xml, "B", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(A != null ? A.ExportGuid : (Guid?)null, xml, "A", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(B != null ? B.ExportGuid : (Guid?)null, xml, "B", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream((int)this.Storage, xml, "Storage", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Verb, xml, "Verb", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_A, xml, "A", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_B, xml, "B", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStreamConverter(v => ((Relation)this).Storage = (Kistl.App.Base.StorageType)v, xml, "Storage", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Verb, xml, "Verb", "Kistl.App.Base");
        }

#endregion

    }


}