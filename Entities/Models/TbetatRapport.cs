using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbetatRapport
    {
        public TbetatRapport()
        {
            TbdossierEtatRapport = new HashSet<TbdossierEtatRapport>();
            TbexpertiseEtatRapport = new HashSet<TbexpertiseEtatRapport>();
        }

        public decimal IdEtaRaport { get; set; }
        public string LibEtaRaport { get; set; }
        public decimal? Nbre { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbdossierEtatRapport> TbdossierEtatRapport { get; set; }
        public virtual ICollection<TbexpertiseEtatRapport> TbexpertiseEtatRapport { get; set; }
    }
}
