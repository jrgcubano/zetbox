// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.
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
using Zetbox.Client.GUI;
using Zetbox.Client.Presentables;
using Zetbox.Client.Presentables.ValueViewModels;
using Zetbox.Client.WPF.CustomControls;
using Zetbox.Client.WPF.View.ZetboxBase;

namespace Zetbox.Client.WPF.View
{
    /// <summary>
    /// Interaction logic for EnumSelectionView.xaml
    /// </summary>
    public partial class EnumSelectionView : PropertyEditor, IHasViewModel<EnumerationValueViewModel>
    {
        public EnumSelectionView()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();

            cb.GotKeyboardFocus += (s, e) => ViewModel.Focus();
            cb.LostKeyboardFocus += (s, e) => ViewModel.Blur();
        }

        #region IHasViewModel<EnumerationPropertyModel> Members

        public EnumerationValueViewModel ViewModel
        {
            get { return (EnumerationValueViewModel)DataContext; }
        }

        #endregion

        protected override FrameworkElement MainControl
        {
            get { return cb; }
        }

        protected override void SetHighlightValue(FrameworkElement ctrl, DependencyProperty dpProp, Highlight h, Converter.HighlightConverter converter, TypeConverter finalConverter)
        {
            if(dpProp != BackgroundProperty) base.SetHighlightValue(ctrl, dpProp, h, converter, finalConverter);
        }

        private void cbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                ViewModel.FormattedValue = cb.Text;
            }
        }
    }
}
