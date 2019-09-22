using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbvehiculeAssurance
    {
        public decimal IdAss { get; set; }
        public decimal IdVeh { get; set; }
        public DateTime DatAss { get; set; }
        public string NumPolice { get; set; }
        public decimal Ligne { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbassurance IdAssNavigation { get; set; }
        public virtual Tbvehicule IdVehNavigation { get; set; }
    }
}
