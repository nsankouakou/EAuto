using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbrubriqueConstatationDto
    {
        public decimal IdRubConst { get; set; }

        public string LibRubConst { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }

        public static TbrubriqueConstatationDto FromModel(TbrubriqueConstatation model)
        {
            return new TbrubriqueConstatationDto()
            {
                IdRubConst = model.IdRubConst, 
                LibRubConst = model.LibRubConst, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseRubriqueConstatationPointChoc = model.TbexpertiseRubriqueConstatationPointChoc, 
            }; 
        }

        public TbrubriqueConstatation ToModel()
        {
            return new TbrubriqueConstatation()
            {
                IdRubConst = IdRubConst, 
                LibRubConst = LibRubConst, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseRubriqueConstatationPointChoc = TbexpertiseRubriqueConstatationPointChoc, 
            }; 
        }
    }
}