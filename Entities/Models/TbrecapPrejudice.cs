using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrecapPrejudice
    {
        public decimal IdRecapExp { get; set; }
        public decimal MtPneuveHt { get; set; }
        public decimal MtTvapneuve { get; set; }
        public decimal MtPneuveTtc { get; set; }
        public decimal MtRecupTtc { get; set; }
        public decimal MtFournitureTtc { get; set; }
        public decimal? MtTotDesPrejudices { get; set; }
        public decimal MtMoHt { get; set; }
        public decimal MtMoPeintureHt { get; set; }
        public decimal MtTvamoPeinture { get; set; }
        public decimal MtMoTtc { get; set; }
        public decimal MtMoPeintureTtc { get; set; }
        public decimal MtTotMoTtc { get; set; }
        public decimal MtProdPeintureHt { get; set; }
        public decimal MtPetiteFounHt { get; set; }
        public decimal MtTvapetiteFournPeinture { get; set; }
        public decimal MtTotPrejudice { get; set; }
        public string MtDepannage { get; set; }
        public decimal IdPointChoc { get; set; }
        public decimal IdExpert { get; set; }
        public DateTime? DatCompo { get; set; }
        public decimal? Eprejudice { get; set; }
        public decimal IdDoss { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual TbpointChoc IdPointChocNavigation { get; set; }
    }
}
