

using ApiExpertAuto.Models;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.IServices
{
    public interface ILoginService
    {
        ObjetRetour Login(LoginModel login);
        ObjetRetour ModifierMotDePasse(LoginModel login);
        ObjetRetour InitialiserMotDePasse(LoginModel login);

        Task<ObjetRetour> GetAllUsers(string token);
        Task<ObjetRetour> GetUsers(decimal id, string token);
        Task<ObjetRetour> InsertUsers(TbuserDto value);
        
        ObjetRetour MajUsers(TbuserDto value);
        
        ObjetRetour DeleteUsers(TbuserDto value);
        
        ObjetRetour LoginMobile(string codeEquipement);

        //TbmenuDto VmenuToMenu(VvMenuParUtilisateur menuUser);

        //List<TbmenuDto> VmenuToMenu(List<VvMenuParUtilisateur> menuUser);
    }
}
