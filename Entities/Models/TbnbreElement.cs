using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbnbreElement
    {
        public TbnbreElement()
        {
            TbnbreElementMainOeuvreTypePeinture = new HashSet<TbnbreElementMainOeuvreTypePeinture>();
            TbtypPeintureTarifActifTarifHonoraireNbreElemnt = new HashSet<TbtypPeintureTarifActifTarifHonoraireNbreElemnt>();
        }

        public decimal Idnbelmt { get; set; }
        public string Libnbelmt { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbnbreElementMainOeuvreTypePeinture> TbnbreElementMainOeuvreTypePeinture { get; set; }
        public virtual ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }
    }
}
