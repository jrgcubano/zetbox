//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseProperty_ObjectClass", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass), "B_BaseProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseProperty))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseProperty_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module), "B_BaseProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseProperty))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="BaseProperty")]
    public class BaseProperty : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_ObjectClass = Helper.INVALIDID;
        
        private string _PropertyName;
        
        private string _AltText;
        
        private int _fk_Module = Helper.INVALIDID;
        
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
        
        public override string EntitySetName
        {
            get
            {
                return "BaseProperty";
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseProperty_ObjectClass", "A_ObjectClass")]
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_BaseProperty_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_BaseProperty_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_ObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_ObjectClass == Helper.INVALIDID && ObjectClass != null)
                {
                    _fk_ObjectClass = ObjectClass.ID;
                }
                return _fk_ObjectClass;
            }
            set
            {
                _fk_ObjectClass = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string PropertyName
        {
            get
            {
                return _PropertyName;
            }
            set
            {
                _PropertyName = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string AltText
        {
            get
            {
                return _AltText;
            }
            set
            {
                _AltText = value;
            }
        }
        
        [XmlIgnore()]
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseProperty_Module", "A_Module")]
        public Kistl.App.Base.Module Module
        {
            get
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_BaseProperty_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_BaseProperty_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Module
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Module == Helper.INVALIDID && Module != null)
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
        
        public event ToStringHandler<BaseProperty> OnToString_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPreSave_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPostSave_BaseProperty;
        
        public event GetDataType_Handler<BaseProperty> OnGetDataType_BaseProperty;
        
        public event GetGUIRepresentation_Handler<BaseProperty> OnGetGUIRepresentation_BaseProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BaseProperty != null)
            {
                OnToString_BaseProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BaseProperty != null) OnPreSave_BaseProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BaseProperty != null) OnPostSave_BaseProperty(this);
        }
        
        public override object Clone()
        {
            BaseProperty obj = new BaseProperty();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(BaseProperty obj)
        {
            base.CopyTo(obj);
            obj.fk_ObjectClass = this.fk_ObjectClass;
            obj.PropertyName = this.PropertyName;
            obj.AltText = this.AltText;
            obj.fk_Module = this.fk_Module;
        }
        
        public virtual string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            if (OnGetDataType_BaseProperty != null)
            {
                OnGetDataType_BaseProperty(this, e);
            }
            return e.Result;
        }
        
        public virtual string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_BaseProperty != null)
            {
                OnGetGUIRepresentation_BaseProperty(this, e);
            }
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this.PropertyName, sw);
            BinarySerializer.ToBinary(this.AltText, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._PropertyName, sr);
            BinarySerializer.FromBinary(out this._AltText, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
        }
        
        public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<string> e);
        
        public delegate void GetGUIRepresentation_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
