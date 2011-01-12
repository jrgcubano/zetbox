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

using Kistl.Client.GUI;
using Kistl.Client.Presentables;
using Kistl.Client.WPF.View.KistlBase;
using Kistl.Client.Presentables.ValueViewModels;

namespace Kistl.Client.WPF.View
{
    [ViewDescriptor(Kistl.App.GUI.Toolkit.WPF)]
    public partial class NullablePasswordTextBoxView : PropertyEditor, IHasViewModel<IValueViewModel<string>>, IHasViewModel<IFormattedValueViewModel>
    {
        public NullablePasswordTextBoxView()
        {
            InitializeComponent();
        }

        #region IHasViewModel<IValueModelAsString> Members

        public IValueViewModel<string> ViewModel
        {
            get { return (IValueViewModel<string>)DataContext; }
        }

        #endregion

        #region IHasViewModel<IValueModelAsString> Members

        IFormattedValueViewModel IHasViewModel<IFormattedValueViewModel>.ViewModel
        {
            get { return (IFormattedValueViewModel)DataContext; }
        }

        #endregion

        /// <summary>
        /// Foreces a manual refresh, as WPF ignores notifications on UpdateSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null && ViewModel.IsReadOnly == false)
            {
                var binding = BindingOperations.GetBindingExpressionBase(txt, TextBox.TextProperty);
                binding.UpdateSource();
                binding.UpdateTarget();
            }
        }

        protected override FrameworkElement MainControl
        {
            get { return txt; }
        }
    }
}
