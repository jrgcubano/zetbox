//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "A_Mitarbeiter", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Mitarbeiter__Implementation__), "B_Projekt_MitarbeiterCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "A_Projekt", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Projekt__Implementation__), "B_Projekt_MitarbeiterCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry__Implementation__))]

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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.DALProvider.EF;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Projekt")]
    public class Projekt__Implementation__ : BaseServerDataObject_EntityFramework, Projekt
    {
        
        private int _ID;
        
        private string _Name;
        
        private EntityCollectionWrapper<Kistl.App.Projekte.Task, Kistl.App.Projekte.Task__Implementation__> TasksWrapper;
        
        private EntityCollectionEntryValueWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry__Implementation__> MitarbeiterWrapper;
        
        private System.Double? _AufwandGes;
        
        private string _Kundenname;
        
        private EntityCollectionWrapper<Kistl.App.Zeiterfassung.Kostentraeger, Kistl.App.Zeiterfassung.Kostentraeger__Implementation__> KostentraegerWrapper;
        
        private EntityCollectionWrapper<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Auftrag__Implementation__> AuftraegeWrapper;
        
        public Projekt__Implementation__()
        {
        }
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
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
        public ICollection<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if (TasksWrapper == null) TasksWrapper = new EntityCollectionWrapper<Kistl.App.Projekte.Task, Kistl.App.Projekte.Task__Implementation__>(Tasks__Implementation__);
                return TasksWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Task_Projekt_Projekt", "B_Task")]
        public EntityCollection<Kistl.App.Projekte.Task__Implementation__> Tasks__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Projekte.Task__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Projekte.Task__Implementation__>("Model.FK_Task_Projekt_Projekt", "B_Task");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                if (MitarbeiterWrapper == null) MitarbeiterWrapper = new EntityCollectionEntryValueWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry__Implementation__>(this, Mitarbeiter__Implementation__);
                return MitarbeiterWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "B_Projekt_MitarbeiterCollectionEntry")]
        public EntityCollection<Kistl.App.Projekte.Projekt_MitarbeiterCollectionEntry__Implementation__> Mitarbeiter__Implementation__
        {
            get
            {
                EntityCollection<Projekt_MitarbeiterCollectionEntry__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Projekt_MitarbeiterCollectionEntry__Implementation__>("Model.FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "B_Projekt_MitarbeiterCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmScalarPropertyAttribute()]
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
        
        [EdmScalarPropertyAttribute()]
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
        public ICollection<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger
        {
            get
            {
                if (KostentraegerWrapper == null) KostentraegerWrapper = new EntityCollectionWrapper<Kistl.App.Zeiterfassung.Kostentraeger, Kistl.App.Zeiterfassung.Kostentraeger__Implementation__>(Kostentraeger__Implementation__);
                return KostentraegerWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Kostentraeger_Projekt_Projekt", "B_Kostentraeger")]
        public EntityCollection<Kistl.App.Zeiterfassung.Kostentraeger__Implementation__> Kostentraeger__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Zeiterfassung.Kostentraeger__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Zeiterfassung.Kostentraeger__Implementation__>("Model.FK_Kostentraeger_Projekt_Projekt", "B_Kostentraeger");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if (AuftraegeWrapper == null) AuftraegeWrapper = new EntityCollectionWrapper<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Auftrag__Implementation__>(Auftraege__Implementation__);
                return AuftraegeWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Auftrag_Projekt_Projekt", "B_Auftrag")]
        public EntityCollection<Kistl.App.Projekte.Auftrag__Implementation__> Auftraege__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Projekte.Auftrag__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Projekte.Auftrag__Implementation__>("Model.FK_Auftrag_Projekt_Projekt", "B_Auftrag");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            /// Use ToList before using foreach - the collection will change in the KistContext.Attach() Method because EntityFramework will need a Trick to attach CollectionEntries correctly
            Mitarbeiter__Implementation__.ToList().ForEach<ICollectionEntry>(i => ctx.Attach(i));
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
            BinarySerializer.ToBinary(this.Mitarbeiter__Implementation__, sw);
            BinarySerializer.ToBinary(this._AufwandGes, sw);
            BinarySerializer.ToBinary(this._Kundenname, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            BinarySerializer.FromBinaryCollectionEntries(this.Mitarbeiter__Implementation__, sr);
            BinarySerializer.FromBinary(out this._AufwandGes, sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
        }
    }
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Projekt_MitarbeiterCollectionEntry")]
    public class Projekt_MitarbeiterCollectionEntry__Implementation__ : BaseServerCollectionEntry_EntityFramework, ICollectionEntry<Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt>
    {
        
        private int _ID;
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Value
        {
            get
            {
                return ValueImpl;
            }
            set
            {
                ValueImpl = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Parent
        {
            get
            {
                return ParentImpl;
            }
            set
            {
                ParentImpl = (Kistl.App.Projekte.Projekt__Implementation__)value;
            }
        }
        
        public int fk_Value
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Value != null)
                {
                    _fk_Value = Value.ID;
                }
                return _fk_Value;
            }
            set
            {
                _fk_Value = value;
            }
        }
        
        public int fk_Parent
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Parent != null)
                {
                    _fk_Parent = Parent.ID;
                }
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "A_Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter__Implementation__ ValueImpl
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>("Model.FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>("Model.FK_Projekt_MitarbeiterCollectionEntry_Mitarbeiter_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "A_Projekt")]
        public Kistl.App.Projekte.Projekt__Implementation__ ParentImpl
        {
            get
            {
                EntityReference<Projekt__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Projekt__Implementation__>("Model.FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Projekt__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Projekt__Implementation__>("Model.FK_Projekt_MitarbeiterCollectionEntry_Projekt_fk_Parent", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Projekt__Implementation__)value;
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }
    }
}
