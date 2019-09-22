using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbmainOeuvrePointChoc
    {
        public decimal Idpointchoc { get; set; }
        public decimal IdMo { get; set; }
        public DateTime Datetrav { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbmainOeuvre IdMoNavigation { get; set; }
        public virtual TbpointChoc IdpointchocNavigation { get; set; }
    }
}
