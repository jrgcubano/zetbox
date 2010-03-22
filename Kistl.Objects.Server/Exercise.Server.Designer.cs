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
    [EdmEntityType(NamespaceName="Model", Name="Exercise")]
    [System.Diagnostics.DebuggerDisplay("Exercise")]
    public class Exercise__Implementation__ : BaseServerDataObject_EntityFramework, Exercise
    {
    
		public Exercise__Implementation__()
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
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? Date
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Date;
                if (OnDate_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnDate_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Date != value)
                {
                    var __oldValue = _Date;
                    var __newValue = value;
                    if(OnDate_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnDate_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Date", __oldValue, __newValue);
                    _Date = __newValue;
                    NotifyPropertyChanged("Date", __oldValue, __newValue);
                    if(OnDate_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnDate_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _Date;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Exercise, DateTime?> OnDate_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Exercise, DateTime?> OnDate_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Exercise, DateTime?> OnDate_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_GroupExcercise_passes_Excercise
    A: ZeroOrMore GroupExcercise as GroupExcercise
    B: One Exercise as Excercise
    Preferred Storage: MergeIntoA
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.GroupExcercise> GroupExcercise
        {
            get
            {
                if (_GroupExcerciseWrapper == null)
                {
                    _GroupExcerciseWrapper = new EntityCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.GroupExcercise__Implementation__>(
                            this.Context, GroupExcercise__Implementation__);
                }
                return _GroupExcerciseWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_GroupExcercise_passes_Excercise", "GroupExcercise")]
        public EntityCollection<at.dasz.CourseOrganiser.GroupExcercise__Implementation__> GroupExcercise__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.GroupExcercise__Implementation__>(
                        "Model.FK_GroupExcercise_passes_Excercise",
                        "GroupExcercise");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.GroupExcercise__Implementation__> _GroupExcerciseWrapper;



        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int MaxScores
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MaxScores;
                if (OnMaxScores_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMaxScores_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MaxScores != value)
                {
                    var __oldValue = _MaxScores;
                    var __newValue = value;
                    if(OnMaxScores_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMaxScores_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MaxScores", __oldValue, __newValue);
                    _MaxScores = __newValue;
                    NotifyPropertyChanged("MaxScores", __oldValue, __newValue);
                    if(OnMaxScores_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMaxScores_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _MaxScores;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Exercise, int> OnMaxScores_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Exercise, int> OnMaxScores_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Exercise, int> OnMaxScores_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if(OnName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(OnName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Exercise, string> OnName_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Exercise, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Exercise, string> OnName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Excercise_happens_in_Semester
    A: ZeroOrMore Exercise as Excercise
    B: One Semester as Semester
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public at.dasz.CourseOrganiser.Semester Semester
        {
            get
            {
                return Semester__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Semester__Implementation__ = (at.dasz.CourseOrganiser.Semester__Implementation__)value;
            }
        }
        
        private int? _fk_Semester;
        private Guid? _fk_guid_Semester = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Excercise_happens_in_Semester", "Semester")]
        public at.dasz.CourseOrganiser.Semester__Implementation__ Semester__Implementation__
        {
            get
            {
                EntityReference<at.dasz.CourseOrganiser.Semester__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.CourseOrganiser.Semester__Implementation__>(
                        "Model.FK_Excercise_happens_in_Semester",
                        "Semester");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnSemester_Getter != null)
				{
					var e = new PropertyGetterEventArgs<at.dasz.CourseOrganiser.Semester>(__value);
					OnSemester_Getter(this, e);
					__value = (at.dasz.CourseOrganiser.Semester__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<at.dasz.CourseOrganiser.Semester__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.CourseOrganiser.Semester__Implementation__>(
                        "Model.FK_Excercise_happens_in_Semester",
                        "Semester");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                at.dasz.CourseOrganiser.Semester __oldValue = (at.dasz.CourseOrganiser.Semester)r.Value;
                at.dasz.CourseOrganiser.Semester __newValue = (at.dasz.CourseOrganiser.Semester)value;

                if(OnSemester_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<at.dasz.CourseOrganiser.Semester>(__oldValue, __newValue);
					OnSemester_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (at.dasz.CourseOrganiser.Semester__Implementation__)__newValue;
                if(OnSemester_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<at.dasz.CourseOrganiser.Semester>(__oldValue, __newValue);
					OnSemester_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Exercise, at.dasz.CourseOrganiser.Semester> OnSemester_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Exercise, at.dasz.CourseOrganiser.Semester> OnSemester_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Exercise, at.dasz.CourseOrganiser.Semester> OnSemester_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Exercise));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Exercise)obj;
			var otherImpl = (Exercise__Implementation__)obj;
			var me = (Exercise)this;

			me.Date = other.Date;
			me.MaxScores = other.MaxScores;
			me.Name = other.Name;
			this._fk_Semester = otherImpl._fk_Semester;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Exercise")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Exercise != null)
            {
                OnToString_Exercise(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Exercise> OnToString_Exercise;

        [EventBasedMethod("OnPreSave_Exercise")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Exercise != null) OnPreSave_Exercise(this);
        }
        public static event ObjectEventHandler<Exercise> OnPreSave_Exercise;

        [EventBasedMethod("OnPostSave_Exercise")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Exercise != null) OnPostSave_Exercise(this);
        }
        public static event ObjectEventHandler<Exercise> OnPostSave_Exercise;

        [EventBasedMethod("OnCreated_Exercise")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Exercise != null) OnCreated_Exercise(this);
        }
        public static event ObjectEventHandler<Exercise> OnCreated_Exercise;

        [EventBasedMethod("OnDeleting_Exercise")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Exercise != null) OnDeleting_Exercise(this);
        }
        public static event ObjectEventHandler<Exercise> OnDeleting_Exercise;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<Exercise__Implementation__, DateTime?>(
				new Guid("7d4137e1-360c-44eb-ab64-5cc61983da60"),
				"Date",
				null,
				obj => obj.Date,
				(obj, val) => obj.Date = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Exercise__Implementation__, ICollection<at.dasz.CourseOrganiser.GroupExcercise>>(
				new Guid("4c82e650-323b-4bc6-a472-642c1b975bfc"),
				"GroupExcercise",
				null,
				obj => obj.GroupExcercise,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Exercise__Implementation__, int>(
				new Guid("a7d4b4d0-08aa-4d30-bf1b-0e45ed1db172"),
				"MaxScores",
				null,
				obj => obj.MaxScores,
				(obj, val) => obj.MaxScores = val),
			// else
			new CustomPropertyDescriptor<Exercise__Implementation__, string>(
				new Guid("f1fb9038-d6b3-4042-8072-c7192dfd6828"),
				"Name",
				null,
				obj => obj.Name,
				(obj, val) => obj.Name = val),
			// else
			new CustomPropertyDescriptor<Exercise__Implementation__, at.dasz.CourseOrganiser.Semester>(
				new Guid("30583b3c-51ff-4308-8e00-8f4f8cacb80c"),
				"Semester",
				null,
				obj => obj.Semester,
				(obj, val) => obj.Semester = val),
			// rel: GroupExcercise passes Excercise (a8350540-d61e-48b3-b7a1-39751968dcf3)
			// rel: Excercise happens_in Semester (719bf072-74d1-4878-8d8b-db1c92d60145)
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_Semester.HasValue)
				Semester__Implementation__ = (at.dasz.CourseOrganiser.Semester__Implementation__)Context.FindPersistenceObject<at.dasz.CourseOrganiser.Semester>(_fk_guid_Semester.Value);
			else if (_fk_Semester.HasValue)
				Semester__Implementation__ = (at.dasz.CourseOrganiser.Semester__Implementation__)Context.Find<at.dasz.CourseOrganiser.Semester>(_fk_Semester.Value);
			else
				Semester__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Date, binStream);
            BinarySerializer.ToStream(this._MaxScores, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(Semester != null ? Semester.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Date, binStream);
            BinarySerializer.FromStream(out this._MaxScores, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._fk_Semester, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Date, xml, "Date", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(this._MaxScores, xml, "MaxScores", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(this._Name, xml, "Name", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(Semester != null ? Semester.ID : (int?)null, xml, "Semester", "at.dasz.CourseOrganiser");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Date, xml, "Date", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._MaxScores, xml, "MaxScores", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._fk_Semester, xml, "Semester", "at.dasz.CourseOrganiser");
        }

#endregion

    }


}