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
    /// Metadefinition Object for Double Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DoubleProperty")]
    [System.Diagnostics.DebuggerDisplay("DoubleProperty")]
    public class DoubleProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, DoubleProperty
    {
    
		public DoubleProperty__Implementation__()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_DoubleProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DoubleProperty != null)
            {
                OnGetPropertyType_DoubleProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public static event GetPropertyType_Handler<DoubleProperty> OnGetPropertyType_DoubleProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_DoubleProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DoubleProperty != null)
            {
                OnGetPropertyTypeString_DoubleProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public static event GetPropertyTypeString_Handler<DoubleProperty> OnGetPropertyTypeString_DoubleProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DoubleProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DoubleProperty)obj;
			var otherImpl = (DoubleProperty__Implementation__)obj;
			var me = (DoubleProperty)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DoubleProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleProperty != null)
            {
                OnToString_DoubleProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DoubleProperty> OnToString_DoubleProperty;

        [EventBasedMethod("OnPreSave_DoubleProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleProperty != null) OnPreSave_DoubleProperty(this);
        }
        public static event ObjectEventHandler<DoubleProperty> OnPreSave_DoubleProperty;

        [EventBasedMethod("OnPostSave_DoubleProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleProperty != null) OnPostSave_DoubleProperty(this);
        }
        public static event ObjectEventHandler<DoubleProperty> OnPostSave_DoubleProperty;

        [EventBasedMethod("OnCreated_DoubleProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DoubleProperty != null) OnCreated_DoubleProperty(this);
        }
        public static event ObjectEventHandler<DoubleProperty> OnCreated_DoubleProperty;

        [EventBasedMethod("OnDeleting_DoubleProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DoubleProperty != null) OnDeleting_DoubleProperty(this);
        }
        public static event ObjectEventHandler<DoubleProperty> OnDeleting_DoubleProperty;



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