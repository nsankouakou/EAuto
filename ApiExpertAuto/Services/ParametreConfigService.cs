using ApiExpertAuto.IServices;
using ApiExpertAuto.Models;
using Contracts;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Entities.Enumeration.Enumeration;

namespace ApiExpertAuto.Services
{
    public class ParametreConfigService: IParametreConfigService
    {
        private IRepositoryWrapper _service { get; set; }
        private ILoggerManager _logger { get; set; }
        private ICommunServices _commun { get; set; }

            
        public ParametreConfigService(IRepositoryWrapper service, ILoggerManager logger, ICommunServices communService)
        {
            _service = service;
            _logger = logger;
            _commun = communService;
        }

        #region Assurance
        //Récupération des assurances

        public async Task<ObjetRetour> GetChargAllTbassurance(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbassurance.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdAssur, ValueType = d.NomAssur, CodeStr = d.SiglAssur });
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

        public async Task<ObjetRetour> getAllAssurance(string token)
        {
            ObjetRetour retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == 1)
                {
                    retour.Contenu = await _service.Tbassurance.FindAllAsync();
                    retour.Etat = true;
                    _logger.LogInfo("Liste des assurances récupérée avec succès. ");
                }
            }
            catch (Exception ex)
            {
                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.ToString());
            }
            return retour;
        }

        public async Task<ObjetRetour> getSingleAssurance(string token, int id)
        {
            ObjetRetour retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == 1)
                {
                    retour.Contenu = await _service.Tbassurance.FindByConditionAync(x => x.IdAssur == id) ;
                    retour.Etat = true;
                    _logger.LogInfo("Assurances récupérée avec succès. ");
                }
            }
            catch (Exception ex)
            {
                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.ToString());
            }
            return retour;
        }

        public async Task<ObjetRetour> setSingleAssurance(string token, TbassuranceDto  assurance)
        {
            ObjetRetour retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == 1)
                {
                   await _service.Tbassurance.CreateAsync(assurance.ToModel());
                    retour.Etat = true;
                    _logger.LogInfo("Assurances récupérée avec succès. ");
                }
            }
            catch (Exception ex)
            {
                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.ToString());
            }
            return retour;
        }
        #endregion

        #region Tbville

        public async Task<ObjetRetour> GetChargAllTbville(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbville.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdVille, ValueType = d.NomVille, Code = d.Distance });
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

        public ObjetRetour GetAllTbville(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas =  _service.Tbville.FindAll().ToList();

                    var lstTbvilleDtos = new List<TbvilleDto>();
                    
                    foreach (var item in datas)
                    {
                        lstTbvilleDtos.Add(TbvilleDto.FromModel(item));
                    }
                    retour.Contenu = lstTbvilleDtos;
                    

                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbville");
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

        public async Task<ObjetRetour> GetTbville(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbville.FindByConditionAync(a => a.IdVille == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbville");
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


        public async Task<ObjetRetour> InsertTbville(TbvilleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbville.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbville :\n  {value.ToString()}");
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


        public ObjetRetour MajTbville(TbvilleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbville.FindByCondition(v => v.IdVille == value.IdVille).FirstOrDefault();
                    data.ModifieLe = value.ModifieLe;
                    data.Distance = value.Distance;
                    data.ModifiePar = value.ModifiePar;
                    data.NomVille = value.NomVille;
                    data.StateCode = value.StateCode;

                    _service.Tbville.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbville :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbville(TbvilleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbville.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbville :\n  {value.ToString()}");
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

        #region Tbvehicule

        public ObjetRetour GetAllTbvehicule(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbvehicule.FindAll().ToList();

                    var lstTbvehiculeDtos = new List<TbvehiculeDto>();

                    foreach (var item in datas)
                    {
                        lstTbvehiculeDtos.Add(TbvehiculeDto.FromModel(item));
                    }
                    retour.Contenu = lstTbvehiculeDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbvehicule");
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

        public async Task<ObjetRetour> GetTbvehicule(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbvehicule.FindByConditionAync(a => a.IdVeh == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbvehicule");
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


        public async Task<ObjetRetour> InsertTbvehicule(TbvehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbvehicule.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbvehicule :\n  {value.ToString()}");
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


        public ObjetRetour MajTbvehicule(TbvehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbvehicule.FindByCondition(v => v.IdVeh == value.IdVeh).FirstOrDefault();
                    data.Immatriculation = value.Immatriculation;
                    data.Serievehic = value.Serievehic;
                    data.Datmisecircul = value.Datmisecircul;
                    data.Puissancefiscal = value.Puissancefiscal;
                    data.Nbplace = value.Nbplace;
                    data.VisiteTech = value.VisiteTech;
                    data.Idtypveh = value.Idtypveh;
                    data.IdGenre = value.IdGenre;
                    data.IdCouleur = value.IdCouleur;
                    data.IdEnergie = value.IdEnergie;
                    data.IdProprio = value.IdProprio;
                    data.Idcarross = value.Idcarross;
                    data.IdDoss = value.IdDoss;
                    data.IdUser = value.IdUser;
                    data.ModifieLe = value.ModifieLe;
                    data.ModifiePar = value.ModifiePar;
                    data.StateCode = value.StateCode;
                    data.StatusCode = value.StatusCode;

                    _service.Tbvehicule.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbvehicule :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbvehicule(TbvehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbvehicule.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbvehicule :\n  {value.ToString()}");
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

        #region TbtypeVehicule
        public async Task<ObjetRetour> GetChargAllTbtypeVehicule(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypeVehicule.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idtypveh, ValueType = d.Libtypveh});
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

        public ObjetRetour GetAllTbtypeVehicule(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeVehicule.FindAll().ToList();

                    var lstTbtypeVehiculeDtos = new List<TbtypeVehiculeDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeVehiculeDtos.Add(TbtypeVehiculeDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeVehiculeDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeVehicule");
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

        public async Task<ObjetRetour> GetTbtypeVehicule(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeVehicule.FindByConditionAync(a => a.Idtypveh == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeVehicule");
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


        public async Task<ObjetRetour> InsertTbtypeVehicule(TbtypeVehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeVehicule.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeVehicule :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeVehicule(TbtypeVehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeVehicule.FindByCondition(v => v.Idtypveh == value.Idtypveh).FirstOrDefault();
                    data.Idtypveh = value.Idtypveh; data. 
                Libtypveh = value.Libtypveh; data. 
                Idmodel = value.Idmodel; data. 
                IdUser = value.IdUser;data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypeVehicule.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeVehicule :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeVehicule(TbtypeVehiculeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeVehicule.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeVehicule :\n  {value.ToString()}");
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

        #region TbtypeValeur
        public async Task<ObjetRetour> GetChargAllTbtypeValeur(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypeValeur.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idtypval, ValueType = d.Libtypval });
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

        public ObjetRetour GetAllTbtypeValeur(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeValeur.FindAll().ToList();

                    var lstTbtypeValeurDtos = new List<TbtypeValeurDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeValeurDtos.Add(TbtypeValeurDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeValeurDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeValeur");
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

        public async Task<ObjetRetour> GetTbtypeValeur(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeValeur.FindByConditionAync(a => a.Idtypval == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeValeur");
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


        public async Task<ObjetRetour> InsertTbtypeValeur(TbtypeValeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeValeur.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeValeur :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeValeur(TbtypeValeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeValeur.FindByCondition(v => v.Idtypval == value.Idtypval).FirstOrDefault();
                    data.Idtypval = value.Idtypval; data. 
                Libtypval = value.Libtypval; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypeValeur.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeValeur :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeValeur(TbtypeValeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeValeur.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeValeur :\n  {value.ToString()}");
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

        #region TbtypeUserDroit

        public ObjetRetour GetAllTbtypeUserDroit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeUserDroit.FindAll().ToList();

                    var lstTbtypeUserDroitDtos = new List<TbtypeUserDroitDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeUserDroitDtos.Add(TbtypeUserDroitDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeUserDroitDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeUserDroit");
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

        public async Task<ObjetRetour> GetTbtypeUserDroit(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeUserDroit.FindByConditionAync(a => a.IdDroit == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeUserDroit");
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


        public async Task<ObjetRetour> InsertTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeUserDroit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeUserDroit :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeUserDroit.FindByCondition(v => v.IdDroit == value.IdDroit).FirstOrDefault();
                    data.IdDroit = value.IdDroit; data. 
                IdTypeUser = value.IdTypeUser; data. 
                Date = value.Date; data. 
                Heure = value.Heure; data. 
                Indexer = value.Indexer; data. 
                IdUser = value.IdUser; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypeUserDroit.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeUserDroit :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeUserDroit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeUserDroit :\n  {value.ToString()}");
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

        #region TbtypeUser

        public ObjetRetour GetAllTbtypeUser(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeUser.FindAll().ToList();

                    var lstTbtypeUserDtos = new List<TbtypeUserDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeUserDtos.Add(TbtypeUserDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeUserDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeUser");
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

        public async Task<ObjetRetour> GetTbtypeUser(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeUser.FindByConditionAync(a => a.IdTypeUser == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeUser");
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


        public async Task<ObjetRetour> InsertTbtypeUser(TbtypeUserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeUser.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeUser :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeUser(TbtypeUserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeUser.FindByCondition(v => v.IdTypeUser == value.IdTypeUser).FirstOrDefault();
                    data.IdTypeUser = value.IdTypeUser; data. 
                LibTypeUser = value.LibTypeUser; data. 
                NbreUser = value.NbreUser; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode; data. 
                Tbuser = value.Tbuser;

                    _service.TbtypeUser.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeUser :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeUser(TbtypeUserDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeUser.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeUser :\n  {value.ToString()}");
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

        #region TbtypeTravaux
        public async Task<ObjetRetour> GetChargAllTbtypeTravaux(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypeTravaux.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idtyptrav, ValueType = d.Libtyptrav});
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

        public ObjetRetour GetAllTbtypeTravaux(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeTravaux.FindAll().ToList();

                    var lstTbtypeTravauxDtos = new List<TbtypeTravauxDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeTravauxDtos.Add(TbtypeTravauxDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeTravauxDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeTravaux");
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

        public async Task<ObjetRetour> GetTbtypeTravaux(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeTravaux.FindByConditionAync(a => a.Idtyptrav == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeTravaux");
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


        public async Task<ObjetRetour> InsertTbtypeTravaux(TbtypeTravauxDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeTravaux.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeTravaux :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeTravaux(TbtypeTravauxDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeTravaux.FindByCondition(v => v.Idtyptrav == value.Idtyptrav).FirstOrDefault();
                   data. Idtyptrav = value.Idtyptrav; data. 
                Libtyptrav = value.Libtyptrav; data. 
                IdUser = value.IdUser;data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypeTravaux.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeTravaux :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeTravaux(TbtypeTravauxDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeTravaux.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeTravaux :\n  {value.ToString()}");
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

        #region TbtypePeinture
        public async Task<ObjetRetour> GetChargAllTbtypePeinture(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypePeinture.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdTypePein, ValueType = d.LibTypePein });
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

        public ObjetRetour GetAllTbtypePeinture(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypePeinture.FindAll().ToList();

                    var lstTbtypePeintureDtos = new List<TbtypePeintureDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypePeintureDtos.Add(TbtypePeintureDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypePeintureDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypePeinture");
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

        public async Task<ObjetRetour> GetTbtypePeinture(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypePeinture.FindByConditionAync(a => a.IdTypePein == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypePeinture");
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


        public async Task<ObjetRetour> InsertTbtypePeinture(TbtypePeintureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypePeinture.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypePeinture :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypePeinture(TbtypePeintureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypePeinture.FindByCondition(v => v.IdTypePein == value.IdTypePein).FirstOrDefault();
                    data.IdTypePein = value.IdTypePein; data. 
                LibTypePein = value.LibTypePein; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypePeinture.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypePeinture :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypePeinture(TbtypePeintureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypePeinture.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypePeinture :\n  {value.ToString()}");
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

        #region TbtypeNote
        public async Task<ObjetRetour> GetChargAllTbtypeNote(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypeNote.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idtypnote, ValueType = d.Libtypnote});
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

        public ObjetRetour GetAllTbtypeNote(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeNote.FindAll().ToList();

                    var lstTbtypeNoteDtos = new List<TbtypeNoteDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeNoteDtos.Add(TbtypeNoteDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeNoteDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeNote");
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

        public async Task<ObjetRetour> GetTbtypeNote(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeNote.FindByConditionAync(a => a.Idtypnote == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeNote");
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


        public async Task<ObjetRetour> InsertTbtypeNote(TbtypeNoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeNote.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeNote :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeNote(TbtypeNoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeNote.FindByCondition(v => v.Idtypnote == value.Idtypnote).FirstOrDefault();
                    data.Idtypnote = value.Idtypnote; data. 
                Libtypnote = value.Libtypnote; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode; data. 
                Tbexpertise = value.Tbexpertise; data. 
                TbexpertiseTypeNote = value.TbexpertiseTypeNote; data. 
                Tbnote = value.Tbnote;

                    _service.TbtypeNote.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeNote :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeNote(TbtypeNoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeNote.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeNote :\n  {value.ToString()}");
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

        #region TbtypeExpertise
        public async Task<ObjetRetour> GetChargAllTbtypeExpertise(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypeExpertise.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdTypExpert, ValueType = d.LibTypExpert});
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

        public ObjetRetour GetAllTbtypeExpertise(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypeExpertise.FindAll().ToList();

                    var lstTbtypeExpertiseDtos = new List<TbtypeExpertiseDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypeExpertiseDtos.Add(TbtypeExpertiseDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypeExpertiseDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeExpertise");
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

        public async Task<ObjetRetour> GetTbtypeExpertise(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypeExpertise.FindByConditionAync(a => a.IdTypExpert == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypeExpertise");
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


        public async Task<ObjetRetour> InsertTbtypeExpertise(TbtypeExpertiseDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypeExpertise.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypeExpertise :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypeExpertise(TbtypeExpertiseDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypeExpertise.FindByCondition(v => v.IdTypExpert == value.IdTypExpert).FirstOrDefault();
                    data.IdTypExpert = value.IdTypExpert; data. 
                LibTypExpert = value.LibTypExpert; data. 
                MtPrejudiceHt = value.MtPrejudiceHt; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypeExpertise.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypeExpertise :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypeExpertise(TbtypeExpertiseDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypeExpertise.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypeExpertise :\n  {value.ToString()}");
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

        #region TbtypTravauxMainOuvre

        public async Task<ObjetRetour> GetChargAllTbtypTravauxMainOuvre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypTravauxMainOuvre.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdMo, ValueType = d.ElemntTravo });
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


        public ObjetRetour GetAllTbtypTravauxMainOuvre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypTravauxMainOuvre.FindAll().ToList();

                    var lstTbtypTravauxMainOuvreDtos = new List<TbtypTravauxMainOuvreDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypTravauxMainOuvreDtos.Add(TbtypTravauxMainOuvreDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypTravauxMainOuvreDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypTravauxMainOuvre");
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

        public async Task<ObjetRetour> GetTbtypTravauxMainOuvre(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypTravauxMainOuvre.FindByConditionAync(a => a.Idtyptrav == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypTravauxMainOuvre");
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


        public async Task<ObjetRetour> InsertTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypTravauxMainOuvre.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypTravauxMainOuvre :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypTravauxMainOuvre.FindByCondition(v => v.Idtyptrav == value.Idtyptrav).FirstOrDefault();
                    data.Idtyptrav = value.Idtyptrav; data. 
                IdMo = value.IdMo; data. 
                ElemntTravo = value.ElemntTravo; data. 
                Nbheure = value.Nbheure; data. 
                MtTravo = value.MtTravo; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypTravauxMainOuvre.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypTravauxMainOuvre :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypTravauxMainOuvre.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypTravauxMainOuvre :\n  {value.ToString()}");
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

        #region TbtypGarage
        public async Task<ObjetRetour> GetChargAllTbtypGarage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtypGarage.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdTyGara, ValueType = d.LibTypGara, Code = d.IdTarifHor });
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

        public ObjetRetour GetAllTbtypGarage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtypGarage.FindAll().ToList();

                    var lstTbtypGarageDtos = new List<TbtypGarageDto>();

                    foreach (var item in datas)
                    {
                        lstTbtypGarageDtos.Add(TbtypGarageDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtypGarageDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypGarage");
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

        public async Task<ObjetRetour> GetTbtypGarage(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtypGarage.FindByConditionAync(a => a.IdTarifHor == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtypGarage");
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


        public async Task<ObjetRetour> InsertTbtypGarage(TbtypGarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtypGarage.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtypGarage :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtypGarage(TbtypGarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtypGarage.FindByCondition(v => v.IdTarifHor == value.IdTarifHor).FirstOrDefault();
                    data.IdTyGara = value.IdTyGara; data. 
                LibTypGara = value.LibTypGara; data. 
                IdTarifHor = value.IdTarifHor; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbtypGarage.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtypGarage :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtypGarage(TbtypGarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtypGarage.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtypGarage :\n  {value.ToString()}");
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

        #region Tbtva
        public async Task<ObjetRetour> GetChargAllTbtva(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbtva.FindByConditionAync(m => m.StatusCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdTva, ValueType = d.TxTva });
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

        public ObjetRetour GetAllTbtva(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbtva.FindAll().ToList();

                    var lstTbtvaDtos = new List<TbtvaDto>();

                    foreach (var item in datas)
                    {
                        lstTbtvaDtos.Add(TbtvaDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtvaDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbtva");
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

        public async Task<ObjetRetour> GetTbtva(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbtva.FindByConditionAync(a => a.IdTva == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbtva");
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


        public async Task<ObjetRetour> InsertTbtva(TbtvaDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbtva.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbtva :\n  {value.ToString()}");
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


        public ObjetRetour MajTbtva(TbtvaDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbtva.FindByCondition(v => v.IdTva == value.IdTva).FirstOrDefault();
                    data.IdTva = value.IdTva; data. 
                DateTva = value.DateTva; data. 
                TxTva = value.TxTva; data. 
                EtatTva = value.EtatTva; data. 
                IdUser = value.IdUser; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StatusCode = value.StatusCode;

                    _service.Tbtva.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbtva :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbtva(TbtvaDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbtva.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbtva :\n  {value.ToString()}");
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

        #region Tbparametre

        public ObjetRetour GetAllTbparametre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbparametre.FindAll().ToList();

                    var lstTbparametreDtos = new List<TbparametreDto>();

                    foreach (var item in datas)
                    {
                        lstTbparametreDtos.Add(TbparametreDto.FromModel(item));
                    }
                    retour.Contenu = lstTbparametreDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbparametre");
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

        public async Task<ObjetRetour> GetTbparametre(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbparametre.FindByConditionAync(a => a.IdParam == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbparametre");
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


        public async Task<ObjetRetour> InsertTbparametre(TbparametreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbparametre.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbparametre :\n  {value.ToString()}");
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


        public ObjetRetour MajTbparametre(TbparametreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbparametre.FindByCondition(v => v.IdParam == value.IdParam).FirstOrDefault();
                    data.IdParam = value.IdParam;
                    data.Param = value.Param;

                    _service.Tbparametre.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbparametre :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbparametre(TbparametreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbparametre.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbparametre :\n  {value.ToString()}");
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

        #region Tbmodele
        public async Task<ObjetRetour> GetChargAllTbmodele(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbmodele.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idmodel, ValueType = d.Libmodel, IdParent = d.Idmarq });
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

        public ObjetRetour GetAllTbmodele(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbmodele.FindAll().ToList();

                    var lstTbmodeleDtos = new List<TbmodeleDto>();

                    foreach (var item in datas)
                    {
                        lstTbmodeleDtos.Add(TbmodeleDto.FromModel(item));
                    }
                    retour.Contenu = lstTbmodeleDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbmodele");
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

        public async Task<ObjetRetour> GetTbmodele(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbmodele.FindByConditionAync(a => a.Idmarq == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbmodele");
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


        public async Task<ObjetRetour> InsertTbmodele(TbmodeleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbmodele.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbmodele :\n  {value.ToString()}");
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


        public ObjetRetour MajTbmodele(TbmodeleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbmodele.FindByCondition(v => v.Idmarq == value.Idmarq).FirstOrDefault();
                    data.Idmodel = value.Idmodel; data. 
                Libmodel = value.Libmodel; data. 
                Idmarq = value.Idmarq; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbmodele.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbmodele :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbmodele(TbmodeleDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbmodele.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbmodele :\n  {value.ToString()}");
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

        #region Tbmarque
        public async Task<ObjetRetour> GetChargAllTbmarque(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbmarque.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdMarque, ValueType = d.LibMarque });
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

        public ObjetRetour GetAllTbmarque(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbmarque.FindAll().ToList();

                    var lstTbmarqueDtos = new List<TbmarqueDto>();

                    foreach (var item in datas)
                    {
                        lstTbmarqueDtos.Add(TbmarqueDto.FromModel(item));
                    }
                    retour.Contenu = lstTbmarqueDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbmarque");
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

        public async Task<ObjetRetour> GetTbmarque(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbmarque.FindByConditionAync(a => a.IdMarque == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbmarque");
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


        public async Task<ObjetRetour> InsertTbmarque(TbmarqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbmarque.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbmarque :\n  {value.ToString()}");
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


        public ObjetRetour MajTbmarque(TbmarqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbmarque.FindByCondition(v => v.IdMarque == value.IdMarque).FirstOrDefault();
                    data.IdMarque = value.IdMarque; data. 
                LibMarque = value.LibMarque; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbmarque.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbmarque :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbmarque(TbmarqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbmarque.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbmarque :\n  {value.ToString()}");
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

        #region Tbgenre
        public async Task<ObjetRetour> GetChargAllTbgenre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbgenre.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdGenre, ValueType = d.LibGenre});
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

        public ObjetRetour GetAllTbgenre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbgenre.FindAll().ToList();

                    var lstTbgenreDtos = new List<TbgenreDto>();

                    foreach (var item in datas)
                    {
                        lstTbgenreDtos.Add(TbgenreDto.FromModel(item));
                    }
                    retour.Contenu = lstTbgenreDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbgenre");
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

        public async Task<ObjetRetour> GetTbgenre(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbgenre.FindByConditionAync(a => a.IdGenre == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbgenre");
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


        public async Task<ObjetRetour> InsertTbgenre(TbgenreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbgenre.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbgenre :\n  {value.ToString()}");
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


        public ObjetRetour MajTbgenre(TbgenreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbgenre.FindByCondition(v => v.IdGenre == value.IdGenre).FirstOrDefault();
                    data.IdGenre = value.IdGenre; data. 
                LibGenre = value.LibGenre; data. 
                IdUser = value.IdUser; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode; data. 
                Tbvehicule = value.Tbvehicule;

                    _service.Tbgenre.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbgenre :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbgenre(TbgenreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbgenre.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbgenre :\n  {value.ToString()}");
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

        #region Tbgarage
        public async Task<ObjetRetour> GetChargAllTbgarage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbgarage.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdGara, ValueType = d.RaisonSociale, CodeStr = d.Sigle });
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

        public ObjetRetour GetAllTbgarage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbgarage.FindAll().ToList();

                    var lstTbgarageDtos = new List<TbgarageDto>();

                    foreach (var item in datas)
                    {
                        lstTbgarageDtos.Add(TbgarageDto.FromModel(item));
                    }
                    retour.Contenu = lstTbgarageDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbgarage");
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

        public async Task<ObjetRetour> GetTbgarage(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbgarage.FindByConditionAync(a => a.IdGara == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbgarage");
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


        public async Task<ObjetRetour> InsertTbgarage(TbgarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbgarage.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbgarage :\n  {value.ToString()}");
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


        public ObjetRetour MajTbgarage(TbgarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbgarage.FindByCondition(v => v.IdGara == value.IdGara).FirstOrDefault();
                    data.IdGara = value.IdGara; data. 
                RaisonSociale = value.RaisonSociale; data. 
                TelGar = value.TelGar; data. 
                AdrGar = value.AdrGar; data. 
                MailGar = value.MailGar; data. 
                Sigle = value.Sigle; data. 
                FaxGar = value.FaxGar; data. 
                Contact = value.Contact; data. 
                Pme = value.Pme; data. 
                BpGar = value.BpGar; data. 
                IdUser = value.IdUser; data. 
                IdTyGara = value.IdTyGara; data. 

                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode; data. 
                Tbexpertise = value.Tbexpertise;

                    _service.Tbgarage.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbgarage :\n  {value.ToString()}");
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


        public ObjetRetour DeleteTbgarage(TbgarageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbgarage.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbgarage :\n  {value.ToString()}");
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


    }
}
