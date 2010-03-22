// <autogenerated/>


namespace Kistl.App.TimeRecords
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
    /// An account of work efforts. May be used to limit the hours being expended.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="WorkEffortAccount")]
    [System.Diagnostics.DebuggerDisplay("WorkEffortAccount")]
    public class WorkEffortAccount__Implementation__ : BaseServerDataObject_EntityFramework, WorkEffortAccount
    {
    
		public WorkEffortAccount__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
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

        /// <summary>
        /// Maximal erlaubte Stundenanzahl
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual double? BudgetHours
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _BudgetHours;
                if (OnBudgetHours_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnBudgetHours_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_BudgetHours != value)
                {
                    var __oldValue = _BudgetHours;
                    var __newValue = value;
                    if(OnBudgetHours_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnBudgetHours_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BudgetHours", __oldValue, __newValue);
                    _BudgetHours = __newValue;
                    NotifyPropertyChanged("BudgetHours", __oldValue, __newValue);
                    if(OnBudgetHours_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnBudgetHours_PostSetter(this, __e);
                    }
                }
            }
        }
        private double? _BudgetHours;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnBudgetHours_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnBudgetHours_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnBudgetHours_PostSetter;

        /// <summary>
        /// Zugeordnete Mitarbeiter
        /// </summary>
    /*
    Relation: FK_WorkEffortAccount_has_Mitarbeiter
    A: ZeroOrMore WorkEffortAccount as WorkEffortAccount
    B: ZeroOrMore Mitarbeiter as Mitarbeiter
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                if (_MitarbeiterWrapper == null)
                {
                    _MitarbeiterWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.TimeRecords.WorkEffortAccount, Kistl.App.Projekte.Mitarbeiter, Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__>(
                            this,
                            Mitarbeiter__Implementation__);
                }
                return _MitarbeiterWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_WorkEffortAccount_has_Mitarbeiter_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__> Mitarbeiter__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__>(
                        "Model.FK_WorkEffortAccount_has_Mitarbeiter_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.TimeRecords.WorkEffortAccount, Kistl.App.Projekte.Mitarbeiter, Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__> _MitarbeiterWrapper;


        /// <summary>
        /// Name des TimeRecordsskontos
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Name
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
                    if(OnName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(OnName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnName_PostSetter;

        /// <summary>
        /// Space for notes
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Notes
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Notes;
                if (OnNotes_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNotes_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Notes != value)
                {
                    var __oldValue = _Notes;
                    var __newValue = value;
                    if(OnNotes_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNotes_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Notes", __oldValue, __newValue);
                    _Notes = __newValue;
                    NotifyPropertyChanged("Notes", __oldValue, __newValue);
                    if(OnNotes_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNotes_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Notes;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnNotes_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnNotes_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, string> OnNotes_PostSetter;

        /// <summary>
        /// Aktuell gebuchte Stunden
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual double? SpentHours
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SpentHours;
                if (OnSpentHours_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnSpentHours_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SpentHours != value)
                {
                    var __oldValue = _SpentHours;
                    var __newValue = value;
                    if(OnSpentHours_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnSpentHours_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SpentHours", __oldValue, __newValue);
                    _SpentHours = __newValue;
                    NotifyPropertyChanged("SpentHours", __oldValue, __newValue);
                    if(OnSpentHours_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnSpentHours_PostSetter(this, __e);
                    }
                }
            }
        }
        private double? _SpentHours;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnSpentHours_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnSpentHours_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffortAccount, double?> OnSpentHours_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(WorkEffortAccount));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (WorkEffortAccount)obj;
			var otherImpl = (WorkEffortAccount__Implementation__)obj;
			var me = (WorkEffortAccount)this;

			me.BudgetHours = other.BudgetHours;
			me.Name = other.Name;
			me.Notes = other.Notes;
			me.SpentHours = other.SpentHours;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_WorkEffortAccount")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_WorkEffortAccount != null)
            {
                OnToString_WorkEffortAccount(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<WorkEffortAccount> OnToString_WorkEffortAccount;

        [EventBasedMethod("OnPreSave_WorkEffortAccount")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_WorkEffortAccount != null) OnPreSave_WorkEffortAccount(this);
        }
        public static event ObjectEventHandler<WorkEffortAccount> OnPreSave_WorkEffortAccount;

        [EventBasedMethod("OnPostSave_WorkEffortAccount")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_WorkEffortAccount != null) OnPostSave_WorkEffortAccount(this);
        }
        public static event ObjectEventHandler<WorkEffortAccount> OnPostSave_WorkEffortAccount;

        [EventBasedMethod("OnCreated_WorkEffortAccount")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_WorkEffortAccount != null) OnCreated_WorkEffortAccount(this);
        }
        public static event ObjectEventHandler<WorkEffortAccount> OnCreated_WorkEffortAccount;

        [EventBasedMethod("OnDeleting_WorkEffortAccount")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_WorkEffortAccount != null) OnDeleting_WorkEffortAccount(this);
        }
        public static event ObjectEventHandler<WorkEffortAccount> OnDeleting_WorkEffortAccount;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<WorkEffortAccount__Implementation__, double?>(
				new Guid("2f57b6c8-d798-43de-b9c8-29675ff0c65f"),
				"BudgetHours",
				null,
				obj => obj.BudgetHours,
				(obj, val) => obj.BudgetHours = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<WorkEffortAccount__Implementation__, ICollection<Kistl.App.Projekte.Mitarbeiter>>(
				new Guid("21ed2b37-6e10-4aff-b4c1-554a1cc0e967"),
				"Mitarbeiter",
				null,
				obj => obj.Mitarbeiter,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<WorkEffortAccount__Implementation__, string>(
				new Guid("763b0b46-8309-4532-ba98-36575f02a1d1"),
				"Name",
				null,
				obj => obj.Name,
				(obj, val) => obj.Name = val),
			// else
			new CustomPropertyDescriptor<WorkEffortAccount__Implementation__, string>(
				new Guid("79c8188d-d8e2-41b7-82c9-08f384fd6b68"),
				"Notes",
				null,
				obj => obj.Notes,
				(obj, val) => obj.Notes = val),
			// else
			new CustomPropertyDescriptor<WorkEffortAccount__Implementation__, double?>(
				new Guid("f7816f8a-0b07-429c-9161-47ca495a2e41"),
				"SpentHours",
				null,
				obj => obj.SpentHours,
				(obj, val) => obj.SpentHours = val),
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._BudgetHours, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Notes, binStream);
            BinarySerializer.ToStream(this._SpentHours, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._BudgetHours, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Notes, binStream);
            BinarySerializer.FromStream(out this._SpentHours, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._BudgetHours, xml, "BudgetHours", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._SpentHours, xml, "SpentHours", "Kistl.App.TimeRecords");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._BudgetHours, xml, "BudgetHours", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._SpentHours, xml, "SpentHours", "Kistl.App.TimeRecords");
        }

#endregion

    }


}