using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Kistl.API.Client;
using Kistl.API;

namespace Kistl.App.Projekte
{
    public class Projekt__Implementation__ : Kistl.API.Client.Mocks.BaseClientDataObjectMock__Implementation__, Kistl.App.Projekte.Projekt
    {
        #region Projekt Members

        /// <summary>
        /// Aufträge
        /// </summary>
        // object list property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if (_AuftraegeWrapper == null)
                {
                    _AuftraegeWrapper = new OneNRelationList<Kistl.App.Projekte.Auftrag>(
                        "Projekt",
                        "Projekt_pos",
                        this,
                        () => NotifyPropertyChanged("Auftraege", null, null),
                        new List<Kistl.App.Projekte.Auftrag>());
                }
                return _AuftraegeWrapper;
            }
        }

        private OneNRelationList<Kistl.App.Projekte.Auftrag> _AuftraegeWrapper;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        public virtual double? AufwandGes
        {
            get
            {
                return _AufwandGes;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_AufwandGes != value)
                {
                    NotifyPropertyChanging("AufwandGes", null, null);
                    _AufwandGes = value;
                    NotifyPropertyChanged("AufwandGes", null, null);
                }
            }
        }
        private double? _AufwandGes;

        /// <summary>
        /// Bitte geben Sie den Kundennamen ein
        /// </summary>
        // value type property
        public virtual string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Kundenname != value)
                {
                    NotifyPropertyChanging("Kundenname", null, null);
                    _Kundenname = value;
                    NotifyPropertyChanged("Kundenname", null, null);
                }
            }
        }
        private string _Kundenname;

        /// <summary>
        /// 
        /// </summary>
        // collection reference property

        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                if (_Mitarbeiter == null)
                {
                    Context.FetchRelation<Projekt_haben_Mitarbeiter_RelationEntry__Implementation__>(Guid.Empty, RelationEndRole.A, this);
                    _Mitarbeiter
                        = new ClientRelationBSideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Projekt_haben_Mitarbeiter_RelationEntry__Implementation__>(
                            this,
                            new RelationshipFilterASideCollection<Projekt_haben_Mitarbeiter_RelationEntry__Implementation__>(this.Context, this));
                }
                return _Mitarbeiter;
            }
        }

        private ClientRelationBSideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Projekt_haben_Mitarbeiter_RelationEntry__Implementation__> _Mitarbeiter;

        /// <summary>
        /// Projektname
        /// </summary>
        // value type property
        public virtual string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    NotifyPropertyChanging("Name", null, null);
                    _Name = value;
                    NotifyPropertyChanged("Name", null, null);
                }
            }
        }
        private string _Name;

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if (_TasksWrapper == null)
                {
                    List<Kistl.App.Projekte.Task> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Projekte.Task>(this, "Tasks");
                    else
                        serverList = new List<Kistl.App.Projekte.Task>();

                    _TasksWrapper = new OneNRelationList<Kistl.App.Projekte.Task>(
                        "Projekt",
                        "Projekt_pos",
                        this,
                        () => NotifyPropertyChanged("Tasks", null, null),
                        serverList);
                }
                return _TasksWrapper;
            }
        }

        private OneNRelationList<Kistl.App.Projekte.Task> _TasksWrapper;

        #endregion

        #region IChangedBy Members

        public Kistl.App.Base.Identity ChangedBy
        {
            get;
            set;
        }

        public DateTime? ChangedOn
        {
            get;
            set;
        }

        public Kistl.App.Base.Identity CreatedBy
        {
            get;
            set;
        }

        public DateTime? CreatedOn
        {
            get;
            set;
        }

        #endregion

        public override InterfaceType GetInterfaceType()
        {
            return new InterfaceType(typeof(Kistl.App.Projekte.Projekt));
        }
    }
}
