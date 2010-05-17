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
    [EdmEntityType(NamespaceName="Model", Name="InstanceListKind")]
    [System.Diagnostics.DebuggerDisplay("InstanceListKind")]
    public class InstanceListKind__Implementation__ : Kistl.App.GUI.DashboardKind__Implementation__, InstanceListKind
    {
    
		public InstanceListKind__Implementation__()
		{
        }


		public override Type GetImplementedInterface()
		{
			return typeof(InstanceListKind);
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (InstanceListKind)obj;
			var otherImpl = (InstanceListKind__Implementation__)obj;
			var me = (InstanceListKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_InstanceListKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_InstanceListKind != null)
            {
                OnToString_InstanceListKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<InstanceListKind> OnToString_InstanceListKind;

        [EventBasedMethod("OnPreSave_InstanceListKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_InstanceListKind != null) OnPreSave_InstanceListKind(this);
        }
        public static event ObjectEventHandler<InstanceListKind> OnPreSave_InstanceListKind;

        [EventBasedMethod("OnPostSave_InstanceListKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_InstanceListKind != null) OnPostSave_InstanceListKind(this);
        }
        public static event ObjectEventHandler<InstanceListKind> OnPostSave_InstanceListKind;

        [EventBasedMethod("OnCreated_InstanceListKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_InstanceListKind != null) OnCreated_InstanceListKind(this);
        }
        public static event ObjectEventHandler<InstanceListKind> OnCreated_InstanceListKind;

        [EventBasedMethod("OnDeleting_InstanceListKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_InstanceListKind != null) OnDeleting_InstanceListKind(this);
        }
        public static event ObjectEventHandler<InstanceListKind> OnDeleting_InstanceListKind;


	

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