//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class Module : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Namespace;
        
        private string _ModuleName;
        
        private BackReferenceCollection<Kistl.App.Base.DataType> _DataTypes;
        
        private BackReferenceCollection<Kistl.App.Base.Assembly> _Assemblies;
        
        public Module()
        {
        }
        
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
        
        public string Namespace
        {
            get
            {
                return _Namespace;
            }
            set
            {
                NotifyPropertyChanging("Namespace"); 
                _Namespace = value; 
                NotifyPropertyChanged("Namespace");;
            }
        }
        
        public string ModuleName
        {
            get
            {
                return _ModuleName;
            }
            set
            {
                NotifyPropertyChanging("ModuleName"); 
                _ModuleName = value; 
                NotifyPropertyChanged("ModuleName");;
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Base.DataType> DataTypes
        {
            get
            {
                if (_DataTypes == null)
                {
                    List<Kistl.App.Base.DataType> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Base.DataType>(this, "DataTypes");
                    else
                        serverList = new List<Kistl.App.Base.DataType>();

                    _DataTypes = new BackReferenceCollection<Kistl.App.Base.DataType>(
                         "Module", this, serverList);
                }
                return _DataTypes;
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Base.Assembly> Assemblies
        {
            get
            {
                if (_Assemblies == null)
                {
                    List<Kistl.App.Base.Assembly> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Base.Assembly>(this, "Assemblies");
                    else
                        serverList = new List<Kistl.App.Base.Assembly>();

                    _Assemblies = new BackReferenceCollection<Kistl.App.Base.Assembly>(
                         "Module", this, serverList);
                }
                return _Assemblies;
            }
        }
        
        public event ToStringHandler<Module> OnToString_Module;
        
        public event ObjectEventHandler<Module> OnPreSave_Module;
        
        public event ObjectEventHandler<Module> OnPostSave_Module;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Module != null)
            {
                OnToString_Module(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Module != null) OnPreSave_Module(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Module != null) OnPostSave_Module(this);
        }
        
        public override object Clone()
        {
            Module obj = new Module();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Module)obj)._Namespace = this._Namespace;
            ((Module)obj)._ModuleName = this._ModuleName;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_DataTypes != null) _DataTypes = new BackReferenceCollection<Kistl.App.Base.DataType>("Module", this, _DataTypes.Select(i => ctx.Attach(i)).OfType<Kistl.App.Base.DataType>());
            if(_Assemblies != null) _Assemblies = new BackReferenceCollection<Kistl.App.Base.Assembly>("Module", this, _Assemblies.Select(i => ctx.Attach(i)).OfType<Kistl.App.Base.Assembly>());
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Namespace, sw);
            BinarySerializer.ToBinary(this._ModuleName, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Namespace, sr);
            BinarySerializer.FromBinary(out this._ModuleName, sr);
        }
    }
}
