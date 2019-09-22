using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbnbreElementMainOeuvreTypePeintureDto
    {
        public decimal Idnbelmt { get; set; }

        public decimal IdMo { get; set; }

        public decimal Idtyppeint { get; set; }

        public decimal? Tpeint { get; set; }

        public decimal Coef { get; set; }

        public decimal Conste { get; set; }

        public string MtPeint { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmainOeuvreDto IdMoNavigation { get; set; }

        public TbnbreElementDto IdnbelmtNavigation { get; set; }

        public TbtypePeintureDto IdtyppeintNavigation { get; set; }

        public static TbnbreElementMainOeuvreTypePeintureDto FromModel(TbnbreElementMainOeuvreTypePeinture model)
        {
            return new TbnbreElementMainOeuvreTypePeintureDto()
            {
                Idnbelmt = model.Idnbelmt, 
                IdMo = model.IdMo, 
                Idtyppeint = model.Idtyppeint, 
                Tpeint = model.Tpeint, 
                Coef = model.Coef, 
                Conste = model.Conste, 
                MtPeint = model.MtPeint, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdMoNavigation = TbmainOeuvreDto.FromModel(model.IdMoNavigation), 
                IdnbelmtNavigation = TbnbreElementDto.FromModel(model.IdnbelmtNavigation), 
                IdtyppeintNavigation = TbtypePeintureDto.FromModel(model.IdtyppeintNavigation), 
            }; 
        }

        public TbnbreElementMainOeuvreTypePeinture ToModel()
        {
            return new TbnbreElementMainOeuvreTypePeinture()
            {
                Idnbelmt = Idnbelmt, 
                IdMo = IdMo, 
                Idtyppeint = Idtyppeint, 
                Tpeint = Tpeint, 
                Coef = Coef, 
                Conste = Conste, 
                MtPeint = MtPeint, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdMoNavigation = IdMoNavigation.ToModel(), 
                IdnbelmtNavigation = IdnbelmtNavigation.ToModel(), 
                IdtyppeintNavigation = IdtyppeintNavigation.ToModel(), 
            }; 
        }
    }
}