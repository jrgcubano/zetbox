//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ControlInfo_Assembly_Assembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Assembly), "B_ControlInfo", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.ControlInfo))]

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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ControlInfo")]
    public class ControlInfo : BaseServerDataObject
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private string _ClassName;
        
        private bool _IsContainer;
        
        private int _Platform;
        
        private int _ControlType;
        
        public ControlInfo()
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
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ControlInfo_Assembly_Assembly", "A_Assembly")]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly>("Model.FK_ControlInfo_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly>("Model.FK_ControlInfo_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public System.Nullable<int> fk_Assembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Assembly != null)
                {
                    _fk_Assembly = Assembly.ID;
                }
                return _fk_Assembly;
            }
            set
            {
                _fk_Assembly = value;
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
                if(_ClassName != value)
                {
                    NotifyPropertyChanging("ClassName"); 
                    _ClassName = value; 
                    NotifyPropertyChanged("ClassName");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsContainer
        {
            get
            {
                return _IsContainer;
            }
            set
            {
                if(_IsContainer != value)
                {
                    NotifyPropertyChanging("IsContainer"); 
                    _IsContainer = value; 
                    NotifyPropertyChanged("IsContainer");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int Platform
        {
            get
            {
                return _Platform;
            }
            set
            {
                if(_Platform != value)
                {
                    NotifyPropertyChanging("Platform"); 
                    _Platform = value; 
                    NotifyPropertyChanged("Platform");
                };
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if(_ControlType != value)
                {
                    NotifyPropertyChanging("ControlType"); 
                    _ControlType = value; 
                    NotifyPropertyChanged("ControlType");
                };
            }
        }
        
        public event ToStringHandler<ControlInfo> OnToString_ControlInfo;
        
        public event ObjectEventHandler<ControlInfo> OnPreSave_ControlInfo;
        
        public event ObjectEventHandler<ControlInfo> OnPostSave_ControlInfo;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ControlInfo != null)
            {
                OnToString_ControlInfo(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ControlInfo != null) OnPreSave_ControlInfo(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ControlInfo != null) OnPostSave_ControlInfo(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this._ClassName, sw);
            BinarySerializer.ToBinary(this._IsContainer, sw);
            BinarySerializer.ToBinary((int)this._Platform, sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinary(out this._ClassName, sr);
            BinarySerializer.FromBinary(out this._IsContainer, sr);
            int tmpPlatform; BinarySerializer.FromBinary(out tmpPlatform, sr); _Platform = (System.Int32)tmpPlatform;
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (System.Int32)tmpControlType;
        }
    }
}
