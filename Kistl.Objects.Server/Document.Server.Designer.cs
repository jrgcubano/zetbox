// <autogenerated/>


namespace at.dasz.DocumentManagement
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
    /// Document with revisions
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Document")]
    [System.Diagnostics.DebuggerDisplay("Document")]
    public class Document__Implementation__ : at.dasz.DocumentManagement.File__Implementation__, Document
    {
    
		public Document__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Document_has_Revisions
    A: ZeroOrMore Document as Document
    B: ZeroOrMore Blob as Revisions
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.Blob> Revisions
        {
            get
            {
                if (_RevisionsWrapper == null)
                {
                    _RevisionsWrapper = new EntityRelationBSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, at.dasz.DocumentManagement.Document_has_Blob_RelationEntry__Implementation__>(
                            this,
                            Revisions__Implementation__);
                }
                return _RevisionsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Document_has_Revisions_A", "CollectionEntry")]
        public EntityCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntry__Implementation__> Revisions__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntry__Implementation__>(
                        "Model.FK_Document_has_Revisions_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, at.dasz.DocumentManagement.Document_has_Blob_RelationEntry__Implementation__> _RevisionsWrapper;


        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
		[EventBasedMethod("OnHandleBlobChange_Document")]
		public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_Document != null)
            {
                OnHandleBlobChange_Document(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
		public static event HandleBlobChange_Handler<Document> OnHandleBlobChange_Document;



        /// <summary>
        /// Opens the Content readonly
        /// </summary>
		[EventBasedMethod("OnOpen_Document")]
		public override void Open() 
		{
            // base.Open();
            if (OnOpen_Document != null)
            {
				OnOpen_Document(this);
			}
			else
			{
			    base.Open();
			}
        }
		public static event Open_Handler<Document> OnOpen_Document;



        /// <summary>
        /// Uploads a new Content
        /// </summary>
		[EventBasedMethod("OnUpload_Document")]
		public override void Upload() 
		{
            // base.Upload();
            if (OnUpload_Document != null)
            {
				OnUpload_Document(this);
			}
			else
			{
			    base.Upload();
			}
        }
		public static event Upload_Handler<Document> OnUpload_Document;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Document));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Document)obj;
			var otherImpl = (Document__Implementation__)obj;
			var me = (Document)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Document")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Document != null)
            {
                OnToString_Document(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Document> OnToString_Document;

        [EventBasedMethod("OnPreSave_Document")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Document != null) OnPreSave_Document(this);
        }
        public static event ObjectEventHandler<Document> OnPreSave_Document;

        [EventBasedMethod("OnPostSave_Document")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Document != null) OnPostSave_Document(this);
        }
        public static event ObjectEventHandler<Document> OnPostSave_Document;

        [EventBasedMethod("OnCreated_Document")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Document != null) OnCreated_Document(this);
        }
        public static event ObjectEventHandler<Document> OnCreated_Document;

        [EventBasedMethod("OnDeleting_Document")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Document != null) OnDeleting_Document(this);
        }
        public static event ObjectEventHandler<Document> OnDeleting_Document;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Document__Implementation__, IList<Kistl.App.Base.Blob>>(
				new Guid("ec544fe0-8189-4bb2-a3d1-3cb61d815aa5"),
				"Revisions",
				null,
				obj => obj.Revisions,
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