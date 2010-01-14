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
    /// A control managing a list of objects
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectListKind")]
    [System.Diagnostics.DebuggerDisplay("ObjectListKind")]
    public class ObjectListKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, ObjectListKind
    {
    
		public ObjectListKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ObjectListKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ObjectListKind)obj;
			var otherImpl = (ObjectListKind__Implementation__)obj;
			var me = (ObjectListKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ObjectListKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectListKind != null)
            {
                OnToString_ObjectListKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectListKind> OnToString_ObjectListKind;

        [EventBasedMethod("OnPreSave_ObjectListKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectListKind != null) OnPreSave_ObjectListKind(this);
        }
        public static event ObjectEventHandler<ObjectListKind> OnPreSave_ObjectListKind;

        [EventBasedMethod("OnPostSave_ObjectListKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectListKind != null) OnPostSave_ObjectListKind(this);
        }
        public static event ObjectEventHandler<ObjectListKind> OnPostSave_ObjectListKind;

        [EventBasedMethod("OnCreated_ObjectListKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectListKind != null) OnCreated_ObjectListKind(this);
        }
        public static event ObjectEventHandler<ObjectListKind> OnCreated_ObjectListKind;

        [EventBasedMethod("OnDeleting_ObjectListKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectListKind != null) OnDeleting_ObjectListKind(this);
        }
        public static event ObjectEventHandler<ObjectListKind> OnDeleting_ObjectListKind;



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