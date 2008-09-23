//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3053
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
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
    
    
    public class MethodInvocation__Implementation__ : BaseClientDataObject, MethodInvocation
    {
        
        private System.Nullable<int> _fk_Method = null;
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private string _FullTypeName;
        
        private string _MemberName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private System.Nullable<int> _fk_InvokeOnObjectClass = null;
        
        public MethodInvocation__Implementation__()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Method Method
        {
            get
            {
                if (fk_Method == null) return null;
                return Context.Find<Kistl.App.Base.Method>(fk_Method.Value);
            }
            set
            {
                fk_Method = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Method
        {
            get
            {
                return _fk_Method;
            }
            set
            {
                if (fk_Method != value)
                {
                    NotifyPropertyChanging("Method"); 
                    _fk_Method = value;
                    NotifyPropertyChanged("Method");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                if (fk_Assembly == null) return null;
                return Context.Find<Kistl.App.Base.Assembly>(fk_Assembly.Value);
            }
            set
            {
                fk_Assembly = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Assembly
        {
            get
            {
                return _fk_Assembly;
            }
            set
            {
                if (fk_Assembly != value)
                {
                    NotifyPropertyChanging("Assembly"); 
                    _fk_Assembly = value;
                    NotifyPropertyChanged("Assembly");;
                }
            }
        }
        
        public string FullTypeName
        {
            get
            {
                return _FullTypeName;
            }
            set
            {
                if (FullTypeName != value)
                {
                    NotifyPropertyChanging("FullTypeName"); 
                    _FullTypeName = value;
                    NotifyPropertyChanged("FullTypeName");;
                }
            }
        }
        
        public string MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                if (MemberName != value)
                {
                    NotifyPropertyChanging("MemberName"); 
                    _MemberName = value;
                    NotifyPropertyChanged("MemberName");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (fk_Module == null) return null;
                return Context.Find<Kistl.App.Base.Module>(fk_Module.Value);
            }
            set
            {
                fk_Module = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                if (fk_Module != value)
                {
                    NotifyPropertyChanging("Module"); 
                    _fk_Module = value;
                    NotifyPropertyChanged("Module");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.DataType InvokeOnObjectClass
        {
            get
            {
                if (fk_InvokeOnObjectClass == null) return null;
                return Context.Find<Kistl.App.Base.DataType>(fk_InvokeOnObjectClass.Value);
            }
            set
            {
                fk_InvokeOnObjectClass = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_InvokeOnObjectClass
        {
            get
            {
                return _fk_InvokeOnObjectClass;
            }
            set
            {
                if (fk_InvokeOnObjectClass != value)
                {
                    NotifyPropertyChanging("InvokeOnObjectClass"); 
                    _fk_InvokeOnObjectClass = value;
                    NotifyPropertyChanged("InvokeOnObjectClass");;
                }
            }
        }
        
        public event ToStringHandler<MethodInvocation> OnToString_MethodInvocation;
        
        public event ObjectEventHandler<MethodInvocation> OnPreSave_MethodInvocation;
        
        public event ObjectEventHandler<MethodInvocation> OnPostSave_MethodInvocation;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MethodInvocation != null)
            {
                OnToString_MethodInvocation(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_MethodInvocation != null) OnPreSave_MethodInvocation(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_MethodInvocation != null) OnPostSave_MethodInvocation(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((MethodInvocation__Implementation__)obj).fk_Method = this.fk_Method;
            ((MethodInvocation__Implementation__)obj).fk_Assembly = this.fk_Assembly;
            ((MethodInvocation__Implementation__)obj).FullTypeName = this.FullTypeName;
            ((MethodInvocation__Implementation__)obj).MemberName = this.MemberName;
            ((MethodInvocation__Implementation__)obj).fk_Module = this.fk_Module;
            ((MethodInvocation__Implementation__)obj).fk_InvokeOnObjectClass = this.fk_InvokeOnObjectClass;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this._FullTypeName, sw);
            BinarySerializer.ToBinary(this._MemberName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.fk_InvokeOnObjectClass, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinary(out this._FullTypeName, sr);
            BinarySerializer.FromBinary(out this._MemberName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._fk_InvokeOnObjectClass, sr);
        }
    }
}
