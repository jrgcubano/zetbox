using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Globalization;

namespace Kistl.API.Server
{
    /// <summary>
    /// Abstract Base Class for a PersistenceObject on the Server Side
    /// </summary>
    public abstract class BaseServerPersistenceObject : System.Data.Objects.DataClasses.EntityObject, IPersistenceObject
    {
        /// <summary>
        /// Everyone has an ID
        /// </summary>
        public abstract int ID { get; set; }

        private DataObjectState _ObjectState = DataObjectState.Unmodified;

        /// <summary>
        /// Current ObjectState. Getter calculates the State, Setter is used by the Serializer.
        /// </summary>
        public DataObjectState ObjectState
        {
            get
            {
                // Calc Objectstate
                if (_ObjectState != DataObjectState.Deleted)
                {
                    if (ID <= API.Helper.INVALIDID)
                    {
                        _ObjectState = DataObjectState.New;
                    }
                    else if (_ObjectState == DataObjectState.New)
                    {
                        _ObjectState = DataObjectState.Unmodified;
                    }
                }
                return _ObjectState;
            }
            set
            {
                // Objectstate from Serializer oder Methodcall
                _ObjectState = value;
            }
        }

        private IKistlContext _context;
        /// <summary>
        /// Current Context.
        /// </summary>
        public IKistlContext Context { get { return _context; } }

        /// <summary>
        /// Attach this Object to a Context. This Method is called by the Context.
        /// </summary>
        /// <param name="ctx">Context to attach this Object to.</param>
        public virtual void AttachToContext(IKistlContext ctx)
        {
            if (_context != null && _context != ctx) throw new InvalidOperationException("Object cannot be attached to a new Context while attached to another Context.");
            _context = ctx;
        }

        /// <summary>
        /// Detach this Object from a Context. This Method is called by the Context.
        /// </summary>
        /// <param name="ctx">Context to detach this Object from.</param>
        public virtual void DetachFromContext(IKistlContext ctx)
        {
            if (_context != ctx) throw new InvalidOperationException("Object is not attached to the given context.");
            _context = null;
        }

        /// <summary>
        /// Abstract Method for Serializing this Object.
        /// </summary>
        /// <param name="sw">Stream to serialize to</param>
        public abstract void ToStream(System.IO.BinaryWriter sw);
        /// <summary>
        /// Abstract Method for Deserializing this Object.
        /// </summary>
        /// <param name="sr">Stream to serialize from</param>
        public abstract void FromStream(System.IO.BinaryReader sr);

        /// <summary>
        /// Notifies that a Property is changing
        /// </summary>
        /// <param name="property">Property that is changing or empty, if the Object is changing</param>
        public abstract void NotifyPropertyChanging(string property);
        /// <summary>
        /// Notifies that a Property has changed
        /// </summary>
        /// <param name="property">Property that has changed or empty, if the Object has changed</param>
        public abstract void NotifyPropertyChanged(string property);
    }

    /// <summary>
    /// Abstract Base Class for Server Objects
    /// </summary>
    public abstract class BaseServerDataObject : BaseServerPersistenceObject, IDataObject, ICloneable
    {
        /// <summary>
        /// Attach to Events
        /// </summary>
        protected BaseServerDataObject()
        {
            API.CustomActionsManagerFactory.Current.AttachEvents(this);
        }


        /// <summary>
        /// Fires an Event before an Object is saved.
        /// </summary>
        public virtual void NotifyPreSave() { }
        /// <summary>
        /// Fires an Event after an Object is saved.
        /// </summary>
        public virtual void NotifyPostSave() { }

        /// <summary>
        /// Not implemented yet.
        /// </summary>
        public virtual void NotifyChange()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fires an Event before an Property is changed.
        /// </summary>
        /// <param name="property">Propertyname</param>
        public override void NotifyPropertyChanging(string property)
        {
            base.ReportPropertyChanging(property);
        }

        /// <summary>
        /// Fires an Event after an Property is changed.
        /// </summary>
        /// <param name="property">Propertyname</param>
        public override void NotifyPropertyChanged(string property)
        {
            base.ReportPropertyChanged(property);
        }

        /// <summary>
        /// Copies the current content to a other Object. Used by clone.
        /// </summary>
        /// <param name="target">Object to copy Content to.</param>
        public virtual void CopyTo(IDataObject target)
        {
            if (target == null) throw new ArgumentNullException("target");
            target.ID = this.ID;
        }

        /// <summary>
        /// Clones this Object
        /// </summary>
        /// <returns>A new Object.</returns>
        public virtual object Clone()
        {
            return null;
        }

        /// <summary>
        /// Serialize this Object to a BinaryWriter
        /// </summary>
        /// <param name="sw">BinaryWriter to serialize to</param>
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            if (sw == null) throw new ArgumentNullException("sw");

            BinarySerializer.ToBinary(new SerializableType(this.GetType()), sw);
            BinarySerializer.ToBinary(ID, sw);
            BinarySerializer.ToBinary((int)ObjectState, sw);
        }

        /// <summary>
        /// Deserialize this Object from a BinaryReader
        /// </summary>
        /// <param name="sr">BinaryReader to deserialize to.</param>
        public override void FromStream(System.IO.BinaryReader sr)
        {
            if (sr == null) throw new ArgumentNullException("sr");

            SerializableType t;
            BinarySerializer.FromBinary(out t, sr);

            if (this.GetType() != t.GetSerializedType())
                throw new InvalidOperationException(string.Format("Unable to deserialize Object of Type {0} from Type {1}", GetType(), t));

            int tmp;
            BinarySerializer.FromBinary(out tmp, sr);
            ID = tmp;

            BinarySerializer.FromBinary(out tmp, sr);
            ObjectState = (DataObjectState)tmp;
        }
    }

    /// <summary>
    /// Server Collection Entry Implementation. A Collection Entry is a "connection" Object between other Data Objects 
    /// (ObjectReferenceProperty, IsList=true) or just a simple Collection (eg. StringProperty, IsList=true).
    /// </summary>
    public abstract class BaseServerCollectionEntry : BaseServerPersistenceObject, ICollectionEntry, ICloneable
    {
        /// <summary>
        /// Serialize this Object to a BinaryWriter
        /// </summary>
        /// <param name="sw">BinaryWriter to serialize to</param>
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            if (sw == null) throw new ArgumentNullException("sw", "No BinaryWriter specified");
            BinarySerializer.ToBinary(ID, sw);
            BinarySerializer.ToBinary((int)ObjectState, sw);
        }

        /// <summary>
        /// Deserialize this Object from a BinaryReader
        /// </summary>
        /// <param name="sr">BinaryReader to deserialize to.</param>
        public override void FromStream(System.IO.BinaryReader sr)
        {
            if (sr == null) throw new ArgumentNullException("sr");

            int tmp;
            BinarySerializer.FromBinary(out tmp, sr);
            ID = tmp;

            BinarySerializer.FromBinary(out tmp, sr);
            ObjectState = (DataObjectState)tmp;
        }

        /// <summary>
        /// Clones this Object
        /// </summary>
        /// <returns>A new Object.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Copies the current content to a other Object. Used by clone.
        /// </summary>
        /// <param name="obj">Object to copy Content to.</param>
        public virtual void CopyTo(ICollectionEntry obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            NotifyPropertyChanging("ID");
            obj.ID = this.ID;
            NotifyPropertyChanged("ID");
        }

        /// <summary>
        /// Fires an Event before an Property is changed.
        /// </summary>
        /// <param name="property">Propertyname</param>
        public override void NotifyPropertyChanging(string property)
        {
            base.ReportPropertyChanging(property);
        }

        /// <summary>
        /// Fires an Event after an Property is changed.
        /// </summary>
        /// <param name="property">Propertyname</param>
        public override void NotifyPropertyChanged(string property)
        {
            base.ReportPropertyChanged(property);
        }
    }
}
