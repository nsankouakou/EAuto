using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbenergieDto
    {
        public decimal IdEnergie { get; set; }

        public string LibEnergie { get; set; }

        public string IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbenergieDto FromModel(Tbenergie model)
        {
            return new TbenergieDto()
            {
                IdEnergie = model.IdEnergie, 
                LibEnergie = model.LibEnergie, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public Tbenergie ToModel()
        {
            return new Tbenergie()
            {
                IdEnergie = IdEnergie, 
                LibEnergie = LibEnergie, 
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