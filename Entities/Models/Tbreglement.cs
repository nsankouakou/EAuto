using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbreglement
    {
        public decimal Idreglmt { get; set; }
        public string Numreglmt { get; set; }
        public DateTime Datreglmt { get; set; }
        public string NomMandant { get; set; }
        public decimal Mtrglmt { get; set; }
        public decimal Idfact { get; set; }
        public decimal Idmodrglmt { get; set; }
        public string NumeroRecu { get; set; }
        public string NumeroCheque { get; set; }
        public string NumeroCompte { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual Tbfacture IdfactNavigation { get; set; }
        public virtual TbmodeReglement IdmodrglmtNavigation { get; set; }
    }
}
