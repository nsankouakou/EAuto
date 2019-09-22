using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseTypeNote
    {
        public decimal Idexpert { get; set; }
        public decimal Idtypnote { get; set; }
        public string Texte { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
        public virtual TbtypeNote IdtypnoteNavigation { get; set; }
    }
}
