using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbfournitureDto
    {
        public decimal IdFourn { get; set; }

        public string LibFourn { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }

        public static TbfournitureDto FromModel(Tbfourniture model)
        {
            return new TbfournitureDto()
            {
                IdFourn = model.IdFourn, 
                LibFourn = model.LibFourn, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseFourniturePointChoc = model.TbexpertiseFourniturePointChoc, 
            }; 
        }

        public Tbfourniture ToModel()
        {
            return new Tbfourniture()
            {
                IdFourn = IdFourn, 
                LibFourn = LibFourn, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseFourniturePointChoc = TbexpertiseFourniturePointChoc, 
            }; 
        }
    }
}