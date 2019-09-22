using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbvilleDto
    {
        public decimal IdVille { get; set; }

        public string NomVille { get; set; }

        public decimal Distance { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }



        public ICollection<Tbcommune> Tbcommune { get; set; }

        public static TbvilleDto FromModel(Tbville model)
        {
            return new TbvilleDto()
            {
                IdVille = model.IdVille, 
                NomVille = model.NomVille, 
                Distance = model.Distance, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbcommune = model.Tbcommune, 
            }; 
        }

        public Tbville ToModel()
        {
            return new Tbville()
            {
                IdVille = IdVille, 
                NomVille = NomVille, 
                Distance = Distance, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbcommune = Tbcommune, 
            }; 
        }
    }
}