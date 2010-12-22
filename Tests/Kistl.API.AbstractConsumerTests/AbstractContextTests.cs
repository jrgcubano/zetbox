using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Projekte;
using Kistl.App.Test;

using NUnit.Framework;
using Autofac;

namespace Kistl.API.AbstractConsumerTests
{

    public abstract class AbstractReadonlyContextTests : AbstractTestFixture
    {
        protected int firstId;
        protected int secondId;
        protected InterfaceType.Factory iftFactory;

        public override void SetUp()
        {
            iftFactory = scope.Resolve<InterfaceType.Factory>();

            using (IKistlContext ctx = GetContext())
            {
                var result = ctx.GetQuery<TestObjClass>();
                var list = result.ToList();

                while (list.Count < 2)
                {
                    var newObj = ctx.Create<TestObjClass>();
                    newObj.ObjectProp = ctx.GetQuery<Kunde>().First();
                    newObj.StringProp = "blah" + list.Count;
                    list.Add(newObj);
                }

                ctx.SubmitChanges();

                firstId = list[0].ID;
                list[0].StringProp = "First";
                list[0].TestEnumProp = TestEnum.First;

                secondId = list[1].ID;
                list[1].StringProp = "Second";
                list[1].TestEnumProp = TestEnum.Second;

                ctx.SubmitChanges();
            }
        }

        [Test]
        public void query_should_execute_twice()
        {
            using (var ctx = GetContext())
            {
                var query = ctx.GetQuery<TestObjClass>();

                // call linq2objects OrderBy to avoid touching other parts of the provider
                var results1 = query.ToList().OrderBy(t => t.ID);
                var results2 = query.ToList().OrderBy(t => t.ID);

                Assert.That(results2, Is.EquivalentTo(results1), "Query.ToList() didn't return the same collection on the second execution");
            }
        }

        [Test]
        public void query_should_be_reusable()
        {
            using (var ctx = GetContext())
            {
                var query = ctx.GetQuery<TestObjClass>();

                // call providers' OrderBy to create two different queries
                var results1 = query.OrderBy(t => t.ID).ToList();
                var results2 = query.OrderBy(t => t.ID).ToList();

                Assert.That(results2, Is.EquivalentTo(results1), "Query.ToList() didn't return the same collection on the second execution");
            }
        }

        [Test]
        public void query_should_be_reusable_nesting()
        {
            using (var ctx = GetContext())
            {
                var query = ctx.GetQuery<TestObjClass>().Where(t => t.ID > 2).OrderBy(t => t.ID);

                var results1 = query.ToList();
                // reuse queried query again, nested in another query
                var results2 = query.Where(t => t.ID > 2).ToList();

                Assert.That(results2, Is.EquivalentTo(results1), "Query.ToList() didn't return the same collection on the second execution");
            }
        }
    }

    public abstract class AbstractContextTests : AbstractReadonlyContextTests
    {
        private static Guid guidTestModule = new Guid("81e8ce31-65eb-46fe-ba86-de7452692d5b");
        protected static Guid sequence = new Guid("5c3d9012-a36d-4910-9e7b-1bf7d8f7d09d");
        protected static Guid continuousSequence = new Guid("57a01b4f-940d-4089-b239-fa5a46dc7d00");

        public override void SetUp()
        {
            base.SetUp();
            using (var ctx = GetContext())
            {
                ProjectDataFixture.DeleteData(ctx);
                ctx.GetQuery<TestObjClass>().ForEach(obj => { obj.ObjectProp = null; ctx.Delete(obj); });
                ProjectDataFixture.CreateTestData(ctx);
                ctx.SubmitChanges();
            }
        }

        public override void TearDown()
        {
            using (var ctx = GetContext())
            {
                ProjectDataFixture.DeleteData(ctx);
                ctx.GetQuery<TestObjClass>().ForEach(obj => { obj.ObjectProp = null; ctx.Delete(obj); });
                ctx.SubmitChanges();
            }
            base.TearDown();
        }

        [Test]
        public void should_find_new_objects()
        {
            using (var ctx = GetContext())
            {
                var obj = ctx.Create<TestObjClass>();
                Assert.That(ctx.Find<TestObjClass>(obj.ID), Is.SameAs(obj));
            }

        }

        [Test]
        [Ignore("Discuss")]
        public void should_create_objects_with_valid_IDs()
        {
            using (var ctx = GetContext())
            {
                int objCount = 10;
                while (objCount-- > 0)
                {
                    var obj = ctx.Create<TestObjClass>();
                    Assert.That(obj.ID, Is.Not.EqualTo(Kistl.API.Helper.INVALIDID));
                }
            }
        }

        [Test]
        [Ignore("Discuss")]
        public void should_create_objects_with_different_IDs()
        {
            var objList = new List<TestObjClass>();
            using (var ctx = GetContext())
            {
                int objCount = 10;
                while (objCount-- > 0)
                {
                    objList.Add(ctx.Create<TestObjClass>());
                }
            }

            Assert.DoesNotThrow(delegate()
            {
                // throws exception on duplicate keys
                objList.ToDictionary(o => o.ID);
            });
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_fail_on_existing_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.BeginTransaction();
                ctx.BeginTransaction();
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void commit_should_fail_on_non_existing_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.CommitTransaction();
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void rollback_should_fail_on_non_existing_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.RollbackTransaction();
            }
        }

        [Test]
        public void should_commit_empty_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.BeginTransaction();
                ctx.CommitTransaction();
            }
        }

        [Test]
        public void should_rollback_empty_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.BeginTransaction();
                ctx.RollbackTransaction();
            }
        }

        private TestObjClass CreateTestObjClass(IKistlContext ctx)
        {
            var result = ctx.Create<TestObjClass>();
            result.MyIntProperty = 1;
            result.StringProp = "test";
            result.TestEnumProp = TestEnum.First;
            return result;
        }

        [Test]
        [Ignore("SQL Server locks the table")]
        public void uncommited_data_should_not_be_visible()
        {
            using (var ctx = GetContext())
            using (var testCtx = GetContext())
            {
                List<TestObjClass> objects = new List<TestObjClass>();
                ctx.BeginTransaction();

                objects.Add(CreateTestObjClass(ctx));
                objects.Add(CreateTestObjClass(ctx));
                ctx.SubmitChanges();

                objects.Add(CreateTestObjClass(ctx));
                objects.Add(CreateTestObjClass(ctx));
                ctx.SubmitChanges();

                // SQL Server locks the table
                //foreach (var obj in objects)
                //{
                //    Assert.That(obj.ID, Is.GreaterThan(Helper.INVALIDID));
                //    var testObj = testCtx.Find<TestObjClass>(obj.ID);
                //    Assert.That(testObj, Is.Null);
                //}

                ctx.CommitTransaction();

                foreach (var obj in objects)
                {
                    Assert.That(obj.ID, Is.GreaterThan(Helper.INVALIDID));
                    var testObj = testCtx.Find<TestObjClass>(obj.ID);
                    Assert.That(testObj, Is.Not.Null);
                }
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void should_rollbacktransaction()
        {
            using (var ctx = GetContext())
            using (var testCtx = GetContext())
            {
                List<TestObjClass> objects = new List<TestObjClass>();
                ctx.BeginTransaction();

                objects.Add(CreateTestObjClass(ctx));
                objects.Add(CreateTestObjClass(ctx));
                ctx.SubmitChanges();

                objects.Add(CreateTestObjClass(ctx));
                objects.Add(CreateTestObjClass(ctx));
                ctx.SubmitChanges();

                // SQL Server locks the table
                //foreach (var obj in objects)
                //{
                //    Assert.That(obj.ID, Is.GreaterThan(Helper.INVALIDID));
                //    var testObj = testCtx.Find<TestObjClass>(obj.ID);
                //    Assert.That(testObj, Is.Null);
                //}

                ctx.RollbackTransaction();

                foreach (var obj in objects)
                {
                    Assert.That(obj.ID, Is.GreaterThan(Helper.INVALIDID));
                    var testObj = testCtx.Find<TestObjClass>(obj.ID);
                    Assert.That(testObj, Is.Null);
                }
            }
        }

        [Test]
        public void should_increment_sequence()
        {
            using (var ctx = GetContext())
            {
                var s = ctx.FindPersistenceObject<Sequence>(sequence);
                Assert.That(s.IsContinuous, Is.False);
                var currentNumber = s.CurrentNumber;
                var next = ctx.GetSequenceNumber(sequence);
                Assert.That(next, Is.EqualTo(currentNumber + 1));
            }
        }

        [Test]
        public void should_increment_continuous_sequence()
        {
            using (var ctx = GetContext())
            {
                ctx.BeginTransaction();
                var s = ctx.FindPersistenceObject<Sequence>(continuousSequence);
                Assert.That(s.IsContinuous, Is.True);
                var currentNumber = s.CurrentNumber;
                var next = ctx.GetContinuousSequenceNumber(continuousSequence);
                Assert.That(next, Is.EqualTo(currentNumber + 1));
                ctx.CommitTransaction();
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_fail_on_wrong_sequence_method()
        {
            using (var ctx = GetContext())
            {
                ctx.GetSequenceNumber(continuousSequence);
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_fail_on_wrong_continuous_sequence_method()
        {
            using (var ctx = GetContext())
            {
                ctx.GetContinuousSequenceNumber(sequence);
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_fail_on_increment_continuous_sequence_without_transaction()
        {
            using (var ctx = GetContext())
            {
                ctx.GetContinuousSequenceNumber(sequence);
            }
        }

        [Test]
        public void GetContext_returns_a_context()
        {
            IKistlContext ctx = GetContext();
            Assert.That(ctx, Is.Not.Null);
        }


        [Test]
        public void GetQuery()
        {
            using (IKistlContext ctx = GetContext())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result, Is.Not.Null);
            }
        }

        [Test]
        public void GetQuery_ObjType()
        {
            using (IKistlContext ctx = GetContext())
            {
                var result = ctx.GetQuery(iftFactory(typeof(TestObjClass)));
                Assert.That(result, Is.Not.Null);
                var testObj = result.First(o => o.ID == firstId);
                Assert.That(testObj, Is.Not.Null);
                Assert.That(testObj, Is.InstanceOf(typeof(TestObjClass)));
            }
        }

        [Test]
        public void Find_T_returns_right_object()
        {
            using (IKistlContext ctx = GetContext())
            {
                TestObjClass obj = ctx.Find<TestObjClass>(firstId);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.ID, Is.EqualTo(firstId));
                Assert.That(obj.TestEnumProp, Is.EqualTo(TestEnum.First));
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Find_T_fails_on_invalid_ID()
        {
            using (IKistlContext ctx = GetContext())
            {
                ctx.Find<TestObjClass>(Kistl.API.Helper.INVALIDID);
            }
        }

        [Test]
        public void Find_ObjectType_returns_right_object()
        {
            using (IKistlContext ctx = GetContext())
            {
                TestObjClass obj = (TestObjClass)ctx.Find(iftFactory(typeof(TestObjClass)), firstId);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.ID, Is.EqualTo(firstId));
                Assert.That(obj.TestEnumProp, Is.EqualTo(TestEnum.First));
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Find_ObjectType_fails_on_invalid_ID()
        {
            using (IKistlContext ctx = GetContext())
            {
                ctx.Find(iftFactory(typeof(TestObjClass)), Kistl.API.Helper.INVALIDID);
            }
        }

        [Test]
        public void GetListOf_T_SubClasses_returns_a_non_empty_list_on_class_DataType()
        {
            using (IKistlContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<ObjectClass>().First(o => o.Name == "DataType");
                List<ObjectClass> result = ctx.GetListOf<ObjectClass>(obj, "SubClasses").ToList();
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Count, Is.GreaterThan(0));
            }
        }

        [Test]
        public void GetListOf_ObjType_returns_a_non_empty_list_on_class_DataType()
        {
            using (IKistlContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<ObjectClass>().First(o => o.Name == "DataType");
                List<ObjectClass> result = ctx.GetListOf<ObjectClass>(iftFactory(typeof(ObjectClass)), obj.ID, "SubClasses").ToList();
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Count, Is.GreaterThan(0));
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetListOf_T_WrongPropertyName_fails()
        {
            using (IKistlContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<TestObjClass>().First(o => o.ID == firstId);
                ctx.GetListOf<TestObjClass>(obj, "NotAProperty");
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetListOf_ObjType_WrongPropertyName_fails()
        {
            using (IKistlContext ctx = GetContext())
            {
                ctx.GetListOf<TestObjClass>(iftFactory(typeof(TestObjClass)), firstId, "NotAProperty");
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidCastException))]
        public void GetListOf_T_WrongItemType_fails()
        {
            using (IKistlContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<ObjectClass>().First(o => o.Name == "DataType");
                ctx.GetListOf<TestObjClass>(obj, "SubClasses").ToList();
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidCastException))]
        public void GetListOf_ObjType_WrongItemType_fails()
        {
            using (IKistlContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<ObjectClass>().First(o => o.Name == "DataType");
                ctx.GetListOf<TestObjClass>(iftFactory(typeof(ObjectClass)), obj.ID, "SubClasses").ToList();
            }
        }

        [Test]
        public void UpdateSomeData_SubmitChanges()
        {
            using (IKistlContext ctx = GetContext())
            {
                TestObjClass obj = ctx.Find<TestObjClass>(firstId);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.StringProp, Is.EqualTo("First"));

                obj.StringProp = "Test";
                ctx.SubmitChanges();
            }

            using (IKistlContext ctx = GetContext())
            {
                TestObjClass obj = ctx.Find<TestObjClass>(firstId);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.StringProp, Is.EqualTo("Test"));
            }
        }

        //[Test]
        //[Ignore("Implement IsSorted on TestObjClass.TestName")]
        //public void UpdateLists_SubmitChanges()
        //{
        //    using (IKistlContext ctx = GetContext())
        //    {
        //        TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
        //        Assert.That(obj.TestNames.Count, Is.EqualTo(2));

        //        //obj.TestNames[1] = "MuhBlah";

        //        ctx.SubmitChanges();
        //    }

        //    using (IKistlContext ctx = GetContext())
        //    {
        //        TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
        //        Assert.That(obj.TestNames.Count, Is.EqualTo(2));

        //        //Assert.That(obj.TestNames[1], Is.EqualTo("MuhBlah"));
        //    }
        //}


        
        [Test]
        public void Create_Generic()
        {
            using (IKistlContext ctx = GetContext())
            {
                bool hasCreated = false;
                GenericEventHandler<IPersistenceObject> createdHandler = new GenericEventHandler<IPersistenceObject>(delegate(object obj, GenericEventArgs<IPersistenceObject> e) { hasCreated = true; });
                ctx.ObjectCreated += createdHandler;

                TestObjClass newObj = ctx.Create<TestObjClass>();
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
                Assert.That(hasCreated, Is.True);

                ctx.ObjectCreated -= createdHandler;
            }
        }

        [Test]
        public void Create_Type()
        {
            using (IKistlContext ctx = GetContext())
            {
                TestObjClass newObj = ctx.Create(iftFactory(typeof(TestObjClass))) as TestObjClass;
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
            }
        }

        [Test]
        public void Create_ObjectType()
        {
            using (IKistlContext ctx = GetContext())
            {
                TestObjClass newObj = ctx.Create(iftFactory(typeof(TestObjClass))) as TestObjClass;
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
            }
        }


        [Test]
        public void Delete_triggers_ObjectDeleted()
        {
            using (IKistlContext ctx = GetContext())
            {
                bool hasDeleted = false;
                GenericEventHandler<IPersistenceObject> deletedHandler = new GenericEventHandler<IPersistenceObject>(
                    delegate(object obj, GenericEventArgs<IPersistenceObject> e)
                    {
                        hasDeleted = true;
                    });
                ctx.ObjectDeleted += deletedHandler;

                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result.ToList().Count, Is.GreaterThan(0));

                result.ForEach<TestObjClass>(
                    o => ctx.Delete(o));

                Assert.That(hasDeleted, Is.True);

                ctx.ObjectDeleted -= deletedHandler;
                ctx.SubmitChanges();
            }
        }

        [Test]
        public void Delete_deletes_objects()
        {
            Delete_triggers_ObjectDeleted();
            using (IKistlContext ctx = GetContext())
            {
                Assert.That(ctx.GetQuery<TestObjClass>().Count(), Is.EqualTo(0));
            }
        }


        //[Test]
        //public void Delete_ICollectionEntry()
        //{
        //    using (IKistlContext ctx = GetContext())
        //    {
        //        var result = ctx.GetQuery<TestObjClass>();
        //        Assert.That(result.ToList().Count, Is.EqualTo(4));

        //        foreach (TestObjClass obj in result)
        //        {
        //            obj.TestNames.Clear();
        //            Assert.That(obj.TestNames.Count, Is.EqualTo(0));
        //        }
        //    }
        //}

        
    }
}
