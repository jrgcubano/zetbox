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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// A defined work effort of an employee.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="WorkEffort")]
    [System.Diagnostics.DebuggerDisplay("WorkEffort")]
    public class WorkEffort__Implementation__ : BaseServerDataObject_EntityFramework, WorkEffort
    {
    
		public WorkEffort__Implementation__()
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
					var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);

                }
            }
        }
        private int _ID;

        /// <summary>
        /// Point in time when the work effort started.
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual DateTime From
        {
            get
            {
				var __value = _From;
				if(OnFrom_Getter != null)
				{
					var e = new PropertyGetterEventArgs<DateTime>(__value);
					OnFrom_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_From != value)
                {
					var __oldValue = _From;
					var __newValue = value;
                    if(OnFrom_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
						OnFrom_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("From", __oldValue, __newValue);
                    _From = __newValue;
                    NotifyPropertyChanged("From", __oldValue, __newValue);

                    if(OnFrom_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
						OnFrom_PostSetter(this, e);
                    }
                }
            }
        }
        private DateTime _From;
		public event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_Getter;
		public event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_PostSetter;
        /// <summary>
        /// Which employee effected this work effort.
        /// </summary>
    /*
    Relation: FK_WorkEffort_has_Mitarbeiter
    A: ZeroOrMore WorkEffort as WorkEffort
    B: One Mitarbeiter as Mitarbeiter
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                return Mitarbeiter__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        private int? _fk_Mitarbeiter;
        private Guid? _fk_guid_Mitarbeiter = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_WorkEffort_has_Mitarbeiter", "Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter__Implementation__ Mitarbeiter__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_WorkEffort_has_Mitarbeiter",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMitarbeiter_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__value);
					OnMitarbeiter_Getter(this, e);
					__value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_WorkEffort_has_Mitarbeiter",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Projekte.Mitarbeiter __oldValue = (Kistl.App.Projekte.Mitarbeiter)r.Value;
                Kistl.App.Projekte.Mitarbeiter __newValue = (Kistl.App.Projekte.Mitarbeiter)value;

                if(OnMitarbeiter_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)__newValue;
                if(OnMitarbeiter_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_Getter;
		public event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PostSetter;
        /// <summary>
        /// A short label describing this work effort.
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
				var __value = _Name;
				if(OnName_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnName_Getter(this, e);
					__value = e.Result;
				}
                return __value;
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
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnName_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);

                    if(OnName_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnName_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Name;
		public event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_PostSetter;
        /// <summary>
        /// Space for notes
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Notes
        {
            get
            {
				var __value = _Notes;
				if(OnNotes_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnNotes_Getter(this, e);
					__value = e.Result;
				}
                return __value;
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
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnNotes_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Notes", __oldValue, __newValue);
                    _Notes = __newValue;
                    NotifyPropertyChanged("Notes", __oldValue, __newValue);

                    if(OnNotes_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnNotes_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Notes;
		public event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_Getter;
		public event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_PostSetter;
        /// <summary>
        /// Point in time (inclusive) when the work effort ended.
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual DateTime? Thru
        {
            get
            {
				var __value = _Thru;
				if(OnThru_Getter != null)
				{
					var e = new PropertyGetterEventArgs<DateTime?>(__value);
					OnThru_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Thru != value)
                {
					var __oldValue = _Thru;
					var __newValue = value;
                    if(OnThru_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
						OnThru_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Thru", __oldValue, __newValue);
                    _Thru = __newValue;
                    NotifyPropertyChanged("Thru", __oldValue, __newValue);

                    if(OnThru_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
						OnThru_PostSetter(this, e);
                    }
                }
            }
        }
        private DateTime? _Thru;
		public event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_Getter;
		public event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(WorkEffort));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (WorkEffort)obj;
			var otherImpl = (WorkEffort__Implementation__)obj;
			var me = (WorkEffort)this;

			me.From = other.From;
			me.Name = other.Name;
			me.Notes = other.Notes;
			me.Thru = other.Thru;
			this._fk_Mitarbeiter = otherImpl._fk_Mitarbeiter;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_WorkEffort != null)
            {
                OnToString_WorkEffort(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<WorkEffort> OnToString_WorkEffort;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_WorkEffort != null) OnPreSave_WorkEffort(this);
        }
        public event ObjectEventHandler<WorkEffort> OnPreSave_WorkEffort;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_WorkEffort != null) OnPostSave_WorkEffort(this);
        }
        public event ObjectEventHandler<WorkEffort> OnPostSave_WorkEffort;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_WorkEffort != null) OnCreated_WorkEffort(this);
        }
        public event ObjectEventHandler<WorkEffort> OnCreated_WorkEffort;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_WorkEffort != null) OnDeleting_WorkEffort(this);
        }
        public event ObjectEventHandler<WorkEffort> OnDeleting_WorkEffort;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "From":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(114).Constraints
						.Where(c => !c.IsValid(this, this.From))
						.Select(c => c.GetErrorText(this, this.From))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(163).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(110).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Notes":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(111).Constraints
						.Where(c => !c.IsValid(this, this.Notes))
						.Select(c => c.GetErrorText(this, this.Notes))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Thru":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(115).Constraints
						.Where(c => !c.IsValid(this, this.Thru))
						.Select(c => c.GetErrorText(this, this.Thru))
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

			if (_fk_guid_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)Context.FindPersistenceObject<Kistl.App.Projekte.Mitarbeiter>(_fk_guid_Mitarbeiter.Value);
			else if (_fk_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
			else
				Mitarbeiter__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._From, binStream);
            BinarySerializer.ToStream(Mitarbeiter != null ? Mitarbeiter.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Notes, binStream);
            BinarySerializer.ToStream(this._Thru, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._From, binStream);
            BinarySerializer.FromStream(out this._fk_Mitarbeiter, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Notes, binStream);
            BinarySerializer.FromStream(out this._Thru, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(Mitarbeiter != null ? Mitarbeiter.ID : (int?)null, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._fk_Mitarbeiter, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

#endregion

    }


}