// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for DateTime Properties.
    /// </summary>
    [Kistl.API.DefinitionGuid("1caadf11-7b95-4c68-8b42-87ac51b01ea0")]
    public interface DateTimeProperty : Kistl.App.Base.ValueTypeProperty 
    {

        /// <summary>
        /// Style of Datetime. Can be Date, Date and Time or Time
        /// </summary>
        [Kistl.API.DefinitionGuid("76b04254-3911-4753-ba11-cb1af074b056")]
        Kistl.App.Base.DateTimeStyles? DateTimeStyle {
            get;
            set;
        }
    }
}
