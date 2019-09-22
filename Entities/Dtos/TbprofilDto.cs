using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbprofilDto
    {
        public decimal ProfilId { get; set; }

        public string Code { get; set; }

        public string Libelle { get; set; }

        public string Description { get; set; }

        public DateTime? Datedebut { get; set; }

        public DateTime? Datefin { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }


        public ICollection<Tbhabilitation> Tbhabilitation { get; set; }

        public ICollection<Tbuser> Tbuser { get; set; }

        public static TbprofilDto FromModel(Tbprofil model)
        {
            return new TbprofilDto()
            {
                ProfilId = model.ProfilId, 
                Code = model.Code, 
                Libelle = model.Libelle, 
                Description = model.Description, 
                Datedebut = model.Datedebut, 
                Datefin = model.Datefin, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Tbhabilitation = model.Tbhabilitation, 
                Tbuser = model.Tbuser, 
            }; 
        }

        public Tbprofil ToModel()
        {
            return new Tbprofil()
            {
                ProfilId = ProfilId, 
                Code = Code, 
                Libelle = Libelle, 
                Description = Description, 
                Datedebut = Datedebut, 
                Datefin = Datefin, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Tbhabilitation = Tbhabilitation, 
                Tbuser = Tbuser, 
            }; 
        }
    }
}