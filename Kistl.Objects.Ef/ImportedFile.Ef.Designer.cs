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
    /// Files beeing imported by the import service.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ImportedFile")]
    [System.Diagnostics.DebuggerDisplay("ImportedFile")]
    public class ImportedFileEfImpl : at.dasz.DocumentManagement.FileEfImpl, ImportedFile
    {
        private static readonly Guid _objectClassID = new Guid("523a75bb-29c4-421c-9343-93d8658bb5f8");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public ImportedFileEfImpl()
            : base(null)
        {
        }

        public ImportedFileEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnHandleBlobChange_ImportedFile")]
        public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_ImportedFile != null)
            {
                OnHandleBlobChange_ImportedFile(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
        public static event HandleBlobChange_Handler<ImportedFile> OnHandleBlobChange_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnHandleBlobChange_ImportedFile_CanExec;

        [EventBasedMethod("OnHandleBlobChange_ImportedFile_CanExec")]
        public override bool HandleBlobChangeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnHandleBlobChange_ImportedFile_CanExec != null)
				{
					OnHandleBlobChange_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnHandleBlobChange_ImportedFile_CanExecReason;

        [EventBasedMethod("OnHandleBlobChange_ImportedFile_CanExecReason")]
        public override string HandleBlobChangeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnHandleBlobChange_ImportedFile_CanExecReason != null)
				{
					OnHandleBlobChange_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Converts the imported file to a document
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnMakeDocument_ImportedFile")]
        public virtual at.dasz.DocumentManagement.Document MakeDocument()
        {
            var e = new MethodReturnEventArgs<at.dasz.DocumentManagement.Document>();
            if (OnMakeDocument_ImportedFile != null)
            {
                OnMakeDocument_ImportedFile(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ImportedFile.MakeDocument");
            }
            return e.Result;
        }
        public delegate void MakeDocument_Handler<T>(T obj, MethodReturnEventArgs<at.dasz.DocumentManagement.Document> ret);
        public static event MakeDocument_Handler<ImportedFile> OnMakeDocument_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnMakeDocument_ImportedFile_CanExec;

        [EventBasedMethod("OnMakeDocument_ImportedFile_CanExec")]
        public virtual bool MakeDocumentCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnMakeDocument_ImportedFile_CanExec != null)
				{
					OnMakeDocument_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnMakeDocument_ImportedFile_CanExecReason;

        [EventBasedMethod("OnMakeDocument_ImportedFile_CanExecReason")]
        public virtual string MakeDocumentCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnMakeDocument_ImportedFile_CanExecReason != null)
				{
					OnMakeDocument_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnMakeDynamicFile_ImportedFile")]
        public virtual at.dasz.DocumentManagement.DynamicFile MakeDynamicFile()
        {
            var e = new MethodReturnEventArgs<at.dasz.DocumentManagement.DynamicFile>();
            if (OnMakeDynamicFile_ImportedFile != null)
            {
                OnMakeDynamicFile_ImportedFile(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ImportedFile.MakeDynamicFile");
            }
            return e.Result;
        }
        public delegate void MakeDynamicFile_Handler<T>(T obj, MethodReturnEventArgs<at.dasz.DocumentManagement.DynamicFile> ret);
        public static event MakeDynamicFile_Handler<ImportedFile> OnMakeDynamicFile_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnMakeDynamicFile_ImportedFile_CanExec;

        [EventBasedMethod("OnMakeDynamicFile_ImportedFile_CanExec")]
        public virtual bool MakeDynamicFileCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnMakeDynamicFile_ImportedFile_CanExec != null)
				{
					OnMakeDynamicFile_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnMakeDynamicFile_ImportedFile_CanExecReason;

        [EventBasedMethod("OnMakeDynamicFile_ImportedFile_CanExecReason")]
        public virtual string MakeDynamicFileCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnMakeDynamicFile_ImportedFile_CanExecReason != null)
				{
					OnMakeDynamicFile_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnMakeStaticFile_ImportedFile")]
        public virtual at.dasz.DocumentManagement.StaticFile MakeStaticFile()
        {
            var e = new MethodReturnEventArgs<at.dasz.DocumentManagement.StaticFile>();
            if (OnMakeStaticFile_ImportedFile != null)
            {
                OnMakeStaticFile_ImportedFile(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ImportedFile.MakeStaticFile");
            }
            return e.Result;
        }
        public delegate void MakeStaticFile_Handler<T>(T obj, MethodReturnEventArgs<at.dasz.DocumentManagement.StaticFile> ret);
        public static event MakeStaticFile_Handler<ImportedFile> OnMakeStaticFile_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnMakeStaticFile_ImportedFile_CanExec;

        [EventBasedMethod("OnMakeStaticFile_ImportedFile_CanExec")]
        public virtual bool MakeStaticFileCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnMakeStaticFile_ImportedFile_CanExec != null)
				{
					OnMakeStaticFile_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnMakeStaticFile_ImportedFile_CanExecReason;

        [EventBasedMethod("OnMakeStaticFile_ImportedFile_CanExecReason")]
        public virtual string MakeStaticFileCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnMakeStaticFile_ImportedFile_CanExecReason != null)
				{
					OnMakeStaticFile_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_ImportedFile")]
        public override void Open()
        {
            // base.Open();
            if (OnOpen_ImportedFile != null)
            {
                OnOpen_ImportedFile(this);
            }
            else
            {
                base.Open();
            }
        }
        public static event Open_Handler<ImportedFile> OnOpen_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnOpen_ImportedFile_CanExec;

        [EventBasedMethod("OnOpen_ImportedFile_CanExec")]
        public override bool OpenCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnOpen_ImportedFile_CanExec != null)
				{
					OnOpen_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.OpenCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnOpen_ImportedFile_CanExecReason;

        [EventBasedMethod("OnOpen_ImportedFile_CanExecReason")]
        public override string OpenCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnOpen_ImportedFile_CanExecReason != null)
				{
					OnOpen_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.OpenCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_ImportedFile")]
        public override void Upload()
        {
            // base.Upload();
            if (OnUpload_ImportedFile != null)
            {
                OnUpload_ImportedFile(this);
            }
            else
            {
                base.Upload();
            }
        }
        public static event Upload_Handler<ImportedFile> OnUpload_ImportedFile;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ImportedFile> OnUpload_ImportedFile_CanExec;

        [EventBasedMethod("OnUpload_ImportedFile_CanExec")]
        public override bool UploadCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnUpload_ImportedFile_CanExec != null)
				{
					OnUpload_ImportedFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.UploadCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ImportedFile> OnUpload_ImportedFile_CanExecReason;

        [EventBasedMethod("OnUpload_ImportedFile_CanExecReason")]
        public override string UploadCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnUpload_ImportedFile_CanExecReason != null)
				{
					OnUpload_ImportedFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.UploadCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ImportedFile);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ImportedFile)obj;
            var otherImpl = (ImportedFileEfImpl)obj;
            var me = (ImportedFile)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange


        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ImportedFile")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ImportedFile != null)
            {
                OnToString_ImportedFile(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ImportedFile> OnToString_ImportedFile;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ImportedFile")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ImportedFile != null)
            {
                OnObjectIsValid_ImportedFile(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ImportedFile> OnObjectIsValid_ImportedFile;

        [EventBasedMethod("OnNotifyPreSave_ImportedFile")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ImportedFile != null) OnNotifyPreSave_ImportedFile(this);
        }
        public static event ObjectEventHandler<ImportedFile> OnNotifyPreSave_ImportedFile;

        [EventBasedMethod("OnNotifyPostSave_ImportedFile")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ImportedFile != null) OnNotifyPostSave_ImportedFile(this);
        }
        public static event ObjectEventHandler<ImportedFile> OnNotifyPostSave_ImportedFile;

        [EventBasedMethod("OnNotifyCreated_ImportedFile")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_ImportedFile != null) OnNotifyCreated_ImportedFile(this);
        }
        public static event ObjectEventHandler<ImportedFile> OnNotifyCreated_ImportedFile;

        [EventBasedMethod("OnNotifyDeleting_ImportedFile")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ImportedFile != null) OnNotifyDeleting_ImportedFile(this);
        }
        public static event ObjectEventHandler<ImportedFile> OnNotifyDeleting_ImportedFile;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Kistl.API.KistlStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(Kistl.API.KistlStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        #endregion

    }
}