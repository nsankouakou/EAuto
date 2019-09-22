using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseTravauxExterieurPointChoc
    {
        public decimal Idpointchoc { get; set; }
        public decimal Idautrecharg { get; set; }
        public decimal Mtautrecharge { get; set; }
        public decimal? Dep { get; set; }
        public decimal IdExpert { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdExpertNavigation { get; set; }
        public virtual TbtravauxExterieur IdautrechargNavigation { get; set; }
        public virtual TbpointChoc IdpointchocNavigation { get; set; }
    }
}
