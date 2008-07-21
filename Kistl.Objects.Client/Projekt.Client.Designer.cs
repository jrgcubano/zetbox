//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class Projekt : BaseClientDataObject
    {
        
        private int _ID;
        
        private string _Name;
        
        private BackReferenceCollection<Kistl.App.Projekte.Task> _Tasks;
        
        private ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Projekt, Projekt_MitarbeiterCollectionEntry> _Mitarbeiter;
        
        private System.Double? _AufwandGes;
        
        private string _Kundenname;
        
        private BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger> _Kostentraeger;
        
        private BackReferenceCollection<Kistl.App.Projekte.Auftrag> _Auftraege;
        
        public Projekt()
        {
            _Mitarbeiter = new ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Projekt, Projekt_MitarbeiterCollectionEntry>(this, "Mitarbeiter");
        }
        
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if(_Name != value)
                {
                    NotifyPropertyChanging("Name"); 
                    _Name = value; 
                    NotifyPropertyChanged("Name");
                };
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if (_Tasks == null)
                {
                    List<Kistl.App.Projekte.Task> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Task>(this, "Tasks");
                    else
                        serverList = new List<Kistl.App.Projekte.Task>();

                    _Tasks = new BackReferenceCollection<Kistl.App.Projekte.Task>(
                         "Projekt", this, serverList);
                }
                return _Tasks;
            }
        }
        
        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                return _Mitarbeiter;
            }
        }
        
        public System.Double? AufwandGes
        {
            get
            {
                return _AufwandGes;
            }
            set
            {
                if(_AufwandGes != value)
                {
                    NotifyPropertyChanging("AufwandGes"); 
                    _AufwandGes = value; 
                    NotifyPropertyChanged("AufwandGes");
                };
            }
        }
        
        public string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                if(_Kundenname != value)
                {
                    NotifyPropertyChanging("Kundenname"); 
                    _Kundenname = value; 
                    NotifyPropertyChanged("Kundenname");
                };
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger
        {
            get
            {
                if (_Kostentraeger == null)
                {
                    List<Kistl.App.Zeiterfassung.Kostentraeger> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Zeiterfassung.Kostentraeger>(this, "Kostentraeger");
                    else
                        serverList = new List<Kistl.App.Zeiterfassung.Kostentraeger>();

                    _Kostentraeger = new BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger>(
                         "Projekt", this, serverList);
                }
                return _Kostentraeger;
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if (_Auftraege == null)
                {
                    List<Kistl.App.Projekte.Auftrag> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Auftrag>(this, "Auftraege");
                    else
                        serverList = new List<Kistl.App.Projekte.Auftrag>();

                    _Auftraege = new BackReferenceCollection<Kistl.App.Projekte.Auftrag>(
                         "Projekt", this, serverList);
                }
                return _Auftraege;
            }
        }
        
        public event ToStringHandler<Projekt> OnToString_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPreSave_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPostSave_Projekt;
        
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
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Projekt != null) OnPreSave_Projekt(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Projekt != null) OnPostSave_Projekt(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Projekt)obj).Name = this.Name;
            if(this._Tasks != null) this._Tasks.ApplyChanges(((Projekt)obj)._Tasks); else ((Projekt)obj)._Tasks = null; ((Projekt)obj).NotifyPropertyChanged("Tasks");
            this._Mitarbeiter.ApplyChanges(((Projekt)obj)._Mitarbeiter);
            ((Projekt)obj).AufwandGes = this.AufwandGes;
            ((Projekt)obj).Kundenname = this.Kundenname;
            if(this._Kostentraeger != null) this._Kostentraeger.ApplyChanges(((Projekt)obj)._Kostentraeger); else ((Projekt)obj)._Kostentraeger = null; ((Projekt)obj).NotifyPropertyChanged("Kostentraeger");
            if(this._Auftraege != null) this._Auftraege.ApplyChanges(((Projekt)obj)._Auftraege); else ((Projekt)obj)._Auftraege = null; ((Projekt)obj).NotifyPropertyChanged("Auftraege");
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            _Mitarbeiter.AttachToContext(ctx);
            if(_Tasks != null) _Tasks.AttachToContext(ctx);
            if(_Kostentraeger != null) _Kostentraeger.AttachToContext(ctx);
            if(_Auftraege != null) _Auftraege.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Name, sw);
            this._Mitarbeiter.ToStream(sw);
            BinarySerializer.ToBinary(this._AufwandGes, sw);
            BinarySerializer.ToBinary(this._Kundenname, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            this._Mitarbeiter.FromStream(sr);
            BinarySerializer.FromBinary(out this._AufwandGes, sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
        }
    }
    
    internal class Projekt_MitarbeiterCollectionEntry : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntry<Kistl.App.Projekte.Mitarbeiter, Projekt>
    {
        
        private int _ID;
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Value
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Mitarbeiter>().Single(o => o.ID == fk_Value);
            }
            set
            {
                fk_Value = value.ID;;
            }
        }
        
        [XmlIgnore()]
        public Projekt Parent
        {
            get
            {
                return Context.GetQuery<Projekt>().Single(o => o.ID == fk_Parent);
            }
            set
            {
                _fk_Parent = value.ID;
            }
        }
        
        public int fk_Value
        {
            get
            {
                return _fk_Value;
            }
            set
            {
                if(_fk_Value != value)
                {
                    base.NotifyPropertyChanging("Value");
                    _fk_Value = value;
                    base.NotifyPropertyChanged("Value");
                };
            }
        }
        
        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }
        
        public override void ApplyChanges(Kistl.API.ICollectionEntry obj)
        {
            base.ApplyChanges(obj);
            ((Projekt_MitarbeiterCollectionEntry)obj)._fk_Value = this.fk_Value;
            ((Projekt_MitarbeiterCollectionEntry)obj)._fk_Parent = this.fk_Parent;
        }
    }
}
