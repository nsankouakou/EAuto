using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseEtatRapport
    {
        public decimal IdExpert { get; set; }
        public decimal IdEtaRaport { get; set; }
        public DateTime DatEtat { get; set; }
        public DateTime HeurEtat { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbetatRapport IdEtaRaportNavigation { get; set; }
        public virtual Tbexpertise IdExpertNavigation { get; set; }
    }
}
