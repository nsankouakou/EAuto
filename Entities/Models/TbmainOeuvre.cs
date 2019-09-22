using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbmainOeuvre
    {
        public TbmainOeuvre()
        {
            TbmainOeuvrePointChoc = new HashSet<TbmainOeuvrePointChoc>();
            TbnbreElementMainOeuvreTypePeinture = new HashSet<TbnbreElementMainOeuvreTypePeinture>();
            TbtypTravauxMainOuvre = new HashSet<TbtypTravauxMainOuvre>();
        }

        public decimal IdMo { get; set; }
        public decimal? ToRem { get; set; }
        public decimal Idexpert { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }
        public DateTime? ModifieLe { get; set; }
        public decimal? ModifiePar { get; set; }
        public int? StateCode { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<TbmainOeuvrePointChoc> TbmainOeuvrePointChoc { get; set; }
        public virtual ICollection<TbnbreElementMainOeuvreTypePeinture> TbnbreElementMainOeuvreTypePeinture { get; set; }
        public virtual ICollection<TbtypTravauxMainOuvre> TbtypTravauxMainOuvre { get; set; }
    }
}
