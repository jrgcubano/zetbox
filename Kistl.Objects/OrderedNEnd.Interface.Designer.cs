// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// A test class for persistently ordered 1:N relations
    /// </summary>
    public interface OrderedNEnd : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Test.OrderedOneEnd OneEnd {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        int? OtherInt {
            get;
            set;
        }
    }
}