using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtarifActif
    {
        public TbtarifActif()
        {
            TbtypPeintureTarifActifTarifHonoraireNbreElemnt = new HashSet<TbtypPeintureTarifActifTarifHonoraireNbreElemnt>();
        }

        public decimal IdTarifAct { get; set; }
        public string LibAct { get; set; }
        public decimal MtTarifAct { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }
    }
}
