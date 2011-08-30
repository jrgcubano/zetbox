// <autogenerated/>

namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface FilterConfiguration : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// 
        /// </summary>
        string Label {
            get;
            set;
        }

        /// <summary>
        /// Overrides the default behaviour. If true the filter will be immediately applied
        /// </summary>
        bool? RefreshOnFilterChanged {
            get;
            set;
        }

        /// <summary>
        /// Overrides the default kind of the configured ViewModelDescriptor
        /// </summary>
        Kistl.App.GUI.ControlKind RequestedKind {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        bool Required {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.GUI.ViewModelDescriptor ViewModelDescriptor {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        Kistl.API.IFilterModel CreateFilterModel();

        /// <summary>
        /// 
        /// </summary>
        string GetLabel();
    }
}
