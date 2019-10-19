using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class InfoUserModel
    {
        public InfoUserModel()
        {

        }
        public LoginModel Login { get; set; }
        public List<MenuModel> Menus { get; set; }
    }
}
