using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbnbreElementMainOeuvreTypePeinture
    {
        public decimal Idnbelmt { get; set; }
        public decimal IdMo { get; set; }
        public decimal Idtyppeint { get; set; }
        public decimal? Tpeint { get; set; }
        public decimal Coef { get; set; }
        public decimal Conste { get; set; }
        public string MtPeint { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbmainOeuvre IdMoNavigation { get; set; }
        public virtual TbnbreElement IdnbelmtNavigation { get; set; }
        public virtual TbtypePeinture IdtyppeintNavigation { get; set; }
    }
}
