using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Tbphoto
    {
        public Guid Idphoto { get; set; }
        public string DocNumber { get; set; }
        public string DocName { get; set; }
        public string DocDescription { get; set; }
        public string DocExtension { get; set; }
        public byte[] Doc { get; set; }
        public decimal Idexpert { get; set; }
        public decimal IdUser { get; set; }
        public DateTime? DateCreation { get; set; }

        public virtual Tbexpertise IdexpertNavigation { get; set; }
    }
}
