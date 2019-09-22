using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbcouleurDto
    {
        public decimal IdCouleur { get; set; }

        public string LibCouleur { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbcouleurDto FromModel(Tbcouleur model)
        {
            return new TbcouleurDto()
            {
                IdCouleur = model.IdCouleur, 
                LibCouleur = model.LibCouleur, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbcouleur ToModel()
        {
            return new Tbcouleur()
            {
                IdCouleur = IdCouleur, 
                LibCouleur = LibCouleur, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}