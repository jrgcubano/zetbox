//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BackReferenceProperty_ObjectReferenceProperty", "A_ObjectReferenceProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectReferenceProperty), "B_BackReferenceProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BackReferenceProperty))]

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="BackReferenceProperty")]
    public class BackReferenceProperty : Kistl.App.Base.BaseProperty, ICloneable
    {
        
        private int _fk_ReferenceProperty = Helper.INVALIDID;
        
        private bool _PreFetchToClient;
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BackReferenceProperty_ObjectReferenceProperty", "A_ObjectReferenceProperty")]
        public Kistl.App.Base.ObjectReferenceProperty ReferenceProperty
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectReferenceProperty> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectReferenceProperty>("Model.FK_BackReferenceProperty_ObjectReferenceProperty", "A_ObjectReferenceProperty");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectReferenceProperty> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectReferenceProperty>("Model.FK_BackReferenceProperty_ObjectReferenceProperty", "A_ObjectReferenceProperty");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_ReferenceProperty
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_ReferenceProperty == Helper.INVALIDID && ReferenceProperty != null)
                {
                    _fk_ReferenceProperty = ReferenceProperty.ID;
                }
                return _fk_ReferenceProperty;
            }
            set
            {
                _fk_ReferenceProperty = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool PreFetchToClient
        {
            get
            {
                return _PreFetchToClient;
            }
            set
            {
                _PreFetchToClient = value;
            }
        }
        
        public event ToStringHandler<BackReferenceProperty> OnToString_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPreSave_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPostSave_BackReferenceProperty;
        
        public event GetDataType_Handler<BackReferenceProperty> OnGetDataType_BackReferenceProperty;
        
        public event GetGUIRepresentation_Handler<BackReferenceProperty> OnGetGUIRepresentation_BackReferenceProperty;
        
        [System.Diagnostics.DebuggerHidden()]
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
        
        public override object Clone()
        {
            BackReferenceProperty obj = new BackReferenceProperty();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((BackReferenceProperty)obj).fk_ReferenceProperty = this.fk_ReferenceProperty;
            ((BackReferenceProperty)obj).NotifyPropertyChanging("PreFetchToClient");
            ((BackReferenceProperty)obj).PreFetchToClient = this.PreFetchToClient;
            ((BackReferenceProperty)obj).NotifyPropertyChanged("PreFetchToClient");
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
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_BackReferenceProperty != null)
            {
                OnGetGUIRepresentation_BackReferenceProperty(this, e);
            }
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ReferenceProperty, sw);
            BinarySerializer.ToBinary(this.PreFetchToClient, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_ReferenceProperty, sr);
            BinarySerializer.FromBinary(out this._PreFetchToClient, sr);
        }
    }
}
