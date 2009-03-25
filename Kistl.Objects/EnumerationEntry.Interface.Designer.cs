
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for an Enumeration Entry.
    /// </summary>
    public interface EnumerationEntry : IDataObject 
    {

        /// <summary>
        /// Description of this Enumeration Entry
        /// </summary>
		string Description {
			get;
			set;
		}
        /// <summary>
        /// Übergeordnete Enumeration
        /// </summary>
		Kistl.App.Base.Enumeration Enumeration {
			get;
			set;
		}
        /// <summary>
        /// CLR name of this entry
        /// </summary>
		string Name {
			get;
			set;
		}
        /// <summary>
        /// The CLR value of this entry
        /// </summary>
		int Value {
			get;
			set;
		}
    }
}