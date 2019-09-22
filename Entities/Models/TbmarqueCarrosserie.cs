using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbmarqueCarrosserie
    {
        public decimal IdMarque { get; set; }
        public decimal Idcarross { get; set; }

        public virtual Tbmarque IdMarqueNavigation { get; set; }
        public virtual Tbcarosserie IdcarrossNavigation { get; set; }
    }
}
