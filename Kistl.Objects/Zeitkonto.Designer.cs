//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Zeiterfassung
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
    
    
    public interface Zeitkonto : IDataObject
    {
        
        string Kontoname
        {
            get;
            set;
        }
        
        ICollection<Kistl.App.Zeiterfassung.Taetigkeit> Taetigkeiten
        {
            get;
        }
        
        IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get;
        }
        
        System.Double? MaxStunden
        {
            get;
            set;
        }
        
        System.Double? AktuelleStunden
        {
            get;
            set;
        }
    }
}
