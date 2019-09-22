using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrubriqueEvaluation
    {
        public TbrubriqueEvaluation()
        {
            TbrubriqueEvalExpertise = new HashSet<TbrubriqueEvalExpertise>();
        }

        public decimal IdRubEval { get; set; }
        public string LibRubEval { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbrubriqueEvalExpertise> TbrubriqueEvalExpertise { get; set; }
    }
}
