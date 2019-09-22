using System;
using System.Linq;
using System.Collections.Generic;

namespace Entities.Models.Dtos
{
    public class TbexpertiseDto
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

        public string Token { get; set; }

        public TbdossierDto IdDossNavigation { get; set; }

        public TbgarageDto IdGaraNavigation { get; set; }

        public TbvehiculeDto IdVehNavigation { get; set; }

        public TbtypeNoteDto IdtypnoteNavigation { get; set; }

        public ICollection<Tbconclusion> Tbconclusion { get; set; }

        public ICollection<Tbdiscussion> Tbdiscussion { get; set; }

        public ICollection<TbexpertiseDepannagePointChoc> TbexpertiseDepannagePointChoc { get; set; }

        public ICollection<TbexpertiseEtatRapport> TbexpertiseEtatRapport { get; set; }

        public ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }

        public ICollection<TbexpertisePointChoc> TbexpertisePointChoc { get; set; }

        public ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }

        public ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }

        public ICollection<TbexpertiseRubriqueEstimation> TbexpertiseRubriqueEstimation { get; set; }

        public ICollection<TbexpertiseRubriqueMo> TbexpertiseRubriqueMo { get; set; }

        public ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }

        public ICollection<TbexpertiseTypeNote> TbexpertiseTypeNote { get; set; }

        public ICollection<Tbphoto> Tbphoto { get; set; }

        public ICollection<Tbpreambule> Tbpreambule { get; set; }

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
                StatusCode = model.StatusCode, 
                IdDossNavigation = TbdossierDto.FromModel(model.IdDossNavigation), 
                IdGaraNavigation = TbgarageDto.FromModel(model.IdGaraNavigation), 
                IdVehNavigation = TbvehiculeDto.FromModel(model.IdVehNavigation), 
                IdtypnoteNavigation = TbtypeNoteDto.FromModel(model.IdtypnoteNavigation), 
                Tbconclusion = model.Tbconclusion, 
                Tbdiscussion = model.Tbdiscussion, 
                TbexpertiseDepannagePointChoc = model.TbexpertiseDepannagePointChoc, 
                TbexpertiseEtatRapport = model.TbexpertiseEtatRapport, 
                TbexpertiseFourniturePointChoc = model.TbexpertiseFourniturePointChoc, 
                TbexpertisePointChoc = model.TbexpertisePointChoc, 
                TbexpertisePourRecousPointChoc = model.TbexpertisePourRecousPointChoc, 
                TbexpertiseRubriqueConstatationPointChoc = model.TbexpertiseRubriqueConstatationPointChoc, 
                TbexpertiseRubriqueEstimation = model.TbexpertiseRubriqueEstimation, 
                TbexpertiseRubriqueMo = model.TbexpertiseRubriqueMo, 
                TbexpertiseTravauxExterieurPointChoc = model.TbexpertiseTravauxExterieurPointChoc, 
                TbexpertiseTypeNote = model.TbexpertiseTypeNote, 
                Tbphoto = model.Tbphoto, 
                Tbpreambule = model.Tbpreambule, 
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
                StatusCode = StatusCode, 
                IdDossNavigation = IdDossNavigation.ToModel(), 
                IdGaraNavigation = IdGaraNavigation.ToModel(), 
                IdVehNavigation = IdVehNavigation.ToModel(), 
                IdtypnoteNavigation = IdtypnoteNavigation.ToModel(), 
                Tbconclusion = Tbconclusion, 
                Tbdiscussion = Tbdiscussion, 
                TbexpertiseDepannagePointChoc = TbexpertiseDepannagePointChoc, 
                TbexpertiseEtatRapport = TbexpertiseEtatRapport, 
                TbexpertiseFourniturePointChoc = TbexpertiseFourniturePointChoc, 
                TbexpertisePointChoc = TbexpertisePointChoc, 
                TbexpertisePourRecousPointChoc = TbexpertisePourRecousPointChoc, 
                TbexpertiseRubriqueConstatationPointChoc = TbexpertiseRubriqueConstatationPointChoc, 
                TbexpertiseRubriqueEstimation = TbexpertiseRubriqueEstimation, 
                TbexpertiseRubriqueMo = TbexpertiseRubriqueMo, 
                TbexpertiseTravauxExterieurPointChoc = TbexpertiseTravauxExterieurPointChoc, 
                TbexpertiseTypeNote = TbexpertiseTypeNote, 
                Tbphoto = Tbphoto, 
                Tbpreambule = Tbpreambule, 
            }; 
        }
    }
}