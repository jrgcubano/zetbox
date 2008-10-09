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
    
    
    public class StringRangeConstraint__Implementation__ : Kistl.App.Base.Constraint__Implementation__, StringRangeConstraint
    {
        
        private int _MaxLength;
        
        private int _MinLength;
        
        public StringRangeConstraint__Implementation__()
        {
        }
        
        public int MaxLength
        {
            get
            {
                return _MaxLength;
            }
            set
            {
                if (MaxLength != value)
                {
                    NotifyPropertyChanging("MaxLength"); 
                    _MaxLength = value;
                    NotifyPropertyChanged("MaxLength");;
                }
            }
        }
        
        public int MinLength
        {
            get
            {
                return _MinLength;
            }
            set
            {
                if (MinLength != value)
                {
                    NotifyPropertyChanging("MinLength"); 
                    _MinLength = value;
                    NotifyPropertyChanged("MinLength");;
                }
            }
        }
        
        public event ToStringHandler<StringRangeConstraint> OnToString_StringRangeConstraint;
        
        public event ObjectEventHandler<StringRangeConstraint> OnPreSave_StringRangeConstraint;
        
        public event ObjectEventHandler<StringRangeConstraint> OnPostSave_StringRangeConstraint;
        
        public event IsValid_Handler<StringRangeConstraint> OnIsValid_StringRangeConstraint;
        
        public event GetErrorText_Handler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringRangeConstraint != null)
            {
                OnToString_StringRangeConstraint(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringRangeConstraint != null) OnPreSave_StringRangeConstraint(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringRangeConstraint != null) OnPostSave_StringRangeConstraint(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((StringRangeConstraint__Implementation__)obj).MaxLength = this.MaxLength;
            ((StringRangeConstraint__Implementation__)obj).MinLength = this.MinLength;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override bool IsValid(object value)
        {
            MethodReturnEventArgs<System.Boolean> e = new MethodReturnEventArgs<System.Boolean>();
            e.Result = base.IsValid(value);
            if (OnIsValid_StringRangeConstraint != null)
            {
                OnIsValid_StringRangeConstraint(this, e, value);
            };
            return e.Result;
        }
        
        public override string GetErrorText(object value)
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetErrorText(value);
            if (OnGetErrorText_StringRangeConstraint != null)
            {
                OnGetErrorText_StringRangeConstraint(this, e, value);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._MaxLength, sw);
            BinarySerializer.ToBinary(this._MinLength, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._MaxLength, sr);
            BinarySerializer.FromBinary(out this._MinLength, sr);
        }
    }
}
