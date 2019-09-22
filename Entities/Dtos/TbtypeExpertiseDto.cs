using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbtypeExpertiseDto
    {
        public decimal IdTypExpert { get; set; }

        public string LibTypExpert { get; set; }

        public decimal? MtPrejudiceHt { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbdossier> Tbdossier { get; set; }

        public static TbtypeExpertiseDto FromModel(TbtypeExpertise model)
        {
            return new TbtypeExpertiseDto()
            {
                IdTypExpert = model.IdTypExpert, 
                LibTypExpert = model.LibTypExpert, 
                MtPrejudiceHt = model.MtPrejudiceHt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbdossier = model.Tbdossier, 
            }; 
        }

        public TbtypeExpertise ToModel()
        {
            return new TbtypeExpertise()
            {
                IdTypExpert = IdTypExpert, 
                LibTypExpert = LibTypExpert, 
                MtPrejudiceHt = MtPrejudiceHt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbdossier = Tbdossier, 
            }; 
        }
    }
}