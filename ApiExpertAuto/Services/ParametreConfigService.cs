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

        #region Tbassurance

        public async Task<ObjetRetour> GetChargAllTbassurance(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbassurance.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdAssur, ValueType = d.NomAssur, CodeStr=d.SiglAssur });
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

        public ObjetRetour GetAllTbassurance(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbassurance.FindAll().ToList();

                    var lstTbassuranceDtos = new List<TbassuranceDto>();

                    foreach (var item in datas)
                    {
                        lstTbassuranceDtos.Add(TbassuranceDto.FromModel(item));
                    }
                    retour.Contenu = lstTbassuranceDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbassurance");
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

        public async Task<ObjetRetour> GetTbassurance(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbassurance.FindByConditionAync(a => a.IdAssur == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbassurance");
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

        public async Task<ObjetRetour> InsertTbassurance(TbassuranceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbassurance.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbassurance :\n  {value.ToString()}");
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

        public ObjetRetour MajTbassurance(TbassuranceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbassurance.FindByCondition(v => v.IdAssur == value.IdAssur).FirstOrDefault();
                    data.IdAssur = value.IdAssur; data. 
                NomAssur = value.NomAssur; data. 
                TelAssur = value.TelAssur; data. 
                AdrAssur = value.AdrAssur; data. 
                BpAssur = value.BpAssur; data. 
                MailAssur = value.MailAssur; data. 
                FaxAssur = value.FaxAssur; data. 
                Contact = value.Contact; data. 
                SiglAssur = value.SiglAssur; data. 
                IdUser = value.IdUser;  
                data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbassurance.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbassurance :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbassurance(TbassuranceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbassurance.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbassurance :\n  {value.ToString()}");
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

        #region Tbagent


        public ObjetRetour GetAllTbagent(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbagent.FindAll().ToList();

                    var lstTbagentDtos = new List<TbagentDto>();

                    foreach (var item in datas)
                    {
                        lstTbagentDtos.Add(TbagentDto.FromModel(item));
                    }
                    retour.Contenu = lstTbagentDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbagent");
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

        public async Task<ObjetRetour> GetTbagent(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbagent.FindByConditionAync(a => a.AgentId == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbagent");
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

        public async Task<ObjetRetour> InsertTbagent(TbagentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbagent.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbagent :\n  {value.ToString()}");
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

        public ObjetRetour MajTbagent(TbagentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbagent.FindByCondition(v => v.AgentId == value.AgentId).FirstOrDefault();
                    data.AgentId = value.AgentId; data. 
                Matricule = value.Matricule; data. 
                Nom = value.Nom; data. 
                Prenoms = value.Prenoms; data. 
                Password = value.Password; data. 
                Categorie = value.Categorie; data. 
                Telephone = value.Telephone; data. 
                Lettreaffectee = value.Lettreaffectee; data. 
                Fonctionid = value.Fonctionid; data. 
                IdUser = value.IdUser; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbagent.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbagent :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbagent(TbagentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbagent.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbagent :\n  {value.ToString()}");
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

        #region TbautreRubrique

        public async Task<ObjetRetour> GetChargAllTbautreRubrique(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbautreRubrique.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdAutreRub, ValueType = d.LibAutreRub });
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

        public ObjetRetour GetAllTbautreRubrique(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbautreRubrique.FindAll().ToList();

                    var lstTbautreRubriqueDtos = new List<TbautreRubriqueDto>();

                    foreach (var item in datas)
                    {
                        lstTbautreRubriqueDtos.Add(TbautreRubriqueDto.FromModel(item));
                    }
                    retour.Contenu = lstTbautreRubriqueDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbautreRubrique");
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

        public async Task<ObjetRetour> GetTbautreRubrique(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbautreRubrique.FindByConditionAync(a => a.IdAutreRub == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbautreRubrique");
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

        public async Task<ObjetRetour> InsertTbautreRubrique(TbautreRubriqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbautreRubrique.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbautreRubrique :\n  {value.ToString()}");
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

        public ObjetRetour MajTbautreRubrique(TbautreRubriqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbautreRubrique.FindByCondition(v => v.IdAutreRub == value.IdAutreRub).FirstOrDefault();
                    data.IdAutreRub = value.IdAutreRub; data. 
                LibAutreRub = value.LibAutreRub; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbautreRubrique.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbautreRubrique :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbautreRubrique(TbautreRubriqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbautreRubrique.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbautreRubrique :\n  {value.ToString()}");
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

        #region Tbcarosserie

        public async Task<ObjetRetour> GetChargAllTbcarosserie(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbcarosserie.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idcarross, ValueType = d.LibCarross});
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

        public ObjetRetour GetAllTbcarosserie(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbcarosserie.FindAll().ToList();

                    var lstTbcarosserieDtos = new List<TbcarosserieDto>();

                    foreach (var item in datas)
                    {
                        lstTbcarosserieDtos.Add(TbcarosserieDto.FromModel(item));
                    }
                    retour.Contenu = lstTbcarosserieDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcarosserie");
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

        public async Task<ObjetRetour> GetTbcarosserie(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbcarosserie.FindByConditionAync(a => a.Idcarross == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcarosserie");
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

        public async Task<ObjetRetour> InsertTbcarosserie(TbcarosserieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbcarosserie.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbcarosserie :\n  {value.ToString()}");
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

        public ObjetRetour MajTbcarosserie(TbcarosserieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbcarosserie.FindByCondition(v => v.Idcarross == value.Idcarross).FirstOrDefault();
                    data.Idcarross = value.Idcarross; data. 
                LibCarross = value.LibCarross; data. 
                IdUser = value.IdUser; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbcarosserie.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbcarosserie :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbcarosserie(TbcarosserieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbcarosserie.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbcarosserie :\n  {value.ToString()}");
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

        #region Tbcommune

        public async Task<ObjetRetour> GetChargAllTbcommune(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbcommune.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdComm, ValueType = d.NomComm });
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

        public ObjetRetour GetAllTbcommune(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbcommune.FindAll().ToList();

                    var lstTbcommuneDtos = new List<TbcommuneDto>();

                    foreach (var item in datas)
                    {
                        lstTbcommuneDtos.Add(TbcommuneDto.FromModel(item));
                    }
                    retour.Contenu = lstTbcommuneDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcommune");
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

        public async Task<ObjetRetour> GetTbcommune(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbcommune.FindByConditionAync(a => a.IdComm == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcommune");
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

        public async Task<ObjetRetour> InsertTbcommune(TbcommuneDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbcommune.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbcommune :\n  {value.ToString()}");
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

        public ObjetRetour MajTbcommune(TbcommuneDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbcommune.FindByCondition(v => v.IdVille == value.IdVille).FirstOrDefault();
                    data.IdComm = value.IdComm; data. 
                NomComm = value.NomComm; data. 
                Deplacement = value.Deplacement; data. 
                IdVille = value.IdVille; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbcommune.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbcommune :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbcommune(TbcommuneDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbcommune.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbcommune :\n  {value.ToString()}");
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

        #region Tbcouleur

        public async Task<ObjetRetour> GetChargAllTbcouleur(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbcouleur.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdCouleur, ValueType = d.LibCouleur });
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

        public ObjetRetour GetAllTbcouleur(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbcouleur.FindAll().ToList();

                    var lstTbcouleurDtos = new List<TbcouleurDto>();

                    foreach (var item in datas)
                    {
                        lstTbcouleurDtos.Add(TbcouleurDto.FromModel(item));
                    }
                    retour.Contenu = lstTbcouleurDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcouleur");
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

        public async Task<ObjetRetour> GetTbcouleur(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbcouleur.FindByConditionAync(a => a.IdCouleur == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbcouleur");
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

        public async Task<ObjetRetour> InsertTbcouleur(TbcouleurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbcouleur.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbcouleur :\n  {value.ToString()}");
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

        public ObjetRetour MajTbcouleur(TbcouleurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbcouleur.FindByCondition(v => v.IdCouleur == value.IdCouleur).FirstOrDefault();
                    data.IdCouleur = value.IdCouleur; data. 
                LibCouleur = value.LibCouleur; data. 
                IdUser = value.IdUser; data. 
                DateCreation = value.DateCreation; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbcouleur.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbcouleur :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbcouleur(TbcouleurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbcouleur.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbcouleur :\n  {value.ToString()}");
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



        #region Tbenergie

        public async Task<ObjetRetour> GetChargAllTbenergie(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbenergie.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdEnergie, ValueType = d.LibEnergie});
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

        public ObjetRetour GetAllTbenergie(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbenergie.FindAll().ToList();

                    var lstTbenergieDtos = new List<TbenergieDto>();

                    foreach (var item in datas)
                    {
                        lstTbenergieDtos.Add(TbenergieDto.FromModel(item));
                    }
                    retour.Contenu = lstTbenergieDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbenergie");
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

        public async Task<ObjetRetour> GetTbenergie(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbenergie.FindByConditionAync(a => a.IdEnergie == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbenergie");
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

        public async Task<ObjetRetour> InsertTbenergie(TbenergieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbenergie.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbenergie :\n  {value.ToString()}");
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

        public ObjetRetour MajTbenergie(TbenergieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbenergie.FindByCondition(v => v.IdEnergie == value.IdEnergie).FirstOrDefault();
                    data.IdEnergie = value.IdEnergie; data. 
                LibEnergie = value.LibEnergie; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbenergie.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbenergie :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbenergie(TbenergieDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbenergie.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbenergie :\n  {value.ToString()}");
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

        #region Tbfourniture

        public async Task<ObjetRetour> GetChargAllTbfourniture(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbfourniture.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdFourn, ValueType = d.LibFourn});
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

        public ObjetRetour GetAllTbfourniture(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbfourniture.FindAll().ToList();

                    var lstTbfournitureDtos = new List<TbfournitureDto>();

                    foreach (var item in datas)
                    {
                        lstTbfournitureDtos.Add(TbfournitureDto.FromModel(item));
                    }
                    retour.Contenu = lstTbfournitureDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbfourniture");
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

        public async Task<ObjetRetour> GetTbfourniture(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbfourniture.FindByConditionAync(a => a.IdFourn == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbfourniture");
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

        public async Task<ObjetRetour> InsertTbfourniture(TbfournitureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbfourniture.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbfourniture :\n  {value.ToString()}");
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

        public ObjetRetour MajTbfourniture(TbfournitureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbfourniture.FindByCondition(v => v.IdFourn == value.IdFourn).FirstOrDefault();
                    data.IdFourn = value.IdFourn; data. 
                LibFourn = value.LibFourn; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbfourniture.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbfourniture :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbfourniture(TbfournitureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbfourniture.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbfourniture :\n  {value.ToString()}");
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




        #region TbpointChoc

        public async Task<ObjetRetour> GetChargAllTbpointChoc(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbpointChoc.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdPointChoc, ValueType = d.LibPointChoc});
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

        public ObjetRetour GetAllTbpointChoc(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbpointChoc.FindAll().ToList();

                    var lstTbpointChocDtos = new List<TbpointChocDto>();

                    foreach (var item in datas)
                    {
                        lstTbpointChocDtos.Add(TbpointChocDto.FromModel(item));
                    }
                    retour.Contenu = lstTbpointChocDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbpointChoc");
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

        public async Task<ObjetRetour> GetTbpointChoc(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbpointChoc.FindByConditionAync(a => a.IdPointChoc == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbpointChoc");
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

        public async Task<ObjetRetour> InsertTbpointChoc(TbpointChocDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbpointChoc.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbpointChoc :\n  {value.ToString()}");
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

        public ObjetRetour MajTbpointChoc(TbpointChocDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbpointChoc.FindByCondition(v => v.IdPointChoc == value.IdPointChoc).FirstOrDefault();
                    data.IdPointChoc = value.IdPointChoc; data. 
                LibPointChoc = value.LibPointChoc; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbpointChoc.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbpointChoc :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbpointChoc(TbpointChocDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbpointChoc.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbpointChoc :\n  {value.ToString()}");
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

        #region Tbproprietaire


        public ObjetRetour GetAllTbproprietaire(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbproprietaire.FindAll().ToList();

                    var lstTbproprietaireDtos = new List<TbproprietaireDto>();

                    foreach (var item in datas)
                    {
                        lstTbproprietaireDtos.Add(TbproprietaireDto.FromModel(item));
                    }
                    retour.Contenu = lstTbproprietaireDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbproprietaire");
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

        public async Task<ObjetRetour> GetTbproprietaire(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbproprietaire.FindByConditionAync(a => a.IdProprio == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbproprietaire");
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

        public async Task<ObjetRetour> InsertTbproprietaire(TbproprietaireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbproprietaire.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbproprietaire :\n  {value.ToString()}");
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

        public ObjetRetour MajTbproprietaire(TbproprietaireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbproprietaire.FindByCondition(v => v.IdProprio == value.IdProprio).FirstOrDefault();
                    data.IdProprio = value.IdProprio; data. 
                NomProprio = value.NomProprio; data. 
                PrenProPrio = value.PrenProPrio; data. 
                TelProprio = value.TelProprio; data. 
                AdrProprio = value.AdrProprio; data. 
                BpProprio = value.BpProprio; data. 
                MailProrio = value.MailProrio; data. 
                FaxProprio = value.FaxProprio; data. 
                DatEnreg = value.DatEnreg; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbproprietaire.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbproprietaire :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbproprietaire(TbproprietaireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbproprietaire.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbproprietaire :\n  {value.ToString()}");
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

        #region TbrubriqueConstatation

        public async Task<ObjetRetour> GetChargAllTbrubriqueConstatation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbrubriqueConstatation.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdRubConst, ValueType = d.LibRubConst});
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

        public ObjetRetour GetAllTbrubriqueConstatation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbrubriqueConstatation.FindAll().ToList();

                    var lstTbrubriqueConstatationDtos = new List<TbrubriqueConstatationDto>();

                    foreach (var item in datas)
                    {
                        lstTbrubriqueConstatationDtos.Add(TbrubriqueConstatationDto.FromModel(item));
                    }
                    retour.Contenu = lstTbrubriqueConstatationDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueConstatation");
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

        public async Task<ObjetRetour> GetTbrubriqueConstatation(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbrubriqueConstatation.FindByConditionAync(a => a.IdRubConst == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueConstatation");
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

        public async Task<ObjetRetour> InsertTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbrubriqueConstatation.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbrubriqueConstatation :\n  {value.ToString()}");
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

        public ObjetRetour MajTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbrubriqueConstatation.FindByCondition(v => v.IdRubConst == value.IdRubConst).FirstOrDefault();
                    data.IdRubConst = value.IdRubConst; data. 
                LibRubConst = value.LibRubConst; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbrubriqueConstatation.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbrubriqueConstatation :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbrubriqueConstatation.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbrubriqueConstatation :\n  {value.ToString()}");
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

        #region TbrubriqueEstimation

        public async Task<ObjetRetour> GetChargAllTbrubriqueEstimation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbrubriqueEstimation.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdRubEstim, ValueType = d.LibRubEstim});
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

        public ObjetRetour GetAllTbrubriqueEstimation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbrubriqueEstimation.FindAll().ToList();

                    var lstTbrubriqueEstimationDtos = new List<TbrubriqueEstimationDto>();

                    foreach (var item in datas)
                    {
                        lstTbrubriqueEstimationDtos.Add(TbrubriqueEstimationDto.FromModel(item));
                    }
                    retour.Contenu = lstTbrubriqueEstimationDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueEstimation");
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

        public async Task<ObjetRetour> GetTbrubriqueEstimation(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbrubriqueEstimation.FindByConditionAync(a => a.IdRubEstim == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueEstimation");
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

        public async Task<ObjetRetour> InsertTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbrubriqueEstimation.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbrubriqueEstimation :\n  {value.ToString()}");
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

        public ObjetRetour MajTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbrubriqueEstimation.FindByCondition(v => v.IdRubEstim == value.IdRubEstim).FirstOrDefault();
                    data.IdRubEstim = value.IdRubEstim; data. 
                LibRubEstim = value.LibRubEstim; data. 
                IdUser = value.IdUser; data. 
                DateCreation = value.DateCreation; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbrubriqueEstimation.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbrubriqueEstimation :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbrubriqueEstimation.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbrubriqueEstimation :\n  {value.ToString()}");
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

        #region TbrubriqueEvaluation

        public async Task<ObjetRetour> GetChargAllTbrubriqueEvaluation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbrubriqueEvaluation.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdRubEval, ValueType = d.LibRubEval});
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

        public ObjetRetour GetAllTbrubriqueEvaluation(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbrubriqueEvaluation.FindAll().ToList();

                    var lstTbrubriqueEvaluationDtos = new List<TbrubriqueEvaluationDto>();

                    foreach (var item in datas)
                    {
                        lstTbrubriqueEvaluationDtos.Add(TbrubriqueEvaluationDto.FromModel(item));
                    }
                    retour.Contenu = lstTbrubriqueEvaluationDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueEvaluation");
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

        public async Task<ObjetRetour> GetTbrubriqueEvaluation(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbrubriqueEvaluation.FindByConditionAync(a => a.IdRubEval == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueEvaluation");
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

        public async Task<ObjetRetour> InsertTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbrubriqueEvaluation.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbrubriqueEvaluation :\n  {value.ToString()}");
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

        public ObjetRetour MajTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbrubriqueEvaluation.FindByCondition(v => v.IdRubEval == value.IdRubEval).FirstOrDefault();
                    data.IdRubEval = value.IdRubEval; data. 
                LibRubEval = value.LibRubEval; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbrubriqueEvaluation.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbrubriqueEvaluation :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbrubriqueEvaluation.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbrubriqueEvaluation :\n  {value.ToString()}");
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


        #region TbrubriqueHonoraire

        public async Task<ObjetRetour> GetChargAllTbrubriqueHonoraire(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbrubriqueHonoraire.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.Idrubhonr, ValueType = d.Librubhonor});
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

        public ObjetRetour GetAllTbrubriqueHonoraire(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbrubriqueHonoraire.FindAll().ToList();

                    var lstTbrubriqueHonoraireDtos = new List<TbrubriqueHonoraireDto>();

                    foreach (var item in datas)
                    {
                        lstTbrubriqueHonoraireDtos.Add(TbrubriqueHonoraireDto.FromModel(item));
                    }
                    retour.Contenu = lstTbrubriqueHonoraireDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueHonoraire");
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

        public async Task<ObjetRetour> GetTbrubriqueHonoraire(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbrubriqueHonoraire.FindByConditionAync(a => a.Idrubhonr == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueHonoraire");
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

        public async Task<ObjetRetour> InsertTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbrubriqueHonoraire.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbrubriqueHonoraire :\n  {value.ToString()}");
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

        public ObjetRetour MajTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbrubriqueHonoraire.FindByCondition(v => v.Idrubhonr == value.Idrubhonr).FirstOrDefault();
                    data.Idrubhonr = value.Idrubhonr; data. 
                Librubhonor = value.Librubhonor; data. 
                IdUser = value.IdUser; data. 
                DateCreation = value.DateCreation; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbrubriqueHonoraire.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbrubriqueHonoraire :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbrubriqueHonoraire.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbrubriqueHonoraire :\n  {value.ToString()}");
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

        #region TbrubriqueMainOeuvre

        public async Task<ObjetRetour> GetChargAllTbrubriqueMainOeuvre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbrubriqueMainOeuvre.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdrubriqMo, ValueType = d.LibrubriqMo});
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

        public ObjetRetour GetAllTbrubriqueMainOeuvre(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbrubriqueMainOeuvre.FindAll().ToList();

                    var lstTbrubriqueMainOeuvreDtos = new List<TbrubriqueMainOeuvreDto>();

                    foreach (var item in datas)
                    {
                        lstTbrubriqueMainOeuvreDtos.Add(TbrubriqueMainOeuvreDto.FromModel(item));
                    }
                    retour.Contenu = lstTbrubriqueMainOeuvreDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueMainOeuvre");
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

        public async Task<ObjetRetour> GetTbrubriqueMainOeuvre(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbrubriqueMainOeuvre.FindByConditionAync(a => a.IdrubriqMo == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbrubriqueMainOeuvre");
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

        public async Task<ObjetRetour> InsertTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbrubriqueMainOeuvre.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbrubriqueMainOeuvre :\n  {value.ToString()}");
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

        public ObjetRetour MajTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbrubriqueMainOeuvre.FindByCondition(v => v.IdrubriqMo == value.IdrubriqMo).FirstOrDefault();
                    data.IdrubriqMo = value.IdrubriqMo; data. 
                LibrubriqMo = value.LibrubriqMo; data. 
                Nbre = value.Nbre; data. 
                IdUser = value.IdUser; ; data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.TbrubriqueMainOeuvre.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbrubriqueMainOeuvre :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbrubriqueMainOeuvre.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbrubriqueMainOeuvre :\n  {value.ToString()}");
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

        #region Tbservice

        public async Task<ObjetRetour> GetChargAllTbservice(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbservice.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdServ, ValueType = d.LibServ});
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

        public ObjetRetour GetAllTbservice(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbservice.FindAll().ToList();

                    var lstTbserviceDtos = new List<TbserviceDto>();

                    foreach (var item in datas)
                    {
                        lstTbserviceDtos.Add(TbserviceDto.FromModel(item));
                    }
                    retour.Contenu = lstTbserviceDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbservice");
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

        public async Task<ObjetRetour> GetTbservice(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbservice.FindByConditionAync(a => a.IdServ == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbservice");
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

        public async Task<ObjetRetour> InsertTbservice(TbserviceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbservice.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbservice :\n  {value.ToString()}");
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

        public ObjetRetour MajTbservice(TbserviceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbservice.FindByCondition(v => v.IdServ == value.IdServ).FirstOrDefault();
                    data.IdServ = value.IdServ; data. 
                LibServ = value.LibServ; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbservice.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbservice :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbservice(TbserviceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbservice.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbservice :\n  {value.ToString()}");
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

        #region Tbnote

        public async Task<ObjetRetour> GetChargAllTbnote(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbnote.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdNot, ValueType = d.LibelleNot });
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

        public ObjetRetour GetAllTbnote(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbnote.FindAll().ToList();

                    var lstTbnoteDtos = new List<TbnoteDto>();

                    foreach (var item in datas)
                    {
                        lstTbnoteDtos.Add(TbnoteDto.FromModel(item));
                    }
                    retour.Contenu = lstTbnoteDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbnote");
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

        public async Task<ObjetRetour> GetTbnote(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbnote.FindByConditionAync(a => a.IdNot == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbnote");
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

        public async Task<ObjetRetour> InsertTbnote(TbnoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbnote.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbnote :\n  {value.ToString()}");
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

        public ObjetRetour MajTbnote(TbnoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbnote.FindByCondition(v => v.IdNot == value.IdNot).FirstOrDefault();
                    data.IdNot = value.IdNot;
                    data.LibelleNot = value.LibelleNot;
                    data.Idtypnote = value.Idtypnote;
                    data.IdUser = value.IdUser;
                    data.ModifieLe = value.ModifieLe;
                    data.ModifiePar = value.ModifiePar;
                    data.StateCode = value.StateCode;
                    data.StatusCode = value.StatusCode;

                    _service.Tbnote.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbnote :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbnote(TbnoteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbnote.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbnote :\n  {value.ToString()}");
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


        #region TbtarifHoraire

        public async Task<ObjetRetour> GetChargAllTbtarifHoraire(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.TbtarifHoraire.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdTarifHor, Code = d.MtTarifHor });
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

        public ObjetRetour GetAllTbtarifHoraire(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.TbtarifHoraire.FindAll().ToList();

                    var lstTbtarifHoraireDtos = new List<TbtarifHoraireDto>();

                    foreach (var item in datas)
                    {
                        lstTbtarifHoraireDtos.Add(TbtarifHoraireDto.FromModel(item));
                    }
                    retour.Contenu = lstTbtarifHoraireDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtarifHoraire");
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

        public async Task<ObjetRetour> GetTbtarifHoraire(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TbtarifHoraire.FindByConditionAync(a => a.IdTarifHor == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT TbtarifHoraire");
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

        public async Task<ObjetRetour> InsertTbtarifHoraire(TbtarifHoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.TbtarifHoraire.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION TbtarifHoraire :\n  {value.ToString()}");
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

        public ObjetRetour MajTbtarifHoraire(TbtarifHoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.TbtarifHoraire.FindByCondition(v => v.IdTarifHor == value.IdTarifHor).FirstOrDefault();
                    data.IdTarifHor = value.IdTarifHor;
                    data.MtTarifHor = value.MtTarifHor;
                    data.IdUser = value.IdUser;
                    data.ModifieLe = value.ModifieLe;
                    data.ModifiePar = value.ModifiePar;
                    data.StateCode = value.StateCode;
                    data.StatusCode = value.StatusCode;

                    _service.TbtarifHoraire.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE TbtarifHoraire :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbtarifHoraire(TbtarifHoraireDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.TbtarifHoraire.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION TbtarifHoraire :\n  {value.ToString()}");
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


        #region Tbspecialite

        public async Task<ObjetRetour> GetChargAllTbspecialite(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbspecialite.FindByConditionAync(m => m.StateCode == (int)StateCode.Actif);
                    retour.Contenu = datas.Select(d => new ObjetParamModel { Id = d.IdSpec, ValueType = d.LibSepec});
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

        public ObjetRetour GetAllTbspecialite(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    var datas = _service.Tbspecialite.FindAll().ToList();

                    var lstTbspecialiteDtos = new List<TbspecialiteDto>();

                    foreach (var item in datas)
                    {
                        lstTbspecialiteDtos.Add(TbspecialiteDto.FromModel(item));
                    }
                    retour.Contenu = lstTbspecialiteDtos;


                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbspecialite");
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

        public async Task<ObjetRetour> GetTbspecialite(decimal id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Tbspecialite.FindByConditionAync(a => a.IdSpec == id);
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SELECT Tbspecialite");
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

        public async Task<ObjetRetour> InsertTbspecialite(TbspecialiteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    await _service.Tbspecialite.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION Tbspecialite :\n  {value.ToString()}");
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

        public ObjetRetour MajTbspecialite(TbspecialiteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var data = _service.Tbspecialite.FindByCondition(v => v.IdSpec == value.IdSpec).FirstOrDefault();
                    data.IdSpec = value.IdSpec; data. 
                LibSepec = value.LibSepec; data. 
                IdServ = value.IdServ; data. 
                IdUser = value.IdUser;  data. 
                ModifieLe = value.ModifieLe; data. 
                ModifiePar = value.ModifiePar; data. 
                StateCode = value.StateCode; data. 
                StatusCode = value.StatusCode;

                    _service.Tbspecialite.Update(data);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Tbspecialite :\n  {value.ToString()}");
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

        public ObjetRetour DeleteTbspecialite(TbspecialiteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    _service.Tbspecialite.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Tbspecialite :\n  {value.ToString()}");
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
                    var datas = _service.Tbville.FindAll().ToList();

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
