using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbprofil
    {
        public Tbprofil()
        {
            Tbhabilitation = new HashSet<Tbhabilitation>();
            Tbuser = new HashSet<Tbuser>();
        }

        public decimal ProfilId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime? Datedebut { get; set; }
        public DateTime? Datefin { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Tbhabilitation> Tbhabilitation { get; set; }
        public virtual ICollection<Tbuser> Tbuser { get; set; }
    }
}
