using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbassurance
    {
        public Tbassurance()
        {
            TbvehiculeAssurance = new HashSet<TbvehiculeAssurance>();
        }

        public decimal IdAssur { get; set; }
        public string NomAssur { get; set; }
        public string TelAssur { get; set; }
        public string AdrAssur { get; set; }
        public string BpAssur { get; set; }
        public string MailAssur { get; set; }
        public string FaxAssur { get; set; }
        public string Contact { get; set; }
        public string SiglAssur { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbvehiculeAssurance> TbvehiculeAssurance { get; set; }
    }
}
