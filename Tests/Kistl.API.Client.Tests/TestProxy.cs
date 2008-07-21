using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Client;

namespace Kistl.API.Client.Tests
{
    public class TestProxy : Kistl.API.Client.IProxy
    {
        private int newID = 10;

        #region IProxy Members

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDataObject> GetList(Type type, int maxListCount, System.Linq.Expressions.Expression filter, System.Linq.Expressions.Expression orderBy)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (type != typeof(TestObjClass)) throw new ArgumentOutOfRangeException("type", "Only TestObjClasses are allowed");
            if (filter != null) throw new ArgumentException("Filter is not supported yet");
            if (orderBy != null) throw new ArgumentException("OrderBy is not supported yet");

            List<TestObjClass> result = new List<TestObjClass>();
            result.Add(new TestObjClass() { ID = 1, StringProp = "String " + 1 });
            result.Add(new TestObjClass() { ID = 2, StringProp = "String " + 2, fk_Parent = 1 });
            result.Add(new TestObjClass() { ID = 3, StringProp = "String " + 3, fk_Parent = 1 });
            result.Add(new TestObjClass() { ID = 4, StringProp = "String " + 4 });
            result.Add(new TestObjClass() { ID = 5, StringProp = "String " + 5 });

            return result.Cast<IDataObject>();
        }

        public IEnumerable<IDataObject> GetListOf(Type type, int ID, string property)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (type != typeof(TestObjClass)) throw new ArgumentOutOfRangeException("type", "Only TestObjClasses are allowed");

            List<TestObjClass> result = new List<TestObjClass>();
            if (ID == 1)
            {
                result.Add(new TestObjClass() { ID = 2, StringProp = "String " + 2 });
                result.Add(new TestObjClass() { ID = 3, StringProp = "String " + 3 });
            }

            return result.Cast<IDataObject>();
        }

        public Kistl.API.IDataObject GetObject(Type type, int ID)
        {
            if (type == null) throw new ArgumentNullException("type");
            if (type != typeof(TestObjClass)) throw new ArgumentOutOfRangeException("type", "Only TestObjClasses are allowed");

            TestObjClass obj = new TestObjClass() { ID = ID, StringProp = "String " + ID };
            return obj;
        }

        public string HelloWorld(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Kistl.API.IDataObject> SetObjects(IEnumerable<Kistl.API.IDataObject> objects)
        {
            List<IDataObject> result = new List<IDataObject>();
            foreach (IDataObject obj in objects)
            {
                Type type = obj.GetType();
                if (type == null) throw new ArgumentNullException("type");
                if (type != typeof(TestObjClass)) throw new ArgumentOutOfRangeException("type", "Only TestObjClasses are allowed");

                throw new NotImplementedException();
                //TestObjClass newObj = new TestObjClass();
                //obj.ApplyChanges(newObj);
                //newObj.ID = ++newID;
                //result.Add(newObj);
            }

            return result;
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
