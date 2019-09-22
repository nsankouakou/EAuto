using System;

namespace Entities.Models.Dtos
{
    public class TbrapportAcheveDto
    {
        public decimal Idrapport { get; set; }

        public DateTime Date { get; set; }

        public DateTime Heure { get; set; }

        public decimal IdExpert { get; set; }

        public decimal IdDoss { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public static TbrapportAcheveDto FromModel(TbrapportAcheve model)
        {
            return new TbrapportAcheveDto()
            {
                Idrapport = model.Idrapport, 
                Date = model.Date, 
                Heure = model.Heure, 
                IdExpert = model.IdExpert, 
                IdDoss = model.IdDoss, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public TbrapportAcheve ToModel()
        {
            return new TbrapportAcheve()
            {
                Idrapport = Idrapport, 
                Date = Date, 
                Heure = Heure, 
                IdExpert = IdExpert, 
                IdDoss = IdDoss, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}