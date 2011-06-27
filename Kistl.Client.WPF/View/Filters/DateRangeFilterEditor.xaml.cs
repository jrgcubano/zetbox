using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kistl.Client.GUI;
using Kistl.Client.Presentables.FilterViewModels;
using Kistl.Client.Presentables.KistlBase;

namespace Kistl.Client.WPF.View.Filters
{
    /// <summary>
    /// Interaction logic for StringFilterExpression.xaml
    /// </summary>
    [ViewDescriptor(Kistl.App.GUI.Toolkit.WPF)]
    public partial class DateRangeFilterEditor : UserControl, IHasViewModel<DateRangeFilterViewModel>
    {
        public DateRangeFilterEditor()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        public DateRangeFilterViewModel ViewModel
        {
            get { return (DateRangeFilterViewModel)DataContext; }
        }
    }
}