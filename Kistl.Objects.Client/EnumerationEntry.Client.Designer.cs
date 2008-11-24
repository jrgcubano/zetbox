//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    using Kistl.API.Client;
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.EnumerationEntry")]
    public class EnumerationEntry__Implementation__ : BaseClientDataObject, EnumerationEntry
    {
        
        private System.Nullable<int> _fk_Enumeration = null;
        
        private int _Value;
        
        private string _Name;
        
        private string _Description;
        
        public EnumerationEntry__Implementation__()
        {
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                if (fk_Enumeration == null) return null;
                return Context.Find<Kistl.App.Base.Enumeration>(fk_Enumeration.Value);
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (fk_Enumeration != value.ID && fk_Enumeration != null) Enumeration.EnumerationEntries.Remove(this);
                    fk_Enumeration = value.ID;
                    if (!value.EnumerationEntries.Contains(this)) value.EnumerationEntries.Add(this);
                }
                else
                {
                    if (Enumeration != null && Enumeration.EnumerationEntries.Contains(this)) Enumeration.EnumerationEntries.Remove(this);
                    fk_Enumeration = null;
                };
            }
        }
        
        public System.Nullable<int> fk_Enumeration
        {
            get
            {
                return _fk_Enumeration;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Enumeration != value)
                {
                    NotifyPropertyChanging("Enumeration"); 
                    _fk_Enumeration = value;
                    NotifyPropertyChanged("Enumeration");;
                }
            }
        }
        
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Value != value)
                {
                    NotifyPropertyChanging("Value"); 
                    _Value = value;
                    NotifyPropertyChanged("Value");;
                }
            }
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Name != value)
                {
                    NotifyPropertyChanging("Name"); 
                    _Name = value;
                    NotifyPropertyChanged("Name");;
                }
            }
        }
        
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((EnumerationEntry__Implementation__)obj).fk_Enumeration = this.fk_Enumeration;
            ((EnumerationEntry__Implementation__)obj).Value = this.Value;
            ((EnumerationEntry__Implementation__)obj).Name = this.Name;
            ((EnumerationEntry__Implementation__)obj).Description = this.Description;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Enumeration":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(100).Constraints
                            .Where(c => !c.IsValid(this, this.Enumeration))
                            .Select(c => c.GetErrorText(this, this.Enumeration))
                            .ToArray());
                case "Value":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(135).Constraints
                            .Where(c => !c.IsValid(this, this.Value))
                            .Select(c => c.GetErrorText(this, this.Value))
                            .ToArray());
                case "Name":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(136).Constraints
                            .Where(c => !c.IsValid(this, this.Name))
                            .Select(c => c.GetErrorText(this, this.Name))
                            .ToArray());
                case "Description":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(178).Constraints
                            .Where(c => !c.IsValid(this, this.Description))
                            .Select(c => c.GetErrorText(this, this.Description))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Enumeration, sw);
            BinarySerializer.ToBinary(this._Value, sw);
            BinarySerializer.ToBinary(this._Name, sw);
            BinarySerializer.ToBinary(this._Description, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Enumeration, sr);
            BinarySerializer.FromBinary(out this._Value, sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            BinarySerializer.FromBinary(out this._Description, sr);
        }
    }
}
