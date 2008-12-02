//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Client;
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Projekte.Projekt")]
    public class Projekt__Implementation__ : BaseClientDataObject, Projekt
    {
        
        private string _Name;
        
        private BackReferenceCollection<Kistl.App.Projekte.Task> _Tasks;
        
        private ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt, Projekt_MitarbeiterCollectionEntry__Implementation__> _Mitarbeiter;
        
        private System.Double? _AufwandGes;
        
        private string _Kundenname;
        
        private BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger> _Kostentraeger;
        
        private BackReferenceCollection<Kistl.App.Projekte.Auftrag> _Auftraege;
        
        public Projekt__Implementation__()
        {
            _Mitarbeiter = new ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt, Projekt_MitarbeiterCollectionEntry__Implementation__>(this, "Mitarbeiter");
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Name != value)
                {
                    NotifyPropertyChanging("Name"); 
                    _Name = value;
                    NotifyPropertyChanged("Name");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if (_Tasks == null)
                {
                    List<Kistl.App.Projekte.Task> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Task>(this, "Tasks");
                    else
                        serverList = new List<Kistl.App.Projekte.Task>();

                    _Tasks = new BackReferenceCollection<Kistl.App.Projekte.Task>(
                         "Projekt", this, serverList);
                }
                return _Tasks;
            }
        }
        
        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                return _Mitarbeiter;
            }
        }
        
        public System.Double? AufwandGes
        {
            get
            {
                return _AufwandGes;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (AufwandGes != value)
                {
                    NotifyPropertyChanging("AufwandGes"); 
                    _AufwandGes = value;
                    NotifyPropertyChanged("AufwandGes");;
                }
            }
        }
        
        public string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Kundenname != value)
                {
                    NotifyPropertyChanging("Kundenname"); 
                    _Kundenname = value;
                    NotifyPropertyChanged("Kundenname");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger
        {
            get
            {
                if (_Kostentraeger == null)
                {
                    List<Kistl.App.Zeiterfassung.Kostentraeger> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Zeiterfassung.Kostentraeger>(this, "Kostentraeger");
                    else
                        serverList = new List<Kistl.App.Zeiterfassung.Kostentraeger>();

                    _Kostentraeger = new BackReferenceCollection<Kistl.App.Zeiterfassung.Kostentraeger>(
                         "Projekt", this, serverList);
                }
                return _Kostentraeger;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if (_Auftraege == null)
                {
                    List<Kistl.App.Projekte.Auftrag> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Auftrag>(this, "Auftraege");
                    else
                        serverList = new List<Kistl.App.Projekte.Auftrag>();

                    _Auftraege = new BackReferenceCollection<Kistl.App.Projekte.Auftrag>(
                         "Projekt", this, serverList);
                }
                return _Auftraege;
            }
        }
        
        public event ToStringHandler<Projekt> OnToString_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPreSave_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPostSave_Projekt;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Projekt != null)
            {
                OnToString_Projekt(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Projekt != null) OnPreSave_Projekt(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Projekt != null) OnPostSave_Projekt(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Projekt__Implementation__)obj).Name = this.Name;
            if(this._Tasks != null) this._Tasks.ApplyChanges(((Projekt__Implementation__)obj)._Tasks); else ((Projekt__Implementation__)obj)._Tasks = null; ((Projekt__Implementation__)obj).NotifyPropertyChanged("Tasks");
            this._Mitarbeiter.ApplyChanges(((Projekt__Implementation__)obj)._Mitarbeiter);
            ((Projekt__Implementation__)obj).AufwandGes = this.AufwandGes;
            ((Projekt__Implementation__)obj).Kundenname = this.Kundenname;
            if(this._Kostentraeger != null) this._Kostentraeger.ApplyChanges(((Projekt__Implementation__)obj)._Kostentraeger); else ((Projekt__Implementation__)obj)._Kostentraeger = null; ((Projekt__Implementation__)obj).NotifyPropertyChanged("Kostentraeger");
            if(this._Auftraege != null) this._Auftraege.ApplyChanges(((Projekt__Implementation__)obj)._Auftraege); else ((Projekt__Implementation__)obj)._Auftraege = null; ((Projekt__Implementation__)obj).NotifyPropertyChanged("Auftraege");
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_Tasks != null) _Tasks.AttachToContext(ctx);
            if(_Mitarbeiter != null) _Mitarbeiter.AttachToContext(ctx);
            if(_Kostentraeger != null) _Kostentraeger.AttachToContext(ctx);
            if(_Auftraege != null) _Auftraege.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Name":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(13).Constraints
                            .Where(c => !c.IsValid(this, this.Name))
                            .Select(c => c.GetErrorText(this, this.Name))
                            .ToArray());
                case "Tasks":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(14).Constraints
                            .Where(c => !c.IsValid(this, this.Tasks))
                            .Select(c => c.GetErrorText(this, this.Tasks))
                            .ToArray());
                case "Mitarbeiter":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(22).Constraints
                            .Where(c => !c.IsValid(this, this.Mitarbeiter))
                            .Select(c => c.GetErrorText(this, this.Mitarbeiter))
                            .ToArray());
                case "AufwandGes":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(23).Constraints
                            .Where(c => !c.IsValid(this, this.AufwandGes))
                            .Select(c => c.GetErrorText(this, this.AufwandGes))
                            .ToArray());
                case "Kundenname":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(48).Constraints
                            .Where(c => !c.IsValid(this, this.Kundenname))
                            .Select(c => c.GetErrorText(this, this.Kundenname))
                            .ToArray());
                case "Kostentraeger":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(66).Constraints
                            .Where(c => !c.IsValid(this, this.Kostentraeger))
                            .Select(c => c.GetErrorText(this, this.Kostentraeger))
                            .ToArray());
                case "Auftraege":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(67).Constraints
                            .Where(c => !c.IsValid(this, this.Auftraege))
                            .Select(c => c.GetErrorText(this, this.Auftraege))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Name, sw);
            this._Mitarbeiter.ToStream(sw);
            BinarySerializer.ToBinary(this._AufwandGes, sw);
            BinarySerializer.ToBinary(this._Kundenname, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            this._Mitarbeiter.FromStream(sr);
            BinarySerializer.FromBinary(out this._AufwandGes, sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
        }
    }
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry")]
    public class Projekt_MitarbeiterCollectionEntry__Implementation__ : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntrySorted<Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt>
    {
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        private System.Nullable<int> _ValueIndex;
        
        private System.Nullable<int> _ParentIndex;
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter Value
        {
            get
            {
                return Context != null && fk_Value != Kistl.API.Helper.INVALIDID ? Context.GetQuery<Kistl.App.Projekte.Mitarbeiter>().Single(o => o.ID == fk_Value) : null;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (Context != null && fk_Value != value.ID && fk_Value != Kistl.API.Helper.INVALIDID) Value.Projekte.Remove(Parent);
                    fk_Value = value.ID;
                    if (Context != null && !value.Projekte.Contains(Parent)) value.Projekte.Add(Parent);
                }
                else
                {
                    if (Context != null && Value != null && Value.Projekte.Contains(Parent)) Value.Projekte.Remove(Parent);
                    fk_Value = Kistl.API.Helper.INVALIDID;
                };
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Projekt Parent
        {
            get
            {
                return Context != null && fk_Parent != Kistl.API.Helper.INVALIDID ? Context.GetQuery<Projekt>().Single(o => o.ID == fk_Parent) : null;
            }
            set
            {
                _fk_Parent = value.ID;
            }
        }
        
        public int fk_Value
        {
            get
            {
                return _fk_Value;
            }
            set
            {
                if(_fk_Value != value)
                {
                    base.NotifyPropertyChanging("Value");
                    _fk_Value = value;
                    base.NotifyPropertyChanged("Value");
                };
            }
        }
        
        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }
        
        public System.Nullable<int> ValueIndex
        {
            get
            {
                return _ValueIndex;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ValueIndex != value)
                {
                    NotifyPropertyChanging("ValueIndex"); 
                    _ValueIndex = value;
                    NotifyPropertyChanged("ValueIndex");;
                }
            }
        }
        
        public System.Nullable<int> ParentIndex
        {
            get
            {
                return _ParentIndex;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ParentIndex != value)
                {
                    NotifyPropertyChanging("ParentIndex"); 
                    _ParentIndex = value;
                    NotifyPropertyChanged("ParentIndex");;
                }
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
            BinarySerializer.ToBinary(this.ValueIndex, sw);
            BinarySerializer.ToBinary(this.ParentIndex, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
            BinarySerializer.FromBinary(out this._ValueIndex, sr);
            BinarySerializer.FromBinary(out this._ParentIndex, sr);
        }
        
        public override void ApplyChanges(Kistl.API.ICollectionEntry obj)
        {
            base.ApplyChanges(obj);
            ((Projekt_MitarbeiterCollectionEntry__Implementation__)obj)._fk_Value = this.fk_Value;
            ((Projekt_MitarbeiterCollectionEntry__Implementation__)obj)._fk_Parent = this.fk_Parent;
        }
    }
}
