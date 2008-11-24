//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Method_DataType_ObjectClass", "A_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.DataType__Implementation__), "B_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.Method__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Method_Module_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module__Implementation__), "B_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.Method__Implementation__))]

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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.Method")]
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Method")]
    public class Method__Implementation__ : BaseServerDataObject_EntityFramework, Method
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_ObjectClass = null;
        
        private string _MethodName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private EntityCollectionWrapper<Kistl.App.Base.MethodInvocation, Kistl.App.Base.MethodInvocation__Implementation__> MethodInvokationsWrapper;
        
        private EntityCollectionWrapperSorted<Kistl.App.Base.BaseParameter, Kistl.App.Base.BaseParameter__Implementation__> ParameterWrapper;
        
        private bool _IsDisplayable;
        
        private string _Description;
        
        public Method__Implementation__()
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
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Method_DataType_ObjectClass", "A_DataType")]
        public Kistl.App.Base.DataType__Implementation__ ObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>("Model.FK_Method_DataType_ObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>("Model.FK_Method_DataType_ObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string MethodName
        {
            get
            {
                return _MethodName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (MethodName != value)
                {
                    NotifyPropertyChanging("MethodName"); 
                    _MethodName = value;
                    NotifyPropertyChanged("MethodName");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Method_Module_Module", "A_Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>("Model.FK_Method_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>("Model.FK_Method_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.MethodInvocation> MethodInvokations
        {
            get
            {
                if (MethodInvokationsWrapper == null) MethodInvokationsWrapper = new EntityCollectionWrapper<Kistl.App.Base.MethodInvocation, Kistl.App.Base.MethodInvocation__Implementation__>(MethodInvokations__Implementation__);
                return MethodInvokationsWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Method_Method", "B_MethodInvocation")]
        public EntityCollection<Kistl.App.Base.MethodInvocation__Implementation__> MethodInvokations__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Base.MethodInvocation__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.MethodInvocation__Implementation__>("Model.FK_MethodInvocation_Method_Method", "B_MethodInvocation");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.BaseParameter> Parameter
        {
            get
            {
                if (ParameterWrapper == null) ParameterWrapper = new EntityCollectionWrapperSorted<Kistl.App.Base.BaseParameter, Kistl.App.Base.BaseParameter__Implementation__>(Parameter__Implementation__, "Method");
                return ParameterWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_BaseParameter_Method_Method", "B_BaseParameter")]
        public EntityCollection<Kistl.App.Base.BaseParameter__Implementation__> Parameter__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Base.BaseParameter__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.BaseParameter__Implementation__>("Model.FK_BaseParameter_Method_Method", "B_BaseParameter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsDisplayable
        {
            get
            {
                return _IsDisplayable;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (IsDisplayable != value)
                {
                    NotifyPropertyChanging("IsDisplayable"); 
                    _IsDisplayable = value;
                    NotifyPropertyChanged("IsDisplayable");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Description != value)
                {
                    NotifyPropertyChanging("Description"); 
                    _Description = value;
                    NotifyPropertyChanged("Description");;
                }
            }
        }
        
        public event ToStringHandler<Method> OnToString_Method;
        
        public event ObjectEventHandler<Method> OnPreSave_Method;
        
        public event ObjectEventHandler<Method> OnPostSave_Method;
        
        public event GetReturnParameter_Handler<Method> OnGetReturnParameter_Method;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Method != null)
            {
                OnToString_Method(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Method != null) OnPreSave_Method(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Method != null) OnPostSave_Method(this);
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
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(29).Constraints
                            .Where(c => !c.IsValid(this, this.ObjectClass))
                            .Select(c => c.GetErrorText(this, this.ObjectClass))
                            .ToArray());
                case "MethodName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(30).Constraints
                            .Where(c => !c.IsValid(this, this.MethodName))
                            .Select(c => c.GetErrorText(this, this.MethodName))
                            .ToArray());
                case "Module":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(73).Constraints
                            .Where(c => !c.IsValid(this, this.Module))
                            .Select(c => c.GetErrorText(this, this.Module))
                            .ToArray());
                case "MethodInvokations":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(81).Constraints
                            .Where(c => !c.IsValid(this, this.MethodInvokations))
                            .Select(c => c.GetErrorText(this, this.MethodInvokations))
                            .ToArray());
                case "Parameter":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(96).Constraints
                            .Where(c => !c.IsValid(this, this.Parameter))
                            .Select(c => c.GetErrorText(this, this.Parameter))
                            .ToArray());
                case "IsDisplayable":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(124).Constraints
                            .Where(c => !c.IsValid(this, this.IsDisplayable))
                            .Select(c => c.GetErrorText(this, this.IsDisplayable))
                            .ToArray());
                case "Description":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(180).Constraints
                            .Where(c => !c.IsValid(this, this.Description))
                            .Select(c => c.GetErrorText(this, this.Description))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public virtual Kistl.App.Base.BaseParameter GetReturnParameter()
        {
            MethodReturnEventArgs<Kistl.App.Base.BaseParameter> e = new MethodReturnEventArgs<Kistl.App.Base.BaseParameter>();
            if (OnGetReturnParameter_Method != null)
            {
                OnGetReturnParameter_Method(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this._MethodName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._IsDisplayable, sw);
            BinarySerializer.ToBinary(this._Description, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._MethodName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._IsDisplayable, sr);
            BinarySerializer.FromBinary(out this._Description, sr);
        }
        
        public delegate void GetReturnParameter_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.BaseParameter> e);
    }
}
