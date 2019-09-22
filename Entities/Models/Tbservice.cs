using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbservice
    {
        public Tbservice()
        {
            Tbspecialite = new HashSet<Tbspecialite>();
        }

        public decimal IdServ { get; set; }
        public string LibServ { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbspecialite> Tbspecialite { get; set; }
    }
}
