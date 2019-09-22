using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbproprietaire
    {
        public Tbproprietaire()
        {
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal IdProprio { get; set; }
        public string NomProprio { get; set; }
        public string PrenProPrio { get; set; }
        public string TelProprio { get; set; }
        public string AdrProprio { get; set; }
        public string BpProprio { get; set; }
        public string MailProrio { get; set; }
        public string FaxProprio { get; set; }
        public DateTime DatEnreg { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
