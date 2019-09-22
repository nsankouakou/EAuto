using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbexpertiseFourniturePointChoc
    {
        public decimal Idexpert { get; set; }
        public decimal Idpointchoc { get; set; }
        public decimal Idfourn { get; set; }
        public string DepRep { get; set; }
        public string Reparer { get; set; }
        public string Remp { get; set; }
        public string Peint { get; set; }
        public decimal? Pu { get; set; }
        public decimal? Vetuste { get; set; }
        public decimal Mtht { get; set; }
        public decimal MtTtc { get; set; }
        public decimal? Rem { get; set; }
        public decimal? MtTotHt { get; set; }
        public decimal? MtTotTtc { get; set; }
        public decimal? Ligne { get; set; }
        public string Vneuve { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
        public virtual Tbfourniture IdfournNavigation { get; set; }
        public virtual TbpointChoc IdpointchocNavigation { get; set; }
    }
}
