using System;
using System.Linq;

namespace Entities.Models.Dtos
{
    public class TbexpertiseRubriqueConstatationPointChocDto
    {
        public decimal Idexpert { get; set; }

        public decimal IdRubConst { get; set; }

        public decimal Idpointchoc { get; set; }

        public string Constat { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbrubriqueConstatationDto IdRubConstNavigation { get; set; }

        public TbexpertiseDto IdexpertNavigation { get; set; }

        public TbpointChocDto IdpointchocNavigation { get; set; }

        public static TbexpertiseRubriqueConstatationPointChocDto FromModel(TbexpertiseRubriqueConstatationPointChoc model)
        {
            return new TbexpertiseRubriqueConstatationPointChocDto()
            {
                Idexpert = model.Idexpert, 
                IdRubConst = model.IdRubConst, 
                Idpointchoc = model.Idpointchoc, 
                Constat = model.Constat, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdRubConstNavigation = TbrubriqueConstatationDto.FromModel(model.IdRubConstNavigation), 
                IdexpertNavigation = TbexpertiseDto.FromModel(model.IdexpertNavigation), 
                IdpointchocNavigation = TbpointChocDto.FromModel(model.IdpointchocNavigation), 
            }; 
        }

        public TbexpertiseRubriqueConstatationPointChoc ToModel()
        {
            return new TbexpertiseRubriqueConstatationPointChoc()
            {
                Idexpert = Idexpert, 
                IdRubConst = IdRubConst, 
                Idpointchoc = Idpointchoc, 
                Constat = Constat, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdRubConstNavigation = IdRubConstNavigation.ToModel(), 
                IdexpertNavigation = IdexpertNavigation.ToModel(), 
                IdpointchocNavigation = IdpointchocNavigation.ToModel(), 
            }; 
        }
    }
}