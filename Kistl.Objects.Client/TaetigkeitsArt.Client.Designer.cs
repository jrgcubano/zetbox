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
    
    
    public class TaetigkeitsArt : BaseClientDataObject, ICloneable
    {
        
        private int _ID;
        
        private string _Name;
        
        public TaetigkeitsArt()
        {
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
                NotifyPropertyChanging("Name"); 
                _Name = value; 
                NotifyPropertyChanged("Name");;
            }
        }
        
        public event ToStringHandler<TaetigkeitsArt> OnToString_TaetigkeitsArt;
        
        public event ObjectEventHandler<TaetigkeitsArt> OnPreSave_TaetigkeitsArt;
        
        public event ObjectEventHandler<TaetigkeitsArt> OnPostSave_TaetigkeitsArt;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TaetigkeitsArt != null)
            {
                OnToString_TaetigkeitsArt(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TaetigkeitsArt != null) OnPreSave_TaetigkeitsArt(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TaetigkeitsArt != null) OnPostSave_TaetigkeitsArt(this);
        }
        
        public override object Clone()
        {
            TaetigkeitsArt obj = new TaetigkeitsArt();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((TaetigkeitsArt)obj)._Name = this._Name;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Name, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Name, sr);
        }
    }
}
