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

    using Kistl.DalProvider.Frozen;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("PresentableModelDescriptor")]
    public class PresentableModelDescriptor__Implementation__Frozen : BaseFrozenDataObject, PresentableModelDescriptor, Kistl.API.IExportableInternal
    {
    
		public PresentableModelDescriptor__Implementation__Frozen()
		{
        }


        /// <summary>
        /// The default visual type used for this PresentableModel
        /// </summary>
        // enumeration property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.GUI.VisualType DefaultVisualType
        {
            get
            {
                return _DefaultVisualType;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_DefaultVisualType != value)
                {
					var __oldValue = _DefaultVisualType;
                    NotifyPropertyChanging("DefaultVisualType", __oldValue, value);
                    _DefaultVisualType = value;
                    NotifyPropertyChanged("DefaultVisualType", __oldValue, value);
                }
            }
        }
        private Kistl.App.GUI.VisualType _DefaultVisualType;

        /// <summary>
        /// describe this PresentableModel
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Guid ExportGuid
        {
            get
            {
                return _ExportGuid;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// 
        /// </summary>
        // object reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.Base.Module Module
        {
            get
            {
                return _Module;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Module != value)
                {
					var __oldValue = _Module;
                    NotifyPropertyChanging("Module", __oldValue, value);
                    _Module = value;
                    NotifyPropertyChanged("Module", __oldValue, value);
                }
            }
        }
        private Kistl.App.Base.Module _Module;

        /// <summary>
        /// The described CLR class&apos; reference
        /// </summary>
        // object reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.Base.TypeRef PresentableModelRef
        {
            get
            {
                return _PresentableModelRef;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_PresentableModelRef != value)
                {
					var __oldValue = _PresentableModelRef;
                    NotifyPropertyChanging("PresentableModelRef", __oldValue, value);
                    _PresentableModelRef = value;
                    NotifyPropertyChanged("PresentableModelRef", __oldValue, value);
                }
            }
        }
        private Kistl.App.Base.TypeRef _PresentableModelRef;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(PresentableModelDescriptor));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PresentableModelDescriptor != null)
            {
                OnToString_PresentableModelDescriptor(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<PresentableModelDescriptor> OnToString_PresentableModelDescriptor;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PresentableModelDescriptor != null) OnPreSave_PresentableModelDescriptor(this);
        }
        public event ObjectEventHandler<PresentableModelDescriptor> OnPreSave_PresentableModelDescriptor;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PresentableModelDescriptor != null) OnPostSave_PresentableModelDescriptor(this);
        }
        public event ObjectEventHandler<PresentableModelDescriptor> OnPostSave_PresentableModelDescriptor;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "DefaultVisualType":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(179).Constraints
						.Where(c => !c.IsValid(this, this.DefaultVisualType))
						.Select(c => c.GetErrorText(this, this.DefaultVisualType))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(42).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(24).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(113).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "PresentableModelRef":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(175).Constraints
						.Where(c => !c.IsValid(this, this.PresentableModelRef))
						.Select(c => c.GetErrorText(this, this.PresentableModelRef))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}
        internal PresentableModelDescriptor__Implementation__Frozen(int id)
            : base(id)
        { }


		internal static Dictionary<int, PresentableModelDescriptor__Implementation__Frozen> DataStore = new Dictionary<int, PresentableModelDescriptor__Implementation__Frozen>(38);
		internal static void CreateInstances()
		{
			DataStore[1] = new PresentableModelDescriptor__Implementation__Frozen(1);

			DataStore[2] = new PresentableModelDescriptor__Implementation__Frozen(2);

			DataStore[3] = new PresentableModelDescriptor__Implementation__Frozen(3);

			DataStore[4] = new PresentableModelDescriptor__Implementation__Frozen(4);

			DataStore[5] = new PresentableModelDescriptor__Implementation__Frozen(5);

			DataStore[6] = new PresentableModelDescriptor__Implementation__Frozen(6);

			DataStore[7] = new PresentableModelDescriptor__Implementation__Frozen(7);

			DataStore[8] = new PresentableModelDescriptor__Implementation__Frozen(8);

			DataStore[9] = new PresentableModelDescriptor__Implementation__Frozen(9);

			DataStore[10] = new PresentableModelDescriptor__Implementation__Frozen(10);

			DataStore[11] = new PresentableModelDescriptor__Implementation__Frozen(11);

			DataStore[12] = new PresentableModelDescriptor__Implementation__Frozen(12);

			DataStore[13] = new PresentableModelDescriptor__Implementation__Frozen(13);

			DataStore[14] = new PresentableModelDescriptor__Implementation__Frozen(14);

			DataStore[15] = new PresentableModelDescriptor__Implementation__Frozen(15);

			DataStore[16] = new PresentableModelDescriptor__Implementation__Frozen(16);

			DataStore[17] = new PresentableModelDescriptor__Implementation__Frozen(17);

			DataStore[18] = new PresentableModelDescriptor__Implementation__Frozen(18);

			DataStore[19] = new PresentableModelDescriptor__Implementation__Frozen(19);

			DataStore[20] = new PresentableModelDescriptor__Implementation__Frozen(20);

			DataStore[21] = new PresentableModelDescriptor__Implementation__Frozen(21);

			DataStore[22] = new PresentableModelDescriptor__Implementation__Frozen(22);

			DataStore[23] = new PresentableModelDescriptor__Implementation__Frozen(23);

			DataStore[24] = new PresentableModelDescriptor__Implementation__Frozen(24);

			DataStore[25] = new PresentableModelDescriptor__Implementation__Frozen(25);

			DataStore[26] = new PresentableModelDescriptor__Implementation__Frozen(26);

			DataStore[27] = new PresentableModelDescriptor__Implementation__Frozen(27);

			DataStore[28] = new PresentableModelDescriptor__Implementation__Frozen(28);

			DataStore[29] = new PresentableModelDescriptor__Implementation__Frozen(29);

			DataStore[30] = new PresentableModelDescriptor__Implementation__Frozen(30);

			DataStore[31] = new PresentableModelDescriptor__Implementation__Frozen(31);

			DataStore[32] = new PresentableModelDescriptor__Implementation__Frozen(32);

			DataStore[33] = new PresentableModelDescriptor__Implementation__Frozen(33);

			DataStore[34] = new PresentableModelDescriptor__Implementation__Frozen(34);

			DataStore[35] = new PresentableModelDescriptor__Implementation__Frozen(35);

			DataStore[36] = new PresentableModelDescriptor__Implementation__Frozen(36);

			DataStore[37] = new PresentableModelDescriptor__Implementation__Frozen(37);

			DataStore[38] = new PresentableModelDescriptor__Implementation__Frozen(38);

		}

		internal static void FillDataStore() {
			DataStore[1].DefaultVisualType = (VisualType)1;
			DataStore[1].Description = @"A dashboard for the TimeRecords module";
			DataStore[1].ExportGuid = new Guid("8023e937-5827-4056-b0c0-ffb5bf061dfd");
			DataStore[1].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[1].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83];
			DataStore[1].Seal();
			DataStore[2].DefaultVisualType = (VisualType)22;
			DataStore[2].Description = @"A debugger window showing the used IKistlContexts and their AttachedObjects";
			DataStore[2].ExportGuid = new Guid("b1df266b-a841-4669-9199-a6a01f6dbfcc");
			DataStore[2].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[2].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[70];
			DataStore[2].Seal();
			DataStore[3].DefaultVisualType = (VisualType)2;
			DataStore[3].Description = @"A group of properties";
			DataStore[3].ExportGuid = new Guid("ac2f4c88-333a-4917-a0b5-a39ad7ea991a");
			DataStore[3].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[3].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[75];
			DataStore[3].Seal();
			DataStore[4].DefaultVisualType = (VisualType)1;
			DataStore[4].Description = @"A complete IDataObject";
			DataStore[4].ExportGuid = new Guid("d8e95ac5-d46a-4dfa-a574-12ea299eadc4");
			DataStore[4].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[4].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[71];
			DataStore[4].Seal();
			DataStore[5].DefaultVisualType = (VisualType)1;
			DataStore[5].Description = @"A basic DashBoard for the GUI module.";
			DataStore[5].ExportGuid = new Guid("6d40b091-3c20-4371-9bc2-dc12fe2f552f");
			DataStore[5].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[5].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[84];
			DataStore[5].Seal();
			DataStore[6].DefaultVisualType = (VisualType)24;
			DataStore[6].Description = @"A top-level window containing a Workspace, a visual representation for IKistlContext";
			DataStore[6].ExportGuid = new Guid("ffc833d5-a2a5-4cde-8335-6285973742d8");
			DataStore[6].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[6].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[114];
			DataStore[6].Seal();
			DataStore[7].DefaultVisualType = (VisualType)17;
			DataStore[7].Description = @"An action which can be triggered by the user";
			DataStore[7].ExportGuid = new Guid("3d779eaf-1c37-4c3b-822b-0b1af0926802");
			DataStore[7].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[7].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[117];
			DataStore[7].Seal();
			DataStore[8].DefaultVisualType = (VisualType)1;
			DataStore[8].Description = @"A model for a single work effort";
			DataStore[8].ExportGuid = new Guid("b6dc8994-6930-4cf4-8cb7-7f18efe9ef68");
			DataStore[8].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[8].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[134];
			DataStore[8].Seal();
			DataStore[9].DefaultVisualType = (VisualType)1;
			DataStore[9].Description = @"just a wrapper";
			DataStore[9].ExportGuid = new Guid("382050bb-706b-4812-b23b-133833d72d55");
			DataStore[9].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[9].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[133];
			DataStore[9].Seal();
			DataStore[10].DefaultVisualType = (VisualType)3;
			DataStore[10].Description = @"A list of IDataObjects";
			DataStore[10].ExportGuid = new Guid("9fce01fe-fd6d-4e21-8b55-08d5e38aea36");
			DataStore[10].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[10].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[139];
			DataStore[10].Seal();
			DataStore[11].DefaultVisualType = (VisualType)13;
			DataStore[11].Description = @"A string attribute";
			DataStore[11].ExportGuid = new Guid("975eee82-e7e1-4a12-ab43-d2e3bc3766e4");
			DataStore[11].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[11].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[142];
			DataStore[11].Seal();
			DataStore[12].DefaultVisualType = (VisualType)24;
			DataStore[12].Description = @"A workspace for recording work efforts";
			DataStore[12].ExportGuid = new Guid("b4b23681-f63b-4aeb-9ecb-b258bd33be24");
			DataStore[12].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[12].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[141];
			DataStore[12].Seal();
			DataStore[13].DefaultVisualType = (VisualType)1;
			DataStore[13].Description = @"RelationEditor";
			DataStore[13].ExportGuid = new Guid("d4d5ae35-104d-4445-b0a9-2d49ae5f7716");
			DataStore[13].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[13].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[132];
			DataStore[13].Seal();
			DataStore[14].DefaultVisualType = (VisualType)1;
			DataStore[14].Description = @"DataObjectModel with specific extensions for DataTypes";
			DataStore[14].ExportGuid = new Guid("0d3a2e45-9a49-4e29-afea-619baa8d3871");
			DataStore[14].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[14].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[125];
			DataStore[14].Seal();
			DataStore[15].DefaultVisualType = (VisualType)1;
			DataStore[15].Description = @"DataObjectModel with specific extensions for Modules";
			DataStore[15].ExportGuid = new Guid("84828181-4048-47a7-b526-01508b7a0fd0");
			DataStore[15].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[15].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[124];
			DataStore[15].Seal();
			DataStore[16].DefaultVisualType = (VisualType)1;
			DataStore[16].Description = @"DataObjectModel with specific extensions for MethodInvocations";
			DataStore[16].ExportGuid = new Guid("caf3e708-2f31-4084-9957-ca11fccc1374");
			DataStore[16].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[16].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[126];
			DataStore[16].Seal();
			DataStore[17].DefaultVisualType = (VisualType)1;
			DataStore[17].Description = @"Releation Editor";
			DataStore[17].ExportGuid = new Guid("225bfb18-82fc-429d-81ff-e1ba738fdbc7");
			DataStore[17].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[17].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[131];
			DataStore[17].Seal();
			DataStore[18].DefaultVisualType = (VisualType)5;
			DataStore[18].Description = @"A simple true/false attribute";
			DataStore[18].ExportGuid = new Guid("09d1f453-d0d9-429e-88e7-e84b33de7c2e");
			DataStore[18].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[18].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[127];
			DataStore[18].Seal();
			DataStore[19].DefaultVisualType = (VisualType)13;
			DataStore[19].Description = @"A floating point attribute";
			DataStore[19].ExportGuid = new Guid("3a3d0c1c-679e-4d4d-adeb-3ab260079ccb");
			DataStore[19].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[19].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[145];
			DataStore[19].Seal();
			DataStore[20].DefaultVisualType = (VisualType)13;
			DataStore[20].Description = @"A method returning an integer value";
			DataStore[20].ExportGuid = new Guid("1f4e8593-5675-4f0a-9454-7cb888cfe6e1");
			DataStore[20].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[20].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[165];
			DataStore[20].Seal();
			DataStore[21].DefaultVisualType = (VisualType)4;
			DataStore[21].Description = @"A method returning an IDataObject reference";
			DataStore[21].ExportGuid = new Guid("c799b6bf-a1f7-4374-99df-3ebae6e52ef0");
			DataStore[21].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[21].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[164];
			DataStore[21].Seal();
			DataStore[22].DefaultVisualType = (VisualType)13;
			DataStore[22].Description = @"A date and time attribute";
			DataStore[22].ExportGuid = new Guid("fc74b434-3801-4e4a-ab67-e65a9e014005");
			DataStore[22].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[22].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[146];
			DataStore[22].Seal();
			DataStore[23].DefaultVisualType = (VisualType)13;
			DataStore[23].Description = @"An integer attribute";
			DataStore[23].ExportGuid = new Guid("edaf9334-dc36-4778-aa33-1e5cdaeeb767");
			DataStore[23].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[23].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[147];
			DataStore[23].Seal();
			DataStore[24].DefaultVisualType = (VisualType)4;
			DataStore[24].Description = @"A reference to an IDataObject";
			DataStore[24].ExportGuid = new Guid("83aae6fd-0fae-4348-b313-737a6e751027");
			DataStore[24].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[24].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[161];
			DataStore[24].Seal();
			DataStore[25].DefaultVisualType = (VisualType)5;
			DataStore[25].Description = @"A method returning true or false";
			DataStore[25].ExportGuid = new Guid("ae255750-0147-4e61-9426-8b7232c927fc");
			DataStore[25].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[25].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[152];
			DataStore[25].Seal();
			DataStore[26].DefaultVisualType = (VisualType)13;
			DataStore[26].Description = @"A method returning a date and time value";
			DataStore[26].ExportGuid = new Guid("e60611f1-025e-49f3-854e-c682127bc247");
			DataStore[26].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[26].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[154];
			DataStore[26].Seal();
			DataStore[27].DefaultVisualType = (VisualType)13;
			DataStore[27].Description = @"A method returning a string";
			DataStore[27].ExportGuid = new Guid("75aef030-0c25-4306-b6d2-ca8c7cd672dd");
			DataStore[27].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[27].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[157];
			DataStore[27].Seal();
			DataStore[28].DefaultVisualType = (VisualType)13;
			DataStore[28].Description = @"A method returning a floating point value";
			DataStore[28].ExportGuid = new Guid("677a70dc-a7ec-4f41-9aae-9e87949489db");
			DataStore[28].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[28].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[166];
			DataStore[28].Seal();
			DataStore[29].DefaultVisualType = (VisualType)23;
			DataStore[29].Description = @"A task for the user: select an IDataObject from a list";
			DataStore[29].ExportGuid = new Guid("7ec25c1a-c819-4219-9432-af1fdb0aaf63");
			DataStore[29].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[29].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[162];
			DataStore[29].Seal();
			DataStore[30].DefaultVisualType = (VisualType)27;
			DataStore[30].Description = @"A GUID attribute";
			DataStore[30].ExportGuid = new Guid("2b6fb70f-a382-4057-a139-cc33333d619d");
			DataStore[30].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[30].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[153];
			DataStore[30].Seal();
			DataStore[31].DefaultVisualType = (VisualType)15;
			DataStore[31].Description = @"An enumeration value for TestEnum";
			DataStore[31].ExportGuid = new Guid("4dad4724-51ca-4618-9ea5-58ac201eba8a");
			DataStore[31].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[31].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[170];
			DataStore[31].Seal();
			DataStore[32].DefaultVisualType = (VisualType)4;
			DataStore[32].Description = @"A model for easier working with TypeRef valued Properties.";
			DataStore[32].ExportGuid = new Guid("d96d030e-eebe-4b7f-8b55-dca30cbd4bde");
			DataStore[32].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[32].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[169];
			DataStore[32].Seal();
			DataStore[33].DefaultVisualType = (VisualType)1;
			DataStore[33].Description = @"DataObjectModel with specific extensions for ObjectClasses";
			DataStore[33].ExportGuid = new Guid("6b368136-addd-4e86-ad29-3d2158a00de5");
			DataStore[33].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[33].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[172];
			DataStore[33].Seal();
			DataStore[34].DefaultVisualType = (VisualType)15;
			DataStore[34].Description = @"An enumeration value for Toolkit";
			DataStore[34].ExportGuid = new Guid("467887f3-194c-47b2-9441-c9929dca7d9f");
			DataStore[34].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[34].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[173];
			DataStore[34].Seal();
			DataStore[35].DefaultVisualType = (VisualType)15;
			DataStore[35].Description = @"An enumeration value for VisualType";
			DataStore[35].ExportGuid = new Guid("0b8b98cf-a618-49e8-a2f3-9c3c6b9427ed");
			DataStore[35].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[35].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[177];
			DataStore[35].Seal();
			DataStore[36].DefaultVisualType = (VisualType)15;
			DataStore[36].Description = @"An enumeration value for Multiplicity";
			DataStore[36].ExportGuid = new Guid("4b7ef800-2ddb-4b99-b0d4-aefd9373ba70");
			DataStore[36].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[36].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[168];
			DataStore[36].Seal();
			DataStore[37].DefaultVisualType = (VisualType)26;
			DataStore[37].Description = @"Select a string value from a set of values";
			DataStore[37].ExportGuid = new Guid("d1135824-6e2a-41e7-a1db-83621b5de078");
			DataStore[37].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[37].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[174];
			DataStore[37].Seal();
			DataStore[38].DefaultVisualType = (VisualType)15;
			DataStore[38].Description = @"An enumeration value for StorageType";
			DataStore[38].ExportGuid = new Guid("0151803d-60f4-428a-8b69-a77b783bbc54");
			DataStore[38].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[38].PresentableModelRef = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[176];
			DataStore[38].Seal();
	
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
        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}