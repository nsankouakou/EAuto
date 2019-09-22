using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertisePourRecousPointChoc
    {
        public decimal IdRecours { get; set; }
        public decimal IdExpert { get; set; }
        public decimal IdPointChoc { get; set; }
        public decimal MontRecous { get; set; }
        public string LibRecours { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdExpertNavigation { get; set; }
        public virtual TbpointChoc IdPointChocNavigation { get; set; }
        public virtual TbpourRecours IdRecoursNavigation { get; set; }
    }
}
