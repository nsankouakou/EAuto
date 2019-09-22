using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbville
    {
        public Tbville()
        {
            Tbcommune = new HashSet<Tbcommune>();
        }

        public decimal IdVille { get; set; }
        public string NomVille { get; set; }
        public decimal Distance { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbcommune> Tbcommune { get; set; }
    }
}
