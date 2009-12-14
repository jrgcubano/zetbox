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
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CLRObjectParameter")]
    [System.Diagnostics.DebuggerDisplay("CLRObjectParameter")]
    public class CLRObjectParameter__Implementation__ : Kistl.App.Base.BaseParameter__Implementation__, CLRObjectParameter
    {
    
		public CLRObjectParameter__Implementation__()
		{
        }


        /// <summary>
        /// Assembly des CLR Objektes, NULL für Default Assemblies
        /// </summary>
    /*
    Relation: FK_CLRObjectParameter_has_Assembly
    A: ZeroOrMore CLRObjectParameter as CLRObjectParameter
    B: ZeroOrOne Assembly as Assembly
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return Assembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        private int? _fk_Assembly;
        private Guid? _fk_guid_Assembly = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_CLRObjectParameter_has_Assembly", "Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ Assembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_CLRObjectParameter_has_Assembly",
                        "Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnAssembly_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Assembly>(__value);
					OnAssembly_Getter(this, e);
					__value = (Kistl.App.Base.Assembly__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_CLRObjectParameter_has_Assembly",
                        "Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Assembly __oldValue = (Kistl.App.Base.Assembly)r.Value;
                Kistl.App.Base.Assembly __newValue = (Kistl.App.Base.Assembly)value;

                if(OnAssembly_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
					OnAssembly_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)__newValue;
                if(OnAssembly_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
					OnAssembly_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.Assembly> OnAssembly_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.Assembly> OnAssembly_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.Assembly> OnAssembly_PostSetter;
        /// <summary>
        /// Name des CLR Datentypen
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string FullTypeName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _FullTypeName;
                if (OnFullTypeName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnFullTypeName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_FullTypeName != value)
                {
                    var __oldValue = _FullTypeName;
                    var __newValue = value;
                    if(OnFullTypeName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnFullTypeName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("FullTypeName", __oldValue, __newValue);
                    _FullTypeName = __newValue;
                    NotifyPropertyChanged("FullTypeName", __oldValue, __newValue);
                    if(OnFullTypeName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnFullTypeName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _FullTypeName;
		public event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, string> OnFullTypeName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, string> OnFullTypeName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, string> OnFullTypeName_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ClrObjectParameter_isOf_Type
    A: ZeroOrMore CLRObjectParameter as ClrObjectParameter
    B: ZeroOrOne TypeRef as Type
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Type
        {
            get
            {
                return Type__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Type__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        private int? _fk_Type;
        private Guid? _fk_guid_Type = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ClrObjectParameter_isOf_Type", "Type")]
        public Kistl.App.Base.TypeRef__Implementation__ Type__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_ClrObjectParameter_isOf_Type",
                        "Type");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnType_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
					OnType_Getter(this, e);
					__value = (Kistl.App.Base.TypeRef__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_ClrObjectParameter_isOf_Type",
                        "Type");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.TypeRef __oldValue = (Kistl.App.Base.TypeRef)r.Value;
                Kistl.App.Base.TypeRef __newValue = (Kistl.App.Base.TypeRef)value;

                if(OnType_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnType_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)__newValue;
                if(OnType_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnType_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PostSetter;
        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterType_CLRObjectParameter")]
		public override System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CLRObjectParameter != null)
            {
                OnGetParameterType_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
		public event GetParameterType_Handler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter")]
		public override string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CLRObjectParameter != null)
            {
                OnGetParameterTypeString_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
		public event GetParameterTypeString_Handler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(CLRObjectParameter));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (CLRObjectParameter)obj;
			var otherImpl = (CLRObjectParameter__Implementation__)obj;
			var me = (CLRObjectParameter)this;

			me.FullTypeName = other.FullTypeName;
			this._fk_Assembly = otherImpl._fk_Assembly;
			this._fk_Type = otherImpl._fk_Type;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CLRObjectParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;

        [EventBasedMethod("OnPreSave_CLRObjectParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CLRObjectParameter != null) OnPreSave_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnPreSave_CLRObjectParameter;

        [EventBasedMethod("OnPostSave_CLRObjectParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CLRObjectParameter != null) OnPostSave_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnPostSave_CLRObjectParameter;

        [EventBasedMethod("OnCreated_CLRObjectParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CLRObjectParameter != null) OnCreated_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnCreated_CLRObjectParameter;

        [EventBasedMethod("OnDeleting_CLRObjectParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CLRObjectParameter != null) OnDeleting_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnDeleting_CLRObjectParameter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assembly":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("304b34ac-b581-40ce-826c-0fc0cab93bb6")).Constraints
						.Where(c => !c.IsValid(this, this.Assembly))
						.Select(c => c.GetErrorText(this, this.Assembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "FullTypeName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("7aa087db-ef36-4a93-9bc8-e0e34c9d4d4b")).Constraints
						.Where(c => !c.IsValid(this, this.FullTypeName))
						.Select(c => c.GetErrorText(this, this.FullTypeName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Type":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("137292ce-4493-451d-a7fa-1b7cc7df03dd")).Constraints
						.Where(c => !c.IsValid(this, this.Type))
						.Select(c => c.GetErrorText(this, this.Type))
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
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_guid_Assembly.Value);
			else if (_fk_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.Find<Kistl.App.Base.Assembly>(_fk_Assembly.Value);
			else
				Assembly__Implementation__ = null;

			if (_fk_guid_Type.HasValue)
				Type__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Type.Value);
			else if (_fk_Type.HasValue)
				Type__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.Find<Kistl.App.Base.TypeRef>(_fk_Type.Value);
			else
				Type__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(Assembly != null ? Assembly.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._FullTypeName, binStream);
            BinarySerializer.ToStream(Type != null ? Type.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Assembly, binStream);
            BinarySerializer.FromStream(out this._FullTypeName, binStream);
            BinarySerializer.FromStream(out this._fk_Type, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(Assembly != null ? Assembly.ID : (int?)null, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.ToStream(this._FullTypeName, xml, "FullTypeName", "Kistl.App.Base");
            XmlStreamer.ToStream(Type != null ? Type.ID : (int?)null, xml, "Type", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Assembly, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullTypeName, xml, "FullTypeName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Type, xml, "Type", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Assembly != null ? Assembly.ExportGuid : (Guid?)null, xml, "Assembly", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._FullTypeName, xml, "FullTypeName", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Type != null ? Type.ExportGuid : (Guid?)null, xml, "Type", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_Assembly, xml, "Assembly", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullTypeName, xml, "FullTypeName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Type, xml, "Type", "Kistl.App.Base");
        }

#endregion

    }


}