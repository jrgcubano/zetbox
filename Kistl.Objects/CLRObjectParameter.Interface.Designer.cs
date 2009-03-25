
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    public interface CLRObjectParameter : Kistl.App.Base.BaseParameter 
    {

        /// <summary>
        /// Assembly des CLR Objektes, NULL für Default Assemblies
        /// </summary>
		Kistl.App.Base.Assembly Assembly {
			get;
			set;
		}
        /// <summary>
        /// Name des CLR Datentypen
        /// </summary>
		string FullTypeName {
			get;
			set;
		}
    }
}