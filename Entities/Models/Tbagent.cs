using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbagent
    {
        public Tbagent()
        {
            Tbuser = new HashSet<Tbuser>();
        }

        public decimal AgentId { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }
        public string Password { get; set; }
        public int? Categorie { get; set; }
        public string Telephone { get; set; }
        public string Lettreaffectee { get; set; }
        public decimal? Fonctionid { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Fonction Fonction { get; set; }
        public virtual ICollection<Tbuser> Tbuser { get; set; }
    }
}
