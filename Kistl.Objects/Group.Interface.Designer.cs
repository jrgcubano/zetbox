// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Group : IDataObject, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Base.Group> ChildGroups { get; }
        /// <summary>
        /// Identities are member of this group
        /// </summary>

        ICollection<Kistl.App.Base.Identity> Member { get; }
        /// <summary>
        /// Module is optional. Use it only when you need a Group to be exportable
        /// </summary>
		Kistl.App.Base.Module Module {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		string Name {
			get;
			set;
		}
        /// <summary>
        /// A Group can have a parent group
        /// </summary>
		Kistl.App.Base.Group ParentGroup {
			get;
			set;
		}
    }
}