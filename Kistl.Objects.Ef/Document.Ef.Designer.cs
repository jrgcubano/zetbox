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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Document with revisions
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Document")]
    [System.Diagnostics.DebuggerDisplay("Document")]
    public class DocumentEfImpl : at.dasz.DocumentManagement.FileEfImpl, Document
    {
        [Obsolete]
        public DocumentEfImpl()
            : base(null)
        {
        }

        public DocumentEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
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
        // Kistl.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.Blob> Revisions
        {
            get
            {
                if (_Revisions == null)
                {
                    _Revisions = new BSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl, EntityCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl>>(
                            this,
                            RevisionsImpl);
                }
                return _Revisions;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Document_has_Revisions_A", "CollectionEntry")]
        public EntityCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl> RevisionsImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl>(
                        "Model.FK_Document_has_Revisions_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private BSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl, EntityCollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryEfImpl>> _Revisions;

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(Document);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Document)obj;
            var otherImpl = (DocumentEfImpl)obj;
            var me = (Document)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }


        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<DocumentEfImpl, IList<Kistl.App.Base.Blob>>(
                        lazyCtx,
                        new Guid("ec544fe0-8189-4bb2-a3d1-3cb61d815aa5"),
                        "Revisions",
                        null,
                        obj => obj.Revisions,
                        null), // lists are read-only properties
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
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