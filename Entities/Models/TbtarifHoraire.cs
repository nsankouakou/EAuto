using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtarifHoraire
    {
        public TbtarifHoraire()
        {
            TbtarifHoraireGarageMarque = new HashSet<TbtarifHoraireGarageMarque>();
            TbtypGarage = new HashSet<TbtypGarage>();
            TbtypPeintureTarifActifTarifHonoraireNbreElemnt = new HashSet<TbtypPeintureTarifActifTarifHonoraireNbreElemnt>();
        }

        public decimal IdTarifHor { get; set; }
        public decimal MtTarifHor { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }
        public virtual ICollection<TbtypGarage> TbtypGarage { get; set; }
        public virtual ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }
    }
}
