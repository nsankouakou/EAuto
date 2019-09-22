using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbrubriqueMainOeuvreDto
    {
        public decimal IdrubriqMo { get; set; }

        public string LibrubriqMo { get; set; }

        public decimal? Nbre { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbexpertiseRubriqueMo> TbexpertiseRubriqueMo { get; set; }

        public static TbrubriqueMainOeuvreDto FromModel(TbrubriqueMainOeuvre model)
        {
            return new TbrubriqueMainOeuvreDto()
            {
                IdrubriqMo = model.IdrubriqMo, 
                LibrubriqMo = model.LibrubriqMo, 
                Nbre = model.Nbre, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbexpertiseRubriqueMo = model.TbexpertiseRubriqueMo, 
            }; 
        }

        public TbrubriqueMainOeuvre ToModel()
        {
            return new TbrubriqueMainOeuvre()
            {
                IdrubriqMo = IdrubriqMo, 
                LibrubriqMo = LibrubriqMo, 
                Nbre = Nbre, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbexpertiseRubriqueMo = TbexpertiseRubriqueMo, 
            }; 
        }
    }
}