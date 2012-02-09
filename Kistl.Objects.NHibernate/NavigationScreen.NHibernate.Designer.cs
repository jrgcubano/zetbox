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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("NavigationScreen")]
    public class NavigationScreenNHibernateImpl : Kistl.App.GUI.NavigationEntryNHibernateImpl, NavigationScreen
    {
        public NavigationScreenNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public NavigationScreenNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new NavigationScreenProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public NavigationScreenNHibernateImpl(Func<IFrozenContext> lazyCtx, NavigationScreenProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly NavigationScreenProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen")]
        public override System.Object GetDefaultViewModel(Kistl.API.IKistlContext dataCtx, System.Object parent)
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultViewModel_NavigationScreen != null)
            {
                OnGetDefaultViewModel_NavigationScreen(this, e, dataCtx, parent);
            }
            else
            {
                e.Result = base.GetDefaultViewModel(dataCtx, parent);
            }
            return e.Result;
        }
        public static event GetDefaultViewModel_Handler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen_CanExec;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen_CanExec")]
        public override bool GetDefaultViewModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultViewModel_NavigationScreen_CanExec != null)
				{
					OnGetDefaultViewModel_NavigationScreen_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultViewModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen_CanExecReason;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen_CanExecReason")]
        public override string GetDefaultViewModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultViewModel_NavigationScreen_CanExecReason != null)
				{
					OnGetDefaultViewModel_NavigationScreen_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultViewModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(NavigationScreen);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (NavigationScreen)obj;
            var otherImpl = (NavigationScreenNHibernateImpl)obj;
            var me = (NavigationScreen)this;

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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_NavigationScreen")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NavigationScreen != null)
            {
                OnToString_NavigationScreen(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<NavigationScreen> OnToString_NavigationScreen;

        [EventBasedMethod("OnNotifyPreSave_NavigationScreen")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_NavigationScreen != null) OnNotifyPreSave_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyPreSave_NavigationScreen;

        [EventBasedMethod("OnNotifyPostSave_NavigationScreen")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_NavigationScreen != null) OnNotifyPostSave_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyPostSave_NavigationScreen;

        [EventBasedMethod("OnNotifyCreated_NavigationScreen")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_NavigationScreen != null) OnNotifyCreated_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyCreated_NavigationScreen;

        [EventBasedMethod("OnNotifyDeleting_NavigationScreen")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_NavigationScreen != null) OnNotifyDeleting_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyDeleting_NavigationScreen;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            // Follow Application_has_RootScreen
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.GUI.Application>()
                .Where(child => child.RootScreen == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            return result;
        }


        public class NavigationScreenProxy
            : Kistl.App.GUI.NavigationEntryNHibernateImpl.NavigationEntryProxy
        {
            public NavigationScreenProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(NavigationScreenNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(NavigationScreenProxy); } }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
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