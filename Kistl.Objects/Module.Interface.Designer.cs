// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Modules.
    /// </summary>
    public interface Module : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Description of this Module
        /// </summary>
        string Description {
            get;
            set;
        }

        /// <summary>
        /// Name des Moduls
        /// </summary>
        string Name {
            get;
            set;
        }

        /// <summary>
        /// CLR Namespace des Moduls
        /// </summary>
        string Namespace {
            get;
            set;
        }

        /// <summary>
        /// Name of the database schema
        /// </summary>
        string SchemaName {
            get;
            set;
        }
    }
}
