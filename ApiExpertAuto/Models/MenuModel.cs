
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class MenuModel
    {
        public MenuModel()
        {

        }
        public TbmenuDto MenuParent { get; set; }
        public List<TbmenuDto> Menu { get; set; }
    }
}
