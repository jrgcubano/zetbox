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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestObjClass")]
    [System.Diagnostics.DebuggerDisplay("TestObjClass")]
    public class TestObjClass__Implementation__ : BaseServerDataObject_EntityFramework, TestObjClass
    {
    
		public TestObjClass__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// test
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual int? MyIntProperty
        {
            get
            {
                return _MyIntProperty;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_MyIntProperty != value)
                {
					var __oldValue = _MyIntProperty;
                    NotifyPropertyChanging("MyIntProperty", __oldValue, value);
                    _MyIntProperty = value;
                    NotifyPropertyChanged("MyIntProperty", __oldValue, value);
                }
            }
        }
        private int? _MyIntProperty;

        /// <summary>
        /// testtest
        /// </summary>
    /*
    Relation: FK_TestObjClass_Kunde_TestObjClass_50
    A: ZeroOrMore TestObjClass as TestObjClass
    B: ZeroOrOne Kunde as ObjectProp
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get
            {
                return ObjectProp__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        private int? _fk_ObjectProp;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TestObjClass_Kunde_TestObjClass_50", "ObjectProp")]
        public Kistl.App.Projekte.Kunde__Implementation__ ObjectProp__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_TestObjClass_Kunde_TestObjClass_50",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_TestObjClass_Kunde_TestObjClass_50",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// String Property
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string StringProp
        {
            get
            {
                return _StringProp;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_StringProp != value)
                {
					var __oldValue = _StringProp;
                    NotifyPropertyChanging("StringProp", __oldValue, value);
                    _StringProp = value;
                    NotifyPropertyChanged("StringProp", __oldValue, value);
                }
            }
        }
        private string _StringProp;

        /// <summary>
        /// Test Enumeration Property
        /// </summary>
        // enumeration property
        // implement the user-visible interface
        Kistl.App.Test.TestEnum TestObjClass.TestEnumProp
        {
            get
            {
                return _TestEnumProp;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnumProp != value)
                {
					var __oldValue = _TestEnumProp;
                    NotifyPropertyChanging("TestEnumProp", __oldValue, value);
                    _TestEnumProp = value;
                    NotifyPropertyChanged("TestEnumProp", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for TestEnumProp</summary>
        private Kistl.App.Test.TestEnum _TestEnumProp;
        
        /// <summary>EF sees only this property, for TestEnumProp</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int TestEnumProp
        {
            get
            {
                return (int)((TestObjClass)this).TestEnumProp;
            }
            set
            {
                ((TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)value;
            }
        }
        

        /// <summary>
        /// testmethod
        /// </summary>

		public virtual void TestMethod(System.DateTime DateTimeParamForTestMethod) 
		{
            // base.TestMethod();
            if (OnTestMethod_TestObjClass != null)
            {
				OnTestMethod_TestObjClass(this, DateTimeParamForTestMethod);
			}
			else
			{
                throw new NotImplementedException("No handler registered on TestObjClass.TestMethod");
			}
        }
		public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
		public event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TestObjClass));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TestObjClass)obj;
			var otherImpl = (TestObjClass__Implementation__)obj;
			var me = (TestObjClass)this;

			me.MyIntProperty = other.MyIntProperty;
			me.StringProp = other.StringProp;
			me.TestEnumProp = other.TestEnumProp;
			this._fk_ObjectProp = otherImpl._fk_ObjectProp;
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestObjClass != null)
            {
                OnToString_TestObjClass(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<TestObjClass> OnToString_TestObjClass;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestObjClass != null) OnPreSave_TestObjClass(this);
        }
        public event ObjectEventHandler<TestObjClass> OnPreSave_TestObjClass;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestObjClass != null) OnPostSave_TestObjClass(this);
        }
        public event ObjectEventHandler<TestObjClass> OnPostSave_TestObjClass;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "MyIntProperty":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(126).Constraints
						.Where(c => !c.IsValid(this, this.MyIntProperty))
						.Select(c => c.GetErrorText(this, this.MyIntProperty))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ObjectProp":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(112).Constraints
						.Where(c => !c.IsValid(this, this.ObjectProp))
						.Select(c => c.GetErrorText(this, this.ObjectProp))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "StringProp":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(109).Constraints
						.Where(c => !c.IsValid(this, this.StringProp))
						.Select(c => c.GetErrorText(this, this.StringProp))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "TestEnumProp":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(110).Constraints
						.Where(c => !c.IsValid(this, this.TestEnumProp))
						.Select(c => c.GetErrorText(this, this.TestEnumProp))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// fix direct object references
			if (_fk_ObjectProp.HasValue)
				ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.Find<Kistl.App.Projekte.Kunde>(_fk_ObjectProp.Value);
			else
				ObjectProp__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
			
            base.ToStream(binStream);
            BinarySerializer.ToStream(this._MyIntProperty, binStream);
            BinarySerializer.ToStream(ObjectProp != null ? ObjectProp.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._StringProp, binStream);
            BinarySerializer.ToStream((int)((TestObjClass)this).TestEnumProp, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._MyIntProperty, binStream);
            BinarySerializer.FromStream(out this._fk_ObjectProp, binStream);
            BinarySerializer.FromStream(out this._StringProp, binStream);
            BinarySerializer.FromStreamConverter(v => ((TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)v, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.ToStream(ObjectProp != null ? ObjectProp.ID : (int?)null, xml, "ObjectProp", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._StringProp, xml, "StringProp", "Kistl.App.Test");
            // TODO: Add XML Serializer here
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_ObjectProp, xml, "ObjectProp", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._StringProp, xml, "StringProp", "Kistl.App.Test");
            // TODO: Add XML Serializer here
        }

#endregion

    }


}