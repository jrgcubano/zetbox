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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="IsValidNamespaceConstraint")]
    [System.Diagnostics.DebuggerDisplay("IsValidNamespaceConstraint")]
    public class IsValidNamespaceConstraint__Implementation__ : Kistl.App.Base.IsValidIdentifierConstraint__Implementation__, IsValidNamespaceConstraint
    {
    
		public IsValidNamespaceConstraint__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetErrorText_IsValidNamespaceConstraint")]
		public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IsValidNamespaceConstraint != null)
            {
                OnGetErrorText_IsValidNamespaceConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public static event GetErrorText_Handler<IsValidNamespaceConstraint> OnGetErrorText_IsValidNamespaceConstraint;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnIsValid_IsValidNamespaceConstraint")]
		public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IsValidNamespaceConstraint != null)
            {
                OnIsValid_IsValidNamespaceConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public static event IsValid_Handler<IsValidNamespaceConstraint> OnIsValid_IsValidNamespaceConstraint;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(IsValidNamespaceConstraint));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (IsValidNamespaceConstraint)obj;
			var otherImpl = (IsValidNamespaceConstraint__Implementation__)obj;
			var me = (IsValidNamespaceConstraint)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_IsValidNamespaceConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IsValidNamespaceConstraint != null)
            {
                OnToString_IsValidNamespaceConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IsValidNamespaceConstraint> OnToString_IsValidNamespaceConstraint;

        [EventBasedMethod("OnPreSave_IsValidNamespaceConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IsValidNamespaceConstraint != null) OnPreSave_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnPreSave_IsValidNamespaceConstraint;

        [EventBasedMethod("OnPostSave_IsValidNamespaceConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IsValidNamespaceConstraint != null) OnPostSave_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnPostSave_IsValidNamespaceConstraint;

        [EventBasedMethod("OnCreated_IsValidNamespaceConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IsValidNamespaceConstraint != null) OnCreated_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnCreated_IsValidNamespaceConstraint;

        [EventBasedMethod("OnDeleting_IsValidNamespaceConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IsValidNamespaceConstraint != null) OnDeleting_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnDeleting_IsValidNamespaceConstraint;



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