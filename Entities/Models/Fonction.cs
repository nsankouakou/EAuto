using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Fonction
    {
        public Fonction()
        {
            Tbagent = new HashSet<Tbagent>();
        }

        public decimal Fonctionid { get; set; }
        public string Code { get; set; }
        public string Fonctionlibelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbagent> Tbagent { get; set; }
    }
}
