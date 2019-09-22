using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbdossierRubriqueHonoraire
    {
        public decimal Idrubhonr { get; set; }
        public decimal IdDoss { get; set; }
        public decimal MtRubHono { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual TbrubriqueHonoraire IdrubhonrNavigation { get; set; }
    }
}
