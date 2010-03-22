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
    [EdmEntityType(NamespaceName="Model", Name="Antwort")]
    [System.Diagnostics.DebuggerDisplay("Antwort")]
    public class Antwort__Implementation__ : BaseServerDataObject_EntityFramework, Antwort
    {
    
		public Antwort__Implementation__()
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
        public virtual string Frage
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Frage;
                if (OnFrage_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnFrage_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Frage != value)
                {
                    var __oldValue = _Frage;
                    var __newValue = value;
                    if(OnFrage_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnFrage_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Frage", __oldValue, __newValue);
                    _Frage = __newValue;
                    NotifyPropertyChanged("Frage", __oldValue, __newValue);
                    if(OnFrage_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnFrage_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Frage;
		public static event PropertyGetterHandler<Kistl.App.Test.Antwort, string> OnFrage_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Antwort, string> OnFrage_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Antwort, string> OnFrage_PostSetter;

        /// <summary>
        /// Workaround for Case 1376
        /// </summary>
    /*
    Relation: FK_Ein_Fragebogen_enthaelt_gute_Antworten
    A: One Fragebogen as Ein_Fragebogen
    B: ZeroOrMore Antwort as gute_Antworten
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.Fragebogen Fragebogen
        {
            get
            {
                return Fragebogen__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Fragebogen__Implementation__ = (Kistl.App.Test.Fragebogen__Implementation__)value;
            }
        }
        
        private int? _fk_Fragebogen;
        private Guid? _fk_guid_Fragebogen = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Ein_Fragebogen_enthaelt_gute_Antworten", "Ein_Fragebogen")]
        public Kistl.App.Test.Fragebogen__Implementation__ Fragebogen__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.Fragebogen__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Fragebogen__Implementation__>(
                        "Model.FK_Ein_Fragebogen_enthaelt_gute_Antworten",
                        "Ein_Fragebogen");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnFragebogen_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.Fragebogen>(__value);
					OnFragebogen_Getter(this, e);
					__value = (Kistl.App.Test.Fragebogen__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.Fragebogen__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Fragebogen__Implementation__>(
                        "Model.FK_Ein_Fragebogen_enthaelt_gute_Antworten",
                        "Ein_Fragebogen");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.Fragebogen __oldValue = (Kistl.App.Test.Fragebogen)r.Value;
                Kistl.App.Test.Fragebogen __newValue = (Kistl.App.Test.Fragebogen)value;

                if(OnFragebogen_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.Fragebogen>(__oldValue, __newValue);
					OnFragebogen_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.Fragebogen__Implementation__)__newValue;
                if(OnFragebogen_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.Fragebogen>(__oldValue, __newValue);
					OnFragebogen_PostSetter(this, e);
                }
                                
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int? gute_Antworten_pos
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _gute_Antworten_pos;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_gute_Antworten_pos != value)
                {
                    var __oldValue = _gute_Antworten_pos;
                    var __newValue = value;
                    NotifyPropertyChanging("gute_Antworten_pos", __oldValue, __newValue);
                    _gute_Antworten_pos = __newValue;
                    NotifyPropertyChanged("gute_Antworten_pos", __oldValue, __newValue);
                }
            }
        }
        private int? _gute_Antworten_pos;
        
		public static event PropertyGetterHandler<Kistl.App.Test.Antwort, Kistl.App.Test.Fragebogen> OnFragebogen_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Antwort, Kistl.App.Test.Fragebogen> OnFragebogen_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Antwort, Kistl.App.Test.Fragebogen> OnFragebogen_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int FragenNummer
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _FragenNummer;
                if (OnFragenNummer_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnFragenNummer_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_FragenNummer != value)
                {
                    var __oldValue = _FragenNummer;
                    var __newValue = value;
                    if(OnFragenNummer_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnFragenNummer_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("FragenNummer", __oldValue, __newValue);
                    _FragenNummer = __newValue;
                    NotifyPropertyChanged("FragenNummer", __oldValue, __newValue);
                    if(OnFragenNummer_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnFragenNummer_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _FragenNummer;
		public static event PropertyGetterHandler<Kistl.App.Test.Antwort, int> OnFragenNummer_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Antwort, int> OnFragenNummer_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Antwort, int> OnFragenNummer_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int? GegebeneAntwort
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _GegebeneAntwort;
                if (OnGegebeneAntwort_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnGegebeneAntwort_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_GegebeneAntwort != value)
                {
                    var __oldValue = _GegebeneAntwort;
                    var __newValue = value;
                    if(OnGegebeneAntwort_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnGegebeneAntwort_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("GegebeneAntwort", __oldValue, __newValue);
                    _GegebeneAntwort = __newValue;
                    NotifyPropertyChanged("GegebeneAntwort", __oldValue, __newValue);
                    if(OnGegebeneAntwort_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnGegebeneAntwort_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _GegebeneAntwort;
		public static event PropertyGetterHandler<Kistl.App.Test.Antwort, int?> OnGegebeneAntwort_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Antwort, int?> OnGegebeneAntwort_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Antwort, int?> OnGegebeneAntwort_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Antwort));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Antwort)obj;
			var otherImpl = (Antwort__Implementation__)obj;
			var me = (Antwort)this;

			me.Frage = other.Frage;
			me.FragenNummer = other.FragenNummer;
			me.GegebeneAntwort = other.GegebeneAntwort;
			this.gute_Antworten_pos = otherImpl.gute_Antworten_pos;
			this._fk_Fragebogen = otherImpl._fk_Fragebogen;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Antwort")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Antwort != null)
            {
                OnToString_Antwort(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Antwort> OnToString_Antwort;

        [EventBasedMethod("OnPreSave_Antwort")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Antwort != null) OnPreSave_Antwort(this);
        }
        public static event ObjectEventHandler<Antwort> OnPreSave_Antwort;

        [EventBasedMethod("OnPostSave_Antwort")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Antwort != null) OnPostSave_Antwort(this);
        }
        public static event ObjectEventHandler<Antwort> OnPostSave_Antwort;

        [EventBasedMethod("OnCreated_Antwort")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Antwort != null) OnCreated_Antwort(this);
        }
        public static event ObjectEventHandler<Antwort> OnCreated_Antwort;

        [EventBasedMethod("OnDeleting_Antwort")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Antwort != null) OnDeleting_Antwort(this);
        }
        public static event ObjectEventHandler<Antwort> OnDeleting_Antwort;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<Antwort__Implementation__, string>(
				new Guid("311cb474-be7d-4e6b-b803-379e6523720c"),
				"Frage",
				null,
				obj => obj.Frage,
				(obj, val) => obj.Frage = val),
			// else
			new CustomPropertyDescriptor<Antwort__Implementation__, Kistl.App.Test.Fragebogen>(
				new Guid("ae20c23b-0cfa-422a-9f8d-797e9f70bf82"),
				"Fragebogen",
				null,
				obj => obj.Fragebogen,
				(obj, val) => obj.Fragebogen = val),
			// else
			new CustomPropertyDescriptor<Antwort__Implementation__, int>(
				new Guid("87a005fa-6249-4aab-b90e-b50c97487c09"),
				"FragenNummer",
				null,
				obj => obj.FragenNummer,
				(obj, val) => obj.FragenNummer = val),
			// else
			new CustomPropertyDescriptor<Antwort__Implementation__, int?>(
				new Guid("bbddff1f-943e-48cb-b097-377040280f0a"),
				"GegebeneAntwort",
				null,
				obj => obj.GegebeneAntwort,
				(obj, val) => obj.GegebeneAntwort = val),
			// rel: Ein_Fragebogen enthaelt gute_Antworten (0f425937-0d1e-4887-ae65-a162b45fc93e)
			// rel.B.Type == cls && rel.B.HasPersistentOrder
			new CustomPropertyDescriptor<Antwort__Implementation__, int?>(
				null,
				"gute_Antworten_pos",
				null,
				obj => obj.gute_Antworten_pos,
				(obj, val) => obj.gute_Antworten_pos = val),
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

			if (_fk_guid_Fragebogen.HasValue)
				Fragebogen__Implementation__ = (Kistl.App.Test.Fragebogen__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.Fragebogen>(_fk_guid_Fragebogen.Value);
			else if (_fk_Fragebogen.HasValue)
				Fragebogen__Implementation__ = (Kistl.App.Test.Fragebogen__Implementation__)Context.Find<Kistl.App.Test.Fragebogen>(_fk_Fragebogen.Value);
			else
				Fragebogen__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Frage, binStream);
            BinarySerializer.ToStream(Fragebogen != null ? Fragebogen.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._gute_Antworten_pos, binStream);
            BinarySerializer.ToStream(this._FragenNummer, binStream);
            BinarySerializer.ToStream(this._GegebeneAntwort, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Frage, binStream);
            BinarySerializer.FromStream(out this._fk_Fragebogen, binStream);
            BinarySerializer.FromStream(out this._gute_Antworten_pos, binStream);
            BinarySerializer.FromStream(out this._FragenNummer, binStream);
            BinarySerializer.FromStream(out this._GegebeneAntwort, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Frage, xml, "Frage", "Kistl.App.Test");
            XmlStreamer.ToStream(Fragebogen != null ? Fragebogen.ID : (int?)null, xml, "Fragebogen", "Kistl.App.Test");
            XmlStreamer.ToStream(this._gute_Antworten_pos, xml, "gute_Antworten_pos", "Kistl.App.Test");
            XmlStreamer.ToStream(this._FragenNummer, xml, "FragenNummer", "Kistl.App.Test");
            XmlStreamer.ToStream(this._GegebeneAntwort, xml, "GegebeneAntwort", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Frage, xml, "Frage", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_Fragebogen, xml, "Fragebogen", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._gute_Antworten_pos, xml, "gute_Antworten_pos", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._FragenNummer, xml, "FragenNummer", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._GegebeneAntwort, xml, "GegebeneAntwort", "Kistl.App.Test");
        }

#endregion

    }


}