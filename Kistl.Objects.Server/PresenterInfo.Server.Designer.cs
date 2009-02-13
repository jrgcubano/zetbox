
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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="PresenterInfo")]
    [System.Diagnostics.DebuggerDisplay("PresenterInfo")]
    public class PresenterInfo__Implementation__ : BaseServerDataObject_EntityFramework, PresenterInfo
    {

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    NotifyPropertyChanging("ID");
                    _ID = value;
                    NotifyPropertyChanged("ID");;
                }
            }
        }
        private int _ID;

        /// <summary>
        /// which controls are handled by this Presenter
        /// </summary>
        // enumeration property
        // implement the user-visible interface
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ControlType != value)
                {
                    NotifyPropertyChanging("ControlType");
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType");
                }
            }
        }
        
        /// <summary>backing store for ControlType</summary>
        private Kistl.App.GUI.VisualType _ControlType;
        
        /// <summary>EF sees only this property, for ControlType</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int ControlType__Implementation__
        {
            get
            {
                return (int)ControlType;
            }
            set
            {
                ControlType = (Kistl.App.GUI.VisualType)value;
            }
        }
        

        /// <summary>
        /// Where to find the implementation of the Presenter
        /// </summary>
    /*
    NewRelation: FK_PresenterInfo_Assembly_PresenterInfo_33 
    A: ZeroOrMore PresenterInfo as PresenterInfo (site: A, no Relation, prop ID=138)
    B: ZeroOrOne Assembly as PresenterAssembly (site: B, no Relation, prop ID=138)
    Preferred Storage: MergeA
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly PresenterAssembly
        {
            get
            {
                return PresenterAssembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                PresenterAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int fk_PresenterAssembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && PresenterAssembly != null)
                {
                    _fk_PresenterAssembly = PresenterAssembly.ID;
                }
                return _fk_PresenterAssembly;
            }
            set
            {
                _fk_PresenterAssembly = value;
            }
        }
        private int _fk_PresenterAssembly;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_PresenterInfo_Assembly_PresenterInfo_33", "PresenterAssembly")]
        public Kistl.App.Base.Assembly__Implementation__ PresenterAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_PresenterInfo_Assembly_PresenterInfo_33",
                        "PresenterAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_PresenterInfo_Assembly_PresenterInfo_33",
                        "PresenterAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// The CLR namespace and class name of the Presenter
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string PresenterTypeName
        {
            get
            {
                return _PresenterTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_PresenterTypeName != value)
                {
                    NotifyPropertyChanging("PresenterTypeName");
                    _PresenterTypeName = value;
                    NotifyPropertyChanged("PresenterTypeName");;
                }
            }
        }
        private string _PresenterTypeName;

        /// <summary>
        /// The Assembly of the Data Type
        /// </summary>
    /*
    NewRelation: FK_PresenterInfo_Assembly_PresenterInfo_34 
    A: ZeroOrMore PresenterInfo as PresenterInfo (site: A, no Relation, prop ID=147)
    B: ZeroOrOne Assembly as DataAssembly (site: B, no Relation, prop ID=147)
    Preferred Storage: MergeA
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly DataAssembly
        {
            get
            {
                return DataAssembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                DataAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int fk_DataAssembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && DataAssembly != null)
                {
                    _fk_DataAssembly = DataAssembly.ID;
                }
                return _fk_DataAssembly;
            }
            set
            {
                _fk_DataAssembly = value;
            }
        }
        private int _fk_DataAssembly;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_PresenterInfo_Assembly_PresenterInfo_34", "DataAssembly")]
        public Kistl.App.Base.Assembly__Implementation__ DataAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_PresenterInfo_Assembly_PresenterInfo_34",
                        "DataAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_PresenterInfo_Assembly_PresenterInfo_34",
                        "DataAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// The CLR namespace and class name of the Data Type
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string DataTypeName
        {
            get
            {
                return _DataTypeName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_DataTypeName != value)
                {
                    NotifyPropertyChanging("DataTypeName");
                    _DataTypeName = value;
                    NotifyPropertyChanged("DataTypeName");;
                }
            }
        }
        private string _DataTypeName;

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PresenterInfo != null)
            {
                OnToString_PresenterInfo(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<PresenterInfo> OnToString_PresenterInfo;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PresenterInfo != null) OnPreSave_PresenterInfo(this);
        }
        public event ObjectEventHandler<PresenterInfo> OnPreSave_PresenterInfo;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PresenterInfo != null) OnPostSave_PresenterInfo(this);
        }
        public event ObjectEventHandler<PresenterInfo> OnPostSave_PresenterInfo;




#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
            BinarySerializer.ToStream((int)this.ControlType, binStream);
            BinarySerializer.ToStream(this._fk_PresenterAssembly, binStream);
            BinarySerializer.ToStream(this._PresenterTypeName, binStream);
            BinarySerializer.ToStream(this._fk_DataAssembly, binStream);
            BinarySerializer.ToStream(this._DataTypeName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
            BinarySerializer.FromStreamConverter(v => this.ControlType = (Kistl.App.GUI.VisualType)v, binStream);
            BinarySerializer.FromStream(out this._fk_PresenterAssembly, binStream);
            BinarySerializer.FromStream(out this._PresenterTypeName, binStream);
            BinarySerializer.FromStream(out this._fk_DataAssembly, binStream);
            BinarySerializer.FromStream(out this._DataTypeName, binStream);
        }

#endregion

    }


}