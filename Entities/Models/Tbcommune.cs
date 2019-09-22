using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbcommune
    {
        public Tbcommune()
        {
            Tbdossier = new HashSet<Tbdossier>();
        }

        public decimal IdComm { get; set; }
        public string NomComm { get; set; }
        public decimal Deplacement { get; set; }
        public decimal IdVille { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbville IdVilleNavigation { get; set; }
        public virtual ICollection<Tbdossier> Tbdossier { get; set; }
    }
}
