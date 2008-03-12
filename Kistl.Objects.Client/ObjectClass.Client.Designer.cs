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
    
    
    public class ObjectClass : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _ClassName;
        
        private string _TableName;
        
        private List<Kistl.App.Base.BaseProperty> _Properties;
        
        private int _fk_BaseObjectClass = Helper.INVALIDID;
        
        private List<Kistl.App.Base.ObjectClass> _SubClasses;
        
        private List<Kistl.App.Base.Method> _Methods;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private int _fk_DefaultIcon = Helper.INVALIDID;
        
        private List<Kistl.App.Base.MethodInvocation> _MethodIvokations;
        
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
        
        public string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                NotifyPropertyChanging("ClassName"); 
                _ClassName = value; 
                NotifyPropertyChanged("ClassName");;
            }
        }
        
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                NotifyPropertyChanging("TableName"); 
                _TableName = value; 
                NotifyPropertyChanged("TableName");;
            }
        }
        
        [XmlIgnore()]
        public List<Kistl.App.Base.BaseProperty> Properties
        {
            get
            {
                if(_Properties == null) _Properties = Context.GetListOf<Kistl.App.Base.BaseProperty>(this, "Properties");
                return _Properties;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass BaseObjectClass
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.ObjectClass>().Single(o => o.ID == fk_BaseObjectClass);
            }
            set
            {
                NotifyPropertyChanging("BaseObjectClass"); 
                _fk_BaseObjectClass = value.ID;
                NotifyPropertyChanged("BaseObjectClass"); ;
            }
        }
        
        public int fk_BaseObjectClass
        {
            get
            {
                return _fk_BaseObjectClass;
            }
            set
            {
                NotifyPropertyChanging("BaseObjectClass"); 
                _fk_BaseObjectClass = value;
                NotifyPropertyChanged("BaseObjectClass"); ;
            }
        }
        
        [XmlIgnore()]
        public List<Kistl.App.Base.ObjectClass> SubClasses
        {
            get
            {
                if(_SubClasses == null) _SubClasses = Context.GetListOf<Kistl.App.Base.ObjectClass>(this, "SubClasses");
                return _SubClasses;
            }
        }
        
        [XmlIgnore()]
        public List<Kistl.App.Base.Method> Methods
        {
            get
            {
                if(_Methods == null) _Methods = Context.GetListOf<Kistl.App.Base.Method>(this, "Methods");
                return _Methods;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.Module>().Single(o => o.ID == fk_Module);
            }
            set
            {
                NotifyPropertyChanging("Module"); 
                _fk_Module = value.ID;
                NotifyPropertyChanged("Module"); ;
            }
        }
        
        public int fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                NotifyPropertyChanging("Module"); 
                _fk_Module = value;
                NotifyPropertyChanged("Module"); ;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.GUI.Icon DefaultIcon
        {
            get
            {
                return Context.GetQuery<Kistl.App.GUI.Icon>().Single(o => o.ID == fk_DefaultIcon);
            }
            set
            {
                NotifyPropertyChanging("DefaultIcon"); 
                _fk_DefaultIcon = value.ID;
                NotifyPropertyChanged("DefaultIcon"); ;
            }
        }
        
        public int fk_DefaultIcon
        {
            get
            {
                return _fk_DefaultIcon;
            }
            set
            {
                NotifyPropertyChanging("DefaultIcon"); 
                _fk_DefaultIcon = value;
                NotifyPropertyChanged("DefaultIcon"); ;
            }
        }
        
        [XmlIgnore()]
        public List<Kistl.App.Base.MethodInvocation> MethodIvokations
        {
            get
            {
                if(_MethodIvokations == null) _MethodIvokations = Context.GetListOf<Kistl.App.Base.MethodInvocation>(this, "MethodIvokations");
                return _MethodIvokations;
            }
        }
        
        public event ToStringHandler<ObjectClass> OnToString_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPreSave_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPostSave_ObjectClass;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectClass != null)
            {
                OnToString_ObjectClass(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectClass != null) OnPreSave_ObjectClass(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectClass != null) OnPostSave_ObjectClass(this);
        }
        
        public override object Clone()
        {
            ObjectClass obj = new ObjectClass();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((ObjectClass)obj)._ClassName = this._ClassName;
            ((ObjectClass)obj)._TableName = this._TableName;
            ((ObjectClass)obj)._fk_BaseObjectClass = this._fk_BaseObjectClass;
            ((ObjectClass)obj)._fk_Module = this._fk_Module;
            ((ObjectClass)obj)._fk_DefaultIcon = this._fk_DefaultIcon;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._ClassName, sw);
            BinarySerializer.ToBinary(this._TableName, sw);
            BinarySerializer.ToBinary(this.fk_BaseObjectClass, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.fk_DefaultIcon, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._ClassName, sr);
            BinarySerializer.FromBinary(out this._TableName, sr);
            BinarySerializer.FromBinary(out this._Properties, sr, ctx);
            BinarySerializer.FromBinary(out this._fk_BaseObjectClass, sr);
            BinarySerializer.FromBinary(out this._Methods, sr, ctx);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._fk_DefaultIcon, sr);
            BinarySerializer.FromBinary(out this._MethodIvokations, sr, ctx);
        }
    }
}
