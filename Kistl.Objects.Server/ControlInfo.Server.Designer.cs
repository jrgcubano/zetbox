// <autogenerated/>


namespace Kistl.App.GUI
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
    [EdmEntityType(NamespaceName="Model", Name="ControlInfo")]
    [System.Diagnostics.DebuggerDisplay("ControlInfo")]
    public class ControlInfo__Implementation__ : BaseServerDataObject_EntityFramework, ControlInfo
    {
    
		public ControlInfo__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
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
        /// The assembly containing the Control
        /// </summary>
    /*
    Relation: FK_ControlInfo_Assembly_ControlInfo_51
    A: ZeroOrMore ControlInfo as ControlInfo
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        private int? _fk_Assembly;
        private Guid? _fk_guid_Assembly = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ControlInfo_Assembly_ControlInfo_51", "Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ Assembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_ControlInfo_Assembly_ControlInfo_51",
                        "Assembly");
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
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_ControlInfo_Assembly_ControlInfo_51",
                        "Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// The name of the class implementing this Control
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ClassName != value)
                {
					var __oldValue = _ClassName;
                    NotifyPropertyChanging("ClassName", __oldValue, value);
                    _ClassName = value;
                    NotifyPropertyChanged("ClassName", __oldValue, value);
                }
            }
        }
        private string _ClassName;

        /// <summary>
        /// The type of Control of this implementation
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ControlType != value)
                {
					var __oldValue = _ControlType;
                    NotifyPropertyChanging("ControlType", "ControlType__Implementation__", __oldValue, value);
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType", "ControlType__Implementation__", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for ControlType</summary>
        private Kistl.App.GUI.VisualType _ControlType;
        
        /// <summary>EF sees only this property, for ControlType</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int ControlType__Implementation__
        {
            get
            {
                return (int)this.ControlType;
            }
            set
            {
                this.ControlType = (Kistl.App.GUI.VisualType)value;
            }
        }
        

        /// <summary>
        /// Whether or not this Control can contain other Controls
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool IsContainer
        {
            get
            {
                return _IsContainer;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_IsContainer != value)
                {
					var __oldValue = _IsContainer;
                    NotifyPropertyChanging("IsContainer", __oldValue, value);
                    _IsContainer = value;
                    NotifyPropertyChanged("IsContainer", __oldValue, value);
                }
            }
        }
        private bool _IsContainer;

        /// <summary>
        /// The toolkit of this Control.
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.GUI.Toolkit Platform
        {
            get
            {
                return _Platform;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Platform != value)
                {
					var __oldValue = _Platform;
                    NotifyPropertyChanging("Platform", "Platform__Implementation__", __oldValue, value);
                    _Platform = value;
                    NotifyPropertyChanged("Platform", "Platform__Implementation__", __oldValue, value);
                }
            }
        }
        
        /// <summary>backing store for Platform</summary>
        private Kistl.App.GUI.Toolkit _Platform;
        
        /// <summary>EF sees only this property, for Platform</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int Platform__Implementation__
        {
            get
            {
                return (int)this.Platform;
            }
            set
            {
                this.Platform = (Kistl.App.GUI.Toolkit)value;
            }
        }
        

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ControlInfo));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ControlInfo)obj;
			var otherImpl = (ControlInfo__Implementation__)obj;
			var me = (ControlInfo)this;

			me.ClassName = other.ClassName;
			me.ControlType = other.ControlType;
			me.IsContainer = other.IsContainer;
			me.Platform = other.Platform;
			this._fk_Assembly = otherImpl._fk_Assembly;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ControlInfo != null)
            {
                OnToString_ControlInfo(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ControlInfo> OnToString_ControlInfo;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ControlInfo != null) OnPreSave_ControlInfo(this);
        }
        public event ObjectEventHandler<ControlInfo> OnPreSave_ControlInfo;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ControlInfo != null) OnPostSave_ControlInfo(this);
        }
        public event ObjectEventHandler<ControlInfo> OnPostSave_ControlInfo;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assembly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(114).Constraints
						.Where(c => !c.IsValid(this, this.Assembly))
						.Select(c => c.GetErrorText(this, this.Assembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ClassName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(115).Constraints
						.Where(c => !c.IsValid(this, this.ClassName))
						.Select(c => c.GetErrorText(this, this.ClassName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ControlType":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(118).Constraints
						.Where(c => !c.IsValid(this, this.ControlType))
						.Select(c => c.GetErrorText(this, this.ControlType))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsContainer":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(116).Constraints
						.Where(c => !c.IsValid(this, this.IsContainer))
						.Select(c => c.GetErrorText(this, this.IsContainer))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Platform":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(117).Constraints
						.Where(c => !c.IsValid(this, this.Platform))
						.Select(c => c.GetErrorText(this, this.Platform))
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

			if (_fk_guid_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_guid_Assembly.Value);
			else if (_fk_Assembly.HasValue)
				Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.Find<Kistl.App.Base.Assembly>(_fk_Assembly.Value);
			else
				Assembly__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(Assembly != null ? Assembly.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ClassName, binStream);
            BinarySerializer.ToStream((int)((ControlInfo)this).ControlType, binStream);
            BinarySerializer.ToStream(this._IsContainer, binStream);
            BinarySerializer.ToStream((int)((ControlInfo)this).Platform, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Assembly, binStream);
            BinarySerializer.FromStream(out this._ClassName, binStream);
            BinarySerializer.FromStreamConverter(v => ((ControlInfo)this).ControlType = (Kistl.App.GUI.VisualType)v, binStream);
            BinarySerializer.FromStream(out this._IsContainer, binStream);
            BinarySerializer.FromStreamConverter(v => ((ControlInfo)this).Platform = (Kistl.App.GUI.Toolkit)v, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(Assembly != null ? Assembly.ID : (int?)null, xml, "Assembly", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ClassName, xml, "ClassName", "Kistl.App.GUI");
            XmlStreamer.ToStream((int)this.ControlType, xml, "ControlType", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._IsContainer, xml, "IsContainer", "Kistl.App.GUI");
            XmlStreamer.ToStream((int)this.Platform, xml, "Platform", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Assembly, xml, "Assembly", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ClassName, xml, "ClassName", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ControlInfo)this).ControlType = (Kistl.App.GUI.VisualType)v, xml, "ControlType", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsContainer, xml, "IsContainer", "Kistl.App.GUI");
            XmlStreamer.FromStreamConverter(v => ((ControlInfo)this).Platform = (Kistl.App.GUI.Toolkit)v, xml, "Platform", "Kistl.App.GUI");
        }

#endregion

    }


}