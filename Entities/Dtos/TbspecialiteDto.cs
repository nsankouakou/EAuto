using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbspecialiteDto
    {
        public decimal IdSpec { get; set; }

        public string LibSepec { get; set; }

        public decimal IdServ { get; set; }

        public decimal IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public TbserviceDto IdServNavigation { get; set; }

        public ICollection<TbspecialiteUser> TbspecialiteUser { get; set; }

        public static TbspecialiteDto FromModel(Tbspecialite model)
        {
            return new TbspecialiteDto()
            {
                IdSpec = model.IdSpec, 
                LibSepec = model.LibSepec, 
                IdServ = model.IdServ, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                IdServNavigation = TbserviceDto.FromModel(model.IdServNavigation), 
                TbspecialiteUser = model.TbspecialiteUser, 
            }; 
        }

        public Tbspecialite ToModel()
        {
            return new Tbspecialite()
            {
                IdSpec = IdSpec, 
                LibSepec = LibSepec, 
                IdServ = IdServ, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                IdServNavigation = IdServNavigation.ToModel(), 
                TbspecialiteUser = TbspecialiteUser, 
            }; 
        }
    }
}