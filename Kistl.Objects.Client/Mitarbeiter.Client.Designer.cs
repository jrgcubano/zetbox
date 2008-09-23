//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3053
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
    using Kistl.API.Client;
    
    
    public class Mitarbeiter__Implementation__ : BaseClientDataObject, Mitarbeiter
    {
        
        private string _Name;
        
        private BackReferenceCollection<Kistl.App.Projekte.Projekt> _Projekte;
        
        private System.DateTime? _Geburtstag;
        
        private string _SVNr;
        
        private string _TelefonNummer;
        
        public Mitarbeiter__Implementation__()
        {
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Name != value)
                {
                    NotifyPropertyChanging("Name"); 
                    _Name = value;
                    NotifyPropertyChanged("Name");;
                }
            }
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Projekte.Projekt> Projekte
        {
            get
            {
                if (_Projekte == null)
                {
                    List<Kistl.App.Projekte.Projekt> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Projekt>(this, "Projekte");
                    else
                        serverList = new List<Kistl.App.Projekte.Projekt>();

                    _Projekte = new BackReferenceCollection<Kistl.App.Projekte.Projekt>(
                         "Mitarbeiter", this, serverList);
                }
                return _Projekte;
            }
        }
        
        public System.DateTime? Geburtstag
        {
            get
            {
                return _Geburtstag;
            }
            set
            {
                if (Geburtstag != value)
                {
                    NotifyPropertyChanging("Geburtstag"); 
                    _Geburtstag = value;
                    NotifyPropertyChanged("Geburtstag");;
                }
            }
        }
        
        public string SVNr
        {
            get
            {
                return _SVNr;
            }
            set
            {
                if (SVNr != value)
                {
                    NotifyPropertyChanging("SVNr"); 
                    _SVNr = value;
                    NotifyPropertyChanged("SVNr");;
                }
            }
        }
        
        public string TelefonNummer
        {
            get
            {
                return _TelefonNummer;
            }
            set
            {
                if (TelefonNummer != value)
                {
                    NotifyPropertyChanging("TelefonNummer"); 
                    _TelefonNummer = value;
                    NotifyPropertyChanged("TelefonNummer");;
                }
            }
        }
        
        public event ToStringHandler<Mitarbeiter> OnToString_Mitarbeiter;
        
        public event ObjectEventHandler<Mitarbeiter> OnPreSave_Mitarbeiter;
        
        public event ObjectEventHandler<Mitarbeiter> OnPostSave_Mitarbeiter;
        
        public event TestMethodForParameter_Handler<Mitarbeiter> OnTestMethodForParameter_Mitarbeiter;
        
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
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Mitarbeiter != null) OnPreSave_Mitarbeiter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Mitarbeiter != null) OnPostSave_Mitarbeiter(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Mitarbeiter__Implementation__)obj).Name = this.Name;
            if(this._Projekte != null) this._Projekte.ApplyChanges(((Mitarbeiter__Implementation__)obj)._Projekte); else ((Mitarbeiter__Implementation__)obj)._Projekte = null; ((Mitarbeiter__Implementation__)obj).NotifyPropertyChanged("Projekte");
            ((Mitarbeiter__Implementation__)obj).Geburtstag = this.Geburtstag;
            ((Mitarbeiter__Implementation__)obj).SVNr = this.SVNr;
            ((Mitarbeiter__Implementation__)obj).TelefonNummer = this.TelefonNummer;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_Projekte != null) _Projekte.AttachToContext(ctx);
        }
        
        public virtual System.DateTime TestMethodForParameter(string TestString, int TestInt, double TestDouble, bool TestBool, System.DateTime TestDateTime, Kistl.App.Projekte.Auftrag TestObjectParameter, System.Guid TestCLRObjectParameter)
        {
            MethodReturnEventArgs<System.DateTime> e = new MethodReturnEventArgs<System.DateTime>();
            if (OnTestMethodForParameter_Mitarbeiter != null)
            {
                OnTestMethodForParameter_Mitarbeiter(this, e, TestString, TestInt, TestDouble, TestBool, TestDateTime, TestObjectParameter, TestCLRObjectParameter);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Name, sw);
            BinarySerializer.ToBinary(this._Geburtstag, sw);
            BinarySerializer.ToBinary(this._SVNr, sw);
            BinarySerializer.ToBinary(this._TelefonNummer, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            BinarySerializer.FromBinary(out this._Geburtstag, sr);
            BinarySerializer.FromBinary(out this._SVNr, sr);
            BinarySerializer.FromBinary(out this._TelefonNummer, sr);
        }
        
        public delegate void TestMethodForParameter_Handler<T>(T obj, MethodReturnEventArgs<System.DateTime> e, string TestString, int TestInt, double TestDouble, bool TestBool, System.DateTime TestDateTime, Kistl.App.Projekte.Auftrag TestObjectParameter, System.Guid TestCLRObjectParameter);
    }
}
