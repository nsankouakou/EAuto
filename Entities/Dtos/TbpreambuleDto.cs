using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbpreambuleDto
    {
        public decimal Idpreamb { get; set; }

        public string Libpreamb { get; set; }

        public decimal IdExpert { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdExpertNavigation { get; set; }

        public static TbpreambuleDto FromModel(Tbpreambule model)
        {
            return new TbpreambuleDto()
            {
                Idpreamb = model.Idpreamb, 
                Libpreamb = model.Libpreamb, 
                IdExpert = model.IdExpert, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
            }; 
        }

        public Tbpreambule ToModel()
        {
            return new Tbpreambule()
            {
                Idpreamb = Idpreamb, 
                Libpreamb = Libpreamb, 
                IdExpert = IdExpert, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdExpertNavigation = IdExpertNavigation.ToModel(), 
            }; 
        }
    }
}