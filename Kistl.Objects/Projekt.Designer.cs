//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3053
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Projekte
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
    
    
    public interface Projekt : IDataObject
    {
        
        string Name
        {
            get;
            set;
        }
        
        ICollection<Kistl.App.Projekte.Task> Tasks
        {
            get;
        }
        
        IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get;
        }
        
        System.Double? AufwandGes
        {
            get;
            set;
        }
        
        string Kundenname
        {
            get;
            set;
        }
        
        ICollection<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger
        {
            get;
        }
        
        ICollection<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get;
        }
    }
}
