using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbmodeleDto
    {
        public decimal Idmodel { get; set; }

        public string Libmodel { get; set; }

        public decimal Idmarq { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmarqueDto IdmarqNavigation { get; set; }

        public ICollection<TbtypeVehicule> TbtypeVehicule { get; set; }

        public static TbmodeleDto FromModel(Tbmodele model)
        {
            return new TbmodeleDto()
            {
                Idmodel = model.Idmodel, 
                Libmodel = model.Libmodel, 
                Idmarq = model.Idmarq, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdmarqNavigation = TbmarqueDto.FromModel(model.IdmarqNavigation), 
                TbtypeVehicule = model.TbtypeVehicule, 
            }; 
        }

        public Tbmodele ToModel()
        {
            return new Tbmodele()
            {
                Idmodel = Idmodel, 
                Libmodel = Libmodel, 
                Idmarq = Idmarq, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdmarqNavigation = IdmarqNavigation.ToModel(), 
                TbtypeVehicule = TbtypeVehicule, 
            }; 
        }
    }
}