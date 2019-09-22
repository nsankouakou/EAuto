using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbrapportAcheve
    {
        public decimal Idrapport { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure { get; set; }
        public decimal IdExpert { get; set; }
        public decimal IdDoss { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }
    }
}
