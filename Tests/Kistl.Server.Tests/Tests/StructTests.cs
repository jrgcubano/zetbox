using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API.Server;

using NUnit.Framework;
using NUnit.Framework.Constraints;
using Kistl.API;
using Autofac;


namespace Kistl.Server.Tests
{
    [TestFixture]
    public class StructTests
    {
        private IContainer container;
        private IContainer GetContainer()
        {
            if (container == null)
            {
                container = Kistl.Server.Tests.SetUp.CreateInnerContainer();
            }
            return container;
        }

        [TearDown]
        public void TearDownContainer()
        {
            if (container != null)
            {
                container.Dispose();
                container = null;
            }
        }

        protected IKistlContext GetContext()
        {
            return GetContainer().Resolve<IKistlContext>();
        }

        Random rnd = new Random();
        string number;

        [SetUp]
        public void SetUp()
        {
            number = rnd.Next().ToString();
        }

        [Test]
        public void CreateObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var obj = ctx.Create<Kistl.App.Test.TestCustomObject>();
                obj.PersonName = "TestPerson " + rnd.Next();
                obj.Birthday = DateTime.Now;

                Assert.That(obj.PhoneNumberMobile, Is.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Null);

                obj.PhoneNumberMobile.AreaCode = "1";
                obj.PhoneNumberMobile.Number = number;

                obj.PhoneNumberOffice.AreaCode = "1";
                obj.PhoneNumberOffice.Number = number;

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));

                ID = obj.ID;
            }

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var obj = ctx.Find<Kistl.App.Test.TestCustomObject>(ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile, Is.Not.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile.Number, Is.EqualTo(number));
                Assert.That(obj.PhoneNumberOffice.Number, Is.EqualTo(number));
            }
        }

        [Test]
        public void GetObjectWithStruct()
        {
            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                foreach (var obj in objList)
                {
                    Assert.That(obj.ID, Is.GreaterThan(Kistl.API.Helper.INVALIDID));
                }
            }
        }

        [Test]
        public void SaveObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                var obj = objList.First();
                ID = obj.ID;

                obj.PhoneNumberMobile.AreaCode = "1";
                obj.PhoneNumberMobile.Number = number;

                obj.PhoneNumberOffice.AreaCode = "1";
                obj.PhoneNumberOffice.Number = number;

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));
            }

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var obj = ctx.Find<Kistl.App.Test.TestCustomObject>(ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile, Is.Not.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile.Number, Is.EqualTo(number));
                Assert.That(obj.PhoneNumberOffice.Number, Is.EqualTo(number));
            }
        }

        /// <summary>
        /// Tests if setting a Structmember directy does _not_ change the value.
        /// </summary>
        [Test]
        public void ChangeObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string oldNumber;

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                Kistl.App.Test.TestCustomObject testObject = null;
                foreach (var obj in objList)
                {
                    if (obj.PhoneNumberMobile != null && obj.PhoneNumberOffice != null)
                    {
                        testObject = obj;
                        break;
                    }
                }

                Assert.That(testObject, Is.Not.Null);

                oldNumber = testObject.PhoneNumberOffice.Number;

                testObject.PhoneNumberOffice.Number = number;
                testObject.PhoneNumberMobile.Number = number;

                Assert.That(testObject.PhoneNumberMobile.Number, Is.EqualTo(number));
                Assert.That(testObject.PhoneNumberOffice.Number, Is.EqualTo(number));

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));

                ID = testObject.ID;
            }

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var obj = ctx.Find<Kistl.App.Test.TestCustomObject>(ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile, Is.Not.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile.Number, Is.EqualTo(number));
                Assert.That(obj.PhoneNumberOffice.Number, Is.EqualTo(number));
            }
        }

        [Test]
        public void SetStructNull()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string number = new Random().Next().ToString();

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                Kistl.App.Test.TestCustomObject testObject = null;
                foreach (var obj in objList)
                {
                    if (obj.PhoneNumberMobile != null && obj.PhoneNumberOffice != null)
                    {
                        testObject = obj;
                        break;
                    }
                }

                Assert.That(testObject, Is.Not.Null);

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));

                ID = testObject.ID;
            }

            using (Kistl.API.IKistlContext ctx = GetContext())
            {
                var obj = ctx.Find<Kistl.App.Test.TestCustomObject>(ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile, Is.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Null);
            }
        }
    }
}
