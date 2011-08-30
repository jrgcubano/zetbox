// <autogenerated/>

namespace Kistl.App.Calendar
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// A Calendar describing recurrent working hours
    /// </summary>
    public interface Calendar : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// 
        /// </summary>
        Kistl.App.Calendar.Calendar BaseCalendar {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Calendar.CalendarRule> CalendarRules { get; }

        /// <summary>
        /// 
        /// </summary>

        ICollection<Kistl.App.Calendar.Calendar> ChildCalendar { get; }

        /// <summary>
        /// 
        /// </summary>
        string Name {
            get;
            set;
        }

        /// <summary>
        /// Gets the number of free days between two dates
        /// </summary>
        int GetOffDays(System.DateTime from, System.DateTime until);

        /// <summary>
        /// Get the number of working days between two dates
        /// </summary>
        int GetWorkingDays(System.DateTime from, System.DateTime until);

        /// <summary>
        /// Returns the amount of working hours between two dates
        /// </summary>
        System.Decimal GetWorkingHours(System.DateTime from, System.DateTime until);
    }
}