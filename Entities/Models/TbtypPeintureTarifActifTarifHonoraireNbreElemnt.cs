using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypPeintureTarifActifTarifHonoraireNbreElemnt
    {
        public decimal IdTarif { get; set; }
        public decimal IdTypPeint { get; set; }
        public decimal IdTarifAct { get; set; }
        public decimal Coef { get; set; }
        public decimal Const { get; set; }
        public decimal Mtprodpeint { get; set; }
        public decimal Idnbelmt { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbtarifActif IdTarifActNavigation { get; set; }
        public virtual TbtarifHoraire IdTarifNavigation { get; set; }
        public virtual TbtypePeinture IdTypPeintNavigation { get; set; }
        public virtual TbnbreElement IdnbelmtNavigation { get; set; }
    }
}
