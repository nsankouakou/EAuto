using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbtypeValeurDto
    {
        public decimal Idtypval { get; set; }

        public string Libtypval { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public static TbtypeValeurDto FromModel(TbtypeValeur model)
        {
            return new TbtypeValeurDto()
            {
                Idtypval = model.Idtypval, 
                Libtypval = model.Libtypval, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public TbtypeValeur ToModel()
        {
            return new TbtypeValeur()
            {
                Idtypval = Idtypval, 
                Libtypval = Libtypval, 
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