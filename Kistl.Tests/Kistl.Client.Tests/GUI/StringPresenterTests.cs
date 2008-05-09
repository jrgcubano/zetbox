using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using Kistl.Client.Mocks;
using Kistl.GUI;
using Kistl.GUI.DB;

namespace Kistl.GUI.Tests
{
    [TestFixture]
    public class StringPresenterTests : ReferencePresenterTests<string, TestStringControl, StringPresenter>
    {
        protected override void CustomSetUp()
        {
            Init(TestStringControl.Info, TestObject.TestStringDescriptor, Toolkit.TEST);
        }

        protected override string GetObjectValue() { return obj.TestString; }
        protected override string GetWidgetValue() { return widget.Value; }
        protected override void SetObjectValue(string v) { obj.TestString = v; }
        protected override void UserInput(string v) { widget.SimulateUserInput(v); }
        protected override string DefaultValue() { return null; }
        protected override IEnumerable<string> SomeValues()
        {
            return new List<string>(new[] { 
                "foo", "<xss>", "'!\"§!$%!%`id`$(id)§&''''''''#%$/\\\"$%!°\"§!/%()( -- blah /* blubb */ // hallo", "", 
                "00012346789", "0", "0.0", "0.1", "0.002", "10.0e100", "0x120",
                "...", "<xss>", "!'\"§!$§%&/(){}&amp;", "normal string",
                "very long string: very long string: very long string: very long string: very long string: very long string: " +
                "very long string: very long string: very long string: very long string: very long string: very long string: " +
                "very long string: very long string: very long string: very long string: very long string: very long string: " +
                "very long string: very long string: very long string: very long string: very long string: very long string"
            });
        }
    }
}
