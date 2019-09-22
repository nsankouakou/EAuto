using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbautreRubrique
    {
        public decimal IdAutreRub { get; set; }
        public string LibAutreRub { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }
    }
}
