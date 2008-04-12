using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;

namespace API.Tests
{
    public class TestCollectionEntry : ICollectionEntry
    {
        private int _ID  = -1;
        public int ID { get { return _ID; } set { _ID = value; } }

        private string _TestName;
        public string TestName { get { return _TestName; } set { _TestName = value; } }

        public override bool Equals(object obj)
        {
            if (obj is TestCollectionEntry)
            {
                TestCollectionEntry x = (TestCollectionEntry)obj;
                return
                       this.ID == x.ID
                    && this.TestName == x.TestName;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public void CopyTo(ICollectionEntry obj)
        {
            ((TestCollectionEntry)obj).ID = this.ID;
            ((TestCollectionEntry)obj).TestName = this.TestName;
        }

        public void FromStream(IKistlContext ctx, System.IO.BinaryReader sr)
        {
            BinarySerializer.FromBinary(out _ID, sr);
            BinarySerializer.FromBinary(out _TestName, sr);
        }

        public void ToStream(System.IO.BinaryWriter sw)
        {
            BinarySerializer.ToBinary(ID, sw);
            BinarySerializer.ToBinary(TestName, sw);
        }

        public void NotifyPropertyChanged(string property)
        {
            throw new NotImplementedException();
        }

        public void NotifyPropertyChanging(string property)
        {
            throw new NotImplementedException();
        }
    }
}
