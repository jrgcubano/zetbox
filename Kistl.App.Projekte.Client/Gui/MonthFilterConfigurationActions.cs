namespace Kistl.App.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.Client.Presentables;
    using Kistl.Client.Models;
    using Kistl.App.Base;
    using Kistl.Client;

    /// <summary>
    /// Client implementation
    /// </summary>
    [Implementor]
    public class MonthFilterConfigurationActions
    {
        private static IViewModelFactory _factory;
        private static IFrozenContext ForzenContext;

        public MonthFilterConfigurationActions(IFrozenContext frozenCtx, IViewModelFactory factory)
        {
            ForzenContext = frozenCtx;
            _factory = factory;
        }

        [Invocation]
        public static void CreateFilterModel(Kistl.App.GUI.MonthFilterConfiguration obj, MethodReturnEventArgs<IFilterModel> e)
        {
            var mdl = new MonthValueFilterModel();
            mdl.Label = obj.GetLabel();
            mdl.Required = obj.Required;
            mdl.ValueSource = FilterValueSource.FromProperty(obj.Property);

            mdl.ViewModelType = obj.ViewModelDescriptor;
            mdl.FilterArguments.Add(new FilterArgumentConfig(obj.Property.GetDetachedValueModel(true), /*cfg.ArgumentViewModel ?? */ ForzenContext.FindPersistenceObject<ViewModelDescriptor>(NamedObjects.ViewModelDescriptor_NullableMonthPropertyViewModel)));

            if (obj.IsCurrentMonthDefault == true)
            {
                // Defaults to this month
                ((DateTimeValueModel)mdl.FilterArguments[0].Value).Value = DateTime.Today.FirstMonthDay();
            }

            e.Result = mdl;
        }

        [Invocation]
        public static void NotifyCreated(Kistl.App.GUI.MonthFilterConfiguration obj)
        {
            obj.ViewModelDescriptor = obj.Context.FindPersistenceObject<ViewModelDescriptor>(NamedObjects.ViewModelDescriptor_SingleValueFilterViewModel);
        }
  
    }
}