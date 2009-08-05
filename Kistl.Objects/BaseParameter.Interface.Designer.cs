// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Parameter. This class is abstract.
    /// </summary>
    public interface BaseParameter : IDataObject, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Description of this Parameter
        /// </summary>
		string Description {
			get;
			set;
		}
        /// <summary>
        /// Parameter wird als List&lt;&gt; generiert
        /// </summary>
		bool IsList {
			get;
			set;
		}
        /// <summary>
        /// Es darf nur ein Return Parameter angegeben werden
        /// </summary>
		bool IsReturnParameter {
			get;
			set;
		}
        /// <summary>
        /// Methode des Parameters
        /// </summary>
		Kistl.App.Base.Method Method {
			get;
			set;
		}
        /// <summary>
        /// Name des Parameter
        /// </summary>
		string ParameterName {
			get;
			set;
		}
        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
		 System.Type GetParameterType() ;
        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
		 string GetParameterTypeString() ;
    }
}