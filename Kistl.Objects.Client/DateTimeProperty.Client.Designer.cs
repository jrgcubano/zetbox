
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

    using Kistl.API.Client;

    /// <summary>
    /// Metadefinition Object for DateTime Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeProperty")]
    public class DateTimeProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, DateTimeProperty
    {


        /// <summary>
        /// 
        /// </summary>

		public override string GetGUIRepresentation() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_DateTimeProperty != null)
            {
                OnGetGUIRepresentation_DateTimeProperty(this, e);
            }
            else
            {
                base.GetGUIRepresentation();
            }
            return e.Result;
        }
		public event GetGUIRepresentation_Handler<DateTimeProperty> OnGetGUIRepresentation_DateTimeProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DateTimeProperty != null)
            {
                OnGetPropertyType_DateTimeProperty(this, e);
            }
            else
            {
                base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<DateTimeProperty> OnGetPropertyType_DateTimeProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DateTimeProperty != null)
            {
                OnGetPropertyTypeString_DateTimeProperty(this, e);
            }
            else
            {
                base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<DateTimeProperty> OnGetPropertyTypeString_DateTimeProperty;



		public override Type GetInterfaceType()
		{
			return typeof(DateTimeProperty);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeProperty != null)
            {
                OnToString_DateTimeProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DateTimeProperty> OnToString_DateTimeProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateTimeProperty != null) OnPreSave_DateTimeProperty(this);
        }
        public event ObjectEventHandler<DateTimeProperty> OnPreSave_DateTimeProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateTimeProperty != null) OnPostSave_DateTimeProperty(this);
        }
        public event ObjectEventHandler<DateTimeProperty> OnPostSave_DateTimeProperty;




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