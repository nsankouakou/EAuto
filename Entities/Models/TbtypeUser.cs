using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeUser
    {
        public TbtypeUser()
        {
            Tbuser = new HashSet<Tbuser>();
        }

        public decimal IdTypeUser { get; set; }
        public string LibTypeUser { get; set; }
        public decimal? NbreUser { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbuser> Tbuser { get; set; }
    }
}
