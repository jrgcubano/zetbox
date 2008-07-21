//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class ObjectReferenceProperty : Kistl.App.Base.Property
    {
        
        private System.Nullable<int> _fk_ReferenceObjectClass = null;
        
        public ObjectReferenceProperty()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass ReferenceObjectClass
        {
            get
            {
                if (fk_ReferenceObjectClass == null) return null;
                return Context.Find<Kistl.App.Base.ObjectClass>(fk_ReferenceObjectClass.Value);
            }
            set
            {
                fk_ReferenceObjectClass = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_ReferenceObjectClass
        {
            get
            {
                return _fk_ReferenceObjectClass;
            }
            set
            {
                if (fk_ReferenceObjectClass != value)
                {
                    NotifyPropertyChanging("ReferenceObjectClass"); 
                    _fk_ReferenceObjectClass = value;
                    NotifyPropertyChanged("ReferenceObjectClass");;
                }
            }
        }
        
        public event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;
        
        public event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;
        
        public event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;
        
        public event GetDataType_Handler<ObjectReferenceProperty> OnGetDataType_ObjectReferenceProperty;
        
        public event GetGUIRepresentation_Handler<ObjectReferenceProperty> OnGetGUIRepresentation_ObjectReferenceProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceProperty != null)
            {
                OnToString_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceProperty != null) OnPreSave_ObjectReferenceProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceProperty != null) OnPostSave_ObjectReferenceProperty(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((ObjectReferenceProperty)obj).fk_ReferenceObjectClass = this.fk_ReferenceObjectClass;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_ObjectReferenceProperty != null)
            {
                OnGetDataType_ObjectReferenceProperty(this, e);
            };
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_ObjectReferenceProperty != null)
            {
                OnGetGUIRepresentation_ObjectReferenceProperty(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ReferenceObjectClass, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ReferenceObjectClass, sr);
        }
    }
}
