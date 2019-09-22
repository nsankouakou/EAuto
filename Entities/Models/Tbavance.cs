using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbavance
    {
        public decimal IdAvance { get; set; }
        public string NumAvance { get; set; }
        public DateTime DatAvance { get; set; }
        public decimal Mtavance { get; set; }
        public string NumCheqAvan { get; set; }
        public decimal IdDoss { get; set; }
        public decimal IdModeReglmnt { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbdossier IdDossNavigation { get; set; }
        public virtual TbmodeReglement IdModeReglmntNavigation { get; set; }
    }
}
