using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseDepannagePointChoc
    {
        public decimal IdExpert { get; set; }
        public decimal IdPointChoc { get; set; }
        public decimal IdDepann { get; set; }
        public decimal Montant { get; set; }
        public string LibelleDepann { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdExpertNavigation { get; set; }
    }
}
