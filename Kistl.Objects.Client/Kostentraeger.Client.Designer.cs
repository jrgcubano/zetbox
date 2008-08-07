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
    
    
    public class Kostentraeger : Kistl.App.Zeiterfassung.Zeitkonto
    {
        
        private System.Nullable<int> _fk_Projekt = null;
        
        public Kostentraeger()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                if (fk_Projekt == null) return null;
                return Context.Find<Kistl.App.Projekte.Projekt>(fk_Projekt.Value);
            }
            set
            {
                fk_Projekt = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Projekt
        {
            get
            {
                return _fk_Projekt;
            }
            set
            {
                if (fk_Projekt != value)
                {
                    NotifyPropertyChanging("Projekt"); 
                    _fk_Projekt = value;
                    NotifyPropertyChanged("Projekt");;
                }
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Kostentraeger)obj).fk_Projekt = this.fk_Projekt;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
        }
    }
}
