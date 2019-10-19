using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbuserDto
    {
        public decimal IdUser { get; set; }

        public string CodUser { get; set; }

        public string LoginUser { get; set; }

        public string NomPrenUser { get; set; }

        public string NumTel { get; set; }

        public string SexUser { get; set; }

        public string AdrUser { get; set; }

        public string Password { get; set; }

        public DateTime DatFonc { get; set; }

        public decimal IdTypeUser { get; set; }

        public decimal ProfilId { get; set; }

        public decimal? AgentId { get; set; }

        public DateTime? DateDebutValidite { get; set; }

        public DateTime? DateFinValidite { get; set; }

        public DateTime? DateDerniereModificationPassword { get; set; }

        public bool? InitUserPassword { get; set; }

        public short? NbreEchecsOuvertureSession { get; set; }

        public DateTime? DateDerniereConnexion { get; set; }

        public bool? DerniereConnexionReussie { get; set; }

        public DateTime? DateDernierVerrouillage { get; set; }

        public string Email { get; set; }

        public bool? StatutSession { get; set; }

        public string Hostname { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public DateTime? DateCreation { get; set; }

        public string Matricule { get; set; }

        public string Token { get; set; }


        public TbagentDto Agent { get; set; }

        public TbtypeUserDto IdTypeUserNavigation { get; set; }

        public TbprofilDto Profil { get; set; }

        public ICollection<TbspecialiteUser> TbspecialiteUser { get; set; }

        public ICollection<TbuserDossier> TbuserDossier { get; set; }

        public static TbuserDto FromModel(Tbuser model)
        {
            return new TbuserDto()
            {
                IdUser = model.IdUser, 
                CodUser = model.CodUser, 
                LoginUser = model.LoginUser, 
                NomPrenUser = model.NomPrenUser, 
                NumTel = model.NumTel, 
                SexUser = model.SexUser, 
                AdrUser = model.AdrUser, 
                Password = model.Password, 
                DatFonc = model.DatFonc, 
                IdTypeUser = model.IdTypeUser, 
                ProfilId = model.ProfilId, 
                AgentId = model.AgentId, 
                DateDebutValidite = model.DateDebutValidite, 
                DateFinValidite = model.DateFinValidite, 
                DateDerniereModificationPassword = model.DateDerniereModificationPassword, 
                InitUserPassword = model.InitUserPassword, 
                NbreEchecsOuvertureSession = model.NbreEchecsOuvertureSession, 
                DateDerniereConnexion = model.DateDerniereConnexion, 
                DerniereConnexionReussie = model.DerniereConnexionReussie, 
                DateDernierVerrouillage = model.DateDernierVerrouillage, 
                Email = model.Email, 
                StatutSession = model.StatutSession, 
                Hostname = model.Hostname, 
                ModifieLe = model.ModifieLe, 
                ModifiePar = model.ModifiePar, 
                StateCode = model.StateCode, 
                StatusCode = model.StatusCode, 
                DateCreation = model.DateCreation, 
                Agent = TbagentDto.FromModel(model.Agent), 
                IdTypeUserNavigation = TbtypeUserDto.FromModel(model.IdTypeUserNavigation), 
                Profil = TbprofilDto.FromModel(model.Profil), 
                TbspecialiteUser = model.TbspecialiteUser, 
                TbuserDossier = model.TbuserDossier, 
            }; 
        }

        public Tbuser ToModel()
        {
            return new Tbuser()
            {
                IdUser = IdUser, 
                CodUser = CodUser, 
                LoginUser = LoginUser, 
                NomPrenUser = NomPrenUser, 
                NumTel = NumTel, 
                SexUser = SexUser, 
                AdrUser = AdrUser, 
                Password = Password, 
                DatFonc = DatFonc, 
                IdTypeUser = IdTypeUser, 
                ProfilId = ProfilId, 
                AgentId = AgentId, 
                DateDebutValidite = DateDebutValidite, 
                DateFinValidite = DateFinValidite, 
                DateDerniereModificationPassword = DateDerniereModificationPassword, 
                InitUserPassword = InitUserPassword, 
                NbreEchecsOuvertureSession = NbreEchecsOuvertureSession, 
                DateDerniereConnexion = DateDerniereConnexion, 
                DerniereConnexionReussie = DerniereConnexionReussie, 
                DateDernierVerrouillage = DateDernierVerrouillage, 
                Email = Email, 
                StatutSession = StatutSession, 
                Hostname = Hostname, 
                ModifieLe = ModifieLe, 
                ModifiePar = ModifiePar, 
                StateCode = StateCode, 
                StatusCode = StatusCode, 
                DateCreation = DateCreation, 
                Agent = Agent.ToModel(), 
                IdTypeUserNavigation = IdTypeUserNavigation.ToModel(), 
                Profil = Profil.ToModel(), 
                TbspecialiteUser = TbspecialiteUser, 
                TbuserDossier = TbuserDossier, 
            }; 
        }
    }
}