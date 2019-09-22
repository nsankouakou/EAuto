using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeVehicule
    {
        public TbtypeVehicule()
        {
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal Idtypveh { get; set; }
        public string Libtypveh { get; set; }
        public decimal Idmodel { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbmodele IdmodelNavigation { get; set; }
        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
