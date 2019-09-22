using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbtypeTravaux
    {
        public TbtypeTravaux()
        {
            TbtypTravauxMainOuvre = new HashSet<TbtypTravauxMainOuvre>();
        }

        public decimal Idtyptrav { get; set; }
        public string Libtyptrav { get; set; }
        public decimal? IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbtypTravauxMainOuvre> TbtypTravauxMainOuvre { get; set; }
    }
}
