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
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for Enumerations.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Enumeration")]
    [System.Diagnostics.DebuggerDisplay("Enumeration")]
    public class Enumeration__Implementation__ : Kistl.App.Base.DataType__Implementation__, Enumeration
    {
    
		public Enumeration__Implementation__()
		{
        }


        /// <summary>
        /// Einträge der Enumeration
        /// </summary>
    /*
    Relation: FK_Enumeration_has_EnumerationEntries
    A: One Enumeration as Enumeration
    B: ZeroOrMore EnumerationEntry as EnumerationEntries
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.EnumerationEntry> EnumerationEntries
        {
            get
            {
                if (_EnumerationEntriesWrapper == null)
                {
                    _EnumerationEntriesWrapper = new EntityCollectionWrapper<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.EnumerationEntry__Implementation__>(
                            this.Context, EnumerationEntries__Implementation__);
                }
                return _EnumerationEntriesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Enumeration_has_EnumerationEntries", "EnumerationEntries")]
        public EntityCollection<Kistl.App.Base.EnumerationEntry__Implementation__> EnumerationEntries__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.EnumerationEntry__Implementation__>(
                        "Model.FK_Enumeration_has_EnumerationEntries",
                        "EnumerationEntries");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.EnumerationEntry, Kistl.App.Base.EnumerationEntry__Implementation__> _EnumerationEntriesWrapper;



        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetDataType_Enumeration")]
		public override System.Type GetDataType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_Enumeration != null)
            {
                OnGetDataType_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
		public static event GetDataType_Handler<Enumeration> OnGetDataType_Enumeration;



        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetDataTypeString_Enumeration")]
		public override string GetDataTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_Enumeration != null)
            {
                OnGetDataTypeString_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
		public static event GetDataTypeString_Handler<Enumeration> OnGetDataTypeString_Enumeration;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Enumeration));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Enumeration)obj;
			var otherImpl = (Enumeration__Implementation__)obj;
			var me = (Enumeration)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Enumeration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Enumeration != null)
            {
                OnToString_Enumeration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Enumeration> OnToString_Enumeration;

        [EventBasedMethod("OnPreSave_Enumeration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Enumeration != null) OnPreSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnPreSave_Enumeration;

        [EventBasedMethod("OnPostSave_Enumeration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Enumeration != null) OnPostSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnPostSave_Enumeration;

        [EventBasedMethod("OnCreated_Enumeration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Enumeration != null) OnCreated_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnCreated_Enumeration;

        [EventBasedMethod("OnDeleting_Enumeration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Enumeration != null) OnDeleting_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnDeleting_Enumeration;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "EnumerationEntries":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("1619c8a7-b969-4c05-851c-7a2545cda484")).Constraints
						.Where(c => !c.IsValid(this, this.EnumerationEntries))
						.Select(c => c.GetErrorText(this, this.EnumerationEntries))
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
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
        }

#endregion

    }


}