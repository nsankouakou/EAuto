using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbrembourssement
    {
        public decimal Idrembours { get; set; }
        public string Librembours { get; set; }
        public decimal Idfact { get; set; }
        public decimal Idmodrglmt { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbfacture IdfactNavigation { get; set; }
        public virtual TbmodeReglement IdmodrglmtNavigation { get; set; }
    }
}
