//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_EnumerationEntry_Enumeration_Enumeration", "A_Enumeration", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Enumeration), "B_EnumerationEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.EnumerationEntry))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="EnumerationEntry")]
    public class EnumerationEntry : BaseServerDataObject
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_Enumeration = null;
        
        private string _EnumerationEntryName;
        
        private int _EnumValue;
        
        public EnumerationEntry()
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
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_EnumerationEntry_Enumeration_Enumeration", "A_Enumeration")]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                EntityReference<Kistl.App.Base.Enumeration> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration>("Model.FK_EnumerationEntry_Enumeration_Enumeration", "A_Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Enumeration> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration>("Model.FK_EnumerationEntry_Enumeration_Enumeration", "A_Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public System.Nullable<int> fk_Enumeration
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Enumeration != null)
                {
                    _fk_Enumeration = Enumeration.ID;
                }
                return _fk_Enumeration;
            }
            set
            {
                _fk_Enumeration = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string EnumerationEntryName
        {
            get
            {
                return _EnumerationEntryName;
            }
            set
            {
                if (EnumerationEntryName != value)
                {
                    NotifyPropertyChanging("EnumerationEntryName"); 
                    _EnumerationEntryName = value;
                    NotifyPropertyChanged("EnumerationEntryName");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int EnumValue
        {
            get
            {
                return _EnumValue;
            }
            set
            {
                if (EnumValue != value)
                {
                    NotifyPropertyChanging("EnumValue"); 
                    _EnumValue = value;
                    NotifyPropertyChanged("EnumValue");;
                }
            }
        }
        
        public event ToStringHandler<EnumerationEntry> OnToString_EnumerationEntry;
        
        public event ObjectEventHandler<EnumerationEntry> OnPreSave_EnumerationEntry;
        
        public event ObjectEventHandler<EnumerationEntry> OnPostSave_EnumerationEntry;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationEntry != null)
            {
                OnToString_EnumerationEntry(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationEntry != null) OnPreSave_EnumerationEntry(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationEntry != null) OnPostSave_EnumerationEntry(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Enumeration, sw);
            BinarySerializer.ToBinary(this._EnumerationEntryName, sw);
            BinarySerializer.ToBinary(this._EnumValue, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Enumeration, sr);
            BinarySerializer.FromBinary(out this._EnumerationEntryName, sr);
            BinarySerializer.FromBinary(out this._EnumValue, sr);
        }
    }
}
