using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtarifHoraireGarageMarque
    {
        public decimal IdGara { get; set; }
        public decimal IdMarque { get; set; }
        public decimal IdTarifHor { get; set; }
        public decimal MtTarif { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbgarage IdGaraNavigation { get; set; }
        public virtual Tbmarque IdMarqueNavigation { get; set; }
        public virtual TbtarifHoraire IdTarifHorNavigation { get; set; }
    }
}
