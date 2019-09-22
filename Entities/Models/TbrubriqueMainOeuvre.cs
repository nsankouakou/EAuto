using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrubriqueMainOeuvre
    {
        public TbrubriqueMainOeuvre()
        {
            TbexpertiseRubriqueMo = new HashSet<TbexpertiseRubriqueMo>();
        }

        public decimal IdrubriqMo { get; set; }
        public string LibrubriqMo { get; set; }
        public decimal? Nbre { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbexpertiseRubriqueMo> TbexpertiseRubriqueMo { get; set; }
    }
}
