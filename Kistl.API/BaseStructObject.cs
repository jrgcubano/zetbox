using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Kistl.API
{
    /// <summary>
    /// Implements basic (serialisation) infrastructure of IStruct objects
    /// </summary>
    public abstract class BaseStructObject : BaseNotifyingObject, IStruct
    {

        #region IStruct Members

        public IPersistenceObject ParentObject { get; protected set; }
        public string ParentProperty { get; protected set; }

        public virtual void AttachToObject(IPersistenceObject obj, string property)
        {
            if (ParentObject != null && ParentObject != obj)
                throw new ArgumentException("Struct is already attached to another object", "obj");

            ParentProperty = property;
            ParentObject = obj;
        }

        public virtual void DetachFromObject(IPersistenceObject obj, string property)
        {
            if (ParentObject == null || ParentObject != obj)
                throw new ArgumentException("Struct is not attached to this object", "obj");

            ParentObject = null;
            ParentProperty = null;
        }

        public virtual bool IsReadonly { get { return ParentObject != null ? ParentObject.IsReadonly : false; } }

        #endregion

        #region IStreamable Members

        /// <summary>
        /// Serializes a struct to the specified stream. Since structs have no 
        /// own identity the ParentObject has to be constructed somewhere else 
        /// using external means, e.g. by examining the position in the stream.
        /// </summary>
        /// <param name="sw">the stream to write to</param>
        public virtual void ToStream(BinaryWriter sw)
        {
            if (sw == null)
                throw new ArgumentNullException("sw");

            BinarySerializer.ToStream(new SerializableType(this.GetInterfaceType()), sw);
        }

        /// <summary>
        /// reads a struct from the specified stream. Since structs have no 
        /// own identity the ParentObject has to be constructed somewhere else 
        /// using external means, e.g. by examining the position in the stream.
        /// </summary>
        /// <param name="sr">the stream to read from</param>
        public virtual void FromStream(BinaryReader sr)
        {
            if (sr == null)
                throw new ArgumentNullException("sr");

            SerializableType t;
            BinarySerializer.FromStream(out t, sr);

            if (this.GetInterfaceType() != t.GetSystemType())
                throw new InvalidOperationException(string.Format("Unable to deserialize Object of Type {0} from Type {1}", GetType(), t));
        }

        /// <summary>
        /// Empty implementation, since Structs can't have ObjectReferences
        /// </summary>
        public void ReloadReferences() { }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// By default, this makes a memberwise clone of this object, but detaches it from its parent.
        /// </summary>
        public object Clone()
        {
            var clone = (BaseStructObject)this.MemberwiseClone();
            // detach struct when cloning
            clone.ParentObject = null;
            clone.ParentProperty = null;
            return clone;
        }

        #endregion

        /// <summary>
        /// returns the Kistl.Objects interface type of this struct
        /// </summary>
        /// <returns></returns>
        public abstract InterfaceType GetInterfaceType();

        protected override void SetModified()
        {
            // don't care
        }
    }
}
