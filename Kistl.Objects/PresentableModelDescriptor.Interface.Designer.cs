
namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface PresentableModelDescriptor : IDataObject 
    {

        /// <summary>
        /// The default visual type used for this PresentableModel
        /// </summary>
		Kistl.App.GUI.VisualType DefaultVisualType {
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
        /// The described CLR class' reference
        /// </summary>
		Kistl.App.Base.TypeRef PresentableModelRef {
			get;
			set;
		}
    }
}