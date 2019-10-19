using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbmenu
    {
        public Tbmenu()
        {
            Tbhabilitation = new HashSet<Tbhabilitation>();
        }

        public decimal MenuId { get; set; }
        public decimal? IdParent { get; set; }
        public string LibelleMenu { get; set; }
        public string Action { get; set; }
        public int? OrdreMenu { get; set; }
        public bool? Bactif { get; set; }
        public string Controlleur { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tbhabilitation> Tbhabilitation { get; set; }
    }
}
