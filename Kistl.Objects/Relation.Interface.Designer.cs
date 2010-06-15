// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Describes a Relation between two Object Classes
    /// </summary>
    public interface Relation : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// The A-side of this Relation.
        /// </summary>
		Kistl.App.Base.RelationEnd A {
			get;
			set;
		}
        /// <summary>
        /// The B-side of this Relation.
        /// </summary>
		Kistl.App.Base.RelationEnd B {
			get;
			set;
		}
        /// <summary>
        /// The ContainmentSpecification of this Relation.
        /// </summary>
		Kistl.App.Base.ContainmentSpecification Containment {
			get;
			set;
		}
        /// <summary>
        /// Description of this Relation
        /// </summary>
		string Description {
			get;
			set;
		}
        /// <summary>
        /// Storagetype for 1:1 Relations. Must be null for non 1:1 Relations.
        /// </summary>
		Kistl.App.Base.StorageType Storage {
			get;
			set;
		}
        /// <summary>
        /// Verb of this Relation
        /// </summary>
		string Verb {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		 Kistl.App.Base.RelationEnd GetEnd(Kistl.App.Base.ObjectReferenceProperty prop) ;
        /// <summary>
        /// 
        /// </summary>
		 Kistl.App.Base.RelationEnd GetEndFromRole(Kistl.API.RelationEndRole role) ;
        /// <summary>
        /// 
        /// </summary>
		 Kistl.API.InterfaceType GetEntryInterfaceType() ;
        /// <summary>
        /// 
        /// </summary>
		 Kistl.App.Base.RelationEnd GetOtherEnd(Kistl.App.Base.RelationEnd relEnd) ;
        /// <summary>
        /// 
        /// </summary>
		 Kistl.API.RelationType GetRelationType() ;
        /// <summary>
        /// 
        /// </summary>
		 bool NeedsPositionStorage(Kistl.API.RelationEndRole endRole) ;
    }
}