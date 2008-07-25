//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Interface")]
    public class Interface : Kistl.App.Base.DataType
    {
        
        public Interface()
        {
        }
        
        public event ToStringHandler<Interface> OnToString_Interface;
        
        public event ObjectEventHandler<Interface> OnPreSave_Interface;
        
        public event ObjectEventHandler<Interface> OnPostSave_Interface;
        
        public event GetDataTypeString_Handler<Interface> OnGetDataTypeString_Interface;
        
        public event GetDataType_Handler<Interface> OnGetDataType_Interface;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Interface != null)
            {
                OnToString_Interface(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Interface != null) OnPreSave_Interface(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Interface != null) OnPostSave_Interface(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataTypeString();
            if (OnGetDataTypeString_Interface != null)
            {
                OnGetDataTypeString_Interface(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetDataType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetDataType();
            if (OnGetDataType_Interface != null)
            {
                OnGetDataType_Interface(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
        }
    }
}
