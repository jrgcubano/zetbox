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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Fragebogen")]
    [System.Diagnostics.DebuggerDisplay("Fragebogen")]
    public class Fragebogen__Implementation__ : BaseServerDataObject_EntityFramework, Fragebogen
    {
    
		public Fragebogen__Implementation__()
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
    Relation: FK_Ein_Fragebogen_enthaelt_gute_Antworten
    A: One Fragebogen as Ein_Fragebogen
    B: ZeroOrMore Antwort as gute_Antworten
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Test.Antwort> Antworten
        {
            get
            {
                if (_AntwortenWrapper == null)
                {
                    _AntwortenWrapper = new EntityListWrapper<Kistl.App.Test.Antwort, Kistl.App.Test.Antwort__Implementation__>(
                            this.Context, Antworten__Implementation__, "Ein_Fragebogen");
                }
                return _AntwortenWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Ein_Fragebogen_enthaelt_gute_Antworten", "gute_Antworten")]
        public EntityCollection<Kistl.App.Test.Antwort__Implementation__> Antworten__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.Antwort__Implementation__>(
                        "Model.FK_Ein_Fragebogen_enthaelt_gute_Antworten",
                        "gute_Antworten");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityListWrapper<Kistl.App.Test.Antwort, Kistl.App.Test.Antwort__Implementation__> _AntwortenWrapper;

		private List<int> AntwortenIds;


        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int? BogenNummer
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _BogenNummer;
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
                if (_BogenNummer != value)
                {
                    var __oldValue = _BogenNummer;
                    var __newValue = value;
                    if(OnBogenNummer_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnBogenNummer_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BogenNummer", __oldValue, __newValue);
                    _BogenNummer = __newValue;
                    NotifyPropertyChanged("BogenNummer", __oldValue, __newValue);
                    if(OnBogenNummer_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnBogenNummer_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _BogenNummer;
		public static event PropertyGetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Fragebogen, int?> OnBogenNummer_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Student_füllt_aus_Testbogen
    A: One TestStudent as Student
    B: ZeroOrMore Fragebogen as Testbogen
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.TestStudent Student
        {
            get
            {
                return Student__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Student__Implementation__ = (Kistl.App.Test.TestStudent__Implementation__)value;
            }
        }
        
        private int? _fk_Student;
        private Guid? _fk_guid_Student = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Student_füllt_aus_Testbogen", "Student")]
        public Kistl.App.Test.TestStudent__Implementation__ Student__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.TestStudent__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestStudent__Implementation__>(
                        "Model.FK_Student_füllt_aus_Testbogen",
                        "Student");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnStudent_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestStudent>(__value);
					OnStudent_Getter(this, e);
					__value = (Kistl.App.Test.TestStudent__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.TestStudent__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestStudent__Implementation__>(
                        "Model.FK_Student_füllt_aus_Testbogen",
                        "Student");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.TestStudent __oldValue = (Kistl.App.Test.TestStudent)r.Value;
                Kistl.App.Test.TestStudent __newValue = (Kistl.App.Test.TestStudent)value;

                if(OnStudent_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestStudent>(__oldValue, __newValue);
					OnStudent_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.TestStudent__Implementation__)__newValue;
                if(OnStudent_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestStudent>(__oldValue, __newValue);
					OnStudent_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent> OnStudent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent> OnStudent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent> OnStudent_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Fragebogen));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Fragebogen)obj;
			var otherImpl = (Fragebogen__Implementation__)obj;
			var me = (Fragebogen)this;

			me.BogenNummer = other.BogenNummer;
			this._fk_Student = otherImpl._fk_Student;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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

        [EventBasedMethod("OnPreSave_Fragebogen")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Fragebogen != null) OnPreSave_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnPreSave_Fragebogen;

        [EventBasedMethod("OnPostSave_Fragebogen")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Fragebogen != null) OnPostSave_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnPostSave_Fragebogen;

        [EventBasedMethod("OnCreated_Fragebogen")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Fragebogen != null) OnCreated_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnCreated_Fragebogen;

        [EventBasedMethod("OnDeleting_Fragebogen")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Fragebogen != null) OnDeleting_Fragebogen(this);
        }
        public static event ObjectEventHandler<Fragebogen> OnDeleting_Fragebogen;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			new CustomPropertyDescriptor<Fragebogen, IList<Kistl.App.Test.Antwort>>(
				new Guid("e8f20c02-abea-4c91-850f-c321adfd46f0"),
				"Antworten",
				null,
				obj => obj.Antworten,
				null), // lists are read-only properties
			new CustomPropertyDescriptor<Fragebogen, int?>(
				new Guid("b65f1a91-e063-4054-a2e7-d5dc0292e3fc"),
				"BogenNummer",
				null,
				obj => obj.BogenNummer,
				(obj, val) => obj.BogenNummer = val),
			new CustomPropertyDescriptor<Fragebogen, Kistl.App.Test.TestStudent>(
				new Guid("3a91e745-0dd2-4f31-864e-eaf657ddb577"),
				"Student",
				null,
				obj => obj.Student,
				(obj, val) => obj.Student = val),
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

			if (_fk_guid_Student.HasValue)
				Student__Implementation__ = (Kistl.App.Test.TestStudent__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.TestStudent>(_fk_guid_Student.Value);
			else if (_fk_Student.HasValue)
				Student__Implementation__ = (Kistl.App.Test.TestStudent__Implementation__)Context.Find<Kistl.App.Test.TestStudent>(_fk_Student.Value);
			else
				Student__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
			{
				BinarySerializer.ToStream(Antworten.Count, binStream);
				foreach(var obj in Antworten)
				{
					if (auxObjects != null) {
						auxObjects.Add(obj);
					}
					BinarySerializer.ToStream(obj.ID, binStream);
				}
			}
            BinarySerializer.ToStream(this._BogenNummer, binStream);
            BinarySerializer.ToStream(Student != null ? Student.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
			{
				int numElements;
				BinarySerializer.FromStream(out numElements, binStream);
				AntwortenIds = new List<int>(numElements);
				while (numElements-- > 0) 
				{
					int id;
					BinarySerializer.FromStream(out id, binStream);
					AntwortenIds.Add(id);
				}
			}

            BinarySerializer.FromStream(out this._BogenNummer, binStream);
            BinarySerializer.FromStream(out this._fk_Student, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._BogenNummer, xml, "BogenNummer", "Kistl.App.Test");
            XmlStreamer.ToStream(Student != null ? Student.ID : (int?)null, xml, "Student", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._BogenNummer, xml, "BogenNummer", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_Student, xml, "Student", "Kistl.App.Test");
        }

#endregion

    }


}