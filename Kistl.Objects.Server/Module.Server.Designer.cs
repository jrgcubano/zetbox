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
    using System.Linq;
    using System.Text;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Module")]
    public class Module : BaseServerDataObject
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Namespace;
        
        private string _ModuleName;
        
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
        
        public override string EntitySetName
        {
            get
            {
                return "Module";
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string Namespace
        {
            get
            {
                return _Namespace;
            }
            set
            {
                _Namespace = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string ModuleName
        {
            get
            {
                return _ModuleName;
            }
            set
            {
                _ModuleName = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_Module", "B_ObjectClass")]
        [XmlIgnore()]
        public EntityCollection<Kistl.App.Base.ObjectClass> ObjectClasses
        {
            get
            {
                EntityCollection<Kistl.App.Base.ObjectClass> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.ObjectClass>("Model.FK_ObjectClass_Module", "B_ObjectClass");
                if (!c.IsLoaded) c.Load(); 
                return c;
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
    }
    
    public sealed class ModuleServer : ServerObject<Module, XMLObjectCollection, XMLObject>
    {
    }
}
