using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbphoto1
    {
        public decimal Idphoto { get; set; }
        public decimal Ordre { get; set; }
        public string Comphoto { get; set; }
        public string Cheminphoto { get; set; }
        public decimal Idexpert { get; set; }
        public decimal? IdUser { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
    }
}
