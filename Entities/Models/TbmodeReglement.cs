using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbmodeReglement
    {
        public TbmodeReglement()
        {
            Tbavance = new HashSet<Tbavance>();
            Tbreglement = new HashSet<Tbreglement>();
            Tbrembourssement = new HashSet<Tbrembourssement>();
        }

        public decimal IdModeReglmnt { get; set; }
        public string LibModReglmnt { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbavance> Tbavance { get; set; }
        public virtual ICollection<Tbreglement> Tbreglement { get; set; }
        public virtual ICollection<Tbrembourssement> Tbrembourssement { get; set; }
    }
}
