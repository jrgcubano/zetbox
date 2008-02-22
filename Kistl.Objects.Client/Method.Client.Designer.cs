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
    
    
    public class Method : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_ObjectClass = Helper.INVALIDID;
        
        private string _MethodName;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private List<Kistl.App.Base.MethodInvocation> _MethodIvokations;
        
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
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.ObjectClass>().Single(o => o.ID == fk_ObjectClass);
            }
            set
            {
                _fk_ObjectClass = value.ID;
            }
        }
        
        public int fk_ObjectClass
        {
            get
            {
                return _fk_ObjectClass;
            }
            set
            {
                _fk_ObjectClass = value;
            }
        }
        
        public string MethodName
        {
            get
            {
                return _MethodName;
            }
            set
            {
                _MethodName = value;
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
        
        [XmlIgnore()]
        public List<Kistl.App.Base.MethodInvocation> MethodIvokations
        {
            get
            {
                if(_MethodIvokations == null) _MethodIvokations = Context.GetListOf<Kistl.App.Base.MethodInvocation>(this, "MethodIvokations");
                return _MethodIvokations;
            }
        }
        
        public event ToStringHandler<Method> OnToString_Method;
        
        public event ObjectEventHandler<Method> OnPreSave_Method;
        
        public event ObjectEventHandler<Method> OnPostSave_Method;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Method != null)
            {
                OnToString_Method(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Method != null) OnPreSave_Method(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Method != null) OnPostSave_Method(this);
        }
        
        public override object Clone()
        {
            Method obj = new Method();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Method)obj).fk_ObjectClass = this.fk_ObjectClass;
            ((Method)obj).NotifyPropertyChanging("MethodName");
            ((Method)obj).MethodName = this.MethodName;
            ((Method)obj).NotifyPropertyChanged("MethodName");
            ((Method)obj).fk_Module = this.fk_Module;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this.MethodName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._MethodName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
        }
    }
}
