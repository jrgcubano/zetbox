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
using Kistl.Client.Presentables;
using Kistl.Client.Presentables.ValueViewModels;
using Kistl.Client.GUI;

namespace Kistl.Client.WPF.View.GridCells
{
    /// <summary>
    /// Interaction logic for ReferenceEditor.xaml
    /// </summary>
    public partial class ReferenceEditor : UserControl, IHasViewModel<ObjectReferenceViewModel>
    {
        public ReferenceEditor()
        {
            InitializeComponent();
        }

        #region IHasViewModel<ObjectReferenceModel> Members

        public ObjectReferenceViewModel ViewModel
        {
            get { return (ObjectReferenceViewModel)DataContext; }
        }

        #endregion
    }
}
