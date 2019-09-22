using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbdossierDto
    {
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

        public string Token { get; set; }

        public TbcommuneDto IdCommNavigation { get; set; }

        public TbpriseEnChargeDto IdPriseChargNavigation { get; set; }

        public TbtvaDto IdTvaNavigation { get; set; }

        public TbtypeExpertiseDto IdTypExpertNavigation { get; set; }

        public ICollection<Tbavance> Tbavance { get; set; }

        public ICollection<TbconclusionGen> TbconclusionGen { get; set; }

        public ICollection<TbdossierEtatRapport> TbdossierEtatRapport { get; set; }

        public ICollection<TbdossierRubriqueHonoraire> TbdossierRubriqueHonoraire { get; set; }

        public ICollection<TbdossierSortis> TbdossierSortis { get; set; }

        public ICollection<Tbexpertise> Tbexpertise { get; set; }

        public ICollection<Tbfacture> Tbfacture { get; set; }

        public ICollection<TbpreambuleGen> TbpreambuleGen { get; set; }

        public ICollection<TbrecapPrejudice> TbrecapPrejudice { get; set; }

        public ICollection<TbuserDossier> TbuserDossier { get; set; }

        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbdossierDto FromModel(Tbdossier model)
        {
            return new TbdossierDto()
            {
                IdDoss = model.IdDoss, 
                NumDoss = model.NumDoss, 
                NumSinistre = model.NumSinistre, 
                DateSinistre = model.DateSinistre, 
                DatOuvert = model.DatOuvert, 
                DateRdv = model.DateRdv, 
                DatExpert = model.DatExpert, 
                MtPrejudice = model.MtPrejudice, 
                IdTypExpert = model.IdTypExpert, 
                IdPriseCharg = model.IdPriseCharg, 
                IdComm = model.IdComm, 
                LieuExpert = model.LieuExpert, 
                HorsTaxe = model.HorsTaxe, 
                HorsDouane = model.HorsDouane, 
                IdTva = model.IdTva, 
                IdUser = model.IdUser, 
                DatDemExpert = model.DatDemExpert, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdCommNavigation = TbcommuneDto.FromModel(model.IdCommNavigation), 
                IdPriseChargNavigation = TbpriseEnChargeDto.FromModel(model.IdPriseChargNavigation), 
                IdTvaNavigation = TbtvaDto.FromModel(model.IdTvaNavigation), 
                IdTypExpertNavigation = TbtypeExpertiseDto.FromModel(model.IdTypExpertNavigation), 
                Tbavance = model.Tbavance, 
                TbconclusionGen = model.TbconclusionGen, 
                TbdossierEtatRapport = model.TbdossierEtatRapport, 
                TbdossierRubriqueHonoraire = model.TbdossierRubriqueHonoraire, 
                TbdossierSortis = model.TbdossierSortis, 
                Tbexpertise = model.Tbexpertise, 
                Tbfacture = model.Tbfacture, 
                TbpreambuleGen = model.TbpreambuleGen, 
                TbrecapPrejudice = model.TbrecapPrejudice, 
                TbuserDossier = model.TbuserDossier, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbdossier ToModel()
        {
            return new Tbdossier()
            {
                IdDoss = IdDoss, 
                NumDoss = NumDoss, 
                NumSinistre = NumSinistre, 
                DateSinistre = DateSinistre, 
                DatOuvert = DatOuvert, 
                DateRdv = DateRdv, 
                DatExpert = DatExpert, 
                MtPrejudice = MtPrejudice, 
                IdTypExpert = IdTypExpert, 
                IdPriseCharg = IdPriseCharg, 
                IdComm = IdComm, 
                LieuExpert = LieuExpert, 
                HorsTaxe = HorsTaxe, 
                HorsDouane = HorsDouane, 
                IdTva = IdTva, 
                IdUser = IdUser, 
                DatDemExpert = DatDemExpert, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdCommNavigation = IdCommNavigation.ToModel(), 
                IdPriseChargNavigation = IdPriseChargNavigation.ToModel(), 
                IdTvaNavigation = IdTvaNavigation.ToModel(), 
                IdTypExpertNavigation = IdTypExpertNavigation.ToModel(), 
                Tbavance = Tbavance, 
                TbconclusionGen = TbconclusionGen, 
                TbdossierEtatRapport = TbdossierEtatRapport, 
                TbdossierRubriqueHonoraire = TbdossierRubriqueHonoraire, 
                TbdossierSortis = TbdossierSortis, 
                Tbexpertise = Tbexpertise, 
                Tbfacture = Tbfacture, 
                TbpreambuleGen = TbpreambuleGen, 
                TbrecapPrejudice = TbrecapPrejudice, 
                TbuserDossier = TbuserDossier, 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}