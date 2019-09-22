using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbpriseEnChargeDto
    {
        public decimal IdPriseCharg { get; set; }

        public string LibPriseCharg { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbdossier> Tbdossier { get; set; }

        public static TbpriseEnChargeDto FromModel(TbpriseEnCharge model)
        {
            return new TbpriseEnChargeDto()
            {
                IdPriseCharg = model.IdPriseCharg, 
                LibPriseCharg = model.LibPriseCharg, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbdossier = model.Tbdossier, 
            }; 
        }

        public TbpriseEnCharge ToModel()
        {
            return new TbpriseEnCharge()
            {
                IdPriseCharg = IdPriseCharg, 
                LibPriseCharg = LibPriseCharg, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbdossier = Tbdossier, 
            }; 
        }
    }
}