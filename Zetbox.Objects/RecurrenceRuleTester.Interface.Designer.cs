// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Tests the RecurrenceRule
    /// </summary>
    [Zetbox.API.DefinitionGuid("b6c60adc-19f0-4169-8b78-53d7eaa549f7")]
    public interface RecurrenceRuleTester : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("404eda18-44aa-456c-aaa7-c1c45c6b7008")]
        Zetbox.App.Base.RecurrenceRule Rule {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        DateTime GetCurrent(DateTime? dt);

        /// <summary>
        /// 
        /// </summary>
        DateTime GetNext(DateTime? dt);
    }
}
