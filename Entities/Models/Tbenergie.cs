using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbenergie
    {
        public Tbenergie()
        {
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal IdEnergie { get; set; }
        public string LibEnergie { get; set; }
        public string IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
