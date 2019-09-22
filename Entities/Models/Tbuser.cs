using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbuser
    {
        public Tbuser()
        {
            TbspecialiteUser = new HashSet<TbspecialiteUser>();
            TbuserDossier = new HashSet<TbuserDossier>();
        }

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

        public virtual Tbagent Agent { get; set; }
        public virtual TbtypeUser IdTypeUserNavigation { get; set; }
        public virtual Tbprofil Profil { get; set; }
        public virtual ICollection<TbspecialiteUser> TbspecialiteUser { get; set; }
        public virtual ICollection<TbuserDossier> TbuserDossier { get; set; }
    }
}
