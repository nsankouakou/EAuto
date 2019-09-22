using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertisePointChocDto
    {
        public decimal Idexpert { get; set; }

        public decimal Idpointchoc { get; set; }

        public string IdFourn { get; set; }

        public decimal Ligne { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdexpertNavigation { get; set; }

        public TbpointChocDto IdpointchocNavigation { get; set; }

        public static TbexpertisePointChocDto FromModel(TbexpertisePointChoc model)
        {
            return new TbexpertisePointChocDto()
            {
                Idexpert = model.Idexpert, 
                Idpointchoc = model.Idpointchoc, 
                IdFourn = model.IdFourn, 
                Ligne = model.Ligne, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
                IdpointchocNavigation = TbpointChocDto.FromModel(model.IdpointchocNavigation), 
            }; 
        }

        public TbexpertisePointChoc ToModel()
        {
            return new TbexpertisePointChoc()
            {
                Idexpert = Idexpert, 
                Idpointchoc = Idpointchoc, 
                IdFourn = IdFourn, 
                Ligne = Ligne, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
                IdpointchocNavigation = IdpointchocNavigation.ToModel(), 
            }; 
        }
    }
}