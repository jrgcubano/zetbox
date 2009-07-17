// <autogenerated/>


namespace Kistl.App.GUI
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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ViewDescriptor")]
    [System.Diagnostics.DebuggerDisplay("ViewDescriptor")]
    public class ViewDescriptor__Implementation__ : BaseServerDataObject_EntityFramework, ViewDescriptor, Kistl.API.IExportableInternal
    {
    
		public ViewDescriptor__Implementation__()
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
        /// The control implementing this View
        /// </summary>
    /*
    Relation: FK_ViewDescriptor_has_TypeRef
    A: ZeroOrMore ViewDescriptor as View
    B: One TypeRef as ControlRef
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef ControlRef
        {
            get
            {
                return ControlRef__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        private int? _fk_ControlRef;
        private Guid? _fk_guid_ControlRef = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ViewDescriptor_has_TypeRef", "ControlRef")]
        public Kistl.App.Base.TypeRef__Implementation__ ControlRef__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_ViewDescriptor_has_TypeRef",
                        "ControlRef");
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
                        "Model.FK_ViewDescriptor_has_TypeRef",
                        "ControlRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)value;
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
        /// Indicates whether or not the described control is read-only or allows editing.
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool IsReadOnly
        {
            get
            {
                return _IsReadOnly;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_IsReadOnly != value)
                {
					var __oldValue = _IsReadOnly;
                    NotifyPropertyChanging("IsReadOnly", __oldValue, value);
                    _IsReadOnly = value;
                    NotifyPropertyChanged("IsReadOnly", __oldValue, value);
                }
            }
        }
        private bool _IsReadOnly;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ViewDescriptor_has_Module
    A: ZeroOrMore ViewDescriptor as ViewDescriptor
    B: ZeroOrOne Module as Module
    Preferred Storage: MergeIntoA
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
        [EdmRelationshipNavigationProperty("Model", "FK_ViewDescriptor_has_Module", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_ViewDescriptor_has_Module",
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
                        "Model.FK_ViewDescriptor_has_Module",
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
        /// The PresentableModel usable by this View
        /// </summary>
    /*
    Relation: FK_ViewDescriptor_has_PresentableModelDescriptor
    A: ZeroOrMore ViewDescriptor as View
    B: One PresentableModelDescriptor as PresentedModelDescriptor
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.PresentableModelDescriptor PresentedModelDescriptor
        {
            get
            {
                return PresentedModelDescriptor__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                PresentedModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)value;
            }
        }
        
        private int? _fk_PresentedModelDescriptor;
        private Guid? _fk_guid_PresentedModelDescriptor = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ViewDescriptor_has_PresentableModelDescriptor", "PresentedModelDescriptor")]
        public Kistl.App.GUI.PresentableModelDescriptor__Implementation__ PresentedModelDescriptor__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_ViewDescriptor_has_PresentableModelDescriptor",
                        "PresentedModelDescriptor");
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
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_ViewDescriptor_has_PresentableModelDescriptor",
                        "PresentedModelDescriptor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Which toolkit provides this View
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.GUI.Toolkit Toolkit
        {
            get
            {
                return _Toolkit;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Toolkit != value)
                {
					var __oldValue = _Toolkit;
                    NotifyPropertyChanging("Toolkit", "Toolkit__Implementation__", __oldValue, value);
                    _Toolkit = value;
                    NotifyPropertyChanged("Toolkit", "Toolkit__Implementation__", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for Toolkit</summary>
        private Kistl.App.GUI.Toolkit _Toolkit;
        
        /// <summary>EF sees only this property, for Toolkit</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int Toolkit__Implementation__
        {
            get
            {
                return (int)this.Toolkit;
            }
            set
            {
                this.Toolkit = (Kistl.App.GUI.Toolkit)value;
            }
        }
        

        /// <summary>
        /// The visual type of this View
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.GUI.VisualType VisualType
        {
            get
            {
                return _VisualType;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_VisualType != value)
                {
					var __oldValue = _VisualType;
                    NotifyPropertyChanging("VisualType", "VisualType__Implementation__", __oldValue, value);
                    _VisualType = value;
                    NotifyPropertyChanged("VisualType", "VisualType__Implementation__", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for VisualType</summary>
        private Kistl.App.GUI.VisualType _VisualType;
        
        /// <summary>EF sees only this property, for VisualType</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int VisualType__Implementation__
        {
            get
            {
                return (int)this.VisualType;
            }
            set
            {
                this.VisualType = (Kistl.App.GUI.VisualType)value;
            }
        }
        

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ViewDescriptor));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ViewDescriptor)obj;
			var otherImpl = (ViewDescriptor__Implementation__)obj;
			var me = (ViewDescriptor)this;

			me.ExportGuid = other.ExportGuid;
			me.IsReadOnly = other.IsReadOnly;
			me.Toolkit = other.Toolkit;
			me.VisualType = other.VisualType;
			this._fk_ControlRef = otherImpl._fk_ControlRef;
			this._fk_Module = otherImpl._fk_Module;
			this._fk_PresentedModelDescriptor = otherImpl._fk_PresentedModelDescriptor;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ViewDescriptor != null)
            {
                OnToString_ViewDescriptor(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ViewDescriptor> OnToString_ViewDescriptor;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ViewDescriptor != null) OnPreSave_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnPreSave_ViewDescriptor;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ViewDescriptor != null) OnPostSave_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnPostSave_ViewDescriptor;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ViewDescriptor != null) OnCreated_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnCreated_ViewDescriptor;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ViewDescriptor != null) OnDeleting_ViewDescriptor(this);
        }
        public event ObjectEventHandler<ViewDescriptor> OnDeleting_ViewDescriptor;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ControlRef":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(180).Constraints
						.Where(c => !c.IsValid(this, this.ControlRef))
						.Select(c => c.GetErrorText(this, this.ControlRef))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(31).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsReadOnly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(63).Constraints
						.Where(c => !c.IsValid(this, this.IsReadOnly))
						.Select(c => c.GetErrorText(this, this.IsReadOnly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(169).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "PresentedModelDescriptor":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(168).Constraints
						.Where(c => !c.IsValid(this, this.PresentedModelDescriptor))
						.Select(c => c.GetErrorText(this, this.PresentedModelDescriptor))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Toolkit":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(187).Constraints
						.Where(c => !c.IsValid(this, this.Toolkit))
						.Select(c => c.GetErrorText(this, this.Toolkit))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "VisualType":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(177).Constraints
						.Where(c => !c.IsValid(this, this.VisualType))
						.Select(c => c.GetErrorText(this, this.VisualType))
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

			if (_fk_guid_PresentedModelDescriptor.HasValue)
				PresentedModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.PresentableModelDescriptor>(_fk_guid_PresentedModelDescriptor.Value);
			else if (_fk_PresentedModelDescriptor.HasValue)
				PresentedModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.Find<Kistl.App.GUI.PresentableModelDescriptor>(_fk_PresentedModelDescriptor.Value);
			else
				PresentedModelDescriptor__Implementation__ = null;

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;

			if (_fk_guid_ControlRef.HasValue)
				ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_ControlRef.Value);
			else if (_fk_ControlRef.HasValue)
				ControlRef__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.Find<Kistl.App.Base.TypeRef>(_fk_ControlRef.Value);
			else
				ControlRef__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(ControlRef != null ? ControlRef.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._IsReadOnly, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream(PresentedModelDescriptor != null ? PresentedModelDescriptor.ID : (int?)null, binStream);
            BinarySerializer.ToStream((int)((ViewDescriptor)this).Toolkit, binStream);
            BinarySerializer.ToStream((int)((ViewDescriptor)this).VisualType, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_ControlRef, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._IsReadOnly, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._fk_PresentedModelDescriptor, binStream);
            BinarySerializer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, binStream);
            BinarySerializer.FromStreamConverter(v => ((ViewDescriptor)this).VisualType = (Kistl.App.GUI.VisualType)v, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(ControlRef != null ? ControlRef.ID : (int?)null, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._IsReadOnly, xml, "IsReadOnly", "Kistl.App.GUI");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.ToStream(PresentedModelDescriptor != null ? PresentedModelDescriptor.ID : (int?)null, xml, "PresentedModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.ToStream((int)this.Toolkit, xml, "Toolkit", "Kistl.App.GUI");
            XmlStreamer.ToStream((int)this.VisualType, xml, "VisualType", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_ControlRef, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsReadOnly, xml, "IsReadOnly", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_PresentedModelDescriptor, xml, "PresentedModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, xml, "Toolkit", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).VisualType = (Kistl.App.GUI.VisualType)v, xml, "VisualType", "Kistl.App.GUI");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(ControlRef != null ? ControlRef.ExportGuid : (Guid?)null, xml, "ControlRef", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsReadOnly, xml, "IsReadOnly", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(PresentedModelDescriptor != null ? PresentedModelDescriptor.ExportGuid : (Guid?)null, xml, "PresentedModelDescriptor", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream((int)this.Toolkit, xml, "Toolkit", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream((int)this.VisualType, xml, "VisualType", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_ControlRef, xml, "ControlRef", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsReadOnly, xml, "IsReadOnly", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_PresentedModelDescriptor, xml, "PresentedModelDescriptor", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).Toolkit = (Kistl.App.GUI.Toolkit)v, xml, "Toolkit", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ViewDescriptor)this).VisualType = (Kistl.App.GUI.VisualType)v, xml, "VisualType", "Kistl.App.GUI");
        }

#endregion

    }


}