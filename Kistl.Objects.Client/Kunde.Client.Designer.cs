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
    
    
    public class Kunde__Implementation__ : BaseClientDataObject, Kunde
    {
        
        private string _Kundenname;
        
        private string _Adresse;
        
        private string _PLZ;
        
        private string _Ort;
        
        private string _Land;
        
        private ListPropertyCollection<System.String, Kistl.App.Projekte.Kunde, Kunde_EMailsCollectionEntry__Implementation__> _EMails;
        
        public Kunde__Implementation__()
        {
            _EMails = new ListPropertyCollection<System.String, Kistl.App.Projekte.Kunde, Kunde_EMailsCollectionEntry__Implementation__>(this, "EMails");
        }
        
        public string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                if (Kundenname != value)
                {
                    NotifyPropertyChanging("Kundenname"); 
                    _Kundenname = value;
                    NotifyPropertyChanged("Kundenname");;
                }
            }
        }
        
        public string Adresse
        {
            get
            {
                return _Adresse;
            }
            set
            {
                if (Adresse != value)
                {
                    NotifyPropertyChanging("Adresse"); 
                    _Adresse = value;
                    NotifyPropertyChanged("Adresse");;
                }
            }
        }
        
        public string PLZ
        {
            get
            {
                return _PLZ;
            }
            set
            {
                if (PLZ != value)
                {
                    NotifyPropertyChanging("PLZ"); 
                    _PLZ = value;
                    NotifyPropertyChanged("PLZ");;
                }
            }
        }
        
        public string Ort
        {
            get
            {
                return _Ort;
            }
            set
            {
                if (Ort != value)
                {
                    NotifyPropertyChanging("Ort"); 
                    _Ort = value;
                    NotifyPropertyChanged("Ort");;
                }
            }
        }
        
        public string Land
        {
            get
            {
                return _Land;
            }
            set
            {
                if (Land != value)
                {
                    NotifyPropertyChanging("Land"); 
                    _Land = value;
                    NotifyPropertyChanged("Land");;
                }
            }
        }
        
        public IList<System.String> EMails
        {
            get
            {
                return _EMails;
            }
        }
        
        public event ToStringHandler<Kunde> OnToString_Kunde;
        
        public event ObjectEventHandler<Kunde> OnPreSave_Kunde;
        
        public event ObjectEventHandler<Kunde> OnPostSave_Kunde;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kunde != null)
            {
                OnToString_Kunde(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kunde != null) OnPreSave_Kunde(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kunde != null) OnPostSave_Kunde(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Kunde__Implementation__)obj).Kundenname = this.Kundenname;
            ((Kunde__Implementation__)obj).Adresse = this.Adresse;
            ((Kunde__Implementation__)obj).PLZ = this.PLZ;
            ((Kunde__Implementation__)obj).Ort = this.Ort;
            ((Kunde__Implementation__)obj).Land = this.Land;
            this._EMails.ApplyChanges(((Kunde__Implementation__)obj)._EMails);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            _EMails.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Kundenname, sw);
            BinarySerializer.ToBinary(this._Adresse, sw);
            BinarySerializer.ToBinary(this._PLZ, sw);
            BinarySerializer.ToBinary(this._Ort, sw);
            BinarySerializer.ToBinary(this._Land, sw);
            this._EMails.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
            BinarySerializer.FromBinary(out this._Adresse, sr);
            BinarySerializer.FromBinary(out this._PLZ, sr);
            BinarySerializer.FromBinary(out this._Ort, sr);
            BinarySerializer.FromBinary(out this._Land, sr);
            this._EMails.FromStream(sr);
        }
    }
    
    public class Kunde_EMailsCollectionEntry__Implementation__ : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntry<System.String, Kistl.App.Projekte.Kunde>
    {
        
        private string _Value;
        
        private int _fk_Parent;
        
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (Value != value)
                {
                    NotifyPropertyChanging("Value"); 
                    _Value = value;
                    NotifyPropertyChanged("Value");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde Parent
        {
            get
            {
                return Context.GetQuery<Kunde>().Single(o => o.ID == fk_Parent);
            }
            set
            {
                /// TODO: Damit hab ich noch ein Problem. Wenn die Property not nullable ist, dann sollte das eigentlich nicht möglich sein.
                _fk_Parent = value.ID;
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
            BinarySerializer.ToBinary(this.Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }
        
        public override void ApplyChanges(Kistl.API.ICollectionEntry obj)
        {
            base.ApplyChanges(obj);
            ((Kunde_EMailsCollectionEntry__Implementation__)obj)._Value = this._Value;
            ((Kunde_EMailsCollectionEntry__Implementation__)obj)._fk_Parent = this._fk_Parent;
        }
    }
}
