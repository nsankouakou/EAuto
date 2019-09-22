using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbnbreElementDto
    {
        public decimal Idnbelmt { get; set; }

        public string Libnbelmt { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbnbreElementMainOeuvreTypePeinture> TbnbreElementMainOeuvreTypePeinture { get; set; }

        public ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }

        public static TbnbreElementDto FromModel(TbnbreElement model)
        {
            return new TbnbreElementDto()
            {
                Idnbelmt = model.Idnbelmt, 
                Libnbelmt = model.Libnbelmt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbnbreElementMainOeuvreTypePeinture = model.TbnbreElementMainOeuvreTypePeinture, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = model.TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }

        public TbnbreElement ToModel()
        {
            return new TbnbreElement()
            {
                Idnbelmt = Idnbelmt, 
                Libnbelmt = Libnbelmt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbnbreElementMainOeuvreTypePeinture = TbnbreElementMainOeuvreTypePeinture, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }
    }
}