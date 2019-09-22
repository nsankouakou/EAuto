using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbgenreDto
    {
        public decimal IdGenre { get; set; }

        public string LibGenre { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbgenreDto FromModel(Tbgenre model)
        {
            return new TbgenreDto()
            {
                IdGenre = model.IdGenre, 
                LibGenre = model.LibGenre, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbgenre ToModel()
        {
            return new Tbgenre()
            {
                IdGenre = IdGenre, 
                LibGenre = LibGenre, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}