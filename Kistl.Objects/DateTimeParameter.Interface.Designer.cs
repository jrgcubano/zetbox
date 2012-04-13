// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for DateTime Parameter.
    /// </summary>
    [Kistl.API.DefinitionGuid("cd6e3f93-5a1d-4c56-bec7-59a951d9fed6")]
    public interface DateTimeParameter : Kistl.App.Base.BaseParameter 
    {

        /// <summary>
        /// Style of Datetime. Can be Date, Time, or Date and Time.
        /// </summary>
        [Kistl.API.DefinitionGuid("0d0f2e67-cfa2-4463-aaf2-2ce0e6d11fa0")]
        Kistl.App.Base.DateTimeStyles? DateTimeStyle {
            get;
            set;
        }
    }
}
