using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class FonctionDto
    {
        public decimal Fonctionid { get; set; }

        public string Code { get; set; }

        public string Fonctionlibelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<Tbagent> Tbagent { get; set; }

        public static FonctionDto FromModel(Fonction model)
        {
            return new FonctionDto()
            {
                Fonctionid = model.Fonctionid, 
                Code = model.Code, 
                Fonctionlibelle = model.Fonctionlibelle, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbagent = model.Tbagent, 
            }; 
        }

        public Fonction ToModel()
        {
            return new Fonction()
            {
                Fonctionid = Fonctionid, 
                Code = Code, 
                Fonctionlibelle = Fonctionlibelle, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbagent = Tbagent, 
            }; 
        }
    }
}