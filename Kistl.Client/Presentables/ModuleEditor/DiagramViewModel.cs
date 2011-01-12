using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.App.Base;
using QuickGraph;
using Kistl.API.Configuration;
using Kistl.API.Utils;
using ObjectEditorWorkspace = Kistl.Client.Presentables.ObjectEditor.WorkspaceViewModel;

namespace Kistl.Client.Presentables.ModuleEditor
{
    [CLSCompliant(false)]
    public class DataTypeGraph : BidirectionalGraph<DataTypeGraphModel, IEdge<DataTypeGraphModel>>
    {
        public DataTypeGraph() { }

        public DataTypeGraph(bool allowParallelEdges)
            : base(allowParallelEdges) { }

        public DataTypeGraph(bool allowParallelEdges, int vertexCapacity)
            : base(allowParallelEdges, vertexCapacity) { }
    }

    public class DataTypeGraphModel : Presentables.DataTypeViewModel
    {
#if MONO
        // See https://bugzilla.novell.com/show_bug.cgi?id=660553
        public delegate DataTypeGraphModel Factory(IKistlContext dataCtx, DataType obj, DiagramViewModel parent);
#else
        public new delegate DataTypeGraphModel Factory(IKistlContext dataCtx, DataType obj, DiagramViewModel parent);
#endif

        private DiagramViewModel _diagMdl;
        protected readonly Func<IKistlContext> ctxFactory;

        public DataTypeGraphModel(IViewModelDependencies appCtx, IKistlContext dataCtx,
            DataType obj, DiagramViewModel parent, Func<IKistlContext> ctxFactory)
            : base(appCtx, dataCtx, obj)
        {
            this._diagMdl = parent;
            this.ctxFactory = ctxFactory;
            this.DataType = obj;
        }

        public DataType DataType { get; private set; }

        private bool _isChecked = false;
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                SetChecked(value, true);
            }
        }

        internal void SetChecked(bool chk, bool recreateGraph)
        {
            if (_isChecked != chk)
            {
                _isChecked = chk;
                if (recreateGraph) _diagMdl.RecreateGraph();
                OnPropertyChanged("IsChecked");
            }
        }

        private bool _isGraphChecked = false;
        public bool IsGraphChecked
        {
            get
            {
                return _isGraphChecked;
            }
            set
            {
                if (_isGraphChecked != value)
                {
                    _isGraphChecked = value;
                    OnPropertyChanged("IsGraphChecked");
                }
            }
        }

        private ICommandViewModel _open = null;
        public ICommandViewModel Open
        {
            get
            {
                if (_open == null)
                {
                    _open = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(
                        DataContext, "Open", "Opens the current DataType", () =>
                        {
                            var newWorkspace = ViewModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(ctxFactory());
                            newWorkspace.ShowForeignModel(this);
                            ViewModelFactory.ShowModel(newWorkspace, true);
                        }, null);
                }

                return _open;
            }
        }
    }

    public class DiagramViewModel : ViewModel
    {
#if MONO
        // See https://bugzilla.novell.com/show_bug.cgi?id=660553
        public delegate DiagramViewModel Factory(IKistlContext dataCtx, Module module);
#else
        public new delegate DiagramViewModel Factory(IKistlContext dataCtx, Module module);
#endif

        public DiagramViewModel(IViewModelDependencies appCtx, IKistlContext dataCtx, Module module, Func<IKistlContext> ctxFactory)
            : base(appCtx, dataCtx)
        {
            this.ctxFactory = ctxFactory;
            this.Module = module;
        }

        protected readonly Func<IKistlContext> ctxFactory;
        public Module Module { get; private set; }

        #region GraphSettings
        public enum GraphTypeEnum
        {
            Relation,
            Inheritance,
        }

        private GraphTypeEnum _graphType = GraphTypeEnum.Relation;
        public GraphTypeEnum GraphType
        {
            get
            {
                return _graphType;
            }
            set
            {
                if (_graphType != value)
                {
                    _graphType = value;
                    OnPropertyChanged("GrapType");
                    RecreateGraph();
                }
            }
        }

        public IEnumerable<GraphTypeEnum> GraphTypes
        {
            get
            {
                return new GraphTypeEnum[] { GraphTypeEnum.Relation, GraphTypeEnum.Inheritance };
            }
        }
        #endregion

        #region ViewModel

        public override string Name
        {
            get { return "Class Diagram"; }
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion

        #region DataTypes
        private ReadOnlyProjectedList<DataType, DataTypeGraphModel> _DataTypeViewModels = null;
        public IEnumerable<DataTypeGraphModel> DataTypeViewModels
        {
            get
            {
                if (_DataTypeViewModels == null)
                {
                    _DataTypeViewModels = new ReadOnlyProjectedList<DataType, DataTypeGraphModel>(DataTypes,
                        i => ViewModelFactory.CreateViewModel<DataTypeGraphModel.Factory>().Invoke(DataContext, i, this),
                        i => i.DataType);
                }
                return _DataTypeViewModels;
            }
        }

        private List<DataType> _dataTypes = null;
        private IList<DataType> DataTypes
        {
            get
            {
                if (_dataTypes == null)
                {
                    _dataTypes = DataContext.GetQuery<DataType>().Where(i => i.Module == Module).OrderBy(i => i.Name).ToList();
                }
                return _dataTypes;
            }
        }

        private List<Relation> _relations = null;
        public IEnumerable<Relation> Relations
        {
            get
            {
                if (_relations == null)
                {
                    _relations = DataContext.GetQuery<Relation>().Where(i => i.Module == Module).ToList();
                }
                return _relations;
            }
        }

        private void Refresh()
        {
            _relations = null;
            if (_dataTypes != null)
            {
                var newDataTypes = DataContext.GetQuery<DataType>().Where(i => i.Module == Module).ToList();
                // Add new ones, keep old ones
                _dataTypes.AddRange(newDataTypes.Except(_dataTypes));
                _dataTypes.RemoveAll(dt => !newDataTypes.Contains(dt));
                _dataTypes.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
            OnPropertyChanged("Relations");
            OnPropertyChanged("DataTypes");
            OnPropertyChanged("DataTypeViewModels");
            RecreateGraph();
        }

        public IEnumerable<DataTypeGraphModel> SelectedDataTypeViewModels
        {
            get
            {
                return DataTypeViewModels.Where(i => i.IsChecked);
            }
        }

        public IEnumerable<DataTypeGraphModel> SelectedGraphDataTypeViewModels
        {
            get
            {
                return DataTypeViewModels.Where(i => i.IsGraphChecked);
            }
        }

        private void SelectAllDataTypes()
        {
            DataTypeViewModels.ForEach(i => i.SetChecked(true, false));
            RecreateGraph();
        }

        private void SelectNoDataTypes()
        {
            DataTypeViewModels.ForEach(i => i.SetChecked(false, false));
            RecreateGraph();
        }

        private void AddRelatedDataTypes()
        {
            foreach (var dtm in DataTypeViewModels.Where(i => i.IsChecked).ToList())
            {
                var add = new List<DataTypeGraphModel>();
                if (GraphType == GraphTypeEnum.Inheritance)
                {
                    // Add BaseClass
                    if (dtm.DataType is ObjectClass && ((ObjectClass)dtm.DataType).BaseObjectClass != null)
                    {
                        var item = DataTypeViewModels.FirstOrDefault(i => i.DataType == ((ObjectClass)dtm.DataType).BaseObjectClass);
                        if (item != null) add.Add(item);
                    }

                    // Add Inheritance
                    add.AddRange(DataTypeViewModels.Where(i => i.DataType is ObjectClass && ((ObjectClass)i.DataType).BaseObjectClass == dtm.DataType));

                }
                else if (GraphType == GraphTypeEnum.Relation)
                {
                    foreach (var rel in Relations.Where(i => i.A.Type == dtm.DataType || i.B.Type == dtm.DataType))
                    {
                        var a = DataTypeViewModels.FirstOrDefault(i => i.DataType == rel.A.Type);
                        if (a != null) add.Add(a);
                        var b = DataTypeViewModels.FirstOrDefault(i => i.DataType == rel.B.Type);
                        if (b != null) add.Add(b);
                    }
                }

                // checked = true
                add.ForEach(i => i.SetChecked(true, false));
            }

            RecreateGraph();
        }
        #endregion

        #region Graph
        public class RelationEdge
        {
            public Relation Rel { get; set; }
            public override string ToString()
            {
                return string.Format("{0} {1} {2}", Rel.A.RoleName, Rel.Verb, Rel.B.RoleName);
            }
        }

        public class InheritanceEdge
        {
            public ObjectClass ObjClass { get; set; }
            public override string ToString()
            {
                return string.Format("{0} : {1}", ObjClass.Name, ObjClass.BaseObjectClass.Name);
            }
        }

        private DataTypeGraph CreateGraph()
        {
            var g = new DataTypeGraph(true);

            if (SelectedDataTypeViewModels.Count() == 0)
            {
                return null;
            }

            Dictionary<DataType, DataTypeGraphModel> typeMdlDict = new Dictionary<DataType, DataTypeGraphModel>();
            foreach (var dt in SelectedDataTypeViewModels)
            {
                g.AddVertex(dt);
                typeMdlDict[dt.DataType] = dt;
            }

            if (GraphType == GraphTypeEnum.Relation)
            {
                foreach (var rel in Relations)
                {
                    if (typeMdlDict.ContainsKey(rel.A.Type) && typeMdlDict.ContainsKey(rel.B.Type))
                    {
                        g.AddEdge(new TaggedEdge<DataTypeGraphModel, RelationEdge>(typeMdlDict[rel.A.Type], typeMdlDict[rel.B.Type], new RelationEdge() { Rel = rel }));
                    }
                }
            }
            else if (GraphType == GraphTypeEnum.Inheritance)
            {
                foreach (var cls in SelectedDataTypeViewModels.Select(i => i.DataType).OfType<ObjectClass>())
                {
                    if (cls.BaseObjectClass != null && typeMdlDict.ContainsKey(cls) && typeMdlDict.ContainsKey(cls.BaseObjectClass))
                    {
                        g.AddEdge(new TaggedEdge<DataTypeGraphModel, InheritanceEdge>(typeMdlDict[cls.BaseObjectClass], typeMdlDict[cls], new InheritanceEdge() { ObjClass = cls }));
                    }
                }
            }

            return g;
        }

        internal void RecreateGraph()
        {
            _graph = null;
            OnPropertyChanged("Graph");
        }

        private DataTypeGraph _graph;
        public object Graph
        {
            get
            {
                if (_graph == null)
                {
                    _graph = CreateGraph();
                }
                return _graph;
            }
        }

        #endregion

        #region Commands
        private ICommandViewModel _RefreshCommand = null;
        public ICommandViewModel RefreshCommand
        {
            get
            {
                if (_RefreshCommand == null)
                {
                    _RefreshCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "Refresh", "Refresh the DataTypes list", () => Refresh(), null);
                }
                return _RefreshCommand;
            }
        }

        private ICommandViewModel _selectAllCommand = null;
        public ICommandViewModel SelectAllCommand
        {
            get
            {
                if (_selectAllCommand == null)
                {
                    _selectAllCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "Select all", "Selects all DataTypes", () => SelectAllDataTypes(), null);
                }
                return _selectAllCommand;
            }
        }

        private ICommandViewModel _selectNoneCommand = null;
        public ICommandViewModel SelectNoneCommand
        {
            get
            {
                if (_selectNoneCommand == null)
                {
                    _selectNoneCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "Select None", "Selects no DataTypes", () => SelectNoDataTypes(), null);
                }
                return _selectNoneCommand;
            }
        }

        private ICommandViewModel _addRelatedCommand = null;
        public ICommandViewModel AddRelatedCommand
        {
            get
            {
                if (_addRelatedCommand == null)
                {
                    _addRelatedCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "Add Related", "Add related DataTypes", () => AddRelatedDataTypes(), null);
                }
                return _addRelatedCommand;
            }
        }

        private ICommandViewModel _NewObjectClassCommand = null;
        public ICommandViewModel NewObjectClassCommand
        {
            get
            {
                if (_NewObjectClassCommand == null)
                {
                    _NewObjectClassCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "New Class", "Creates a new Class", () =>
                    {
                        var newCtx = ctxFactory();
                        var newWorkspace = ViewModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(newCtx);
                        var newCls = newCtx.Create<ObjectClass>();

                        newCls.Module = newCtx.Find<Module>(Module.ID);

                        newWorkspace.ShowForeignModel(DataObjectViewModel.Fetch(ViewModelFactory, newCtx, newCls));
                        ViewModelFactory.ShowModel(newWorkspace, true);
                    }, null);
                }
                return _NewObjectClassCommand;
            }
        }

        private ICommandViewModel _NewRelationCommand = null;
        public ICommandViewModel NewRelationCommand
        {
            get
            {
                if (_NewRelationCommand == null)
                {
                    _NewRelationCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, "New Relation", "Creates a new Relation", () =>
                    {
                        var newCtx = ctxFactory();
                        var newWorkspace = ViewModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(newCtx);
                        var newRel = newCtx.Create<Relation>();

                        newRel.Module = newCtx.Find<Module>(Module.ID);
                        // First() and Last() may be the same
                        newRel.A.Type = newCtx.Find<ObjectClass>(SelectedGraphDataTypeViewModels.First().ID);
                        newRel.B.Type = newCtx.Find<ObjectClass>(SelectedGraphDataTypeViewModels.Last().ID);

                        newWorkspace.ShowForeignModel(DataObjectViewModel.Fetch(ViewModelFactory, newCtx, newRel));
                        ViewModelFactory.ShowModel(newWorkspace, true);
                    },
                    () => (SelectedGraphDataTypeViewModels.Count() == 1 || SelectedGraphDataTypeViewModels.Count() == 2) && SelectedGraphDataTypeViewModels.Any(dt => dt.DataType is ObjectClass));
                }
                return _NewRelationCommand;
            }
        }
        #endregion
    }
}
