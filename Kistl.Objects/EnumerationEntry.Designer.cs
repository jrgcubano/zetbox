//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.3053
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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
    
    
    public interface EnumerationEntry : IDataObject
    {
        
        Kistl.App.Base.Enumeration Enumeration
        {
            get;
            set;
        }
        
        int Value
        {
            get;
            set;
        }
        
        string Name
        {
            get;
            set;
        }
    }
}
