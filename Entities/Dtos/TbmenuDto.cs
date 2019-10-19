using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbmenuDto
    {
        public decimal MenuId { get; set; }

        public decimal? IdParent { get; set; }

        public string LibelleMenu { get; set; }

        public string Action { get; set; }

        public int? OrdreMenu { get; set; }

        public bool? Bactif { get; set; }

        public string Controlleur { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }

        public string Description { get; set; }

        public string Token { get; set; }


        public ICollection<Tbhabilitation> Tbhabilitation { get; set; }

        public static TbmenuDto FromModel(Tbmenu model)
        {
            return new TbmenuDto()
            {
                MenuId = model.MenuId, 
                IdParent = model.IdParent, 
                LibelleMenu = model.LibelleMenu, 
                Action = model.Action, 
                OrdreMenu = model.OrdreMenu, 
                Bactif = model.Bactif, 
                Controlleur = model.Controlleur, 
                Url = model.Url, 
                Icon = model.Icon, 
                Description = model.Description, 
                Tbhabilitation = model.Tbhabilitation, 
            }; 
        }

        public Tbmenu ToModel()
        {
            return new Tbmenu()
            {
                MenuId = MenuId, 
                IdParent = IdParent, 
                LibelleMenu = LibelleMenu, 
                Action = Action, 
                OrdreMenu = OrdreMenu, 
                Bactif = Bactif, 
                Controlleur = Controlleur, 
                Url = Url, 
                Icon = Icon, 
                Description = Description, 
                Tbhabilitation = Tbhabilitation, 
            }; 
        }
    }
}