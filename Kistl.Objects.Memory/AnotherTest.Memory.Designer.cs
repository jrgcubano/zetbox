// <autogenerated/>

namespace Kistl.App.Test
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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AnotherTest")]
    public class AnotherTestMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, AnotherTest
    {
        private static readonly Guid _objectClassID = new Guid("6d00a4e3-75b0-4a56-bc9f-3e9812d9c8fe");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public AnotherTestMemoryImpl()
            : base(null)
        {
        }

        public AnotherTestMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        public override Type GetImplementedInterface()
        {
            return typeof(AnotherTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AnotherTest)obj;
            var otherImpl = (AnotherTestMemoryImpl)obj;
            var me = (AnotherTest)this;

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
        [EventBasedMethod("OnToString_AnotherTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AnotherTest != null)
            {
                OnToString_AnotherTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AnotherTest> OnToString_AnotherTest;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_AnotherTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_AnotherTest != null)
            {
                OnObjectIsValid_AnotherTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<AnotherTest> OnObjectIsValid_AnotherTest;

        [EventBasedMethod("OnNotifyPreSave_AnotherTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_AnotherTest != null) OnNotifyPreSave_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnNotifyPreSave_AnotherTest;

        [EventBasedMethod("OnNotifyPostSave_AnotherTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_AnotherTest != null) OnNotifyPostSave_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnNotifyPostSave_AnotherTest;

        [EventBasedMethod("OnNotifyCreated_AnotherTest")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_AnotherTest != null) OnNotifyCreated_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnNotifyCreated_AnotherTest;

        [EventBasedMethod("OnNotifyDeleting_AnotherTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_AnotherTest != null) OnNotifyDeleting_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnNotifyDeleting_AnotherTest;

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

        #endregion

    }
}