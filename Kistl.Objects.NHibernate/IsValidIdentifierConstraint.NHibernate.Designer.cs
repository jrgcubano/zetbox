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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IsValidIdentifierConstraint")]
    public class IsValidIdentifierConstraintNHibernateImpl : Kistl.App.Base.ConstraintNHibernateImpl, IsValidIdentifierConstraint
    {
        public IsValidIdentifierConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IsValidIdentifierConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IsValidIdentifierConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IsValidIdentifierConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, IsValidIdentifierConstraintProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly IsValidIdentifierConstraintProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IsValidIdentifierConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IsValidIdentifierConstraint != null)
            {
                OnGetErrorText_IsValidIdentifierConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IsValidIdentifierConstraint> OnGetErrorText_IsValidIdentifierConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_IsValidIdentifierConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IsValidIdentifierConstraint != null)
            {
                OnIsValid_IsValidIdentifierConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IsValidIdentifierConstraint> OnIsValid_IsValidIdentifierConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(IsValidIdentifierConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IsValidIdentifierConstraint)obj;
            var otherImpl = (IsValidIdentifierConstraintNHibernateImpl)obj;
            var me = (IsValidIdentifierConstraint)this;

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
        [EventBasedMethod("OnToString_IsValidIdentifierConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IsValidIdentifierConstraint != null)
            {
                OnToString_IsValidIdentifierConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IsValidIdentifierConstraint> OnToString_IsValidIdentifierConstraint;

        [EventBasedMethod("OnPreSave_IsValidIdentifierConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IsValidIdentifierConstraint != null) OnPreSave_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnPreSave_IsValidIdentifierConstraint;

        [EventBasedMethod("OnPostSave_IsValidIdentifierConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IsValidIdentifierConstraint != null) OnPostSave_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnPostSave_IsValidIdentifierConstraint;

        [EventBasedMethod("OnCreated_IsValidIdentifierConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IsValidIdentifierConstraint != null) OnCreated_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnCreated_IsValidIdentifierConstraint;

        [EventBasedMethod("OnDeleting_IsValidIdentifierConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IsValidIdentifierConstraint != null) OnDeleting_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnDeleting_IsValidIdentifierConstraint;

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


        public class IsValidIdentifierConstraintProxy
            : Kistl.App.Base.ConstraintNHibernateImpl.ConstraintProxy
        {
            public IsValidIdentifierConstraintProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(IsValidIdentifierConstraintNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(IsValidIdentifierConstraintProxy); } }

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