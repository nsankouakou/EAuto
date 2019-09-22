using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbgenre
    {
        public Tbgenre()
        {
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal IdGenre { get; set; }
        public string LibGenre { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
