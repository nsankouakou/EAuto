using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbconclusionGenDto
    {
        public decimal IdconclusGen { get; set; }

        public string Libconclus { get; set; }

        public decimal IdDoss { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public static TbconclusionGenDto FromModel(TbconclusionGen model)
        {
            return new TbconclusionGenDto()
            {
                IdconclusGen = model.IdconclusGen, 
                Libconclus = model.Libconclus, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
            }; 
        }

        public TbconclusionGen ToModel()
        {
            return new TbconclusionGen()
            {
                IdconclusGen = IdconclusGen, 
                Libconclus = Libconclus, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
            }; 
        }
    }
}