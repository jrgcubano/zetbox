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
    
    
    public class NotNullableConstraint__Implementation__ : Kistl.App.Base.Constraint__Implementation__, NotNullableConstraint
    {
        
        public NotNullableConstraint__Implementation__()
        {
        }
        
        public event ToStringHandler<NotNullableConstraint> OnToString_NotNullableConstraint;
        
        public event ObjectEventHandler<NotNullableConstraint> OnPreSave_NotNullableConstraint;
        
        public event ObjectEventHandler<NotNullableConstraint> OnPostSave_NotNullableConstraint;
        
        public event IsValid_Handler<NotNullableConstraint> OnIsValid_NotNullableConstraint;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NotNullableConstraint != null)
            {
                OnToString_NotNullableConstraint(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_NotNullableConstraint != null) OnPreSave_NotNullableConstraint(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_NotNullableConstraint != null) OnPostSave_NotNullableConstraint(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override bool IsValid(object value)
        {
            MethodReturnEventArgs<System.Boolean> e = new MethodReturnEventArgs<System.Boolean>();
            e.Result = base.IsValid(value);
            if (OnIsValid_NotNullableConstraint != null)
            {
                OnIsValid_NotNullableConstraint(this, e, value);
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
