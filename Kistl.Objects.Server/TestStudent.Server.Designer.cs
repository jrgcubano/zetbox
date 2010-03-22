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
    [EdmEntityType(NamespaceName="Model", Name="TestStudent")]
    [System.Diagnostics.DebuggerDisplay("TestStudent")]
    public class TestStudent__Implementation__ : BaseServerDataObject_EntityFramework, TestStudent
    {
    
		public TestStudent__Implementation__()
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
		public static event PropertyGetterHandler<Kistl.App.Test.TestStudent, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestStudent, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestStudent, string> OnName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Student_füllt_aus_Testbogen
    A: ZeroOrMore TestStudent as Student
    B: ZeroOrMore Fragebogen as Testbogen
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.Fragebogen> Testbogen
        {
            get
            {
                if (_TestbogenWrapper == null)
                {
                    _TestbogenWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntry__Implementation__>(
                            this,
                            Testbogen__Implementation__);
                }
                return _TestbogenWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Student_füllt_aus_Testbogen_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntry__Implementation__> Testbogen__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntry__Implementation__>(
                        "Model.FK_Student_füllt_aus_Testbogen_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntry__Implementation__> _TestbogenWrapper;


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TestStudent));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TestStudent)obj;
			var otherImpl = (TestStudent__Implementation__)obj;
			var me = (TestStudent)this;

			me.Name = other.Name;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestStudent")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestStudent != null)
            {
                OnToString_TestStudent(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestStudent> OnToString_TestStudent;

        [EventBasedMethod("OnPreSave_TestStudent")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestStudent != null) OnPreSave_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnPreSave_TestStudent;

        [EventBasedMethod("OnPostSave_TestStudent")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestStudent != null) OnPostSave_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnPostSave_TestStudent;

        [EventBasedMethod("OnCreated_TestStudent")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestStudent != null) OnCreated_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnCreated_TestStudent;

        [EventBasedMethod("OnDeleting_TestStudent")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestStudent != null) OnDeleting_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnDeleting_TestStudent;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<TestStudent__Implementation__, string>(
				new Guid("190b4492-c1cb-40a2-8941-84b8ff3ac141"),
				"Name",
				null,
				obj => obj.Name,
				(obj, val) => obj.Name = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<TestStudent__Implementation__, ICollection<Kistl.App.Test.Fragebogen>>(
				new Guid("f330d95b-372d-4302-b4d1-73afc5fa71de"),
				"Testbogen",
				null,
				obj => obj.Testbogen,
				null), // lists are read-only properties
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
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Test");
        }

#endregion

    }


}