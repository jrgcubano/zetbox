// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for a MethodInvocation on a Method of a DataType.
    /// </summary>
    public interface MethodInvocation : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IInvocation 
    {

        /// <summary>
        /// In dieser Objektklasse implementieren
        /// </summary>
		Kistl.App.Base.DataType InvokeOnObjectClass {
			get;
			set;
		}
        /// <summary>
        /// Methode, die Aufgerufen wird
        /// </summary>
		Kistl.App.Base.Method Method {
			get;
			set;
		}
        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
		Kistl.App.Base.Module Module {
			get;
			set;
		}
    }
}