using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbconclusion
    {
        public decimal Idconclus { get; set; }
        public string Libconclus { get; set; }
        public decimal IdExpert { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdExpertNavigation { get; set; }
    }
}
