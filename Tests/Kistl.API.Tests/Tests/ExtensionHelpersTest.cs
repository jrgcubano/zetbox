using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.SyntaxHelpers;
using Kistl.API;
using System.Reflection;
using System.Linq.Expressions;
using System.Collections;

namespace Kistl.API.Tests
{
    [TestFixture]
    public class ExtensionHelpersTest
    {
        TestDataObject obj;

        [SetUp]
        public void SetUp()
        {
            obj = new TestDataObject__Implementation__() { BoolProperty = true, IntProperty = 1, StringProperty = "test" };
        }

        [Test]
        [Ignore("XML Serialization dysfunctional")]
        public void XmlString()
        {
            string xml = obj.ToXmlString();
            TestDataObject result = xml.FromXmlString<TestDataObject__Implementation__>();

            Assert.That(result, Is.EqualTo(obj));
        }

        [Test]
        public void In()
        {
            DayOfWeek day = DayOfWeek.Thursday;
            bool result = day.In(
                DayOfWeek.Monday, 
                DayOfWeek.Thursday, 
                DayOfWeek.Wednesday, 
                DayOfWeek.Thursday, 
                DayOfWeek.Friday);

            Assert.That(result, Is.True);
        }

        [Test]
        public void InFalse()
        {
            DayOfWeek day = DayOfWeek.Sunday;
            bool result = day.In(
                DayOfWeek.Monday,
                DayOfWeek.Thursday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday);

            Assert.That(result, Is.False);
        }

        [Test]
        public void GetPropertyValue()
        {
            Assert.That(obj.GetPropertyValue<int>("IntProperty"), Is.EqualTo(obj.IntProperty));
            Assert.That(obj.GetPropertyValue<bool>("BoolProperty"), Is.EqualTo(obj.BoolProperty));
            Assert.That(obj.GetPropertyValue<string>("StringProperty"), Is.EqualTo(obj.StringProperty));
        }

        [Test]
        public void SetPropertyValue()
        {
            obj.SetPropertyValue<int>("IntProperty", 2);
            obj.SetPropertyValue<bool>("BoolProperty", false);
            obj.SetPropertyValue<string>("StringProperty", "Hello");

            Assert.That(obj.IntProperty, Is.EqualTo(2));
            Assert.That(obj.BoolProperty, Is.EqualTo(false));
            Assert.That(obj.StringProperty, Is.EqualTo("Hello"));
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPropertyValue_InvalidPropertyName()
        {
            obj.GetPropertyValue<int>("TestProperty");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetPropertyValue_InvalidPropertyName()
        {
            obj.SetPropertyValue<int>("TestProperty", 1);
        }

        [Test]
        public void GetPrivateFieldValue()
        {
            Assert.That(obj.GetPrivateFieldValue<int>("_IntProperty"), Is.EqualTo(obj.IntProperty));
            Assert.That(obj.GetPrivateFieldValue<bool>("_BoolProperty"), Is.EqualTo(obj.BoolProperty));
            Assert.That(obj.GetPrivateFieldValue<string>("_StringProperty"), Is.EqualTo(obj.StringProperty));
        }

        [Test]
        public void SetPrivateFieldValue()
        {
            obj.SetPrivateFieldValue<int>("_IntProperty", 2);
            obj.SetPrivateFieldValue<bool>("_BoolProperty", false);
            obj.SetPrivateFieldValue<string>("_StringProperty", "Hello");

            Assert.That(obj.IntProperty, Is.EqualTo(2));
            Assert.That(obj.BoolProperty, Is.EqualTo(false));
            Assert.That(obj.StringProperty, Is.EqualTo("Hello"));
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPrivateFieldValue_InvalidPropertyName()
        {
            obj.GetPrivateFieldValue<int>("_TestProperty");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetPrivateFieldValue_InvalidPropertyName()
        {
            obj.SetPrivateFieldValue<int>("_TestProperty", 1);
        }

        /// /////////
        [Test]
        public void GetPrivatePropertyValue()
        {
            Assert.That(obj.GetPrivatePropertyValue<int>("PrivateIntProperty"), Is.EqualTo(0));
        }

        [Test]
        public void SetPrivatePropertyValue()
        {
            obj.SetPrivatePropertyValue<int>("PrivateIntProperty", 2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPrivatePropertyValue_InvalidPropertyName()
        {
            obj.GetPrivatePropertyValue<int>("_TestProperty");
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetPrivatePropertyValue_InvalidPropertyName()
        {
            obj.SetPrivatePropertyValue<int>("_TestProperty", 1);
        }
        /// /////////


        [Test]
        public void ForEach_IEnumerable()
        {
            IEnumerable list = new List<int>(new int[] { 1, 2, 3, 4 });
            int result = 0;
            list.ForEach<int>(i => result += i);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void ForEach_List()
        {
            List<int> list = new List<int>(new int[] { 1, 2, 3, 4 });
            int result = 0;
            list.ForEach<int>(i => result += i);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void ForEach_ObservableCollection()
        {
            ObservableCollection<int> list = new ObservableCollection<int>(new int[] { 1, 2, 3, 4 }.ToList());
            int result = 0;
            list.ForEach<int>(i => result += i);
            Assert.That(result, Is.EqualTo(10));
        }
    }
}
