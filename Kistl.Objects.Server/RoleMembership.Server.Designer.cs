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
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="RoleMembership")]
    [System.Diagnostics.DebuggerDisplay("RoleMembership")]
    public class RoleMembership__Implementation__ : Kistl.App.Base.AccessControl__Implementation__, RoleMembership
    {
    
		public RoleMembership__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_RoleMembership_resolves_Relations
    A: ZeroOrMore RoleMembership as RoleMembership
    B: ZeroOrMore Relation as Relations
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.Relation> Relations
        {
            get
            {
                if (_RelationsWrapper == null)
                {
                    _RelationsWrapper = new EntityRelationBSideListWrapper<Kistl.App.Base.RoleMembership, Kistl.App.Base.Relation, Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntry__Implementation__>(
                            this,
                            Relations__Implementation__);
                }
                return _RelationsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_RoleMembership_resolves_Relations_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntry__Implementation__> Relations__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntry__Implementation__>(
                        "Model.FK_RoleMembership_resolves_Relations_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideListWrapper<Kistl.App.Base.RoleMembership, Kistl.App.Base.Relation, Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntry__Implementation__> _RelationsWrapper;


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(RoleMembership));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (RoleMembership)obj;
			var otherImpl = (RoleMembership__Implementation__)obj;
			var me = (RoleMembership)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_RoleMembership")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RoleMembership != null)
            {
                OnToString_RoleMembership(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RoleMembership> OnToString_RoleMembership;

        [EventBasedMethod("OnPreSave_RoleMembership")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_RoleMembership != null) OnPreSave_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnPreSave_RoleMembership;

        [EventBasedMethod("OnPostSave_RoleMembership")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_RoleMembership != null) OnPostSave_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnPostSave_RoleMembership;

        [EventBasedMethod("OnCreated_RoleMembership")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_RoleMembership != null) OnCreated_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnCreated_RoleMembership;

        [EventBasedMethod("OnDeleting_RoleMembership")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_RoleMembership != null) OnDeleting_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnDeleting_RoleMembership;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<RoleMembership__Implementation__, IList<Kistl.App.Base.Relation>>(
				new Guid("fb799900-1a5b-4b62-a445-5dae8febdd28"),
				"Relations",
				null,
				obj => obj.Relations,
				null), // lists are read-only properties
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