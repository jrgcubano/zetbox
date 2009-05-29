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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="PresenceRecord")]
    [System.Diagnostics.DebuggerDisplay("PresenceRecord")]
    public class PresenceRecord__Implementation__ : BaseServerDataObject_EntityFramework, PresenceRecord
    {
    
		public PresenceRecord__Implementation__()
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
        /// Point in time when the presence started.
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
                return _From;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_From != value)
                {
					var __oldValue = _From;
                    NotifyPropertyChanging("From", __oldValue, value);
                    _From = value;
                    NotifyPropertyChanged("From", __oldValue, value);
                }
            }
        }
        private DateTime _From;

        /// <summary>
        /// Which employee was present.
        /// </summary>
    /*
    Relation: FK_PresenceRecord_Mitarbeiter_PresenceRecord_81
    A: ZeroOrMore PresenceRecord as PresenceRecord
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        private int? _fk_Mitarbeiter;
        private Guid? _fk_guid_Mitarbeiter = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_PresenceRecord_Mitarbeiter_PresenceRecord_81", "Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter__Implementation__ Mitarbeiter__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_PresenceRecord_Mitarbeiter_PresenceRecord_81",
                        "Mitarbeiter");
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
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_PresenceRecord_Mitarbeiter_PresenceRecord_81",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Point in time (inclusive) when the presence ended.
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
                return _Thru;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Thru != value)
                {
					var __oldValue = _Thru;
                    NotifyPropertyChanging("Thru", __oldValue, value);
                    _Thru = value;
                    NotifyPropertyChanged("Thru", __oldValue, value);
                }
            }
        }
        private DateTime? _Thru;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(PresenceRecord));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (PresenceRecord)obj;
			var otherImpl = (PresenceRecord__Implementation__)obj;
			var me = (PresenceRecord)this;

			me.From = other.From;
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
            if (OnToString_PresenceRecord != null)
            {
                OnToString_PresenceRecord(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<PresenceRecord> OnToString_PresenceRecord;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PresenceRecord != null) OnPreSave_PresenceRecord(this);
        }
        public event ObjectEventHandler<PresenceRecord> OnPreSave_PresenceRecord;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PresenceRecord != null) OnPostSave_PresenceRecord(this);
        }
        public event ObjectEventHandler<PresenceRecord> OnPostSave_PresenceRecord;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "From":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(238).Constraints
						.Where(c => !c.IsValid(this, this.From))
						.Select(c => c.GetErrorText(this, this.From))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(244).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Thru":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(239).Constraints
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
            BinarySerializer.ToStream(this._Thru, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._From, binStream);
            BinarySerializer.FromStream(out this._fk_Mitarbeiter, binStream);
            BinarySerializer.FromStream(out this._Thru, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(Mitarbeiter != null ? Mitarbeiter.ID : (int?)null, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._fk_Mitarbeiter, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

#endregion

    }


}