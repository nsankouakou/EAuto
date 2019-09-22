using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypGarage
    {
        public decimal IdTyGara { get; set; }
        public string LibTypGara { get; set; }
        public decimal IdTarifHor { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbtarifHoraire IdTarifHorNavigation { get; set; }
    }
}
