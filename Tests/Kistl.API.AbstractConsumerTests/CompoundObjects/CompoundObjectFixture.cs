using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Test;

using NUnit.Framework;
using System.Globalization;

namespace Kistl.API.AbstractConsumerTests.CompoundObjects
{

    public abstract class CompoundObjectFixture
    {
        protected const int MINLISTCOUNT = 5;
        public abstract IKistlContext GetContext();

        protected Random rnd = new Random();
        protected string testNumber;
        protected IKistlContext ctx;
        protected TestCustomObject obj;

        [SetUp]
        public void InitTestObjects()
        {
            DeleteTestData();
            CreateTestData();

            ctx = GetContext();
            obj = ctx.GetQuery<TestCustomObject>().First();

            testNumber = "TestNumber " + rnd.NextDouble().ToString(CultureInfo.InvariantCulture);
        }

        protected virtual void DeleteTestData()
        {
            using (IKistlContext ctx = GetContext())
            {
                ctx.GetQuery<TestCustomObject>().ForEach(obj => ctx.Delete(obj));
                ctx.SubmitChanges();
            }
        }

        protected virtual void CreateTestData()
        {
            using (IKistlContext create_ctx = GetContext())
            {
                TestCustomObject create_obj;

                create_obj = create_ctx.Create<TestCustomObject>();
                create_obj.Birthday = DateTime.Now;
                create_obj.PersonName = "First Person";
                create_obj.PhoneNumberMobile = create_ctx.CreateCompoundObject<TestPhoneCompoundObject>();
                create_obj.PhoneNumberMobile.AreaCode = "1";
                create_obj.PhoneNumberMobile.Number = "11111111";
                create_obj.PhoneNumberOffice.AreaCode = "o1";
                create_obj.PhoneNumberOffice.Number = "o11111111";
                AddPhoneNumberOther(create_ctx, create_obj, MINLISTCOUNT);

                create_obj = create_ctx.Create<TestCustomObject>();
                create_obj.Birthday = DateTime.Now;
                create_obj.PersonName = "Second Person";
                create_obj.PhoneNumberMobile = create_ctx.CreateCompoundObject<TestPhoneCompoundObject>();
                create_obj.PhoneNumberMobile.AreaCode = "2";
                create_obj.PhoneNumberMobile.Number = "22222222";
                create_obj.PhoneNumberOffice.AreaCode = "o1";
                create_obj.PhoneNumberOffice.Number = "o2222222";
                AddPhoneNumberOther(create_ctx, create_obj, MINLISTCOUNT + 5);

                create_obj = create_ctx.Create<TestCustomObject>();
                create_obj.Birthday = DateTime.Now;
                create_obj.PersonName = "Third Person";
                create_obj.PhoneNumberMobile = create_ctx.CreateCompoundObject<TestPhoneCompoundObject>();
                create_obj.PhoneNumberMobile.AreaCode = "3";
                create_obj.PhoneNumberMobile.Number = "3333333";
                create_obj.PhoneNumberOffice.AreaCode = "o3";
                create_obj.PhoneNumberOffice.Number = "o3333333";
                AddPhoneNumberOther(create_ctx, create_obj, MINLISTCOUNT + 10);

                create_ctx.SubmitChanges();
            }
        }

        private void AddPhoneNumberOther(IKistlContext create_ctx, TestCustomObject obj, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var c = create_ctx.CreateCompoundObject<TestPhoneCompoundObject>();
                c.AreaCode = "123";
                c.Number = rnd.Next(int.MaxValue).ToString();
                obj.PhoneNumbersOther.Add(c);
            }
        }

        [TearDown]
        public virtual void DisposeContext()
        {
            ctx.Dispose();
        }
    }

}
