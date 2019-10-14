using Entities.Models;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;

namespace ApiExpertAuto.Models
{
    public class DossierModel
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



        public ICollection<TbdossierRubriqueHonoraireDto> dossierRubriqueHonoraires { get; set; }


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
                StatusCode = model.StatusCode
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
                StatusCode = StatusCode
            };
        }
    }
}
