using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtravauxExterieur
    {
        public TbtravauxExterieur()
        {
            TbexpertiseTravauxExterieurPointChoc = new HashSet<TbexpertiseTravauxExterieurPointChoc>();
        }

        public decimal Idautrecharg { get; set; }
        public string Libautrecharg { get; set; }
        public decimal? NbAutres { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }
    }
}
