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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Represents an Identity
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Identity")]
    [System.Diagnostics.DebuggerDisplay("Identity")]
    public class Identity__Implementation__ : BaseServerDataObject_EntityFramework, Identity
    {
    
		public Identity__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
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
            }
        }
        private int _ID;

        /// <summary>
        /// Displayname of this identity
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string DisplayName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayName != value)
                {
                    var __oldValue = _DisplayName;
                    var __newValue = value;
                    if(OnDisplayName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    _DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);
                    if(OnDisplayName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _DisplayName;
		public static event PropertyGetterHandler<Kistl.App.Base.Identity, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Identity, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Identity, string> OnDisplayName_PostSetter;

        /// <summary>
        /// Identites are member of groups
        /// </summary>
    /*
    Relation: FK_Identities_memberOf_Groups
    A: ZeroOrMore Identity as Identities
    B: ZeroOrMore Group as Groups
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Group> Groups
        {
            get
            {
                if (_GroupsWrapper == null)
                {
                    _GroupsWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.Base.Identity, Kistl.App.Base.Group, Kistl.App.Base.Identity_memberOf_Group_RelationEntry__Implementation__>(
                            this,
                            Groups__Implementation__);
                }
                return _GroupsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Identities_memberOf_Groups_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.Identity_memberOf_Group_RelationEntry__Implementation__> Groups__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.Identity_memberOf_Group_RelationEntry__Implementation__>(
                        "Model.FK_Identities_memberOf_Groups_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.Base.Identity, Kistl.App.Base.Group, Kistl.App.Base.Identity_memberOf_Group_RelationEntry__Implementation__> _GroupsWrapper;


        /// <summary>
        /// Password of a generic identity
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Password
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Password;
                if (OnPassword_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPassword_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Password != value)
                {
                    var __oldValue = _Password;
                    var __newValue = value;
                    if(OnPassword_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Password", __oldValue, __newValue);
                    _Password = __newValue;
                    NotifyPropertyChanged("Password", __oldValue, __newValue);
                    if(OnPassword_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Password;
		public static event PropertyGetterHandler<Kistl.App.Base.Identity, string> OnPassword_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Identity, string> OnPassword_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Identity, string> OnPassword_PostSetter;

        /// <summary>
        /// Username of a generic identity
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string UserName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _UserName;
                if (OnUserName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnUserName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_UserName != value)
                {
                    var __oldValue = _UserName;
                    var __newValue = value;
                    if(OnUserName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("UserName", __oldValue, __newValue);
                    _UserName = __newValue;
                    NotifyPropertyChanged("UserName", __oldValue, __newValue);
                    if(OnUserName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _UserName;
		public static event PropertyGetterHandler<Kistl.App.Base.Identity, string> OnUserName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Identity, string> OnUserName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Identity, string> OnUserName_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Identity));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Identity)obj;
			var otherImpl = (Identity__Implementation__)obj;
			var me = (Identity)this;

			me.DisplayName = other.DisplayName;
			me.Password = other.Password;
			me.UserName = other.UserName;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Identity")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Identity != null)
            {
                OnToString_Identity(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Identity> OnToString_Identity;

        [EventBasedMethod("OnPreSave_Identity")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Identity != null) OnPreSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnPreSave_Identity;

        [EventBasedMethod("OnPostSave_Identity")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Identity != null) OnPostSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnPostSave_Identity;

        [EventBasedMethod("OnCreated_Identity")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Identity != null) OnCreated_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnCreated_Identity;

        [EventBasedMethod("OnDeleting_Identity")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Identity != null) OnDeleting_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnDeleting_Identity;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<Identity__Implementation__, string>(
				new Guid("f93e6dbb-a704-460c-8183-ce8b1c2c47a2"),
				"DisplayName",
				null,
				obj => obj.DisplayName,
				(obj, val) => obj.DisplayName = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Identity__Implementation__, ICollection<Kistl.App.Base.Group>>(
				new Guid("5f534204-f0d5-4d6f-8efa-7ff248580ba3"),
				"Groups",
				null,
				obj => obj.Groups,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Identity__Implementation__, string>(
				new Guid("0d499610-99e3-42cc-b71b-49ed1a356355"),
				"Password",
				null,
				obj => obj.Password,
				(obj, val) => obj.Password = val),
			// else
			new CustomPropertyDescriptor<Identity__Implementation__, string>(
				new Guid("a4ce1f5f-311b-4510-8817-4cca40f0bf0f"),
				"UserName",
				null,
				obj => obj.UserName,
				(obj, val) => obj.UserName = val),
			// rel: Relation was CreatedBy (84a74390-2386-465d-b9a5-83f9b60a006f)
			// rel: TypeRef was CreatedBy (18ca9bcf-98f8-42b1-8280-649401dec9de)
			// rel: Property was ChangedBy (88098240-78f7-43eb-8c0d-746c8dfeba63)
			// rel: Mitarbeiter was CreatedBy (3c7ef80e-07a3-4cb0-93be-9163650abc9a)
			// rel: Projekt was CreatedBy (035db8da-a9f4-4529-9f50-29afd9e6f043)
			// rel: RelationEnd was ChangedBy (7be8f809-6b85-40e1-bfce-7de8909a03d9)
			// rel: Module was CreatedBy (5c8dd58e-cf1d-484f-af64-ff84ea4c3ee9)
			// rel: Module was ChangedBy (9d108dc6-7caa-4597-95d4-82cf52da5638)
			// rel: Property was CreatedBy (3c085354-3ef4-49b2-bb95-80d5295519f1)
			// rel: DefaultPropertyValue was CreatedBy (2cec73a2-76e5-4b98-bf49-16e873d4bf67)
			// rel: AccessControl was ChangedBy (89cba0a2-2515-45d8-90e5-fa96db0cc4b3)
			// rel: EnumerationEntry was ChangedBy (20d04b3c-9357-440f-96e9-7056736d6ca3)
			// rel: DefaultPropertyValue was ChangedBy (7f9ecbb7-c962-4f95-9d89-3cb86857886f)
			// rel: AccessControl was CreatedBy (a6a5dcbf-0751-4911-9a0a-5fb1a59d2a45)
			// rel: BaseParameter was ChangedBy (50657ede-910f-4552-a58b-b58832b7db8d)
			// rel: DataType was CreatedBy (b7d1b442-4364-4979-b81c-66392fbe69fd)
			// rel: File was CreatedBy (1f543299-93ce-4441-a3d7-6d95e8546350)
			// rel: File was ChangedBy (2ff68641-0051-4f2e-a8ee-5f50b9d507f3)
			// rel: Assembly was CreatedBy (56b41a57-e179-4cd3-8706-8c6871f0fc58)
			// rel: Task was CreatedBy (d3b22699-c804-4443-bf4d-5d083cb0d313)
			// rel: PropertyInvocation was CreatedBy (dc1d4aa8-0253-48da-9ed0-d3c9b8d2746e)
			// rel: Task was ChangedBy (79cfa49b-e629-492f-a8d7-d4467d3a55c0)
			// rel: Relation was ChangedBy (ba46e16e-5659-4e29-b770-1222d7b0acc1)
			// rel: PropertyInvocation was ChangedBy (a3de8754-433e-4cd5-b463-7b2708b18e66)
			// rel: Auftrag ChangedBy ChangedBy (f12a4d5c-dcb0-416c-b1fa-1f6fc163bdac)
			// rel: BaseParameter was CreatedBy (e98d475b-1a3f-4ffb-ac5a-4ecbebb2e6ce)
			// rel: Assembly was ChangedBy (98612719-3882-45a2-ae30-b5329524e744)
			// rel: Auftrag CreatedBy CreatedBy (a6ed6bc7-2eb3-4e43-97f3-ec8aca0e120b)
			// rel: MethodInvocation was CreatedBy (062cc504-2191-4e6b-87e1-08747acd350c)
			// rel: Document was CreatedBy (40257114-de1a-493c-998e-18484521fb8c)
			// rel: EnumerationEntry was CreatedBy (c4b36682-947b-4c4a-802f-7618e3b0c3c3)
			// rel: DataType was ChangedBy (cf88221e-3474-4de1-8692-abd65d052e8b)
			// rel: Method was CreatedBy (c2f4906d-2841-47df-bd91-6228f2f4285a)
			// rel: RelationEnd was CreatedBy (f474544e-8537-4dce-a8b4-9ec0b5f4150e)
			// rel: Constraint was ChangedBy (6b1b0216-b3cf-4a5f-ae59-e6f46fda9331)
			// rel: Mitarbeiter was ChangedBy (aeca0771-5b0f-48a7-9ff9-02a56d6fe758)
			// rel: MethodInvocation was ChangedBy (7ad6ee5a-550e-444e-b568-998bbf1a1994)
			// rel: Kunde was CreatedBy (5daf8db8-be8b-4ac7-a887-9217442fa7f4)
			// rel: Projekt was ChangedBy (bc2a3fdc-68d7-4ba1-9c16-03fd74c43bb0)
			// rel: TypeRef was ChangedBy (b027e54e-632d-43ef-a83f-9d017717a9da)
			// rel: Method was ChangedBy (30768fac-3c40-46e7-94fd-a2ab73447cd7)
			// rel: Document was ChangedBy (5b930212-f85a-4be9-9882-437cca6ffe0d)
			// rel: Constraint was CreatedBy (f7eab863-c425-4819-b435-10394cf1ca5a)
			// rel: Kunde was ChangedBy (2a33407e-beeb-4919-b4c1-9aa264286151)
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._DisplayName, binStream);
            BinarySerializer.ToStream(this._Password, binStream);
            BinarySerializer.ToStream(this._UserName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._DisplayName, binStream);
            BinarySerializer.FromStream(out this._Password, binStream);
            BinarySerializer.FromStream(out this._UserName, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._DisplayName, xml, "DisplayName", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Password, xml, "Password", "Kistl.App.Base");
            XmlStreamer.ToStream(this._UserName, xml, "UserName", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._DisplayName, xml, "DisplayName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Password, xml, "Password", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._UserName, xml, "UserName", "Kistl.App.Base");
        }

#endregion

    }


}