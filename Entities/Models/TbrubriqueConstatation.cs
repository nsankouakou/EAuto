using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrubriqueConstatation
    {
        public TbrubriqueConstatation()
        {
            TbexpertiseRubriqueConstatationPointChoc = new HashSet<TbexpertiseRubriqueConstatationPointChoc>();
        }

        public decimal IdRubConst { get; set; }
        public string LibRubConst { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }
    }
}
