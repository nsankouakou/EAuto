using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbpourRecoursDto
    {
        public decimal IdRecours { get; set; }

        public string LibRecours { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }

        public static TbpourRecoursDto FromModel(TbpourRecours model)
        {
            return new TbpourRecoursDto()
            {
                IdRecours = model.IdRecours, 
                LibRecours = model.LibRecours, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertisePourRecousPointChoc = model.TbexpertisePourRecousPointChoc, 
            }; 
        }

        public TbpourRecours ToModel()
        {
            return new TbpourRecours()
            {
                IdRecours = IdRecours, 
                LibRecours = LibRecours, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertisePourRecousPointChoc = TbexpertisePourRecousPointChoc, 
            }; 
        }
    }
}