using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbtva
    {
        public Tbtva()
        {
            Tbdossier = new HashSet<Tbdossier>();
        }

        public decimal IdTva { get; set; }
        public DateTime DateTva { get; set; }
        public string TxTva { get; set; }
        public int EtatTva { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbdossier> Tbdossier { get; set; }
    }
}
