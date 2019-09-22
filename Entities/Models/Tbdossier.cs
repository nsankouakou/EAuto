using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbdossier
    {
        public Tbdossier()
        {
            Tbavance = new HashSet<Tbavance>();
            TbconclusionGen = new HashSet<TbconclusionGen>();
            TbdossierEtatRapport = new HashSet<TbdossierEtatRapport>();
            TbdossierRubriqueHonoraire = new HashSet<TbdossierRubriqueHonoraire>();
            TbdossierSortis = new HashSet<TbdossierSortis>();
            Tbexpertise = new HashSet<Tbexpertise>();
            Tbfacture = new HashSet<Tbfacture>();
            TbpreambuleGen = new HashSet<TbpreambuleGen>();
            TbrecapPrejudice = new HashSet<TbrecapPrejudice>();
            TbuserDossier = new HashSet<TbuserDossier>();
            Tbvehicule = new HashSet<Tbvehicule>();
        }

        public decimal IdDoss { get; set; }
        public string NumDoss { get; set; }
        public string NumSinistre { get; set; }
        public string DateSinistre { get; set; }
        public DateTime DatOuvert { get; set; }
        public DateTime DateRdv { get; set; }
        public DateTime? DatExpert { get; set; }
        public decimal MtPrejudice { get; set; }
        public decimal IdTypExpert { get; set; }
        public decimal IdPriseCharg { get; set; }
        public decimal? IdComm { get; set; }
        public string LieuExpert { get; set; }
        public decimal? HorsTaxe { get; set; }
        public decimal? HorsDouane { get; set; }
        public decimal? IdTva { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DatDemExpert { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbcommune IdCommNavigation { get; set; }
        public virtual TbpriseEnCharge IdPriseChargNavigation { get; set; }
        public virtual Tbtva IdTvaNavigation { get; set; }
        public virtual TbtypeExpertise IdTypExpertNavigation { get; set; }
        public virtual ICollection<Tbavance> Tbavance { get; set; }
        public virtual ICollection<TbconclusionGen> TbconclusionGen { get; set; }
        public virtual ICollection<TbdossierEtatRapport> TbdossierEtatRapport { get; set; }
        public virtual ICollection<TbdossierRubriqueHonoraire> TbdossierRubriqueHonoraire { get; set; }
        public virtual ICollection<TbdossierSortis> TbdossierSortis { get; set; }
        public virtual ICollection<Tbexpertise> Tbexpertise { get; set; }
        public virtual ICollection<Tbfacture> Tbfacture { get; set; }
        public virtual ICollection<TbpreambuleGen> TbpreambuleGen { get; set; }
        public virtual ICollection<TbrecapPrejudice> TbrecapPrejudice { get; set; }
        public virtual ICollection<TbuserDossier> TbuserDossier { get; set; }
        public virtual ICollection<Tbvehicule> Tbvehicule { get; set; }
    }
}
