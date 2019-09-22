using System;

namespace Entities.Models.Dtos
{
    public class TbexpertiseEtatRapportDto
    {
        public decimal IdExpert { get; set; }

        public decimal IdEtaRaport { get; set; }

        public DateTime DatEtat { get; set; }

        public DateTime HeurEtat { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbetatRapportDto IdEtaRaportNavigation { get; set; }

        public TbexpertiseDto IdExpertNavigation { get; set; }

        public static TbexpertiseEtatRapportDto FromModel(TbexpertiseEtatRapport model)
        {
            return new TbexpertiseEtatRapportDto()
            {
                IdExpert = model.IdExpert, 
                IdEtaRaport = model.IdEtaRaport, 
                DatEtat = model.DatEtat, 
                HeurEtat = model.HeurEtat, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdEtaRaportNavigation = TbetatRapportDto.FromModel(model.IdEtaRaportNavigation), 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
            }; 
        }

        public TbexpertiseEtatRapport ToModel()
        {
            return new TbexpertiseEtatRapport()
            {
                IdExpert = IdExpert, 
                IdEtaRaport = IdEtaRaport, 
                DatEtat = DatEtat, 
                HeurEtat = HeurEtat, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdEtaRaportNavigation = IdEtaRaportNavigation.ToModel(), 
                IdExpertNavigation = IdExpertNavigation.ToModel(), 
            }; 
        }
    }
}