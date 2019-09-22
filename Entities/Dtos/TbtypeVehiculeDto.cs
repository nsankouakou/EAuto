using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtypeVehiculeDto
    {
        public decimal Idtypveh { get; set; }

        public string Libtypveh { get; set; }

        public decimal Idmodel { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmodeleDto IdmodelNavigation { get; set; }

        public ICollection<Tbvehicule> Tbvehicule { get; set; }

        public static TbtypeVehiculeDto FromModel(TbtypeVehicule model)
        {
            return new TbtypeVehiculeDto()
            {
                Idtypveh = model.Idtypveh, 
                Libtypveh = model.Libtypveh, 
                Idmodel = model.Idmodel, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdmodelNavigation = TbmodeleDto.FromModel(model.IdmodelNavigation), 
                Tbvehicule = model.Tbvehicule, 
            }; 
        }

        public TbtypeVehicule ToModel()
        {
            return new TbtypeVehicule()
            {
                Idtypveh = Idtypveh, 
                Libtypveh = Libtypveh, 
                Idmodel = Idmodel, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdmodelNavigation = IdmodelNavigation.ToModel(), 
                Tbvehicule = Tbvehicule, 
            }; 
        }
    }
}