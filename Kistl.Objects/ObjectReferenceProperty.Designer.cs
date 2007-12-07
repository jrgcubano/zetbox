//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ObjectReferenceProperty_ObjectClass", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass), "B_ObjectReferenceProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.ObjectReferenceProperty))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ObjectReferenceProperty")]
    public class ObjectReferenceProperty : Kistl.App.Base.Property
    {
        
        private int _fk_ReferenceObjectClass = Helper.INVALIDID;
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectReferenceProperty_ObjectClass", "A_ObjectClass")]
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass ReferenceObjectClass
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_ObjectReferenceProperty_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_ObjectReferenceProperty_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_ReferenceObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_ReferenceObjectClass == Helper.INVALIDID && ReferenceObjectClass != null)
                {
                    _fk_ReferenceObjectClass = ReferenceObjectClass.ID;
                }
                return _fk_ReferenceObjectClass;
            }
            set
            {
                _fk_ReferenceObjectClass = value;
            }
        }
        
        public event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;
        
        public event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;
        
        public event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;
        
        public event GetDataType_Handler<ObjectReferenceProperty> OnGetDataType_ObjectReferenceProperty;
        
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
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_ObjectReferenceProperty != null)
            {
                OnGetDataType_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
    }
}
