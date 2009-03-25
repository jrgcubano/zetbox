
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Struct Properties.
    /// </summary>
    public interface StructProperty : Kistl.App.Base.Property 
    {

        /// <summary>
        /// Definition of this Struct
        /// </summary>
		Kistl.App.Base.Struct StructDefinition {
			get;
			set;
		}
    }
}