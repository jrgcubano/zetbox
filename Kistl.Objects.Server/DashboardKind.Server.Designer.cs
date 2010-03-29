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
    [EdmEntityType(NamespaceName="Model", Name="DashboardKind")]
    [System.Diagnostics.DebuggerDisplay("DashboardKind")]
    public abstract class DashboardKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, DashboardKind
    {
    
		public DashboardKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DashboardKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DashboardKind)obj;
			var otherImpl = (DashboardKind__Implementation__)obj;
			var me = (DashboardKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DashboardKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DashboardKind != null)
            {
                OnToString_DashboardKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DashboardKind> OnToString_DashboardKind;

        [EventBasedMethod("OnPreSave_DashboardKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DashboardKind != null) OnPreSave_DashboardKind(this);
        }
        public static event ObjectEventHandler<DashboardKind> OnPreSave_DashboardKind;

        [EventBasedMethod("OnPostSave_DashboardKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DashboardKind != null) OnPostSave_DashboardKind(this);
        }
        public static event ObjectEventHandler<DashboardKind> OnPostSave_DashboardKind;

        [EventBasedMethod("OnCreated_DashboardKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DashboardKind != null) OnCreated_DashboardKind(this);
        }
        public static event ObjectEventHandler<DashboardKind> OnCreated_DashboardKind;

        [EventBasedMethod("OnDeleting_DashboardKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DashboardKind != null) OnDeleting_DashboardKind(this);
        }
        public static event ObjectEventHandler<DashboardKind> OnDeleting_DashboardKind;


	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			base.ReloadReferences();
			
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
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