//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_PresenterInfo_Assembly_PresenterAssembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Assembly__Implementation__), "B_PresenterInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.PresenterInfo__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_PresenterInfo_Assembly_DataAssembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Assembly__Implementation__), "B_PresenterInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.PresenterInfo__Implementation__))]

namespace Kistl.App.GUI
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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.GUI.PresenterInfo")]
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="PresenterInfo")]
    public class PresenterInfo__Implementation__ : BaseServerDataObject_EntityFramework, PresenterInfo
    {
        
        private int _ID;
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        private System.Nullable<int> _fk_PresenterAssembly = null;
        
        private string _PresenterTypeName;
        
        private System.Nullable<int> _fk_DataAssembly = null;
        
        private string _DataTypeName;
        
        public PresenterInfo__Implementation__()
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
        
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ControlType != value)
                {
                    NotifyPropertyChanging("ControlType"); 
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int ControlType__Implementation__
        {
            get
            {
                return (int)ControlType;
            }
            set
            {
                ControlType = (Kistl.App.GUI.VisualType)value;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly PresenterAssembly
        {
            get
            {
                return PresenterAssembly__Implementation__;
            }
            set
            {
                PresenterAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        public System.Nullable<int> fk_PresenterAssembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && PresenterAssembly != null)
                {
                    _fk_PresenterAssembly = PresenterAssembly.ID;
                }
                return _fk_PresenterAssembly;
            }
            set
            {
                _fk_PresenterAssembly = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_PresenterInfo_Assembly_PresenterAssembly", "A_Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ PresenterAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_PresenterInfo_Assembly_PresenterAssembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_PresenterInfo_Assembly_PresenterAssembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string PresenterTypeName
        {
            get
            {
                return _PresenterTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (PresenterTypeName != value)
                {
                    NotifyPropertyChanging("PresenterTypeName"); 
                    _PresenterTypeName = value;
                    NotifyPropertyChanged("PresenterTypeName");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly DataAssembly
        {
            get
            {
                return DataAssembly__Implementation__;
            }
            set
            {
                DataAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        public System.Nullable<int> fk_DataAssembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && DataAssembly != null)
                {
                    _fk_DataAssembly = DataAssembly.ID;
                }
                return _fk_DataAssembly;
            }
            set
            {
                _fk_DataAssembly = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_PresenterInfo_Assembly_DataAssembly", "A_Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ DataAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_PresenterInfo_Assembly_DataAssembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_PresenterInfo_Assembly_DataAssembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string DataTypeName
        {
            get
            {
                return _DataTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (DataTypeName != value)
                {
                    NotifyPropertyChanging("DataTypeName"); 
                    _DataTypeName = value;
                    NotifyPropertyChanged("DataTypeName");;
                }
            }
        }
        
        public event ToStringHandler<PresenterInfo> OnToString_PresenterInfo;
        
        public event ObjectEventHandler<PresenterInfo> OnPreSave_PresenterInfo;
        
        public event ObjectEventHandler<PresenterInfo> OnPostSave_PresenterInfo;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PresenterInfo != null)
            {
                OnToString_PresenterInfo(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PresenterInfo != null) OnPreSave_PresenterInfo(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PresenterInfo != null) OnPostSave_PresenterInfo(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ControlType":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(137).Constraints
                            .Where(c => !c.IsValid(this, this.ControlType))
                            .Select(c => c.GetErrorText(this, this.ControlType))
                            .ToArray());
                case "PresenterAssembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(138).Constraints
                            .Where(c => !c.IsValid(this, this.PresenterAssembly))
                            .Select(c => c.GetErrorText(this, this.PresenterAssembly))
                            .ToArray());
                case "PresenterTypeName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(139).Constraints
                            .Where(c => !c.IsValid(this, this.PresenterTypeName))
                            .Select(c => c.GetErrorText(this, this.PresenterTypeName))
                            .ToArray());
                case "DataAssembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(147).Constraints
                            .Where(c => !c.IsValid(this, this.DataAssembly))
                            .Select(c => c.GetErrorText(this, this.DataAssembly))
                            .ToArray());
                case "DataTypeName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(148).Constraints
                            .Where(c => !c.IsValid(this, this.DataTypeName))
                            .Select(c => c.GetErrorText(this, this.DataTypeName))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
            BinarySerializer.ToBinary(this.fk_PresenterAssembly, sw);
            BinarySerializer.ToBinary(this._PresenterTypeName, sw);
            BinarySerializer.ToBinary(this.fk_DataAssembly, sw);
            BinarySerializer.ToBinary(this._DataTypeName, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (Kistl.App.GUI.VisualType)tmpControlType;
            BinarySerializer.FromBinary(out this._fk_PresenterAssembly, sr);
            BinarySerializer.FromBinary(out this._PresenterTypeName, sr);
            BinarySerializer.FromBinary(out this._fk_DataAssembly, sr);
            BinarySerializer.FromBinary(out this._DataTypeName, sr);
        }
    }
}
