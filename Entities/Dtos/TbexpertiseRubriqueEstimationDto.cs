using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseRubriqueEstimationDto
    {
        public decimal IdExpert { get; set; }

        public decimal IdRubEstim { get; set; }

        public string Estimation { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdExpertNavigation { get; set; }

        public TbrubriqueEstimationDto IdRubEstimNavigation { get; set; }

        public static TbexpertiseRubriqueEstimationDto FromModel(TbexpertiseRubriqueEstimation model)
        {
            return new TbexpertiseRubriqueEstimationDto()
            {
                IdExpert = model.IdExpert, 
                IdRubEstim = model.IdRubEstim, 
                Estimation = model.Estimation, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
                IdRubEstimNavigation = TbrubriqueEstimationDto.FromModel(model.IdRubEstimNavigation), 
            }; 
        }

        public TbexpertiseRubriqueEstimation ToModel()
        {
            return new TbexpertiseRubriqueEstimation()
            {
                IdExpert = IdExpert, 
                IdRubEstim = IdRubEstim, 
                Estimation = Estimation, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdExpertNavigation = IdExpertNavigation.ToModel(), 
                IdRubEstimNavigation = IdRubEstimNavigation.ToModel(), 
            }; 
        }
    }
}