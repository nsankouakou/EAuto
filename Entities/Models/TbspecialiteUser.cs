using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TbspecialiteUser
    {
        public decimal IdUser { get; set; }
        public decimal IdSpec { get; set; }

        public virtual Tbspecialite IdSpecNavigation { get; set; }
        public virtual Tbuser IdUserNavigation { get; set; }
    }
}
