// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// IChangedBy
    /// </summary>
    public interface IChangedBy  
    {

        /// <summary>
        /// Identity which changed this object
        /// </summary>
        Kistl.App.Base.Identity ChangedBy {
            get;
            set;
        }

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>
        DateTime ChangedOn {
            get;
            set;
        }

        /// <summary>
        /// Identity which created this object
        /// </summary>
        Kistl.App.Base.Identity CreatedBy {
            get;
            set;
        }

        /// <summary>
        /// Date and time where this object was created
        /// </summary>
        DateTime CreatedOn {
            get;
            set;
        }
    }
}