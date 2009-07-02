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

    using Kistl.DalProvider.Frozen;

    /// <summary>
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CLRObjectParameter")]
    public class CLRObjectParameter__Implementation__Frozen : Kistl.App.Base.BaseParameter__Implementation__Frozen, CLRObjectParameter
    {
    
		public CLRObjectParameter__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Assembly des CLR Objektes, NULL für Default Assemblies
        /// </summary>
        // object reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return _Assembly;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Assembly != value)
                {
					var __oldValue = _Assembly;
                    NotifyPropertyChanging("Assembly", __oldValue, value);
                    _Assembly = value;
                    NotifyPropertyChanged("Assembly", __oldValue, value);
                }
            }
        }
        private Kistl.App.Base.Assembly _Assembly;

        /// <summary>
        /// Name des CLR Datentypen
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string FullTypeName
        {
            get
            {
                return _FullTypeName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_FullTypeName != value)
                {
					var __oldValue = _FullTypeName;
                    NotifyPropertyChanging("FullTypeName", __oldValue, value);
                    _FullTypeName = value;
                    NotifyPropertyChanged("FullTypeName", __oldValue, value);
                }
            }
        }
        private string _FullTypeName;

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>

		public override System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CLRObjectParameter != null)
            {
                OnGetParameterType_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
		public event GetParameterType_Handler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>

		public override string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CLRObjectParameter != null)
            {
                OnGetParameterTypeString_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
		public event GetParameterTypeString_Handler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(CLRObjectParameter));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CLRObjectParameter != null) OnPreSave_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnPreSave_CLRObjectParameter;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CLRObjectParameter != null) OnPostSave_CLRObjectParameter(this);
        }
        public event ObjectEventHandler<CLRObjectParameter> OnPostSave_CLRObjectParameter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assembly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(104).Constraints
						.Where(c => !c.IsValid(this, this.Assembly))
						.Select(c => c.GetErrorText(this, this.Assembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "FullTypeName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(15).Constraints
						.Where(c => !c.IsValid(this, this.FullTypeName))
						.Select(c => c.GetErrorText(this, this.FullTypeName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}
        internal CLRObjectParameter__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, CLRObjectParameter__Implementation__Frozen> DataStore = new Dictionary<int, CLRObjectParameter__Implementation__Frozen>(13);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[1] = 
			DataStore[1] = new CLRObjectParameter__Implementation__Frozen(1);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[3] = 
			DataStore[3] = new CLRObjectParameter__Implementation__Frozen(3);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[6] = 
			DataStore[6] = new CLRObjectParameter__Implementation__Frozen(6);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[7] = 
			DataStore[7] = new CLRObjectParameter__Implementation__Frozen(7);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[9] = 
			DataStore[9] = new CLRObjectParameter__Implementation__Frozen(9);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[10] = 
			DataStore[10] = new CLRObjectParameter__Implementation__Frozen(10);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[11] = 
			DataStore[11] = new CLRObjectParameter__Implementation__Frozen(11);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[15] = 
			DataStore[15] = new CLRObjectParameter__Implementation__Frozen(15);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[19] = 
			DataStore[19] = new CLRObjectParameter__Implementation__Frozen(19);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[20] = 
			DataStore[20] = new CLRObjectParameter__Implementation__Frozen(20);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[21] = 
			DataStore[21] = new CLRObjectParameter__Implementation__Frozen(21);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[27] = 
			DataStore[27] = new CLRObjectParameter__Implementation__Frozen(27);

			Kistl.App.Base.BaseParameter__Implementation__Frozen.DataStore[30] = 
			DataStore[30] = new CLRObjectParameter__Implementation__Frozen(30);

		}

		internal new static void FillDataStore() {
			DataStore[1].Description = null;
			DataStore[1].ExportGuid = new Guid("8b256774-a753-4463-9d36-dd652c02e5d2");
			DataStore[1].IsList = false;
			DataStore[1].IsReturnParameter = false;
			DataStore[1].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[10];
			DataStore[1].ParameterName = @"constrainedObject";
			DataStore[1].Assembly = null;
			DataStore[1].FullTypeName = @"System.Object";
			DataStore[1].Seal();
			DataStore[3].Description = null;
			DataStore[3].ExportGuid = new Guid("c72cd537-eff1-47fc-a58c-7ff6f0c5c708");
			DataStore[3].IsList = false;
			DataStore[3].IsReturnParameter = false;
			DataStore[3].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[10];
			DataStore[3].ParameterName = @"constrainedValue";
			DataStore[3].Assembly = null;
			DataStore[3].FullTypeName = @"System.Object";
			DataStore[3].Seal();
			DataStore[6].Description = null;
			DataStore[6].ExportGuid = new Guid("d0d5e933-5bca-4be9-8cbb-91088065f2cb");
			DataStore[6].IsList = false;
			DataStore[6].IsReturnParameter = false;
			DataStore[6].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[14];
			DataStore[6].ParameterName = @"constrainedObject";
			DataStore[6].Assembly = null;
			DataStore[6].FullTypeName = @"System.Object";
			DataStore[6].Seal();
			DataStore[7].Description = null;
			DataStore[7].ExportGuid = new Guid("bc641521-f091-4c9c-9065-0ef1d2813e90");
			DataStore[7].IsList = false;
			DataStore[7].IsReturnParameter = false;
			DataStore[7].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[14];
			DataStore[7].ParameterName = @"constrainedValue";
			DataStore[7].Assembly = null;
			DataStore[7].FullTypeName = @"System.Object";
			DataStore[7].Seal();
			DataStore[9].Description = null;
			DataStore[9].ExportGuid = new Guid("887f23ba-d2dd-409d-a94a-18fd0615cb80");
			DataStore[9].IsList = false;
			DataStore[9].IsReturnParameter = false;
			DataStore[9].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[80];
			DataStore[9].ParameterName = @"ctx";
			DataStore[9].Assembly = null;
			DataStore[9].FullTypeName = @"Kistl.API.IKistlContext";
			DataStore[9].Seal();
			DataStore[10].Description = null;
			DataStore[10].ExportGuid = new Guid("008a012a-6800-4048-b50f-6e9068e89bcf");
			DataStore[10].IsList = false;
			DataStore[10].IsReturnParameter = false;
			DataStore[10].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[80];
			DataStore[10].ParameterName = @"objectType";
			DataStore[10].Assembly = null;
			DataStore[10].FullTypeName = @"System.Type";
			DataStore[10].Seal();
			DataStore[11].Description = @"the referenced Type";
			DataStore[11].ExportGuid = new Guid("355175eb-1741-46a5-a03b-6f121604023e");
			DataStore[11].IsList = false;
			DataStore[11].IsReturnParameter = true;
			DataStore[11].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[77];
			DataStore[11].ParameterName = @"return";
			DataStore[11].Assembly = null;
			DataStore[11].FullTypeName = @"System.Type";
			DataStore[11].Seal();
			DataStore[15].Description = null;
			DataStore[15].ExportGuid = new Guid("91bcf25a-efbe-498a-86a7-5d5a0b0e2b43");
			DataStore[15].IsList = false;
			DataStore[15].IsReturnParameter = true;
			DataStore[15].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[93];
			DataStore[15].ParameterName = @"ReturnParameter";
			DataStore[15].Assembly = null;
			DataStore[15].FullTypeName = @"System.Type";
			DataStore[15].Seal();
			DataStore[19].Description = null;
			DataStore[19].ExportGuid = new Guid("c3dae1ab-3c30-4ada-991e-163db90df26e");
			DataStore[19].IsList = false;
			DataStore[19].IsReturnParameter = true;
			DataStore[19].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[80];
			DataStore[19].ParameterName = @"result";
			DataStore[19].Assembly = null;
			DataStore[19].FullTypeName = @"Kistl.API.IDataObject";
			DataStore[19].Seal();
			DataStore[20].Description = null;
			DataStore[20].ExportGuid = new Guid("e389c092-d4a5-44d6-a0d7-157e629fb032");
			DataStore[20].IsList = false;
			DataStore[20].IsReturnParameter = false;
			DataStore[20].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[81];
			DataStore[20].ParameterName = @"obj";
			DataStore[20].Assembly = null;
			DataStore[20].FullTypeName = @"Kistl.API.IDataObject";
			DataStore[20].Seal();
			DataStore[21].Description = null;
			DataStore[21].ExportGuid = new Guid("ab9c14a8-e232-4705-bd91-256d8f718d4b");
			DataStore[21].IsList = false;
			DataStore[21].IsReturnParameter = true;
			DataStore[21].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[87];
			DataStore[21].ParameterName = @"ReturnParameter";
			DataStore[21].Assembly = null;
			DataStore[21].FullTypeName = @"System.Type";
			DataStore[21].Seal();
			DataStore[27].Description = null;
			DataStore[27].ExportGuid = new Guid("5fc58d51-b4f0-4d78-b973-834d3e9e4962");
			DataStore[27].IsList = false;
			DataStore[27].IsReturnParameter = false;
			DataStore[27].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[122];
			DataStore[27].ParameterName = @"TestCLRObjectParameter";
			DataStore[27].Assembly = null;
			DataStore[27].FullTypeName = @"System.Guid";
			DataStore[27].Seal();
			DataStore[30].Description = null;
			DataStore[30].ExportGuid = new Guid("2a95f5c5-bae6-48e6-a4b9-15381fffd615");
			DataStore[30].IsList = false;
			DataStore[30].IsReturnParameter = true;
			DataStore[30].Method = Kistl.App.Base.Method__Implementation__Frozen.DataStore[107];
			DataStore[30].ParameterName = @"ReturnParameter";
			DataStore[30].Assembly = null;
			DataStore[30].FullTypeName = @"System.Type";
			DataStore[30].Seal();
	
		}
#region Serializer

        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.IO.BinaryReader binStream)
        {
            throw new NotImplementedException();
        }
        public override void ToStream(System.Xml.XmlWriter xml)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }
        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public override void MergeImport(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}