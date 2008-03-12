//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Taetigkeit_Zeitkonto", "A_Zeitkonto", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Zeiterfassung.Zeitkonto), "B_Taetigkeit", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Zeiterfassung.Taetigkeit))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Taetigkeit_Mitarbeiter", "A_Mitarbeiter", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Mitarbeiter), "B_Taetigkeit", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Zeiterfassung.Taetigkeit))]

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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Taetigkeit")]
    public class Taetigkeit : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Zeitkonto = Helper.INVALIDID;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private System.DateTime _Datum;
        
        private double _Dauer;
        
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
        
        public override string EntitySetName
        {
            get
            {
                return "Taetigkeit";
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Taetigkeit_Zeitkonto", "A_Zeitkonto")]
        public Kistl.App.Zeiterfassung.Zeitkonto Zeitkonto
        {
            get
            {
                EntityReference<Kistl.App.Zeiterfassung.Zeitkonto> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Zeiterfassung.Zeitkonto>("Model.FK_Taetigkeit_Zeitkonto", "A_Zeitkonto");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Zeiterfassung.Zeitkonto> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Zeiterfassung.Zeitkonto>("Model.FK_Taetigkeit_Zeitkonto", "A_Zeitkonto");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Zeitkonto
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Zeitkonto == Helper.INVALIDID && Zeitkonto != null)
                {
                    _fk_Zeitkonto = Zeitkonto.ID;
                }
                return _fk_Zeitkonto;
            }
            set
            {
                _fk_Zeitkonto = value;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Taetigkeit_Mitarbeiter", "A_Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter>("Model.FK_Taetigkeit_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter>("Model.FK_Taetigkeit_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Mitarbeiter
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Mitarbeiter == Helper.INVALIDID && Mitarbeiter != null)
                {
                    _fk_Mitarbeiter = Mitarbeiter.ID;
                }
                return _fk_Mitarbeiter;
            }
            set
            {
                _fk_Mitarbeiter = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.DateTime Datum
        {
            get
            {
                return _Datum;
            }
            set
            {
                NotifyPropertyChanging("Datum"); 
                _Datum = value; 
                NotifyPropertyChanged("Datum");;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public double Dauer
        {
            get
            {
                return _Dauer;
            }
            set
            {
                NotifyPropertyChanging("Dauer"); 
                _Dauer = value; 
                NotifyPropertyChanged("Dauer");;
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
        
        public override object Clone()
        {
            Taetigkeit obj = new Taetigkeit();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Taetigkeit)obj)._fk_Zeitkonto = this._fk_Zeitkonto;
            ((Taetigkeit)obj)._fk_Mitarbeiter = this._fk_Mitarbeiter;
            ((Taetigkeit)obj)._Datum = this._Datum;
            ((Taetigkeit)obj)._Dauer = this._Dauer;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Zeitkonto, sw);
            BinarySerializer.ToBinary(this.fk_Mitarbeiter, sw);
            BinarySerializer.ToBinary(this._Datum, sw);
            BinarySerializer.ToBinary(this._Dauer, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Zeitkonto, sr);
            BinarySerializer.FromBinary(out this._fk_Mitarbeiter, sr);
            BinarySerializer.FromBinary(out this._Datum, sr);
            BinarySerializer.FromBinary(out this._Dauer, sr);
        }
    }
}
