//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseProperty_DataType_ObjectClass", "A_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.DataType__Implementation__), "B_BaseProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseProperty__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_BaseProperty_Module_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module__Implementation__), "B_BaseProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.BaseProperty__Implementation__))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="BaseProperty")]
    public class BaseProperty__Implementation__ : BaseServerDataObject_EntityFramework, BaseProperty
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_ObjectClass = null;
        
        private string _PropertyName;
        
        private string _AltText;
        
        private System.Nullable<int> _fk_Module = null;
        
        private EntityCollectionWrapper<Kistl.App.Base.Constraint, Kistl.App.Base.Constraint__Implementation__> ConstraintsWrapper;
        
        public BaseProperty__Implementation__()
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
        public Kistl.App.Base.DataType ObjectClass
        {
            get
            {
                return ObjectClass__Implementation__;
            }
            set
            {
                ObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        public System.Nullable<int> fk_ObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && ObjectClass != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseProperty_DataType_ObjectClass", "A_DataType")]
        public Kistl.App.Base.DataType__Implementation__ ObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>("Model.FK_BaseProperty_DataType_ObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>("Model.FK_BaseProperty_DataType_ObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.DataType__Implementation__)value;
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (PropertyName != value)
                {
                    NotifyPropertyChanging("PropertyName"); 
                    _PropertyName = value;
                    NotifyPropertyChanged("PropertyName");;
                }
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (AltText != value)
                {
                    NotifyPropertyChanging("AltText"); 
                    _AltText = value;
                    NotifyPropertyChanged("AltText");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Module__Implementation__;
            }
            set
            {
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseProperty_Module_Module", "A_Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>("Model.FK_BaseProperty_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>("Model.FK_BaseProperty_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Base.Constraint> Constraints
        {
            get
            {
                if (ConstraintsWrapper == null) ConstraintsWrapper = new EntityCollectionWrapper<Kistl.App.Base.Constraint, Kistl.App.Base.Constraint__Implementation__>(Constraints__Implementation__);
                return ConstraintsWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Constraint_BaseProperty_ConstrainedProperty", "B_Constraint")]
        public EntityCollection<Kistl.App.Base.Constraint__Implementation__> Constraints__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Base.Constraint__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.Constraint__Implementation__>("Model.FK_Constraint_BaseProperty_ConstrainedProperty", "B_Constraint");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public event ToStringHandler<BaseProperty> OnToString_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPreSave_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPostSave_BaseProperty;
        
        public event GetPropertyTypeString_Handler<BaseProperty> OnGetPropertyTypeString_BaseProperty;
        
        public event GetGUIRepresentation_Handler<BaseProperty> OnGetGUIRepresentation_BaseProperty;
        
        public event GetPropertyType_Handler<BaseProperty> OnGetPropertyType_BaseProperty;
        
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ObjectClass":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(8).Constraints
                            .Where(c => !c.IsValid(this, this.ObjectClass))
                            .Select(c => c.GetErrorText(this, this.ObjectClass))
                            .ToArray());
                case "PropertyName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(9).Constraints
                            .Where(c => !c.IsValid(this, this.PropertyName))
                            .Select(c => c.GetErrorText(this, this.PropertyName))
                            .ToArray());
                case "AltText":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(41).Constraints
                            .Where(c => !c.IsValid(this, this.AltText))
                            .Select(c => c.GetErrorText(this, this.AltText))
                            .ToArray());
                case "Module":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(72).Constraints
                            .Where(c => !c.IsValid(this, this.Module))
                            .Select(c => c.GetErrorText(this, this.Module))
                            .ToArray());
                case "Constraints":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(170).Constraints
                            .Where(c => !c.IsValid(this, this.Constraints))
                            .Select(c => c.GetErrorText(this, this.Constraints))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public virtual string GetPropertyTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetPropertyTypeString_BaseProperty != null)
            {
                OnGetPropertyTypeString_BaseProperty(this, e);
            };
            return e.Result;
        }
        
        public virtual string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetGUIRepresentation_BaseProperty != null)
            {
                OnGetGUIRepresentation_BaseProperty(this, e);
            };
            return e.Result;
        }
        
        public virtual System.Type GetPropertyType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_BaseProperty != null)
            {
                OnGetPropertyType_BaseProperty(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this._PropertyName, sw);
            BinarySerializer.ToBinary(this._AltText, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.Constraints.Cast<IDataObject>(), sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._PropertyName, sr);
            BinarySerializer.FromBinary(out this._AltText, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
        }
        
        public delegate void GetPropertyTypeString_Handler<T>(T obj, MethodReturnEventArgs<string> e);
        
        public delegate void GetGUIRepresentation_Handler<T>(T obj, MethodReturnEventArgs<string> e);
        
        public delegate void GetPropertyType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> e);
    }
}
