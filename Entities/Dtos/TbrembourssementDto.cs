using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbrembourssementDto
    {
        public decimal Idrembours { get; set; }

        public string Librembours { get; set; }

        public decimal Idfact { get; set; }

        public decimal Idmodrglmt { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbfactureDto IdfactNavigation { get; set; }

        public TbmodeReglementDto IdmodrglmtNavigation { get; set; }

        public static TbrembourssementDto FromModel(Tbrembourssement model)
        {
            return new TbrembourssementDto()
            {
                Idrembours = model.Idrembours, 
                Librembours = model.Librembours, 
                Idfact = model.Idfact, 
                Idmodrglmt = model.Idmodrglmt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdfactNavigation = TbfactureDto.FromModel(model.IdfactNavigation), 
                IdmodrglmtNavigation = TbmodeReglementDto.FromModel(model.IdmodrglmtNavigation), 
            }; 
        }

        public Tbrembourssement ToModel()
        {
            return new Tbrembourssement()
            {
                Idrembours = Idrembours, 
                Librembours = Librembours, 
                Idfact = Idfact, 
                Idmodrglmt = Idmodrglmt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdfactNavigation = IdfactNavigation.ToModel(), 
                IdmodrglmtNavigation = IdmodrglmtNavigation.ToModel(), 
            }; 
        }
    }
}