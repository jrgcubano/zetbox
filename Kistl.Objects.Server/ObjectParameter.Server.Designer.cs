//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ObjectParameter_DataType", "A_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.DataType), "B_ObjectParameter", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.ObjectParameter))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ObjectParameter")]
    public class ObjectParameter : Kistl.App.Base.BaseParameter, ICloneable
    {
        
        private int _fk_DataType = Helper.INVALIDID;
        
        public ObjectParameter()
        {
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectParameter_DataType", "A_DataType")]
        public Kistl.App.Base.DataType DataType
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType>("Model.FK_ObjectParameter_DataType", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType>("Model.FK_ObjectParameter_DataType", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_DataType
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && DataType != null)
                {
                    _fk_DataType = DataType.ID;
                }
                return _fk_DataType;
            }
            set
            {
                _fk_DataType = value;
            }
        }
        
        public event ToStringHandler<ObjectParameter> OnToString_ObjectParameter;
        
        public event ObjectEventHandler<ObjectParameter> OnPreSave_ObjectParameter;
        
        public event ObjectEventHandler<ObjectParameter> OnPostSave_ObjectParameter;
        
        public event GetDataType_Handler<ObjectParameter> OnGetDataType_ObjectParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectParameter != null)
            {
                OnToString_ObjectParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectParameter != null) OnPreSave_ObjectParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectParameter != null) OnPostSave_ObjectParameter(this);
        }
        
        public override object Clone()
        {
            ObjectParameter obj = new ObjectParameter();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((ObjectParameter)obj)._fk_DataType = this._fk_DataType;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_ObjectParameter != null)
            {
                OnGetDataType_ObjectParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_DataType, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_DataType, sr);
        }
    }
}
