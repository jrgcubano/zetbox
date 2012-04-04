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
    [System.Diagnostics.DebuggerDisplay("IntegerRangeConstraint")]
    public class IntegerRangeConstraintMemoryImpl : Kistl.App.Base.ConstraintMemoryImpl, IntegerRangeConstraint
    {
        [Obsolete]
        public IntegerRangeConstraintMemoryImpl()
            : base(null)
        {
        }

        public IntegerRangeConstraintMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// The biggest value accepted by this constraint
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int Max
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Max;
                if (OnMax_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMax_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Max != value)
                {
                    var __oldValue = _Max;
                    var __newValue = value;
                    if (OnMax_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMax_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Max", __oldValue, __newValue);
                    _Max = __newValue;
                    NotifyPropertyChanged("Max", __oldValue, __newValue);

                    if (OnMax_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMax_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Max");
				}
            }
        }
        private int _Max;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.IntegerRangeConstraint> OnMax_IsValid;

        /// <summary>
        /// The smallest value accepted by this constraint
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int Min
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Min;
                if (OnMin_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMin_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Min != value)
                {
                    var __oldValue = _Min;
                    var __newValue = value;
                    if (OnMin_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMin_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Min", __oldValue, __newValue);
                    _Min = __newValue;
                    NotifyPropertyChanged("Min", __oldValue, __newValue);

                    if (OnMin_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMin_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Min");
				}
            }
        }
        private int _Min;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.IntegerRangeConstraint> OnMin_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IntegerRangeConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IntegerRangeConstraint != null)
            {
                OnGetErrorText_IntegerRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IntegerRangeConstraint> OnGetErrorText_IntegerRangeConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IntegerRangeConstraint> OnGetErrorText_IntegerRangeConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_IntegerRangeConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_IntegerRangeConstraint_CanExec != null)
				{
					OnGetErrorText_IntegerRangeConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IntegerRangeConstraint> OnGetErrorText_IntegerRangeConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_IntegerRangeConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_IntegerRangeConstraint_CanExecReason != null)
				{
					OnGetErrorText_IntegerRangeConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_IntegerRangeConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IntegerRangeConstraint != null)
            {
                OnIsValid_IntegerRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IntegerRangeConstraint> OnIsValid_IntegerRangeConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IntegerRangeConstraint> OnIsValid_IntegerRangeConstraint_CanExec;

        [EventBasedMethod("OnIsValid_IntegerRangeConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_IntegerRangeConstraint_CanExec != null)
				{
					OnIsValid_IntegerRangeConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IntegerRangeConstraint> OnIsValid_IntegerRangeConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_IntegerRangeConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_IntegerRangeConstraint_CanExecReason != null)
				{
					OnIsValid_IntegerRangeConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(IntegerRangeConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IntegerRangeConstraint)obj;
            var otherImpl = (IntegerRangeConstraintMemoryImpl)obj;
            var me = (IntegerRangeConstraint)this;

            me.Max = other.Max;
            me.Min = other.Min;
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
                    new PropertyDescriptorMemoryImpl<IntegerRangeConstraint, int>(
                        lazyCtx,
                        new Guid("dff43695-5b93-4378-a01d-94a82d29dcef"),
                        "Max",
                        null,
                        obj => obj.Max,
                        (obj, val) => obj.Max = val,
						obj => OnMax_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<IntegerRangeConstraint, int>(
                        lazyCtx,
                        new Guid("8afdbf66-c979-4c09-8872-1a44aa1dbf72"),
                        "Min",
                        null,
                        obj => obj.Min,
                        (obj, val) => obj.Min = val,
						obj => OnMin_IsValid), 
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
        [EventBasedMethod("OnToString_IntegerRangeConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntegerRangeConstraint != null)
            {
                OnToString_IntegerRangeConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IntegerRangeConstraint> OnToString_IntegerRangeConstraint;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_IntegerRangeConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_IntegerRangeConstraint != null)
            {
                OnObjectIsValid_IntegerRangeConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<IntegerRangeConstraint> OnObjectIsValid_IntegerRangeConstraint;

        [EventBasedMethod("OnNotifyPreSave_IntegerRangeConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_IntegerRangeConstraint != null) OnNotifyPreSave_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnNotifyPreSave_IntegerRangeConstraint;

        [EventBasedMethod("OnNotifyPostSave_IntegerRangeConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_IntegerRangeConstraint != null) OnNotifyPostSave_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnNotifyPostSave_IntegerRangeConstraint;

        [EventBasedMethod("OnNotifyCreated_IntegerRangeConstraint")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Max");
            SetNotInitializedProperty("Min");
            base.NotifyCreated();
            if (OnNotifyCreated_IntegerRangeConstraint != null) OnNotifyCreated_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnNotifyCreated_IntegerRangeConstraint;

        [EventBasedMethod("OnNotifyDeleting_IntegerRangeConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_IntegerRangeConstraint != null) OnNotifyDeleting_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnNotifyDeleting_IntegerRangeConstraint;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._Max, binStream);
            BinarySerializer.ToStream(this._Min, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._Max, binStream);
            BinarySerializer.FromStream(out this._Min, binStream);
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
            XmlStreamer.ToStream(this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Min, xml, "Min", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Min, xml, "Min", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Max, xml, "Max", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Min, xml, "Min", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Min, xml, "Min", "Kistl.App.Base");
        }

        #endregion

    }
}