using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;

namespace Kistl.Client.Presentables
{
    public class WorkspaceModel : PresentableModel
    {
        public WorkspaceModel(
            IThreadManager uiManager, IThreadManager asyncManager,
            IKistlContext guiCtx, IKistlContext dataCtx,
            ModelFactory factory)
            : base(uiManager, asyncManager, guiCtx, dataCtx, factory)
        {
            Modules = new ObservableCollection<ModuleModel>();
            OpenObjects = new ObservableCollection<DataObjectModel>();


            Async.Queue(DataContext, () => { AsyncLoadModules(); UI.Queue(UI, () => this.State = ModelState.Active); });
        }

        #region public interface

        /// <summary>
        /// A list of "active" <see cref="IDataObjects"/>
        /// </summary>
        public ObservableCollection<DataObjectModel> OpenObjects { get; private set; }

        /// <summary>
        /// registers a user contact with the mdl in this <see cref="WorkspaceModel"/>'s history
        /// </summary>
        /// <param name="mdl"></param>
        public void HistoryTouch(DataObjectModel mdl)
        {
            UI.Verify();
            var item = SelectedItem;
            if (OpenObjects.Contains(mdl))
            {
                OpenObjects.Remove(mdl);
            }
            OpenObjects.Add(mdl);
            SelectedItem = item;
        }

        /// <summary>
        /// A collection of all <see cref="Module"/>s, to display as entry 
        /// point into the object hierarchy
        /// </summary>
        public ObservableCollection<ModuleModel> Modules { get; private set; }

        private SaveContextCommand _saveCommand;
        /// <summary>
        /// This command submits all outstanding changes of this Workspace to the data store.
        /// The parameter has to be <value>null</value>.
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                UI.Verify();
                if (_saveCommand == null)
                    _saveCommand = Factory.CreateModel<SaveContextCommand>();

                return _saveCommand;
            }
        }

        private DataObjectModel _selectedItem;
        public DataObjectModel SelectedItem
        {
            get
            {
                UI.Verify();
                return _selectedItem;
            }
            set
            {
                UI.Verify();
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    if (_selectedItem != null)
                        HistoryTouch(_selectedItem);
                    OnPropertyChanged("SelectedItem");
                }
            }
        }
        #endregion

        #region Async handlers and UI callbacks

        private void AsyncLoadModules()
        {
            Async.Verify();
            var modules = DataContext.GetQuery<Module>().ToList();
            UI.Queue(UI, () =>
            {
                foreach (var m in modules)
                {
                    Modules.Add(Factory.CreateModel<ModuleModel>(m));
                }
                State = ModelState.Active;
            });
        }

        #endregion

    }

    public class SaveContextCommand : CommandModel
    {
        public SaveContextCommand(
            IThreadManager uiManager, IThreadManager asyncManager,
            IKistlContext guiCtx, IKistlContext dataCtx,
            ModelFactory factory)
            : base(uiManager, asyncManager, guiCtx, dataCtx, factory)
        {
            Label = "Save";
            ToolTip = "Commits outstanding changes to the data store.";
        }

        public override bool CanExecute(object data)
        {
            UI.Verify();
            return data == null;
        }

        public override void Execute(object data)
        {
            UI.Verify();
            Executing = true;
            Async.Queue(DataContext, () =>
            {
                DataContext.SubmitChanges();
                UI.Queue(UI, () => Executing = false);
            });
        }

    }

}
