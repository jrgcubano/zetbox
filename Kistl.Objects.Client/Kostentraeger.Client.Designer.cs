
namespace Kistl.App.Zeiterfassung
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
    [System.Diagnostics.DebuggerDisplay("Kostentraeger")]
    public class Kostentraeger__Implementation__ : Kistl.App.Zeiterfassung.Zeitkonto__Implementation__, Kostentraeger
    {
    
		public Kostentraeger__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Projekt des Kostenträgers
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
					(oldValue.Kostentraeger as BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger>).RemoveWithoutClearParent(this);
				}

                if (value != null)
                {
					// add to new list
					(value.Kostentraeger as BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger>).AddWithoutSetParent(this);
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

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Kostentraeger));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Kostentraeger)obj;
			var otherImpl = (Kostentraeger__Implementation__)obj;
			var me = (Kostentraeger)this;

			this.fk_Projekt = otherImpl.fk_Projekt;
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kostentraeger != null)
            {
                OnToString_Kostentraeger(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Kostentraeger> OnToString_Kostentraeger;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kostentraeger != null) OnPreSave_Kostentraeger(this);
        }
        public event ObjectEventHandler<Kostentraeger> OnPreSave_Kostentraeger;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kostentraeger != null) OnPostSave_Kostentraeger(this);
        }
        public event ObjectEventHandler<Kostentraeger> OnPostSave_Kostentraeger;



		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
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
            BinarySerializer.ToStream(this._fk_Projekt, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Projekt, binStream);
        }

#endregion

    }


}