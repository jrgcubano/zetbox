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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.GUI.ControlInfo")]
    public class ControlInfo__Implementation__ : BaseClientDataObject, ControlInfo
    {
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private string _ClassName;
        
        private bool _IsContainer;
        
        private Kistl.App.GUI.Toolkit _Platform;
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        public ControlInfo__Implementation__()
        {
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
                if (IsReadonly) throw new ReadOnlyObjectException();
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
            ((ControlInfo__Implementation__)obj).fk_Assembly = this.fk_Assembly;
            ((ControlInfo__Implementation__)obj).ClassName = this.ClassName;
            ((ControlInfo__Implementation__)obj).IsContainer = this.IsContainer;
            ((ControlInfo__Implementation__)obj).Platform = this.Platform;
            ((ControlInfo__Implementation__)obj).ControlType = this.ControlType;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Assembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(114).Constraints
                            .Where(c => !c.IsValid(this, this.Assembly))
                            .Select(c => c.GetErrorText(this, this.Assembly))
                            .ToArray());
                case "ClassName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(115).Constraints
                            .Where(c => !c.IsValid(this, this.ClassName))
                            .Select(c => c.GetErrorText(this, this.ClassName))
                            .ToArray());
                case "IsContainer":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(116).Constraints
                            .Where(c => !c.IsValid(this, this.IsContainer))
                            .Select(c => c.GetErrorText(this, this.IsContainer))
                            .ToArray());
                case "Platform":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(117).Constraints
                            .Where(c => !c.IsValid(this, this.Platform))
                            .Select(c => c.GetErrorText(this, this.Platform))
                            .ToArray());
                case "ControlType":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(118).Constraints
                            .Where(c => !c.IsValid(this, this.ControlType))
                            .Select(c => c.GetErrorText(this, this.ControlType))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
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
