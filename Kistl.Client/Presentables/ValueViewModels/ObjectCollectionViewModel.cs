
namespace Kistl.Client.Presentables.ValueViewModels
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Dynamic;
    using System.Text;

    using Kistl.API;
    using Kistl.API.Utils;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Client.Models;

    /// <summary>
    /// </summary>
    public class ObjectCollectionViewModel
        : BaseObjectCollectionViewModel<IReadOnlyObservableList<DataObjectModel>>, IValueCollectionViewModel<DataObjectModel, IReadOnlyObservableList<DataObjectModel>>
    {
        public new delegate ObjectCollectionViewModel Factory(IKistlContext dataCtx, IValueModel mdl);

        public IObjectListValueModel ObjectCollectionModel { get; private set; }

        public ObjectCollectionViewModel(
            IViewModelDependencies appCtx, IKistlContext dataCtx,
            IValueModel mdl)
            : base(appCtx, dataCtx, mdl)
        {
            ObjectCollectionModel = (IObjectListValueModel)mdl;
        }

        #region Public interface and IReadOnlyValueModel<IReadOnlyObservableCollection<DataObjectModel>> Members

        // private ReadOnlyObservableProjectedList<IDataObject, DataObjectModel> _valueCache;
        public override IReadOnlyObservableList<DataObjectModel> Value
        {
            get
            {
                EnsureValueCache();
                return _wrapper;
            }
            set
            {
                throw new NotSupportedException();
            }

        }

        private SortedWrapper _wrapper = null;
        private class SortedWrapper : INotifyCollectionChanged, IList<DataObjectModel>, IReadOnlyObservableList<DataObjectModel>
        {
            private List<DataObjectModel> _sortedList;
            private ICollection<DataObjectModel> _collection;
            private INotifyCollectionChanged _notifier;

            private string _sortProp = "ID";
            private ListSortDirection _direction = ListSortDirection.Ascending;

            public SortedWrapper(IReadOnlyObservableList<DataObjectModel> collection, INotifyCollectionChanged notifier)
            {
                _collection = collection;
                _notifier = notifier;
                notifier.CollectionChanged += new NotifyCollectionChangedEventHandler(notifier_CollectionChanged);
                Sort(_sortProp, _direction);
            }

            public void Sort(string p, ListSortDirection direction)
            {
                _sortProp = p;
                _direction = direction;
                _sortedList = _collection.AsQueryable()
                    .OrderBy(string.Format("it.Object.{0} {1}", _sortProp, _direction == ListSortDirection.Descending ? "desc" : string.Empty))
                    .Cast<DataObjectModel>()
                    .ToList();
                OnCollectionChanged();
            }

            private void OnCollectionChanged()
            {
                var temp = CollectionChanged;
                if (temp != null)
                {
                    temp(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
                }
            }

            void notifier_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                Sort(_sortProp, _direction);
            }

            #region INotifyCollectionChanged Members

            public event NotifyCollectionChangedEventHandler CollectionChanged;

            #endregion

            #region IList<IDataObject> Members

            public int IndexOf(DataObjectModel item)
            {
                return _sortedList.IndexOf(item);
            }

            public void Insert(int index, DataObjectModel item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            public DataObjectModel this[int index]
            {
                get
                {
                    return _sortedList[index];
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            #endregion

            #region ICollection<DataObjectModel> Members

            public void Add(DataObjectModel item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(DataObjectModel item)
            {
                return _sortedList.Contains(item);
            }

            public void CopyTo(DataObjectModel[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public int Count
            {
                get { return _sortedList.Count; }
            }

            public bool IsReadOnly
            {
                get { return true; }
            }

            public bool Remove(DataObjectModel item)
            {
                throw new NotImplementedException();
            }

            #endregion

            #region IEnumerable<IDataObject> Members

            public IEnumerator<DataObjectModel> GetEnumerator()
            {
                return _sortedList.GetEnumerator();
            }

            #endregion

            #region IEnumerable Members

            IEnumerator IEnumerable.GetEnumerator()
            {
                return _sortedList.GetEnumerator();
            }

            #endregion
        }

        private void EnsureValueCache()
        {
            if (_wrapper == null)
            {
                _wrapper = new SortedWrapper(ObjectCollectionModel.Value, ObjectCollectionModel.Value);
                //_valueCache = new ReadOnlyObservableList<DataObjectModel>(
                //    _wrapper,
                //    obj => ModelFactory.CreateViewModel<DataObjectModel.Factory>(obj).Invoke(DataContext, obj),
                //    mdl => mdl.Object);
            }
        }

        public bool HasPersistentOrder
        {
            get
            {
                return false;
            }
        }

        #region Commands

        public override void AddItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            EnsureValueCache();
            // Value.Add(item);
            ObjectCollectionModel.tmpAddItem(item);

            SelectedItem = item;
        }


        public override void RemoveItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            EnsureValueCache();
            Value.Remove(item);
        }

        public override void DeleteItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            EnsureValueCache();
            Value.Remove(item);
            item.Delete();
        }
        #endregion

        #endregion

        public void Sort(string propName, ListSortDirection direction)
        {
            if (string.IsNullOrEmpty(propName)) throw new ArgumentNullException("propName");
            EnsureValueCache();
            _wrapper.Sort(propName, direction);
        }
    }
}
