using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbdiscussionDto
    {
        public decimal Iddiscus { get; set; }

        public string Libdiscus { get; set; }

        public decimal Idexpert { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbexpertiseDto IdexpertNavigation { get; set; }

        public static TbdiscussionDto FromModel(Tbdiscussion model)
        {
            return new TbdiscussionDto()
            {
                Iddiscus = model.Iddiscus, 
                Libdiscus = model.Libdiscus, 
                Idexpert = model.Idexpert, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
            }; 
        }

        public Tbdiscussion ToModel()
        {
            return new Tbdiscussion()
            {
                Iddiscus = Iddiscus, 
                Libdiscus = Libdiscus, 
                Idexpert = Idexpert, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
            }; 
        }
    }
}