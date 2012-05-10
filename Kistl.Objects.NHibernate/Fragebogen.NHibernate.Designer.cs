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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Fragebogen")]
    public class FragebogenNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, Fragebogen
    {
        private static readonly Guid _objectClassID = new Guid("a78ff235-4511-431b-8437-939f7fecded4");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public FragebogenNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public FragebogenNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new FragebogenProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public FragebogenNHibernateImpl(Func<IFrozenContext> lazyCtx, FragebogenProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly FragebogenProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // object list property

        // Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Test.Antwort> Antworten
        {
            get
            {
                if (_Antworten == null)
                {
                    _Antworten = new OneNRelationList<Kistl.App.Test.Antwort>(
                        "Fragebogen",
                        "gute_Antworten_pos",
                        this,
                        () => this.NotifyPropertyChanging("Antworten", null, null),
                        () => { this.NotifyPropertyChanged("Antworten", null, null); if(OnAntworten_PostSetter != null && IsAttached) OnAntworten_PostSetter(this); },
                        new ProjectedCollection<Kistl.App.Test.AntwortNHibernateImpl.AntwortProxy, Kistl.App.Test.Antwort>(
                            () => Proxy.Antworten,
                            p => (Kistl.App.Test.Antwort)OurContext.AttachAndWrap(p),
                            d => (Kistl.App.Test.AntwortNHibernateImpl.AntwortProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _Antworten;
            }
        }
    
        private OneNRelationList<Kistl.App.Test.Antwort> _Antworten;
        private List<int> AntwortenIds;
        private bool Antworten_was_eagerLoaded = false;
public static event PropertyListChangedHandler<Kistl.App.Test.Fragebogen> OnAntworten_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.Fragebogen> OnAntworten_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? BogenNummer
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.BogenNummer;
                if (OnBogenNummer_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnBogenNummer_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.BogenNummer != value)
                {
                    var __oldValue = Proxy.BogenNummer;
                    var __newValue = value;
                    if (OnBogenNummer_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnBogenNummer_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BogenNummer", __oldValue, __newValue);
                    Proxy.BogenNummer = __newValue;
                    NotifyPropertyChanged("BogenNummer", __oldValue, __newValue);

                    if (OnBogenNummer_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnBogenNummer_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("BogenNummer");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.Fragebogen> OnBogenNummer_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Test.TestStudent> Student
		{
			get
			{
				if (_Student == null)
				{
					_Student 
						= new NHibernateASideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl.TestStudent_füllt_aus_Fragebogen_RelationEntryProxy, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl>(
                                () => this.Proxy.Student,
                                p => (Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl.TestStudent_füllt_aus_Fragebogen_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl>)entry.A.Testbogen);
                    if (Student_was_eagerLoaded) { Student_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.Test.TestStudent>)_Student;
			}
		}

		private NHibernateASideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl> _Student;
		// ignored, but required for Serialization
        private bool Student_was_eagerLoaded = false;

        public static event PropertyIsValidHandler<Kistl.App.Test.Fragebogen> OnStudent_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Fragebogen);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Fragebogen)obj;
            var otherImpl = (FragebogenNHibernateImpl)obj;
            var me = (Fragebogen)this;

            me.BogenNummer = other.BogenNummer;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "BogenNummer":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Antworten":
                case "Student":
                    return false;
                default:
                    return base.ShouldSetModified(property);
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
                    new PropertyDescriptorNHibernateImpl<Fragebogen, IList<Kistl.App.Test.Antwort>>(
                        lazyCtx,
                        new Guid("e8f20c02-abea-4c91-850f-c321adfd46f0"),
                        "Antworten",
                        null,
                        obj => obj.Antworten,
                        null, // lists are read-only properties
                        obj => OnAntworten_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Fragebogen, int?>(
                        lazyCtx,
                        new Guid("b65f1a91-e063-4054-a2e7-d5dc0292e3fc"),
                        "BogenNummer",
                        null,
                        obj => obj.BogenNummer,
                        (obj, val) => obj.BogenNummer = val,
						obj => OnBogenNummer_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<Fragebogen, ICollection<Kistl.App.Test.TestStudent>>(
                        lazyCtx,
                        new Guid("3a91e745-0dd2-4f31-864e-eaf657ddb577"),
                        "Student",
                        null,
                        obj => obj.Student,
                        null, // lists are read-only properties
                        obj => OnStudent_IsValid), 
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Fragebogen")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Fragebogen != null)
            {
                OnToString_Fragebogen(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Fragebogen> OnToString_Fragebogen;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Fragebogen")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Fragebogen != null)
            {
                OnObjectIsValid_Fragebogen(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Fragebogen> OnObjectIsValid_Fragebogen;

        [EventBasedMethod("OnNotifyPreSave_Fragebogen")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Fragebogen != null) OnNotifyPreSave_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnNotifyPreSave_Fragebogen;

        [EventBasedMethod("OnNotifyPostSave_Fragebogen")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Fragebogen != null) OnNotifyPostSave_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnNotifyPostSave_Fragebogen;

        [EventBasedMethod("OnNotifyCreated_Fragebogen")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("BogenNummer");
            base.NotifyCreated();
            if (OnNotifyCreated_Fragebogen != null) OnNotifyCreated_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnNotifyCreated_Fragebogen;

        [EventBasedMethod("OnNotifyDeleting_Fragebogen")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Fragebogen != null) OnNotifyDeleting_Fragebogen(this);

            // FK_Ein_Fragebogen_enthaelt_gute_Antworten ZeroOrMore
            foreach(NHibernatePersistenceObject x in Antworten) {
                x.ParentsToDelete.Add(this);
                ChildrenToDelete.Add(x);
            }

            Antworten.Clear();
            Student.Clear();
        }
        public static event ObjectEventHandler<Fragebogen> OnNotifyDeleting_Fragebogen;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class FragebogenProxy
            : IProxyObject, ISortKey<int>
        {
            public FragebogenProxy()
            {
                Antworten = new Collection<Kistl.App.Test.AntwortNHibernateImpl.AntwortProxy>();
                Student = new Collection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl.TestStudent_füllt_aus_Fragebogen_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(FragebogenNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(FragebogenProxy); } }

            public virtual ICollection<Kistl.App.Test.AntwortNHibernateImpl.AntwortProxy> Antworten { get; set; }

            public virtual int? BogenNummer { get; set; }

            public virtual ICollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryNHibernateImpl.TestStudent_füllt_aus_Fragebogen_RelationEntryProxy> Student { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;

            binStream.Write(eagerLoadLists);
            if (eagerLoadLists && auxObjects != null)
            {
                binStream.Write(true);
                binStream.Write(Antworten.Count);
                foreach(var obj in Antworten)
                {
                    auxObjects.Add(obj);
                    binStream.Write(obj.ID);
                }
            }
            else
            {
                binStream.Write(false);
            }
            binStream.Write(this.Proxy.BogenNummer);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {

            Antworten_was_eagerLoaded = binStream.ReadBoolean();
            {
                bool containsList = binStream.ReadBoolean();
                if (containsList)
                {
                    int numElements = binStream.ReadInt32();
                    AntwortenIds = new List<int>(numElements);
                    while (numElements-- > 0) 
                    {
                        int id = binStream.ReadInt32();
                        AntwortenIds.Add(id);
                    }
                }
            }
            this.Proxy.BogenNummer = binStream.ReadNullableInt32();
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