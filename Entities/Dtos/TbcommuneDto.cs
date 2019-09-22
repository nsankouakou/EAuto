using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbcommuneDto
    {
        public decimal IdComm { get; set; }

        public string NomComm { get; set; }

        public decimal Deplacement { get; set; }

        public decimal IdVille { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbvilleDto IdVilleNavigation { get; set; }

        public ICollection<Tbdossier> Tbdossier { get; set; }

        public static TbcommuneDto FromModel(Tbcommune model)
        {
            return new TbcommuneDto()
            {
                IdComm = model.IdComm, 
                NomComm = model.NomComm, 
                Deplacement = model.Deplacement, 
                IdVille = model.IdVille, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdVilleNavigation = TbvilleDto.FromModel(model.IdVilleNavigation), 
                Tbdossier = model.Tbdossier, 
            }; 
        }

        public Tbcommune ToModel()
        {
            return new Tbcommune()
            {
                IdComm = IdComm, 
                NomComm = NomComm, 
                Deplacement = Deplacement, 
                IdVille = IdVille, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdVilleNavigation = IdVilleNavigation.ToModel(), 
                Tbdossier = Tbdossier, 
            }; 
        }
    }
}