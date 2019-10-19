using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Models
{
    public class LoginModel
    {
        public LoginModel()
        {

        }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public Guid? AgentID { get; set; }
        public string Token { get; set; }
    }
}
