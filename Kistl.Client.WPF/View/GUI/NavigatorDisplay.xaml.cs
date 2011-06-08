
namespace Kistl.Client.WPF.View.GUI
{
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
    using System.Windows.Shapes;
    using Kistl.Client.GUI;
    using Kistl.Client.Presentables.GUI;
    using Kistl.Client.WPF.CustomControls;

    /// <summary>
    /// Interaction logic for NavigatorDisplay.xaml
    /// </summary>
    [ViewDescriptor(Kistl.App.GUI.Toolkit.WPF)]
    public partial class NavigatorDisplay : WindowView, IHasViewModel<NavigatorViewModel>
    {
        public NavigatorDisplay()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        protected void BackCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ViewModel.Back();
        }

        #region IHasViewModel<NavigatorViewModel> Members

        public NavigatorViewModel ViewModel
        {
            get { return (NavigatorViewModel)DataContext; }
        }

        #endregion
    }
}
