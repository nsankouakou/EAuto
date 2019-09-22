using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbtypGarageDto
    {
        public decimal IdTyGara { get; set; }

        public string LibTypGara { get; set; }

        public decimal IdTarifHor { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbtarifHoraireDto IdTarifHorNavigation { get; set; }

        public static TbtypGarageDto FromModel(TbtypGarage model)
        {
            return new TbtypGarageDto()
            {
                IdTyGara = model.IdTyGara, 
                LibTypGara = model.LibTypGara, 
                IdTarifHor = model.IdTarifHor, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdTarifHorNavigation = TbtarifHoraireDto.FromModel(model.IdTarifHorNavigation), 
            }; 
        }

        public TbtypGarage ToModel()
        {
            return new TbtypGarage()
            {
                IdTyGara = IdTyGara, 
                LibTypGara = LibTypGara, 
                IdTarifHor = IdTarifHor, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdTarifHorNavigation = IdTarifHorNavigation.ToModel(), 
            }; 
        }
    }
}