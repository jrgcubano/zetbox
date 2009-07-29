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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmComplexType(NamespaceName="Model", Name="TestPhoneStruct")]
    [System.Diagnostics.DebuggerDisplay("TestPhoneStruct")]
    public class TestPhoneStruct__Implementation__ : BaseServerStructObject_EntityFramework, IStruct, TestPhoneStruct
    {
    
		public TestPhoneStruct__Implementation__()
		{
        }


        /// <summary>
        /// Enter Area Code
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string AreaCode
        {
            get
            {
				var __value = _AreaCode;
				if(OnAreaCode_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnAreaCode_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_AreaCode != value)
                {
					var __oldValue = _AreaCode;
					var __newValue = value;
                    if(OnAreaCode_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnAreaCode_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("AreaCode", __oldValue, __newValue);
                    _AreaCode = __newValue;
                    NotifyPropertyChanged("AreaCode", __oldValue, __newValue);

                    if(OnAreaCode_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnAreaCode_PostSetter(this, e);
                    }
                }
            }
        }
        private string _AreaCode;
		public event PropertyGetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnAreaCode_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnAreaCode_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnAreaCode_PostSetter;
        /// <summary>
        /// Enter a Number
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Number
        {
            get
            {
				var __value = _Number;
				if(OnNumber_Getter != null)
				{
					var e = new PropertyGetterEventArgs<string>(__value);
					OnNumber_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Number != value)
                {
					var __oldValue = _Number;
					var __newValue = value;
                    if(OnNumber_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
						OnNumber_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("Number", __oldValue, __newValue);
                    _Number = __newValue;
                    NotifyPropertyChanged("Number", __oldValue, __newValue);

                    if(OnNumber_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
						OnNumber_PostSetter(this, e);
                    }
                }
            }
        }
        private string _Number;
		public event PropertyGetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnNumber_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnNumber_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestPhoneStruct, string> OnNumber_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TestPhoneStruct));
		}
        public TestPhoneStruct__Implementation__(IPersistenceObject parent, string property)
        {
            AttachToObject(parent, property);
        }

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._AreaCode, binStream);
            BinarySerializer.ToStream(this._Number, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._AreaCode, binStream);
            BinarySerializer.FromStream(out this._Number, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._AreaCode, xml, "AreaCode", "Kistl.App.Test");
            XmlStreamer.ToStream(this._Number, xml, "Number", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._AreaCode, xml, "AreaCode", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._Number, xml, "Number", "Kistl.App.Test");
        }

#endregion

    }


}