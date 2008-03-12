//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.API
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
    
    
    [Serializable()]
    [XmlRoot(ElementName="ObjectCollection")]
    public sealed class XMLObjectCollection : IXmlObjectCollection
    {
        
        private List<Object> _Objects = new List<Object>();
        
        [XmlArrayItem(Type=typeof(Kistl.App.Base.ObjectClass), ElementName="ObjectClass")]
        [XmlArrayItem(Type=typeof(Kistl.App.Projekte.Projekt), ElementName="Projekt")]
        [XmlArrayItem(Type=typeof(Kistl.App.Projekte.Task), ElementName="Task")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.BaseProperty), ElementName="BaseProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Projekte.Mitarbeiter), ElementName="Mitarbeiter")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.Property), ElementName="Property")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.ValueTypeProperty), ElementName="ValueTypeProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.StringProperty), ElementName="StringProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.Method), ElementName="Method")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.IntProperty), ElementName="IntProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.BoolProperty), ElementName="BoolProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.DoubleProperty), ElementName="DoubleProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.ObjectReferenceProperty), ElementName="ObjectReferenceProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.DateTimeProperty), ElementName="DateTimeProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.BackReferenceProperty), ElementName="BackReferenceProperty")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.Module), ElementName="Module")]
        [XmlArrayItem(Type=typeof(Kistl.App.Projekte.Auftrag), ElementName="Auftrag")]
        [XmlArrayItem(Type=typeof(Kistl.App.Zeiterfassung.Zeitkonto), ElementName="Zeitkonto")]
        [XmlArrayItem(Type=typeof(Kistl.App.Zeiterfassung.Kostenstelle), ElementName="Kostenstelle")]
        [XmlArrayItem(Type=typeof(Kistl.App.Zeiterfassung.Kostentraeger), ElementName="Kostentraeger")]
        [XmlArrayItem(Type=typeof(Kistl.App.Zeiterfassung.Taetigkeit), ElementName="Taetigkeit")]
        [XmlArrayItem(Type=typeof(Kistl.App.Projekte.Kunde), ElementName="Kunde")]
        [XmlArrayItem(Type=typeof(Kistl.App.GUI.Icon), ElementName="Icon")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.Assembly), ElementName="Assembly")]
        [XmlArrayItem(Type=typeof(Kistl.App.Base.MethodInvocation), ElementName="MethodInvocation")]
        public List<Object> Objects
        {
            get
            {
                return _Objects;
            }
        }
        
        public List<T> ToList<T>()
            where T : IDataObject
        {
            return new List<T>(Objects.OfType<T>());
        }
    }
    
    [Serializable()]
    [XmlRoot(ElementName="Object")]
    public sealed class XMLObject : IXmlObject
    {
        
        private Object _Object;
        
        [XmlElement(Type=typeof(Kistl.App.Base.ObjectClass), ElementName="ObjectClass")]
        [XmlElement(Type=typeof(Kistl.App.Projekte.Projekt), ElementName="Projekt")]
        [XmlElement(Type=typeof(Kistl.App.Projekte.Task), ElementName="Task")]
        [XmlElement(Type=typeof(Kistl.App.Base.BaseProperty), ElementName="BaseProperty")]
        [XmlElement(Type=typeof(Kistl.App.Projekte.Mitarbeiter), ElementName="Mitarbeiter")]
        [XmlElement(Type=typeof(Kistl.App.Base.Property), ElementName="Property")]
        [XmlElement(Type=typeof(Kistl.App.Base.ValueTypeProperty), ElementName="ValueTypeProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.StringProperty), ElementName="StringProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.Method), ElementName="Method")]
        [XmlElement(Type=typeof(Kistl.App.Base.IntProperty), ElementName="IntProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.BoolProperty), ElementName="BoolProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.DoubleProperty), ElementName="DoubleProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.ObjectReferenceProperty), ElementName="ObjectReferenceProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.DateTimeProperty), ElementName="DateTimeProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.BackReferenceProperty), ElementName="BackReferenceProperty")]
        [XmlElement(Type=typeof(Kistl.App.Base.Module), ElementName="Module")]
        [XmlElement(Type=typeof(Kistl.App.Projekte.Auftrag), ElementName="Auftrag")]
        [XmlElement(Type=typeof(Kistl.App.Zeiterfassung.Zeitkonto), ElementName="Zeitkonto")]
        [XmlElement(Type=typeof(Kistl.App.Zeiterfassung.Kostenstelle), ElementName="Kostenstelle")]
        [XmlElement(Type=typeof(Kistl.App.Zeiterfassung.Kostentraeger), ElementName="Kostentraeger")]
        [XmlElement(Type=typeof(Kistl.App.Zeiterfassung.Taetigkeit), ElementName="Taetigkeit")]
        [XmlElement(Type=typeof(Kistl.App.Projekte.Kunde), ElementName="Kunde")]
        [XmlElement(Type=typeof(Kistl.App.GUI.Icon), ElementName="Icon")]
        [XmlElement(Type=typeof(Kistl.App.Base.Assembly), ElementName="Assembly")]
        [XmlElement(Type=typeof(Kistl.App.Base.MethodInvocation), ElementName="MethodInvocation")]
        public Object Object
        {
            get
            {
                 return _Object;
            }
            set
            {
                _Object = value;
            }
        }
    }
}
