using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtarifActifDto
    {
        public decimal IdTarifAct { get; set; }

        public string LibAct { get; set; }

        public decimal MtTarifAct { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbtypPeintureTarifActifTarifHonoraireNbreElemnt> TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; set; }

        public static TbtarifActifDto FromModel(TbtarifActif model)
        {
            return new TbtarifActifDto()
            {
                IdTarifAct = model.IdTarifAct, 
                LibAct = model.LibAct, 
                MtTarifAct = model.MtTarifAct, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = model.TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }

        public TbtarifActif ToModel()
        {
            return new TbtarifActif()
            {
                IdTarifAct = IdTarifAct, 
                LibAct = LibAct, 
                MtTarifAct = MtTarifAct, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbtypPeintureTarifActifTarifHonoraireNbreElemnt = TbtypPeintureTarifActifTarifHonoraireNbreElemnt, 
            }; 
        }
    }
}