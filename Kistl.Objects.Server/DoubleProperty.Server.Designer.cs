//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
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
    using Kistl.DALProvider.EF;
    using Kistl.API.Server;
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.DoubleProperty")]
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="DoubleProperty")]
    public class DoubleProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, DoubleProperty
    {
        
        public DoubleProperty__Implementation__()
        {
        }
        
        public event ToStringHandler<DoubleProperty> OnToString_DoubleProperty;
        
        public event ObjectEventHandler<DoubleProperty> OnPreSave_DoubleProperty;
        
        public event ObjectEventHandler<DoubleProperty> OnPostSave_DoubleProperty;
        
        public event GetPropertyTypeString_Handler<DoubleProperty> OnGetPropertyTypeString_DoubleProperty;
        
        public event GetGUIRepresentation_Handler<DoubleProperty> OnGetGUIRepresentation_DoubleProperty;
        
        public event GetPropertyType_Handler<DoubleProperty> OnGetPropertyType_DoubleProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleProperty != null)
            {
                OnToString_DoubleProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleProperty != null) OnPreSave_DoubleProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleProperty != null) OnPostSave_DoubleProperty(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            return base.GetPropertyError(prop);
        }
        
        public override string GetPropertyTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetPropertyTypeString();
            if (OnGetPropertyTypeString_DoubleProperty != null)
            {
                OnGetPropertyTypeString_DoubleProperty(this, e);
            };
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_DoubleProperty != null)
            {
                OnGetGUIRepresentation_DoubleProperty(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetPropertyType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetPropertyType();
            if (OnGetPropertyType_DoubleProperty != null)
            {
                OnGetPropertyType_DoubleProperty(this, e);
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
