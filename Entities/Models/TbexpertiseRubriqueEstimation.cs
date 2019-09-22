using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseRubriqueEstimation
    {
        public decimal IdExpert { get; set; }
        public decimal IdRubEstim { get; set; }
        public string Estimation { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdExpertNavigation { get; set; }
        public virtual TbrubriqueEstimation IdRubEstimNavigation { get; set; }
    }
}
