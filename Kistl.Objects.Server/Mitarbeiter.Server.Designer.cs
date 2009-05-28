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
    [EdmEntityType(NamespaceName="Model", Name="Mitarbeiter")]
    [System.Diagnostics.DebuggerDisplay("Mitarbeiter")]
    public class Mitarbeiter__Implementation__ : BaseServerDataObject_EntityFramework, Mitarbeiter
    {
    
		public Mitarbeiter__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
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
        /// Herzlichen Glückwunsch zum Geburtstag
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual DateTime? Geburtstag
        {
            get
            {
                return _Geburtstag;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Geburtstag != value)
                {
					var __oldValue = _Geburtstag;
                    NotifyPropertyChanging("Geburtstag", __oldValue, value);
                    _Geburtstag = value;
                    NotifyPropertyChanged("Geburtstag", __oldValue, value);
                }
            }
        }
        private DateTime? _Geburtstag;

        /// <summary>
        /// Vorname Nachname
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
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
        /// Projekte des Mitarbeiters für die er Verantwortlich ist
        /// </summary>
    /*
    Relation: FK_Projekt_Mitarbeiter_Projekte_23
    A: ZeroOrMore Projekt as Projekte
    B: ZeroOrMore Mitarbeiter as Mitarbeiter
    Preferred Storage: Separate
    */
        // collection reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Projekte.Projekt> Projekte
        {
            get
            {
                if (_ProjekteWrapper == null)
                {
                    _ProjekteWrapper = new EntityRelationASideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__>(
                            this,
                            Projekte__Implementation__);
                }
                return _ProjekteWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_Mitarbeiter_Mitarbeiter_23", "CollectionEntry")]
        public EntityCollection<Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__> Projekte__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__>(
                        "Model.FK_Projekt_Mitarbeiter_Mitarbeiter_23",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationASideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_Mitarbeiter23CollectionEntry__Implementation__> _ProjekteWrapper;
        

        /// <summary>
        /// NNNN TTMMYY
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string SVNr
        {
            get
            {
                return _SVNr;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_SVNr != value)
                {
					var __oldValue = _SVNr;
                    NotifyPropertyChanging("SVNr", __oldValue, value);
                    _SVNr = value;
                    NotifyPropertyChanged("SVNr", __oldValue, value);
                }
            }
        }
        private string _SVNr;

        /// <summary>
        /// +43 123 12345678
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string TelefonNummer
        {
            get
            {
                return _TelefonNummer;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_TelefonNummer != value)
                {
					var __oldValue = _TelefonNummer;
                    NotifyPropertyChanging("TelefonNummer", __oldValue, value);
                    _TelefonNummer = value;
                    NotifyPropertyChanged("TelefonNummer", __oldValue, value);
                }
            }
        }
        private string _TelefonNummer;

        /// <summary>
        /// 
        /// </summary>

		public virtual DateTime TestMethodForParameter(System.Boolean TestBool, System.Guid TestCLRObjectParameter, System.DateTime TestDateTime, System.Double TestDouble, System.Int32 TestInt, Kistl.App.Projekte.Auftrag TestObjectParameter, System.String TestString) 
        {
            var e = new MethodReturnEventArgs<DateTime>();
            if (OnTestMethodForParameter_Mitarbeiter != null)
            {
                OnTestMethodForParameter_Mitarbeiter(this, e, TestBool, TestCLRObjectParameter, TestDateTime, TestDouble, TestInt, TestObjectParameter, TestString);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Mitarbeiter.TestMethodForParameter");
            }
            return e.Result;
        }
		public delegate void TestMethodForParameter_Handler<T>(T obj, MethodReturnEventArgs<DateTime> ret, System.Boolean TestBool, System.Guid TestCLRObjectParameter, System.DateTime TestDateTime, System.Double TestDouble, System.Int32 TestInt, Kistl.App.Projekte.Auftrag TestObjectParameter, System.String TestString);
		public event TestMethodForParameter_Handler<Mitarbeiter> OnTestMethodForParameter_Mitarbeiter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Mitarbeiter));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Mitarbeiter)obj;
			var otherImpl = (Mitarbeiter__Implementation__)obj;
			var me = (Mitarbeiter)this;

			me.Geburtstag = other.Geburtstag;
			me.Name = other.Name;
			me.SVNr = other.SVNr;
			me.TelefonNummer = other.TelefonNummer;
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Mitarbeiter != null)
            {
                OnToString_Mitarbeiter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Mitarbeiter> OnToString_Mitarbeiter;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Mitarbeiter != null) OnPreSave_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnPreSave_Mitarbeiter;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Mitarbeiter != null) OnPostSave_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnPostSave_Mitarbeiter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Geburtstag":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(38).Constraints
						.Where(c => !c.IsValid(this, this.Geburtstag))
						.Select(c => c.GetErrorText(this, this.Geburtstag))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(20).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Projekte":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(21).Constraints
						.Where(c => !c.IsValid(this, this.Projekte))
						.Select(c => c.GetErrorText(this, this.Projekte))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "SVNr":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(39).Constraints
						.Where(c => !c.IsValid(this, this.SVNr))
						.Select(c => c.GetErrorText(this, this.SVNr))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "TelefonNummer":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(40).Constraints
						.Where(c => !c.IsValid(this, this.TelefonNummer))
						.Select(c => c.GetErrorText(this, this.TelefonNummer))
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
            BinarySerializer.ToStream(this._Geburtstag, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._SVNr, binStream);
            BinarySerializer.ToStream(this._TelefonNummer, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Geburtstag, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._SVNr, binStream);
            BinarySerializer.FromStream(out this._TelefonNummer, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Geburtstag, xml, "Geburtstag", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._SVNr, xml, "SVNr", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._TelefonNummer, xml, "TelefonNummer", "Kistl.App.Projekte");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Geburtstag, xml, "Geburtstag", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._SVNr, xml, "SVNr", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._TelefonNummer, xml, "TelefonNummer", "Kistl.App.Projekte");
        }

#endregion

    }


}