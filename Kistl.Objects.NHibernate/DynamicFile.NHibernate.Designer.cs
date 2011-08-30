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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// File with changeable content
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DynamicFile")]
    public class DynamicFileNHibernateImpl : at.dasz.DocumentManagement.FileNHibernateImpl, DynamicFile
    {
        public DynamicFileNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public DynamicFileNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new DynamicFileProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DynamicFileNHibernateImpl(Func<IFrozenContext> lazyCtx, DynamicFileProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly DynamicFileProxy Proxy;

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnHandleBlobChange_DynamicFile")]
        public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_DynamicFile != null)
            {
                OnHandleBlobChange_DynamicFile(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
        public static event HandleBlobChange_Handler<DynamicFile> OnHandleBlobChange_DynamicFile;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_DynamicFile")]
        public override void Open()
        {
            // base.Open();
            if (OnOpen_DynamicFile != null)
            {
                OnOpen_DynamicFile(this);
            }
            else
            {
                base.Open();
            }
        }
        public static event Open_Handler<DynamicFile> OnOpen_DynamicFile;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_DynamicFile")]
        public override void Upload()
        {
            // base.Upload();
            if (OnUpload_DynamicFile != null)
            {
                OnUpload_DynamicFile(this);
            }
            else
            {
                base.Upload();
            }
        }
        public static event Upload_Handler<DynamicFile> OnUpload_DynamicFile;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DynamicFile);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DynamicFile)obj;
            var otherImpl = (DynamicFileNHibernateImpl)obj;
            var me = (DynamicFile)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DynamicFile")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DynamicFile != null)
            {
                OnToString_DynamicFile(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DynamicFile> OnToString_DynamicFile;

        [EventBasedMethod("OnPreSave_DynamicFile")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DynamicFile != null) OnPreSave_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnPreSave_DynamicFile;

        [EventBasedMethod("OnPostSave_DynamicFile")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DynamicFile != null) OnPostSave_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnPostSave_DynamicFile;

        [EventBasedMethod("OnCreated_DynamicFile")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DynamicFile != null) OnCreated_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnCreated_DynamicFile;

        [EventBasedMethod("OnDeleting_DynamicFile")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DynamicFile != null) OnDeleting_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnDeleting_DynamicFile;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();


            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();


            return result;
        }


        public class DynamicFileProxy
            : at.dasz.DocumentManagement.FileNHibernateImpl.FileProxy
        {
            public DynamicFileProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(DynamicFileNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(DynamicFileProxy); } }

        }

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