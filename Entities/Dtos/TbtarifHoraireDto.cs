using System;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtarifHoraireDto
    {
        public decimal IdTarifHor { get; set; }

        public decimal MtTarifHor { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbtarifHoraireGarageMarque> TbtarifHoraireGarageMarque { get; set; }

        public ICollection<TbtypGarage> TbtypGarage { get; set; }

        public ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }

        public static TbtarifHoraireDto FromModel(TbtarifHoraire model)
        {
            return new TbtarifHoraireDto()
            {
                IdTarifHor = model.IdTarifHor, 
                MtTarifHor = model.MtTarifHor, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbtarifHoraireGarageMarque = model.TbtarifHoraireGarageMarque, 
                TbtypGarage = model.TbtypGarage, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = model.TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }

        public TbtarifHoraire ToModel()
        {
            return new TbtarifHoraire()
            {
                IdTarifHor = IdTarifHor, 
                MtTarifHor = MtTarifHor, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbtarifHoraireGarageMarque = TbtarifHoraireGarageMarque, 
                TbtypGarage = TbtypGarage, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }
    }
}