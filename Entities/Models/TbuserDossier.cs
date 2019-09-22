using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbuserDossier
    {
        public decimal Iddoss { get; set; }
        public decimal Iduser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IddossNavigation { get; set; }
        public virtual Tbuser IduserNavigation { get; set; }
    }
}
