using System;

namespace Entities.Models.Dtos
{
    public class TbtypeUserDroitDto
    {
        public decimal IdDroit { get; set; }

        public decimal IdTypeUser { get; set; }

        public DateTime Date { get; set; }

        public DateTime Heure { get; set; }

        public decimal? Indexer { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public static TbtypeUserDroitDto FromModel(TbtypeUserDroit model)
        {
            return new TbtypeUserDroitDto()
            {
                IdDroit = model.IdDroit, 
                IdTypeUser = model.IdTypeUser, 
                Date = model.Date, 
                Heure = model.Heure, 
                Indexer = model.Indexer, 
                IdUser = model.IdUser, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public TbtypeUserDroit ToModel()
        {
            return new TbtypeUserDroit()
            {
                IdDroit = IdDroit, 
                IdTypeUser = IdTypeUser, 
                Date = Date, 
                Heure = Heure, 
                Indexer = Indexer, 
                IdUser = IdUser, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}