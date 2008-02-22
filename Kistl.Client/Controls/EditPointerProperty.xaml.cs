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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kistl.API.Client;
using Kistl.API;
using System.ComponentModel;

namespace Kistl.Client.Controls
{
    /// <summary>
    /// Interaction logic for EditPointerProperty.xaml
    /// </summary>
    public partial class EditPointerProperty : PropertyControl
    {
        public EditPointerProperty()
        {
            InitializeComponent();
        }

        public ObjectType ObjectType
        {
            get { return (ObjectType)GetValue(ObjectTypeProperty); }
            set { SetValue(ObjectTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ObjectType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ObjectTypeProperty =
            DependencyProperty.Register("ObjectType", typeof(ObjectType), typeof(EditPointerProperty));

        public Visibility ShowLabel
        {
            get { return (Visibility)GetValue(ShowLabelProperty); }
            set { SetValue(ShowLabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowLabel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowLabelProperty =
            DependencyProperty.Register("ShowLabel", typeof(Visibility), typeof(EditPointerProperty), new UIPropertyMetadata(Visibility.Visible));


        public int TargetID
        {
            get { return (int)Value; }
            set { Value = value; }
        }

        private void LoadList()
        {
            cbValues.ItemsSource = Context.GetQuery(ObjectType).ToList();
        }

        private void PointerCtrl_Loaded(object sender, RoutedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex);
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObjectWindow wnd = new ObjectWindow();
                wnd.ObjectType = this.ObjectType;
                wnd.ObjectID = API.Helper.INVALIDID;

                wnd.ShowDialog();

                if (wnd.ObjectID != API.Helper.INVALIDID)
                {
                    LoadList();
                    this.Value = wnd.ObjectID;
                }
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex);
            }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ObjectWindow wnd = new ObjectWindow();
                wnd.ObjectType = this.ObjectType;
                wnd.ObjectID = this.TargetID;

                wnd.Show();
            }
            catch (Exception ex)
            {
                Helper.HandleError(ex);
            }
        }

        private void cbValues_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
