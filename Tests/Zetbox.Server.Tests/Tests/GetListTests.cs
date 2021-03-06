// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.Server.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Autofac;

    using Zetbox.API;
    using Zetbox.API.Server;
    using Zetbox.App.Base;

    using NUnit.Framework;
    using NUnit.Framework.Constraints;

    [TestFixture]
    public class GetListTests : AbstractServerTestFixture
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Zetbox.Tests.Server.GetList");

        private IReadOnlyZetboxContext ctx;

        public override void SetUp()
        {
            base.SetUp();
            ctx = GetContext();
        }

        [Test]
        public void GetList()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().ToList();
            Assert.That(list.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetList_Twice()
        {
            List<Zetbox.App.Base.ObjectClass> list1 = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().ToList();
            Assert.That(list1, Is.Not.Null);
            Assert.That(list1.Count, Is.AtLeast(2));
            list1.ForEach(obj => Assert.That(obj, Is.Not.Null));

            List<Zetbox.App.Base.ObjectClass> list2 = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().ToList();
            Assert.That(list2, Is.Not.Null);
            Assert.That(list2.Count, Is.EqualTo(list1.Count));
            list2.ForEach(obj => Assert.That(obj, Is.Not.Null));

            for (int i = 0; i < list1.Count; i++)
            {
                Assert.That(object.ReferenceEquals(list1[i], list2[i]), "list1[i] & list2[i] are different Objects");
            }
        }

        [Test]
        public void GetObject_GetList()
        {
            var prop = ctx.Find<Zetbox.App.Base.Property>(1);
            Assert.That(prop, Is.Not.Null);
            Assert.That(prop.Context, Is.EqualTo(ctx));

            var list_objclass = ctx.GetQuery<Zetbox.App.Base.DataType>().ToList();
            Assert.That(list_objclass.Count, Is.GreaterThan(0));

            var objclass = list_objclass.Single(o => o == prop.ObjectClass);
            Assert.That(objclass.Context, Is.EqualTo(ctx));
            var prop_test = objclass.Properties.Single(p => p.ID == prop.ID);
            Assert.That(prop_test.Context, Is.EqualTo(ctx));

            Assert.That(prop, Is.SameAs(prop_test), "prop & prop_test are different Objects");
        }

        [Test]
        public void GetList_GetOneObject()
        {
            var list_objclass = ctx.GetQuery<Zetbox.App.Base.DataType>().ToList();
            Assert.That(list_objclass.Count, Is.GreaterThan(0));

            var prop = ctx.Find<Zetbox.App.Base.Property>(1);
            Assert.That(prop, Is.Not.Null);

            var objclass = list_objclass.Single(o => o == prop.ObjectClass);
            var prop_test = objclass.Properties.Single(p => p.ID == prop.ID);

            Assert.That(object.ReferenceEquals(prop, prop_test), "prop & prop_test are different Objects");
        }


        [Test]
        public void GetList_With_Take()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().Take(10).ToList();
            Assert.That(list.Count, Is.EqualTo(10));
        }

        [Test]
        public void GetList_With_Take_And_Where()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().Where(o => o.Module.Name == "ZetboxBase").Take(10).ToList();
            Assert.That(list.Count, Is.EqualTo(10));
        }

        [Test]
        public void GetList_With_OrderBy()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().OrderBy(o => o.Name).ToList();
            Assert.That(list.Count, Is.GreaterThan(0));
            List<Zetbox.App.Base.ObjectClass> result = list.ToList();
            List<Zetbox.App.Base.ObjectClass> sorted = list.OrderBy(o => o.Name).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].ID != sorted[i].ID)
                {
                    Assert.Fail("List was not sorted");
                    break;
                }
            }
        }

        [Test]
        public void GetList_With_OrderBy_And_Where()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().Where(o => o.Module.Name == "ZetboxBase").OrderBy(o => o.Name).ToList();
            Assert.That(list.Count, Is.GreaterThan(0));
            List<Zetbox.App.Base.ObjectClass> result = list.ToList();
            List<Zetbox.App.Base.ObjectClass> sorted = list.OrderBy(o => o.Name).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].ID != sorted[i].ID)
                {
                    Assert.Fail("List was not sorted");
                    break;
                }
            }
        }

        [Test]
        public void GetList_With_OrderBy_ThenOrderBy()
        {
            var list = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().OrderBy(o => o.Module.Name).ThenBy(o => o.Name).ToList();
            Assert.That(list.Count, Is.GreaterThan(0));
            List<Zetbox.App.Base.ObjectClass> result = list.ToList();
            List<Zetbox.App.Base.ObjectClass> sorted = list.OrderBy(o => o.Module.Name).ThenBy(o => o.Name).ToList();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].ID != sorted[i].ID)
                {
                    Assert.Fail("List was not sorted");
                    break;
                }
            }
        }

        [Test]
        public void GetList_With_Parameter_Legal()
        {
            var test = (from m in ctx.GetQuery<Zetbox.App.Base.Module>()
                        where
                            m.Name.StartsWith("Z")
                            && m.Namespace.Length > 1
                            && m.Name == "ZetboxBase"
                            && m.Name.EndsWith("e")
                        select m).ToList();
            Assert.That(test.Count, Is.EqualTo(1));
            foreach (var t in test)
            {
                Log.DebugFormat("GetListWithParameterLegal: {0}", t.Name);
            }
        }

        [Test]
        public void GetList_With_Projection()
        {
            var test = from z in ctx.GetQuery<ObjectClass>()
                       select new { A = z.Name, B = z.TableName };
            foreach (var t in test)
            {
                Log.DebugFormat("GetListWithProjection: {0}", t.A);
            }
        }

        [Test]
        [Ignore("Case 471")]
        public void GetList_With_Single()
        {
            var guiModule = ctx.GetQuery<Zetbox.App.Base.Module>().Where(m => m.Name == "GUI").Single();
            Assert.That(guiModule, Is.Not.Null);
            Assert.That(guiModule.Name, Is.EqualTo("GUI"));
        }

        [Test]
        [Ignore("Case 471")]
        public void GetList_Single()
        {
            var guiModule = ctx.GetQuery<Zetbox.App.Base.Module>().Single(m => m.Name == "GUI");
            Assert.That(guiModule, Is.Not.Null);
            Assert.That(guiModule.Name, Is.EqualTo("GUI"));
        }

        [Test]
        public void GetList_With_First()
        {
            var guiModule = ctx.GetQuery<Zetbox.App.Base.Module>().Where(m => m.Name == "GUI").First();
            Assert.That(guiModule, Is.Not.Null);
            Assert.That(guiModule.Name, Is.EqualTo("GUI"));
        }

        [Test]
        public void GetList_First()
        {
            var guiModule = ctx.GetQuery<Zetbox.App.Base.Module>().First(m => m.Name == "GUI");
            Assert.That(guiModule, Is.Not.Null);
            Assert.That(guiModule.Name, Is.EqualTo("GUI"));
        }

        public class Test
        {
            public string TestProp { get; set; }
        }

        /// <summary>
        /// Case 472
        /// http://blogs.msdn.com/mattwar/archive/2007/08/01/linq-building-an-iqueryable-provider-part-iii.aspx
        /// </summary>
        [Test]
        public void GetList_With_PropertyAccessor()
        {
            Test t = new Test();
            t.TestProp = "foo";
            var result = ctx.GetQuery<Zetbox.App.Base.Assembly>()
                .Where(a => a.Name == t.TestProp).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetList_With_PropertyObjectAccessor()
        {
            int mID = ctx.GetQuery<Zetbox.App.Base.ObjectClass>().First().Module.ID;
            using (var otherCtx = GetContext())
            {
                var result = otherCtx.GetQuery<Zetbox.App.Base.ObjectClass>().Where(c => c.Module.ID == mID).ToList();
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Count, Is.GreaterThan(0));
            }
        }

        [Test]
        [Ignore("Case 1760: Enum member access does not work yet")]
        public void GetList_With_EnumAccessor()
        {
            StorageType v = StorageType.MergeIntoA;
            var result = ctx.GetQuery<Zetbox.App.Base.Relation>()
                .Where(i => i.Storage == v).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetList_With_EnumAccessor_Constant()
        {
            var result = ctx.GetQuery<Zetbox.App.Base.Relation>()
                .Where(i => i.Storage == StorageType.MergeIntoA).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        [Ignore("Case 1760: Enum member access does not work yet")]
        public void GetList_With_Nullable_EnumAccessor()
        {
            DateTimeStyles v = DateTimeStyles.Date;
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == v).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetList_With_Nullable_EnumAccessor_Constant()
        {
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == DateTimeStyles.Date).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        [Ignore("Case 1760: Enum member access does not work yet")]
        public void GetList_With_Nullable_EnumAccessor_Nullable_Value()
        {
            DateTimeStyles? v = DateTimeStyles.Date;
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == v).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetList_With_Nullable_EnumAccessor_Nullable_Constant()
        {
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == (DateTimeStyles?)DateTimeStyles.Date).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        [Ignore("Case 1760: Enum member access does not work yet")]
        public void GetList_With_Nullable_EnumAccessor_With_Null_Value()
        {
            DateTimeStyles? v = null;
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == v).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }

        [Test]
        public void GetList_With_Nullable_EnumAccessor_With_Null_Constant()
        {
            var result = ctx.GetQuery<Zetbox.App.Base.DateTimeProperty>()
                .Where(i => i.DateTimeStyle == null).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.GreaterThan(0));
        }
    }
}
