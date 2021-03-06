// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("0999effb-c645-45e1-b3c2-5654530d0acb")]
    public interface IInvocation  
    {

        /// <summary>
        /// The type implementing this invocation
        /// </summary>
        [Zetbox.API.DefinitionGuid("f3caf1b1-867b-4c09-8377-e7542fd51be2")]
        Zetbox.App.Base.TypeRef Implementor {
            get;
            set;
        }

        /// <summary>
        /// Name des implementierenden Members
        /// </summary>
        [Zetbox.API.DefinitionGuid("b14ea4c6-2638-4278-917d-863754aeff4b")]
        string MemberName {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string GetCodeTemplate();

        /// <summary>
        /// 
        /// </summary>
        string GetMemberName();
    }
}
