using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseRubriqueMo
    {
        public decimal Idexpert { get; set; }
        public decimal IdrubriqMo { get; set; }
        public string Constat { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
        public virtual TbrubriqueMainOeuvre IdrubriqMoNavigation { get; set; }
    }
}
