using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypTravauxMainOuvre
    {
        public decimal Idtyptrav { get; set; }
        public decimal IdMo { get; set; }
        public string ElemntTravo { get; set; }
        public decimal? Nbheure { get; set; }
        public decimal? MtTravo { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual TbmainOeuvre IdMoNavigation { get; set; }
        public virtual TbtypeTravaux IdtyptravNavigation { get; set; }
    }
}
