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
    [EdmEntityType(NamespaceName="Model", Name="InstanceConstraint")]
    [System.Diagnostics.DebuggerDisplay("InstanceConstraint")]
    public class InstanceConstraint__Implementation__ : BaseServerDataObject_EntityFramework, InstanceConstraint
    {
    
		public InstanceConstraint__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                }
            }
        }
        private int _ID;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(InstanceConstraint));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (InstanceConstraint)obj;
			var otherImpl = (InstanceConstraint__Implementation__)obj;
			var me = (InstanceConstraint)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_InstanceConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_InstanceConstraint != null)
            {
                OnToString_InstanceConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<InstanceConstraint> OnToString_InstanceConstraint;

        [EventBasedMethod("OnPreSave_InstanceConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_InstanceConstraint != null) OnPreSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnPreSave_InstanceConstraint;

        [EventBasedMethod("OnPostSave_InstanceConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_InstanceConstraint != null) OnPostSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnPostSave_InstanceConstraint;

        [EventBasedMethod("OnCreated_InstanceConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_InstanceConstraint != null) OnCreated_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnCreated_InstanceConstraint;

        [EventBasedMethod("OnDeleting_InstanceConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_InstanceConstraint != null) OnDeleting_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnDeleting_InstanceConstraint;


	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
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

#endregion

    }


}