// <autogenerated/>

namespace ZBox.App.SchemaMigration
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface StagingDatabase : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
        string ConnectionStringKey {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        ZBox.App.SchemaMigration.MigrationProject MigrationProject {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string OriginConnectionStringKey {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Schema {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        ICollection<ZBox.App.SchemaMigration.SourceTable> SourceTables { get; }
    }
}