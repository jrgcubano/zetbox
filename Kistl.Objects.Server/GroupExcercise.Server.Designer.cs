// <autogenerated/>


namespace at.dasz.CourseOrganiser
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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="GroupExcercise")]
    [System.Diagnostics.DebuggerDisplay("GroupExcercise")]
    public class GroupExcercise__Implementation__ : BaseServerDataObject_EntityFramework, GroupExcercise
    {
    
		public GroupExcercise__Implementation__()
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
        /// 
        /// </summary>
    /*
    Relation: FK_GroupExcercise_passes_Excercise
    A: ZeroOrMore GroupExcercise as GroupExcercise
    B: One Exercise as Excercise
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public at.dasz.CourseOrganiser.Exercise Excercise
        {
            get
            {
                return Excercise__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Excercise__Implementation__ = (at.dasz.CourseOrganiser.Exercise__Implementation__)value;
            }
        }
        
        private int? _fk_Excercise;
        private Guid? _fk_guid_Excercise = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_GroupExcercise_passes_Excercise", "Excercise")]
        public at.dasz.CourseOrganiser.Exercise__Implementation__ Excercise__Implementation__
        {
            get
            {
                EntityReference<at.dasz.CourseOrganiser.Exercise__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.CourseOrganiser.Exercise__Implementation__>(
                        "Model.FK_GroupExcercise_passes_Excercise",
                        "Excercise");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnExcercise_Getter != null)
				{
					var e = new PropertyGetterEventArgs<at.dasz.CourseOrganiser.Exercise>(__value);
					OnExcercise_Getter(this, e);
					__value = (at.dasz.CourseOrganiser.Exercise__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<at.dasz.CourseOrganiser.Exercise__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.CourseOrganiser.Exercise__Implementation__>(
                        "Model.FK_GroupExcercise_passes_Excercise",
                        "Excercise");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                at.dasz.CourseOrganiser.Exercise __oldValue = (at.dasz.CourseOrganiser.Exercise)r.Value;
                at.dasz.CourseOrganiser.Exercise __newValue = (at.dasz.CourseOrganiser.Exercise)value;

                if(OnExcercise_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<at.dasz.CourseOrganiser.Exercise>(__oldValue, __newValue);
					OnExcercise_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (at.dasz.CourseOrganiser.Exercise__Implementation__)__newValue;
                if(OnExcercise_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<at.dasz.CourseOrganiser.Exercise>(__oldValue, __newValue);
					OnExcercise_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Exercise> OnExcercise_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Exercise> OnExcercise_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Exercise> OnExcercise_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int? Score
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Score;
                if (OnScore_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnScore_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Score != value)
                {
                    var __oldValue = _Score;
                    var __newValue = value;
                    if(OnScore_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnScore_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Score", __oldValue, __newValue);
                    _Score = __newValue;
                    NotifyPropertyChanged("Score", __oldValue, __newValue);
                    if(OnScore_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnScore_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _Score;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.GroupExcercise, int?> OnScore_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.GroupExcercise, int?> OnScore_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.GroupExcercise, int?> OnScore_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_GroupExcercise_accomplished_by_Students
    A: ZeroOrMore GroupExcercise as GroupExcercise
    B: ZeroOrMore Student as Students
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.Student> Students
        {
            get
            {
                if (_StudentsWrapper == null)
                {
                    _StudentsWrapper = new EntityRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__>(
                            this,
                            Students__Implementation__);
                }
                return _StudentsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_GroupExcercise_accomplished_by_Students_A", "CollectionEntry")]
        public EntityCollection<at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__> Students__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__>(
                        "Model.FK_GroupExcercise_accomplished_by_Students_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__> _StudentsWrapper;


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(GroupExcercise));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (GroupExcercise)obj;
			var otherImpl = (GroupExcercise__Implementation__)obj;
			var me = (GroupExcercise)this;

			me.Score = other.Score;
			this._fk_Excercise = otherImpl._fk_Excercise;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_GroupExcercise")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_GroupExcercise != null)
            {
                OnToString_GroupExcercise(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<GroupExcercise> OnToString_GroupExcercise;

        [EventBasedMethod("OnPreSave_GroupExcercise")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_GroupExcercise != null) OnPreSave_GroupExcercise(this);
        }
        public static event ObjectEventHandler<GroupExcercise> OnPreSave_GroupExcercise;

        [EventBasedMethod("OnPostSave_GroupExcercise")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_GroupExcercise != null) OnPostSave_GroupExcercise(this);
        }
        public static event ObjectEventHandler<GroupExcercise> OnPostSave_GroupExcercise;

        [EventBasedMethod("OnCreated_GroupExcercise")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_GroupExcercise != null) OnCreated_GroupExcercise(this);
        }
        public static event ObjectEventHandler<GroupExcercise> OnCreated_GroupExcercise;

        [EventBasedMethod("OnDeleting_GroupExcercise")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_GroupExcercise != null) OnDeleting_GroupExcercise(this);
        }
        public static event ObjectEventHandler<GroupExcercise> OnDeleting_GroupExcercise;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<GroupExcercise__Implementation__, at.dasz.CourseOrganiser.Exercise>(
				new Guid("844509ba-ace7-4ce5-a5a0-ec52110d0203"),
				"Excercise",
				null,
				obj => obj.Excercise,
				(obj, val) => obj.Excercise = val),
			// else
			new CustomPropertyDescriptor<GroupExcercise__Implementation__, int?>(
				new Guid("04f84c64-4d2d-41c3-8007-024ba5f71b08"),
				"Score",
				null,
				obj => obj.Score,
				(obj, val) => obj.Score = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<GroupExcercise__Implementation__, ICollection<at.dasz.CourseOrganiser.Student>>(
				new Guid("f8257ff0-7693-4a11-bb2b-6f6db4666dfa"),
				"Students",
				null,
				obj => obj.Students,
				null), // lists are read-only properties
			// rel: GroupExcercise passes Excercise (a8350540-d61e-48b3-b7a1-39751968dcf3)
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

			if (_fk_guid_Excercise.HasValue)
				Excercise__Implementation__ = (at.dasz.CourseOrganiser.Exercise__Implementation__)Context.FindPersistenceObject<at.dasz.CourseOrganiser.Exercise>(_fk_guid_Excercise.Value);
			else if (_fk_Excercise.HasValue)
				Excercise__Implementation__ = (at.dasz.CourseOrganiser.Exercise__Implementation__)Context.Find<at.dasz.CourseOrganiser.Exercise>(_fk_Excercise.Value);
			else
				Excercise__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(Excercise != null ? Excercise.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._Score, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Excercise, binStream);
            BinarySerializer.FromStream(out this._Score, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(Excercise != null ? Excercise.ID : (int?)null, xml, "Excercise", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(this._Score, xml, "Score", "at.dasz.CourseOrganiser");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Excercise, xml, "Excercise", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._Score, xml, "Score", "at.dasz.CourseOrganiser");
        }

#endregion

    }


}