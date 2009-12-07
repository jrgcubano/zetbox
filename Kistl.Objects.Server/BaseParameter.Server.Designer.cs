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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for Parameter. This class is abstract.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="BaseParameter")]
    [System.Diagnostics.DebuggerDisplay("BaseParameter")]
    public class BaseParameter__Implementation__ : BaseServerDataObject_EntityFramework, BaseParameter, Kistl.API.IExportableInternal
    {
    
		public BaseParameter__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
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
        /// Description of this Parameter
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Description
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Description;
                if (OnDescription_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDescription_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
                    var __oldValue = _Description;
                    var __newValue = value;
                    if(OnDescription_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Description", __oldValue, __newValue);
                    _Description = __newValue;
                    NotifyPropertyChanged("Description", __oldValue, __newValue);
                    if(OnDescription_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Description;
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, string> OnDescription_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, string> OnDescription_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, string> OnDescription_PostSetter;
        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("74265fbf-2340-4828-82fa-cff4a0d18ffa"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'BaseParameter.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if(OnExportGuid_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(OnExportGuid_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// Parameter wird als List&lt;&gt; generiert
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool IsList
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsList;
                if (OnIsList_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsList_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsList != value)
                {
                    var __oldValue = _IsList;
                    var __newValue = value;
                    if(OnIsList_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsList", __oldValue, __newValue);
                    _IsList = __newValue;
                    NotifyPropertyChanged("IsList", __oldValue, __newValue);
                    if(OnIsList_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsList;
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsList_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsList_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsList_PostSetter;
        /// <summary>
        /// Es darf nur ein Return Parameter angegeben werden
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool IsReturnParameter
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsReturnParameter;
                if (OnIsReturnParameter_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsReturnParameter_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsReturnParameter != value)
                {
                    var __oldValue = _IsReturnParameter;
                    var __newValue = value;
                    if(OnIsReturnParameter_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsReturnParameter_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsReturnParameter", __oldValue, __newValue);
                    _IsReturnParameter = __newValue;
                    NotifyPropertyChanged("IsReturnParameter", __oldValue, __newValue);
                    if(OnIsReturnParameter_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsReturnParameter_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsReturnParameter;
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsReturnParameter_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsReturnParameter_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, bool> OnIsReturnParameter_PostSetter;
        /// <summary>
        /// Methode des Parameters
        /// </summary>
    /*
    Relation: FK_Method_has_Parameter
    A: One Method as Method
    B: ZeroOrMore BaseParameter as Parameter
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Method Method
        {
            get
            {
                return Method__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)value;
            }
        }
        
        private int? _fk_Method;
        private Guid? _fk_guid_Method = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Method_has_Parameter", "Method")]
        public Kistl.App.Base.Method__Implementation__ Method__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Method_has_Parameter",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMethod_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Method>(__value);
					OnMethod_Getter(this, e);
					__value = (Kistl.App.Base.Method__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Method_has_Parameter",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Method __oldValue = (Kistl.App.Base.Method)r.Value;
                Kistl.App.Base.Method __newValue = (Kistl.App.Base.Method)value;

                if(OnMethod_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Method__Implementation__)__newValue;
                if(OnMethod_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PostSetter(this, e);
                }
                                
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int? Method_pos
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Method_pos;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Method_pos != value)
                {
                    var __oldValue = _Method_pos;
                    var __newValue = value;
                    NotifyPropertyChanging("Method_pos", __oldValue, __newValue);
                    _Method_pos = __newValue;
                    NotifyPropertyChanged("Method_pos", __oldValue, __newValue);
                }
            }
        }
        private int? _Method_pos;
        
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, Kistl.App.Base.Method> OnMethod_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, Kistl.App.Base.Method> OnMethod_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, Kistl.App.Base.Method> OnMethod_PostSetter;
        /// <summary>
        /// Name des Parameter
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string ParameterName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ParameterName;
                if (OnParameterName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnParameterName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ParameterName != value)
                {
                    var __oldValue = _ParameterName;
                    var __newValue = value;
                    if(OnParameterName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnParameterName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ParameterName", __oldValue, __newValue);
                    _ParameterName = __newValue;
                    NotifyPropertyChanged("ParameterName", __oldValue, __newValue);
                    if(OnParameterName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnParameterName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _ParameterName;
		public event PropertyGetterHandler<Kistl.App.Base.BaseParameter, string> OnParameterName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.BaseParameter, string> OnParameterName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.BaseParameter, string> OnParameterName_PostSetter;
        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterType_BaseParameter")]
		public virtual System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_BaseParameter != null)
            {
                OnGetParameterType_BaseParameter(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on BaseParameter.GetParameterType");
            }
            return e.Result;
        }
		public delegate void GetParameterType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret);
		public event GetParameterType_Handler<BaseParameter> OnGetParameterType_BaseParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterTypeString_BaseParameter")]
		public virtual string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_BaseParameter != null)
            {
                OnGetParameterTypeString_BaseParameter(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on BaseParameter.GetParameterTypeString");
            }
            return e.Result;
        }
		public delegate void GetParameterTypeString_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetParameterTypeString_Handler<BaseParameter> OnGetParameterTypeString_BaseParameter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(BaseParameter));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (BaseParameter)obj;
			var otherImpl = (BaseParameter__Implementation__)obj;
			var me = (BaseParameter)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.IsList = other.IsList;
			me.IsReturnParameter = other.IsReturnParameter;
			me.ParameterName = other.ParameterName;
			this._fk_Method = otherImpl._fk_Method;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_BaseParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BaseParameter != null)
            {
                OnToString_BaseParameter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<BaseParameter> OnToString_BaseParameter;

        [EventBasedMethod("OnPreSave_BaseParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BaseParameter != null) OnPreSave_BaseParameter(this);
        }
        public event ObjectEventHandler<BaseParameter> OnPreSave_BaseParameter;

        [EventBasedMethod("OnPostSave_BaseParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BaseParameter != null) OnPostSave_BaseParameter(this);
        }
        public event ObjectEventHandler<BaseParameter> OnPostSave_BaseParameter;

        [EventBasedMethod("OnCreated_BaseParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_BaseParameter != null) OnCreated_BaseParameter(this);
        }
        public event ObjectEventHandler<BaseParameter> OnCreated_BaseParameter;

        [EventBasedMethod("OnDeleting_BaseParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_BaseParameter != null) OnDeleting_BaseParameter(this);
        }
        public event ObjectEventHandler<BaseParameter> OnDeleting_BaseParameter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Description":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("20668b5a-ecaa-4531-81d8-6e50c9858ff0")).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("74265fbf-2340-4828-82fa-cff4a0d18ffa")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsList":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("ec4d5dbc-f738-4eb3-a663-2328d0baa79c")).Constraints
						.Where(c => !c.IsValid(this, this.IsList))
						.Select(c => c.GetErrorText(this, this.IsList))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsReturnParameter":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("ba5bfb2e-f679-41b2-93ef-fc795e2e92d4")).Constraints
						.Where(c => !c.IsValid(this, this.IsReturnParameter))
						.Select(c => c.GetErrorText(this, this.IsReturnParameter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Method":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("29d7eba7-6b87-438a-910d-1a2bf17d8215")).Constraints
						.Where(c => !c.IsValid(this, this.Method))
						.Select(c => c.GetErrorText(this, this.Method))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ParameterName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("25c82fbd-cf5d-4021-b549-fccb46e166b3")).Constraints
						.Where(c => !c.IsValid(this, this.ParameterName))
						.Select(c => c.GetErrorText(this, this.ParameterName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Method>(_fk_guid_Method.Value);
			else if (_fk_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.Find<Kistl.App.Base.Method>(_fk_Method.Value);
			else
				Method__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._IsList, binStream);
            BinarySerializer.ToStream(this._IsReturnParameter, binStream);
            BinarySerializer.ToStream(Method != null ? Method.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._Method_pos, binStream);
            BinarySerializer.ToStream(this._ParameterName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._IsList, binStream);
            BinarySerializer.FromStream(out this._IsReturnParameter, binStream);
            BinarySerializer.FromStream(out this._fk_Method, binStream);
            {
                var tmp = this._Method_pos;
                BinarySerializer.FromStream(out tmp, binStream);
                this._Method_pos = tmp;
            }
            BinarySerializer.FromStream(out this._ParameterName, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsReturnParameter, xml, "IsReturnParameter", "Kistl.App.Base");
            XmlStreamer.ToStream(Method != null ? Method.ID : (int?)null, xml, "Method", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Method_pos, xml, "Method_pos", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ParameterName, xml, "ParameterName", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsReturnParameter, xml, "IsReturnParameter", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Method, xml, "Method", "Kistl.App.Base");
            {
                var tmp = this._Method_pos;
                XmlStreamer.FromStream(ref tmp, xml, "Method_pos", "Kistl.App.Base");
                this._Method_pos = tmp;
            }
            XmlStreamer.FromStream(ref this._ParameterName, xml, "ParameterName", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsReturnParameter, xml, "IsReturnParameter", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Method != null ? Method.ExportGuid : (Guid?)null, xml, "Method", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Method_pos, xml, "Method_pos", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ParameterName, xml, "ParameterName", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsReturnParameter, xml, "IsReturnParameter", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Method, xml, "Method", "Kistl.App.Base");
            {
                var tmp = this._Method_pos;
                XmlStreamer.FromStream(ref tmp, xml, "Method_pos", "Kistl.App.Base");
                this._Method_pos = tmp;
            }
            XmlStreamer.FromStream(ref this._ParameterName, xml, "ParameterName", "Kistl.App.Base");
        }

#endregion

    }


}