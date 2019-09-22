using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbrubriqueEstimationDto
    {
        public decimal IdRubEstim { get; set; }

        public string LibRubEstim { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseRubriqueEstimation> TbexpertiseRubriqueEstimation { get; set; }

        public static TbrubriqueEstimationDto FromModel(TbrubriqueEstimation model)
        {
            return new TbrubriqueEstimationDto()
            {
                IdRubEstim = model.IdRubEstim, 
                LibRubEstim = model.LibRubEstim, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseRubriqueEstimation = model.TbexpertiseRubriqueEstimation, 
            }; 
        }

        public TbrubriqueEstimation ToModel()
        {
            return new TbrubriqueEstimation()
            {
                IdRubEstim = IdRubEstim, 
                LibRubEstim = LibRubEstim, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseRubriqueEstimation = TbexpertiseRubriqueEstimation, 
            }; 
        }
    }
}