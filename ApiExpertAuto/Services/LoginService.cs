

using Contracts;
using Entities.Models;
using Microsoft.IdentityModel.Tokens;
using SecurityService;
using static Entities.Enumeration.Enumeration;
using Api_SNE.Extensions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Security.Claims;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiExpertAuto.IServices;
using ApiExpertAuto.Models;
using Entities.Models.Dtos;

namespace ApiExpertAuto.Services
{
    public class LoginService : ILoginService
    {

        private IRepositoryWrapper _service { get; set; }
        private ICommunServices _commun { get; set; }
        private ILoggerManager _logger { get; set; }
        public string _strIP { get; set; }

        public LoginService(ILoggerManager logger, IRepositoryWrapper repository, ICommunServices serviceCommun)
        {
            _commun = serviceCommun;
            _logger = logger;
            _service = repository;
        }

        
        public ObjetRetour InitialiserMotDePasse(LoginModel login)
        {
            var retour = new ObjetRetour();
            try
            {
                if (login != null)
                {
                    if (_commun.ConnexionValide(login.Token) == (int)enumEtat.Valide)
                    {
                       var user =  _service.Tbuser.FindByCondition(u => u.IdUser == login.UserId).FirstOrDefault();

                        user.Password= clsSecurityHash.getSHA256("123456");
                        //user..DateDerniereModificationPassword = DateTime.Now;
                        user.DateDerniereModificationPassword = DateTime.Now;
                        _service.Tbuser.Update(user);
                        _service.Save();
                        retour.Etat = true;
                        _logger.LogInfo($"SUCCESS");
                    }
                    else
                    {
                        retour.Message = $"Token non valide!";
                        retour.Etat = false;
                        _logger.LogInfo($"Token non valide!");
                    } 
                }
                else
                {
                    retour.Message = $"Parametre non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Parametre non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = true;
                retour.Message = ex.Message;
            }

            return retour;
        }



        public ObjetRetour Login(LoginModel login)
        {
           if (login == null) return new ObjetRetour();

            var retour = new ObjetRetour();
            try
            {
                string pass = "";
                pass = clsSecurityHash.getSHA256(login.Password);

                var user = _service.Tbuser.FindByCondition(u => u.LoginUser == login.Login && u.Password == pass).FirstOrDefault();

                if (user == null)
                {
                    retour.Etat = false;
                    retour.Message = "Login ou mot de passe non valide!";
                    retour.Contenu = new LoginModel();
                    return retour;
                }

                if (user.Password == pass)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Startup.SecretKey));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokeOptions = new JwtSecurityToken(
                        issuer: Startup.Issuer,// TODO adresse de deploiement du service
                        audience: _strIP,
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),//TODO Duree du Token
                        signingCredentials: signinCredentials
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                    var connexion = new Connexion()
                    {
                        AdresseIpSource = _strIP,
                        Bsucces = true,
                        DateConnexion = DateTime.Now,
                        DateLastConnexion = DateTime.Now,
                        Token = tokenString,
                        UserId = (int)user.IdUser
                        
                    };


                    _service.Connexion.Create(connexion);

                    var profil =_service.Tbprofil.FindByCondition(p=> p.ProfilId == user.ProfilId).FirstOrDefault();


                    var habilitations = _service.Tbhabilitation.FindByCondition(h=> h.ProfilId==profil.ProfilId);
                    var lstIdMenus = habilitations.Select(m => m.MenuId).ToList();

                    var menuUsers = _service.Tbmenu.FindByCondition(mp => lstIdMenus.Contains(mp.MenuId));
                    var info = new InfoUserModel();
                    var loginModel = new LoginModel();

                    loginModel.UserId = (int)user.IdUser;
                    loginModel.UserName = user.NomPrenUser;
                    loginModel.Login = user.LoginUser;
                    loginModel.Token = tokenString;
                    info.Login = loginModel;

                    info.Menus = new List<MenuModel>();

                    var vueMenuParent = menuUsers.Where(m => m.IdParent == null).OrderBy(o => o.OrdreMenu).ToList();

                    foreach (var menuUser in vueMenuParent)
                    {
                        var menup = new MenuModel();
                        menup.MenuParent = ModelFromDto(menuUser);

                        menup.Menu = LstModelFromDto(menuUsers.Where(me => me.IdParent == menuUser.MenuId).OrderBy(o => o.OrdreMenu).ToList());

                        info.Menus.Add(menup);
                    }

                    // info = getinfoUser(user);
                    _service.Save();

                    retour.Contenu = info;
                    retour.Message = $"SUCCESS";
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS");
                }

            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }



        public ObjetRetour LoginMobile(string codeEquipement )
        {
            if (string.IsNullOrEmpty(codeEquipement)) return new ObjetRetour();

            var retour = new ObjetRetour();
            try
            {
                

                var equipement = _service.Equipement.FindByCondition(e => e .CodeEq== codeEquipement).FirstOrDefault();

                if (equipement == null)
                {
                    retour.Etat = false;
                    retour.Message = "Equipement non habilité!";
                    
                    return retour;
                }

                if (equipement != null)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Startup.SecretKey));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                    var tokeOptions = new JwtSecurityToken(
                        issuer: Startup.Issuer,// TODO adresse de deploiement du service
                        audience: _strIP,
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(10),//TODO Duree du Token
                        signingCredentials: signinCredentials
                    );

                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                    var connexion = new Connexion()
                    {
                        AdresseIpSource = _strIP,
                        Bsucces = true,
                        DateConnexion = DateTime.Now,
                        DateLastConnexion = DateTime.Now,
                        Token = tokenString,
                        Equipementid = equipement.Equipementid

                    };
                    _service.Connexion.Create(connexion);

                    // info = getinfoUser(user);
                    _service.Save();

                    retour.Contenu = tokenString;
                    retour.Message = $"SUCCESS";
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS");
                }

            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }



        //private InfoUserModel getinfoUser(TbuserDto connexion)
        //{
        //    var retour = new InfoUserModel();

        //    return retour;
        //}

        //public ObjetRetour ModifierMotDePasse(LoginModel login)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ObjetRetour> GetAllUsers(string token)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ObjetRetour> GetUsers(int id, string token)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ObjetRetour> InsertUsers(TbuserDto value)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ObjetRetour> InsertListUsers(List<TbuserDto> value)
        //{
        //    throw new NotImplementedException();
        //}

        //public ObjetRetour MajUsers(TbuserDto value)
        //{
        //    throw new NotImplementedException();
        //}

        //public ObjetRetour MajListUsers(List<TbuserDto> value)
        //{
        //    throw new NotImplementedException();
        //}

        //public ObjetRetour DeleteUsers(TbuserDto value)
        //{
        //    throw new NotImplementedException();
        //}

        //public ObjetRetour DeleteListUsers(List<TbuserDto> values)
        //{
        //    throw new NotImplementedException();
        //}

        public ObjetRetour ModifierMotDePasse(LoginModel login)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(login.Token) == (int)enumEtat.Valide)
                {

                    var pass = clsSecurityHash.getSHA256(login.OldPassword);

                    var user = _service.Tbuser.FindByCondition(u => u.LoginUser == login.Login && u.Password == pass).FirstOrDefault();

                    if (user.Password == pass)
                    {
                        user.Password = clsSecurityHash.getSHA256(login.Password);
                        _service.Tbuser.Update(user);
                        _service.Save();
                        retour.Etat = true;
                        _logger.LogInfo($"SUCCESS");
                    }
                    else
                    {
                        retour.Message = $"Ancien mot de passe incorrect!";
                        retour.Etat = false;
                        _logger.LogInfo($"Ancien mot de passe incorrect!");
                    }

                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #region Users
        public async Task<ObjetRetour> GetAllUsers(string token)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbuser.FindByConditionAync(u=> u.StatutSession == true);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetUsers(decimal id, string token)
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbuser.FindByConditionAync(a => a.IdUser == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertUsers(TbuserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (value != null)
                {
                    if (_commun.ConnexionValide(value.Token) == (int)enumEtat.Valide)
                    {
                        var pass = clsSecurityHash.getSHA256(value.Password);
                        value.Password = pass;
                        var agent =_service.Tbagent.FindByCondition(a => a.Matricule == value.Matricule).FirstOrDefault();
                        if (agent != null)
                        {
                            value.AgentId = agent.AgentId;
                            value.StatusCode = (int)EtatAgent.EnFonction;
                            await _service.Tbuser.CreateAsync(value.ToModel());
                            _service.Save();
                            retour.Etat = true;
                            _logger.LogInfo($"SUCCESS"); 
                        }
                        else
                        {
                            retour.Message = $"Agent Inexistant!";
                            retour.Etat = false;
                            _logger.LogInfo($"Agent Inexistant!");
                        }
                    }
                    else
                    {
                        retour.Message = $"Token non valide!";
                        retour.Etat = false;
                        _logger.LogInfo($"Token non valide!");
                    } 
                }
                else
                {
                    retour.Message = $"Parametre non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Parametre non valide!");
                }
            }
            catch (Exception ex)
            {
                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }

  

        public ObjetRetour MajUsers(TbuserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (value != null)
                {
                    if (_commun.ConnexionValide(value.Token) == (int)enumEtat.Valide)
                    {
                        
                        var agent = _service.Tbagent.FindByCondition(a => a.Matricule == value.Matricule).FirstOrDefault();
                        if (agent != null)
                        {
                            var user = _service.Tbuser.FindByCondition(u=>u.IdUser == value.IdUser).FirstOrDefault();

                            if (user != null)
                            {
                                user.IdUser = value.IdUser;
                                user.CodUser = value.CodUser;
                                user.LoginUser = value.LoginUser;
                                user.NomPrenUser = value.NomPrenUser;
                                user.NumTel = value.NumTel;
                                user.SexUser = value.SexUser;
                                user.AdrUser = value.AdrUser;
                                user.Password = value.Password;
                                user.DatFonc = value.DatFonc;
                                user.IdTypeUser = value.IdTypeUser;
                                user.ProfilId = value.ProfilId;
                                user.AgentId = value.AgentId;
                                user.DateDebutValidite = value.DateDebutValidite;
                                user.DateFinValidite = value.DateFinValidite;
                                user.DateDerniereModificationPassword = value.DateDerniereModificationPassword;
                                user.InitUserPassword = value.InitUserPassword;
                                user.NbreEchecsOuvertureSession = value.NbreEchecsOuvertureSession;
                                user.DateDerniereConnexion = value.DateDerniereConnexion;
                                user.DerniereConnexionReussie = value.DerniereConnexionReussie;
                                user.DateDernierVerrouillage = value.DateDernierVerrouillage;
                                user.Email = value.Email;
                                user.StatutSession = value.StatutSession;
                                user.Hostname = value.Hostname;
                                user.ModifieLe = value.ModifieLe;
                                user.ModifiePar = value.ModifiePar;
                                user.StateCode = value.StateCode;
                                user.StatusCode = value.StatusCode;
                                user.DateCreation = value.DateCreation;



                                _service.Tbuser.Update(user);
                                _service.Save();
                                retour.Etat = true;
                                _logger.LogInfo($"SUCCESS");
                            }
                            else
                            {
                                retour.Message = $"Tbuser  Inexistant!";
                                retour.Etat = false;
                                _logger.LogInfo($"Tbuser Inexistant!");
                            }
                        }
                        else
                        {
                            retour.Message = $"Agent Inexistant!";
                            retour.Etat = false;
                            _logger.LogInfo($"Agent Inexistant!");
                        }
                    }
                    else
                    {
                        retour.Message = $"Token non valide!";
                        retour.Etat = false;
                        _logger.LogInfo($"Token non valide!");
                    }
                }
                else
                {
                    retour.Message = $"Parametre non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Parametre non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        

        public ObjetRetour DeleteUsers(TbuserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value.Token) == (int)enumEtat.Valide)
                {
                    try
                    {
                        _service.Tbuser.Delete(value.ToModel());
                        _service.Save();
                        retour.Etat = true;
                        _logger.LogInfo($"SUCCESS");
                    }
                    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                    {

                        value.StatusCode = (int)EtatAgent.Supprimer;
                        _service.Tbuser.Update(value.ToModel());
                        _service.Save();
                        retour.Etat = true;
                        _logger.LogInfo($"SUCCESS");
                        retour.Message = ex.Message;
                    }
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                    _logger.LogInfo($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        #endregion

        public  TbmenuDto ModelFromDto(Tbmenu model)
        {
            return new TbmenuDto()
            {
                MenuId = model.MenuId,
                IdParent = model.IdParent,
                LibelleMenu = model.LibelleMenu,
                Action = model.Action,
                OrdreMenu = model.OrdreMenu,
                Bactif = model.Bactif,
                Controlleur = model.Controlleur,
                Url = model.Url,
                Icon = model.Icon,
                Description = model.Description,
                Tbhabilitation = model.Tbhabilitation,
            };
        }

        private  List<TbmenuDto> LstModelFromDto(List<Tbmenu> values)
        {
            return values.Select(model=> new TbmenuDto
            {
                MenuId = model.MenuId,
                IdParent = model.IdParent,
                LibelleMenu = model.LibelleMenu,
                Action = model.Action,
                OrdreMenu = model.OrdreMenu,
                Bactif = model.Bactif,
                Controlleur = model.Controlleur,
                Url = model.Url,
                Icon = model.Icon,
                Description = model.Description,
                Tbhabilitation = model.Tbhabilitation,
            }).ToList();
        }

        public Tbmenu DtoFromModel(TbmenuDto model)
        {
            return new Tbmenu()
            {
                MenuId = model.MenuId,
                IdParent = model.IdParent,
                LibelleMenu = model.LibelleMenu,
                Action = model.Action,
                OrdreMenu = model.OrdreMenu,
                Bactif = model.Bactif,
                Controlleur = model.Controlleur,
                Url = model.Url,
                Icon = model.Icon,
                Description = model.Description,
                Tbhabilitation = model.Tbhabilitation,
            };
        }

    }



}

