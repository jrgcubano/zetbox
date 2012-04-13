// <autogenerated/>

namespace Kistl.App.Test
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
    /// Test class for methods
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="MethodTest")]
    [System.Diagnostics.DebuggerDisplay("MethodTest")]
    public class MethodTestEfImpl : BaseServerDataObject_EntityFramework, MethodTest
    {
        private static readonly Guid _objectClassID = new Guid("68a664ee-67e0-4ba7-a0dc-148b9dfa32a7");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public MethodTestEfImpl()
            : base(null)
        {
        }

        public MethodTestEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Parent_has_Children
    A: ZeroOrOne MethodTest as Parent
    B: ZeroOrMore MethodTest as Children
    Preferred Storage: MergeIntoB
    */
        // object list property
        // object list property
           // Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.MethodTest> Children
        {
            get
            {
                if (_Children == null)
                {
                    _Children = new EntityCollectionWrapper<Kistl.App.Test.MethodTest, Kistl.App.Test.MethodTestEfImpl>(
                            this.Context, ChildrenImpl,
                            () => this.NotifyPropertyChanging("Children", null, null, null),
                            () => { this.NotifyPropertyChanged("Children", null, null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); },
                            (item) => item.NotifyPropertyChanging("Parent", null, null, null),
                            (item) => item.NotifyPropertyChanged("Parent", null, null, null));
                }
                return _Children;
            }
        }
    
        [EdmRelationshipNavigationProperty("Model", "FK_Parent_has_Children", "Children")]
        public EntityCollection<Kistl.App.Test.MethodTestEfImpl> ChildrenImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.MethodTestEfImpl>(
                        "Model.FK_Parent_has_Children",
                        "Children");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Test.MethodTest, Kistl.App.Test.MethodTestEfImpl> _Children;


public static event PropertyListChangedHandler<Kistl.App.Test.MethodTest> OnChildren_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.MethodTest> OnChildren_IsValid;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Parent_has_Children
    A: ZeroOrOne MethodTest as Parent
    B: ZeroOrMore MethodTest as Children
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=_fk_Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Kistl.App.Test.MethodTest; moduleNamespace=Kistl.App.Test;
        // inverse Navigator=Children; is list;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.MethodTest Parent
        {
            get { return ParentImpl; }
            set { ParentImpl = (Kistl.App.Test.MethodTestEfImpl)value; }
        }

        private int? _fk_Parent;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Parent_has_Children", "Parent")]
        public Kistl.App.Test.MethodTestEfImpl ParentImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Test.MethodTestEfImpl __value;
                EntityReference<Kistl.App.Test.MethodTestEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.MethodTestEfImpl>(
                        "Model.FK_Parent_has_Children",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Test.MethodTest>(__value);
                    OnParent_Getter(this, e);
                    __value = (Kistl.App.Test.MethodTestEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Test.MethodTestEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.MethodTestEfImpl>(
                        "Model.FK_Parent_has_Children",
                        "Parent");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Test.MethodTestEfImpl __oldValue = (Kistl.App.Test.MethodTestEfImpl)r.Value;
                Kistl.App.Test.MethodTestEfImpl __newValue = (Kistl.App.Test.MethodTestEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Children", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Children", null, null, null);
                }

                if (OnParent_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Test.MethodTest>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Kistl.App.Test.MethodTestEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Test.MethodTestEfImpl)__newValue;

                if (OnParent_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Test.MethodTest>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Parent", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("Children", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("Children", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Kistl.App.Test.MethodTest, Kistl.App.Test.MethodTest> OnParent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.MethodTest, Kistl.App.Test.MethodTest> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.MethodTest, Kistl.App.Test.MethodTest> OnParent_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.MethodTest> OnParent_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string StringProp
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _StringProp;
                if (OnStringProp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnStringProp_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_StringProp != value)
                {
                    var __oldValue = _StringProp;
                    var __newValue = value;
                    if (OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    _StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);

                    if (OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("StringProp");
				}
            }
        }
        private string _StringProp;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.MethodTest, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.MethodTest, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.MethodTest, string> OnStringProp_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.MethodTest> OnStringProp_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGroup1_MethodTest")]
        public virtual void Group1()
        {
            // base.Group1();
            if (OnGroup1_MethodTest != null)
            {
                OnGroup1_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Group1");
            }
        }
        public delegate void Group1_Handler<T>(T obj);
        public static event Group1_Handler<MethodTest> OnGroup1_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnGroup1_MethodTest_CanExec;

        [EventBasedMethod("OnGroup1_MethodTest_CanExec")]
        public virtual bool Group1CanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGroup1_MethodTest_CanExec != null)
				{
					OnGroup1_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnGroup1_MethodTest_CanExecReason;

        [EventBasedMethod("OnGroup1_MethodTest_CanExecReason")]
        public virtual string Group1CanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGroup1_MethodTest_CanExecReason != null)
				{
					OnGroup1_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnGroup2_MethodTest")]
        public virtual void Group2()
        {
            // base.Group2();
            if (OnGroup2_MethodTest != null)
            {
                OnGroup2_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Group2");
            }
        }
        public delegate void Group2_Handler<T>(T obj);
        public static event Group2_Handler<MethodTest> OnGroup2_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnGroup2_MethodTest_CanExec;

        [EventBasedMethod("OnGroup2_MethodTest_CanExec")]
        public virtual bool Group2CanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGroup2_MethodTest_CanExec != null)
				{
					OnGroup2_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnGroup2_MethodTest_CanExecReason;

        [EventBasedMethod("OnGroup2_MethodTest_CanExecReason")]
        public virtual string Group2CanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGroup2_MethodTest_CanExecReason != null)
				{
					OnGroup2_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnObjParameter_MethodTest")]
        public virtual void ObjParameter(Kistl.App.Test.MethodTest objParam)
        {
            // base.ObjParameter();
            if (OnObjParameter_MethodTest != null)
            {
                OnObjParameter_MethodTest(this, objParam);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.ObjParameter");
            }
        }
        public delegate void ObjParameter_Handler<T>(T obj, Kistl.App.Test.MethodTest objParam);
        public static event ObjParameter_Handler<MethodTest> OnObjParameter_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnObjParameter_MethodTest_CanExec;

        [EventBasedMethod("OnObjParameter_MethodTest_CanExec")]
        public virtual bool ObjParameterCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnObjParameter_MethodTest_CanExec != null)
				{
					OnObjParameter_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnObjParameter_MethodTest_CanExecReason;

        [EventBasedMethod("OnObjParameter_MethodTest_CanExecReason")]
        public virtual string ObjParameterCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnObjParameter_MethodTest_CanExecReason != null)
				{
					OnObjParameter_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnObjRet_MethodTest")]
        public virtual Kistl.App.Test.MethodTest ObjRet()
        {
            var e = new MethodReturnEventArgs<Kistl.App.Test.MethodTest>();
            if (OnObjRet_MethodTest != null)
            {
                OnObjRet_MethodTest(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on MethodTest.ObjRet");
            }
            return e.Result;
        }
        public delegate void ObjRet_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Test.MethodTest> ret);
        public static event ObjRet_Handler<MethodTest> OnObjRet_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnObjRet_MethodTest_CanExec;

        [EventBasedMethod("OnObjRet_MethodTest_CanExec")]
        public virtual bool ObjRetCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnObjRet_MethodTest_CanExec != null)
				{
					OnObjRet_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnObjRet_MethodTest_CanExecReason;

        [EventBasedMethod("OnObjRet_MethodTest_CanExecReason")]
        public virtual string ObjRetCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnObjRet_MethodTest_CanExecReason != null)
				{
					OnObjRet_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnParameterless_MethodTest")]
        public virtual void Parameterless()
        {
            // base.Parameterless();
            if (OnParameterless_MethodTest != null)
            {
                OnParameterless_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Parameterless");
            }
        }
        public delegate void Parameterless_Handler<T>(T obj);
        public static event Parameterless_Handler<MethodTest> OnParameterless_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnParameterless_MethodTest_CanExec;

        [EventBasedMethod("OnParameterless_MethodTest_CanExec")]
        public virtual bool ParameterlessCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnParameterless_MethodTest_CanExec != null)
				{
					OnParameterless_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnParameterless_MethodTest_CanExecReason;

        [EventBasedMethod("OnParameterless_MethodTest_CanExecReason")]
        public virtual string ParameterlessCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnParameterless_MethodTest_CanExecReason != null)
				{
					OnParameterless_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnStringParameter_MethodTest")]
        public virtual void StringParameter(string str)
        {
            // base.StringParameter();
            if (OnStringParameter_MethodTest != null)
            {
                OnStringParameter_MethodTest(this, str);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.StringParameter");
            }
        }
        public delegate void StringParameter_Handler<T>(T obj, string str);
        public static event StringParameter_Handler<MethodTest> OnStringParameter_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnStringParameter_MethodTest_CanExec;

        [EventBasedMethod("OnStringParameter_MethodTest_CanExec")]
        public virtual bool StringParameterCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnStringParameter_MethodTest_CanExec != null)
				{
					OnStringParameter_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnStringParameter_MethodTest_CanExecReason;

        [EventBasedMethod("OnStringParameter_MethodTest_CanExecReason")]
        public virtual string StringParameterCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnStringParameter_MethodTest_CanExecReason != null)
				{
					OnStringParameter_MethodTest_CanExecReason(this, e);
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
        [EventBasedMethod("OnSummary_MethodTest")]
        public virtual void Summary()
        {
            // base.Summary();
            if (OnSummary_MethodTest != null)
            {
                OnSummary_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Summary");
            }
        }
        public delegate void Summary_Handler<T>(T obj);
        public static event Summary_Handler<MethodTest> OnSummary_MethodTest;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnSummary_MethodTest_CanExec;

        [EventBasedMethod("OnSummary_MethodTest_CanExec")]
        public virtual bool SummaryCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnSummary_MethodTest_CanExec != null)
				{
					OnSummary_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnSummary_MethodTest_CanExecReason;

        [EventBasedMethod("OnSummary_MethodTest_CanExecReason")]
        public virtual string SummaryCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnSummary_MethodTest_CanExecReason != null)
				{
					OnSummary_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(MethodTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (MethodTest)obj;
            var otherImpl = (MethodTestEfImpl)obj;
            var me = (MethodTest)this;

            me.StringProp = other.StringProp;
            this._fk_Parent = otherImpl._fk_Parent;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "StringProp":
                case "Parent":
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

            if (_fk_Parent.HasValue)
                ParentImpl = (Kistl.App.Test.MethodTestEfImpl)Context.Find<Kistl.App.Test.MethodTest>(_fk_Parent.Value);
            else
                ParentImpl = null;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<MethodTest, ICollection<Kistl.App.Test.MethodTest>>(
                        lazyCtx,
                        new Guid("bf48b883-8821-4c4e-8509-590a72604f9e"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null, // lists are read-only properties
                        obj => OnChildren_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<MethodTest, Kistl.App.Test.MethodTest>(
                        lazyCtx,
                        new Guid("02a7d534-9325-48e5-bbc2-b61420afd940"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val,
						obj => OnParent_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<MethodTest, string>(
                        lazyCtx,
                        new Guid("8d226658-fecc-4139-8234-aa88a4738b4d"),
                        "StringProp",
                        null,
                        obj => obj.StringProp,
                        (obj, val) => obj.StringProp = val,
						obj => OnStringProp_IsValid), 
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
        [EventBasedMethod("OnToString_MethodTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MethodTest != null)
            {
                OnToString_MethodTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<MethodTest> OnToString_MethodTest;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_MethodTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_MethodTest != null)
            {
                OnObjectIsValid_MethodTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<MethodTest> OnObjectIsValid_MethodTest;

        [EventBasedMethod("OnNotifyPreSave_MethodTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_MethodTest != null) OnNotifyPreSave_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyPreSave_MethodTest;

        [EventBasedMethod("OnNotifyPostSave_MethodTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_MethodTest != null) OnNotifyPostSave_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyPostSave_MethodTest;

        [EventBasedMethod("OnNotifyCreated_MethodTest")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Parent");
            SetNotInitializedProperty("StringProp");
            base.NotifyCreated();
            if (OnNotifyCreated_MethodTest != null) OnNotifyCreated_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyCreated_MethodTest;

        [EventBasedMethod("OnNotifyDeleting_MethodTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_MethodTest != null) OnNotifyDeleting_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyDeleting_MethodTest;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);

                }
				else 
				{
					SetInitializedProperty("ID");
				}
            }
        }
        private int _ID;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Test.MethodTestEfImpl>("Model.FK_Parent_has_Children", "Parent").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
            BinarySerializer.ToStream(this._StringProp, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
            BinarySerializer.FromStream(out this._StringProp, binStream);
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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Test.MethodTestEfImpl>("Model.FK_Parent_has_Children", "Parent").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Parent", "Kistl.App.Test");
            }
            XmlStreamer.ToStream(this._StringProp, xml, "StringProp", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._StringProp, xml, "StringProp", "Kistl.App.Test");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}