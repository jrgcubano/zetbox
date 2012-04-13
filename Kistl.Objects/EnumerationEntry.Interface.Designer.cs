// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for an Enumeration Entry.
    /// </summary>
    [Kistl.API.DefinitionGuid("6365c62d-60a6-4fa3-9c78-370ffcc50478")]
    public interface EnumerationEntry : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Description of this Enumeration Entry
        /// </summary>
        [Kistl.API.DefinitionGuid("3366c523-0593-4a29-978f-5ac8a4f15eca")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// Übergeordnete Enumeration
        /// </summary>
        [Kistl.API.DefinitionGuid("115c3bfb-72fd-46f2-81fe-74ce1cfa1874")]
        Kistl.App.Base.Enumeration Enumeration {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("feb0b203-5f83-4b9b-848c-a3e4ee895055")]
        string Label {
            get;
            set;
        }

        /// <summary>
        /// CLR name of this entry
        /// </summary>
        [Kistl.API.DefinitionGuid("1c1e497b-294f-442e-8793-478b298d4aba")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// The CLR value of this entry
        /// </summary>
        [Kistl.API.DefinitionGuid("2fea1d2e-d5ed-457f-9828-4df8c3d3d3aa")]
        int Value {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string GetLabel();
    }
}
