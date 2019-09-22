using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbrubriqueEvaluationDto
    {
        public decimal IdRubEval { get; set; }

        public string LibRubEval { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbrubriqueEvalExpertise> TbrubriqueEvalExpertise { get; set; }

        public static TbrubriqueEvaluationDto FromModel(TbrubriqueEvaluation model)
        {
            return new TbrubriqueEvaluationDto()
            {
                IdRubEval = model.IdRubEval, 
                LibRubEval = model.LibRubEval, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbrubriqueEvalExpertise = model.TbrubriqueEvalExpertise, 
            }; 
        }

        public TbrubriqueEvaluation ToModel()
        {
            return new TbrubriqueEvaluation()
            {
                IdRubEval = IdRubEval, 
                LibRubEval = LibRubEval, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbrubriqueEvalExpertise = TbrubriqueEvalExpertise, 
            }; 
        }
    }
}