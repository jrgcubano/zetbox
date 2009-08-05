// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Properties. This class is abstract.
    /// </summary>
    public interface Property : IDataObject, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
		string AltText {
			get;
			set;
		}
        /// <summary>
        /// A space separated list of category names containing this Property
        /// </summary>
		string CategoryTags {
			get;
			set;
		}
        /// <summary>
        /// The list of constraints applying to this Property
        /// </summary>

        ICollection<Kistl.App.Base.Constraint> Constraints { get; }
        /// <summary>
        /// Property can have a default value
        /// </summary>
		Kistl.App.Base.DefaultPropertyValue DefaultValue {
			get;
			set;
		}
        /// <summary>
        /// Description of this Property
        /// </summary>
		string Description {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Base.PropertyInvocation> Invocations { get; }
        /// <summary>
        /// Whether or not a list-valued property has a index
        /// </summary>
		bool IsIndexed {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		bool IsList {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		bool IsNullable {
			get;
			set;
		}
        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
		Kistl.App.Base.Module Module {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		Kistl.App.Base.DataType ObjectClass {
			get;
			set;
		}
        /// <summary>
        /// 
        /// </summary>
		string PropertyName {
			get;
			set;
		}
        /// <summary>
        /// The PresentableModel to use for values of this Property
        /// </summary>
		Kistl.App.GUI.PresentableModelDescriptor ValueModelDescriptor {
			get;
			set;
		}
        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		 System.Type GetPropertyType() ;
        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		 string GetPropertyTypeString() ;
    }
}