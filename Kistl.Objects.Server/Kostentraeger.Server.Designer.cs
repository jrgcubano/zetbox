//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Kostentraeger_Projekt", "A_Projekt", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Projekt), "B_Kostentraeger", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Zeiterfassung.Kostentraeger))]

namespace Kistl.App.Zeiterfassung
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Kostentraeger")]
    public class Kostentraeger : Kistl.App.Zeiterfassung.Zeitkonto, ICloneable
    {
        
        private int _fk_Projekt = Helper.INVALIDID;
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Kostentraeger_Projekt", "A_Projekt")]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Kostentraeger_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Kostentraeger_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Projekt
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Projekt == Helper.INVALIDID && Projekt != null)
                {
                    _fk_Projekt = Projekt.ID;
                }
                return _fk_Projekt;
            }
            set
            {
                _fk_Projekt = value;
            }
        }
        
        public event ToStringHandler<Kostentraeger> OnToString_Kostentraeger;
        
        public event ObjectEventHandler<Kostentraeger> OnPreSave_Kostentraeger;
        
        public event ObjectEventHandler<Kostentraeger> OnPostSave_Kostentraeger;
        
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
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kostentraeger != null) OnPreSave_Kostentraeger(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kostentraeger != null) OnPostSave_Kostentraeger(this);
        }
        
        public override object Clone()
        {
            Kostentraeger obj = new Kostentraeger();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Kostentraeger obj)
        {
            base.CopyTo(obj);
            obj.fk_Projekt = this.fk_Projekt;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
        }
    }
}
