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
    
    
    /// <summary>
    /// Metadefinition Object for Methods.
    /// </summary>
    public interface Method : IDataObject
    {
        
        Kistl.App.Base.DataType ObjectClass
        {
            get;
            set;
        }
        
        string MethodName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
        Kistl.App.Base.Module Module
        {
            get;
            set;
        }
        
        /// <summary>
        /// Methodenaufrufe implementiert in dieser Objekt Klasse
        /// </summary>
        ICollection<Kistl.App.Base.MethodInvocation> MethodInvokations
        {
            get;
        }
        
        /// <summary>
        /// Parameter der Methode
        /// </summary>
        IList<Kistl.App.Base.BaseParameter> Parameter
        {
            get;
        }
        
        /// <summary>
        /// Shows this Method in th GUI
        /// </summary>
        bool IsDisplayable
        {
            get;
            set;
        }
        
        /// <summary>
        /// Description of this Method
        /// </summary>
        string Description
        {
            get;
            set;
        }
        
        /// <summary>
        /// Returns the Return Parameter Meta Object of this Method Meta Object.
        /// </summary>
        Kistl.App.Base.BaseParameter GetReturnParameter();
    }
}
