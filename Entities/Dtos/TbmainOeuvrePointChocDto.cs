using System;

namespace Entities.Models.Dtos
{
    public class TbmainOeuvrePointChocDto
    {
        public decimal Idpointchoc { get; set; }

        public decimal IdMo { get; set; }

        public DateTime Datetrav { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmainOeuvreDto IdMoNavigation { get; set; }

        public TbpointChocDto IdpointchocNavigation { get; set; }

        public static TbmainOeuvrePointChocDto FromModel(TbmainOeuvrePointChoc model)
        {
            return new TbmainOeuvrePointChocDto()
            {
                Idpointchoc = model.Idpointchoc, 
                IdMo = model.IdMo, 
                Datetrav = model.Datetrav, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdMoNavigation = TbmainOeuvreDto.FromModel(model.IdMoNavigation), 
                IdpointchocNavigation = TbpointChocDto.FromModel(model.IdpointchocNavigation), 
            }; 
        }

        public TbmainOeuvrePointChoc ToModel()
        {
            return new TbmainOeuvrePointChoc()
            {
                Idpointchoc = Idpointchoc, 
                IdMo = IdMo, 
                Datetrav = Datetrav, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdMoNavigation = IdMoNavigation.ToModel(), 
                IdpointchocNavigation = IdpointchocNavigation.ToModel(), 
            }; 
        }
    }
}