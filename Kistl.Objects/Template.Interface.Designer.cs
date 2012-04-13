// <autogenerated/>

namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    [Kistl.API.DefinitionGuid("c677d3fe-7dfe-4ea5-91e0-d1b0df9118be")]
    public interface Template : IDataObject 
    {

        /// <summary>
        /// Assembly of the Type that is displayed with this Template
        /// </summary>
        [Kistl.API.DefinitionGuid("c81105da-97e4-4685-af88-792c68e55a17")]
        Kistl.App.Base.Assembly DisplayedTypeAssembly {
            get;
            set;
        }

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>
        [Kistl.API.DefinitionGuid("4b683aa1-45a9-4c5e-80e7-0ff30f5b798c")]
        string DisplayedTypeFullName {
            get;
            set;
        }

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>
        [Kistl.API.DefinitionGuid("4fc51781-b0fe-495c-91a1-90e484345515")]
        string DisplayName {
            get;
            set;
        }

        /// <summary>
        /// The main menu for this Template
        /// </summary>

        [Kistl.API.DefinitionGuid("5e9612d5-019a-416b-a2e2-dfc9674a50f6")]
        ICollection<Kistl.App.GUI.Visual> Menu { get; }

        /// <summary>
        /// The visual representation of this Template
        /// </summary>
        [Kistl.API.DefinitionGuid("5d2880a4-716a-4bdc-aaa9-379c006e7ed4")]
        Kistl.App.GUI.Visual VisualTree {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        void PrepareDefault(Kistl.App.Base.ObjectClass cls);
    }
}
