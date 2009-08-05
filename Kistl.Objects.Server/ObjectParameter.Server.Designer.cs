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
    /// Metadefinition Object for Object Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectParameter")]
    [System.Diagnostics.DebuggerDisplay("ObjectParameter")]
    public class ObjectParameter__Implementation__ : Kistl.App.Base.BaseParameter__Implementation__, ObjectParameter
    {
    
		public ObjectParameter__Implementation__()
		{
        }


        /// <summary>
        /// Kistl-Typ des Parameters
        /// </summary>
    /*
    Relation: FK_ObjectParameter_has_DataType
    A: ZeroOrMore ObjectParameter as ObjectParameter
    B: ZeroOrOne DataType as DataType
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType DataType
        {
            get
            {
                return DataType__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                DataType__Implementation__ = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        private int? _fk_DataType;
        private Guid? _fk_guid_DataType = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ObjectParameter_has_DataType", "DataType")]
        public Kistl.App.Base.DataType__Implementation__ DataType__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_ObjectParameter_has_DataType",
                        "DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnDataType_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.DataType>(__value);
					OnDataType_Getter(this, e);
					__value = (Kistl.App.Base.DataType__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_ObjectParameter_has_DataType",
                        "DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.DataType __oldValue = (Kistl.App.Base.DataType)r.Value;
                Kistl.App.Base.DataType __newValue = (Kistl.App.Base.DataType)value;

                if(OnDataType_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnDataType_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.DataType__Implementation__)__newValue;
                if(OnDataType_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnDataType_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.ObjectParameter, Kistl.App.Base.DataType> OnDataType_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.ObjectParameter, Kistl.App.Base.DataType> OnDataType_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.ObjectParameter, Kistl.App.Base.DataType> OnDataType_PostSetter;
        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterType_ObjectParameter")]
		public override System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_ObjectParameter != null)
            {
                OnGetParameterType_ObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
		public event GetParameterType_Handler<ObjectParameter> OnGetParameterType_ObjectParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterTypeString_ObjectParameter")]
		public override string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_ObjectParameter != null)
            {
                OnGetParameterTypeString_ObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
		public event GetParameterTypeString_Handler<ObjectParameter> OnGetParameterTypeString_ObjectParameter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ObjectParameter));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ObjectParameter)obj;
			var otherImpl = (ObjectParameter__Implementation__)obj;
			var me = (ObjectParameter)this;

			this._fk_DataType = otherImpl._fk_DataType;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectParameter != null)
            {
                OnToString_ObjectParameter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ObjectParameter> OnToString_ObjectParameter;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectParameter != null) OnPreSave_ObjectParameter(this);
        }
        public event ObjectEventHandler<ObjectParameter> OnPreSave_ObjectParameter;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectParameter != null) OnPostSave_ObjectParameter(this);
        }
        public event ObjectEventHandler<ObjectParameter> OnPostSave_ObjectParameter;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectParameter != null) OnCreated_ObjectParameter(this);
        }
        public event ObjectEventHandler<ObjectParameter> OnCreated_ObjectParameter;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectParameter != null) OnDeleting_ObjectParameter(this);
        }
        public event ObjectEventHandler<ObjectParameter> OnDeleting_ObjectParameter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "DataType":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("9bd64c60-7282-47f0-8069-528a175fcc92")).Constraints
						.Where(c => !c.IsValid(this, this.DataType))
						.Select(c => c.GetErrorText(this, this.DataType))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_DataType.HasValue)
				DataType__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.DataType>(_fk_guid_DataType.Value);
			else if (_fk_DataType.HasValue)
				DataType__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.Find<Kistl.App.Base.DataType>(_fk_DataType.Value);
			else
				DataType__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(DataType != null ? DataType.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_DataType, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(DataType != null ? DataType.ID : (int?)null, xml, "DataType", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_DataType, xml, "DataType", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(DataType != null ? DataType.ExportGuid : (Guid?)null, xml, "DataType", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_DataType, xml, "DataType", "Kistl.App.Base");
        }

#endregion

    }


}