// <autogenerated/>

namespace Kistl.App.Calendar
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Abstract base class for Calendar Rules describing recurrent working hours
    /// </summary>
    [Kistl.API.DefinitionGuid("ee70b186-09ae-43a3-afb2-a632c47765b9")]
    public interface CalendarRule : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable, Kistl.App.Base.IModuleMember 
    {

        /// <summary>
        /// 
        /// </summary>
        [Kistl.API.DefinitionGuid("115c1d4c-ddd3-4d33-ae74-a6b676fc0dfa")]
        Kistl.App.Calendar.Calendar Calendar {
            get;
            set;
        }

        /// <summary>
        /// True if the day is a working day, regardless of the working hours. E.g. Saturday is a working day (in Austria), but most people aktually don&apos;t work.
        /// </summary>
        [Kistl.API.DefinitionGuid("09cfc4e1-c106-46ec-825d-31226d8df335")]
        bool IsWorkingDay {
            get;
            set;
        }

        /// <summary>
        /// The name of the Rule
        /// </summary>
        [Kistl.API.DefinitionGuid("88bd31d8-6963-49ed-8ac8-31d438744eef")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// Optional valid from date
        /// </summary>
        [Kistl.API.DefinitionGuid("940552fc-7cb1-4512-9096-54c3e70f7a1f")]
        DateTime? ValidFrom {
            get;
            set;
        }

        /// <summary>
        /// Optional valid until date
        /// </summary>
        [Kistl.API.DefinitionGuid("4fced9a6-fe27-44a2-a21d-17a09c720588")]
        DateTime? ValidUntil {
            get;
            set;
        }

        /// <summary>
        /// The amount of working hours. 0 if it&apos;s a free day.
        /// </summary>
        [Kistl.API.DefinitionGuid("20370deb-580a-44e6-b201-f5740ee5e330")]
        decimal WorkingHours {
            get;
            set;
        }

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        bool AppliesTo(DateTime date);
    }
}
