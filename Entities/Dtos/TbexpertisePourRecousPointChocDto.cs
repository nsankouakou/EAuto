using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertisePourRecousPointChocDto
    {
        public decimal IdRecours { get; set; }

        public decimal IdExpert { get; set; }

        public decimal IdPointChoc { get; set; }

        public decimal MontRecous { get; set; }

        public string LibRecours { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdExpertNavigation { get; set; }

        public TbpointChocDto IdPointChocNavigation { get; set; }

        public TbpourRecoursDto IdRecoursNavigation { get; set; }

        public static TbexpertisePourRecousPointChocDto FromModel(TbexpertisePourRecousPointChoc model)
        {
            return new TbexpertisePourRecousPointChocDto()
            {
                IdRecours = model.IdRecours, 
                IdExpert = model.IdExpert, 
                IdPointChoc = model.IdPointChoc, 
                MontRecous = model.MontRecous, 
                LibRecours = model.LibRecours, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
                IdPointChocNavigation = TbpointChocDto.FromModel(model.IdPointChocNavigation), 
                IdRecoursNavigation = TbpourRecoursDto.FromModel(model.IdRecoursNavigation), 
            }; 
        }

        public TbexpertisePourRecousPointChoc ToModel()
        {
            return new TbexpertisePourRecousPointChoc()
            {
                IdRecours = IdRecours, 
                IdExpert = IdExpert, 
                IdPointChoc = IdPointChoc, 
                MontRecous = MontRecous, 
                LibRecours = LibRecours, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdExpertNavigation = IdExpertNavigation.ToModel(), 
                IdPointChocNavigation = IdPointChocNavigation.ToModel(), 
                IdRecoursNavigation = IdRecoursNavigation.ToModel(), 
            }; 
        }
    }
}