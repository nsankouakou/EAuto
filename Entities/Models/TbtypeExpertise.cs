using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeExpertise
    {
        public TbtypeExpertise()
        {
            Tbdossier = new HashSet<Tbdossier>();
        }

        public decimal IdTypExpert { get; set; }
        public string LibTypExpert { get; set; }
        public decimal? MtPrejudiceHt { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbdossier> Tbdossier { get; set; }
    }
}
