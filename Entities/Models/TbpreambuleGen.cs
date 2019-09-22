using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbpreambuleGen
    {
        public decimal Idpream { get; set; }
        public string Libpream { get; set; }
        public decimal Iddoss { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IddossNavigation { get; set; }
    }
}
