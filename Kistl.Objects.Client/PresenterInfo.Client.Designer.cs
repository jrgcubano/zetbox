//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
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
    using Kistl.API.Client;
    
    
    public class PresenterInfo__Implementation__ : BaseClientDataObject, PresenterInfo
    {
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        private System.Nullable<int> _fk_PresenterAssembly = null;
        
        private string _PresenterTypeName;
        
        private System.Nullable<int> _fk_DataAssembly = null;
        
        private string _DataTypeName;
        
        public PresenterInfo__Implementation__()
        {
        }
        
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ControlType != value)
                {
                    NotifyPropertyChanging("ControlType"); 
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Assembly PresenterAssembly
        {
            get
            {
                if (fk_PresenterAssembly == null) return null;
                return Context.Find<Kistl.App.Base.Assembly>(fk_PresenterAssembly.Value);
            }
            set
            {
                fk_PresenterAssembly = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_PresenterAssembly
        {
            get
            {
                return _fk_PresenterAssembly;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_PresenterAssembly != value)
                {
                    NotifyPropertyChanging("PresenterAssembly"); 
                    _fk_PresenterAssembly = value;
                    NotifyPropertyChanged("PresenterAssembly");;
                }
            }
        }
        
        public string PresenterTypeName
        {
            get
            {
                return _PresenterTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (PresenterTypeName != value)
                {
                    NotifyPropertyChanging("PresenterTypeName"); 
                    _PresenterTypeName = value;
                    NotifyPropertyChanged("PresenterTypeName");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Assembly DataAssembly
        {
            get
            {
                if (fk_DataAssembly == null) return null;
                return Context.Find<Kistl.App.Base.Assembly>(fk_DataAssembly.Value);
            }
            set
            {
                fk_DataAssembly = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_DataAssembly
        {
            get
            {
                return _fk_DataAssembly;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_DataAssembly != value)
                {
                    NotifyPropertyChanging("DataAssembly"); 
                    _fk_DataAssembly = value;
                    NotifyPropertyChanged("DataAssembly");;
                }
            }
        }
        
        public string DataTypeName
        {
            get
            {
                return _DataTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (DataTypeName != value)
                {
                    NotifyPropertyChanging("DataTypeName"); 
                    _DataTypeName = value;
                    NotifyPropertyChanged("DataTypeName");;
                }
            }
        }
        
        public event ToStringHandler<PresenterInfo> OnToString_PresenterInfo;
        
        public event ObjectEventHandler<PresenterInfo> OnPreSave_PresenterInfo;
        
        public event ObjectEventHandler<PresenterInfo> OnPostSave_PresenterInfo;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PresenterInfo != null)
            {
                OnToString_PresenterInfo(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PresenterInfo != null) OnPreSave_PresenterInfo(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PresenterInfo != null) OnPostSave_PresenterInfo(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((PresenterInfo__Implementation__)obj).ControlType = this.ControlType;
            ((PresenterInfo__Implementation__)obj).fk_PresenterAssembly = this.fk_PresenterAssembly;
            ((PresenterInfo__Implementation__)obj).PresenterTypeName = this.PresenterTypeName;
            ((PresenterInfo__Implementation__)obj).fk_DataAssembly = this.fk_DataAssembly;
            ((PresenterInfo__Implementation__)obj).DataTypeName = this.DataTypeName;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ControlType":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(137).Constraints
                            .Where(c => !c.IsValid(this, this.ControlType))
                            .Select(c => c.GetErrorText(this, this.ControlType))
                            .ToArray());
                case "PresenterAssembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(138).Constraints
                            .Where(c => !c.IsValid(this, this.PresenterAssembly))
                            .Select(c => c.GetErrorText(this, this.PresenterAssembly))
                            .ToArray());
                case "PresenterTypeName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(139).Constraints
                            .Where(c => !c.IsValid(this, this.PresenterTypeName))
                            .Select(c => c.GetErrorText(this, this.PresenterTypeName))
                            .ToArray());
                case "DataAssembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(147).Constraints
                            .Where(c => !c.IsValid(this, this.DataAssembly))
                            .Select(c => c.GetErrorText(this, this.DataAssembly))
                            .ToArray());
                case "DataTypeName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(148).Constraints
                            .Where(c => !c.IsValid(this, this.DataTypeName))
                            .Select(c => c.GetErrorText(this, this.DataTypeName))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
            BinarySerializer.ToBinary(this.fk_PresenterAssembly, sw);
            BinarySerializer.ToBinary(this._PresenterTypeName, sw);
            BinarySerializer.ToBinary(this.fk_DataAssembly, sw);
            BinarySerializer.ToBinary(this._DataTypeName, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (Kistl.App.GUI.VisualType)tmpControlType;
            BinarySerializer.FromBinary(out this._fk_PresenterAssembly, sr);
            BinarySerializer.FromBinary(out this._PresenterTypeName, sr);
            BinarySerializer.FromBinary(out this._fk_DataAssembly, sr);
            BinarySerializer.FromBinary(out this._DataTypeName, sr);
        }
    }
}
