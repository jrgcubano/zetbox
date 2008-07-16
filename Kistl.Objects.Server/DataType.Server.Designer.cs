//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_DataType_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module), "B_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.DataType))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_DataType_Icon", "A_Icon", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.GUI.Icon), "B_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.DataType))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="DataType")]
    public class DataType : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private System.Nullable<int> _fk_Module = null;
        
        private string _ClassName;
        
        private System.Nullable<int> _fk_DefaultIcon = null;
        
        public DataType()
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
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_DataType_Module", "A_Module")]
        public Kistl.App.Base.Module Module
        {
            get
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_DataType_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_DataType_Module", "A_Module");
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
        public string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                NotifyPropertyChanging("ClassName"); 
                _ClassName = value; 
                NotifyPropertyChanged("ClassName");;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseProperty_DataType", "B_BaseProperty")]
        public EntityCollection<Kistl.App.Base.BaseProperty> Properties
        {
            get
            {
                EntityCollection<Kistl.App.Base.BaseProperty> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.BaseProperty>("Model.FK_BaseProperty_DataType", "B_BaseProperty");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Method_DataType", "B_Method")]
        public EntityCollection<Kistl.App.Base.Method> Methods
        {
            get
            {
                EntityCollection<Kistl.App.Base.Method> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.Method>("Model.FK_Method_DataType", "B_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_DataType_Icon", "A_Icon")]
        public Kistl.App.GUI.Icon DefaultIcon
        {
            get
            {
                EntityReference<Kistl.App.GUI.Icon> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Icon>("Model.FK_DataType_Icon", "A_Icon");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.Icon> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Icon>("Model.FK_DataType_Icon", "A_Icon");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public System.Nullable<int> fk_DefaultIcon
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && DefaultIcon != null)
                {
                    _fk_DefaultIcon = DefaultIcon.ID;
                }
                return _fk_DefaultIcon;
            }
            set
            {
                _fk_DefaultIcon = value;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_DataType", "B_MethodInvocation")]
        public EntityCollection<Kistl.App.Base.MethodInvocation> MethodIvokations
        {
            get
            {
                EntityCollection<Kistl.App.Base.MethodInvocation> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.MethodInvocation>("Model.FK_MethodInvocation_DataType", "B_MethodInvocation");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public event ToStringHandler<DataType> OnToString_DataType;
        
        public event ObjectEventHandler<DataType> OnPreSave_DataType;
        
        public event ObjectEventHandler<DataType> OnPostSave_DataType;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DataType != null)
            {
                OnToString_DataType(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DataType != null) OnPreSave_DataType(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DataType != null) OnPostSave_DataType(this);
        }
        
        public override object Clone()
        {
            DataType obj = new DataType();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((DataType)obj)._fk_Module = this._fk_Module;
            ((DataType)obj)._ClassName = this._ClassName;
            ((DataType)obj)._fk_DefaultIcon = this._fk_DefaultIcon;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._ClassName, sw);
            BinarySerializer.ToBinary(this.Properties.OfType<IDataObject>(), sw);
            BinarySerializer.ToBinary(this.Methods.OfType<IDataObject>(), sw);
            BinarySerializer.ToBinary(this.fk_DefaultIcon, sw);
            BinarySerializer.ToBinary(this.MethodIvokations.OfType<IDataObject>(), sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._ClassName, sr);
            BinarySerializer.FromBinary(out this._fk_DefaultIcon, sr);
        }
    }
}
