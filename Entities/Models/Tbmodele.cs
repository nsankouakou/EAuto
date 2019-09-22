using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbmodele
    {
        public Tbmodele()
        {
            TbtypeVehicule = new HashSet<TbtypeVehicule>();
        }

        public decimal Idmodel { get; set; }
        public string Libmodel { get; set; }
        public decimal Idmarq { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbmarque IdmarqNavigation { get; set; }
        public virtual ICollection<TbtypeVehicule> TbtypeVehicule { get; set; }
    }
}
