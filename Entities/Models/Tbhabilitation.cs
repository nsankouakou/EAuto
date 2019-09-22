using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbhabilitation
    {
        public decimal MenuId { get; set; }
        public decimal ProfilId { get; set; }
        public int Droit { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbmenu Menu { get; set; }
        public virtual Tbprofil Profil { get; set; }
    }
}
