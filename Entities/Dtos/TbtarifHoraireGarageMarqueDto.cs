using System;

namespace Entities.Models.Dtos
{
    public class TbtarifHoraireGarageMarqueDto
    {
        public decimal IdGara { get; set; }

        public decimal IdMarque { get; set; }

        public decimal IdTarifHor { get; set; }

        public decimal MtTarif { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbgarageDto IdGaraNavigation { get; set; }

        public TbmarqueDto IdMarqueNavigation { get; set; }

        public TbtarifHoraireDto IdTarifHorNavigation { get; set; }

        public static TbtarifHoraireGarageMarqueDto FromModel(TbtarifHoraireGarageMarque model)
        {
            return new TbtarifHoraireGarageMarqueDto()
            {
                IdGara = model.IdGara, 
                IdMarque = model.IdMarque, 
                IdTarifHor = model.IdTarifHor, 
                MtTarif = model.MtTarif, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdGaraNavigation = TbgarageDto.FromModel(model.IdGaraNavigation), 
                IdMarqueNavigation = TbmarqueDto.FromModel(model.IdMarqueNavigation), 
                IdTarifHorNavigation = TbtarifHoraireDto.FromModel(model.IdTarifHorNavigation), 
            }; 
        }

        public TbtarifHoraireGarageMarque ToModel()
        {
            return new TbtarifHoraireGarageMarque()
            {
                IdGara = IdGara, 
                IdMarque = IdMarque, 
                IdTarifHor = IdTarifHor, 
                MtTarif = MtTarif, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdGaraNavigation = IdGaraNavigation.ToModel(), 
                IdMarqueNavigation = IdMarqueNavigation.ToModel(), 
                IdTarifHorNavigation = IdTarifHorNavigation.ToModel(), 
            }; 
        }
    }
}