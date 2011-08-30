// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Logentry for exceptions
    /// </summary>
    public interface ExceptionLogEntry : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        DateTime Date {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Exception {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Level {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Logger {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Message {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string Thread {
            get;
            set;
        }
    }
}
