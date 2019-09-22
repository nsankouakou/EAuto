using System;

namespace Entities.Models.Dtos
{
    public class TbtypPeintureTarifActifTarifHonoraireNbreElemntDto
    {
        public decimal IdTarif { get; set; }

        public decimal IdTypPeint { get; set; }

        public decimal IdTarifAct { get; set; }

        public decimal Coef { get; set; }

        public decimal Const { get; set; }

        public decimal Mtprodpeint { get; set; }

        public decimal Idnbelmt { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbtarifActifDto IdTarifActNavigation { get; set; }

        public TbtarifHoraireDto IdTarifNavigation { get; set; }

        public TbtypePeintureDto IdTypPeintNavigation { get; set; }

        public TbnbreElementDto IdnbelmtNavigation { get; set; }

        public static TbtypPeintureTarifActifTarifHonoraireNbreElemntDto FromModel(TbtypPeintureTarifActifTarifHonoraireNbreElemnt model)
        {
            return new TbtypPeintureTarifActifTarifHonoraireNbreElemntDto()
            {
                IdTarif = model.IdTarif, 
                IdTypPeint = model.IdTypPeint, 
                IdTarifAct = model.IdTarifAct, 
                Coef = model.Coef, 
                Const = model.Const, 
                Mtprodpeint = model.Mtprodpeint, 
                Idnbelmt = model.Idnbelmt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdTarifActNavigation = TbtarifActifDto.FromModel(model.IdTarifActNavigation), 
                IdTarifNavigation = TbtarifHoraireDto.FromModel(model.IdTarifNavigation), 
                IdTypPeintNavigation = TbtypePeintureDto.FromModel(model.IdTypPeintNavigation), 
                IdnbelmtNavigation = TbnbreElementDto.FromModel(model.IdnbelmtNavigation), 
            }; 
        }

        public TbtypPeintureTarifActifTarifHonoraireNbreElemnt ToModel()
        {
            return new TbtypPeintureTarifActifTarifHonoraireNbreElemnt()
            {
                IdTarif = IdTarif, 
                IdTypPeint = IdTypPeint, 
                IdTarifAct = IdTarifAct, 
                Coef = Coef, 
                Const = Const, 
                Mtprodpeint = Mtprodpeint, 
                Idnbelmt = Idnbelmt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdTarifActNavigation = IdTarifActNavigation.ToModel(), 
                IdTarifNavigation = IdTarifNavigation.ToModel(), 
                IdTypPeintNavigation = IdTypPeintNavigation.ToModel(), 
                IdnbelmtNavigation = IdnbelmtNavigation.ToModel(), 
            }; 
        }
    }
}