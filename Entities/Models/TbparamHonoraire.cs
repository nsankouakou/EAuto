using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbparamHonoraire
    {
        public decimal IdParam { get; set; }
        public decimal MtInferPrej { get; set; }
        public decimal MtSupPrej { get; set; }
        public decimal MtHonoraire { get; set; }
        public string CoefExced { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }
    }
}
