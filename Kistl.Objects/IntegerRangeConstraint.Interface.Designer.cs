
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface IntegerRangeConstraint : Kistl.App.Base.Constraint 
    {

        /// <summary>
        /// The biggest value accepted by this constraint
        /// </summary>
		int Max {
			get;
			set;
		}
        /// <summary>
        /// The smallest value accepted by this constraint
        /// </summary>
		int Min {
			get;
			set;
		}
    }
}