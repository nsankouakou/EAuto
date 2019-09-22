using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbfourniture
    {
        public Tbfourniture()
        {
            TbexpertiseFourniturePointChoc = new HashSet<TbexpertiseFourniturePointChoc>();
        }

        public decimal IdFourn { get; set; }
        public string LibFourn { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }
    }
}
