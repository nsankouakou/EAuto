using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbgarage
    {
        public Tbgarage()
        {
            Tbexpertise = new HashSet<Tbexpertise>();
            TbtarifHoraireGarageMarque = new HashSet<TbtarifHoraireGarageMarque>();
        }

        public decimal IdGara { get; set; }
        public string RaisonSociale { get; set; }
        public string TelGar { get; set; }
        public string AdrGar { get; set; }
        public string MailGar { get; set; }
        public string Sigle { get; set; }
        public string FaxGar { get; set; }
        public string Contact { get; set; }
        public bool Pme { get; set; }
        public string BpGar { get; set; }
        public decimal? IdUser { get; set; }
        public decimal? IdTyGara { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbexpertise> Tbexpertise { get; set; }
        public virtual ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }
    }
}
