// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface TestStudent : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Test.Fragebogen> Testbogen { get; }
    }
}