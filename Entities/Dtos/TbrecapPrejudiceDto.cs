using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbrecapPrejudiceDto
    {
        public decimal IdRecapExp { get; set; }

        public decimal MtPneuveHt { get; set; }

        public decimal MtTvapneuve { get; set; }

        public decimal MtPneuveTtc { get; set; }

        public decimal MtRecupTtc { get; set; }

        public decimal MtFournitureTtc { get; set; }

        public decimal? MtTotDesPrejudices { get; set; }

        public decimal MtMoHt { get; set; }

        public decimal MtMoPeintureHt { get; set; }

        public decimal MtTvamoPeinture { get; set; }

        public decimal MtMoTtc { get; set; }

        public decimal MtMoPeintureTtc { get; set; }

        public decimal MtTotMoTtc { get; set; }

        public decimal MtProdPeintureHt { get; set; }

        public decimal MtPetiteFounHt { get; set; }

        public decimal MtTvapetiteFournPeinture { get; set; }

        public decimal MtTotPrejudice { get; set; }

        public string MtDepannage { get; set; }

        public decimal IdPointChoc { get; set; }

        public decimal IdExpert { get; set; }

        public DateTime? DatCompo { get; set; }

        public decimal? Eprejudice { get; set; }

        public decimal IdDoss { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbdossierDto IdDossNavigation { get; set; }

        public TbpointChocDto IdPointChocNavigation { get; set; }

        public static TbrecapPrejudiceDto FromModel(TbrecapPrejudice model)
        {
            return new TbrecapPrejudiceDto()
            {
                IdRecapExp = model.IdRecapExp, 
                MtPneuveHt = model.MtPneuveHt, 
                MtTvapneuve = model.MtTvapneuve, 
                MtPneuveTtc = model.MtPneuveTtc, 
                MtRecupTtc = model.MtRecupTtc, 
                MtFournitureTtc = model.MtFournitureTtc, 
                MtTotDesPrejudices = model.MtTotDesPrejudices, 
                MtMoHt = model.MtMoHt, 
                MtMoPeintureHt = model.MtMoPeintureHt, 
                MtTvamoPeinture = model.MtTvamoPeinture, 
                MtMoTtc = model.MtMoTtc, 
                MtMoPeintureTtc = model.MtMoPeintureTtc, 
                MtTotMoTtc = model.MtTotMoTtc, 
                MtProdPeintureHt = model.MtProdPeintureHt, 
                MtPetiteFounHt = model.MtPetiteFounHt, 
                MtTvapetiteFournPeinture = model.MtTvapetiteFournPeinture, 
                MtTotPrejudice = model.MtTotPrejudice, 
                MtDepannage = model.MtDepannage, 
                IdPointChoc = model.IdPointChoc, 
                IdExpert = model.IdExpert, 
                DatCompo = model.DatCompo, 
                Eprejudice = model.Eprejudice, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                IdPointChocNavigation = TbpointChocDto.FromModel(model.IdPointChocNavigation), 
            }; 
        }

        public TbrecapPrejudice ToModel()
        {
            return new TbrecapPrejudice()
            {
                IdRecapExp = IdRecapExp, 
                MtPneuveHt = MtPneuveHt, 
                MtTvapneuve = MtTvapneuve, 
                MtPneuveTtc = MtPneuveTtc, 
                MtRecupTtc = MtRecupTtc, 
                MtFournitureTtc = MtFournitureTtc, 
                MtTotDesPrejudices = MtTotDesPrejudices, 
                MtMoHt = MtMoHt, 
                MtMoPeintureHt = MtMoPeintureHt, 
                MtTvamoPeinture = MtTvamoPeinture, 
                MtMoTtc = MtMoTtc, 
                MtMoPeintureTtc = MtMoPeintureTtc, 
                MtTotMoTtc = MtTotMoTtc, 
                MtProdPeintureHt = MtProdPeintureHt, 
                MtPetiteFounHt = MtPetiteFounHt, 
                MtTvapetiteFournPeinture = MtTvapetiteFournPeinture, 
                MtTotPrejudice = MtTotPrejudice, 
                MtDepannage = MtDepannage, 
                IdPointChoc = IdPointChoc, 
                IdExpert = IdExpert, 
                DatCompo = DatCompo, 
                Eprejudice = Eprejudice, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                IdPointChocNavigation = IdPointChocNavigation.ToModel(), 
            }; 
        }
    }
}