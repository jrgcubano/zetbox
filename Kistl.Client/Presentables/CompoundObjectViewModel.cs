using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Utils;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.API.Configuration;
using System.ComponentModel;
using Kistl.Client.Presentables.ValueViewModels;
using Kistl.Client.Models;

namespace Kistl.Client.Presentables
{
    public class CompoundObjectViewModel : ViewModel
    {
        public new delegate CompoundObjectViewModel Factory(IKistlContext dataCtx, ICompoundObject obj);

        protected readonly KistlConfig config;

        public CompoundObjectViewModel(
            IViewModelDependencies appCtx, KistlConfig config, IKistlContext dataCtx,
            ICompoundObject obj)
            : base(appCtx, dataCtx)
        {
            this.config = config;
            _object = obj;
            _object.PropertyChanged += ObjectPropertyChanged;
        }

        private void ObjectPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // propagate updates for IDataErrorInfo
            OnPropertyChanged("PropertyModels");
            OnPropertyChanged("PropertyModelsByName");
            OnPropertyChanged("PropertyGroups");
            OnPropertyChanged("PropertyGroupsByName");
            // all updates done
        }

        #region Public Interface

        private ICompoundObject _object;
        public ICompoundObject Object { get { return _object; } }

        private ReadOnlyProjectedList<Property, BaseValueViewModel> _propertyModels;
        public IReadOnlyList<BaseValueViewModel> PropertyModels
        {
            get
            {
                if (_propertyModels == null)
                {
                    _propertyModels = new ReadOnlyProjectedList<Property, BaseValueViewModel>(
                        FetchPropertyList().ToList(),
                        property => ModelFactory.CreateViewModel<BaseValueViewModel.Factory>(property).Invoke(DataContext, property.GetValueModel(Object, DataContext, ModelFactory)),
                        m => null); //m.Property);
                }
                return _propertyModels;
            }
        }
        private LookupDictionary<string, Property, ViewModel> _propertyModelsByName;
        public LookupDictionary<string, Property, ViewModel> PropertyModelsByName
        {
            get
            {
                if (_propertyModelsByName == null)
                {
                    _propertyModelsByName = new LookupDictionary<string, Property, ViewModel>(FetchPropertyList().ToList(), 
                        prop => prop.Name,
                        prop => ModelFactory.CreateViewModel<BaseValueViewModel.Factory>(prop).Invoke(DataContext, prop.GetValueModel(Object, DataContext, ModelFactory)));
                }
                return _propertyModelsByName;
            }
        }

        private IEnumerable<Property> FetchPropertyList()
        {
            // load properties from MetaContext
            var cls = _object.GetCompoundObjectDefinition(FrozenContext);
            var props = new List<Property>();
            foreach (Property p in cls.Properties)
            {
                props.Add(p);
            }

            return props;
        }
        #endregion

        public override string Name
        {
            get { return ""; }
        }
    }
}
