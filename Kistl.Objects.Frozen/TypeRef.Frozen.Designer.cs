
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
                    NotifyPropertyChanging("Assembly");
                    _Assembly = value;
                    NotifyPropertyChanged("Assembly");;
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
                    NotifyPropertyChanging("FullName");
                    _FullName = value;
                    NotifyPropertyChanged("FullName");;
                }
            }
        }
        private string _FullName;

        /// <summary>
        /// list of type arguments
        /// </summary>
        // object reference list property
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
        /// get the referenced <see cref="System.Type"/>
        /// </summary>

		public virtual System.Type AsType(System.Boolean throwOnError) 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnAsType_TypeRef != null)
            {
                OnAsType_TypeRef(this, e, throwOnError);
            };
            return e.Result;
        }
		public delegate void AsType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret, System.Boolean throwOnError);
		public event AsType_Handler<TypeRef> OnAsType_TypeRef;



		public override Type GetInterfaceType()
		{
			return typeof(TypeRef);
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


		internal static Dictionary<int, TypeRef__Implementation__Frozen> DataStore = new Dictionary<int, TypeRef__Implementation__Frozen>(106);
		internal static void CreateInstances()
		{
			DataStore[1] = new TypeRef__Implementation__Frozen(1);

			DataStore[2] = new TypeRef__Implementation__Frozen(2);

			DataStore[3] = new TypeRef__Implementation__Frozen(3);

			DataStore[4] = new TypeRef__Implementation__Frozen(4);

			DataStore[5] = new TypeRef__Implementation__Frozen(5);

			DataStore[6] = new TypeRef__Implementation__Frozen(6);

			DataStore[7] = new TypeRef__Implementation__Frozen(7);

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

			DataStore[19] = new TypeRef__Implementation__Frozen(19);

			DataStore[20] = new TypeRef__Implementation__Frozen(20);

			DataStore[21] = new TypeRef__Implementation__Frozen(21);

			DataStore[22] = new TypeRef__Implementation__Frozen(22);

			DataStore[23] = new TypeRef__Implementation__Frozen(23);

			DataStore[24] = new TypeRef__Implementation__Frozen(24);

			DataStore[25] = new TypeRef__Implementation__Frozen(25);

			DataStore[26] = new TypeRef__Implementation__Frozen(26);

			DataStore[27] = new TypeRef__Implementation__Frozen(27);

			DataStore[28] = new TypeRef__Implementation__Frozen(28);

			DataStore[29] = new TypeRef__Implementation__Frozen(29);

			DataStore[30] = new TypeRef__Implementation__Frozen(30);

			DataStore[31] = new TypeRef__Implementation__Frozen(31);

			DataStore[32] = new TypeRef__Implementation__Frozen(32);

			DataStore[33] = new TypeRef__Implementation__Frozen(33);

			DataStore[34] = new TypeRef__Implementation__Frozen(34);

			DataStore[35] = new TypeRef__Implementation__Frozen(35);

			DataStore[36] = new TypeRef__Implementation__Frozen(36);

			DataStore[37] = new TypeRef__Implementation__Frozen(37);

			DataStore[38] = new TypeRef__Implementation__Frozen(38);

			DataStore[39] = new TypeRef__Implementation__Frozen(39);

			DataStore[40] = new TypeRef__Implementation__Frozen(40);

			DataStore[41] = new TypeRef__Implementation__Frozen(41);

			DataStore[42] = new TypeRef__Implementation__Frozen(42);

			DataStore[43] = new TypeRef__Implementation__Frozen(43);

			DataStore[44] = new TypeRef__Implementation__Frozen(44);

			DataStore[45] = new TypeRef__Implementation__Frozen(45);

			DataStore[46] = new TypeRef__Implementation__Frozen(46);

			DataStore[47] = new TypeRef__Implementation__Frozen(47);

			DataStore[48] = new TypeRef__Implementation__Frozen(48);

			DataStore[49] = new TypeRef__Implementation__Frozen(49);

			DataStore[50] = new TypeRef__Implementation__Frozen(50);

			DataStore[51] = new TypeRef__Implementation__Frozen(51);

			DataStore[52] = new TypeRef__Implementation__Frozen(52);

			DataStore[53] = new TypeRef__Implementation__Frozen(53);

			DataStore[54] = new TypeRef__Implementation__Frozen(54);

			DataStore[55] = new TypeRef__Implementation__Frozen(55);

			DataStore[56] = new TypeRef__Implementation__Frozen(56);

			DataStore[57] = new TypeRef__Implementation__Frozen(57);

			DataStore[58] = new TypeRef__Implementation__Frozen(58);

			DataStore[59] = new TypeRef__Implementation__Frozen(59);

			DataStore[60] = new TypeRef__Implementation__Frozen(60);

			DataStore[61] = new TypeRef__Implementation__Frozen(61);

			DataStore[62] = new TypeRef__Implementation__Frozen(62);

			DataStore[63] = new TypeRef__Implementation__Frozen(63);

			DataStore[64] = new TypeRef__Implementation__Frozen(64);

			DataStore[65] = new TypeRef__Implementation__Frozen(65);

			DataStore[66] = new TypeRef__Implementation__Frozen(66);

			DataStore[67] = new TypeRef__Implementation__Frozen(67);

			DataStore[68] = new TypeRef__Implementation__Frozen(68);

			DataStore[69] = new TypeRef__Implementation__Frozen(69);

			DataStore[70] = new TypeRef__Implementation__Frozen(70);

			DataStore[71] = new TypeRef__Implementation__Frozen(71);

			DataStore[72] = new TypeRef__Implementation__Frozen(72);

			DataStore[73] = new TypeRef__Implementation__Frozen(73);

			DataStore[74] = new TypeRef__Implementation__Frozen(74);

			DataStore[75] = new TypeRef__Implementation__Frozen(75);

			DataStore[76] = new TypeRef__Implementation__Frozen(76);

			DataStore[77] = new TypeRef__Implementation__Frozen(77);

			DataStore[78] = new TypeRef__Implementation__Frozen(78);

			DataStore[79] = new TypeRef__Implementation__Frozen(79);

			DataStore[80] = new TypeRef__Implementation__Frozen(80);

			DataStore[81] = new TypeRef__Implementation__Frozen(81);

			DataStore[82] = new TypeRef__Implementation__Frozen(82);

			DataStore[83] = new TypeRef__Implementation__Frozen(83);

			DataStore[84] = new TypeRef__Implementation__Frozen(84);

			DataStore[85] = new TypeRef__Implementation__Frozen(85);

			DataStore[86] = new TypeRef__Implementation__Frozen(86);

			DataStore[87] = new TypeRef__Implementation__Frozen(87);

			DataStore[88] = new TypeRef__Implementation__Frozen(88);

			DataStore[89] = new TypeRef__Implementation__Frozen(89);

			DataStore[90] = new TypeRef__Implementation__Frozen(90);

			DataStore[91] = new TypeRef__Implementation__Frozen(91);

			DataStore[92] = new TypeRef__Implementation__Frozen(92);

			DataStore[93] = new TypeRef__Implementation__Frozen(93);

			DataStore[94] = new TypeRef__Implementation__Frozen(94);

			DataStore[95] = new TypeRef__Implementation__Frozen(95);

			DataStore[96] = new TypeRef__Implementation__Frozen(96);

			DataStore[97] = new TypeRef__Implementation__Frozen(97);

			DataStore[98] = new TypeRef__Implementation__Frozen(98);

			DataStore[99] = new TypeRef__Implementation__Frozen(99);

			DataStore[100] = new TypeRef__Implementation__Frozen(100);

			DataStore[101] = new TypeRef__Implementation__Frozen(101);

			DataStore[102] = new TypeRef__Implementation__Frozen(102);

			DataStore[103] = new TypeRef__Implementation__Frozen(103);

			DataStore[104] = new TypeRef__Implementation__Frozen(104);

			DataStore[105] = new TypeRef__Implementation__Frozen(105);

			DataStore[106] = new TypeRef__Implementation__Frozen(106);

		}

		internal static void FillDataStore() {
			DataStore[1].FullName = @"Kistl.App.Base.CustomClientActions_KistlBase";
			DataStore[1].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[1].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[1].Seal();
			DataStore[2].FullName = @"Kistl.App.Zeiterfassung.CustomServerActions_Zeiterfassung";
			DataStore[2].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[2].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[2].Seal();
			DataStore[3].FullName = @"Kistl.App.Projekte.CustomServerActions_Projekte";
			DataStore[3].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[3].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[3].Seal();
			DataStore[4].FullName = @"Kistl.App.Base.CustomServerActions_KistlBase";
			DataStore[4].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[2];
			DataStore[4].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[4].Seal();
			DataStore[5].FullName = @"Kistl.App.GUI.CustomClientActions_GUI";
			DataStore[5].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[5].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[5].Seal();
			DataStore[6].FullName = @"Kistl.App.Zeiterfassung.CustomClientActions_Zeiterfassung";
			DataStore[6].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[6].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[6].Seal();
			DataStore[7].FullName = @"Kistl.App.Base.CustomClientActions_KistlBase";
			DataStore[7].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[7].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[7].Seal();
			DataStore[8].FullName = @"Kistl.App.Projekte.CustomClientActions_Projekte";
			DataStore[8].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[1];
			DataStore[8].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[8].Seal();
			DataStore[9].FullName = @"Kistl.Client.Presentables.ModuleModel";
			DataStore[9].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[9].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[9].Seal();
			DataStore[10].FullName = @"Kistl.Client.Presentables.ObjectClassModel";
			DataStore[10].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[10].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[10].Seal();
			DataStore[11].FullName = @"Kistl.Client.Presentables.DataTypeModel";
			DataStore[11].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[11].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[11].Seal();
			DataStore[12].FullName = @"Kistl.Client.Presentables.SaveContextCommand";
			DataStore[12].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[12].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[12].Seal();
			DataStore[13].FullName = @"Kistl.Client.Presentables.WorkspaceModel";
			DataStore[13].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[13].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[13].Seal();
			DataStore[14].FullName = @"Kistl.Client.ClientExtensions";
			DataStore[14].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[14].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[14].Seal();
			DataStore[15].FullName = @"Kistl.Client.ClientHelper";
			DataStore[15].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[15].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[15].Seal();
			DataStore[16].FullName = @"Kistl.Client.Presentables.ActionModel";
			DataStore[16].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[16].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[16].Seal();
			DataStore[17].FullName = @"Kistl.Client.Presentables.ObjectListModel";
			DataStore[17].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[17].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[17].Seal();
			DataStore[18].FullName = @"Kistl.Client.Presentables.DataObjectSelectionTaskModel";
			DataStore[18].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[18].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[18].Seal();
			DataStore[19].FullName = @"Kistl.Client.Presentables.SelectionTaskModel`1";
			DataStore[19].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[19].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[19].Seal();
			DataStore[20].FullName = @"Kistl.Client.Presentables.SimpleReferenceListPropertyModel`1";
			DataStore[20].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[20].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[20].Seal();
			DataStore[21].FullName = @"Kistl.Client.Presentables.ReferenceListPropertyModel`2";
			DataStore[21].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[21].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[21].Seal();
			DataStore[22].FullName = @"Kistl.Client.Presentables.IValueListModel`1";
			DataStore[22].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[22].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[22].Seal();
			DataStore[23].FullName = @"Kistl.Client.ServerDomainManager";
			DataStore[23].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[23].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[23].Seal();
			DataStore[24].FullName = @"Kistl.Client.Presentables.SynchronousThreadManager";
			DataStore[24].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[24].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[24].Seal();
			DataStore[25].FullName = @"Kistl.Client.Presentables.WPF.AsyncThreadManager";
			DataStore[25].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[25].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[25].Seal();
			DataStore[26].FullName = @"Kistl.Client.Presentables.WPF.UiThreadManager";
			DataStore[26].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[26].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[26].Seal();
			DataStore[27].FullName = @"Kistl.Client.Presentables.IThreadManager";
			DataStore[27].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[27].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[27].Seal();
			DataStore[28].FullName = @"Kistl.GUI.ObjectListMethodPresenter";
			DataStore[28].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[28].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[28].Seal();
			DataStore[29].FullName = @"Kistl.GUI.ObjectMethodPresenter";
			DataStore[29].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[29].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[29].Seal();
			DataStore[30].FullName = @"Kistl.GUI.DefaultMethodPresenter`1";
			DataStore[30].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[30].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[30].Seal();
			DataStore[31].FullName = @"Kistl.Client.TheseMethodsShouldBeImplementedOnKistlObjects";
			DataStore[31].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[31].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[31].Seal();
			DataStore[32].FullName = @"Kistl.GUI.Renderer.BasicRenderer`3";
			DataStore[32].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[32].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[32].Seal();
			DataStore[33].FullName = @"Kistl.GUI.Renderer.IRenderer";
			DataStore[33].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[33].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[33].Seal();
			DataStore[34].FullName = @"Kistl.Client.Presentables.ObjectReferenceModel";
			DataStore[34].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[34].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[34].Seal();
			DataStore[35].FullName = @"Kistl.GUI.DB.KistlGUIContext";
			DataStore[35].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[35].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[35].Seal();
			DataStore[36].FullName = @"Kistl.GUI.ObjectReferencePresenter`1";
			DataStore[36].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[36].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[36].Seal();
			DataStore[37].FullName = @"Kistl.GUI.ObjectListPresenter`1";
			DataStore[37].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[37].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[37].Seal();
			DataStore[38].FullName = @"Kistl.GUI.ListPresenter`2";
			DataStore[38].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[38].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[38].Seal();
			DataStore[39].FullName = @"Kistl.Client.GUI.IView";
			DataStore[39].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[39].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[39].Seal();
			DataStore[40].FullName = @"Kistl.Client.Presentables.ModelState";
			DataStore[40].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[40].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[40].Seal();
			DataStore[41].FullName = @"Kistl.Client.Presentables.MethodInvocationModel";
			DataStore[41].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[41].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[41].Seal();
			DataStore[42].FullName = @"Kistl.Client.Presentables.ObjectResultModel`1";
			DataStore[42].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[42].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[42].Seal();
			DataStore[43].FullName = @"Kistl.Client.Presentables.NullableResultModel`1";
			DataStore[43].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[43].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[43].Seal();
			DataStore[44].FullName = @"Kistl.Client.Presentables.MethodResultModel`1";
			DataStore[44].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[44].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[44].Seal();
			DataStore[45].FullName = @"Kistl.Client.Presentables.CommandModel";
			DataStore[45].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[45].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[45].Seal();
			DataStore[46].FullName = @"Kistl.Client.Presentables.ICommand";
			DataStore[46].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[46].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[46].Seal();
			DataStore[47].FullName = @"Kistl.Client.GuiApplicationContext";
			DataStore[47].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[47].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[47].Seal();
			DataStore[48].FullName = @"Kistl.Client.IGuiApplicationContext";
			DataStore[48].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[48].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[48].Seal();
			DataStore[49].FullName = @"Kistl.GUI.ExtensionHelper";
			DataStore[49].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[49].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[49].Seal();
			DataStore[50].FullName = @"Kistl.GUI.WorkspacePresenter";
			DataStore[50].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[50].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[50].Seal();
			DataStore[51].FullName = @"Kistl.GUI.ObjectPresenter";
			DataStore[51].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[51].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[51].Seal();
			DataStore[52].FullName = @"Kistl.GUI.ActionPresenter";
			DataStore[52].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[52].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[52].Seal();
			DataStore[53].FullName = @"Kistl.GUI.GroupPresenter";
			DataStore[53].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[53].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[53].Seal();
			DataStore[54].FullName = @"Kistl.GUI.ToolBarPresenter";
			DataStore[54].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[54].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[54].Seal();
			DataStore[55].FullName = @"Kistl.GUI.EnumerationPresenter`1";
			DataStore[55].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[55].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[55].Seal();
			DataStore[56].FullName = @"Kistl.GUI.DefaultValuePresenter`1";
			DataStore[56].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[56].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[56].Seal();
			DataStore[57].FullName = @"Kistl.GUI.DefaultStructPresenter`1";
			DataStore[57].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[57].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[57].Seal();
			DataStore[58].FullName = @"Kistl.GUI.DefaultListPresenter`1";
			DataStore[58].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[58].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[58].Seal();
			DataStore[59].FullName = @"Kistl.GUI.DefaultPresenter`4";
			DataStore[59].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[59].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[59].Seal();
			DataStore[60].FullName = @"Kistl.GUI.Presenter`1";
			DataStore[60].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[60].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[60].Seal();
			DataStore[61].FullName = @"Kistl.GUI.IPresenter";
			DataStore[61].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[61].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[61].Seal();
			DataStore[62].FullName = @"Kistl.Client.GUI.DB.DataMocks";
			DataStore[62].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[62].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[62].Seal();
			DataStore[63].FullName = @"Kistl.Client.GUI.DB.DebuggerLayout";
			DataStore[63].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[63].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[63].Seal();
			DataStore[64].FullName = @"Kistl.Client.GUI.DB.ActionLayout";
			DataStore[64].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[64].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[64].Seal();
			DataStore[65].FullName = @"Kistl.Client.GUI.DB.SelectionTaskLayout";
			DataStore[65].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[65].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[65].Seal();
			DataStore[66].FullName = @"Kistl.Client.GUI.DB.DataObjectReferenceLayout";
			DataStore[66].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[66].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[66].Seal();
			DataStore[67].FullName = @"Kistl.Client.GUI.DB.DataObjectListLayout";
			DataStore[67].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[67].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[67].Seal();
			DataStore[68].FullName = @"Kistl.Client.GUI.DB.DataObjectFullLayout";
			DataStore[68].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[68].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[68].Seal();
			DataStore[69].FullName = @"Kistl.Client.GUI.DB.DataObjectLineLayout";
			DataStore[69].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[69].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[69].Seal();
			DataStore[70].FullName = @"Kistl.Client.GUI.DB.ListValueLayout";
			DataStore[70].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[70].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[70].Seal();
			DataStore[71].FullName = @"Kistl.Client.GUI.DB.TextValueSelectionLayout";
			DataStore[71].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[71].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[71].Seal();
			DataStore[72].FullName = @"Kistl.Client.GUI.DB.TextValueLayout";
			DataStore[72].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[72].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[72].Seal();
			DataStore[73].FullName = @"Kistl.Client.GUI.DB.SimpleEnumValueLayout";
			DataStore[73].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[73].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[73].Seal();
			DataStore[74].FullName = @"Kistl.Client.GUI.DB.SimpleNullableValueLayout`1";
			DataStore[74].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[74].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[74].Seal();
			DataStore[75].FullName = @"Kistl.Client.GUI.DB.WorkspaceLayout";
			DataStore[75].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[75].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[75].Seal();
			DataStore[76].FullName = @"Kistl.Client.GUI.DB.StaticLayout";
			DataStore[76].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[76].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[76].Seal();
			DataStore[77].FullName = @"Kistl.Client.GUI.DB.Layout";
			DataStore[77].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[77].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[77].Seal();
			DataStore[78].FullName = @"Kistl.Client.GUI.DB.ModelDescriptor";
			DataStore[78].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[78].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[78].Seal();
			DataStore[79].FullName = @"Kistl.Client.GUI.DB.ViewDescriptor";
			DataStore[79].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[79].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[79].Seal();
			DataStore[80].FullName = @"Kistl.Client.GUI.DB.TypeRef";
			DataStore[80].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[80].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[80].Seal();
			DataStore[81].FullName = @"Kistl.Client.Presentables.ModelFactory";
			DataStore[81].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[81].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[81].Seal();
			DataStore[82].FullName = @"Kistl.GUI.DB.VisualHelper";
			DataStore[82].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[82].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[82].Seal();
			DataStore[83].FullName = @"Kistl.Client.Presentables.DataObjectModel";
			DataStore[83].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[83].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[83].Seal();
			DataStore[84].FullName = @"Kistl.GUI.DB.TemplateUsage";
			DataStore[84].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[84].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[84].Seal();
			DataStore[85].FullName = @"Kistl.GUI.DB.TemplateHelper";
			DataStore[85].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[85].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[85].Seal();
			DataStore[86].FullName = @"Kistl.Client.Presentables.EnumerationPropertyModel`1";
			DataStore[86].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[86].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[86].Seal();
			DataStore[87].FullName = @"Kistl.Client.Presentables.ChooseReferencePropertyModel`1";
			DataStore[87].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[87].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[87].Seal();
			DataStore[88].FullName = @"Kistl.Client.Presentables.ReferencePropertyModel`1";
			DataStore[88].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[88].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[88].Seal();
			DataStore[89].FullName = @"Kistl.Client.Presentables.NullableValuePropertyModel`1";
			DataStore[89].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[89].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[89].Seal();
			DataStore[90].FullName = @"Kistl.Client.Presentables.PropertyModel`1";
			DataStore[90].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[90].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[90].Seal();
			DataStore[91].FullName = @"Kistl.Client.Presentables.IValueModel`1";
			DataStore[91].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[91].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[91].Seal();
			DataStore[92].FullName = @"Kistl.Client.Presentables.IClearableValue";
			DataStore[92].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[92].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[92].Seal();
			DataStore[93].FullName = @"Kistl.Client.Presentables.IReadOnlyValueModel`1";
			DataStore[93].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[93].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[93].Seal();
			DataStore[94].FullName = @"Kistl.Client.Presentables.KistlContextModel";
			DataStore[94].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[94].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[94].Seal();
			DataStore[95].FullName = @"Kistl.Client.Presentables.KistlDebuggerAsModel";
			DataStore[95].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[95].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[95].Seal();
			DataStore[96].FullName = @"Kistl.Client.Presentables.PresentableModel";
			DataStore[96].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[96].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[96].Seal();
			DataStore[97].FullName = @"Kistl.GUI.FieldSize";
			DataStore[97].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[97].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[97].Seal();
			DataStore[98].FullName = @"Kistl.GUI.IActionControl";
			DataStore[98].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[98].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[98].Seal();
			DataStore[99].FullName = @"Kistl.GUI.IWorkspaceControl";
			DataStore[99].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[99].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[99].Seal();
			DataStore[100].FullName = @"Kistl.GUI.IObjectControl";
			DataStore[100].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[100].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[100].Seal();
			DataStore[101].FullName = @"Kistl.GUI.IReferenceListControl";
			DataStore[101].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[101].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[101].Seal();
			DataStore[102].FullName = @"Kistl.GUI.IReferenceControl";
			DataStore[102].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[102].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[102].Seal();
			DataStore[103].FullName = @"Kistl.GUI.IListControl`1";
			DataStore[103].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[103].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[103].Seal();
			DataStore[104].FullName = @"Kistl.GUI.IEnumControl";
			DataStore[104].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[104].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[104].Seal();
			DataStore[105].FullName = @"Kistl.GUI.IValueControl`1";
			DataStore[105].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[105].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[105].Seal();
			DataStore[106].FullName = @"Kistl.GUI.IBasicControl";
			DataStore[106].Assembly = Kistl.App.Base.Assembly__Implementation__Frozen.DataStore[14];
			DataStore[106].GenericArguments = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.TypeRef>(new List<Kistl.App.Base.TypeRef>(0) {
});
			DataStore[106].Seal();
	
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

#endregion

    }


}