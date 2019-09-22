using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbpourRecours
    {
        public TbpourRecours()
        {
            TbexpertisePourRecousPointChoc = new HashSet<TbexpertisePourRecousPointChoc>();
        }

        public decimal IdRecours { get; set; }
        public string LibRecours { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }
    }
}
