using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.SyntaxHelpers;
using Kistl.Server;
using Kistl.API.Server;

namespace Kistl.Server.Tests
{
    [TestFixture]
    public class StructTests
    {
        Random rnd = new Random();
        string number;

        [SetUp]
        [Ignore("To be implemented on server")]
        public void SetUp()
        {
            number = rnd.Next().ToString();
        }

        [Test]
        [Ignore("To be implemented on server")]
        public void CreateObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
            {
                var obj = ctx.Create<Kistl.App.Test.TestCustomObject>();
                obj.PersonName = "TestPerson " + rnd.Next();
                obj.Birthday = DateTime.Now;

                Assert.That(obj.PhoneNumberMobile, Is.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Null);

                obj.PhoneNumberMobile = ctx.CreateStruct<Kistl.App.Test.TestPhoneStruct>();
                obj.PhoneNumberOffice = ctx.CreateStruct<Kistl.App.Test.TestPhoneStruct>();

                obj.PhoneNumberMobile.AreaCode = "1";
                obj.PhoneNumberMobile.Number = number;

                obj.PhoneNumberOffice.AreaCode = "1";
                obj.PhoneNumberOffice.Number = number;

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));

                ID = obj.ID;
            }

            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
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
        [Ignore("To be implemented on server")]
        public void GetObjectWithStruct()
        {
            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                foreach (var obj in objList)
                {
                    Assert.That(obj.ID, Is.GreaterThan(Kistl.API.Helper.INVALIDID));
                }
            }
        }

        [Test]
        [Ignore("To be implemented on server")]
        public void SaveObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
            {
                var objList = ctx.GetQuery<Kistl.App.Test.TestCustomObject>();
                var obj = objList.First();
                ID = obj.ID;

                obj.PhoneNumberMobile = ctx.CreateStruct<Kistl.App.Test.TestPhoneStruct>();
                obj.PhoneNumberOffice = ctx.CreateStruct<Kistl.App.Test.TestPhoneStruct>();

                obj.PhoneNumberMobile.AreaCode = "1";
                obj.PhoneNumberMobile.Number = number;

                obj.PhoneNumberOffice.AreaCode = "1";
                obj.PhoneNumberOffice.Number = number;

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));
            }
            
            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
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
        [Ignore("To be implemented on server")]
        public void ChangeObjectWithStruct()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string oldNumber;

            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
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

            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
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
        [Ignore("Nicht fertig besprochen")]
        public void SetStructNull()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string number = new Random().Next().ToString();

            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
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
                testObject.PhoneNumberOffice = null;
                testObject.PhoneNumberMobile = null;

                Assert.That(ctx.SubmitChanges(), Is.EqualTo(1));

                ID = testObject.ID;
            }

            using (Kistl.API.IKistlContext ctx = KistlContext.GetContext())
            {
                var obj = ctx.Find<Kistl.App.Test.TestCustomObject>(ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.PhoneNumberMobile, Is.Null);
                Assert.That(obj.PhoneNumberOffice, Is.Null);
            }
        }
    }
}
