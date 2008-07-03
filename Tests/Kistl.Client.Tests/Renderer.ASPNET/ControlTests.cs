using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.Client.Mocks;
using Kistl.GUI.DB;
using Kistl.GUI.Mocks;
using Kistl.GUI.Tests;

using NUnit.Framework;
using Kistl.Client.ASPNET.Toolkit;

namespace Kistl.GUI.Renderer.ASPNET.Tests
{
    [TestFixture]
    [Ignore("TODO: ASP.NET Testframework")]
    public class BoolControlTests : ValueControlTests<bool?, BoolPropertyControl>
    {
        public BoolControlTests()
            : base(
                new ControlHarness<BoolPropertyControl>(TestObject.TestBoolVisual, Toolkit.ASPNET),
                new BoolValues()
            )
        {
        }

        [Test]
        [Ignore()]
        public override void TestUserInput()
        {
            //TestUserInput((w, v) => w.SetValue(BoolPropertyControl.ValueProperty, v));
        }

    }

    [TestFixture]
    [Ignore("TODO: ASP.NET Testframework")]
    public class DateTimeControlTests : ValueControlTests<DateTime?, DateTimePropertyControl>
    {
        public DateTimeControlTests()
            : base(
                new ControlHarness<DateTimePropertyControl>(TestObject.TestDateTimeVisual, Toolkit.ASPNET),
                new DateTimeValues()
            )
        {
        }

        [Test]
        [Ignore()]
        public override void TestUserInput()
        {
            //TestUserInput((w, v) => w.SetValue(EditDateTimeProperty.ValueProperty, v));
        }

    }

    [TestFixture]
    [Ignore("TODO: ASP.NET Testframework")]
    public class DoubleControlTests : ValueControlTests<double?, DoublePropertyControl>
    {
        public DoubleControlTests()
            : base(
                new ControlHarness<DoublePropertyControl>(TestObject.TestDoubleVisual, Toolkit.ASPNET),
                new DoubleValues()
            )
        {
        }
        [Test]
        [Ignore()]
        public override void TestUserInput()
        {
            //TestUserInput((w, v) => w.SetValue(EditDoubleProperty.ValueProperty, v));
        }
    }

    [TestFixture]
    [Ignore("TODO: ASP.NET Testframework")]
    public class IntControlTests : ValueControlTests<int?, IntPropertyControl>
    {
        public IntControlTests()
            : base(
                new ControlHarness<IntPropertyControl>(TestObject.TestIntVisual, Toolkit.ASPNET),
                new IntValues()
            )
        {
        }

        [Test]
        [Ignore()]
        public override void TestUserInput()
        {
            //TestUserInput((w, v) => w.SetValue(EditIntProperty.ValueProperty, v));
        }
    }

    [TestFixture]
    [Ignore("TODO: ASP.NET Testframework")]
    public class StringControlTests : ValueControlTests<string, StringPropertyControl>
    {
        public StringControlTests()
            : base(
                new ControlHarness<StringPropertyControl>(TestObject.TestStringVisual, Toolkit.ASPNET),
                new StringValues()
            )
        {
        }
        [Test]
        [Ignore()]
        public override void TestUserInput()
        {
            //TestUserInput((w, v) => w.SetValue(EditSimpleProperty.ValueProperty, v));
        }

    }

}
