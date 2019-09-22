using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbnote
    {
        public decimal IdNot { get; set; }
        public string LibelleNot { get; set; }
        public decimal Idtypnote { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbtypeNote IdtypnoteNavigation { get; set; }
    }
}
