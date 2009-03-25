
namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface Kunde : IDataObject 
    {

        /// <summary>
        /// Adresse & Hausnummer
        /// </summary>
		string Adresse {
			get;
			set;
		}
        /// <summary>
        /// EMails des Kunden - können mehrere sein
        /// </summary>

        ICollection<System.String> EMails { get; }
        /// <summary>
        /// Name des Kunden
        /// </summary>
		string Kundenname {
			get;
			set;
		}
        /// <summary>
        /// Land
        /// </summary>
		string Land {
			get;
			set;
		}
        /// <summary>
        /// Ort
        /// </summary>
		string Ort {
			get;
			set;
		}
        /// <summary>
        /// Postleitzahl
        /// </summary>
		string PLZ {
			get;
			set;
		}
    }
}