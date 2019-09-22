using System;

namespace Entities.Models.Dtos
{
    public class TbhabilitationDto
    {
        public decimal MenuId { get; set; }

        public decimal ProfilId { get; set; }

        public int Droit { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbmenuDto Menu { get; set; }

        public TbprofilDto Profil { get; set; }

        public static TbhabilitationDto FromModel(Tbhabilitation model)
        {
            return new TbhabilitationDto()
            {
                MenuId = model.MenuId, 
                ProfilId = model.ProfilId, 
                Droit = model.Droit, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Menu = TbmenuDto.FromModel(model.Menu), 
                Profil = TbprofilDto.FromModel(model.Profil), 
            }; 
        }

        public Tbhabilitation ToModel()
        {
            return new Tbhabilitation()
            {
                MenuId = MenuId, 
                ProfilId = ProfilId, 
                Droit = Droit, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Menu = Menu.ToModel(), 
                Profil = Profil.ToModel(), 
            }; 
        }
    }
}