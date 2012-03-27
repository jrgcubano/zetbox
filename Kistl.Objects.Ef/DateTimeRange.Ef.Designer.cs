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
    /// A from and until DateTime Value
    /// </summary>
    [EdmComplexType(NamespaceName="Model", Name="DateTimeRange")]
    [System.Diagnostics.DebuggerDisplay("DateTimeRange")]
    public class DateTimeRangeEfImpl : BaseServerCompoundObject_EntityFramework, DateTimeRange, ICompoundObject
    {
        public DateTimeRangeEfImpl()
            : base(null) // TODO: pass parent's lazyCtx
        {
            CompoundObject_IsNull = false;

        }
        public DateTimeRangeEfImpl(bool isNull, IPersistenceObject parent, string property)
            : base(null) // TODO: pass parent's lazyCtx
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        public DateTimeRangeEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
            CompoundObject_IsNull = false;

        }
        public DateTimeRangeEfImpl(Func<IFrozenContext> lazyCtx, bool isNull, IPersistenceObject parent, string property)
            : base(lazyCtx)
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        [EdmScalarProperty(IsNullable = false)]
        public bool CompoundObject_IsNull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public DateTime? From
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(DateTime?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _From;
                if (OnFrom_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnFrom_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_From != value)
                {
                    var __oldValue = _From;
                    var __newValue = value;
                    if (OnFrom_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnFrom_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("From", __oldValue, __newValue);
                    _From = __newValue;
                    NotifyPropertyChanged("From", __oldValue, __newValue);
                    if (OnFrom_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnFrom_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _From;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public DateTime? Thru
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(DateTime?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Thru;
                if (OnThru_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnThru_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Thru != value)
                {
                    var __oldValue = _Thru;
                    var __newValue = value;
                    if (OnThru_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Thru", __oldValue, __newValue);
                    _Thru = __newValue;
                    NotifyPropertyChanged("Thru", __oldValue, __newValue);
                    if (OnThru_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _Thru;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // calculated  property
        // BEGIN Kistl.Generator.Templates.Properties.CalculatedProperty
        public int? TotalDays
        {
            get
            {
                if (OnTotalDays_Getter == null)
                {
                    throw new NotImplementedException("No handler registered on calculated property Kistl.App.Base.DateTimeRange.TotalDays");
                }
                var e = new PropertyGetterEventArgs<int?>(default(int?));                OnTotalDays_Getter(this, e);                return e.Result;            }
        }
        private bool TotalDays_IsDirty = true;
        // END Kistl.Generator.Templates.Properties.CalculatedProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, int?> OnTotalDays_Getter;

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeRange);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeRange)obj;
            var otherImpl = (DateTimeRangeEfImpl)obj;
            var me = (DateTimeRange)this;

            me.From = other.From;
            me.Thru = other.Thru;
        }
        #region Kistl.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DateTimeRange")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeRange != null)
            {
                OnToString_DateTimeRange(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateTimeRange> OnToString_DateTimeRange;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DateTimeRange")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DateTimeRange != null)
            {
                OnObjectIsValid_DateTimeRange(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DateTimeRange> OnObjectIsValid_DateTimeRange;

        #endregion // Kistl.Generator.Templates.CompoundObjects.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._From, binStream);
            BinarySerializer.ToStream(this._Thru, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._From, binStream);
            BinarySerializer.FromStream(out this._Thru, binStream);
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
            XmlStreamer.ToStream(this._From, xml, "From", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Thru, xml, "Thru", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._From, xml, "From", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Thru, xml, "Thru", "Kistl.App.Base");
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