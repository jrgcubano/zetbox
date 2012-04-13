// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Properties. This class is abstract.
    /// </summary>
    [Kistl.API.DefinitionGuid("e5f93f63-9cb8-40a5-8118-d1d9e479370c")]
    public interface Property : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember, Kistl.App.Base.INamedObject 
    {

        /// <summary>
        /// A space separated list of category names containing this Property
        /// </summary>
        [Kistl.API.DefinitionGuid("13418a59-a804-4bc7-88ed-4d3509940301")]
        string CategoryTags {
            get;
            set;
        }

        /// <summary>
        /// Provides a code template for a calculated property
        /// </summary>
        [Kistl.API.DefinitionGuid("7b528b52-52bd-4af0-bcd1-d63cd73a65bd")]
        string CodeTemplate {
            get;
        }

        /// <summary>
        /// The list of constraints applying to this Property
        /// </summary>

        [Kistl.API.DefinitionGuid("fd8f14da-e647-48cb-8593-3a30984f5c96")]
        ICollection<Kistl.App.Base.Constraint> Constraints { get; }

        /// <summary>
        /// Property can have a default value
        /// </summary>
        [Kistl.API.DefinitionGuid("590d6a36-2e4b-41bd-a51e-298aba90ce72")]
        Kistl.App.Base.DefaultPropertyValue DefaultValue {
            get;
            set;
        }

        /// <summary>
        /// Description of this Property
        /// </summary>
        [Kistl.API.DefinitionGuid("5905ae85-6a44-4dbd-9752-49cac467d3cd")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("dbf93142-1769-4f53-bcbc-71325e1d5ce7")]
        Kistl.App.GUI.PropertyFilterConfiguration FilterConfiguration {
            get;
            set;
        }

        /// <summary>
        /// Label is displayed to User in UI
        /// </summary>
        [Kistl.API.DefinitionGuid("34fc8b17-e9c2-43c5-a6d6-908551a8818b")]
        string Label {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("8c474623-7e53-4ca6-a996-f3b5a8c72834")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("bdaacacd-c8cb-45cf-a329-28f942337273")]
        Kistl.App.Base.DataType ObjectClass {
            get;
            set;
        }

        /// <summary>
        /// Optional requested ControlKind
        /// </summary>
        [Kistl.API.DefinitionGuid("3be58daf-9008-4cc3-a65d-8989909dcd80")]
        Kistl.App.GUI.ControlKind RequestedKind {
            get;
            set;
        }

        /// <summary>
        /// The ViewModel to use for values of this Property
        /// </summary>
        [Kistl.API.DefinitionGuid("84e0996a-081f-4a17-a34d-54cf23991301")]
        Kistl.App.GUI.ViewModelDescriptor ValueModelDescriptor {
            get;
            set;
        }

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        string GetElementTypeString();

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
