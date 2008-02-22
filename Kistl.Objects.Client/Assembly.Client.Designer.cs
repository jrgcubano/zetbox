//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
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
    using Kistl.API.Client;
    
    
    public class Assembly : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private string _AssemblyName;
        
        private bool _IsClientAssembly;
        
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
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.Module>().Single(o => o.ID == fk_Module);
            }
            set
            {
                _fk_Module = value.ID;
            }
        }
        
        public int fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                _fk_Module = value;
            }
        }
        
        public string AssemblyName
        {
            get
            {
                return _AssemblyName;
            }
            set
            {
                _AssemblyName = value;
            }
        }
        
        public bool IsClientAssembly
        {
            get
            {
                return _IsClientAssembly;
            }
            set
            {
                _IsClientAssembly = value;
            }
        }
        
        public event ToStringHandler<Assembly> OnToString_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPreSave_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPostSave_Assembly;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Assembly != null)
            {
                OnToString_Assembly(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Assembly != null) OnPreSave_Assembly(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Assembly != null) OnPostSave_Assembly(this);
        }
        
        public override object Clone()
        {
            Assembly obj = new Assembly();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Assembly)obj).fk_Module = this.fk_Module;
            ((Assembly)obj).NotifyPropertyChanging("AssemblyName");
            ((Assembly)obj).AssemblyName = this.AssemblyName;
            ((Assembly)obj).NotifyPropertyChanged("AssemblyName");
            ((Assembly)obj).NotifyPropertyChanging("IsClientAssembly");
            ((Assembly)obj).IsClientAssembly = this.IsClientAssembly;
            ((Assembly)obj).NotifyPropertyChanged("IsClientAssembly");
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.AssemblyName, sw);
            BinarySerializer.ToBinary(this.IsClientAssembly, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._AssemblyName, sr);
            BinarySerializer.FromBinary(out this._IsClientAssembly, sr);
        }
    }
}
