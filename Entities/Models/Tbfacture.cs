using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbfacture
    {
        public Tbfacture()
        {
            Tbreglement = new HashSet<Tbreglement>();
            Tbrembourssement = new HashSet<Tbrembourssement>();
        }

        public decimal IdFact { get; set; }
        public string NumFact { get; set; }
        public DateTime DatFact { get; set; }
        public decimal MtFact { get; set; }
        public decimal MtFactTtc { get; set; }
        public decimal MtTva { get; set; }
        public decimal IdDoss { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual ICollection<Tbreglement> Tbreglement { get; set; }
        public virtual ICollection<Tbrembourssement> Tbrembourssement { get; set; }
    }
}
