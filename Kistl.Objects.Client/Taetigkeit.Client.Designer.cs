//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Zeiterfassung
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
    
    
    public class Taetigkeit : BaseClientDataObject
    {
        
        private System.Nullable<int> _fk_Zeitkonto = null;
        
        private System.Nullable<int> _fk_Mitarbeiter = null;
        
        private System.DateTime _Datum;
        
        private double _Dauer;
        
        private System.Nullable<int> _fk_TaetigkeitsArt = null;
        
        public Taetigkeit()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Zeiterfassung.Zeitkonto Zeitkonto
        {
            get
            {
                if (fk_Zeitkonto == null) return null;
                return Context.Find<Kistl.App.Zeiterfassung.Zeitkonto>(fk_Zeitkonto.Value);
            }
            set
            {
                fk_Zeitkonto = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Zeitkonto
        {
            get
            {
                return _fk_Zeitkonto;
            }
            set
            {
                if (fk_Zeitkonto != value)
                {
                    NotifyPropertyChanging("Zeitkonto"); 
                    _fk_Zeitkonto = value;
                    NotifyPropertyChanged("Zeitkonto");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                if (fk_Mitarbeiter == null) return null;
                return Context.Find<Kistl.App.Projekte.Mitarbeiter>(fk_Mitarbeiter.Value);
            }
            set
            {
                fk_Mitarbeiter = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Mitarbeiter
        {
            get
            {
                return _fk_Mitarbeiter;
            }
            set
            {
                if (fk_Mitarbeiter != value)
                {
                    NotifyPropertyChanging("Mitarbeiter"); 
                    _fk_Mitarbeiter = value;
                    NotifyPropertyChanged("Mitarbeiter");;
                }
            }
        }
        
        public System.DateTime Datum
        {
            get
            {
                return _Datum;
            }
            set
            {
                if (Datum != value)
                {
                    NotifyPropertyChanging("Datum"); 
                    _Datum = value;
                    NotifyPropertyChanged("Datum");;
                }
            }
        }
        
        public double Dauer
        {
            get
            {
                return _Dauer;
            }
            set
            {
                if (Dauer != value)
                {
                    NotifyPropertyChanging("Dauer"); 
                    _Dauer = value;
                    NotifyPropertyChanged("Dauer");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Zeiterfassung.TaetigkeitsArt TaetigkeitsArt
        {
            get
            {
                if (fk_TaetigkeitsArt == null) return null;
                return Context.Find<Kistl.App.Zeiterfassung.TaetigkeitsArt>(fk_TaetigkeitsArt.Value);
            }
            set
            {
                fk_TaetigkeitsArt = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_TaetigkeitsArt
        {
            get
            {
                return _fk_TaetigkeitsArt;
            }
            set
            {
                if (fk_TaetigkeitsArt != value)
                {
                    NotifyPropertyChanging("TaetigkeitsArt"); 
                    _fk_TaetigkeitsArt = value;
                    NotifyPropertyChanged("TaetigkeitsArt");;
                }
            }
        }
        
        public event ToStringHandler<Taetigkeit> OnToString_Taetigkeit;
        
        public event ObjectEventHandler<Taetigkeit> OnPreSave_Taetigkeit;
        
        public event ObjectEventHandler<Taetigkeit> OnPostSave_Taetigkeit;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Taetigkeit != null)
            {
                OnToString_Taetigkeit(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Taetigkeit != null) OnPreSave_Taetigkeit(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Taetigkeit != null) OnPostSave_Taetigkeit(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Taetigkeit)obj).fk_Zeitkonto = this.fk_Zeitkonto;
            ((Taetigkeit)obj).fk_Mitarbeiter = this.fk_Mitarbeiter;
            ((Taetigkeit)obj).Datum = this.Datum;
            ((Taetigkeit)obj).Dauer = this.Dauer;
            ((Taetigkeit)obj).fk_TaetigkeitsArt = this.fk_TaetigkeitsArt;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Zeitkonto, sw);
            BinarySerializer.ToBinary(this.fk_Mitarbeiter, sw);
            BinarySerializer.ToBinary(this._Datum, sw);
            BinarySerializer.ToBinary(this._Dauer, sw);
            BinarySerializer.ToBinary(this.fk_TaetigkeitsArt, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Zeitkonto, sr);
            BinarySerializer.FromBinary(out this._fk_Mitarbeiter, sr);
            BinarySerializer.FromBinary(out this._Datum, sr);
            BinarySerializer.FromBinary(out this._Dauer, sr);
            BinarySerializer.FromBinary(out this._fk_TaetigkeitsArt, sr);
        }
    }
}
