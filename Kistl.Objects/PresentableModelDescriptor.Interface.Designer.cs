// <autogenerated/>

namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface PresentableModelDescriptor : IDataObject, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// The default ControlKind to use for this Presentable.
        /// </summary>
		Kistl.App.GUI.ControlKind DefaultKind {
			get;
			set;
		}
        /// <summary>
        /// describe this PresentableModel
        /// </summary>
		string Description {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		Kistl.App.Base.Module Module {
			get;
			set;
		}
        /// <summary>
        /// The described CLR class&apos; reference
        /// </summary>
		Kistl.App.Base.TypeRef PresentableModelRef {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.GUI.ControlKind> SecondaryControlKinds { get; }
    }
}