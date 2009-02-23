
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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for ValueType Properties. This class is abstract.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ValueTypeProperty")]
    [System.Diagnostics.DebuggerDisplay("ValueTypeProperty")]
    public class ValueTypeProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, ValueTypeProperty
    {


        /// <summary>
        /// 
        /// </summary>

		public override string GetGUIRepresentation() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_ValueTypeProperty != null)
            {
                OnGetGUIRepresentation_ValueTypeProperty(this, e);
            }
            else
            {
                base.GetGUIRepresentation();
            }
            return e.Result;
        }
		public event GetGUIRepresentation_Handler<ValueTypeProperty> OnGetGUIRepresentation_ValueTypeProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ValueTypeProperty != null)
            {
                OnGetPropertyType_ValueTypeProperty(this, e);
            }
            else
            {
                base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<ValueTypeProperty> OnGetPropertyType_ValueTypeProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ValueTypeProperty != null)
            {
                OnGetPropertyTypeString_ValueTypeProperty(this, e);
            }
            else
            {
                base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<ValueTypeProperty> OnGetPropertyTypeString_ValueTypeProperty;



		public override Type GetInterfaceType()
		{
			return typeof(ValueTypeProperty);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ValueTypeProperty != null)
            {
                OnToString_ValueTypeProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ValueTypeProperty> OnToString_ValueTypeProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ValueTypeProperty != null) OnPreSave_ValueTypeProperty(this);
        }
        public event ObjectEventHandler<ValueTypeProperty> OnPreSave_ValueTypeProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ValueTypeProperty != null) OnPostSave_ValueTypeProperty(this);
        }
        public event ObjectEventHandler<ValueTypeProperty> OnPostSave_ValueTypeProperty;




#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
        }

#endregion

    }


}