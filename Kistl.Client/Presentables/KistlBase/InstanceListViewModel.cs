
namespace Kistl.Client.Presentables.KistlBase
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Linq.Dynamic;
    using System.Text;
    using ObjectEditorWorkspace = Kistl.Client.Presentables.ObjectEditor.WorkspaceViewModel;

    using Kistl.API;
    using Kistl.API.Client;
    using Kistl.App.Base;
    using Kistl.API.Configuration;
    using System.Reflection;

    /// <summary>
    /// Models the specialities of <see cref="DataType"/>s.
    /// </summary>
    [ViewModelDescriptor("KistlBase", DefaultKind = "Kistl.App.GUI.InstanceListKind", Description = "DataObjectModel with specific extensions for DataTypes")]
    public class InstanceListViewModel
        : ViewModel, IViewModelWithIcon, IRefreshCommandListener
    {
        public new delegate InstanceListViewModel Factory(IKistlContext dataCtx, DataType type, IQueryable qry);

        protected readonly Func<IKistlContext> ctxFactory;

        /// <summary>
        /// Initializes a new instance of the DataTypeModel class.
        /// </summary>
        /// <param name="appCtx">the application context to use</param>
        /// <param name="config"></param>
        /// <param name="dataCtx">the data context to use</param>
        /// <param name="type">optional: the data type to model. If null, qry must be a Query of a valid DataType</param>
        /// <param name="qry">optional: the query to display. If null, Query will be constructed from type</param>
        /// <param name="ctxFactory"></param>
        public InstanceListViewModel(
            IViewModelDependencies appCtx,
            KistlConfig config,
            IKistlContext dataCtx,
            DataType type,
            IQueryable qry,
            Func<IKistlContext> ctxFactory)
            : base(appCtx, dataCtx)
        {
            if (dataCtx == null) throw new ArgumentNullException("dataCtx");
            if (qry == null && type == null) throw new ArgumentException("qry and type may not be null");

            if (type != null)
            {
                _type = type;
            }
            else
            {
                this._type = FrozenContext.GetQuery<DataType>().SingleOrDefault(dt => dt.GetDataType() == qry.ElementType);
                if (_type == null) throw new ArgumentException("Cannot resolve type from Query");
            }
            if (qry == null)
            {
                MethodInfo mi = this.GetType().FindGenericMethod("GetTypedQuery", new Type[] { DataContext.GetInterfaceType(_type.GetDataType()).Type }, null);
                // See Case 552
                _query = (IQueryable)mi.Invoke(this, new object[] { });
            }
            else
            {
                _query = qry;
            }

            this.ctxFactory = ctxFactory;
        }

        public IQueryable GetTypedQuery<T>() where T : class, IDataObject
        {
            return DataContext.GetQuery<T>();
        }

        #region Public interface
        private ObservableCollection<IFilterExpression> _filter = null;
        public ICollection<IFilterExpression> Filter
        {
            get
            {
                if (_filter == null)
                {
                    _filter = new ObservableCollection<IFilterExpression>();
                    // React on changes -> attach to FilterChanged Event
                    _filter.CollectionChanged += new NotifyCollectionChangedEventHandler(_filter_CollectionChanged);

                    // Resolve default property filter
                    var t = _type;
                    while (t != null)
                    {
                        // Add Property filter expressions
                        foreach (var prop in t.Properties.Where(p => p.FilterConfiguration != null))
                        {
                            var cfg = prop.FilterConfiguration;
                            _filter.Add(ModelFactory.CreateViewModel<PropertyFilterExpressionFactory>(cfg.ViewModelDescriptor.ViewModelRef.AsType(true)).Invoke(DataContext, prop, cfg));
                        }
                        if(t is ObjectClass)
                        {
                            t = ((ObjectClass)t).BaseObjectClass;
                        }
                    }

                    // Add default ToString Filter for all
                    _filter.Add(ModelFactory.CreateViewModel<ToStringFilterExpression.Factory>().Invoke(DataContext, "Name"));
                }
                return _filter;
            }
        }

        void _filter_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems.OfType<IUIFilterExpression>())
            {
                // attach change events
                item.FilterChanged += new EventHandler(delegate(object s, EventArgs a) {
                    if (s is IPostFilterExpression)
                    {
                        ExecutePostFilter();
                    }
                    else
                    {
                        ReloadInstances();
                    }
                });
            }

            OnPropertyChanged("FilterViewModels");
        }

        public IEnumerable<IUIFilterExpression> FilterViewModels
        {
            get
            {
                return Filter.OfType<IUIFilterExpression>();
            }
        }

        private ObservableCollection<ICommand> _commands = null;
        public ICollection<ICommand> Commands
        {
            get
            {
                if (_commands == null)
                {
                    _commands = new ObservableCollection<ICommand>();
                    // Add default actions
                    _commands.Add(ModelFactory.CreateViewModel<NewDataObjectCommand.Factory>().Invoke(DataContext, _type));
                    _commands.Add(ModelFactory.CreateViewModel<OpenDataObjectCommand.Factory>().Invoke(DataContext));
                    _commands.Add(ModelFactory.CreateViewModel<RefreshCommand.Factory>().Invoke(DataContext, this));
                }
                return _commands;
            }
        }

        private Kistl.Client.Presentables.DataTypeModel _dataTypeMdl = null;
        public Kistl.Client.Presentables.DataTypeModel DataTypeModel
        {
            get
            {
                if (_dataTypeMdl == null)
                {
                    _dataTypeMdl = ModelFactory.CreateViewModel<DataTypeModel.Factory>(_type).Invoke(DataContext, _type);
                }
                return _dataTypeMdl;
            }
        }

        // TODO: make readonly, take care of new and deleted+submitted objects
        private ObservableCollection<DataObjectModel> _instances = null;
        public ObservableCollection<DataObjectModel> Instances
        {
            get
            {
                if (_instances == null)
                {
                    _instances = new ObservableCollection<DataObjectModel>();

                    // As this is a "calculated" collection, only insider should modify this
                    ////_instances.CollectionChanged += _instances_CollectionChanged;
                    LoadInstances();
                }
                return _instances;
            }
        }

        private ReadOnlyObservableCollection<DataObjectModel> _instancesFiltered = null;
        public ReadOnlyObservableCollection<DataObjectModel> InstancesFiltered
        {
            get
            {
                if (_instancesFiltered == null)
                {
                    ExecutePostFilter();
                }
                return _instancesFiltered;
            }
        }

        private ObservableCollection<DataObjectModel> _selectedItems = null;
        public ObservableCollection<DataObjectModel> SelectedItems
        {
            get
            {
                if (_selectedItems == null)
                {
                    _selectedItems = new ObservableCollection<DataObjectModel>();
                }
                return _selectedItems;
            }
            set
            {
                _selectedItems = value;
                OnPropertyChanged("SelectedItems");
            }
        }
        /// <summary>
        /// Reload instances from context.
        /// </summary>
        public void ReloadInstances()
        {
            if (_instances != null)
            {
                _instances.Clear();
                LoadInstances();
                ExecutePostFilter();
            }
        }

        public InterfaceType InterfaceType
        {
            get
            {
                return DataContext.GetInterfaceType(_type.GetDataType());
            }
        }

        public void OpenObjects(IEnumerable<DataObjectModel> objects)
        {
            if (objects == null) throw new ArgumentNullException("objects");

            var newWorkspace = ModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(ctxFactory());
            foreach (var item in objects)
            {
                newWorkspace.ShowForeignModel(item);
            }
            ModelFactory.ShowModel(newWorkspace, true);
        }

        public delegate void ItemsDefaultActionHandler(IEnumerable<DataObjectModel> objects);
        public event ItemsDefaultActionHandler ItemsDefaultAction = null;

        public void OnItemsDefaultAction(IEnumerable<DataObjectModel> objects)
        {
            ItemsDefaultActionHandler temp = ItemsDefaultAction;
            if (temp != null)
            {
                temp(objects);
            }
            else
            {
                OpenObjects(objects);
            }
        }

        #endregion

        #region Utilities and UI callbacks
        /// <returns>the default icon of this <see cref="DataType"/></returns>
        public Kistl.App.GUI.Icon Icon
        {
            get
            {
                if (_type != null)
                    return _type.DefaultIcon;
                else
                    return null;
            }
        }

        public override string Name
        {
            get
            {
                return _type.Name;
            }
        }

        public override string ToString()
        {
            return Name;
        }


        private IQueryable _query;
        protected virtual IQueryable GetQuery()
        {
            var result = _query;

            foreach (var f in Filter.OfType<ILinqFilterExpression>().Where(f => f.Enabled))
            {
                result = result.Where(f.Predicate, f.FilterValues);
            }

            return result;
        }


        /// <summary>
        /// Loads the instances of this DataType and adds them to the Instances collection
        /// </summary>
        private void LoadInstances()
        {
            // Can execute?
            if (Filter.Count(f => !f.Enabled && f.Requiered) > 0) return;

            foreach (var obj in GetQuery().Cast<IDataObject>().ToList().OrderBy(obj => obj.ToString()))
            {
                _instances.Add(ModelFactory.CreateViewModel<DataObjectModel.Factory>(obj).Invoke(DataContext, obj));
            }
            OnInstancesChanged();
        }

        /// <summary>
        /// Call this when the <see cref="Instances"/> property or its 
        /// contents have changed. Override this to react on changes here.
        /// </summary>
        protected virtual void OnInstancesChanged()
        {
            OnPropertyChanged("Instances");
            ExecutePostFilter();
        }

        /// <summary>
        /// Create a fresh <see cref="InstancesFiltered"/> collection when something has changed.
        /// </summary>
        private void ExecutePostFilter()
        {
            _instancesFiltered = new ReadOnlyObservableCollection<DataObjectModel>(this.Instances);
            // poor man's full text search
            foreach (var filter in Filter.OfType<IPostFilterExpression>())
            {
                if (filter.Enabled)
                {
                    _instancesFiltered = filter.Execute(_instancesFiltered);
                }
            }
            OnPropertyChanged("InstancesFiltered");
        }

        #endregion

        private DataType _type;

        #region IRefreshCommandListener Members

        void IRefreshCommandListener.Refresh()
        {
            ReloadInstances();
        }

        #endregion
    }
}
