
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for String Properties.
    /// </summary>
    public interface StringProperty : Kistl.App.Base.ValueTypeProperty 
    {

        /// <summary>
        /// 
        /// </summary>
		int Length {
			get;
			set;
		}
    }
}