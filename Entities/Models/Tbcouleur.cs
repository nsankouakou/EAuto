using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbcouleur
    {
        public Tbcouleur()
        {
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal IdCouleur { get; set; }
        public string LibCouleur { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
