using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbmarqueDto
    {
        public decimal IdMarque { get; set; }

        public string LibMarque { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbmarqueCarrosserie> TbmarqueCarrosserie { get; set; }

        public ICollection<Tbmodele> Tbmodele { get; set; }

        public ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }

        public static TbmarqueDto FromModel(Tbmarque model)
        {
            return new TbmarqueDto()
            {
                IdMarque = model.IdMarque, 
                LibMarque = model.LibMarque, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbmarqueCarrosserie = model.TbmarqueCarrosserie, 
                Tbmodele = model.Tbmodele, 
                TbtarifHoraireGarageMarque = model.TbtarifHoraireGarageMarque, 
            }; 
        }

        public Tbmarque ToModel()
        {
            return new Tbmarque()
            {
                IdMarque = IdMarque, 
                LibMarque = LibMarque, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbmarqueCarrosserie = TbmarqueCarrosserie, 
                Tbmodele = Tbmodele, 
                TbtarifHoraireGarageMarque = TbtarifHoraireGarageMarque, 
            }; 
        }
    }
}