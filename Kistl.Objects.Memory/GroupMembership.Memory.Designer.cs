// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("GroupMembership")]
    public class GroupMembershipMemoryImpl : Kistl.App.Base.AccessControlMemoryImpl, GroupMembership
    {
        private static readonly Guid _objectClassID = new Guid("acf18a64-5fc0-4610-b083-9893eea0776c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public GroupMembershipMemoryImpl()
            : base(null)
        {
        }

        public GroupMembershipMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Group
        // fkBackingName=_fk_Group; fkGuidBackingName=_fk_guid_Group;
        // referencedInterface=Kistl.App.Base.Group; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Group Group
        {
            get { return GroupImpl; }
            set { GroupImpl = (Kistl.App.Base.GroupMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Group;

        private Guid? _fk_guid_Group = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.GroupMemoryImpl GroupImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.GroupMemoryImpl __value;
                if (_fk_Group.HasValue)
                    __value = (Kistl.App.Base.GroupMemoryImpl)Context.Find<Kistl.App.Base.Group>(_fk_Group.Value);
                else
                    __value = null;

                if (OnGroup_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Group>(__value);
                    OnGroup_Getter(this, e);
                    __value = (Kistl.App.Base.GroupMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Group == null)
                    return;
                else if (value != null && value.ID == _fk_Group)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = GroupImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Group", __oldValue, __newValue);

                if (OnGroup_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Group>(__oldValue, __newValue);
                    OnGroup_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.GroupMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Group = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Group", __oldValue, __newValue);

                if (OnGroup_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Group>(__oldValue, __newValue);
                    OnGroup_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Group
		public static event PropertyGetterHandler<Kistl.App.Base.GroupMembership, Kistl.App.Base.Group> OnGroup_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.GroupMembership, Kistl.App.Base.Group> OnGroup_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.GroupMembership, Kistl.App.Base.Group> OnGroup_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.GroupMembership> OnGroup_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(GroupMembership);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (GroupMembership)obj;
            var otherImpl = (GroupMembershipMemoryImpl)obj;
            var me = (GroupMembership)this;

            this._fk_Group = otherImpl._fk_Group;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Group":
                    {
                        var __oldValue = _fk_Group;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Group", __oldValue, __newValue);
                        _fk_Group = __newValue;
                        NotifyPropertyChanged("Group", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Group":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Group.HasValue)
                GroupImpl = (Kistl.App.Base.GroupMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.Group>(_fk_guid_Group.Value);
            else
            if (_fk_Group.HasValue)
                GroupImpl = (Kistl.App.Base.GroupMemoryImpl)Context.Find<Kistl.App.Base.Group>(_fk_Group.Value);
            else
                GroupImpl = null;
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // else
                    new PropertyDescriptorMemoryImpl<GroupMembership, Kistl.App.Base.Group>(
                        lazyCtx,
                        new Guid("da080b07-15d2-4cdf-bc1c-df776e094a75"),
                        "Group",
                        null,
                        obj => obj.Group,
                        (obj, val) => obj.Group = val,
						obj => OnGroup_IsValid), 
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_GroupMembership")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_GroupMembership != null)
            {
                OnToString_GroupMembership(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<GroupMembership> OnToString_GroupMembership;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_GroupMembership")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_GroupMembership != null)
            {
                OnObjectIsValid_GroupMembership(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<GroupMembership> OnObjectIsValid_GroupMembership;

        [EventBasedMethod("OnNotifyPreSave_GroupMembership")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_GroupMembership != null) OnNotifyPreSave_GroupMembership(this);
        }
        public static event ObjectEventHandler<GroupMembership> OnNotifyPreSave_GroupMembership;

        [EventBasedMethod("OnNotifyPostSave_GroupMembership")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_GroupMembership != null) OnNotifyPostSave_GroupMembership(this);
        }
        public static event ObjectEventHandler<GroupMembership> OnNotifyPostSave_GroupMembership;

        [EventBasedMethod("OnNotifyCreated_GroupMembership")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Group");
            base.NotifyCreated();
            if (OnNotifyCreated_GroupMembership != null) OnNotifyCreated_GroupMembership(this);
        }
        public static event ObjectEventHandler<GroupMembership> OnNotifyCreated_GroupMembership;

        [EventBasedMethod("OnNotifyDeleting_GroupMembership")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_GroupMembership != null) OnNotifyDeleting_GroupMembership(this);
        }
        public static event ObjectEventHandler<GroupMembership> OnNotifyDeleting_GroupMembership;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(Group != null ? Group.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_Group, binStream);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(Group != null ? Group.ID : (int?)null, xml, "Group", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Group, xml, "Group", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Group != null ? Group.ExportGuid : (Guid?)null, xml, "Group", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_Group, xml, "Group", "Kistl.App.Base");
        }

        #endregion

    }
}