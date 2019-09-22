using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbdiscussion
    {
        public decimal Iddiscus { get; set; }
        public string Libdiscus { get; set; }
        public decimal Idexpert { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
    }
}
