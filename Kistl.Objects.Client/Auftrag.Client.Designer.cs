
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

    using Kistl.API.Client;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Auftrag")]
    public class Auftrag__Implementation__ : BaseClientDataObject, Auftrag
    {
    
		public Auftrag__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Bitte füllen Sie einen sprechenden Auftragsnamen aus
        /// </summary>
        // value type property
        public virtual string Auftragsname
        {
            get
            {
                return _Auftragsname;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragsname != value)
                {
					var __oldValue = _Auftragsname;
                    NotifyPropertyChanging("Auftragsname", __oldValue, value);
                    _Auftragsname = value;
                    NotifyPropertyChanged("Auftragsname", __oldValue, value);
                }
            }
        }
        private string _Auftragsname;

        /// <summary>
        /// Wert in EUR des Auftrages
        /// </summary>
        // value type property
        public virtual double? Auftragswert
        {
            get
            {
                return _Auftragswert;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragswert != value)
                {
					var __oldValue = _Auftragswert;
                    NotifyPropertyChanging("Auftragswert", __oldValue, value);
                    _Auftragswert = value;
                    NotifyPropertyChanged("Auftragswert", __oldValue, value);
                }
            }
        }
        private double? _Auftragswert;

        /// <summary>
        /// Kunde des Projektes
        /// </summary>
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde Kunde
        {
            get
            {
                if (fk_Kunde.HasValue)
                    return Context.Find<Kistl.App.Projekte.Kunde>(fk_Kunde.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Kunde == null)
					return;
                else if (value != null && value.ID == _fk_Kunde)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Kunde;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Kunde", oldValue, value);
                
				// next, set the local reference
                _fk_Kunde = value == null ? (int?)null : value.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Kunde", oldValue, value);
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Kunde
        {
            get
            {
                return _fk_Kunde;
            }
            private set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_fk_Kunde != value)
                {
					var __oldValue = _fk_Kunde;
                    NotifyPropertyChanging("Kunde", __oldValue, value);
                    _fk_Kunde = value;
                    NotifyPropertyChanged("Kunde", __oldValue, value);
                }
            }
        }
        private int? _fk_Kunde;

        /// <summary>
        /// 
        /// </summary>
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                if (fk_Mitarbeiter.HasValue)
                    return Context.Find<Kistl.App.Projekte.Mitarbeiter>(fk_Mitarbeiter.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Mitarbeiter == null)
					return;
                else if (value != null && value.ID == _fk_Mitarbeiter)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Mitarbeiter;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Mitarbeiter", oldValue, value);
                
				// next, set the local reference
                _fk_Mitarbeiter = value == null ? (int?)null : value.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Mitarbeiter", oldValue, value);
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Mitarbeiter
        {
            get
            {
                return _fk_Mitarbeiter;
            }
            private set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_fk_Mitarbeiter != value)
                {
					var __oldValue = _fk_Mitarbeiter;
                    NotifyPropertyChanging("Mitarbeiter", __oldValue, value);
                    _fk_Mitarbeiter = value;
                    NotifyPropertyChanged("Mitarbeiter", __oldValue, value);
                }
            }
        }
        private int? _fk_Mitarbeiter;

        /// <summary>
        /// Projekt zum Auftrag
        /// </summary>
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                if (fk_Projekt.HasValue)
                    return Context.Find<Kistl.App.Projekte.Projekt>(fk_Projekt.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Projekt == null)
					return;
                else if (value != null && value.ID == _fk_Projekt)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Projekt;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Projekt", oldValue, value);
                
				// next, set the local reference
                _fk_Projekt = value == null ? (int?)null : value.ID;
				
				// now fixup redundant, inverse references
				// The inverse navigator will also fire events when changed, so should 
				// only be touched after setting the local value above. 
				// TODO: for complete correctness, the "other" Changing event should also fire 
				//       before the local value is changed
				if (oldValue != null)
				{
					// remove from old list
					(oldValue.Auftraege as OneNRelationCollection<Kistl.App.Projekte.Auftrag>).RemoveWithoutClearParent(this);
				}

                if (value != null)
                {
					// add to new list
					(value.Auftraege as OneNRelationCollection<Kistl.App.Projekte.Auftrag>).AddWithoutSetParent(this);
                }
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Projekt", oldValue, value);
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Projekt
        {
            get
            {
                return _fk_Projekt;
            }
            private set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_fk_Projekt != value)
                {
					var __oldValue = _fk_Projekt;
                    NotifyPropertyChanging("Projekt", __oldValue, value);
                    _fk_Projekt = value;
                    NotifyPropertyChanged("Projekt", __oldValue, value);
                }
            }
        }
        private int? _fk_Projekt;

        /// <summary>
        /// Testmethode zum Erstellen von Rechnungen mit Word
        /// </summary>

		public virtual void RechnungErstellen() 
		{
            // base.RechnungErstellen();
            if (OnRechnungErstellen_Auftrag != null)
            {
				OnRechnungErstellen_Auftrag(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on Auftrag.RechnungErstellen");
			}
        }
		public delegate void RechnungErstellen_Handler<T>(T obj);
		public event RechnungErstellen_Handler<Auftrag> OnRechnungErstellen_Auftrag;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Auftrag));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Auftrag)obj;
			var otherImpl = (Auftrag__Implementation__)obj;
			var me = (Auftrag)this;

			me.Auftragsname = other.Auftragsname;
			me.Auftragswert = other.Auftragswert;
			this.fk_Kunde = otherImpl.fk_Kunde;
			this.fk_Mitarbeiter = otherImpl.fk_Mitarbeiter;
			this.fk_Projekt = otherImpl.fk_Projekt;
		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Auftrag != null)
            {
                OnToString_Auftrag(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Auftrag> OnToString_Auftrag;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Auftrag != null) OnPreSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPreSave_Auftrag;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Auftrag != null) OnPostSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPostSave_Auftrag;



		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
                case "Kunde":
                    fk_Kunde = id;
                    break;
                case "Mitarbeiter":
                    fk_Mitarbeiter = id;
                    break;
                case "Projekt":
                    fk_Projekt = id;
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
            BinarySerializer.ToStream(this._Auftragsname, binStream);
            BinarySerializer.ToStream(this._Auftragswert, binStream);
            BinarySerializer.ToStream(this._fk_Kunde, binStream);
            BinarySerializer.ToStream(this._fk_Mitarbeiter, binStream);
            BinarySerializer.ToStream(this._fk_Projekt, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Auftragsname, binStream);
            BinarySerializer.FromStream(out this._Auftragswert, binStream);
            BinarySerializer.FromStream(out this._fk_Kunde, binStream);
            BinarySerializer.FromStream(out this._fk_Mitarbeiter, binStream);
            BinarySerializer.FromStream(out this._fk_Projekt, binStream);
        }

#endregion

    }


}