
namespace Kistl.App.Test
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// A Test Interface
    /// </summary>
    public interface ITestInterface  
    {

        /// <summary>
        /// String Property für das Testinterface
        /// </summary>

		string StringProp { get; set; }
        /// <summary>
        /// Objektpointer für das Testinterface
        /// </summary>

		Kistl.App.Projekte.Kunde ObjectProp { get; set; }
        /// <summary>
        /// Test Enum Property
        /// </summary>

		Kistl.App.Test.TestEnum TestEnumProp { get; set; }
        /// <summary>
        /// 
        /// </summary>

		 void TestMethod(System.DateTime DateTimeParam) ;
    }
}