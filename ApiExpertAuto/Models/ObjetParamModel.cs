using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class ObjetParamModel
    {
        public ObjetParamModel()
        {

        }

        public decimal Id { get; set; }
        public decimal IdParent { get; set; }
        public decimal Code { get; set; }
        public string CodeStr { get; set; }
        public String ValueType { get; set; }
    }
}
