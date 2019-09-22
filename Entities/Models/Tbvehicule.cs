using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbvehicule
    {
        public Tbvehicule()
        {
            Tbexpertise = new HashSet<Tbexpertise>();
            TbvehiculeAssurance = new HashSet<TbvehiculeAssurance>();
        }

        public decimal IdVeh { get; set; }
        public string Immatriculation { get; set; }
        public string Serievehic { get; set; }
        public DateTime? Datmisecircul { get; set; }
        public string Puissancefiscal { get; set; }
        public string Nbplace { get; set; }
        public string VisiteTech { get; set; }
        public decimal? Idtypveh { get; set; }
        public decimal? IdGenre { get; set; }
        public decimal? IdCouleur { get; set; }
        public decimal? IdEnergie { get; set; }
        public decimal IdProprio { get; set; }
        public decimal? Idcarross { get; set; }
        public decimal IdDoss { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbcouleur IdCouleurNavigation { get; set; }
        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual Tbenergie IdEnergieNavigation { get; set; }
        public virtual Tbgenre IdGenreNavigation { get; set; }
        public virtual Tbproprietaire IdProprioNavigation { get; set; }
        public virtual Tbcarosserie IdcarrossNavigation { get; set; }
        public virtual TbtypeVehicule IdtypvehNavigation { get; set; }
        public virtual ICollection<Tbexpertise> Tbexpertise { get; set; }
        public virtual ICollection<TbvehiculeAssurance> TbvehiculeAssurance { get; set; }
    }
}
