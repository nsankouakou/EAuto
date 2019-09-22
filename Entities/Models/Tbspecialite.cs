using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbspecialite
    {
        public Tbspecialite()
        {
            TbspecialiteUser = new HashSet<TbspecialiteUser>();
        }

        public decimal IdSpec { get; set; }
        public string LibSepec { get; set; }
        public decimal IdServ { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbservice IdServNavigation { get; set; }
        public virtual ICollection<TbspecialiteUser> TbspecialiteUser { get; set; }
    }
}
