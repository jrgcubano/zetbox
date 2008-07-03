using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

namespace Kistl.GUI.Renderer.WPF
{
    /// <summary>
    /// Zeigt eine Liste von Objekten an.
    /// Sie kann _alle_ Instanzen einer Klasse anzeigen &
    /// alle Instanzen einer Eigenschaft eines Objektes.
    /// </summary>
    public partial class ObjectListControl
        : PropertyControl, IObjectListControl, ITestObjectListControl
    {

        public ObjectListControl()
        {
            InitializeComponent();
            Value = new List<Kistl.API.IDataObject>(0);
        }

        /// <summary>
        /// DoppelKlick -> öffnet das Objekt in einem neuen Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //TODO: OnUserSelectsObject(sender);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            OnUserAddRequest();
        }

        #region IObjectListControl Member

        public event EventHandler UserAddRequest;

        #endregion

        #region IReferenceControl<IList<Kistl.API.IDataObject>> Members

        public Type ObjectType
        {
            get { return (Type)GetValue(ObjectTypeProperty); }
            set { SetValue(ObjectTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ObjectType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ObjectTypeProperty =
            DependencyProperty.Register("ObjectType", typeof(Type), typeof(ObjectListControl), new PropertyMetadata(null));

        public IList<Kistl.API.IDataObject> ItemsSource
        {
            get { return (IList<Kistl.API.IDataObject>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IList<Kistl.API.IDataObject>), typeof(ObjectListControl), new PropertyMetadata(null));

        #endregion

        #region IValueControl<IList<Kistl.API.IDataObject>> Members

        /// <summary>
        /// explicitly implement this for the framework and suppress the UserInput Event 
        /// when using this.
        /// </summary>
        IList<Kistl.API.IDataObject> IValueControl<IList<Kistl.API.IDataObject>>.Value
        {
            get { return (IList<Kistl.API.IDataObject>)GetValue(ValueProperty); }
            set { SetValueNoUserInput(ValueProperty, value ?? new List<Kistl.API.IDataObject>(0)); }
        }

        /// <summary>
        /// The actual Value of this Widget
        /// </summary>
        public IList<Kistl.API.IDataObject> Value
        {
            get { return (IList<Kistl.API.IDataObject>)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(IList<Kistl.API.IDataObject>),
                typeof(ObjectListControl), new PropertyMetadata(null));

        public event EventHandler UserInput;

        #endregion

        #region Change Management

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == ValueProperty)
            {
                if (Value == null)
                {
                    Value = new List<Kistl.API.IDataObject>(0);
                }
                else
                {
                    OnUserInput(e);
                }
            }
        }

        protected virtual void OnUserInput(DependencyPropertyChangedEventArgs e)
        {
            // this is not always a noop. it happens if the Value is set 
            // programmatically, e.g. by the Presenter on initialisation
            // or when the Model's Value changes.
            // TODO: replace appropriately

            lst.ItemsSource = Value;

            if (UserInput != null && !_SupressUserInputEvent)
            {
                UserInput(this, new EventArgs());
            }
        }

        private bool _SupressUserInputEvent = false;
        public void SetValueNoUserInput(DependencyProperty dp, object value)
        {
            try
            {
                _SupressUserInputEvent = true;
                SetValue(dp, value);
            }
            finally
            {
                _SupressUserInputEvent = false;
            }
        }

        private void OnUserAddRequest()
        {
            if (UserAddRequest != null)
            {
                UserAddRequest(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// exports the list's SelectionChanged Event for usage in the client.
        /// Used by the main window - remove it later!!
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged
        {
            add { lst.SelectionChanged += value; }
            remove { lst.SelectionChanged -= value; }
        }

        #endregion

        #region ITestObjectListControl Members

        object ITestObjectListControl.ListboxValue
        {
            get { return lst.ItemsSource; }
        }

        #endregion

    }

    public interface ITestObjectListControl
    {
        object ListboxValue { get; }
    }

}
