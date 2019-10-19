using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class ExpertiseVehiculeVoleModel
    {
        public decimal IdExpert { get; set; }

        public string NumExpert { get; set; }

        public string Kilometrage { get; set; }

        public string VuAvT { get; set; }

        public string VuPdtT { get; set; }

        public string VuApT { get; set; }

        public string Duree { get; set; }

        public string LieuVisite { get; set; }

        public string ValeurNeuve { get; set; }

        public string Depreciation { get; set; }

        public string ValeurVenale { get; set; }

        public string Avd { get; set; }

        public string Avgp { get; set; }

        public string Ard { get; set; }

        public string Arg { get; set; }

        public bool? Indep { get; set; }

        public bool? Reseau { get; set; }

        public bool? Hreseau { get; set; }

        public bool? EuxMeme { get; set; }

        public bool? Inconnu { get; set; }

        public bool? NonProf { get; set; }

        public decimal? IdVeh { get; set; }

        public decimal? IdGara { get; set; }

        public decimal? IdEtatEntretien { get; set; }

        public decimal IdDoss { get; set; }

        public decimal? Idtypnote { get; set; }

        public DateTime? DatEnreg { get; set; }

        public DateTime? HeurEnreg { get; set; }

        public string Typnote { get; set; }

        public decimal? Numero { get; set; }

        public decimal? IdUser { get; set; }

        public bool Epave { get; set; }

        public decimal? ValeurSauvetage { get; set; }

        public bool? EconoIrrep { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? ModifieLe { get; set; }

        public decimal? ModifiePar { get; set; }

        public int? StateCode { get; set; }

        public int? StatusCode { get; set; }

        public List<TbexpertisePointChocDto> ExpertisePointChocs { get; set; }

        public List<TbpointChocDto> PointChocs { get; set; }

        public string Token { get; set; }
    }
}
