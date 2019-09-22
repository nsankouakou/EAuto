using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbrubriqueEvalExpertiseDto
    {
        public decimal Idexpert { get; set; }

        public decimal IdRubEval { get; set; }

        public string Constater { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbrubriqueEvaluationDto IdRubEvalNavigation { get; set; }

        public static TbrubriqueEvalExpertiseDto FromModel(TbrubriqueEvalExpertise model)
        {
            return new TbrubriqueEvalExpertiseDto()
            {
                Idexpert = model.Idexpert, 
                IdRubEval = model.IdRubEval, 
                Constater = model.Constater, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdRubEvalNavigation = TbrubriqueEvaluationDto.FromModel(model.IdRubEvalNavigation), 
            }; 
        }

        public TbrubriqueEvalExpertise ToModel()
        {
            return new TbrubriqueEvalExpertise()
            {
                Idexpert = Idexpert, 
                IdRubEval = IdRubEval, 
                Constater = Constater, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdRubEvalNavigation = IdRubEvalNavigation.ToModel(), 
            }; 
        }
    }
}