using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtypeTravauxDto
    {
        public decimal Idtyptrav { get; set; }

        public string Libtyptrav { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<TbtypTravauxMainOuvre> TbtypTravauxMainOuvre { get; set; }

        public static TbtypeTravauxDto FromModel(TbtypeTravaux model)
        {
            return new TbtypeTravauxDto()
            {
                Idtyptrav = model.Idtyptrav, 
                Libtyptrav = model.Libtyptrav, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                TbtypTravauxMainOuvre = model.TbtypTravauxMainOuvre, 
            }; 
        }

        public TbtypeTravaux ToModel()
        {
            return new TbtypeTravaux()
            {
                Idtyptrav = Idtyptrav, 
                Libtyptrav = Libtyptrav, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                TbtypTravauxMainOuvre = TbtypTravauxMainOuvre, 
            }; 
        }
    }
}