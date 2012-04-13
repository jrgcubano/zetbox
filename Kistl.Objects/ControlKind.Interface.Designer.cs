// <autogenerated/>

namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
    /// </summary>
    [Kistl.API.DefinitionGuid("a9166f1e-9233-4d2d-8eb6-be71d724ea14")]
    public interface ControlKind : IDataObject, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember, Kistl.App.Base.INamedObject 
    {

        /// <summary>
        /// 
        /// </summary>

        [Kistl.API.DefinitionGuid("bf073bb5-eaa8-4e3d-b019-60b47ba6a088")]
        ICollection<Kistl.App.GUI.ControlKind> ChildControlKinds { get; }

        /// <summary>
        /// Name of this ControlKind
        /// </summary>
        [Kistl.API.DefinitionGuid("438ab847-c5d1-4072-9449-96e3d4e92b1f")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("5d75bf4f-29dd-4d00-8e4f-b40a1b9ad92c")]
        Kistl.App.GUI.ControlKind Parent {
            get;
            set;
        }
    }
}
