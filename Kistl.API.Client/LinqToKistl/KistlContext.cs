using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Kistl.API.Client.LinqToKistl;

namespace Kistl.API.Client
{
    /// <summary>
    /// Linq to Kistl Context Factory
    /// </summary>
    public static class KistlContext
    {
        /// <summary>
        /// Returns a new KistContext.
        /// </summary>
        /// <returns>A new KistlContext</returns>
        public static IKistlContext GetContext()
        {
            return new KistlContextImpl();
        }
    }

    /// <summary>
    /// Linq to Kistl Context Implementation
    /// </summary>
    internal class KistlContextImpl : IDebuggingKistlContext, IDisposable
    {
        public KistlContextImpl()
        {
            CreatedAt = new StackTrace(true);
            KistlContextDebugger.Created(this);
            _relationshipManager = new RelationshipManager(this);
        }

        private LinqToKistl.RelationshipManager _relationshipManager;

        private bool disposed = false;
        /// <summary>
        /// Dispose this Context.
        /// </summary>
        public void Dispose()
        {
            lock (this)
            {
                if (!disposed)
                {
                    DisposedAt = new StackTrace(true);
                    KistlContextDebugger.Disposed(this);
                }
                disposed = true;
            }
            // TODO: use correct Dispose implementation pattern
            GC.SuppressFinalize(this);
        }

        public bool IsDisposed
        {
            get
            {
                return disposed;
            }
        }

        public bool IsReadonly { get { return false; } }

        /// <summary>
        /// Throws an Exception when this Context has been disposed
        /// </summary>
        private void CheckDisposed()
        {
            if (disposed)
            {
                throw new KistlContextDisposedExeption();
            }
        }

        /// <summary>
        /// List of Objects (IDataObject and ICollectionEntry) in this Context.
        /// </summary>
        private ContextCache _objects = new ContextCache();

        /// <summary>
        /// Counter for newly created Objects to give them a valid ID
        /// </summary>
        private int _newIDCounter = Helper.INVALIDID;

        /// <summary>
        /// Checks if the given Object is already in that Context.
        /// </summary>
        /// <param name="type">Type of Object</param>
        /// <param name="ID">ID</param>
        /// <returns>If ID is InvalidID (Object is not inititalized) then an Exception will be thrown.
        /// If the Object is already in that Context, the Object Instace is returned.
        /// If the Object is not in that Context, null is returned.</returns>
        public IPersistenceObject ContainsObject(InterfaceType type, int ID)
        {
            if (ID == Helper.INVALIDID) throw new ArgumentException("ID cannot be invalid", "ID");
            return _objects.Lookup(type, ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [System.Diagnostics.DebuggerDisplay("Count = {_objects.Count}")]
        public IEnumerable<IPersistenceObject> AttachedObjects
        {
            get
            {
                return _objects;
            }
        }

        /// <summary>
        /// Returns a Query by System.Type
        /// </summary>
        /// <param name="ifType">System.Type</param>
        /// <returns>IQueryable</returns>
        public IQueryable<IDataObject> GetQuery(InterfaceType ifType)
        {
            CheckDisposed();
            return new KistlContextQuery<IDataObject>(this, ifType);
        }

        /// <summary>
        /// Returns a Query by T
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>IQueryable</returns>
        public IQueryable<T> GetQuery<T>() where T : class, IDataObject
        {
            CheckDisposed();
            return new KistlContextQuery<T>(this, new InterfaceType(typeof(T)));
        }

        /// <summary>
        /// Returns the List referenced by the given PropertyName.
        /// </summary>
        /// <typeparam name="T">List Type of the ObjectReferenceProperty</typeparam>
        /// <param name="obj">Object which holds the ObjectReferenceProperty</param>
        /// <param name="propertyName">Propertyname which holds the ObjectReferenceProperty</param>
        /// <returns>A List of Objects</returns>
        public List<T> GetListOf<T>(IDataObject obj, string propertyName) where T : class, IDataObject
        {
            CheckDisposed();
            return this.GetListOf<T>(obj.GetInterfaceType(), obj.ID, propertyName);
        }

        /// <summary>
        /// Returns the List referenced by the given Type, ID and PropertyName.
        /// </summary>
        /// <typeparam name="T">List Type of the ObjectReferenceProperty</typeparam>
        /// <param name="type">Type of the Object which holds the ObjectReferenceProperty</param>
        /// <param name="ID">ID of the Object which holds the ObjectReferenceProperty</param>
        /// <param name="propertyName">Propertyname which holds the ObjectReferenceProperty</param>
        /// <returns>A List of Objects</returns>
        public List<T> GetListOf<T>(InterfaceType type, int ID, string propertyName) where T : class, IDataObject
        {
            CheckDisposed();
            KistlContextQuery<T> query = new KistlContextQuery<T>(this, type);
            return ((KistlContextProvider)query.Provider).GetListOf(ID, propertyName).Cast<T>().ToList();
        }

        internal IList<ICollectionEntry> FetchRelation(ImplementationType imType, int relationId, RelationEndRole role, IDataObject container)
        {
            object result = this.GetType().FindGenericMethod("FetchRelation", new Type[] { imType.Type }, new Type[] { typeof(int), typeof(RelationEndRole), typeof(IDataObject) })
                .Invoke(this, new object[] { relationId, role, container });
            return Kistl.API.Utils.MagicCollectionFactory.WrapAsList<ICollectionEntry>(result);
        }

        public IList<T> FetchRelation<T>(int relationId, RelationEndRole role, IDataObject container) where T : class, ICollectionEntry
        {
            var key = new RelationContentKey(relationId, role, container.ID);
            if (_relationshipManager.FetchRelationCache.ContainsKey(key))
            {
                return (List<T>)_relationshipManager.FetchRelationCache[key];
            }
            else
            {
                var serverList = Proxy.Current.FetchRelation<T>(relationId, role, container);
                var result = new List<T>();
                foreach (IPersistenceObject obj in serverList)
                {
                    var localobj = this.Attach(obj);
                    _relationshipManager.ManageRelationsip((ICollectionEntry)localobj);
                    result.Add((T)localobj);
                }
                _relationshipManager.FetchRelationCache[key] = result;
                return result;
            }
        }

        /// <summary>
        /// Creates a new IDataObject.
        /// </summary>
        /// <typeparam name="T">Type of the new IDataObject</typeparam>
        /// <returns>A new IDataObject</returns>
        public T Create<T>() where T : class, IDataObject
        {
            return (T)Create(new InterfaceType(typeof(T)));
        }

        /// <summary>
        /// Creates a new IDataObject by System.Type. Note - this Method is depricated!
        /// </summary>
        /// <param name="ifType">System.Type of the new IDataObject</param>
        /// <returns>A new IDataObject</returns>
        public IDataObject Create(InterfaceType ifType)
        {
            return (IDataObject)CreateInternal(ifType);
        }

        /// <summary>
        /// Creates a new ICollectionEntry by Type
        /// </summary>
        /// <param name="type">Type of the new ICollectionEntry</param>
        /// <returns>A new ICollectionEntry</returns>
        public T CreateCollectionEntry<T>() where T : ICollectionEntry
        {
            return (T)CreateCollectionEntry(new InterfaceType(typeof(T)));
        }

        /// <summary>
        /// Creates a new ICollectionEntry.
        /// </summary>
        /// <typeparam name="T">Type of the new ICollectionEntry</typeparam>
        /// <returns>A new ICollectionEntry</returns>
        public ICollectionEntry CreateCollectionEntry(InterfaceType ifType)
        {
            return (ICollectionEntry)CreateInternal(ifType);
        }

        private IPersistenceObject CreateInternal(InterfaceType ifType)
        {
            CheckDisposed();
            IPersistenceObject obj = (IPersistenceObject)Activator.CreateInstance(ifType.ToImplementationType().Type);
            Attach(obj);
            if (obj is ICollectionEntry)
            {
                _relationshipManager.ManageRelationsip((ICollectionEntry)obj);
            }
            OnObjectCreated(obj);
            return obj;
        }


        /// <summary>
        /// Creates a new Struct by Type
        /// </summary>
        /// <param name="ifType">Type of the new IDataObject</param>
        /// <returns>A new Struct</returns>
        public IStruct CreateStruct(InterfaceType ifType)
        {
            CheckDisposed();
            IStruct obj = (IStruct)Activator.CreateInstance(ifType.ToImplementationType().Type);
            return obj;
        }
        /// <summary>
        /// Creates a new Struct.
        /// </summary>
        /// <typeparam name="T">Type of the new Struct</typeparam>
        /// <returns>A new Struct</returns>
        public T CreateStruct<T>() where T : IStruct
        {
            return (T)CreateStruct(new InterfaceType(typeof(T)));
        }


        /// <summary>
        /// Attach an IPersistenceObject. This Method checks, if the Object is already in that Context. 
        /// If so, it returns the Object in that Context.
        /// </summary>
        /// <param name="obj">IDataObject</param>
        /// <returns>The Object in already Context or obj if not</returns>
        public IPersistenceObject Attach(IPersistenceObject obj)
        {
            CheckDisposed();
            if (obj == null) throw new ArgumentNullException("obj");

            // Handle created Objects
            if (obj.ID == Helper.INVALIDID)
            {
                // TODO: security: check for overflow
                ((BaseClientPersistenceObject)obj).ID = --_newIDCounter;
            }
            else
            {
                // Check if Object is already in this Context
                var attachedObj = ContainsObject(obj.GetInterfaceType(), obj.ID);
                if (attachedObj != null)
                {
                    // already attached, nothing to do
                    return attachedObj;
                }

                // Check ID <-> newIDCounter
                if (obj.ID < _newIDCounter)
                {
                    _newIDCounter = obj.ID;
                }
            }

            // Attach & set Objectstate to Unmodified
            _objects.Add(obj);
            ((BaseClientPersistenceObject)obj).SetUnmodified();

            // Call Objects Attach Method to ensure, that every Child Object is also attached
            obj.AttachToContext(this);

            // update the debugger last 
            KistlContextDebugger.Changed(this);

            return obj;
        }

        /// <summary>
        /// Detach an IPersistenceObject.
        /// </summary>
        /// <param name="obj">IDataObject</param>
        public void Detach(IPersistenceObject obj)
        {
            CheckDisposed();
            if (obj == null) throw new ArgumentNullException("obj");
            if (!_objects.Contains(obj)) throw new InvalidOperationException("This Object does not belong to this context");

            _objects.Remove(obj);
            obj.DetachFromContext(this);
            KistlContextDebugger.Changed(this);
        }

        /// <summary>
        /// Delete an IPersistenceObject.
        /// </summary>
        /// <param name="obj">IPersistenceObject</param>
        public void Delete(IPersistenceObject obj)
        {
            CheckDisposed();
            if (obj == null) throw new ArgumentNullException("obj");
            if (obj.Context != this) throw new InvalidOperationException("The Object does not belong to the current Context");
            ((BaseClientPersistenceObject)obj).SetDeleted();
            OnObjectDeleted(obj);
        }

        /// <summary>
        /// Submits the changes and returns the number of affected Objects. Note: only IDataObjects are counted.
        /// </summary>
        /// <returns>Number of affected Objects</returns>
        public int SubmitChanges()
        {
            CheckDisposed();
            // TODO: Add a better Cache Refresh Strategie
            // CacheController<IDataObject>.Current.Clear();

            var objectsToSubmit = new List<BaseClientPersistenceObject>();
            var objectsToAdd = new List<BaseClientPersistenceObject>();
            var objectsToDetach = new List<BaseClientPersistenceObject>();

            // Added Objects
            foreach (var obj in _objects.OfType<BaseClientPersistenceObject>()
                .Where(o => o.ObjectState == DataObjectState.New))
            {
                objectsToSubmit.Add(obj);
                objectsToAdd.Add(obj);
            }
            // Changed objects
            foreach (var obj in _objects.OfType<BaseClientPersistenceObject>()
                .Where(o => o.ObjectState == DataObjectState.Modified))
            {
                objectsToSubmit.Add(obj);
            }
            // Deleted Objects
            foreach (var obj in _objects.OfType<BaseClientPersistenceObject>()
                .Where(o => o.ObjectState == DataObjectState.Deleted))
            {
                // Submit only persisted objects
                if (Helper.IsPersistedObject(obj))
                {
                    objectsToSubmit.Add(obj);
                }
                objectsToDetach.Add(obj);
            }

            // Submit to server
            var newObjects = Proxy.Current.SetObjects(objectsToSubmit.Cast<IPersistenceObject>());

            // Apply Changes
            int counter = 0;
            var changedObjects = new List<BaseClientPersistenceObject>();
            foreach (BaseClientPersistenceObject newobj in newObjects)
            {
                BaseClientPersistenceObject obj;

                if (counter < objectsToAdd.Count)
                {
                    obj = objectsToAdd[counter++];
                }
                else
                {
                    obj = (BaseClientPersistenceObject)this.ContainsObject(newobj.GetInterfaceType(), newobj.ID) ?? newobj;
                }

                obj.RecordNotifications();
                if (obj != newobj)
                {
                    obj.ApplyChangesFrom(newobj);
                }

                // reset ObjectState to new truth
                obj.SetUnmodified();

                changedObjects.Add(obj);
            }

            objectsToDetach.ForEach(obj => this.Detach(obj));
            changedObjects.ForEach(obj => this.Attach(obj));

            changedObjects.ForEach(obj => obj.PlaybackNotifications());

            return objectsToSubmit.Count;
        }

        /// <summary>
        /// Find the Object of the given type by ID
        /// TODO: This is quite redundant here as it only uses other IKistlContext Methods.
        /// This could be moved to a common abstract IKistlContextBase
        /// </summary>
        /// <param name="type">Object Type of the Object to find.</param>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        public IDataObject Find(InterfaceType ifType, int ID)
        {
            // TODO: check "type" for being a IDataObject
            CheckDisposed();

            // TODO: should be able to pass "type" unmodified, like this
            // See Case 552
            //return GetQuery(type).Single(o => o.ID == ID);

            return (IDataObject)this.GetType().FindGenericMethod("Find", 
                new Type[] { ifType.Type }, 
                new Type[] { typeof(int) })
                .Invoke(this, new object[] { ID });
        }

        /// <summary>
        /// Find the Object of the given type by ID
        /// TODO: This is quite redundant here as it only uses other IKistlContext Methods.
        /// This could be moved to a common abstract IKistlContextBase
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        public T Find<T>(int ID)
            where T : class, IDataObject
        {
            CheckDisposed();
            IPersistenceObject cacheHit = _objects.Lookup(new InterfaceType(typeof(T)), ID);
            if (cacheHit != null)
                return (T)cacheHit;
            else
                return GetQuery<T>().Single(o => o.ID == ID);
        }

        /// <summary>
        /// Find the Persistence Object of the given type by ID
        /// </summary>
        /// <param name="ifType">Object Type of the Object to find.</param>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public IPersistenceObject FindPersistenceObject(InterfaceType ifType, int ID)
        {
            // TODO: check "type" for being a IDataObject
            CheckDisposed();

            // TODO: should be able to pass "type" unmodified, like this
            // See Case 552
            //return GetQuery(type).Single(o => o.ID == ID);

            return (IPersistenceObject)this.GetType().FindGenericMethod("FindPersistenceObject",
                new Type[] { ifType.Type },
                new Type[] { typeof(int) })
                .Invoke(this, new object[] { ID });
        }

        /// <summary>
        /// Find the Persistence Object of the given type by ID.
        /// Note: This method is not supported on the client
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public T FindPersistenceObject<T>(int ID) where T : class, IPersistenceObject
        {
            throw new NotSupportedException();
        }


        public event GenericEventHandler<IPersistenceObject> ObjectCreated;

        protected virtual void OnObjectCreated(IPersistenceObject obj)
        {
            if (ObjectCreated != null)
            {
                ObjectCreated(this, new GenericEventArgs<IPersistenceObject>() { Data = obj });
            }
        }

        public event GenericEventHandler<IPersistenceObject> ObjectDeleted;

        protected virtual void OnObjectDeleted(IPersistenceObject obj)
        {
            if (ObjectDeleted != null)
            {
                ObjectDeleted(this, new GenericEventArgs<IPersistenceObject>() { Data = obj });
            }
        }

        public IKistlContext GetReadonlyContext()
        {
            // TODO: actually create a ThreadStatic read-only variant of this to allow for a common cache
            // return this;
            return FrozenContext.Single;
        }

        #region IDebuggingKistlContext Members

        public StackTrace CreatedAt { get; private set; }

        public StackTrace DisposedAt { get; private set; }

        #endregion
    }

    /// <summary>
    /// Store IPersistenceObjects ordered by (root-)Type and ID for fast access within the KistlContextImpl
    /// </summary>
    internal class ContextCache : ICollection<IPersistenceObject>
    {

        private IDictionary<Type, IDictionary<int, IPersistenceObject>> _objects = new Dictionary<Type, IDictionary<int, IPersistenceObject>>();

        /// <summary>
        /// Returns the root implementation Type of a given IPersistenceObject.
        /// This corresponds to the ID namespace of the object
        /// </summary>
        /// <param name="obj">IPersistenceObject to inspect</param>
        /// <returns>Root Type of the given Type</returns>
        private static Type GetRootImplType(IPersistenceObject obj)
        {
            return GetRootImplType(obj.GetInterfaceType().ToImplementationType());
        }

        /// <summary>
        /// Returns the root implementation Type of a given System.Type.
        /// This corresponds to the ID namespace of the object
        /// </summary>
        /// <param name="t">Type to inspect</param>
        /// <returns>Root Type of the given Type</returns>
        private static Type GetRootImplType(ImplementationType t)
        {
            Type result = t.Type;
            // TODO: Make this better - asking for BaseTypes is not elegant
            while (result != null && result.BaseType != typeof(BaseClientDataObject) && result.BaseType != typeof(BaseClientCollectionEntry))
            {
                result = result.BaseType;
            }

            return result;
        }

        public IPersistenceObject Lookup(InterfaceType t, int id)
        {
            Type rootT = GetRootImplType(t.ToImplementationType());

            if (!_objects.ContainsKey(rootT))
                return null;

            IDictionary<int, IPersistenceObject> typeList = _objects[rootT];
            if (!typeList.ContainsKey(id))
                return null;

            return typeList[id];
        }

        #region ICollection<IPersistenceObject> Members

        public void Add(IPersistenceObject item)
        {
            Type rootT = GetRootImplType(item);

            // create per-Type dictionary on-demand
            if (!_objects.ContainsKey(rootT))
                _objects[rootT] = new Dictionary<int, IPersistenceObject>();

            _objects[rootT][item.ID] = item;
        }

        public void Clear()
        {
            _objects.Clear();
        }

        public bool Contains(IPersistenceObject item)
        {
            Type rootT = GetRootImplType(item);
            return _objects.ContainsKey(rootT) && _objects[rootT].ContainsKey(item.ID);
        }

        public void CopyTo(IPersistenceObject[] array, int arrayIndex)
        {
            foreach (IPersistenceObject item in this)
            {
                array[arrayIndex++] = item;
            }
        }

        public int Count
        {
            get { return _objects.Values.Sum(list => list.Count); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(IPersistenceObject item)
        {
            if (Contains(item))
                // should always return true
                return _objects[GetRootImplType(item)].Remove(item.ID);
            else
                return false;
        }

        #endregion

        #region IEnumerable<IPersistenceObject> Members

        public IEnumerator<IPersistenceObject> GetEnumerator()
        {
            foreach (var typeList in _objects.Values)
            {
                foreach (IPersistenceObject obj in typeList.Values)
                {
                    yield return obj;
                }
            }
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            // reuse strongly typed enumerator
            return GetEnumerator();
        }

        #endregion

    }

}
