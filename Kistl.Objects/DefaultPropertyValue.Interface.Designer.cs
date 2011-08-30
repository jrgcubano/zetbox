// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface DefaultPropertyValue : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Property where the default value is set
        /// </summary>
        Kistl.App.Base.Property Property {
            get;
            set;
        }

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        System.Object GetDefaultValue();
    }
}