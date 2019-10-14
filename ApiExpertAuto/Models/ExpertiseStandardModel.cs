using Entities.Models;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class ExpertiseStandardModel
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

        public List<TbexpertisePointChocDto> PointChocs { get; set; }

        public string Token { get; set; }


        public static TbexpertiseDto FromModel(Tbexpertise model)
        {
            return new TbexpertiseDto()
            {
                IdExpert = model.IdExpert,
                NumExpert = model.NumExpert,
                Kilometrage = model.Kilometrage,
                VuAvT = model.VuAvT,
                VuPdtT = model.VuPdtT,
                VuApT = model.VuApT,
                Duree = model.Duree,
                LieuVisite = model.LieuVisite,
                ValeurNeuve = model.ValeurNeuve,
                Depreciation = model.Depreciation,
                ValeurVenale = model.ValeurVenale,
                Avd = model.Avd,
                Avgp = model.Avgp,
                Ard = model.Ard,
                Arg = model.Arg,
                Indep = model.Indep,
                Reseau = model.Reseau,
                Hreseau = model.Hreseau,
                EuxMeme = model.EuxMeme,
                Inconnu = model.Inconnu,
                NonProf = model.NonProf,
                IdVeh = model.IdVeh,
                IdGara = model.IdGara,
                IdEtatEntretien = model.IdEtatEntretien,
                IdDoss = model.IdDoss,
                Idtypnote = model.Idtypnote,
                DatEnreg = model.DatEnreg,
                HeurEnreg = model.HeurEnreg,
                Typnote = model.Typnote,
                Numero = model.Numero,
                IdUser = model.IdUser,
                Epave = model.Epave,
                ValeurSauvetage = model.ValeurSauvetage,
                EconoIrrep = model.EconoIrrep,
                DateCreation = model.DateCreation,
                ModifieLe = model.ModifieLe,
                ModifiePar = model.ModifiePar,
                StateCode = model.StateCode,
                StatusCode = model.StatusCode
            };
        }

        public Tbexpertise ToModel()
        {
            return new Tbexpertise()
            {
                IdExpert = IdExpert,
                NumExpert = NumExpert,
                Kilometrage = Kilometrage,
                VuAvT = VuAvT,
                VuPdtT = VuPdtT,
                VuApT = VuApT,
                Duree = Duree,
                LieuVisite = LieuVisite,
                ValeurNeuve = ValeurNeuve,
                Depreciation = Depreciation,
                ValeurVenale = ValeurVenale,
                Avd = Avd,
                Avgp = Avgp,
                Ard = Ard,
                Arg = Arg,
                Indep = Indep,
                Reseau = Reseau,
                Hreseau = Hreseau,
                EuxMeme = EuxMeme,
                Inconnu = Inconnu,
                NonProf = NonProf,
                IdVeh = IdVeh,
                IdGara = IdGara,
                IdEtatEntretien = IdEtatEntretien,
                IdDoss = IdDoss,
                Idtypnote = Idtypnote,
                DatEnreg = DatEnreg,
                HeurEnreg = HeurEnreg,
                Typnote = Typnote,
                Numero = Numero,
                IdUser = IdUser,
                Epave = Epave,
                ValeurSauvetage = ValeurSauvetage,
                EconoIrrep = EconoIrrep,
                DateCreation = DateCreation,
                ModifieLe = ModifieLe,
                ModifiePar = ModifiePar,
                StateCode = StateCode,
                StatusCode = StatusCode
                
            };
        }

    }
}
