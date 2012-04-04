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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for Enumerations.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Enumeration")]
    [System.Diagnostics.DebuggerDisplay("Enumeration")]
    public class EnumerationEfImpl : Kistl.App.Base.DataTypeEfImpl, Enumeration
    {
        [Obsolete]
        public EnumerationEfImpl()
            : base(null)
        {
        }

        public EnumerationEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Enumeration Entries are Flags
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public bool AreFlags
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _AreFlags;
                if (OnAreFlags_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnAreFlags_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_AreFlags != value)
                {
                    var __oldValue = _AreFlags;
                    var __newValue = value;
                    if (OnAreFlags_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnAreFlags_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("AreFlags", __oldValue, __newValue);
                    _AreFlags = __newValue;
                    NotifyPropertyChanged("AreFlags", __oldValue, __newValue);

                    if (OnAreFlags_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnAreFlags_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("AreFlags");
				}
            }
        }
        private bool _AreFlags;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.Enumeration> OnAreFlags_IsValid;

        /// <summary>
        /// Einträge der Enumeration
        /// </summary>
    /*
    Relation: FK_Enumeration_has_EnumerationEntries
    A: One Enumeration as Enumeration
    B: ZeroOrMore EnumerationEntry as EnumerationEntries
    Preferred Storage: MergeIntoB
    */
        // object list property
        // object list property
           // Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.EnumerationEntry> EnumerationEntries
        {
            get
            {
                if (_EnumerationEntries == null)
                {
                    _EnumerationEntries = new EntityListWrapper<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.EnumerationEntryEfImpl>(
                            this.Context, EnumerationEntriesImpl,
                            () => this.NotifyPropertyChanging("EnumerationEntries", null, null, null),
                            () => { this.NotifyPropertyChanged("EnumerationEntries", null, null, null); if(OnEnumerationEntries_PostSetter != null && IsAttached) OnEnumerationEntries_PostSetter(this); },
                            (item) => item.NotifyPropertyChanging("Enumeration", null, null, null),
                            (item) => item.NotifyPropertyChanged("Enumeration", null, null, null), "Enumeration", "EnumerationEntries_pos");
                }
                return _EnumerationEntries;
            }
        }
    
        [EdmRelationshipNavigationProperty("Model", "FK_Enumeration_has_EnumerationEntries", "EnumerationEntries")]
        public EntityCollection<Kistl.App.Base.EnumerationEntryEfImpl> EnumerationEntriesImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.EnumerationEntryEfImpl>(
                        "Model.FK_Enumeration_has_EnumerationEntries",
                        "EnumerationEntries");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityListWrapper<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.EnumerationEntryEfImpl> _EnumerationEntries;


public static event PropertyListChangedHandler<Kistl.App.Base.Enumeration> OnEnumerationEntries_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.Enumeration> OnEnumerationEntries_IsValid;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataType_Enumeration")]
        public override System.Type GetDataType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_Enumeration != null)
            {
                OnGetDataType_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
        public static event GetDataType_Handler<Enumeration> OnGetDataType_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetDataType_Enumeration_CanExec;

        [EventBasedMethod("OnGetDataType_Enumeration_CanExec")]
        public override bool GetDataTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDataType_Enumeration_CanExec != null)
				{
					OnGetDataType_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetDataType_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetDataType_Enumeration_CanExecReason")]
        public override string GetDataTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDataType_Enumeration_CanExecReason != null)
				{
					OnGetDataType_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataTypeString_Enumeration")]
        public override string GetDataTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_Enumeration != null)
            {
                OnGetDataTypeString_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
        public static event GetDataTypeString_Handler<Enumeration> OnGetDataTypeString_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetDataTypeString_Enumeration_CanExec;

        [EventBasedMethod("OnGetDataTypeString_Enumeration_CanExec")]
        public override bool GetDataTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDataTypeString_Enumeration_CanExec != null)
				{
					OnGetDataTypeString_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetDataTypeString_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetDataTypeString_Enumeration_CanExecReason")]
        public override string GetDataTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDataTypeString_Enumeration_CanExecReason != null)
				{
					OnGetDataTypeString_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDataTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetEntryByName_Enumeration")]
        public virtual Kistl.App.Base.EnumerationEntry GetEntryByName(string name)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry>();
            if (OnGetEntryByName_Enumeration != null)
            {
                OnGetEntryByName_Enumeration(this, e, name);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetEntryByName");
            }
            return e.Result;
        }
        public delegate void GetEntryByName_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry> ret, string name);
        public static event GetEntryByName_Handler<Enumeration> OnGetEntryByName_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetEntryByName_Enumeration_CanExec;

        [EventBasedMethod("OnGetEntryByName_Enumeration_CanExec")]
        public virtual bool GetEntryByNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetEntryByName_Enumeration_CanExec != null)
				{
					OnGetEntryByName_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetEntryByName_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetEntryByName_Enumeration_CanExecReason")]
        public virtual string GetEntryByNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetEntryByName_Enumeration_CanExecReason != null)
				{
					OnGetEntryByName_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetEntryByValue_Enumeration")]
        public virtual Kistl.App.Base.EnumerationEntry GetEntryByValue(int val)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry>();
            if (OnGetEntryByValue_Enumeration != null)
            {
                OnGetEntryByValue_Enumeration(this, e, val);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetEntryByValue");
            }
            return e.Result;
        }
        public delegate void GetEntryByValue_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry> ret, int val);
        public static event GetEntryByValue_Handler<Enumeration> OnGetEntryByValue_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetEntryByValue_Enumeration_CanExec;

        [EventBasedMethod("OnGetEntryByValue_Enumeration_CanExec")]
        public virtual bool GetEntryByValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetEntryByValue_Enumeration_CanExec != null)
				{
					OnGetEntryByValue_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetEntryByValue_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetEntryByValue_Enumeration_CanExecReason")]
        public virtual string GetEntryByValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetEntryByValue_Enumeration_CanExecReason != null)
				{
					OnGetEntryByValue_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabelByName_Enumeration")]
        public virtual string GetLabelByName(string name)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabelByName_Enumeration != null)
            {
                OnGetLabelByName_Enumeration(this, e, name);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetLabelByName");
            }
            return e.Result;
        }
        public delegate void GetLabelByName_Handler<T>(T obj, MethodReturnEventArgs<string> ret, string name);
        public static event GetLabelByName_Handler<Enumeration> OnGetLabelByName_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetLabelByName_Enumeration_CanExec;

        [EventBasedMethod("OnGetLabelByName_Enumeration_CanExec")]
        public virtual bool GetLabelByNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabelByName_Enumeration_CanExec != null)
				{
					OnGetLabelByName_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetLabelByName_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetLabelByName_Enumeration_CanExecReason")]
        public virtual string GetLabelByNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabelByName_Enumeration_CanExecReason != null)
				{
					OnGetLabelByName_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabelByValue_Enumeration")]
        public virtual string GetLabelByValue(int val)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabelByValue_Enumeration != null)
            {
                OnGetLabelByValue_Enumeration(this, e, val);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetLabelByValue");
            }
            return e.Result;
        }
        public delegate void GetLabelByValue_Handler<T>(T obj, MethodReturnEventArgs<string> ret, int val);
        public static event GetLabelByValue_Handler<Enumeration> OnGetLabelByValue_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnGetLabelByValue_Enumeration_CanExec;

        [EventBasedMethod("OnGetLabelByValue_Enumeration_CanExec")]
        public virtual bool GetLabelByValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabelByValue_Enumeration_CanExec != null)
				{
					OnGetLabelByValue_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnGetLabelByValue_Enumeration_CanExecReason;

        [EventBasedMethod("OnGetLabelByValue_Enumeration_CanExecReason")]
        public virtual string GetLabelByValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabelByValue_Enumeration_CanExecReason != null)
				{
					OnGetLabelByValue_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Implements all available interfaces as Properties and Methods
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnImplementInterfaces_Enumeration")]
        public override void ImplementInterfaces()
        {
            // base.ImplementInterfaces();
            if (OnImplementInterfaces_Enumeration != null)
            {
                OnImplementInterfaces_Enumeration(this);
            }
            else
            {
                base.ImplementInterfaces();
            }
        }
        public static event ImplementInterfaces_Handler<Enumeration> OnImplementInterfaces_Enumeration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Enumeration> OnImplementInterfaces_Enumeration_CanExec;

        [EventBasedMethod("OnImplementInterfaces_Enumeration_CanExec")]
        public override bool ImplementInterfacesCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnImplementInterfaces_Enumeration_CanExec != null)
				{
					OnImplementInterfaces_Enumeration_CanExec(this, e);
				}
				else
				{
					e.Result = base.ImplementInterfacesCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Enumeration> OnImplementInterfaces_Enumeration_CanExecReason;

        [EventBasedMethod("OnImplementInterfaces_Enumeration_CanExecReason")]
        public override string ImplementInterfacesCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnImplementInterfaces_Enumeration_CanExecReason != null)
				{
					OnImplementInterfaces_Enumeration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.ImplementInterfacesCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(Enumeration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Enumeration)obj;
            var otherImpl = (EnumerationEfImpl)obj;
            var me = (Enumeration)this;

            me.AreFlags = other.AreFlags;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
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
                    new PropertyDescriptorEfImpl<Enumeration, bool>(
                        lazyCtx,
                        new Guid("1ef92eea-d8b3-4f95-a694-9ca09ceff0e5"),
                        "AreFlags",
                        null,
                        obj => obj.AreFlags,
                        (obj, val) => obj.AreFlags = val,
						obj => OnAreFlags_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<Enumeration, IList<Kistl.App.Base.EnumerationEntry>>(
                        lazyCtx,
                        new Guid("1619c8a7-b969-4c05-851c-7a2545cda484"),
                        "EnumerationEntries",
                        null,
                        obj => obj.EnumerationEntries,
                        null, // lists are read-only properties
                        obj => OnEnumerationEntries_IsValid), 
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
        [EventBasedMethod("OnToString_Enumeration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Enumeration != null)
            {
                OnToString_Enumeration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Enumeration> OnToString_Enumeration;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Enumeration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Enumeration != null)
            {
                OnObjectIsValid_Enumeration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Enumeration> OnObjectIsValid_Enumeration;

        [EventBasedMethod("OnNotifyPreSave_Enumeration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Enumeration != null) OnNotifyPreSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnNotifyPreSave_Enumeration;

        [EventBasedMethod("OnNotifyPostSave_Enumeration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Enumeration != null) OnNotifyPostSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnNotifyPostSave_Enumeration;

        [EventBasedMethod("OnNotifyCreated_Enumeration")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("AreFlags");
            base.NotifyCreated();
            if (OnNotifyCreated_Enumeration != null) OnNotifyCreated_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnNotifyCreated_Enumeration;

        [EventBasedMethod("OnNotifyDeleting_Enumeration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Enumeration != null) OnNotifyDeleting_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnNotifyDeleting_Enumeration;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._AreFlags, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._AreFlags, binStream);
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
            XmlStreamer.ToStream(this._AreFlags, xml, "AreFlags", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._AreFlags, xml, "AreFlags", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._AreFlags, xml, "AreFlags", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._AreFlags, xml, "AreFlags", "Kistl.App.Base");
        }

        #endregion

    }
}