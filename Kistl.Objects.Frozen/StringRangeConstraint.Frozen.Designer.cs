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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("StringRangeConstraint")]
    public class StringRangeConstraint__Implementation__Frozen : Kistl.App.Base.Constraint__Implementation__Frozen, StringRangeConstraint
    {
    
		public StringRangeConstraint__Implementation__Frozen()
		{
        }


        /// <summary>
        /// The maximal length of this StringProperty
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int MaxLength
        {
            get
            {
                return _MaxLength;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_MaxLength != value)
                {
					var __oldValue = _MaxLength;
                    NotifyPropertyChanging("MaxLength", __oldValue, value);
                    _MaxLength = value;
                    NotifyPropertyChanged("MaxLength", __oldValue, value);
                }
            }
        }
        private int _MaxLength;

        /// <summary>
        /// The minimal length of this StringProperty
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int MinLength
        {
            get
            {
                return _MinLength;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_MinLength != value)
                {
					var __oldValue = _MinLength;
                    NotifyPropertyChanging("MinLength", __oldValue, value);
                    _MinLength = value;
                    NotifyPropertyChanged("MinLength", __oldValue, value);
                }
            }
        }
        private int _MinLength;

        /// <summary>
        /// 
        /// </summary>

		public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_StringRangeConstraint != null)
            {
                OnGetErrorText_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event GetErrorText_Handler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint;



        /// <summary>
        /// 
        /// </summary>

		public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_StringRangeConstraint != null)
            {
                OnIsValid_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event IsValid_Handler<StringRangeConstraint> OnIsValid_StringRangeConstraint;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StringRangeConstraint));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringRangeConstraint != null)
            {
                OnToString_StringRangeConstraint(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<StringRangeConstraint> OnToString_StringRangeConstraint;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringRangeConstraint != null) OnPreSave_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnPreSave_StringRangeConstraint;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringRangeConstraint != null) OnPostSave_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnPostSave_StringRangeConstraint;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "MaxLength":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(172).Constraints
						.Where(c => !c.IsValid(this, this.MaxLength))
						.Select(c => c.GetErrorText(this, this.MaxLength))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MinLength":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(171).Constraints
						.Where(c => !c.IsValid(this, this.MinLength))
						.Select(c => c.GetErrorText(this, this.MinLength))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}
        internal StringRangeConstraint__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, StringRangeConstraint__Implementation__Frozen> DataStore = new Dictionary<int, StringRangeConstraint__Implementation__Frozen>(50);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[1] = 
			DataStore[1] = new StringRangeConstraint__Implementation__Frozen(1);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[3] = 
			DataStore[3] = new StringRangeConstraint__Implementation__Frozen(3);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[4] = 
			DataStore[4] = new StringRangeConstraint__Implementation__Frozen(4);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[11] = 
			DataStore[11] = new StringRangeConstraint__Implementation__Frozen(11);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[12] = 
			DataStore[12] = new StringRangeConstraint__Implementation__Frozen(12);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[13] = 
			DataStore[13] = new StringRangeConstraint__Implementation__Frozen(13);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[21] = 
			DataStore[21] = new StringRangeConstraint__Implementation__Frozen(21);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[37] = 
			DataStore[37] = new StringRangeConstraint__Implementation__Frozen(37);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[38] = 
			DataStore[38] = new StringRangeConstraint__Implementation__Frozen(38);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[42] = 
			DataStore[42] = new StringRangeConstraint__Implementation__Frozen(42);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[44] = 
			DataStore[44] = new StringRangeConstraint__Implementation__Frozen(44);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[45] = 
			DataStore[45] = new StringRangeConstraint__Implementation__Frozen(45);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[46] = 
			DataStore[46] = new StringRangeConstraint__Implementation__Frozen(46);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[47] = 
			DataStore[47] = new StringRangeConstraint__Implementation__Frozen(47);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[48] = 
			DataStore[48] = new StringRangeConstraint__Implementation__Frozen(48);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[50] = 
			DataStore[50] = new StringRangeConstraint__Implementation__Frozen(50);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[52] = 
			DataStore[52] = new StringRangeConstraint__Implementation__Frozen(52);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[54] = 
			DataStore[54] = new StringRangeConstraint__Implementation__Frozen(54);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[56] = 
			DataStore[56] = new StringRangeConstraint__Implementation__Frozen(56);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[60] = 
			DataStore[60] = new StringRangeConstraint__Implementation__Frozen(60);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[61] = 
			DataStore[61] = new StringRangeConstraint__Implementation__Frozen(61);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[64] = 
			DataStore[64] = new StringRangeConstraint__Implementation__Frozen(64);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[66] = 
			DataStore[66] = new StringRangeConstraint__Implementation__Frozen(66);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[70] = 
			DataStore[70] = new StringRangeConstraint__Implementation__Frozen(70);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[79] = 
			DataStore[79] = new StringRangeConstraint__Implementation__Frozen(79);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[81] = 
			DataStore[81] = new StringRangeConstraint__Implementation__Frozen(81);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[83] = 
			DataStore[83] = new StringRangeConstraint__Implementation__Frozen(83);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[85] = 
			DataStore[85] = new StringRangeConstraint__Implementation__Frozen(85);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[87] = 
			DataStore[87] = new StringRangeConstraint__Implementation__Frozen(87);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[91] = 
			DataStore[91] = new StringRangeConstraint__Implementation__Frozen(91);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[93] = 
			DataStore[93] = new StringRangeConstraint__Implementation__Frozen(93);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[95] = 
			DataStore[95] = new StringRangeConstraint__Implementation__Frozen(95);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[97] = 
			DataStore[97] = new StringRangeConstraint__Implementation__Frozen(97);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[99] = 
			DataStore[99] = new StringRangeConstraint__Implementation__Frozen(99);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[103] = 
			DataStore[103] = new StringRangeConstraint__Implementation__Frozen(103);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[109] = 
			DataStore[109] = new StringRangeConstraint__Implementation__Frozen(109);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[121] = 
			DataStore[121] = new StringRangeConstraint__Implementation__Frozen(121);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[122] = 
			DataStore[122] = new StringRangeConstraint__Implementation__Frozen(122);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[128] = 
			DataStore[128] = new StringRangeConstraint__Implementation__Frozen(128);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[130] = 
			DataStore[130] = new StringRangeConstraint__Implementation__Frozen(130);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[138] = 
			DataStore[138] = new StringRangeConstraint__Implementation__Frozen(138);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[141] = 
			DataStore[141] = new StringRangeConstraint__Implementation__Frozen(141);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[144] = 
			DataStore[144] = new StringRangeConstraint__Implementation__Frozen(144);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[145] = 
			DataStore[145] = new StringRangeConstraint__Implementation__Frozen(145);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[147] = 
			DataStore[147] = new StringRangeConstraint__Implementation__Frozen(147);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[150] = 
			DataStore[150] = new StringRangeConstraint__Implementation__Frozen(150);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[151] = 
			DataStore[151] = new StringRangeConstraint__Implementation__Frozen(151);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[153] = 
			DataStore[153] = new StringRangeConstraint__Implementation__Frozen(153);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[154] = 
			DataStore[154] = new StringRangeConstraint__Implementation__Frozen(154);

			Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[163] = 
			DataStore[163] = new StringRangeConstraint__Implementation__Frozen(163);

		}

		internal new static void FillDataStore() {
			DataStore[1].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[3];
			DataStore[1].ExportGuid = new Guid("d23346da-59c9-4011-bc17-59f9f925fa78");
			DataStore[1].Reason = null;
			DataStore[1].MaxLength = 200;
			DataStore[1].MinLength = 0;
			DataStore[1].Seal();
			DataStore[3].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[38];
			DataStore[3].ExportGuid = new Guid("8d4ed43a-62d6-45fd-b3e3-cfb60e11da6e");
			DataStore[3].Reason = null;
			DataStore[3].MaxLength = 200;
			DataStore[3].MinLength = 0;
			DataStore[3].Seal();
			DataStore[4].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[39];
			DataStore[4].ExportGuid = new Guid("dc6ae076-e73f-4d2f-9f19-342c5fc69bee");
			DataStore[4].Reason = null;
			DataStore[4].MaxLength = 4000;
			DataStore[4].MinLength = 0;
			DataStore[4].Seal();
			DataStore[11].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[37];
			DataStore[11].ExportGuid = new Guid("323c7941-6578-4729-905b-31883c3fd13f");
			DataStore[11].Reason = null;
			DataStore[11].MaxLength = 200;
			DataStore[11].MinLength = 0;
			DataStore[11].Seal();
			DataStore[12].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[41];
			DataStore[12].ExportGuid = new Guid("8a89b37e-bcff-4aa7-a6e3-6612a3ee98f4");
			DataStore[12].Reason = null;
			DataStore[12].MaxLength = 400;
			DataStore[12].MinLength = 0;
			DataStore[12].Seal();
			DataStore[13].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[43];
			DataStore[13].ExportGuid = new Guid("91b2db4b-a391-4321-af1b-8e9322cd0e70");
			DataStore[13].Reason = null;
			DataStore[13].MaxLength = 4000;
			DataStore[13].MinLength = 0;
			DataStore[13].Seal();
			DataStore[21].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[42];
			DataStore[21].ExportGuid = new Guid("ef21d105-f97d-4f81-a98b-25d472cbc41f");
			DataStore[21].Reason = null;
			DataStore[21].MaxLength = 4000;
			DataStore[21].MinLength = 0;
			DataStore[21].Seal();
			DataStore[37].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[36];
			DataStore[37].ExportGuid = new Guid("53b91dd8-1f92-4fd8-8795-d1cada6f3f9b");
			DataStore[37].Reason = null;
			DataStore[37].MaxLength = 200;
			DataStore[37].MinLength = 0;
			DataStore[37].Seal();
			DataStore[38].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[35];
			DataStore[38].ExportGuid = new Guid("9d9c8bf8-26cf-4a35-a542-1fc4ebcd2504");
			DataStore[38].Reason = null;
			DataStore[38].MaxLength = 4000;
			DataStore[38].MinLength = 0;
			DataStore[38].Seal();
			DataStore[42].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[34];
			DataStore[42].ExportGuid = new Guid("41d415ec-3004-4157-b185-d1e51b3244f0");
			DataStore[42].Reason = null;
			DataStore[42].MaxLength = 200;
			DataStore[42].MinLength = 0;
			DataStore[42].Seal();
			DataStore[44].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[44];
			DataStore[44].ExportGuid = new Guid("59493532-e14f-4968-b19c-46792767e357");
			DataStore[44].Reason = null;
			DataStore[44].MaxLength = 100;
			DataStore[44].MinLength = 0;
			DataStore[44].Seal();
			DataStore[45].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[81];
			DataStore[45].ExportGuid = new Guid("eecb73e6-3890-4f04-ac98-1abe7d4de818");
			DataStore[45].Reason = null;
			DataStore[45].MaxLength = 20;
			DataStore[45].MinLength = 0;
			DataStore[45].Seal();
			DataStore[46].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[82];
			DataStore[46].ExportGuid = new Guid("25dda4b3-fdcd-4c74-aac0-151fe9f0b6ac");
			DataStore[46].Reason = null;
			DataStore[46].MaxLength = 100;
			DataStore[46].MinLength = 0;
			DataStore[46].Seal();
			DataStore[47].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[73];
			DataStore[47].ExportGuid = new Guid("19a0fe43-535c-4d4b-b038-c036a34a496f");
			DataStore[47].Reason = null;
			DataStore[47].MaxLength = 200;
			DataStore[47].MinLength = 0;
			DataStore[47].Seal();
			DataStore[48].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[80];
			DataStore[48].ExportGuid = new Guid("106355d6-2e2b-4af6-9bc8-358b06eee884");
			DataStore[48].Reason = null;
			DataStore[48].MaxLength = 100;
			DataStore[48].MinLength = 0;
			DataStore[48].Seal();
			DataStore[50].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[84];
			DataStore[50].ExportGuid = new Guid("c11b167a-d87c-4fb2-a8e1-b25880839b97");
			DataStore[50].Reason = null;
			DataStore[50].MaxLength = 100;
			DataStore[50].MinLength = 0;
			DataStore[50].Seal();
			DataStore[52].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[71];
			DataStore[52].ExportGuid = new Guid("ff85dca6-a0f1-4410-b9a1-e5c4e9cd3539");
			DataStore[52].Reason = null;
			DataStore[52].MaxLength = 10;
			DataStore[52].MinLength = 0;
			DataStore[52].Seal();
			DataStore[54].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[83];
			DataStore[54].ExportGuid = new Guid("cffb8784-4b8e-4c87-95d1-68b2bb9522df");
			DataStore[54].Reason = null;
			DataStore[54].MaxLength = 100;
			DataStore[54].MinLength = 0;
			DataStore[54].Seal();
			DataStore[56].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[75];
			DataStore[56].ExportGuid = new Guid("3216b626-121c-477a-b457-b4f2a347fd5c");
			DataStore[56].Reason = null;
			DataStore[56].MaxLength = 100;
			DataStore[56].MinLength = 1;
			DataStore[56].Seal();
			DataStore[60].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[76];
			DataStore[60].ExportGuid = new Guid("9f8f82dc-0fb6-41b3-bddc-453c4eb67542");
			DataStore[60].Reason = null;
			DataStore[60].MaxLength = 100;
			DataStore[60].MinLength = 0;
			DataStore[60].Seal();
			DataStore[61].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[74];
			DataStore[61].ExportGuid = new Guid("628a2b96-f7fe-4b4e-b2ff-9f76c10b4c50");
			DataStore[61].Reason = null;
			DataStore[61].MaxLength = 200;
			DataStore[61].MinLength = 0;
			DataStore[61].Seal();
			DataStore[64].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[77];
			DataStore[64].ExportGuid = new Guid("4b7fea07-8714-4280-96dc-33bdededc0b2");
			DataStore[64].Reason = @"Classes should have a non-empty name. Names longer than 51 become unwieldy.";
			DataStore[64].MaxLength = 51;
			DataStore[64].MinLength = 1;
			DataStore[64].Seal();
			DataStore[66].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[65];
			DataStore[66].ExportGuid = new Guid("45f9afdb-7529-4f4f-af22-7b957342071a");
			DataStore[66].Reason = null;
			DataStore[66].MaxLength = 200;
			DataStore[66].MinLength = 0;
			DataStore[66].Seal();
			DataStore[70].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[66];
			DataStore[70].ExportGuid = new Guid("339ba200-167c-4bc7-8409-a2350107c12a");
			DataStore[70].Reason = null;
			DataStore[70].MaxLength = 100;
			DataStore[70].MinLength = 0;
			DataStore[70].Seal();
			DataStore[79].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[69];
			DataStore[79].ExportGuid = new Guid("e4e53e52-a40f-4d98-820e-3132cd586718");
			DataStore[79].Reason = null;
			DataStore[79].MaxLength = 200;
			DataStore[79].MinLength = 0;
			DataStore[79].Seal();
			DataStore[81].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[70];
			DataStore[81].ExportGuid = new Guid("e48a9549-018c-4da4-856c-29c15fba81ec");
			DataStore[81].Reason = null;
			DataStore[81].MaxLength = 200;
			DataStore[81].MinLength = 0;
			DataStore[81].Seal();
			DataStore[83].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[67];
			DataStore[83].ExportGuid = new Guid("73821828-029d-498b-b3f2-8bc0708778f1");
			DataStore[83].Reason = null;
			DataStore[83].MaxLength = 200;
			DataStore[83].MinLength = 0;
			DataStore[83].Seal();
			DataStore[85].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[68];
			DataStore[85].ExportGuid = new Guid("12758ab2-e0dd-4212-9491-426af93b79a4");
			DataStore[85].Reason = null;
			DataStore[85].MaxLength = 50;
			DataStore[85].MinLength = 0;
			DataStore[85].Seal();
			DataStore[87].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[6];
			DataStore[87].ExportGuid = new Guid("8901b641-ef28-4e94-8d28-039c6a4947e1");
			DataStore[87].Reason = null;
			DataStore[87].MaxLength = 200;
			DataStore[87].MinLength = 0;
			DataStore[87].Seal();
			DataStore[91].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[4];
			DataStore[91].ExportGuid = new Guid("a5e5b5a6-d6ee-4f74-9e6e-1d3d297162fa");
			DataStore[91].Reason = null;
			DataStore[91].MaxLength = 200;
			DataStore[91].MinLength = 0;
			DataStore[91].Seal();
			DataStore[93].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[5];
			DataStore[93].ExportGuid = new Guid("50d38cf9-75d2-4f05-8d64-5a46391247e4");
			DataStore[93].Reason = null;
			DataStore[93].MaxLength = 400;
			DataStore[93].MinLength = 0;
			DataStore[93].Seal();
			DataStore[95].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[7];
			DataStore[95].ExportGuid = new Guid("46db572f-58a4-4673-827b-7e5b976c202e");
			DataStore[95].Reason = null;
			DataStore[95].MaxLength = 200;
			DataStore[95].MinLength = 0;
			DataStore[95].Seal();
			DataStore[97].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[9];
			DataStore[97].ExportGuid = new Guid("c9ecb11b-d23d-43f9-9c51-c17ac743bbda");
			DataStore[97].Reason = null;
			DataStore[97].MaxLength = 200;
			DataStore[97].MinLength = 0;
			DataStore[97].Seal();
			DataStore[99].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[10];
			DataStore[99].ExportGuid = new Guid("b4f189d0-a7cc-4c44-83bb-e9264583dab7");
			DataStore[99].Reason = null;
			DataStore[99].MaxLength = 200;
			DataStore[99].MinLength = 0;
			DataStore[99].Seal();
			DataStore[103].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[8];
			DataStore[103].ExportGuid = new Guid("2ae24cc6-140c-4c5d-a639-ac3da7187ae8");
			DataStore[103].Reason = null;
			DataStore[103].MaxLength = 200;
			DataStore[103].MinLength = 0;
			DataStore[103].Seal();
			DataStore[109].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[72];
			DataStore[109].ExportGuid = new Guid("ecba903c-9f8b-44f9-a048-0d241c480a44");
			DataStore[109].Reason = null;
			DataStore[109].MaxLength = 200;
			DataStore[109].MinLength = 0;
			DataStore[109].Seal();
			DataStore[121].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[11];
			DataStore[121].ExportGuid = new Guid("df796b11-89ce-4f1a-94e6-4b25e6658d5a");
			DataStore[121].Reason = null;
			DataStore[121].MaxLength = 200;
			DataStore[121].MinLength = 0;
			DataStore[121].Seal();
			DataStore[122].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[21];
			DataStore[122].ExportGuid = new Guid("a5e9106b-bf3f-4626-a73e-548d1177d1f3");
			DataStore[122].Reason = null;
			DataStore[122].MaxLength = 50;
			DataStore[122].MinLength = 0;
			DataStore[122].Seal();
			DataStore[128].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[20];
			DataStore[128].ExportGuid = new Guid("bb45ba61-6b65-47bd-9d42-dc947d0d8014");
			DataStore[128].Reason = null;
			DataStore[128].MaxLength = 200;
			DataStore[128].MinLength = 0;
			DataStore[128].Seal();
			DataStore[130].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[22];
			DataStore[130].ExportGuid = new Guid("b3cab736-23be-4c1a-8fb7-1b4e689aa804");
			DataStore[130].Reason = null;
			DataStore[130].MaxLength = 200;
			DataStore[130].MinLength = 0;
			DataStore[130].Seal();
			DataStore[138].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[23];
			DataStore[138].ExportGuid = new Guid("888c5b65-32b7-424c-8c59-b9880697a13a");
			DataStore[138].Reason = null;
			DataStore[138].MaxLength = 200;
			DataStore[138].MinLength = 0;
			DataStore[138].Seal();
			DataStore[141].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[15];
			DataStore[141].ExportGuid = new Guid("19c8dc77-8079-43ab-8db3-5112cfc54700");
			DataStore[141].Reason = null;
			DataStore[141].MaxLength = 200;
			DataStore[141].MinLength = 0;
			DataStore[141].Seal();
			DataStore[144].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[14];
			DataStore[144].ExportGuid = new Guid("8efb3794-6f27-4c83-b3ff-6cd9dd680a99");
			DataStore[144].Reason = null;
			DataStore[144].MaxLength = 100;
			DataStore[144].MinLength = 0;
			DataStore[144].Seal();
			DataStore[145].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[12];
			DataStore[145].ExportGuid = new Guid("b7bb2f92-c1e4-405f-bcb3-6de8969d134d");
			DataStore[145].Reason = null;
			DataStore[145].MaxLength = 200;
			DataStore[145].MinLength = 0;
			DataStore[145].Seal();
			DataStore[147].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[13];
			DataStore[147].ExportGuid = new Guid("02367a9f-35f0-4bb1-97f4-4d9999b6fa35");
			DataStore[147].Reason = null;
			DataStore[147].MaxLength = 200;
			DataStore[147].MinLength = 0;
			DataStore[147].Seal();
			DataStore[150].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[19];
			DataStore[150].ExportGuid = new Guid("25ef284a-39a7-4d28-92d4-fe2ebd7e003f");
			DataStore[150].Reason = null;
			DataStore[150].MaxLength = 50;
			DataStore[150].MinLength = 0;
			DataStore[150].Seal();
			DataStore[151].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[17];
			DataStore[151].ExportGuid = new Guid("16b78e66-93ed-4817-9e11-45caef1da299");
			DataStore[151].Reason = null;
			DataStore[151].MaxLength = 50;
			DataStore[151].MinLength = 0;
			DataStore[151].Seal();
			DataStore[153].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[18];
			DataStore[153].ExportGuid = new Guid("1e20b663-808b-48d7-9db2-d3b525303cb1");
			DataStore[153].Reason = null;
			DataStore[153].MaxLength = 200;
			DataStore[153].MinLength = 0;
			DataStore[153].Seal();
			DataStore[154].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[16];
			DataStore[154].ExportGuid = new Guid("33b4207b-fc81-4e99-a27f-d3b7e24dc06d");
			DataStore[154].Reason = null;
			DataStore[154].MaxLength = 200;
			DataStore[154].MinLength = 0;
			DataStore[154].Seal();
			DataStore[163].ConstrainedProperty = Kistl.App.Base.Property__Implementation__Frozen.DataStore[184];
			DataStore[163].ExportGuid = new Guid("4a2de5ff-e539-4795-b13a-a04965d849a1");
			DataStore[163].Reason = null;
			DataStore[163].MaxLength = 200;
			DataStore[163].MinLength = 0;
			DataStore[163].Seal();
	
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