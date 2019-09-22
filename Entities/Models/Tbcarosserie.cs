using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbcarosserie
    {
        public Tbcarosserie()
        {
            TbmarqueCarrosserie = new HashSet<TbmarqueCarrosserie>();
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal Idcarross { get; set; }
        public string LibCarross { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbmarqueCarrosserie> TbmarqueCarrosserie { get; set; }
        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
