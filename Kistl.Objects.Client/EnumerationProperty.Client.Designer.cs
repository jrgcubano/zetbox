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
    
    
    public class EnumerationProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, EnumerationProperty
    {
        
        private System.Nullable<int> _fk_Enumeration = null;
        
        public EnumerationProperty__Implementation__()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                if (fk_Enumeration == null) return null;
                return Context.Find<Kistl.App.Base.Enumeration>(fk_Enumeration.Value);
            }
            set
            {
                fk_Enumeration = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Enumeration
        {
            get
            {
                return _fk_Enumeration;
            }
            set
            {
                if (fk_Enumeration != value)
                {
                    NotifyPropertyChanging("Enumeration"); 
                    _fk_Enumeration = value;
                    NotifyPropertyChanged("Enumeration");;
                }
            }
        }
        
        public event ToStringHandler<EnumerationProperty> OnToString_EnumerationProperty;
        
        public event ObjectEventHandler<EnumerationProperty> OnPreSave_EnumerationProperty;
        
        public event ObjectEventHandler<EnumerationProperty> OnPostSave_EnumerationProperty;
        
        public event GetPropertyTypeString_Handler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty;
        
        public event GetGUIRepresentation_Handler<EnumerationProperty> OnGetGUIRepresentation_EnumerationProperty;
        
        public event GetPropertyType_Handler<EnumerationProperty> OnGetPropertyType_EnumerationProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationProperty != null)
            {
                OnToString_EnumerationProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationProperty != null) OnPreSave_EnumerationProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationProperty != null) OnPostSave_EnumerationProperty(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((EnumerationProperty__Implementation__)obj).fk_Enumeration = this.fk_Enumeration;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetPropertyTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetPropertyTypeString();
            if (OnGetPropertyTypeString_EnumerationProperty != null)
            {
                OnGetPropertyTypeString_EnumerationProperty(this, e);
            };
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_EnumerationProperty != null)
            {
                OnGetGUIRepresentation_EnumerationProperty(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetPropertyType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetPropertyType();
            if (OnGetPropertyType_EnumerationProperty != null)
            {
                OnGetPropertyType_EnumerationProperty(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Enumeration, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Enumeration, sr);
        }
    }
}
