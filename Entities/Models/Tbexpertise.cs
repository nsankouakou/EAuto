using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbexpertise
    {
        public Tbexpertise()
        {
            Tbconclusion = new HashSet<Tbconclusion>();
            Tbdiscussion = new HashSet<Tbdiscussion>();
            TbexpertiseDepannagePointChoc = new HashSet<TbexpertiseDepannagePointChoc>();
            TbexpertiseEtatRapport = new HashSet<TbexpertiseEtatRapport>();
            TbexpertiseFourniturePointChoc = new HashSet<TbexpertiseFourniturePointChoc>();
            TbexpertisePointChoc = new HashSet<TbexpertisePointChoc>();
            TbexpertisePourRecousPointChoc = new HashSet<TbexpertisePourRecousPointChoc>();
            TbexpertiseRubriqueConstatationPointChoc = new HashSet<TbexpertiseRubriqueConstatationPointChoc>();
            TbexpertiseRubriqueEstimation = new HashSet<TbexpertiseRubriqueEstimation>();
            TbexpertiseRubriqueMo = new HashSet<TbexpertiseRubriqueMo>();
            TbexpertiseTravauxExterieurPointChoc = new HashSet<TbexpertiseTravauxExterieurPointChoc>();
            TbexpertiseTypeNote = new HashSet<TbexpertiseTypeNote>();
            Tbphoto = new HashSet<Tbphoto>();
            Tbpreambule = new HashSet<Tbpreambule>();
        }

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

        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual Tbgarage IdGaraNavigation { get; set; }
        public virtual Tbvehicule IdVehNavigation { get; set; }
        public virtual TbtypeNote IdtypnoteNavigation { get; set; }
        public virtual ICollection<Tbconclusion> Tbconclusion { get; set; }
        public virtual ICollection<Tbdiscussion> Tbdiscussion { get; set; }
        public virtual ICollection<TbexpertiseDepannagePointChoc> TbexpertiseDepannagePointChoc { get; set; }
        public virtual ICollection<TbexpertiseEtatRapport> TbexpertiseEtatRapport { get; set; }
        public virtual ICollection<TbexpertiseFourniturePointChoc> TbexpertiseFourniturePointChoc { get; set; }
        public virtual ICollection<TbexpertisePointChoc> TbexpertisePointChoc { get; set; }
        public virtual ICollection<TbexpertisePourRecousPointChoc> TbexpertisePourRecousPointChoc { get; set; }
        public virtual ICollection<TbexpertiseRubriqueConstatationPointChoc> TbexpertiseRubriqueConstatationPointChoc { get; set; }
        public virtual ICollection<TbexpertiseRubriqueEstimation> TbexpertiseRubriqueEstimation { get; set; }
        public virtual ICollection<TbexpertiseRubriqueMo> TbexpertiseRubriqueMo { get; set; }
        public virtual ICollection<TbexpertiseTravauxExterieurPointChoc> TbexpertiseTravauxExterieurPointChoc { get; set; }
        public virtual ICollection<TbexpertiseTypeNote> TbexpertiseTypeNote { get; set; }
        public virtual ICollection<Tbphoto> Tbphoto { get; set; }
        public virtual ICollection<Tbpreambule> Tbpreambule { get; set; }
    }
}
