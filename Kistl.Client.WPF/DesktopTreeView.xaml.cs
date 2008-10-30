using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

using Kistl.API;
using Kistl.API.Client;
using Kistl.GUI.Renderer.WPF;

namespace Kistl.Client.WPF
{
    /// <summary>
    /// Interaction logic for DesktopTreeView.xaml
    /// </summary>
    public partial class DesktopTreeView : UserControl
    {
        static DesktopTreeView()
        {
            SelectionChangedEvent = EventManager.RegisterRoutedEvent("SelectionChanged", RoutingStrategy.Bubble,
                            typeof(RoutedPropertyChangedEventHandler<Kistl.API.IDataObject>), typeof(DesktopTreeView));
        }

        public static RoutedEvent SelectionChangedEvent;
        public event RoutedPropertyChangedEventHandler<Kistl.API.IDataObject> SelectionChanged
        {
            add { AddHandler(SelectionChangedEvent, value); }
            remove { RemoveHandler(SelectionChangedEvent, value); }
        }

        public DesktopTreeView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Bind();
        }

        private IKistlContext context;

        private void Bind()
        {
            // Desingmode? -> raus
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(this)) return;

            try
            {
                if (context != null)
                {
                    context.Dispose();
                }

                context = KistlContext.GetContext();

                this.DataContext = context.GetQuery<Kistl.App.Base.Module>().ToList()
                    .Select(m => new ModuleNode(m)).ToList();
            }
            catch (Exception ex)
            {
                ClientHelper.HandleError(ex);
            }
        }

        #region Nodes
        public interface INode
        {
            Kistl.API.IDataObject DataObject { get; }
            void RefreshChildren();
        }

        public class ModuleNode : INode
        {
            public Kistl.App.Base.Module Module { get; set; }

            public ModuleNode(Kistl.App.Base.Module m)
            {
                Module = m;
            }

            private ObservableCollection<ObjectClassNode> _ObjectClassedNodes = null;
            public ObservableCollection<ObjectClassNode> ObjectClassedNodes
            {
                get
                {
                    if (_ObjectClassedNodes == null)
                    {
                        _ObjectClassedNodes = new ObservableCollection<ObjectClassNode>();
                        Module.DataTypes.ForEach<Kistl.App.Base.DataType>(o => _ObjectClassedNodes.Add(new ObjectClassNode(o)));
                    }

                    return _ObjectClassedNodes;
                }
            }

            #region INode Members

            public Kistl.API.IDataObject DataObject
            {
                get { return Module; }
            }

            public void RefreshChildren()
            {
            }

            #endregion
        }

        public class ObjectClassNode : INode
        {
            public Kistl.App.Base.DataType ObjectClass { get; set; }

            public ObjectClassNode(Kistl.App.Base.DataType o)
            {
                ObjectClass = o;
            }

            private ObservableCollection<InstanceNode> _InstancesNodes = null;
            public ObservableCollection<InstanceNode> InstancesNodes
            {
                get
                {
                    if (_InstancesNodes == null)
                    {
                        _InstancesNodes = new ObservableCollection<InstanceNode>();
                        RefreshChildren();
                    }

                    return _InstancesNodes;
                }
            }

            #region INode Members

            public Kistl.API.IDataObject DataObject
            {
                get { return ObjectClass; }
            }

            public void RefreshChildren()
            {
                try
                {
                    Mouse.OverrideCursor = Cursors.Wait;
                    _InstancesNodes.Clear();
                    if (ObjectClass is Kistl.App.Base.ObjectClass)
                    {
                        ObjectClass.Context.GetQuery(ObjectClass.GetDataType()).ToList()
                            .ForEach(i => _InstancesNodes.Add(new InstanceNode(i)));
                    }
                }
                finally
                {
                    Mouse.OverrideCursor = Cursors.Arrow;
                }
            }
            #endregion
        }

        public class InstanceNode : INode
        {
            // public BaseClientDataObject Object { get; set; }
            public Kistl.API.IDataObject Object { get; set; }

            public InstanceNode(Kistl.API.IDataObject obj)
            {
                Object = (BaseClientDataObject)obj;
            }

            #region INode Members

            public Kistl.API.IDataObject DataObject
            {
                get { return Object; }
            }

            public void RefreshChildren()
            {
            }
            #endregion
        }
        #endregion

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (treeView.SelectedItem == null) return;

                Type resultObjectType = null;
                INode n = null;
                if (treeView.SelectedItem is ObjectClassNode)
                {
                    n = (ObjectClassNode)treeView.SelectedItem;
                    resultObjectType = ((ObjectClassNode)n).ObjectClass.GetDataType();
                    Kistl.App.Base.ObjectClass objClass = ClientHelper.ObjectClasses[resultObjectType];

                    if (objClass.SubClasses.Count > 0)
                    {
                        // TODO: Das ist noch nicht ganz konsistent
                        Kistl.Client.WPF.Dialogs.ChooseFromSubclassesDialog dlg
                            = new Kistl.Client.WPF.Dialogs.ChooseFromSubclassesDialog(objClass);

                        if (dlg.ShowDialog() == true)
                        {
                            resultObjectType = ((Kistl.App.Base.ObjectClass)dlg.Result).GetDataType();
                        }
                        else
                        {
                            // Do nothing
                            return;
                        }
                    }
                }
                else if (treeView.SelectedItem is ModuleNode)
                {
                    n = (ModuleNode)treeView.SelectedItem;
                    // TODO: Ausbessern!!!
                    resultObjectType = Type.GetType("Kistl.App.Base.ObjectClass, Kistl.Objects", true);
                }

                if (resultObjectType != null && n != null)
                {
                    // Create a new Context for this object
                    IKistlContext ctx = KistlContext.GetContext();
                    Kistl.API.IDataObject newObject = ctx.Create(resultObjectType);

                    // (Kistl.API.IDataObject)Activator.CreateInstance(resultObjectType);
                    // newObject.AttachToContext(ctx);

                    GuiApplicationContext.Current.Renderer.ShowObject(newObject);
                    n.RefreshChildren();
                }
            }
            catch (Exception ex)
            {
                ClientHelper.HandleError(ex);
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Bind();
        }

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue is INode)
            {
                RoutedPropertyChangedEventArgs<Kistl.API.IDataObject> args =
                    new RoutedPropertyChangedEventArgs<Kistl.API.IDataObject>(
                       null, ((INode)e.NewValue).DataObject, SelectionChangedEvent);
                RaiseEvent(args);
            }
        }

        private void treeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (treeView.SelectedItem == null) return;

                INode n = treeView.SelectedItem as INode;
                // Create new Context for new Window
                IKistlContext ctx = KistlContext.GetContext();
                Kistl.API.IDataObject newObject = ctx.Find(n.DataObject.GetInterfaceType(), n.DataObject.ID);
                GuiApplicationContext.Current.Renderer.ShowObject(newObject);
            }
            catch (Exception ex)
            {
                ClientHelper.HandleError(ex);
            }
        }

        private void ctxmnu_Refresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (treeView.SelectedItem == null) return;
                INode n = treeView.SelectedItem as INode;
                n.RefreshChildren();
            }
            catch (Exception ex)
            {
                ClientHelper.HandleError(ex);
            }
        }
    }
}
