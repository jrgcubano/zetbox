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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.Assembly")]
    public class Assembly__Implementation__ : BaseClientDataObject, Assembly
    {
        
        private System.Nullable<int> _fk_Module = null;
        
        private string _AssemblyName;
        
        private bool _IsClientAssembly;
        
        public Assembly__Implementation__()
        {
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (fk_Module == null) return null;
                return Context.Find<Kistl.App.Base.Module>(fk_Module.Value);
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (fk_Module != value.ID && fk_Module != null) Module.Assemblies.Remove(this);
                    fk_Module = value.ID;
                    if (!value.Assemblies.Contains(this)) value.Assemblies.Add(this);
                }
                else
                {
                    if (Module != null && Module.Assemblies.Contains(this)) Module.Assemblies.Remove(this);
                    fk_Module = null;
                };
            }
        }
        
        public System.Nullable<int> fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Module != value)
                {
                    NotifyPropertyChanging("Module"); 
                    _fk_Module = value;
                    NotifyPropertyChanged("Module");;
                }
            }
        }
        
        public string AssemblyName
        {
            get
            {
                return _AssemblyName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (AssemblyName != value)
                {
                    NotifyPropertyChanging("AssemblyName"); 
                    _AssemblyName = value;
                    NotifyPropertyChanged("AssemblyName");;
                }
            }
        }
        
        public bool IsClientAssembly
        {
            get
            {
                return _IsClientAssembly;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (IsClientAssembly != value)
                {
                    NotifyPropertyChanging("IsClientAssembly"); 
                    _IsClientAssembly = value;
                    NotifyPropertyChanged("IsClientAssembly");;
                }
            }
        }
        
        public event ToStringHandler<Assembly> OnToString_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPreSave_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPostSave_Assembly;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Assembly != null)
            {
                OnToString_Assembly(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Assembly != null) OnPreSave_Assembly(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Assembly != null) OnPostSave_Assembly(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Assembly__Implementation__)obj).fk_Module = this.fk_Module;
            ((Assembly__Implementation__)obj).AssemblyName = this.AssemblyName;
            ((Assembly__Implementation__)obj).IsClientAssembly = this.IsClientAssembly;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Module":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(70).Constraints
                            .Where(c => !c.IsValid(this, this.Module))
                            .Select(c => c.GetErrorText(this, this.Module))
                            .ToArray());
                case "AssemblyName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(71).Constraints
                            .Where(c => !c.IsValid(this, this.AssemblyName))
                            .Select(c => c.GetErrorText(this, this.AssemblyName))
                            .ToArray());
                case "IsClientAssembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(83).Constraints
                            .Where(c => !c.IsValid(this, this.IsClientAssembly))
                            .Select(c => c.GetErrorText(this, this.IsClientAssembly))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._AssemblyName, sw);
            BinarySerializer.ToBinary(this._IsClientAssembly, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._AssemblyName, sr);
            BinarySerializer.FromBinary(out this._IsClientAssembly, sr);
        }
    }
}
