//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Task_Projekt", "A_Projekt", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Projekt), "B_Task", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Task))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Task")]
    public class Task : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Projekt = Helper.INVALIDID;
        
        private string _Name;
        
        private System.DateTime? _DatumVon;
        
        private System.DateTime? _DatumBis;
        
        private System.Double? _Aufwand;
        
        public Task()
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
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Task_Projekt", "A_Projekt")]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Task_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Task_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Projekt
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Projekt != null)
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
        
        [EdmScalarPropertyAttribute()]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                NotifyPropertyChanging("Name"); 
                _Name = value; 
                NotifyPropertyChanged("Name");;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.DateTime? DatumVon
        {
            get
            {
                return _DatumVon;
            }
            set
            {
                NotifyPropertyChanging("DatumVon"); 
                _DatumVon = value; 
                NotifyPropertyChanged("DatumVon");;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.DateTime? DatumBis
        {
            get
            {
                return _DatumBis;
            }
            set
            {
                NotifyPropertyChanging("DatumBis"); 
                _DatumBis = value; 
                NotifyPropertyChanged("DatumBis");;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.Double? Aufwand
        {
            get
            {
                return _Aufwand;
            }
            set
            {
                NotifyPropertyChanging("Aufwand"); 
                _Aufwand = value; 
                NotifyPropertyChanged("Aufwand");;
            }
        }
        
        public event ToStringHandler<Task> OnToString_Task;
        
        public event ObjectEventHandler<Task> OnPreSave_Task;
        
        public event ObjectEventHandler<Task> OnPostSave_Task;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Task != null)
            {
                OnToString_Task(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Task != null) OnPreSave_Task(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Task != null) OnPostSave_Task(this);
        }
        
        public override object Clone()
        {
            Task obj = new Task();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Task)obj)._fk_Projekt = this._fk_Projekt;
            ((Task)obj)._Name = this._Name;
            ((Task)obj)._DatumVon = this._DatumVon;
            ((Task)obj)._DatumBis = this._DatumBis;
            ((Task)obj)._Aufwand = this._Aufwand;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
            BinarySerializer.ToBinary(this._Name, sw);
            BinarySerializer.ToBinary(this._DatumVon, sw);
            BinarySerializer.ToBinary(this._DatumBis, sw);
            BinarySerializer.ToBinary(this._Aufwand, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            BinarySerializer.FromBinary(out this._DatumVon, sr);
            BinarySerializer.FromBinary(out this._DatumBis, sr);
            BinarySerializer.FromBinary(out this._Aufwand, sr);
        }
    }
}
