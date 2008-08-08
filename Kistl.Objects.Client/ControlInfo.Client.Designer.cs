//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.GUI
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
    
    
    public class ControlInfo : BaseClientDataObject
    {
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private string _ClassName;
        
        private bool _IsContainer;
        
        private Kistl.App.GUI.Toolkit _Platform;
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        public ControlInfo()
        {
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
        
        public string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                if (ClassName != value)
                {
                    NotifyPropertyChanging("ClassName"); 
                    _ClassName = value;
                    NotifyPropertyChanged("ClassName");;
                }
            }
        }
        
        public bool IsContainer
        {
            get
            {
                return _IsContainer;
            }
            set
            {
                if (IsContainer != value)
                {
                    NotifyPropertyChanging("IsContainer"); 
                    _IsContainer = value;
                    NotifyPropertyChanged("IsContainer");;
                }
            }
        }
        
        public Kistl.App.GUI.Toolkit Platform
        {
            get
            {
                return _Platform;
            }
            set
            {
                if (Platform != value)
                {
                    NotifyPropertyChanging("Platform"); 
                    _Platform = value;
                    NotifyPropertyChanged("Platform");;
                }
            }
        }
        
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (ControlType != value)
                {
                    NotifyPropertyChanging("ControlType"); 
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType");;
                }
            }
        }
        
        public event ToStringHandler<ControlInfo> OnToString_ControlInfo;
        
        public event ObjectEventHandler<ControlInfo> OnPreSave_ControlInfo;
        
        public event ObjectEventHandler<ControlInfo> OnPostSave_ControlInfo;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ControlInfo != null)
            {
                OnToString_ControlInfo(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ControlInfo != null) OnPreSave_ControlInfo(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ControlInfo != null) OnPostSave_ControlInfo(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((ControlInfo)obj).fk_Assembly = this.fk_Assembly;
            ((ControlInfo)obj).ClassName = this.ClassName;
            ((ControlInfo)obj).IsContainer = this.IsContainer;
            ((ControlInfo)obj).Platform = this.Platform;
            ((ControlInfo)obj).ControlType = this.ControlType;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this._ClassName, sw);
            BinarySerializer.ToBinary(this._IsContainer, sw);
            BinarySerializer.ToBinary((int)this._Platform, sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinary(out this._ClassName, sr);
            BinarySerializer.FromBinary(out this._IsContainer, sr);
            int tmpPlatform; BinarySerializer.FromBinary(out tmpPlatform, sr); _Platform = (Kistl.App.GUI.Toolkit)tmpPlatform;
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (Kistl.App.GUI.VisualType)tmpControlType;
        }
    }
}
