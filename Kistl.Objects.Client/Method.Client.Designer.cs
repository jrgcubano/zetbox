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

    using Kistl.API.Client;
    using Kistl.DalProvider.ClientObjects;

    /// <summary>
    /// Metadefinition Object for Methods.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Method")]
    public class Method__Implementation__ : BaseClientDataObject_ClientObjects, Method, Kistl.API.IExportableInternal
    {
    
		public Method__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Description of this Method
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Guid ExportGuid
        {
            get
            {
                return _ExportGuid;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// Shows this Method in th GUI
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool IsDisplayable
        {
            get
            {
                return _IsDisplayable;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_IsDisplayable != value)
                {
					var __oldValue = _IsDisplayable;
                    NotifyPropertyChanging("IsDisplayable", __oldValue, value);
                    _IsDisplayable = value;
                    NotifyPropertyChanged("IsDisplayable", __oldValue, value);
                }
            }
        }
        private bool _IsDisplayable;

        /// <summary>
        /// Methodenaufrufe implementiert in dieser Objekt Klasse
        /// </summary>
        // object list property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.MethodInvocation> MethodInvokations
        {
            get
            {
                if (_MethodInvokationsWrapper == null)
                {
                    List<Kistl.App.Base.MethodInvocation> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
						serverList = Context.GetListOf<Kistl.App.Base.MethodInvocation>(this, "MethodInvokations");
					}
                    else
                    {
                        serverList = new List<Kistl.App.Base.MethodInvocation>();
                    }
                        
                    _MethodInvokationsWrapper = new OneNRelationCollection<Kistl.App.Base.MethodInvocation>(
                        "Method",
                        this,
                        serverList);
                }
                return _MethodInvokationsWrapper;
            }
        }
        
        private OneNRelationCollection<Kistl.App.Base.MethodInvocation> _MethodInvokationsWrapper;


        /// <summary>
        /// 
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string MethodName
        {
            get
            {
                return _MethodName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_MethodName != value)
                {
					var __oldValue = _MethodName;
                    NotifyPropertyChanging("MethodName", __oldValue, value);
                    _MethodName = value;
                    NotifyPropertyChanged("MethodName", __oldValue, value);
                }
            }
        }
        private string _MethodName;

        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
        // object reference property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (_fk_Module.HasValue)
                    return Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Module == null)
					return;
                else if (value != null && value.ID == _fk_Module)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Module;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Module", oldValue, value);
                
				// next, set the local reference
                _fk_Module = value == null ? (int?)null : value.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Module", oldValue, value);
            }
        }
        
        private int? _fk_Module;

        /// <summary>
        /// 
        /// </summary>
        // object reference property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType ObjectClass
        {
            get
            {
                if (_fk_ObjectClass.HasValue)
                    return Context.Find<Kistl.App.Base.DataType>(_fk_ObjectClass.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_ObjectClass == null)
					return;
                else if (value != null && value.ID == _fk_ObjectClass)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = ObjectClass;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("ObjectClass", oldValue, value);
                
				// next, set the local reference
                _fk_ObjectClass = value == null ? (int?)null : value.ID;
				
				// now fixup redundant, inverse references
				// The inverse navigator will also fire events when changed, so should 
				// only be touched after setting the local value above. 
				// TODO: for complete correctness, the "other" Changing event should also fire 
				//       before the local value is changed
				if (oldValue != null)
				{
					// remove from old list
					(oldValue.Methods as OneNRelationCollection<Kistl.App.Base.Method>).RemoveWithoutClearParent(this);
				}

                if (value != null)
                {
					// add to new list
					(value.Methods as OneNRelationCollection<Kistl.App.Base.Method>).AddWithoutSetParent(this);
                }
				// everything is done. fire the Changed event
				NotifyPropertyChanged("ObjectClass", oldValue, value);
            }
        }
        
        private int? _fk_ObjectClass;

        /// <summary>
        /// Parameter der Methode
        /// </summary>
        // object list property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.BaseParameter> Parameter
        {
            get
            {
                if (_ParameterWrapper == null)
                {
                    List<Kistl.App.Base.BaseParameter> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
						serverList = Context.GetListOf<Kistl.App.Base.BaseParameter>(this, "Parameter");
					}
                    else
                    {
                        serverList = new List<Kistl.App.Base.BaseParameter>();
                    }
                        
                    _ParameterWrapper = new OneNRelationCollection<Kistl.App.Base.BaseParameter>(
                        "Method",
                        this,
                        serverList);
                }
                return _ParameterWrapper;
            }
        }
        
        private OneNRelationCollection<Kistl.App.Base.BaseParameter> _ParameterWrapper;


        /// <summary>
        /// Returns the Return Parameter Meta Object of this Method Meta Object.
        /// </summary>

		public virtual Kistl.App.Base.BaseParameter GetReturnParameter() 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.BaseParameter>();
            if (OnGetReturnParameter_Method != null)
            {
                OnGetReturnParameter_Method(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Method.GetReturnParameter");
            }
            return e.Result;
        }
		public delegate void GetReturnParameter_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.BaseParameter> ret);
		public event GetReturnParameter_Handler<Method> OnGetReturnParameter_Method;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Method));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Method)obj;
			var otherImpl = (Method__Implementation__)obj;
			var me = (Method)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.IsDisplayable = other.IsDisplayable;
			me.MethodName = other.MethodName;
			this._fk_Module = otherImpl._fk_Module;
			this._fk_ObjectClass = otherImpl._fk_ObjectClass;
		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Method != null)
            {
                OnToString_Method(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Method> OnToString_Method;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Method != null) OnPreSave_Method(this);
        }
        public event ObjectEventHandler<Method> OnPreSave_Method;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Method != null) OnPostSave_Method(this);
        }
        public event ObjectEventHandler<Method> OnPostSave_Method;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(180).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(257).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsDisplayable":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(124).Constraints
						.Where(c => !c.IsValid(this, this.IsDisplayable))
						.Select(c => c.GetErrorText(this, this.IsDisplayable))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MethodInvokations":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(81).Constraints
						.Where(c => !c.IsValid(this, this.MethodInvokations))
						.Select(c => c.GetErrorText(this, this.MethodInvokations))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MethodName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(30).Constraints
						.Where(c => !c.IsValid(this, this.MethodName))
						.Select(c => c.GetErrorText(this, this.MethodName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(73).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ObjectClass":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(29).Constraints
						.Where(c => !c.IsValid(this, this.ObjectClass))
						.Select(c => c.GetErrorText(this, this.ObjectClass))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Parameter":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(96).Constraints
						.Where(c => !c.IsValid(this, this.Parameter))
						.Select(c => c.GetErrorText(this, this.Parameter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
                case "Module":
                    _fk_Module = id;
                    break;
                case "ObjectClass":
                    _fk_ObjectClass = id;
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._IsDisplayable, binStream);
            BinarySerializer.ToStream(this._MethodName, binStream);
            BinarySerializer.ToStream(this._fk_Module, binStream);
            BinarySerializer.ToStream(this._fk_ObjectClass, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._IsDisplayable, binStream);
            BinarySerializer.FromStream(out this._MethodName, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._fk_ObjectClass, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsDisplayable, xml, "IsDisplayable", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._MethodName, xml, "MethodName", "Kistl.App.Base");
            XmlStreamer.ToStream(this._fk_Module, xml, "Module", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._fk_ObjectClass, xml, "ObjectClass", "http://dasz.at/Kistl");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsDisplayable, xml, "IsDisplayable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._MethodName, xml, "MethodName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._fk_ObjectClass, xml, "ObjectClass", "http://dasz.at/Kistl");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsDisplayable, xml, "IsDisplayable", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MethodName, xml, "MethodName", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsDisplayable, xml, "IsDisplayable", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._MethodName, xml, "MethodName", "Kistl.App.Base");
        }

#endregion

    }


}