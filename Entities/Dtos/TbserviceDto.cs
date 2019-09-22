using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbserviceDto
    {
        public decimal IdServ { get; set; }

        public string LibServ { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbspecialite> Tbspecialite { get; set; }

        public static TbserviceDto FromModel(Tbservice model)
        {
            return new TbserviceDto()
            {
                IdServ = model.IdServ, 
                LibServ = model.LibServ, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbspecialite = model.Tbspecialite, 
            }; 
        }

        public Tbservice ToModel()
        {
            return new Tbservice()
            {
                IdServ = IdServ, 
                LibServ = LibServ, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbspecialite = Tbspecialite, 
            }; 
        }
    }
}