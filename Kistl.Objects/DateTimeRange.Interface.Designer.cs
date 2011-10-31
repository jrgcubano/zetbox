// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// A from and until DateTime Value
    /// </summary>
    public interface DateTimeRange : ICompoundObject 
    {

        /// <summary>
        /// 
        /// </summary>
        DateTime? From {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        DateTime? Thru {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        int? TotalDays {
            get;
        }
    }
}