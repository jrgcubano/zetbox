
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
    /// This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TypeRef")]
    public class TypeRef__Implementation__Frozen : BaseFrozenDataObject, TypeRef
    {
    
		public TypeRef__Implementation__Frozen()
		{
        }


        /// <summary>
        /// The assembly containing the referenced Type.
        /// </summary>
        // object reference property
        public virtual Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return _Assembly;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
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
        /// 
        /// </summary>
        // value type property
        public virtual string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_FullName != value)
                {
					var __oldValue = _FullName;
                    NotifyPropertyChanging("FullName", __oldValue, value);
                    _FullName = value;
                    NotifyPropertyChanged("FullName", __oldValue, value);
                }
            }
        }
        private string _FullName;

        /// <summary>
        /// list of type arguments
        /// </summary>
        // collection reference property
        public virtual IList<Kistl.App.Base.TypeRef> GenericArguments
        {
            get
            {
                if (_GenericArguments == null)
                    _GenericArguments = new ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0));
                return _GenericArguments;
            }
            internal set
            {
                if (IsReadonly)
                {
                    throw new ReadOnlyObjectException();
                }
                _GenericArguments = (ReadOnlyCollection<Kistl.App.Base.TypeRef>)value;
            }
        }
        private ReadOnlyCollection<Kistl.App.Base.TypeRef> _GenericArguments;

        /// <summary>
        /// The TypeRef of the BaseClass of the referenced Type
        /// </summary>
        // object reference property
        public virtual Kistl.App.Base.TypeRef Parent
        {
            get
            {
                return _Parent;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Parent != value)
                {
					var __oldValue = _Parent;
                    NotifyPropertyChanging("Parent", __oldValue, value);
                    _Parent = value;
                    NotifyPropertyChanged("Parent", __oldValue, value);
                }
            }
        }
        private Kistl.App.Base.TypeRef _Parent;

        /// <summary>
        /// get the referenced <see cref="System.Type"/>
        /// </summary>

		public virtual System.Type AsType(System.Boolean throwOnError) 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnAsType_TypeRef != null)
            {
                OnAsType_TypeRef(this, e, throwOnError);
            }
            else
            {
                throw new NotImplementedException("No handler registered on TypeRef.AsType");
            }
            return e.Result;
        }
		public delegate void AsType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret, System.Boolean throwOnError);
		public event AsType_Handler<TypeRef> OnAsType_TypeRef;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TypeRef));
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TypeRef != null)
            {
                OnToString_TypeRef(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<TypeRef> OnToString_TypeRef;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TypeRef != null) OnPreSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPreSave_TypeRef;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TypeRef != null) OnPostSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPostSave_TypeRef;


        internal TypeRef__Implementation__Frozen(int id)
            : base(id)
        { }


		internal static Dictionary<int, TypeRef__Implementation__Frozen> DataStore = new Dictionary<int, TypeRef__Implementation__Frozen>(161);
		internal static void CreateInstances()
		{
			DataStore[1] = new TypeRef__Implementation__Frozen(1);

			DataStore[2] = new TypeRef__Implementation__Frozen(2);

			DataStore[3] = new TypeRef__Implementation__Frozen(3);

			DataStore[4] = new TypeRef__Implementation__Frozen(4);

			DataStore[5] = new TypeRef__Implementation__Frozen(5);

			DataStore[6] = new TypeRef__Implementation__Frozen(6);

			DataStore[8] = new TypeRef__Implementation__Frozen(8);

			DataStore[9] = new TypeRef__Implementation__Frozen(9);

			DataStore[10] = new TypeRef__Implementation__Frozen(10);

			DataStore[11] = new TypeRef__Implementation__Frozen(11);

			DataStore[12] = new TypeRef__Implementation__Frozen(12);

			DataStore[13] = new TypeRef__Implementation__Frozen(13);

			DataStore[14] = new TypeRef__Implementation__Frozen(14);

			DataStore[15] = new TypeRef__Implementation__Frozen(15);

			DataStore[16] = new TypeRef__Implementation__Frozen(16);

			DataStore[17] = new TypeRef__Implementation__Frozen(17);

			DataStore[18] = new TypeRef__Implementation__Frozen(18);

			DataStore[23] = new TypeRef__Implementation__Frozen(23);

			DataStore[24] = new TypeRef__Implementation__Frozen(24);

			DataStore[25] = new TypeRef__Implementation__Frozen(25);

			DataStore[26] = new TypeRef__Implementation__Frozen(26);

			DataStore[27] = new TypeRef__Implementation__Frozen(27);

			DataStore[31] = new TypeRef__Implementation__Frozen(31);

			DataStore[34] = new TypeRef__Implementation__Frozen(34);

			DataStore[39] = new TypeRef__Implementation__Frozen(39);

			DataStore[40] = new TypeRef__Implementation__Frozen(40);

			DataStore[41] = new TypeRef__Implementation__Frozen(41);

			DataStore[45] = new TypeRef__Implementation__Frozen(45);

			DataStore[46] = new TypeRef__Implementation__Frozen(46);

			DataStore[47] = new TypeRef__Implementation__Frozen(47);

			DataStore[48] = new TypeRef__Implementation__Frozen(48);

			DataStore[81] = new TypeRef__Implementation__Frozen(81);

			DataStore[83] = new TypeRef__Implementation__Frozen(83);

			DataStore[92] = new TypeRef__Implementation__Frozen(92);

			DataStore[94] = new TypeRef__Implementation__Frozen(94);

			DataStore[95] = new TypeRef__Implementation__Frozen(95);

			DataStore[96] = new TypeRef__Implementation__Frozen(96);

			DataStore[108] = new TypeRef__Implementation__Frozen(108);

			DataStore[110] = new TypeRef__Implementation__Frozen(110);

			DataStore[112] = new TypeRef__Implementation__Frozen(112);

			DataStore[114] = new TypeRef__Implementation__Frozen(114);

			DataStore[116] = new TypeRef__Implementation__Frozen(116);

			DataStore[145] = new TypeRef__Implementation__Frozen(145);

			DataStore[146] = new TypeRef__Implementation__Frozen(146);

			DataStore[147] = new TypeRef__Implementation__Frozen(147);

			DataStore[148] = new TypeRef__Implementation__Frozen(148);

			DataStore[149] = new TypeRef__Implementation__Frozen(149);

			DataStore[150] = new TypeRef__Implementation__Frozen(150);

			DataStore[151] = new TypeRef__Implementation__Frozen(151);

			DataStore[152] = new TypeRef__Implementation__Frozen(152);

			DataStore[153] = new TypeRef__Implementation__Frozen(153);

			DataStore[154] = new TypeRef__Implementation__Frozen(154);

			DataStore[155] = new TypeRef__Implementation__Frozen(155);

			DataStore[156] = new TypeRef__Implementation__Frozen(156);

			DataStore[157] = new TypeRef__Implementation__Frozen(157);

			DataStore[158] = new TypeRef__Implementation__Frozen(158);

			DataStore[159] = new TypeRef__Implementation__Frozen(159);

			DataStore[160] = new TypeRef__Implementation__Frozen(160);

			DataStore[161] = new TypeRef__Implementation__Frozen(161);

			DataStore[162] = new TypeRef__Implementation__Frozen(162);

			DataStore[163] = new TypeRef__Implementation__Frozen(163);

			DataStore[164] = new TypeRef__Implementation__Frozen(164);

			DataStore[165] = new TypeRef__Implementation__Frozen(165);

			DataStore[166] = new TypeRef__Implementation__Frozen(166);

			DataStore[167] = new TypeRef__Implementation__Frozen(167);

			DataStore[273] = new TypeRef__Implementation__Frozen(273);

			DataStore[274] = new TypeRef__Implementation__Frozen(274);

			DataStore[275] = new TypeRef__Implementation__Frozen(275);

			DataStore[276] = new TypeRef__Implementation__Frozen(276);

			DataStore[277] = new TypeRef__Implementation__Frozen(277);

			DataStore[278] = new TypeRef__Implementation__Frozen(278);

			DataStore[282] = new TypeRef__Implementation__Frozen(282);

			DataStore[283] = new TypeRef__Implementation__Frozen(283);

			DataStore[295] = new TypeRef__Implementation__Frozen(295);

			DataStore[299] = new TypeRef__Implementation__Frozen(299);

			DataStore[300] = new TypeRef__Implementation__Frozen(300);

			DataStore[301] = new TypeRef__Implementation__Frozen(301);

			DataStore[302] = new TypeRef__Implementation__Frozen(302);

			DataStore[310] = new TypeRef__Implementation__Frozen(310);

			DataStore[311] = new TypeRef__Implementation__Frozen(311);

			DataStore[312] = new TypeRef__Implementation__Frozen(312);

			DataStore[313] = new TypeRef__Implementation__Frozen(313);

			DataStore[314] = new TypeRef__Implementation__Frozen(314);

			DataStore[315] = new TypeRef__Implementation__Frozen(315);

			DataStore[316] = new TypeRef__Implementation__Frozen(316);

			DataStore[317] = new TypeRef__Implementation__Frozen(317);

			DataStore[318] = new TypeRef__Implementation__Frozen(318);

			DataStore[319] = new TypeRef__Implementation__Frozen(319);

			DataStore[320] = new TypeRef__Implementation__Frozen(320);

			DataStore[321] = new TypeRef__Implementation__Frozen(321);

			DataStore[322] = new TypeRef__Implementation__Frozen(322);

			DataStore[323] = new TypeRef__Implementation__Frozen(323);

			DataStore[324] = new TypeRef__Implementation__Frozen(324);

			DataStore[325] = new TypeRef__Implementation__Frozen(325);

			DataStore[326] = new TypeRef__Implementation__Frozen(326);

			DataStore[328] = new TypeRef__Implementation__Frozen(328);

			DataStore[330] = new TypeRef__Implementation__Frozen(330);

			DataStore[332] = new TypeRef__Implementation__Frozen(332);

			DataStore[334] = new TypeRef__Implementation__Frozen(334);

			DataStore[335] = new TypeRef__Implementation__Frozen(335);

			DataStore[346] = new TypeRef__Implementation__Frozen(346);

			DataStore[347] = new TypeRef__Implementation__Frozen(347);

			DataStore[354] = new TypeRef__Implementation__Frozen(354);

			DataStore[355] = new TypeRef__Implementation__Frozen(355);

			DataStore[357] = new TypeRef__Implementation__Frozen(357);

			DataStore[374] = new TypeRef__Implementation__Frozen(374);

			DataStore[382] = new TypeRef__Implementation__Frozen(382);

			DataStore[383] = new TypeRef__Implementation__Frozen(383);

			DataStore[384] = new TypeRef__Implementation__Frozen(384);

			DataStore[394] = new TypeRef__Implementation__Frozen(394);

			DataStore[395] = new TypeRef__Implementation__Frozen(395);

			DataStore[396] = new TypeRef__Implementation__Frozen(396);

			DataStore[398] = new TypeRef__Implementation__Frozen(398);

			DataStore[399] = new TypeRef__Implementation__Frozen(399);

			DataStore[400] = new TypeRef__Implementation__Frozen(400);

			DataStore[401] = new TypeRef__Implementation__Frozen(401);

			DataStore[403] = new TypeRef__Implementation__Frozen(403);

			DataStore[404] = new TypeRef__Implementation__Frozen(404);

			DataStore[405] = new TypeRef__Implementation__Frozen(405);

			DataStore[406] = new TypeRef__Implementation__Frozen(406);

			DataStore[408] = new TypeRef__Implementation__Frozen(408);

			DataStore[409] = new TypeRef__Implementation__Frozen(409);

			DataStore[410] = new TypeRef__Implementation__Frozen(410);

			DataStore[411] = new TypeRef__Implementation__Frozen(411);

			DataStore[413] = new TypeRef__Implementation__Frozen(413);

			DataStore[414] = new TypeRef__Implementation__Frozen(414);

			DataStore[415] = new TypeRef__Implementation__Frozen(415);

			DataStore[416] = new TypeRef__Implementation__Frozen(416);

			DataStore[418] = new TypeRef__Implementation__Frozen(418);

			DataStore[419] = new TypeRef__Implementation__Frozen(419);

			DataStore[420] = new TypeRef__Implementation__Frozen(420);

			DataStore[421] = new TypeRef__Implementation__Frozen(421);

			DataStore[422] = new TypeRef__Implementation__Frozen(422);

			DataStore[424] = new TypeRef__Implementation__Frozen(424);

			DataStore[426] = new TypeRef__Implementation__Frozen(426);

			DataStore[427] = new TypeRef__Implementation__Frozen(427);

			DataStore[429] = new TypeRef__Implementation__Frozen(429);

			DataStore[431] = new TypeRef__Implementation__Frozen(431);

			DataStore[432] = new TypeRef__Implementation__Frozen(432);

			DataStore[434] = new TypeRef__Implementation__Frozen(434);

			DataStore[436] = new TypeRef__Implementation__Frozen(436);

			DataStore[437] = new TypeRef__Implementation__Frozen(437);

			DataStore[439] = new TypeRef__Implementation__Frozen(439);

			DataStore[441] = new TypeRef__Implementation__Frozen(441);

			DataStore[442] = new TypeRef__Implementation__Frozen(442);

			DataStore[444] = new TypeRef__Implementation__Frozen(444);

			DataStore[447] = new TypeRef__Implementation__Frozen(447);

			DataStore[448] = new TypeRef__Implementation__Frozen(448);

			DataStore[449] = new TypeRef__Implementation__Frozen(449);

			DataStore[450] = new TypeRef__Implementation__Frozen(450);

			DataStore[454] = new TypeRef__Implementation__Frozen(454);

			DataStore[458] = new TypeRef__Implementation__Frozen(458);

			DataStore[462] = new TypeRef__Implementation__Frozen(462);

			DataStore[466] = new TypeRef__Implementation__Frozen(466);

			DataStore[469] = new TypeRef__Implementation__Frozen(469);

			DataStore[470] = new TypeRef__Implementation__Frozen(470);

			DataStore[556] = new TypeRef__Implementation__Frozen(556);

			DataStore[557] = new TypeRef__Implementation__Frozen(557);

			DataStore[558] = new TypeRef__Implementation__Frozen(558);

			DataStore[559] = new TypeRef__Implementation__Frozen(559);

			DataStore[560] = new TypeRef__Implementation__Frozen(560);

		}

		internal static void FillDataStore() {
			DataStore[1].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[1].FullName = @"Kistl.App.Base.CustomClientActions_KistlBase";
			DataStore[1].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[1].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[1].Seal();
			DataStore[2].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[2].FullName = @"Kistl.App.Zeiterfassung.CustomServerActions_Zeiterfassung";
			DataStore[2].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[2].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[2].Seal();
			DataStore[3].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[3].FullName = @"Kistl.App.Projekte.CustomServerActions_Projekte";
			DataStore[3].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[3].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[3].Seal();
			DataStore[4].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[4].FullName = @"Kistl.App.Base.CustomServerActions_KistlBase";
			DataStore[4].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[4].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[4].Seal();
			DataStore[5].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[5].FullName = @"Kistl.App.GUI.CustomClientActions_GUI";
			DataStore[5].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[5].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[5].Seal();
			DataStore[6].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[6].FullName = @"Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung";
			DataStore[6].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[6].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[6].Seal();
			DataStore[8].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[8].FullName = @"Kistl.App.Projekte.CustomClientActions_Projekte";
			DataStore[8].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[8].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[8].Seal();
			DataStore[9].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[9].FullName = @"Kistl.Client.Presentables.ModuleModel";
			DataStore[9].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[9].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83];
			DataStore[9].Seal();
			DataStore[10].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[10].FullName = @"Kistl.Client.Presentables.ObjectClassModel";
			DataStore[10].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[10].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[11];
			DataStore[10].Seal();
			DataStore[11].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[11].FullName = @"Kistl.Client.Presentables.DataTypeModel";
			DataStore[11].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[11].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83];
			DataStore[11].Seal();
			DataStore[12].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[12].FullName = @"Kistl.Client.Presentables.SaveContextCommand";
			DataStore[12].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[12].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[45];
			DataStore[12].Seal();
			DataStore[13].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[13].FullName = @"Kistl.Client.Presentables.WorkspaceModel";
			DataStore[13].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[13].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[13].Seal();
			DataStore[14].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[14].FullName = @"Kistl.Client.ClientExtensions";
			DataStore[14].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[14].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[14].Seal();
			DataStore[15].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[15].FullName = @"Kistl.Client.ClientHelper";
			DataStore[15].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[15].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[15].Seal();
			DataStore[16].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[16].FullName = @"Kistl.Client.Presentables.ActionModel";
			DataStore[16].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[16].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[16].Seal();
			DataStore[17].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[17].FullName = @"Kistl.Client.Presentables.ObjectListModel";
			DataStore[17].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[17].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[355];
			DataStore[17].Seal();
			DataStore[18].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[18].FullName = @"Kistl.Client.Presentables.DataObjectSelectionTaskModel";
			DataStore[18].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[18].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[357];
			DataStore[18].Seal();
			DataStore[23].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[23].FullName = @"Kistl.Client.ServerDomainManager";
			DataStore[23].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[23].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[23].Seal();
			DataStore[24].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[24].FullName = @"Kistl.Client.Presentables.SynchronousThreadManager";
			DataStore[24].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[24].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[24].Seal();
			DataStore[25].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[25].FullName = @"Kistl.Client.Presentables.WPF.AsyncThreadManager";
			DataStore[25].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[25].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[25].Seal();
			DataStore[26].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[26].FullName = @"Kistl.Client.Presentables.WPF.UiThreadManager";
			DataStore[26].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[26].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[26].Seal();
			DataStore[27].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[27].FullName = @"Kistl.Client.Presentables.IThreadManager";
			DataStore[27].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[27].Parent = null;
			DataStore[27].Seal();
			DataStore[31].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[31].FullName = @"Kistl.Client.TheseMethodsShouldBeImplementedOnKistlObjects";
			DataStore[31].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[31].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[31].Seal();
			DataStore[34].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[34].FullName = @"Kistl.Client.Presentables.ObjectReferenceModel";
			DataStore[34].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[34].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[374];
			DataStore[34].Seal();
			DataStore[39].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[39].FullName = @"Kistl.Client.GUI.IView";
			DataStore[39].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[39].Parent = null;
			DataStore[39].Seal();
			DataStore[40].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[40].FullName = @"Kistl.Client.Presentables.ModelState";
			DataStore[40].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[40].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[40].Seal();
			DataStore[41].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[41].FullName = @"Kistl.Client.Presentables.MethodInvocationModel";
			DataStore[41].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[41].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83];
			DataStore[41].Seal();
			DataStore[45].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[45].FullName = @"Kistl.Client.Presentables.CommandModel";
			DataStore[45].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[45].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[45].Seal();
			DataStore[46].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[46].FullName = @"Kistl.Client.Presentables.ICommand";
			DataStore[46].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[46].Parent = null;
			DataStore[46].Seal();
			DataStore[47].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[47].FullName = @"Kistl.Client.GuiApplicationContext";
			DataStore[47].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[47].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[302];
			DataStore[47].Seal();
			DataStore[48].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[48].FullName = @"Kistl.Client.IGuiApplicationContext";
			DataStore[48].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[48].Parent = null;
			DataStore[48].Seal();
			DataStore[81].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[81].FullName = @"Kistl.Client.Presentables.ModelFactory";
			DataStore[81].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[81].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[81].Seal();
			DataStore[83].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[83].FullName = @"Kistl.Client.Presentables.DataObjectModel";
			DataStore[83].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[83].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[83].Seal();
			DataStore[92].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[92].FullName = @"Kistl.Client.Presentables.IClearableValue";
			DataStore[92].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[92].Parent = null;
			DataStore[92].Seal();
			DataStore[94].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[94].FullName = @"Kistl.Client.Presentables.KistlContextModel";
			DataStore[94].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[94].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[94].Seal();
			DataStore[95].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[95].FullName = @"Kistl.Client.Presentables.KistlDebuggerAsModel";
			DataStore[95].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[95].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[95].Seal();
			DataStore[96].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[96].FullName = @"Kistl.Client.Presentables.PresentableModel";
			DataStore[96].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[96].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[96].Seal();
			DataStore[108].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[13];
			DataStore[108].FullName = @"Kistl.App.Base.Multiplicity";
			DataStore[108].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[108].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[108].Seal();
			DataStore[110].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[13];
			DataStore[110].FullName = @"Kistl.App.Base.StorageType";
			DataStore[110].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[110].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[110].Seal();
			DataStore[112].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[13];
			DataStore[112].FullName = @"Kistl.App.GUI.VisualType";
			DataStore[112].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[112].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[112].Seal();
			DataStore[114].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[13];
			DataStore[114].FullName = @"Kistl.App.GUI.Toolkit";
			DataStore[114].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[114].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[114].Seal();
			DataStore[116].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[13];
			DataStore[116].FullName = @"Kistl.App.Test.TestEnum";
			DataStore[116].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[116].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[300];
			DataStore[116].Seal();
			DataStore[145].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[145].FullName = @"Kistl.Client.WPF.View.KistlDebuggerView";
			DataStore[145].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[145].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[317];
			DataStore[145].Seal();
			DataStore[146].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[146].FullName = @"Kistl.Client.WPF.View.ListValueView";
			DataStore[146].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[146].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[146].Seal();
			DataStore[147].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[147].FullName = @"Kistl.Client.WPF.View.EnumSelectionView";
			DataStore[147].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[147].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[147].Seal();
			DataStore[148].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[148].FullName = @"Kistl.Client.WPF.View.TextValueSelectionView";
			DataStore[148].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[148].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[148].Seal();
			DataStore[149].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[149].FullName = @"Kistl.Client.WPF.View.ActionView";
			DataStore[149].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[149].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[318];
			DataStore[149].Seal();
			DataStore[150].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[150].FullName = @"Kistl.Client.WPF.View.SelectionDialog";
			DataStore[150].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[150].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[317];
			DataStore[150].Seal();
			DataStore[151].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[151].FullName = @"Kistl.Client.WPF.View.NullableBoolValueView";
			DataStore[151].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[151].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[151].Seal();
			DataStore[152].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[16];
			DataStore[152].FullName = @"Kistl.Client.ASPNET.Toolkit.View.NullablePropertyTextBoxViewLoader";
			DataStore[152].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[152].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[320];
			DataStore[152].Seal();
			DataStore[153].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[153].FullName = @"Kistl.Client.Forms.View.NullablePropertyTextBoxView";
			DataStore[153].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[153].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[328];
			DataStore[153].Seal();
			DataStore[154].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[154].FullName = @"Kistl.Client.WPF.View.NullablePropertyTextBoxView";
			DataStore[154].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[154].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[154].Seal();
			DataStore[155].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[155].FullName = @"Kistl.Client.WPF.View.DataObjectView";
			DataStore[155].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[155].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[318];
			DataStore[155].Seal();
			DataStore[156].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[16];
			DataStore[156].FullName = @"Kistl.Client.ASPNET.Toolkit.View.DataObjectListViewLoader";
			DataStore[156].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[156].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[320];
			DataStore[156].Seal();
			DataStore[157].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[157].FullName = @"Kistl.Client.Forms.View.DataObjectListView";
			DataStore[157].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[157].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[330];
			DataStore[157].Seal();
			DataStore[158].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[158].FullName = @"Kistl.Client.WPF.View.DataObjectListView";
			DataStore[158].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[158].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[158].Seal();
			DataStore[159].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[16];
			DataStore[159].FullName = @"Kistl.Client.ASPNET.Toolkit.View.DataObjectReferenceViewLoader";
			DataStore[159].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[159].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[320];
			DataStore[159].Seal();
			DataStore[160].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[160].FullName = @"Kistl.Client.Forms.View.DataObjectReferenceView";
			DataStore[160].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[160].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[332];
			DataStore[160].Seal();
			DataStore[161].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[161].FullName = @"Kistl.Client.WPF.View.ObjectReferenceView";
			DataStore[161].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[161].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[319];
			DataStore[161].Seal();
			DataStore[162].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[16];
			DataStore[162].FullName = @"Kistl.Client.ASPNET.Toolkit.View.DataObjectFullViewLoader";
			DataStore[162].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[162].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[320];
			DataStore[162].Seal();
			DataStore[163].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[163].FullName = @"Kistl.Client.Forms.View.DataObjectFullView";
			DataStore[163].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[163].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[334];
			DataStore[163].Seal();
			DataStore[164].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[164].FullName = @"Kistl.Client.WPF.View.DataObjectFullView";
			DataStore[164].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[164].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[318];
			DataStore[164].Seal();
			DataStore[165].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[16];
			DataStore[165].FullName = @"Kistl.Client.ASPNET.Toolkit.View.WorkspaceViewLoader";
			DataStore[165].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[165].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[320];
			DataStore[165].Seal();
			DataStore[166].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[166].FullName = @"Kistl.Client.Forms.View.WorkspaceView";
			DataStore[166].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[166].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[335];
			DataStore[166].Seal();
			DataStore[167].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[167].FullName = @"Kistl.Client.WPF.View.WorkspaceView";
			DataStore[167].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[167].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[317];
			DataStore[167].Seal();
			DataStore[273].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[273].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[273].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[108],
});
			DataStore[273].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[424];
			DataStore[273].Seal();
			DataStore[274].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[274].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[274].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[110],
});
			DataStore[274].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[429];
			DataStore[274].Seal();
			DataStore[275].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[275].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[275].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[112],
});
			DataStore[275].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[434];
			DataStore[275].Seal();
			DataStore[276].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[276].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[276].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[114],
});
			DataStore[276].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[439];
			DataStore[276].Seal();
			DataStore[277].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[277].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[277].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[116],
});
			DataStore[277].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[444];
			DataStore[277].Seal();
			DataStore[278].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[18];
			DataStore[278].FullName = @"Kistl.Client.WPF.View.PropertyGroupBoxView";
			DataStore[278].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[278].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[347];
			DataStore[278].Seal();
			DataStore[282].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[282].FullName = @"Kistl.Client.Forms.View.DataObjectReferenceView";
			DataStore[282].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[282].Parent = null;
			DataStore[282].Seal();
			DataStore[283].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[283].FullName = @"Kistl.Client.Presentables.PropertyGroupModel";
			DataStore[283].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[283].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[283].Seal();
			DataStore[295].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[295].FullName = @"System.Object";
			DataStore[295].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[295].Parent = null;
			DataStore[295].Seal();
			DataStore[299].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[299].FullName = @"System.ValueType";
			DataStore[299].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[299].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[299].Seal();
			DataStore[300].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[300].FullName = @"System.Enum";
			DataStore[300].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[300].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[300].Seal();
			DataStore[301].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[15];
			DataStore[301].FullName = @"Kistl.API.ApplicationContext";
			DataStore[301].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[301].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[301].Seal();
			DataStore[302].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[30];
			DataStore[302].FullName = @"Kistl.API.Client.ClientApiContext";
			DataStore[302].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[302].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[301];
			DataStore[302].Seal();
			DataStore[310].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[31];
			DataStore[310].FullName = @"System.Windows.Threading.DispatcherObject";
			DataStore[310].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[310].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[310].Seal();
			DataStore[311].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[31];
			DataStore[311].FullName = @"System.Windows.DependencyObject";
			DataStore[311].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[311].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[310];
			DataStore[311].Seal();
			DataStore[312].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[32];
			DataStore[312].FullName = @"System.Windows.Media.Visual";
			DataStore[312].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[312].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[311];
			DataStore[312].Seal();
			DataStore[313].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[32];
			DataStore[313].FullName = @"System.Windows.UIElement";
			DataStore[313].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[313].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[312];
			DataStore[313].Seal();
			DataStore[314].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[314].FullName = @"System.Windows.FrameworkElement";
			DataStore[314].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[314].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[313];
			DataStore[314].Seal();
			DataStore[315].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[315].FullName = @"System.Windows.Controls.Control";
			DataStore[315].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[315].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[314];
			DataStore[315].Seal();
			DataStore[316].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[316].FullName = @"System.Windows.Controls.ContentControl";
			DataStore[316].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[316].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[315];
			DataStore[316].Seal();
			DataStore[317].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[317].FullName = @"System.Windows.Window";
			DataStore[317].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[317].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[316];
			DataStore[317].Seal();
			DataStore[318].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[318].FullName = @"System.Windows.Controls.UserControl";
			DataStore[318].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[318].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[316];
			DataStore[318].Seal();
			DataStore[319].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[34];
			DataStore[319].FullName = @"Kistl.Client.WPF.View.PropertyView";
			DataStore[319].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[319].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[318];
			DataStore[319].Seal();
			DataStore[320].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[35];
			DataStore[320].FullName = @"Kistl.Client.ASPNET.Toolkit.View.ViewLoader";
			DataStore[320].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[320].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[320].Seal();
			DataStore[321].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[321].FullName = @"System.MarshalByRefObject";
			DataStore[321].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[321].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[321].Seal();
			DataStore[322].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[36];
			DataStore[322].FullName = @"System.ComponentModel.Component";
			DataStore[322].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[322].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[321];
			DataStore[322].Seal();
			DataStore[323].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[37];
			DataStore[323].FullName = @"System.Windows.Forms.Control";
			DataStore[323].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[323].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[322];
			DataStore[323].Seal();
			DataStore[324].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[37];
			DataStore[324].FullName = @"System.Windows.Forms.ScrollableControl";
			DataStore[324].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[324].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[323];
			DataStore[324].Seal();
			DataStore[325].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[37];
			DataStore[325].FullName = @"System.Windows.Forms.ContainerControl";
			DataStore[325].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[325].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[324];
			DataStore[325].Seal();
			DataStore[326].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[37];
			DataStore[326].FullName = @"System.Windows.Forms.UserControl";
			DataStore[326].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[326].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[325];
			DataStore[326].Seal();
			DataStore[328].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[38];
			DataStore[328].FullName = @"Kistl.Client.Forms.View.NullablePropertyTextBoxViewDesignerProxy";
			DataStore[328].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[328].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[416];
			DataStore[328].Seal();
			DataStore[330].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[38];
			DataStore[330].FullName = @"Kistl.Client.Forms.View.DataObjectListViewDesignerProxy";
			DataStore[330].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[330].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[418];
			DataStore[330].Seal();
			DataStore[332].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[38];
			DataStore[332].FullName = @"Kistl.Client.Forms.View.DataObjectReferenceViewDesignerProxy";
			DataStore[332].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[332].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[419];
			DataStore[332].Seal();
			DataStore[334].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[38];
			DataStore[334].FullName = @"Kistl.Client.Forms.View.DataObjectFullViewDesignerProxy";
			DataStore[334].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[334].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[420];
			DataStore[334].Seal();
			DataStore[335].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[37];
			DataStore[335].FullName = @"System.Windows.Forms.Form";
			DataStore[335].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[335].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[325];
			DataStore[335].Seal();
			DataStore[346].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[346].FullName = @"System.Windows.Controls.HeaderedContentControl";
			DataStore[346].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[346].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[316];
			DataStore[346].Seal();
			DataStore[347].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[33];
			DataStore[347].FullName = @"System.Windows.Controls.GroupBox";
			DataStore[347].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[347].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[346];
			DataStore[347].Seal();
			DataStore[354].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[354].FullName = @"System.Collections.Generic.ICollection`1";
			DataStore[354].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83],
});
			DataStore[354].Parent = null;
			DataStore[354].Seal();
			DataStore[355].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[355].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[355].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[354],
});
			DataStore[355].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[355].Seal();
			DataStore[357].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[357].FullName = @"Kistl.Client.Presentables.SelectionTaskModel`1";
			DataStore[357].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83],
});
			DataStore[357].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[357].Seal();
			DataStore[374].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[374].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[374].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83],
});
			DataStore[374].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[374].Seal();
			DataStore[382].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[382].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[382].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[382].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[382].Seal();
			DataStore[383].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[383].FullName = @"System.String";
			DataStore[383].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[383].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[295];
			DataStore[383].Seal();
			DataStore[384].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[384].FullName = @"Kistl.Client.Presentables.ReferencePropertyModel`1";
			DataStore[384].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[384].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[382];
			DataStore[384].Seal();
			DataStore[394].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[394].FullName = @"Kistl.Client.Presentables.ChooseReferencePropertyModel`1";
			DataStore[394].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[394].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[384];
			DataStore[394].Seal();
			DataStore[395].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[395].FullName = @"System.Nullable`1";
			DataStore[395].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[398],
});
			DataStore[395].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[395].Seal();
			DataStore[396].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[396].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[396].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[395],
});
			DataStore[396].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[396].Seal();
			DataStore[398].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[398].FullName = @"System.Int32";
			DataStore[398].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[398].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[398].Seal();
			DataStore[399].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[399].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[399].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[398],
});
			DataStore[399].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[396];
			DataStore[399].Seal();
			DataStore[400].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[400].FullName = @"System.Nullable`1";
			DataStore[400].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[403],
});
			DataStore[400].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[400].Seal();
			DataStore[401].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[401].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[401].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[400],
});
			DataStore[401].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[401].Seal();
			DataStore[403].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[403].FullName = @"System.Double";
			DataStore[403].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[403].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[403].Seal();
			DataStore[404].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[404].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[404].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[403],
});
			DataStore[404].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[401];
			DataStore[404].Seal();
			DataStore[405].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[405].FullName = @"System.Nullable`1";
			DataStore[405].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[408],
});
			DataStore[405].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[405].Seal();
			DataStore[406].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[406].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[406].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[405],
});
			DataStore[406].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[406].Seal();
			DataStore[408].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[408].FullName = @"System.DateTime";
			DataStore[408].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[408].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[408].Seal();
			DataStore[409].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[409].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[409].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[408],
});
			DataStore[409].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[406];
			DataStore[409].Seal();
			DataStore[410].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[410].FullName = @"System.Nullable`1";
			DataStore[410].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[413],
});
			DataStore[410].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[410].Seal();
			DataStore[411].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[411].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[411].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[410],
});
			DataStore[411].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[411].Seal();
			DataStore[413].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[413].FullName = @"System.Boolean";
			DataStore[413].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[413].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[413].Seal();
			DataStore[414].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[414].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[414].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[413],
});
			DataStore[414].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[411];
			DataStore[414].Seal();
			DataStore[415].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[415].FullName = @"Kistl.Client.Presentables.IValueModel`1";
			DataStore[415].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[415].Parent = null;
			DataStore[415].Seal();
			DataStore[416].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[416].FullName = @"Kistl.Client.Forms.View.FormsUserControl`1";
			DataStore[416].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[415],
});
			DataStore[416].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[326];
			DataStore[416].Seal();
			DataStore[418].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[418].FullName = @"Kistl.Client.Forms.View.FormsUserControl`1";
			DataStore[418].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[17],
});
			DataStore[418].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[326];
			DataStore[418].Seal();
			DataStore[419].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[419].FullName = @"Kistl.Client.Forms.View.FormsUserControl`1";
			DataStore[419].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[34],
});
			DataStore[419].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[326];
			DataStore[419].Seal();
			DataStore[420].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[17];
			DataStore[420].FullName = @"Kistl.Client.Forms.View.FormsUserControl`1";
			DataStore[420].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[83],
});
			DataStore[420].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[326];
			DataStore[420].Seal();
			DataStore[421].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[421].FullName = @"System.Nullable`1";
			DataStore[421].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[108],
});
			DataStore[421].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[421].Seal();
			DataStore[422].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[422].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[422].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[421],
});
			DataStore[422].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[422].Seal();
			DataStore[424].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[424].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[424].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[108],
});
			DataStore[424].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[422];
			DataStore[424].Seal();
			DataStore[426].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[426].FullName = @"System.Nullable`1";
			DataStore[426].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[110],
});
			DataStore[426].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[426].Seal();
			DataStore[427].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[427].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[427].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[426],
});
			DataStore[427].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[427].Seal();
			DataStore[429].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[429].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[429].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[110],
});
			DataStore[429].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[427];
			DataStore[429].Seal();
			DataStore[431].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[431].FullName = @"System.Nullable`1";
			DataStore[431].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[112],
});
			DataStore[431].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[431].Seal();
			DataStore[432].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[432].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[432].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[431],
});
			DataStore[432].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[432].Seal();
			DataStore[434].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[434].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[434].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[112],
});
			DataStore[434].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[432];
			DataStore[434].Seal();
			DataStore[436].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[436].FullName = @"System.Nullable`1";
			DataStore[436].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[114],
});
			DataStore[436].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[436].Seal();
			DataStore[437].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[437].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[437].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[436],
});
			DataStore[437].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[437].Seal();
			DataStore[439].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[439].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[439].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[114],
});
			DataStore[439].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[437];
			DataStore[439].Seal();
			DataStore[441].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[441].FullName = @"System.Nullable`1";
			DataStore[441].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[116],
});
			DataStore[441].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[299];
			DataStore[441].Seal();
			DataStore[442].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[442].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[442].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[441],
});
			DataStore[442].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[442].Seal();
			DataStore[444].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[444].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[444].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[116],
});
			DataStore[444].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[442];
			DataStore[444].Seal();
			DataStore[447].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[15];
			DataStore[447].FullName = @"Kistl.API.IDataObject";
			DataStore[447].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[447].Parent = null;
			DataStore[447].Seal();
			DataStore[448].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[448].FullName = @"Kistl.Client.Presentables.ObjectResultModel`1";
			DataStore[448].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[447],
});
			DataStore[448].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[560];
			DataStore[448].Seal();
			DataStore[449].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[449].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[449].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[449].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[449].Seal();
			DataStore[450].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[450].FullName = @"Kistl.Client.Presentables.ObjectResultModel`1";
			DataStore[450].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[450].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[449];
			DataStore[450].Seal();
			DataStore[454].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[454].FullName = @"Kistl.Client.Presentables.NullableResultModel`1";
			DataStore[454].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[398],
});
			DataStore[454].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[556];
			DataStore[454].Seal();
			DataStore[458].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[458].FullName = @"Kistl.Client.Presentables.NullableResultModel`1";
			DataStore[458].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[403],
});
			DataStore[458].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[557];
			DataStore[458].Seal();
			DataStore[462].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[462].FullName = @"Kistl.Client.Presentables.NullableResultModel`1";
			DataStore[462].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[408],
});
			DataStore[462].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[558];
			DataStore[462].Seal();
			DataStore[466].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[466].FullName = @"Kistl.Client.Presentables.NullableResultModel`1";
			DataStore[466].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[413],
});
			DataStore[466].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[559];
			DataStore[466].Seal();
			DataStore[469].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[29];
			DataStore[469].FullName = @"System.Collections.Generic.ICollection`1";
			DataStore[469].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[383],
});
			DataStore[469].Parent = null;
			DataStore[469].Seal();
			DataStore[470].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[470].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[470].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[469],
});
			DataStore[470].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[470].Seal();
			DataStore[556].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[556].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[556].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[395],
});
			DataStore[556].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[556].Seal();
			DataStore[557].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[557].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[557].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[400],
});
			DataStore[557].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[557].Seal();
			DataStore[558].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[558].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[558].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[405],
});
			DataStore[558].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[558].Seal();
			DataStore[559].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[559].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[559].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[410],
});
			DataStore[559].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[559].Seal();
			DataStore[560].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[560].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[560].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(1) {
Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[447],
});
			DataStore[560].Parent = Kistl.App.Base.TypeRef__Implementation__Frozen.DataStore[96];
			DataStore[560].Seal();
	
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
        public override void ToStream(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}