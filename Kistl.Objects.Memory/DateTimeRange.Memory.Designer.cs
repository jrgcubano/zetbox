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
    /// A from and until DateTime Value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeRange")]
    public class DateTimeRangeMemoryImpl : CompoundObjectDefaultImpl, DateTimeRange, ICompoundObject
    {
        [Obsolete]
        public DateTimeRangeMemoryImpl()
            : base(null)
        {
        }

        public DateTimeRangeMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }
        public DateTimeRangeMemoryImpl(IPersistenceObject parent, string property) : this(false, parent, property) {}
        public DateTimeRangeMemoryImpl(bool ignore, IPersistenceObject parent, string property)
            : base(null) // TODO: pass parent's lazyCtx
        {
            AttachToObject(parent, property);
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
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
				else 
				{
					SetInitializedProperty("From");
				}
            }
        }
        private DateTime? _From;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnFrom_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
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
				else 
				{
					SetInitializedProperty("Thru");
				}
            }
        }
        private DateTime? _Thru;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeRange, DateTime?> OnThru_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int? TotalDays
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TotalDays;
                if (_TotalDays_IsDirty && OnTotalDays_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnTotalDays_Getter(this, __e);
                    _TotalDays_IsDirty = false;
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TotalDays != value)
                {
                    var __oldValue = _TotalDays;
                    var __newValue = value;
                    NotifyPropertyChanging("TotalDays", __oldValue, __newValue);
                    _TotalDays = __newValue;
			        _TotalDays_IsDirty = false;
                    NotifyPropertyChanged("TotalDays", __oldValue, __newValue);
                }
				else 
				{
					SetInitializedProperty("TotalDays");
				}
            }
        }
        private int? _TotalDays;
        private bool _TotalDays_IsDirty = false;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeRange, int?> OnTotalDays_Getter;

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeRange);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeRange)obj;
            var otherImpl = (DateTimeRangeMemoryImpl)obj;
            var me = (DateTimeRange)this;

            me.From = other.From;
            me.Thru = other.Thru;
            this.TotalDays = otherImpl.TotalDays;
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
            BinarySerializer.ToStream(this._TotalDays, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._From, binStream);
            BinarySerializer.FromStream(out this._Thru, binStream);
            BinarySerializer.FromStream(out this._TotalDays, binStream);
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
            XmlStreamer.ToStream(this._TotalDays, xml, "TotalDays", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._From, xml, "From", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Thru, xml, "Thru", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._TotalDays, xml, "TotalDays", "Kistl.App.Base");
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