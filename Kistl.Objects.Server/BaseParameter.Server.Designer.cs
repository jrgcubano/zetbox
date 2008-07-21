//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseParameter_Method", "A_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Method), "B_BaseParameter", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseParameter))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseParameter_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module), "B_BaseParameter", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseParameter))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="BaseParameter")]
    public class BaseParameter : BaseServerDataObject
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_Method = null;
        
        private string _ParameterName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private bool _IsList;
        
        private bool _IsReturnParameter;
        
        public BaseParameter()
        {
        }
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseParameter_Method", "A_Method")]
        public Kistl.App.Base.Method Method
        {
            get
            {
                EntityReference<Kistl.App.Base.Method> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method>("Model.FK_BaseParameter_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Method> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method>("Model.FK_BaseParameter_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public System.Nullable<int> fk_Method
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Method != null)
                {
                    _fk_Method = Method.ID;
                }
                return _fk_Method;
            }
            set
            {
                _fk_Method = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string ParameterName
        {
            get
            {
                return _ParameterName;
            }
            set
            {
                if(_ParameterName != value)
                {
                    NotifyPropertyChanging("ParameterName"); 
                    _ParameterName = value; 
                    NotifyPropertyChanged("ParameterName");
                };
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseParameter_Module", "A_Module")]
        public Kistl.App.Base.Module Module
        {
            get
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_BaseParameter_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_BaseParameter_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public System.Nullable<int> fk_Module
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Module != null)
                {
                    _fk_Module = Module.ID;
                }
                return _fk_Module;
            }
            set
            {
                _fk_Module = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsList
        {
            get
            {
                return _IsList;
            }
            set
            {
                if(_IsList != value)
                {
                    NotifyPropertyChanging("IsList"); 
                    _IsList = value; 
                    NotifyPropertyChanged("IsList");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsReturnParameter
        {
            get
            {
                return _IsReturnParameter;
            }
            set
            {
                if(_IsReturnParameter != value)
                {
                    NotifyPropertyChanging("IsReturnParameter"); 
                    _IsReturnParameter = value; 
                    NotifyPropertyChanged("IsReturnParameter");
                };
            }
        }
        
        public event ToStringHandler<BaseParameter> OnToString_BaseParameter;
        
        public event ObjectEventHandler<BaseParameter> OnPreSave_BaseParameter;
        
        public event ObjectEventHandler<BaseParameter> OnPostSave_BaseParameter;
        
        public event GetDataType_Handler<BaseParameter> OnGetDataType_BaseParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BaseParameter != null)
            {
                OnToString_BaseParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BaseParameter != null) OnPreSave_BaseParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BaseParameter != null) OnPostSave_BaseParameter(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public virtual string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetDataType_BaseParameter != null)
            {
                OnGetDataType_BaseParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            BinarySerializer.ToBinary(this._ParameterName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._IsList, sw);
            BinarySerializer.ToBinary(this._IsReturnParameter, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            BinarySerializer.FromBinary(out this._ParameterName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._IsList, sr);
            BinarySerializer.FromBinary(out this._IsReturnParameter, sr);
        }
        
        public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
