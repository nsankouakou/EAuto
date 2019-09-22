using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeNote
    {
        public TbtypeNote()
        {
            Tbexpertise = new HashSet<Tbexpertise>();
            TbexpertiseTypeNote = new HashSet<TbexpertiseTypeNote>();
            Tbnote = new HashSet<Tbnote>();
        }

        public decimal Idtypnote { get; set; }
        public string Libtypnote { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbexpertise> Tbexpertise { get; set; }
        public virtual ICollection<TbexpertiseTypeNote> TbexpertiseTypeNote { get; set; }
        public virtual ICollection<Tbnote> Tbnote { get; set; }
    }
}
