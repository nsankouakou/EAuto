using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbvehiculeAssuranceDto
    {
        public decimal IdAss { get; set; }

        public decimal IdVeh { get; set; }

        public DateTime DatAss { get; set; }

        public string NumPolice { get; set; }

        public decimal Ligne { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbassuranceDto IdAssNavigation { get; set; }

        public TbvehiculeDto IdVehNavigation { get; set; }

        public static TbvehiculeAssuranceDto FromModel(TbvehiculeAssurance model)
        {
            return new TbvehiculeAssuranceDto()
            {
                IdAss = model.IdAss, 
                IdVeh = model.IdVeh, 
                DatAss = model.DatAss, 
                NumPolice = model.NumPolice, 
                Ligne = model.Ligne, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdAssNavigation = TbassuranceDto.FromModel(model.IdAssNavigation), 
                IdVehNavigation = TbvehiculeDto.FromModel(model.IdVehNavigation), 
            }; 
        }

        public TbvehiculeAssurance ToModel()
        {
            return new TbvehiculeAssurance()
            {
                IdAss = IdAss, 
                IdVeh = IdVeh, 
                DatAss = DatAss, 
                NumPolice = NumPolice, 
                Ligne = Ligne, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdAssNavigation = IdAssNavigation.ToModel(), 
                IdVehNavigation = IdVehNavigation.ToModel(), 
            }; 
        }
    }
}