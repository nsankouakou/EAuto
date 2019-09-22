using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrubriqueHonoraire
    {
        public TbrubriqueHonoraire()
        {
            TbdossierRubriqueHonoraire = new HashSet<TbdossierRubriqueHonoraire>();
        }

        public decimal Idrubhonr { get; set; }
        public string Librubhonor { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbdossierRubriqueHonoraire> TbdossierRubriqueHonoraire { get; set; }
    }
}
