using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbmodeReglementDto
    {
        public decimal IdModeReglmnt { get; set; }

        public string LibModReglmnt { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbavance> Tbavance { get; set; }

        public ICollection<Tbreglement> Tbreglement { get; set; }

        public ICollection<Tbrembourssement> Tbrembourssement { get; set; }

        public static TbmodeReglementDto FromModel(TbmodeReglement model)
        {
            return new TbmodeReglementDto()
            {
                IdModeReglmnt = model.IdModeReglmnt, 
                LibModReglmnt = model.LibModReglmnt, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbavance = model.Tbavance, 
                Tbreglement = model.Tbreglement, 
                Tbrembourssement = model.Tbrembourssement, 
            }; 
        }

        public TbmodeReglement ToModel()
        {
            return new TbmodeReglement()
            {
                IdModeReglmnt = IdModeReglmnt, 
                LibModReglmnt = LibModReglmnt, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbavance = Tbavance, 
                Tbreglement = Tbreglement, 
                Tbrembourssement = Tbrembourssement, 
            }; 
        }
    }
}