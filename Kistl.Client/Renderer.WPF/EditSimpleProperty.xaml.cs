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

using Kistl.GUI;

namespace Kistl.GUI.Renderer.WPF
{
    /// <summary>
    /// Zeigt eine einfache Eigenschaft zum Bearbeiten an
    /// </summary>
    public partial class EditSimpleProperty : PropertyControl, IStringControl
    {

        public EditSimpleProperty()
        {
            InitializeComponent();
        }

        #region IStringControl Members

        string IStringControl.Value
        {
            get
            {
                return this.Value.ToString();
            }
            set
            {
                this.Value = value;
            }
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == ValueProperty)
            {
                OnUserInput(e);
            }
        }

        protected virtual void OnUserInput(DependencyPropertyChangedEventArgs e)
        {
            if (_UserInput != null)
            {
                _UserInput(this, new EventArgs());
            }
        }

        private event EventHandler _UserInput;
        event EventHandler IStringControl.UserInput
        {
            add { _UserInput += value; }
            remove { _UserInput -= value; }
        }

        void IStringControl.FlagValidity(bool valid)
        {
            Panel.Background = valid ? Brushes.White : Brushes.Red;
        }

        #endregion

    }
}
