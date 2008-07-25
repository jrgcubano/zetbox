//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Mitarbeiter")]
    public class Mitarbeiter : BaseServerDataObject
    {
        
        private int _ID;
        
        private string _Name;
        
        private System.DateTime? _Geburtstag;
        
        private string _SVNr;
        
        private string _TelefonNummer;
        
        public Mitarbeiter()
        {
        }
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
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
        
        [EdmScalarPropertyAttribute()]
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
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "B_Projekt_MitarbeiterCollectionEntry")]
        public EntityCollection<Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry> Projekte
        {
            get
            {
                EntityCollection<Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry>("Model.FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "B_Projekt_MitarbeiterCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.DateTime? Geburtstag
        {
            get
            {
                return _Geburtstag;
            }
            set
            {
                if(_Geburtstag != value)
                {
                    NotifyPropertyChanging("Geburtstag"); 
                    _Geburtstag = value; 
                    NotifyPropertyChanged("Geburtstag");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string SVNr
        {
            get
            {
                return _SVNr;
            }
            set
            {
                if(_SVNr != value)
                {
                    NotifyPropertyChanging("SVNr"); 
                    _SVNr = value; 
                    NotifyPropertyChanged("SVNr");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string TelefonNummer
        {
            get
            {
                return _TelefonNummer;
            }
            set
            {
                if(_TelefonNummer != value)
                {
                    NotifyPropertyChanging("TelefonNummer"); 
                    _TelefonNummer = value; 
                    NotifyPropertyChanged("TelefonNummer");
                };
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
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
