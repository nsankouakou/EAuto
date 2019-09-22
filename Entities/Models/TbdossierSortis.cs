using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbdossierSortis
    {
        public decimal IdSorti { get; set; }
        public DateTime DatSorti { get; set; }
        public string Rubrique { get; set; }
        public string Mt { get; set; }
        public string Total { get; set; }
        public decimal IdDoss { get; set; }
        public string IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IdDossNavigation { get; set; }
    }
}
