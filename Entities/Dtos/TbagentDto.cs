using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbagentDto
    {
        public decimal AgentId { get; set; }

        public string Matricule { get; set; }

        public string Nom { get; set; }

        public string Prenoms { get; set; }

        public string Password { get; set; }

        public int? Categorie { get; set; }

        public string Telephone { get; set; }

        public string Lettreaffectee { get; set; }

        public decimal? Fonctionid { get; set; }

        public decimal? IdUser { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public FonctionDto Fonction { get; set; }

        public ICollection<Tbuser> Tbuser { get; set; }

        public static TbagentDto FromModel(Tbagent model)
        {
            return new TbagentDto()
            {
                AgentId = model.AgentId, 
                Matricule = model.Matricule, 
                Nom = model.Nom, 
                Prenoms = model.Prenoms, 
                Password = model.Password, 
                Categorie = model.Categorie, 
                Telephone = model.Telephone, 
                Lettreaffectee = model.Lettreaffectee, 
                Fonctionid = model.Fonctionid, 
                IdUser = model.IdUser, 
                DateCreation = model.DateCreation, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                Fonction = FonctionDto.FromModel(model.Fonction), 
                Tbuser = model.Tbuser, 
            }; 
        }

        public Tbagent ToModel()
        {
            return new Tbagent()
            {
                AgentId = AgentId, 
                Matricule = Matricule, 
                Nom = Nom, 
                Prenoms = Prenoms, 
                Password = Password, 
                Categorie = Categorie, 
                Telephone = Telephone, 
                Lettreaffectee = Lettreaffectee, 
                Fonctionid = Fonctionid, 
                IdUser = IdUser, 
                DateCreation = DateCreation, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                Fonction = Fonction.ToModel(), 
                Tbuser = Tbuser, 
            }; 
        }
    }
}