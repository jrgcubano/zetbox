// <autogenerated/>

namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Represents a ZBox Application
    /// </summary>
    [Kistl.API.DefinitionGuid("896187c2-2714-4430-8adb-6532612d7e0f")]
    public interface Application : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("24fabe2c-de1d-4b67-970d-748a73c5e17d")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("70bec122-0345-457c-9426-52168e033df1")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("2232a206-1192-4937-8314-701073215cdb")]
        Kistl.App.GUI.NavigationScreen RootScreen {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("25e50509-3b29-46b1-9bdb-17a0bd2963c2")]
        Kistl.App.GUI.ViewModelDescriptor WorkspaceViewModel {
            get;
            set;
        }
    }
}
