using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace Kistl.API.AbstractConsumerTests.BinarySerializers
{
    class MinimalCompoundObjectTest 
        : ICompoundObject
    {
        #region ICompoundObject Members

        public void AttachToObject(IPersistenceObject obj, string property)
        {
            throw new NotImplementedException();
        }

        public void DetachFromObject(IPersistenceObject obj, string property)
        {
            throw new NotImplementedException();
        }

        public bool IsReadonly
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IStreamable Members

        public void ToStream(BinaryWriter sw, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {

        }

        public void FromStream(BinaryReader sr)
        {
        }

        public virtual void ToStream(System.Xml.XmlWriter xml)
        {
            if (xml == null) throw new ArgumentNullException("xml");
        }

        public virtual void FromStream(System.Xml.XmlReader xml)
        {
            if (xml == null) throw new ArgumentNullException("xml");
        }

        public void ReloadReferences()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Notify
        public virtual void NotifyPropertyChanging(string property, object oldValue, object newValue)
        {
            if (PropertyChanging != null)
                PropertyChanging(this, new PropertyChangingEventArgs(property));

            if (PropertyChangingWithValue != null)
                PropertyChangingWithValue(this, new PropertyChangeWithValueEventArgs(property, oldValue, newValue));
        }

        public virtual void NotifyPropertyChanged(string property, object oldValue, object newValue)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));

            if (PropertyChangedWithValue != null)
                PropertyChangedWithValue(this, new PropertyChangeWithValueEventArgs(property, oldValue, newValue));
        }

        #endregion

        #region INotifyPropertyChang* Members

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangeWithValueEventHandler PropertyChangedWithValue;
        public event PropertyChangeWithValueEventHandler PropertyChangingWithValue;

        #endregion

        public void ApplyChangesFrom(ICompoundObject other)
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture(typeof(MinimalCompoundObjectTest))]
    public class should_work_with_ICompoundObjects<T> : AbstractTestFixture
        where T : class, ICompoundObject, new()
    {
        MemoryStream ms;
        BinaryWriter sw;
        BinaryReader sr;

        T test;

        public override void SetUp()
        {
            base.SetUp();

            ms = new MemoryStream();
            sw = new BinaryWriter(ms);
            sr = new BinaryReader(ms);

            test = new T();
        }

        /// <summary>
        /// Rewinds all streams to their start
        /// </summary>
        private void RewindStreams()
        {
            ms.Seek(0, SeekOrigin.Begin);
        }

        [Test]
        public void when_serializing()
        {
            BinarySerializer.ToStream(test, sw);
        }

        [Test]
        public void when_deserializing()
        {
            BinarySerializer.ToStream(test, sw);

            RewindStreams();

            Assert.DoesNotThrow(() =>
            {
                BinarySerializer.FromStream(out test, sr);
            });
        }
    }
}