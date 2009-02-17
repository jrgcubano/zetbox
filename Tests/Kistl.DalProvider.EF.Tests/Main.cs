using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kistl.DalProvider.EF.Tests
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var setup = new SetUp();
            setup.Init();

            //BaseServerDataObjectTests();
            KistlDataContextTests();
        }

        //private static void BaseServerDataObjectTests()
        //{
        //    var bsdot = new BaseServerDataObjectTests();
        //    bsdot.SetUp();
        //    bsdot.FromStream_creates_correct_Object();

        //    //bsdot.SetUp();
        //    //bsdot.ToStream_creates_correct_Stream();
        //}

        private static void KistlDataContextTests()
        {
            var tests = new Tests.KistlDataContextTests();

            tests.SetUp();
            tests.GetContext();

            //    tests.SetUp();
            //    tests.Delete_ICollectionEntry();

            //    tests.SetUp();
            //    tests.UpdateLists_SubmitChanges();

            //    tests.SetUp();
            //    tests.Attach_IDataObject_New_WithGraph();

            //    tests.SetUp();
            //    tests.SelectSomeData_Parent();

            //    tests.SetUp();
            //    tests.SelectSomeData_Children();

            //    tests.SetUp();
            //    tests.GetListOf();

            //    tests.SetUp();
            //    tests.GetListOf_ObjType();

            //    tests.SetUp();
            //    tests.GetListOf_WrongPropertyName();

            //    tests.SetUp();
            //    tests.SelectSomeData();

            //    tests.SetUp();
            //    tests.SelectSomeData_Collection();
        }
    }
}
