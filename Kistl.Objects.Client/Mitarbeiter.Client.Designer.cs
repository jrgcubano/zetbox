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
    using Kistl.API.Client;
    
    
    public sealed class MitarbeiterClient : ClientObject<Mitarbeiter>
    {
        
        // Autogeneriert, um die gebundenen Listen zu bekommen
        public List<Kistl.App.Projekte.Projekt> GetListOfProjekte(int ID)
        {
            return Proxy.Service.GetListOf(Type, ID, "Projekte").FromXmlString<XMLObjectCollection>().ToList<Kistl.App.Projekte.Projekt>();
        }
    }
}
