using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrubriqueEstimation
    {
        public TbrubriqueEstimation()
        {
            TbexpertiseRubriqueEstimation = new HashSet<TbexpertiseRubriqueEstimation>();
        }

        public decimal IdRubEstim { get; set; }
        public string LibRubEstim { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseRubriqueEstimation> TbexpertiseRubriqueEstimation { get; set; }
    }
}
