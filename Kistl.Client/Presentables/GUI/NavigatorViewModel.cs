
namespace Kistl.Client.Presentables.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.App.GUI;

    [ViewModelDescriptor]
    public class NavigatorViewModel
        : WindowViewModel
    {
        public new delegate NavigatorViewModel Factory(IKistlContext dataCtx, ViewModel parent, NavigationScreen root);

        private readonly NavigationEntryViewModel _root;
        private NavigationEntryViewModel _current;
        private readonly ObservableCollection<NavigationEntryViewModel> _history;
        private readonly ReadOnlyObservableCollection<NavigationEntryViewModel> _historyRO;

        private readonly ObservableCollection<NavigationEntryViewModel> _location;
        private readonly ReadOnlyObservableCollection<NavigationEntryViewModel> _locationRO;

        public NavigatorViewModel(IViewModelDependencies dependencies, IKistlContext dataCtx, ViewModel parent, NavigationScreen root)
            : base(dependencies, dataCtx, parent)
        {
            _current = _root = NavigationEntryViewModel.Fetch(ViewModelFactory, dataCtx, parent, root);
            _current.Displayer = this;

            _history = new ObservableCollection<NavigationEntryViewModel>() { _current };
            _historyRO = new ReadOnlyObservableCollection<NavigationEntryViewModel>(_history);

            _location = new ObservableCollection<NavigationEntryViewModel>() { _root };
            _locationRO = new ReadOnlyObservableCollection<NavigationEntryViewModel>(_location);
        }

        #region Name

        public override string Name
        {
            get { return GetTitle(_root, _current); }
        }

        private static string GetTitle(NavigationEntryViewModel root, NavigationEntryViewModel current)
        {
            return root.Name + ": " + current.Name;
        }

        #endregion

        #region Navigational Aides

        /// <summary>
        /// The currently displayed NavigationScreenViewModel.
        /// </summary>
        public NavigationEntryViewModel CurrentScreen
        {
            get
            {
                return _current;
            }

            private set
            {
                if (_current != value)
                {
                    _current = value;
                    _current.Displayer = this;
                    _history.Add(_current);
                    UpdateLocation();
                    OnPropertyChanged("CurrentScreen");
                }
            }
        }

        /// <summary>
        /// The "path" to the CurrentScreen, as defined by its Parents.
        /// </summary>
        public ReadOnlyObservableCollection<NavigationEntryViewModel> Location
        {
            get { return _locationRO; }
        }

        private void UpdateLocation()
        {
            var newLocation = new List<NavigationEntryViewModel>();
            var screen = CurrentScreen;
            while (screen != null)
            {
                newLocation.Add(screen);
                screen = screen.ParentScreen;
            }
            newLocation.Reverse();

            int prefixLength = 0;
            while (prefixLength < newLocation.Count
                && prefixLength < Location.Count
                && newLocation[prefixLength] == Location[prefixLength])
            {
                prefixLength += 1;
            }
            // now we know that the first "prefixLength" items are equal
            // and we can replace the rest with the "newLocation" suffix

            // remove from end
            while (Location.Count > prefixLength)
            {
                _location.RemoveAt(Location.Count - 1);
            }

            // add remaining items
            while (prefixLength < newLocation.Count)
            {
                _location.Add(newLocation[prefixLength]);
                prefixLength += 1;
            }
        }

        /// <summary>
        /// A list of recently visited screens.
        /// </summary>
        public ReadOnlyObservableCollection<NavigationEntryViewModel> History
        {
            get { return _historyRO; }
        }

        #endregion

        #region Commands

        private ICommandViewModel _HomeCommand = null;
        public ICommandViewModel HomeCommand
        {
            get
            {
                if (_HomeCommand == null)
                {
                    _HomeCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(
                        DataContext,
                        this,
                        NavigatorViewModelResources.HomeCommand_Name,
                        NavigatorViewModelResources.HomeCommand_Tooltip,
                        Home,
                        () => CurrentScreen != _root, 
                        null);
                }
                return _HomeCommand;
            }
        }

        public void Home()
        {
            CurrentScreen = _root;
        }

        private ICommandViewModel _BackCommand = null;
        public ICommandViewModel BackCommand
        {
            get
            {
                if (_BackCommand == null)
                {
                    _BackCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(
                        DataContext,
                        this,
                        NavigatorViewModelResources.BackCommand_Name,
                        NavigatorViewModelResources.BackCommand_Tooltip,
                        Back,
                        () => _history.Count > 1, 
                        null);
                }
                return _BackCommand;
            }
        }

        public void Back()
        {
            if (_history.Count > 1)
            {
                // remove "current" screen from history
                _history.RemoveAt(_history.Count - 1);
                CurrentScreen = _history.Last();
                // remove the back step from history too
                _history.RemoveAt(_history.Count - 1);
            }
        }

        private ICommandViewModel _NavigateToCommand = null;
        public ICommandViewModel NavigateToCommand
        {
            get
            {
                if (_NavigateToCommand == null)
                {
                    _NavigateToCommand = ViewModelFactory.CreateViewModel<SimpleParameterCommandViewModel<NavigationEntryViewModel>.Factory>().Invoke(
                                DataContext,
                                this,
                                NavigatorViewModelResources.NavigateToCommand_Name,
                                NavigatorViewModelResources.NavigateToCommand_Tooltip,
                                NavigateTo,
                                screen => CurrentScreen != screen);
                }
                return _NavigateToCommand;
            }
        }

        public void NavigateTo(NavigationEntryViewModel screen)
        {
            CurrentScreen = screen;
        }
        #endregion

        #region Closing
        public override bool CanClose()
        {
            return ViewModelFactory.GetDecisionFromUser(NavigatorViewModelResources.CanClose, NavigatorViewModelResources.CanClose_Title);
        }
        #endregion
    }
}
