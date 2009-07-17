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
    [EdmEntityType(NamespaceName="Model", Name="Template")]
    [System.Diagnostics.DebuggerDisplay("Template")]
    public class Template__Implementation__ : BaseServerDataObject_EntityFramework, Template
    {
    
		public Template__Implementation__()
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
        /// Assembly of the Type that is displayed with this Template
        /// </summary>
    /*
    Relation: FK_Template_has_Assembly
    A: ZeroOrMore Template as Template
    B: ZeroOrOne Assembly as DisplayedTypeAssembly
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly DisplayedTypeAssembly
        {
            get
            {
                return DisplayedTypeAssembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        private int? _fk_DisplayedTypeAssembly;
        private Guid? _fk_guid_DisplayedTypeAssembly = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_Assembly", "DisplayedTypeAssembly")]
        public Kistl.App.Base.Assembly__Implementation__ DisplayedTypeAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_Template_has_Assembly",
                        "DisplayedTypeAssembly");
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
                        "Model.FK_Template_has_Assembly",
                        "DisplayedTypeAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string DisplayedTypeFullName
        {
            get
            {
                return _DisplayedTypeFullName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayedTypeFullName != value)
                {
					var __oldValue = _DisplayedTypeFullName;
                    NotifyPropertyChanging("DisplayedTypeFullName", __oldValue, value);
                    _DisplayedTypeFullName = value;
                    NotifyPropertyChanged("DisplayedTypeFullName", __oldValue, value);
                }
            }
        }
        private string _DisplayedTypeFullName;

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string DisplayName
        {
            get
            {
                return _DisplayName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayName != value)
                {
					var __oldValue = _DisplayName;
                    NotifyPropertyChanging("DisplayName", __oldValue, value);
                    _DisplayName = value;
                    NotifyPropertyChanged("DisplayName", __oldValue, value);
                }
            }
        }
        private string _DisplayName;

        /// <summary>
        /// The main menu for this Template
        /// </summary>
    /*
    Relation: FK_Template_hasMenu_Visual
    A: ZeroOrMore Template as Template
    B: ZeroOrMore Visual as Menu
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.Visual> Menu
        {
            get
            {
                if (_MenuWrapper == null)
                {
                    _MenuWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__>(
                            this,
                            Menu__Implementation__);
                }
                return _MenuWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Template_hasMenu_Visual_Template", "CollectionEntry")]
        public EntityCollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__> Menu__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__>(
                        "Model.FK_Template_hasMenu_Visual_Template",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__> _MenuWrapper;


        /// <summary>
        /// The visual representation of this Template
        /// </summary>
    /*
    Relation: FK_Template_has_Visual
    A: ZeroOrMore Template as Template
    B: ZeroOrOne Visual as VisualTree
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.Visual VisualTree
        {
            get
            {
                return VisualTree__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)value;
            }
        }
        
        private int? _fk_VisualTree;
        private Guid? _fk_guid_VisualTree = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_Visual", "VisualTree")]
        public Kistl.App.GUI.Visual__Implementation__ VisualTree__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.Visual__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Visual__Implementation__>(
                        "Model.FK_Template_has_Visual",
                        "VisualTree");
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
                EntityReference<Kistl.App.GUI.Visual__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Visual__Implementation__>(
                        "Model.FK_Template_has_Visual",
                        "VisualTree");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.GUI.Visual__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// 
        /// </summary>

		public virtual void PrepareDefault(Kistl.App.Base.ObjectClass cls) 
		{
            // base.PrepareDefault();
            if (OnPrepareDefault_Template != null)
            {
				OnPrepareDefault_Template(this, cls);
			}
			else
			{
                throw new NotImplementedException("No handler registered on Template.PrepareDefault");
			}
        }
		public delegate void PrepareDefault_Handler<T>(T obj, Kistl.App.Base.ObjectClass cls);
		public event PrepareDefault_Handler<Template> OnPrepareDefault_Template;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Template));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Template)obj;
			var otherImpl = (Template__Implementation__)obj;
			var me = (Template)this;

			me.DisplayedTypeFullName = other.DisplayedTypeFullName;
			me.DisplayName = other.DisplayName;
			this._fk_DisplayedTypeAssembly = otherImpl._fk_DisplayedTypeAssembly;
			this._fk_VisualTree = otherImpl._fk_VisualTree;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Template != null)
            {
                OnToString_Template(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Template> OnToString_Template;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Template != null) OnPreSave_Template(this);
        }
        public event ObjectEventHandler<Template> OnPreSave_Template;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Template != null) OnPostSave_Template(this);
        }
        public event ObjectEventHandler<Template> OnPostSave_Template;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Template != null) OnCreated_Template(this);
        }
        public event ObjectEventHandler<Template> OnCreated_Template;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Template != null) OnDeleting_Template(this);
        }
        public event ObjectEventHandler<Template> OnDeleting_Template;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "DisplayedTypeAssembly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(136).Constraints
						.Where(c => !c.IsValid(this, this.DisplayedTypeAssembly))
						.Select(c => c.GetErrorText(this, this.DisplayedTypeAssembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DisplayedTypeFullName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(90).Constraints
						.Where(c => !c.IsValid(this, this.DisplayedTypeFullName))
						.Select(c => c.GetErrorText(this, this.DisplayedTypeFullName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DisplayName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(91).Constraints
						.Where(c => !c.IsValid(this, this.DisplayName))
						.Select(c => c.GetErrorText(this, this.DisplayName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Menu":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(47).Constraints
						.Where(c => !c.IsValid(this, this.Menu))
						.Select(c => c.GetErrorText(this, this.Menu))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "VisualTree":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(166).Constraints
						.Where(c => !c.IsValid(this, this.VisualTree))
						.Select(c => c.GetErrorText(this, this.VisualTree))
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

			if (_fk_guid_DisplayedTypeAssembly.HasValue)
				DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_guid_DisplayedTypeAssembly.Value);
			else if (_fk_DisplayedTypeAssembly.HasValue)
				DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.Find<Kistl.App.Base.Assembly>(_fk_DisplayedTypeAssembly.Value);
			else
				DisplayedTypeAssembly__Implementation__ = null;

			if (_fk_guid_VisualTree.HasValue)
				VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.Visual>(_fk_guid_VisualTree.Value);
			else if (_fk_VisualTree.HasValue)
				VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)Context.Find<Kistl.App.GUI.Visual>(_fk_VisualTree.Value);
			else
				VisualTree__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(DisplayedTypeAssembly != null ? DisplayedTypeAssembly.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._DisplayedTypeFullName, binStream);
            BinarySerializer.ToStream(this._DisplayName, binStream);
            BinarySerializer.ToStream(VisualTree != null ? VisualTree.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_DisplayedTypeAssembly, binStream);
            BinarySerializer.FromStream(out this._DisplayedTypeFullName, binStream);
            BinarySerializer.FromStream(out this._DisplayName, binStream);
            BinarySerializer.FromStream(out this._fk_VisualTree, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(DisplayedTypeAssembly != null ? DisplayedTypeAssembly.ID : (int?)null, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._DisplayedTypeFullName, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._DisplayName, xml, "DisplayName", "Kistl.App.GUI");
            XmlStreamer.ToStream(VisualTree != null ? VisualTree.ID : (int?)null, xml, "VisualTree", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_DisplayedTypeAssembly, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._DisplayedTypeFullName, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._DisplayName, xml, "DisplayName", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_VisualTree, xml, "VisualTree", "Kistl.App.GUI");
        }

#endregion

    }


}