// <autogenerated/>

namespace ZBox.App.SchemaMigration
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    [Kistl.API.DefinitionGuid("7f95aa3e-0150-4073-8b9e-803226872cc2")]
    public interface SourceTable : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("86a05242-c667-4181-a7a7-1d50d20f9d0f")]
        string Comment {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("8b93e1d4-1e2a-44a8-91c3-0c71541934c6")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("ec638748-894e-4e61-b618-7d8fbacec2fe")]
        Kistl.App.Base.ObjectClass DestinationObjectClass {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("f01c1095-cf9b-41f5-b89c-532a86a78cc5")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        [Kistl.API.DefinitionGuid("0e435261-9490-4fbb-8268-f7f1f6607d2c")]
        ICollection<ZBox.App.SchemaMigration.SourceColumn> SourceColumn { get; }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("d57c1138-b611-44b6-bd30-9b6d6a91cbed")]
        ZBox.App.SchemaMigration.StagingDatabase StagingDatabase {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("6029f896-82fd-4372-8cfd-76ca7e31ebf6")]
        ZBox.App.SchemaMigration.MappingStatus? Status {
            get;
            set;
        }

        /// <summary>
        /// Creates a mapping report
        /// </summary>
        void CreateMappingReport();

        /// <summary>
        /// 
        /// </summary>
        void CreateObjectClass();
    }
}
