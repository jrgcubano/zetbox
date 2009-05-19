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

    using Kistl.API.Client;
    using Kistl.DalProvider.ClientObjects;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Auftrag")]
    public class Auftrag__Implementation__ : BaseClientDataObject_ClientObjects, Auftrag
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
                if (_fk_Kunde.HasValue)
                    return Context.Find<Kistl.App.Projekte.Kunde>(_fk_Kunde.Value);
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
                if (_fk_Mitarbeiter.HasValue)
                    return Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
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
                if (_fk_Projekt.HasValue)
                    return Context.Find<Kistl.App.Projekte.Projekt>(_fk_Projekt.Value);
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
			this._fk_Kunde = otherImpl._fk_Kunde;
			this._fk_Mitarbeiter = otherImpl._fk_Mitarbeiter;
			this._fk_Projekt = otherImpl._fk_Projekt;
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


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Auftragsname":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(50).Constraints
						.Where(c => !c.IsValid(this, this.Auftragsname))
						.Select(c => c.GetErrorText(this, this.Auftragsname))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Auftragswert":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(65).Constraints
						.Where(c => !c.IsValid(this, this.Auftragswert))
						.Select(c => c.GetErrorText(this, this.Auftragswert))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kunde":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(64).Constraints
						.Where(c => !c.IsValid(this, this.Kunde))
						.Select(c => c.GetErrorText(this, this.Kunde))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(49).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Projekt":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(51).Constraints
						.Where(c => !c.IsValid(this, this.Projekt))
						.Select(c => c.GetErrorText(this, this.Projekt))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
                case "Kunde":
                    _fk_Kunde = id;
                    break;
                case "Mitarbeiter":
                    _fk_Mitarbeiter = id;
                    break;
                case "Projekt":
                    _fk_Projekt = id;
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

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._fk_Kunde, xml, "Kunde", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._fk_Mitarbeiter, xml, "Mitarbeiter", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._fk_Projekt, xml, "Projekt", "http://dasz.at/Kistl");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._fk_Kunde, xml, "Kunde", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._fk_Mitarbeiter, xml, "Mitarbeiter", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._fk_Projekt, xml, "Projekt", "http://dasz.at/Kistl");
        }

#endregion

    }


}