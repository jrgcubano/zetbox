// <autogenerated/>


namespace Kistl.App.Projekte
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
    [EdmEntityType(NamespaceName="Model", Name="Projekt")]
    [System.Diagnostics.DebuggerDisplay("Projekt")]
    public class Projekt__Implementation__ : BaseServerDataObject_EntityFramework, Projekt
    {
    
		public Projekt__Implementation__()
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
        /// Aufträge
        /// </summary>
    /*
    Relation: FK_Projekt_Auftrag_Projekt_30
    A: ZeroOrOne Projekt as Projekt
    B: ZeroOrMore Auftrag as Auftraege
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if (_AuftraegeWrapper == null)
                {
                    _AuftraegeWrapper = new EntityCollectionWrapper<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Auftrag__Implementation__>(
                            this.Context, Auftraege__Implementation__);
                }
                return _AuftraegeWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_Auftrag_Projekt_30", "Auftraege")]
        public EntityCollection<Kistl.App.Projekte.Auftrag__Implementation__> Auftraege__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Projekte.Auftrag__Implementation__>(
                        "Model.FK_Projekt_Auftrag_Projekt_30",
                        "Auftraege");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Auftrag__Implementation__> _AuftraegeWrapper;



        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual double? AufwandGes
        {
            get
            {
                return _AufwandGes;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_AufwandGes != value)
                {
					var __oldValue = _AufwandGes;
                    NotifyPropertyChanging("AufwandGes", __oldValue, value);
                    _AufwandGes = value;
                    NotifyPropertyChanged("AufwandGes", __oldValue, value);
                }
            }
        }
        private double? _AufwandGes;

        /// <summary>
        /// Bitte geben Sie den Kundennamen ein
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Kundenname != value)
                {
					var __oldValue = _Kundenname;
                    NotifyPropertyChanging("Kundenname", __oldValue, value);
                    _Kundenname = value;
                    NotifyPropertyChanged("Kundenname", __oldValue, value);
                }
            }
        }
        private string _Kundenname;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Projekt_Mitarbeiter_Projekte_23
    A: ZeroOrMore Projekt as Projekte
    B: ZeroOrMore Mitarbeiter as Mitarbeiter
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                if (_MitarbeiterWrapper == null)
                {
                    _MitarbeiterWrapper = new EntityRelationBSideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__>(
                            this,
                            Mitarbeiter__Implementation__);
                }
                return _MitarbeiterWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_Mitarbeiter_Projekte_23", "CollectionEntry")]
        public EntityCollection<Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__> Mitarbeiter__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__>(
                        "Model.FK_Projekt_Mitarbeiter_Projekte_23",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__> _MitarbeiterWrapper;


        /// <summary>
        /// Projektname
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
					var __oldValue = _Name;
                    NotifyPropertyChanging("Name", __oldValue, value);
                    _Name = value;
                    NotifyPropertyChanged("Name", __oldValue, value);
                }
            }
        }
        private string _Name;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Projekt_Task_Projekt_22
    A: ZeroOrOne Projekt as Projekt
    B: ZeroOrMore Task as Tasks
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if (_TasksWrapper == null)
                {
                    _TasksWrapper = new EntityCollectionWrapper<Kistl.App.Projekte.Task, Kistl.App.Projekte.Task__Implementation__>(
                            this.Context, Tasks__Implementation__);
                }
                return _TasksWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_Task_Projekt_22", "Tasks")]
        public EntityCollection<Kistl.App.Projekte.Task__Implementation__> Tasks__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Projekte.Task__Implementation__>(
                        "Model.FK_Projekt_Task_Projekt_22",
                        "Tasks");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Projekte.Task, Kistl.App.Projekte.Task__Implementation__> _TasksWrapper;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Projekt));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Projekt)obj;
			var otherImpl = (Projekt__Implementation__)obj;
			var me = (Projekt)this;

			me.AufwandGes = other.AufwandGes;
			me.Kundenname = other.Kundenname;
			me.Name = other.Name;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Projekt != null)
            {
                OnToString_Projekt(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Projekt> OnToString_Projekt;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Projekt != null) OnPreSave_Projekt(this);
        }
        public event ObjectEventHandler<Projekt> OnPreSave_Projekt;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Projekt != null) OnPostSave_Projekt(this);
        }
        public event ObjectEventHandler<Projekt> OnPostSave_Projekt;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Auftraege":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(67).Constraints
						.Where(c => !c.IsValid(this, this.Auftraege))
						.Select(c => c.GetErrorText(this, this.Auftraege))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "AufwandGes":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(23).Constraints
						.Where(c => !c.IsValid(this, this.AufwandGes))
						.Select(c => c.GetErrorText(this, this.AufwandGes))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kundenname":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(48).Constraints
						.Where(c => !c.IsValid(this, this.Kundenname))
						.Select(c => c.GetErrorText(this, this.Kundenname))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(22).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(13).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Tasks":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(14).Constraints
						.Where(c => !c.IsValid(this, this.Tasks))
						.Select(c => c.GetErrorText(this, this.Tasks))
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
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._AufwandGes, binStream);
            BinarySerializer.ToStream(this._Kundenname, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._AufwandGes, binStream);
            BinarySerializer.FromStream(out this._Kundenname, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._AufwandGes, xml, "AufwandGes", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Kundenname, xml, "Kundenname", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Projekte");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._AufwandGes, xml, "AufwandGes", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Kundenname, xml, "Kundenname", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Projekte");
        }

#endregion

    }


}