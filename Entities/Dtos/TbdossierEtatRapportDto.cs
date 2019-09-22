using System;

namespace Entities.Models.Dtos
{
    public class TbdossierEtatRapportDto
    {
        public decimal IdDoss { get; set; }

        public decimal IdEtaRaport { get; set; }

        public DateTime? DatEtat { get; set; }

        public DateTime? HeurEtat { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public TbetatRapportDto IdEtaRaportNavigation { get; set; }

        public static TbdossierEtatRapportDto FromModel(TbdossierEtatRapport model)
        {
            return new TbdossierEtatRapportDto()
            {
                IdDoss = model.IdDoss, 
                IdEtaRaport = model.IdEtaRaport, 
                DatEtat = model.DatEtat, 
                HeurEtat = model.HeurEtat, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                IdEtaRaportNavigation = TbetatRapportDto.FromModel(model.IdEtaRaportNavigation), 
            }; 
        }

        public TbdossierEtatRapport ToModel()
        {
            return new TbdossierEtatRapport()
            {
                IdDoss = IdDoss, 
                IdEtaRaport = IdEtaRaport, 
                DatEtat = DatEtat, 
                HeurEtat = HeurEtat, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                IdEtaRaportNavigation = IdEtaRaportNavigation.ToModel(), 
            }; 
        }
    }
}