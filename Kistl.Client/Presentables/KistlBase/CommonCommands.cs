using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.App.Base;
using ObjectEditorWorkspace = Kistl.Client.Presentables.ObjectEditor.WorkspaceViewModel;
using Kistl.App.GUI;

namespace Kistl.Client.Presentables.KistlBase
{
    public class OpenDataObjectCommand : ItemCommandModel<DataObjectViewModel>
    {
        public new delegate OpenDataObjectCommand Factory(IKistlContext dataCtx, ControlKind reqWorkspaceKind, ControlKind reqEditorKind);

        protected readonly Func<IKistlContext> ctxFactory;

        public OpenDataObjectCommand(IViewModelDependencies appCtx, Func<IKistlContext> ctxFactory,
            IKistlContext dataCtx, ControlKind reqWorkspaceKind, ControlKind reqEditorKind
            )
            : base(appCtx, dataCtx, "Open", "Opens the current selected Object")
        {
            this.ctxFactory = ctxFactory;
            this._requestedWorkspaceKind = reqWorkspaceKind;
            this._requestedEditorKind = reqEditorKind;
        }

        private ControlKind _requestedEditorKind;
        public ControlKind RequestedEditorKind
        {
            get
            {
                return _requestedEditorKind;
            }
            set
            {
                if (_requestedEditorKind != value)
                {
                    _requestedEditorKind = value;
                    OnPropertyChanged("RequestedEditorKind");
                }
            }
        }

        private ControlKind _requestedWorkspaceKind;
        public ControlKind RequestedWorkspaceKind
        {
            get
            {
                return _requestedWorkspaceKind;
            }
            set
            {
                if (_requestedWorkspaceKind != value)
                {
                    _requestedWorkspaceKind = value;
                    OnPropertyChanged("RequestedWorkspaceKind");
                }
            }
        }

        public delegate void ModelCreatedEventHandler(DataObjectViewModel mdl);
        public event ModelCreatedEventHandler ModelCreated;

        protected override void DoExecute(IEnumerable<DataObjectViewModel> data)
        {
            var newWorkspace = ModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(ctxFactory());
            foreach (var item in data)
            {
                var newMdl = newWorkspace.ShowForeignModel(item, RequestedEditorKind);
                ModelCreatedEventHandler temp = ModelCreated;
                if (temp != null)
                {
                    temp(newMdl);
                }
            }
            ModelFactory.ShowModel(newWorkspace, RequestedWorkspaceKind, true);
        }
    }

    public class DeleteDataObjectCommand : ItemCommandModel<DataObjectViewModel>
    {
        public new delegate DeleteDataObjectCommand Factory(IKistlContext dataCtx);

        public DeleteDataObjectCommand(IViewModelDependencies appCtx, IKistlContext dataCtx)
            : base(appCtx, dataCtx, "Delete", "Deletes the current selected Object")
        {
        }

        protected override void DoExecute(IEnumerable<DataObjectViewModel> data)
        {
            foreach (var item in data)
            {
                DataContext.Delete(item.Object);
            }
            DataContext.SubmitChanges();
        }
    }

    public class NewDataObjectCommand : CommandModel
    {
        public new delegate NewDataObjectCommand Factory(IKistlContext dataCtx, DataType type, ControlKind reqWorkspaceKind, ControlKind reqEditorKind);

        protected readonly Func<IKistlContext> ctxFactory;
        protected DataType Type { get; private set; }

        public NewDataObjectCommand(IViewModelDependencies appCtx, Func<IKistlContext> ctxFactory,
            IKistlContext dataCtx, DataType type, ControlKind reqWorkspaceKind, ControlKind reqEditorKind)
            : base(appCtx, dataCtx, "New", "Creates a new Object")
        {
            this.Type = type;
            this.ctxFactory = ctxFactory;
            this._requestedWorkspaceKind = reqWorkspaceKind;
            this._requestedEditorKind = reqEditorKind;
        }

        private ControlKind _requestedEditorKind;
        public ControlKind RequestedEditorKind
        {
            get
            {
                return _requestedEditorKind;
            }
            set
            {
                if (_requestedEditorKind != value)
                {
                    _requestedEditorKind = value;
                    OnPropertyChanged("RequestedEditorKind");
                }
            }
        }

        private ControlKind _requestedWorkspaceKind;
        public ControlKind RequestedWorkspaceKind
        {
            get
            {
                return _requestedWorkspaceKind;
            }
            set
            {
                if (_requestedWorkspaceKind != value)
                {
                    _requestedWorkspaceKind = value;
                    OnPropertyChanged("RequestedWorkspaceKind");
                }
            }
        }

        public override bool CanExecute(object data)
        {
            return true;
        }

        protected override void DoExecute(object data)
        {
            var newCtx =  ctxFactory();
            var newWorkspace = ModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(newCtx);
            var newObj = newCtx.Create(DataContext.GetInterfaceType(Type.GetDataType()));
            newWorkspace.ShowForeignModel(ModelFactory.CreateViewModel<DataObjectViewModel.Factory>(newObj).Invoke(newCtx, newObj), RequestedEditorKind);
            ModelFactory.ShowModel(newWorkspace, RequestedWorkspaceKind, true);
        }
    }

    public class EditDataObjectClassCommand : CommandModel
    {
        public new delegate EditDataObjectClassCommand Factory(IKistlContext dataCtx, DataType type);

        protected readonly Func<IKistlContext> ctxFactory;
        protected DataType Type { get; private set; }

        public EditDataObjectClassCommand(IViewModelDependencies appCtx, 
            IKistlContext dataCtx, DataType type,
            Func<IKistlContext> ctxFactory)
            : base(appCtx, dataCtx, "Edit Class", "Opens the Editor for the current lists class")
        {
            this.Type = type;
            this.ctxFactory = ctxFactory;
        }

        public override bool CanExecute(object data)
        {
            return true;
        }

        protected override void DoExecute(object data)
        {
            var newCtx = ctxFactory();
            var objClass = newCtx.Find<DataType>(this.Type.ID);
            var newWorkspace = ModelFactory.CreateViewModel<ObjectEditorWorkspace.Factory>().Invoke(newCtx);
            newWorkspace.ShowForeignModel(ModelFactory.CreateViewModel<DataObjectViewModel.Factory>(objClass).Invoke(newCtx, objClass));
            ModelFactory.ShowModel(newWorkspace, true);
        }
    }

    public interface IRefreshCommandListener
    {
        void Refresh();
    }

    public class RefreshCommand : CommandModel
    {
        public new delegate RefreshCommand Factory(IKistlContext dataCtx, IRefreshCommandListener listener);

        protected IRefreshCommandListener Listener { get; private set; }

        public RefreshCommand(IViewModelDependencies appCtx, IKistlContext dataCtx, IRefreshCommandListener listener)
            : base(appCtx, dataCtx, "Refresh", "Refreshes the current list")
        {
            this.Listener = listener;
        }

        public override bool CanExecute(object data)
        {
            return Listener != null;
        }

        protected override void DoExecute(object data)
        {
            if (CanExecute(data))
            {
                Listener.Refresh();
            }
        }
    }
}
