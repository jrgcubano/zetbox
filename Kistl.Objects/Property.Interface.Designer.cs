// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Properties. This class is abstract.
    /// </summary>
    public interface Property : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// A space separated list of category names containing this Property
        /// </summary>
        string CategoryTags {
            get;
            set;
        }

        /// <summary>
        /// Provides a code template for a calculated property
        /// </summary>
        string CodeTemplate {
            get;
        }

        /// <summary>
        /// The list of constraints applying to this Property
        /// </summary>

        ICollection<Kistl.App.Base.Constraint> Constraints { get; }

        /// <summary>
        /// Property can have a default value
        /// </summary>
        Kistl.App.Base.DefaultPropertyValue DefaultValue {
            get;
            set;
        }

        /// <summary>
        /// Description of this Property
        /// </summary>
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.GUI.PropertyFilterConfiguration FilterConfiguration {
            get;
            set;
        }

        /// <summary>
        /// Label is displayed to User in UI
        /// </summary>
        string Label {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Base.DataType ObjectClass {
            get;
            set;
        }

        /// <summary>
        /// Optional requested ControlKind
        /// </summary>
        Kistl.App.GUI.ControlKind RequestedKind {
            get;
            set;
        }

        /// <summary>
        /// The ViewModel to use for values of this Property
        /// </summary>
        Kistl.App.GUI.ViewModelDescriptor ValueModelDescriptor {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string GetLabel();

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        System.Type GetPropertyType();

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        string GetPropertyTypeString();
    }
}
