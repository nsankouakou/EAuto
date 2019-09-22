using System;

namespace Entities.Models.Dtos
{
    public class TbexpertiseTravauxExterieurPointChocDto
    {
        public decimal Idpointchoc { get; set; }

        public decimal Idautrecharg { get; set; }

        public decimal Mtautrecharge { get; set; }

        public decimal? Dep { get; set; }

        public decimal IdExpert { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbexpertiseDto IdExpertNavigation { get; set; }

        public TbtravauxExterieurDto IdautrechargNavigation { get; set; }

        public TbpointChocDto IdpointchocNavigation { get; set; }

        public static TbexpertiseTravauxExterieurPointChocDto FromModel(TbexpertiseTravauxExterieurPointChoc model)
        {
            return new TbexpertiseTravauxExterieurPointChocDto()
            {
                Idpointchoc = model.Idpointchoc, 
                Idautrecharg = model.Idautrecharg, 
                Mtautrecharge = model.Mtautrecharge, 
                Dep = model.Dep, 
                IdExpert = model.IdExpert, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdExpertNavigation = TbexpertiseDto.FromModel(model.IdExpertNavigation), 
                IdautrechargNavigation = TbtravauxExterieurDto.FromModel(model.IdautrechargNavigation), 
                IdpointchocNavigation = TbpointChocDto.FromModel(model.IdpointchocNavigation), 
            }; 
        }

        public TbexpertiseTravauxExterieurPointChoc ToModel()
        {
            return new TbexpertiseTravauxExterieurPointChoc()
            {
                Idpointchoc = Idpointchoc, 
                Idautrecharg = Idautrecharg, 
                Mtautrecharge = Mtautrecharge, 
                Dep = Dep, 
                IdExpert = IdExpert, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdExpertNavigation = IdExpertNavigation.ToModel(), 
                IdautrechargNavigation = IdautrechargNavigation.ToModel(), 
                IdpointchocNavigation = IdpointchocNavigation.ToModel(), 
            }; 
        }
    }
}