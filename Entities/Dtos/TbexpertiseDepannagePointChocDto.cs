using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseDepannagePointChocDto
    {
        public decimal IdExpert { get; set; }

        public decimal IdPointChoc { get; set; }

        public decimal IdDepann { get; set; }

        public decimal Montant { get; set; }

        public string LibelleDepann { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public TbexpertiseDto IdExpertNavigation { get; set; }

        public static TbexpertiseDepannagePointChocDto FromModel(TbexpertiseDepannagePointChoc model)
        {
            return new TbexpertiseDepannagePointChocDto()
            {
                IdExpert = model.IdExpert, 
                IdPointChoc = model.IdPointChoc, 
                IdDepann = model.IdDepann, 
                Montant = model.Montant, 
                LibelleDepann = model.LibelleDepann, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
            }; 
        }

        public TbexpertiseDepannagePointChoc ToModel()
        {
            return new TbexpertiseDepannagePointChoc()
            {
                IdExpert = IdExpert, 
                IdPointChoc = IdPointChoc, 
                IdDepann = IdDepann, 
                Montant = Montant, 
                LibelleDepann = LibelleDepann, 
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