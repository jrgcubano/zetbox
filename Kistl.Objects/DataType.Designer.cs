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
    
    
    public interface DataType : IDataObject
    {
        
        Kistl.App.Base.Module Module
        {
            get;
            set;
        }
        
        string ClassName
        {
            get;
            set;
        }
        
        ICollection<Kistl.App.Base.BaseProperty> Properties
        {
            get;
        }
        
        ICollection<Kistl.App.Base.Method> Methods
        {
            get;
        }
        
        Kistl.App.GUI.Icon DefaultIcon
        {
            get;
            set;
        }
        
        ICollection<Kistl.App.Base.MethodInvocation> MethodInvocations
        {
            get;
        }
        
        string GetDataTypeString();
        
        System.Type GetDataType();
    }
}
