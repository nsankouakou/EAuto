using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbmarque
    {
        public Tbmarque()
        {
            TbmarqueCarrosserie = new HashSet<TbmarqueCarrosserie>();
            Tbmodele = new HashSet<Tbmodele>();
            TbtarifHoraireGarageMarque = new HashSet<TbtarifHoraireGarageMarque>();
        }

        public decimal IdMarque { get; set; }
        public string LibMarque { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbmarqueCarrosserie> TbmarqueCarrosserie { get; set; }
        public virtual ICollection<Tbmodele> Tbmodele { get; set; }
        public virtual ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }
    }
}
