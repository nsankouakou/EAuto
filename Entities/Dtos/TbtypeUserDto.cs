using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtypeUserDto
    {
        public decimal IdTypeUser { get; set; }

        public string LibTypeUser { get; set; }

        public decimal? NbreUser { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbuser> Tbuser { get; set; }

        public static TbtypeUserDto FromModel(TbtypeUser model)
        {
            return new TbtypeUserDto()
            {
                IdTypeUser = model.IdTypeUser, 
                LibTypeUser = model.LibTypeUser, 
                NbreUser = model.NbreUser, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbuser = model.Tbuser, 
            }; 
        }

        public TbtypeUser ToModel()
        {
            return new TbtypeUser()
            {
                IdTypeUser = IdTypeUser, 
                LibTypeUser = LibTypeUser, 
                NbreUser = NbreUser, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbuser = Tbuser, 
            }; 
        }
    }
}