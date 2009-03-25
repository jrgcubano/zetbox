
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Assembly : IDataObject 
    {

        /// <summary>
        /// Full Assemblyname eg. MyActions, Version=1.0.0.0
        /// </summary>
		string AssemblyName {
			get;
			set;
		}
        /// <summary>
        /// Legt fest, ob es sich um ein Client-Assembly handelt.
        /// </summary>
		bool IsClientAssembly {
			get;
			set;
		}
        /// <summary>
        /// Module
        /// </summary>
		Kistl.App.Base.Module Module {
			get;
			set;
		}
        /// <summary>
        /// Regenerates the stored list of TypeRefs from the loaded assembly
        /// </summary>

		 void RegenerateTypeRefs() ;
    }
}