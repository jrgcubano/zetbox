//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "A_Kunde", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Kunde), "B_Kunde_EMailsCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Kunde_EMailsCollectionEntry))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Kunde")]
    public class Kunde : BaseServerDataObject
    {
        
        private int _ID;
        
        private string _Kundenname;
        
        private string _Adresse;
        
        private string _PLZ;
        
        private string _Ort;
        
        private string _Land;
        
        public Kunde()
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
        
        [EdmScalarPropertyAttribute()]
        public string Adresse
        {
            get
            {
                return _Adresse;
            }
            set
            {
                if(_Adresse != value)
                {
                    NotifyPropertyChanging("Adresse"); 
                    _Adresse = value; 
                    NotifyPropertyChanged("Adresse");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string PLZ
        {
            get
            {
                return _PLZ;
            }
            set
            {
                if(_PLZ != value)
                {
                    NotifyPropertyChanging("PLZ"); 
                    _PLZ = value; 
                    NotifyPropertyChanged("PLZ");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string Ort
        {
            get
            {
                return _Ort;
            }
            set
            {
                if(_Ort != value)
                {
                    NotifyPropertyChanging("Ort"); 
                    _Ort = value; 
                    NotifyPropertyChanged("Ort");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string Land
        {
            get
            {
                return _Land;
            }
            set
            {
                if(_Land != value)
                {
                    NotifyPropertyChanging("Land"); 
                    _Land = value; 
                    NotifyPropertyChanged("Land");
                };
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "B_Kunde_EMailsCollectionEntry")]
        public EntityCollection<Kunde_EMailsCollectionEntry> EMails
        {
            get
            {
                EntityCollection<Kunde_EMailsCollectionEntry> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kunde_EMailsCollectionEntry>("Model.FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "B_Kunde_EMailsCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            EMails.ToList().ForEach<ICollectionEntry>(i => ctx.Attach(i));
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Kundenname, sw);
            BinarySerializer.ToBinary(this._Adresse, sw);
            BinarySerializer.ToBinary(this._PLZ, sw);
            BinarySerializer.ToBinary(this._Ort, sw);
            BinarySerializer.ToBinary(this._Land, sw);
            BinarySerializer.ToBinary(this.EMails, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
            BinarySerializer.FromBinary(out this._Adresse, sr);
            BinarySerializer.FromBinary(out this._PLZ, sr);
            BinarySerializer.FromBinary(out this._Ort, sr);
            BinarySerializer.FromBinary(out this._Land, sr);
            BinarySerializer.FromBinaryCollectionEntries(this.EMails, sr);
        }
    }
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Kunde_EMailsCollectionEntry")]
    public class Kunde_EMailsCollectionEntry : Kistl.API.Server.BaseServerCollectionEntry
    {
        
        private int _ID;
        
        private string _Value;
        
        private int _fk_Parent;
        
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
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if(_Value != value)
                {{
                    base.NotifyPropertyChanging("Value");
                    _Value = value;
                    base.NotifyPropertyChanged("Value");
                }};
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "A_Kunde")]
        public Kunde Parent
        {
            get
            {
                EntityReference<Kunde> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kunde>("Model.FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kunde> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kunde>("Model.FK_Kunde_EMailsCollectionEntry_Kunde_fk_Parent", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Parent
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Parent != null)
                {
                    _fk_Parent = Parent.ID;
                }
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
    }
}
