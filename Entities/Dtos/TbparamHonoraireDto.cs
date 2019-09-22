using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbparamHonoraireDto
    {
        public decimal IdParam { get; set; }

        public decimal MtInferPrej { get; set; }

        public decimal MtSupPrej { get; set; }

        public decimal MtHonoraire { get; set; }

        public string CoefExced { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public static TbparamHonoraireDto FromModel(TbparamHonoraire model)
        {
            return new TbparamHonoraireDto()
            {
                IdParam = model.IdParam, 
                MtInferPrej = model.MtInferPrej, 
                MtSupPrej = model.MtSupPrej, 
                MtHonoraire = model.MtHonoraire, 
                CoefExced = model.CoefExced, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public TbparamHonoraire ToModel()
        {
            return new TbparamHonoraire()
            {
                IdParam = IdParam, 
                MtInferPrej = MtInferPrej, 
                MtSupPrej = MtSupPrej, 
                MtHonoraire = MtHonoraire, 
                CoefExced = CoefExced, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}