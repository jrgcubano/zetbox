// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.
    /// </summary>
    public interface TypeRef : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// The assembly containing the referenced Type.
        /// </summary>
        Kistl.App.Base.Assembly Assembly {
            get;
            set;
        }

        /// <summary>
        /// If the TypeRef could not be found in the containing assembly this property is set to true, otherwise to null
        /// </summary>
        bool? Deleted {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string FullName {
            get;
            set;
        }

        /// <summary>
        /// list of type arguments
        /// </summary>

        IList<Kistl.App.Base.TypeRef> GenericArguments { get; }

        /// <summary>
        /// The TypeRef of the BaseClass of the referenced Type
        /// </summary>
        Kistl.App.Base.TypeRef Parent {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string ToStringCache {
            get;
            set;
        }

        /// <summary>
        /// get the referenced &lt;see cref=&quot;Type&quot;/&gt;
        /// </summary>
        System.Type AsType(System.Boolean throwOnError);

        /// <summary>
        /// Update the Parent property to the currently loaded assemblies&apos; state
        /// </summary>
        void UpdateParent();

        /// <summary>
        /// 
        /// </summary>
        void UpdateToStringCache();
    }
}