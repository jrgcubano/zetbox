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
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringListKind")]
    [System.Diagnostics.DebuggerDisplay("StringListKind")]
    public class StringListKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, StringListKind
    {
    
		public StringListKind__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_List_has_ItemKind
    A: ZeroOrMore StringListKind as List
    B: One ControlKindClass as ItemKind
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.ControlKindClass ItemKind
        {
            get
            {
                return ItemKind__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                ItemKind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)value;
            }
        }
        
        private int? _fk_ItemKind;
        private Guid? _fk_guid_ItemKind = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_List_has_ItemKind", "ItemKind")]
        public Kistl.App.GUI.ControlKindClass__Implementation__ ItemKind__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.ControlKindClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindClass__Implementation__>(
                        "Model.FK_List_has_ItemKind",
                        "ItemKind");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnItemKind_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.GUI.ControlKindClass>(__value);
					OnItemKind_Getter(this, e);
					__value = (Kistl.App.GUI.ControlKindClass__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.ControlKindClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.ControlKindClass__Implementation__>(
                        "Model.FK_List_has_ItemKind",
                        "ItemKind");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.GUI.ControlKindClass __oldValue = (Kistl.App.GUI.ControlKindClass)r.Value;
                Kistl.App.GUI.ControlKindClass __newValue = (Kistl.App.GUI.ControlKindClass)value;

                if(OnItemKind_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ControlKindClass>(__oldValue, __newValue);
					OnItemKind_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.GUI.ControlKindClass__Implementation__)__newValue;
                if(OnItemKind_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ControlKindClass>(__oldValue, __newValue);
					OnItemKind_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.GUI.StringListKind, Kistl.App.GUI.ControlKindClass> OnItemKind_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.StringListKind, Kistl.App.GUI.ControlKindClass> OnItemKind_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.StringListKind, Kistl.App.GUI.ControlKindClass> OnItemKind_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StringListKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StringListKind)obj;
			var otherImpl = (StringListKind__Implementation__)obj;
			var me = (StringListKind)this;

			this._fk_ItemKind = otherImpl._fk_ItemKind;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_StringListKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringListKind != null)
            {
                OnToString_StringListKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StringListKind> OnToString_StringListKind;

        [EventBasedMethod("OnPreSave_StringListKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringListKind != null) OnPreSave_StringListKind(this);
        }
        public static event ObjectEventHandler<StringListKind> OnPreSave_StringListKind;

        [EventBasedMethod("OnPostSave_StringListKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringListKind != null) OnPostSave_StringListKind(this);
        }
        public static event ObjectEventHandler<StringListKind> OnPostSave_StringListKind;

        [EventBasedMethod("OnCreated_StringListKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringListKind != null) OnCreated_StringListKind(this);
        }
        public static event ObjectEventHandler<StringListKind> OnCreated_StringListKind;

        [EventBasedMethod("OnDeleting_StringListKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringListKind != null) OnDeleting_StringListKind(this);
        }
        public static event ObjectEventHandler<StringListKind> OnDeleting_StringListKind;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			new CustomPropertyDescriptor<StringListKind, Kistl.App.GUI.ControlKindClass>(
				new Guid("14270073-da33-4c5e-b6ef-c4e71e3ccee0"),
				"ItemKind",
				null,
				obj => obj.ItemKind,
				(obj, val) => obj.ItemKind = val),
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
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_ItemKind.HasValue)
				ItemKind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.ControlKindClass>(_fk_guid_ItemKind.Value);
			else if (_fk_ItemKind.HasValue)
				ItemKind__Implementation__ = (Kistl.App.GUI.ControlKindClass__Implementation__)Context.Find<Kistl.App.GUI.ControlKindClass>(_fk_ItemKind.Value);
			else
				ItemKind__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(ItemKind != null ? ItemKind.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_ItemKind, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(ItemKind != null ? ItemKind.ID : (int?)null, xml, "ItemKind", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_ItemKind, xml, "ItemKind", "Kistl.App.GUI");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(ItemKind != null ? ItemKind.ExportGuid : (Guid?)null, xml, "ItemKind", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_ItemKind, xml, "ItemKind", "Kistl.App.GUI");
        }

#endregion

    }


}