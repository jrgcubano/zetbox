
namespace Kistl.Client.Presentables
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.API.Utils;
    using Kistl.App.Base;
    using Kistl.App.Extensions;

    /// <summary>
    /// </summary>
    public class ObjectListModel
        : PropertyModel<IList<DataObjectModel>>, IValueListModel<DataObjectModel>
    {
        private readonly ObjectReferenceProperty _property;

        public ObjectListModel(
            IGuiApplicationContext appCtx, IKistlContext dataCtx,
            IDataObject referenceHolder, ObjectReferenceProperty prop)
            : base(appCtx, dataCtx, referenceHolder, prop)
        {
            if (!prop.IsList()) { throw new ArgumentOutOfRangeException("prop", "ObjectReferenceProperty must be a list"); }

            _property = prop;

            ReferencedClass = _property.GetReferencedObjectClass();
        }

        #region Public interface and IReadOnlyValueModel<IReadOnlyObservableCollection<DataObjectModel>> Members

        public bool HasValue
        {
            get { return true; }
        }

        public bool IsNull
        {
            get { return false; }
        }

        private ReadOnlyObservableProjectedList<IDataObject, DataObjectModel> _valueCache;
        public IReadOnlyObservableList<DataObjectModel> Value
        {
            get
            {
                if (_valueCache == null)
                {
                    _valueCache = new ReadOnlyObservableProjectedList<IDataObject, DataObjectModel>(
                        Object.GetPropertyValue<INotifyCollectionChanged>(Property.PropertyName),
                        obj => (DataObjectModel)Factory.CreateDefaultModel(DataContext, obj),
                        mdl => mdl.Object);
                }
                return _valueCache;
            }
        }

        public ObjectClass ReferencedClass
        {
            get;
            protected set;
        }

        public GridDisplayConfiguration DisplayedColumns
        {
            get
            {
                GridDisplayConfiguration result = new GridDisplayConfiguration()
                {
                    ShowIcon = ReferencedClass.ShowIconInLists,
                    ShowId = ReferencedClass.ShowIdInLists,
                    ShowName = ReferencedClass.ShowNameInLists
                };

                var group = this.ReferencedClass.GetAllProperties()
                    .Where(p => (p.CategoryTags ?? String.Empty).Split(',', ' ').Contains("Summary"));
                if (group.Count() == 0)
                {
                    group = this.ReferencedClass.GetAllProperties().Where(p =>
                    {
                        var orp = p as ObjectReferenceProperty;
                        if (orp == null) { return true; }

                        switch (orp.RelationEnd.Parent.GetRelationType())
                        {
                            case RelationType.n_m:
                                return false; // don't display lists in grids
                            case RelationType.one_n:
                                return orp.RelationEnd.Multiplicity.UpperBound() > 1; // if we're "n", the navigator is a pointer, not a list
                            case RelationType.one_one:
                                return true; // can always display
                            default:
                                return false; // something went wrong
                        }
                    });
                }

                result.Columns = group
                    .Select(p => new ColumnDisplayModel()
                    {
                        Header = p.PropertyName,
                        PropertyName = p.PropertyName,
                        ControlKind = p.ValueModelDescriptor.GetDefaultGridCellKind()
                    })
                    .ToList();
                return result;
            }
        }

        private DataObjectModel _selectedItem;
        public DataObjectModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                }
            }
        }

        public bool HasPersistentOrder
        {
            get
            {
                return _property.RelationEnd.HasPersistentOrder;
            }
        }

        /// <summary>
        /// Creates a new Item suitable for adding to the list. This may prompt 
        /// the user to choose a type of item to add or enter an initial value.
        /// </summary>
        /// <param name="onCreated">this callback will be called with the newly created item on the UI thread</param>
        /// 
        /// This example creates a new item and activates it for the user to edit:
        /// <example><![CDATA[
        /// model.CreateNewElement(newitem =>
        /// {
        ///     if (newitem != null)
        ///     {
        ///         model.AddItem(newitem);
        ///         model.SelectedItem = newitem;
        ///         model.ActivateItem(model.SelectedItem, true);
        ///     }
        /// });]]>
        /// </example>
        public void CreateNewItem(Action<DataObjectModel> onCreated)
        {
            ObjectClass baseclass = ((ObjectReferenceProperty)this.Property).GetReferencedObjectClass();

            var children = new List<ObjectClass>() { baseclass };
            CollectChildClasses(baseclass.ID, children);

            if (children.Count == 1)
            {
                var targetType = baseclass.GetDescribedInterfaceType();
                var item = this.DataContext.Create(targetType);
                onCreated(Factory.CreateSpecificModel<DataObjectModel>(DataContext, item));
            }
            else
            {
                // sort by name, create models
                // TODO: filter non-instantiable classes
                var childModels = children
                    .OrderBy(oc => oc.ClassName)
                    .Select(oc => (DataObjectModel)Factory.CreateSpecificModel<ObjectClassModel>(DataContext, oc))
                    .ToList();

                Factory.ShowModel(
                    Factory.CreateSpecificModel<DataObjectSelectionTaskModel>(
                        DataContext,
                        childModels,
                        new Action<DataObjectModel>(delegate(DataObjectModel chosen)
                        {
                            if (chosen != null)
                            {
                                var targetType = ((ObjectClass)chosen.Object).GetDescribedInterfaceType();
                                var item = this.DataContext.Create(targetType);
                                onCreated(Factory.CreateSpecificModel<DataObjectModel>(DataContext, item));
                            }
                            else
                            {
                                onCreated(null);
                            }
                        })), true);
            }
        }

        public void AddItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            Object.AddToCollectionQuick(Property.PropertyName, item.Object);
        }

        /// <summary>
        /// Adds an existing item into this ObjectList. Asks the User which should be added.
        /// </summary>
        public void AddExistingItem()
        {
            var baseclass = ((ObjectReferenceProperty)this.Property).GetReferencedObjectClass().GetDescribedInterfaceType();
            var instances = DataContext.GetQuery(baseclass).ToList(); // TODO: remove superfluous ToList
            var instanceModels = instances
                .OrderBy(i => i.ToString())
                .Select(i => (DataObjectModel)Factory.CreateDefaultModel(DataContext, i))
                .ToList();

            Factory.ShowModel(
                Factory.CreateSpecificModel<DataObjectSelectionTaskModel>(
                    DataContext,
                    instanceModels,
                    new Action<DataObjectModel>(delegate(DataObjectModel chosen)
                    {
                        if (chosen != null)
                        {
                            AddItem(chosen);
                            SelectedItem = chosen;
                        }
                    })), true);
        }

        public void RemoveItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            Object.RemoveFromCollectionQuick(Property.PropertyName, item.Object);
        }

        public void DeleteItem(DataObjectModel item)
        {
            if (item == null) { throw new ArgumentNullException("item"); }
            RemoveItem(item);
            item.Delete();
        }

        public void ActivateItem(DataObjectModel item, bool activate)
        {
            if (item == null) { throw new ArgumentNullException("item"); }

            Factory.ShowModel(item, activate);
        }

        #endregion

        #region Utilities and UI callbacks

        protected override void UpdatePropertyValue()
        {
            _valueCache = null;
            OnPropertyChanged("Value");
        }

        private void CollectChildClasses(int id, List<ObjectClass> children)
        {
            var nextChildren = MetaContext.GetQuery<ObjectClass>()
                .Where(oc => oc.BaseObjectClass != null && oc.BaseObjectClass.ID == id)
                .ToList();

            if (nextChildren.Count() > 0)
            {
                foreach (ObjectClass oc in nextChildren)
                {
                    children.Add(oc);
                    CollectChildClasses(oc.ID, children);
                };
            }
        }

        #endregion

    }
}
