using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeUserDroit
    {
        public decimal IdDroit { get; set; }
        public decimal IdTypeUser { get; set; }
        public DateTime Date { get; set; }
        public DateTime Heure { get; set; }
        public decimal? Indexer { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }
    }
}
