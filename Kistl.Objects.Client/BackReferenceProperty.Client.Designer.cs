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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Client;
    
    
    public class BackReferenceProperty : Kistl.App.Base.BaseProperty
    {
        
        private int _fk_ReferenceProperty = Helper.INVALIDID;
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectReferenceProperty ReferenceProperty
        {
            get
            {
                return this.GetObject<Kistl.App.Base.ObjectReferenceProperty>(fk_ReferenceProperty);
            }
            set
            {
                _fk_ReferenceProperty = value.ID;
            }
        }
        
        public int fk_ReferenceProperty
        {
            get
            {
                return _fk_ReferenceProperty;
            }
            set
            {
                _fk_ReferenceProperty = value;
            }
        }
        
        public event ToStringHandler<BackReferenceProperty> OnToString_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPreSave_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPostSave_BackReferenceProperty;
        
        public event GetDataType_Handler<BackReferenceProperty> OnGetDataType_BackReferenceProperty;
        
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BackReferenceProperty != null)
            {
                OnToString_BackReferenceProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BackReferenceProperty != null) OnPreSave_BackReferenceProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BackReferenceProperty != null) OnPostSave_BackReferenceProperty(this);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_BackReferenceProperty != null)
            {
                OnGetDataType_BackReferenceProperty(this, e);
            }
            return e.Result;
        }
    }
    
    public sealed class BackReferencePropertyClient : ClientObject<BackReferenceProperty, XMLObjectCollection, XMLObject>
    {
    }
}
