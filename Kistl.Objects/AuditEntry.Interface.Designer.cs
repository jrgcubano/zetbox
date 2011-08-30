// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// A single entry in the auditing table of a class
    /// </summary>
    public interface AuditEntry : ICompoundObject 
    {

        /// <summary>
        /// The identity that caued this audit
        /// </summary>
        string Identity {
            get;
            set;
        }

        /// <summary>
        /// The default format to display this change to the user
        /// </summary>
        string MessageFormat {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string NewValue {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string OldValue {
            get;
            set;
        }

        /// <summary>
        /// The name of the changed property
        /// </summary>
        string PropertyName {
            get;
            set;
        }

        /// <summary>
        /// The time when the change was made
        /// </summary>
        DateTime? Timestamp {
            get;
            set;
        }
    }
}