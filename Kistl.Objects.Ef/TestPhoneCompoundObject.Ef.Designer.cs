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
    /// 
    /// </summary>
    [EdmComplexType(NamespaceName="Model", Name="TestPhoneCompoundObject")]
    [System.Diagnostics.DebuggerDisplay("TestPhoneCompoundObject")]
    public class TestPhoneCompoundObjectEfImpl : BaseServerCompoundObject_EntityFramework, ICompoundObject, TestPhoneCompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("2510af08-089f-4252-8a98-ec84cb67bcb9");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        public TestPhoneCompoundObjectEfImpl()
            : base(null) // TODO: pass parent's lazyCtx
        {
            CompoundObject_IsNull = false;

        }
        public TestPhoneCompoundObjectEfImpl(bool isNull, IPersistenceObject parent, string property)
            : base(null) // TODO: pass parent's lazyCtx
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        public TestPhoneCompoundObjectEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
            CompoundObject_IsNull = false;

        }
        public TestPhoneCompoundObjectEfImpl(Func<IFrozenContext> lazyCtx, bool isNull, IPersistenceObject parent, string property)
            : base(lazyCtx)
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        [EdmScalarProperty(IsNullable = false)]
        public bool CompoundObject_IsNull { get; set; }

        /// <summary>
        /// Enter Area Code
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string AreaCode
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _AreaCode;
                if (OnAreaCode_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnAreaCode_Getter(this, __e);
                    __result = _AreaCode = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_AreaCode != value)
                {
                    var __oldValue = _AreaCode;
                    var __newValue = value;
                    if (OnAreaCode_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnAreaCode_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("AreaCode", __oldValue, __newValue);
                    _AreaCode = __newValue;
                    NotifyPropertyChanged("AreaCode", __oldValue, __newValue);

                    if (OnAreaCode_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnAreaCode_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("AreaCode");
				}
            }
        }
        private string _AreaCode;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnAreaCode_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnAreaCode_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnAreaCode_PostSetter;

        /// <summary>
        /// Enter a Number
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Number
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Number;
                if (OnNumber_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNumber_Getter(this, __e);
                    __result = _Number = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Number != value)
                {
                    var __oldValue = _Number;
                    var __newValue = value;
                    if (OnNumber_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNumber_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Number", __oldValue, __newValue);
                    _Number = __newValue;
                    NotifyPropertyChanged("Number", __oldValue, __newValue);

                    if (OnNumber_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNumber_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Number");
				}
            }
        }
        private string _Number;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnNumber_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnNumber_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestPhoneCompoundObject, string> OnNumber_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(TestPhoneCompoundObject);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestPhoneCompoundObject)obj;
            var otherImpl = (TestPhoneCompoundObjectEfImpl)obj;
            var me = (TestPhoneCompoundObject)this;

            me.AreaCode = other.AreaCode;
            me.Number = other.Number;
        }
        #region Kistl.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestPhoneCompoundObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestPhoneCompoundObject != null)
            {
                OnToString_TestPhoneCompoundObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestPhoneCompoundObject> OnToString_TestPhoneCompoundObject;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TestPhoneCompoundObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TestPhoneCompoundObject != null)
            {
                OnObjectIsValid_TestPhoneCompoundObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TestPhoneCompoundObject> OnObjectIsValid_TestPhoneCompoundObject;

        #endregion // Kistl.Generator.Templates.CompoundObjects.DefaultMethods

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._AreaCode);
            binStream.Write(this._Number);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            binStream.Read(out this._AreaCode);
            binStream.Read(out this._Number);
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
            XmlStreamer.ToStream(this._AreaCode, xml, "AreaCode", "Kistl.App.Test");
            XmlStreamer.ToStream(this._Number, xml, "Number", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._AreaCode, xml, "AreaCode", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._Number, xml, "Number", "Kistl.App.Test");
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