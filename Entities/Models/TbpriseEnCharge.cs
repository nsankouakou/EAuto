using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbpriseEnCharge
    {
        public TbpriseEnCharge()
        {
            Tbdossier = new HashSet<Tbdossier>();
        }

        public decimal IdPriseCharg { get; set; }
        public string LibPriseCharg { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbdossier> Tbdossier { get; set; }
    }
}
