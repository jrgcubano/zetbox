using System;
using System.Collections.Generic;
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

using Kistl.Client.Presentables;

namespace Kistl.Client.WPF.View
{
    /// <summary>
    /// Interaction logic for DesktopView.xaml
    /// </summary>
    public partial class WorkspaceView : Window
    {

        public WorkspaceView()
        {
            InitializeComponent();
        }

        private void DataObjectActivated(object sender, MouseButtonEventArgs e)
        {
            var view = (FrameworkElement)sender;
            var dataModel = (DataObjectModel)view.DataContext;
            var workspaceModel = (WorkspaceModel)this.DataContext;
            workspaceModel.HistoryTouch(dataModel);
        }

        private void DeleteHandler(object sender, RoutedEventArgs e)
        {
            var workspaceModel = (WorkspaceModel)this.DataContext;
            var item = workspaceModel.SelectedItem;
            if (item != null)
            {
                item.Delete();
                workspaceModel.HistoryTouch(item);
            }
        }
    }
}
