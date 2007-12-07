//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Projekte
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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Mitarbeiter")]
    public class Mitarbeiter : BaseDataObject
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Name;
        
        private System.Nullable<System.DateTime> _Geburtstag;
        
        private string _SVNr;
        
        private string _TelefonNummer;
        
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
                return "Mitarbeiter";
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Projekt_Mitarbeiter", "B_Projekt")]
        [XmlIgnore()]
        public EntityCollection<Kistl.App.Projekte.Projekt> Projekte
        {
            get
            {
                EntityCollection<Kistl.App.Projekte.Projekt> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Projekte.Projekt>("Model.FK_Projekt_Mitarbeiter", "B_Projekt");
                if (!c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.Nullable<System.DateTime> Geburtstag
        {
            get
            {
                return _Geburtstag;
            }
            set
            {
                _Geburtstag = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string SVNr
        {
            get
            {
                return _SVNr;
            }
            set
            {
                _SVNr = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string TelefonNummer
        {
            get
            {
                return _TelefonNummer;
            }
            set
            {
                _TelefonNummer = value;
            }
        }
        
        public event ToStringHandler<Mitarbeiter> OnToString_Mitarbeiter;
        
        public event ObjectEventHandler<Mitarbeiter> OnPreSave_Mitarbeiter;
        
        public event ObjectEventHandler<Mitarbeiter> OnPostSave_Mitarbeiter;
        
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Mitarbeiter != null)
            {
                OnToString_Mitarbeiter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Mitarbeiter != null) OnPreSave_Mitarbeiter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Mitarbeiter != null) OnPostSave_Mitarbeiter(this);
        }
    }
}
