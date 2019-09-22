using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbetatRapportDto
    {
        public decimal IdEtaRaport { get; set; }

        public string LibEtaRaport { get; set; }

        public decimal? Nbre { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<TbdossierEtatRapport> TbdossierEtatRapport { get; set; }

        public ICollection<TbexpertiseEtatRapport> TbexpertiseEtatRapport { get; set; }

        public static TbetatRapportDto FromModel(TbetatRapport model)
        {
            return new TbetatRapportDto()
            {
                IdEtaRaport = model.IdEtaRaport, 
                LibEtaRaport = model.LibEtaRaport, 
                Nbre = model.Nbre, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbdossierEtatRapport = model.TbdossierEtatRapport, 
                TbexpertiseEtatRapport = model.TbexpertiseEtatRapport, 
            }; 
        }

        public TbetatRapport ToModel()
        {
            return new TbetatRapport()
            {
                IdEtaRaport = IdEtaRaport, 
                LibEtaRaport = LibEtaRaport, 
                Nbre = Nbre, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbdossierEtatRapport = TbdossierEtatRapport, 
                TbexpertiseEtatRapport = TbexpertiseEtatRapport, 
            }; 
        }
    }
}