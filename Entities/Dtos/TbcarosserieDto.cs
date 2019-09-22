using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbcarosserieDto
    {
        public decimal Idcarross { get; set; }

        public string LibCarross { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<TbmarqueCarrosserie> TbmarqueCarrosserie { get; set; }

        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbcarosserieDto FromModel(Tbcarosserie model)
        {
            return new TbcarosserieDto()
            {
                Idcarross = model.Idcarross, 
                LibCarross = model.LibCarross, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbmarqueCarrosserie = model.TbmarqueCarrosserie, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbcarosserie ToModel()
        {
            return new Tbcarosserie()
            {
                Idcarross = Idcarross, 
                LibCarross = LibCarross, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbmarqueCarrosserie = TbmarqueCarrosserie, 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}