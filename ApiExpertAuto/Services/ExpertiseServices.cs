using ApiExpertAuto.IServices;
using ApiExpertAuto.Models;
using Contracts;
using Entities.Models;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Entities.Enumeration.Enumeration;

namespace ApiExpertAuto.Services
{
    public class ExpertiseServices : IExpertiseServices
    {

        private IRepositoryWrapper _service { get; set; }
        private ILoggerManager _logger { get; set; }
        private ICommunServices _commun { get; set; }

        public ExpertiseServices(IRepositoryWrapper service, ILoggerManager logger, ICommunServices communService)
        {
            _service = service;
            _logger = logger;
            _commun = communService;
        }

        #region Expertise standard

        public async Task<ObjetRetour> GetExpertiseParDossier(int IdDossier, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbexpertise.FindByConditionAync(e => e.IdDoss== IdDossier &&  e.StateCode == (int)StateCode.Actif);
                    var expertise = datas.Select(model => new ExpertiseStandardModel {
                        IdExpert = model.IdExpert,
                        NumExpert = model.NumExpert,
                        Kilometrage = model.Kilometrage,
                        VuAvT = model.VuAvT,
                        VuPdtT = model.VuPdtT,
                        VuApT = model.VuApT,
                        Duree = model.Duree,
                        LieuVisite = model.LieuVisite,
                        ValeurNeuve = model.ValeurNeuve,
                        Depreciation = model.Depreciation,
                        ValeurVenale = model.ValeurVenale,
                        Avd = model.Avd,
                        Avgp = model.Avgp,
                        Ard = model.Ard,
                        Arg = model.Arg,
                        Indep = model.Indep,
                        Reseau = model.Reseau,
                        Hreseau = model.Hreseau,
                        EuxMeme = model.EuxMeme,
                        Inconnu = model.Inconnu,
                        NonProf = model.NonProf,
                        IdVeh = model.IdVeh,
                        IdGara = model.IdGara,
                        IdEtatEntretien = model.IdEtatEntretien,
                        IdDoss = model.IdDoss,
                        Idtypnote = model.Idtypnote,
                        DatEnreg = model.DatEnreg,
                        HeurEnreg = model.HeurEnreg,
                        Typnote = model.Typnote,
                        Numero = model.Numero,
                        IdUser = model.IdUser,
                        Epave = model.Epave,
                        ValeurSauvetage = model.ValeurSauvetage,
                        EconoIrrep = model.EconoIrrep,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).FirstOrDefault();

                   var lstIdPc = _service.TbexpertisePointChoc.FindByCondition(ep=>ep.Idexpert== expertise.IdExpert).Select(ep=> ep.Idpointchoc).ToList();
                    expertise.PointChocs = _service.TbpointChoc.FindByCondition(pc => lstIdPc.Contains(pc.IdPointChoc)).Select(model => new TbpointChocDto
                    {
                        IdPointChoc = model.IdPointChoc,
                        LibPointChoc = model.LibPointChoc,
                        IdUser = model.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();
                    retour.Contenu = expertise;
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

        public async Task<ObjetRetour> InsertExpertiseStandard(ExpertiseStandardModel value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var lstExpertisePointChoc = value.ExpertisePointChocs.Select(model => new TbexpertisePointChoc 
                    {
                        Idexpert = model.Idexpert,
                        Idpointchoc = model.Idpointchoc,
                        IdFourn = model.IdFourn,
                        Ligne = model.Ligne,
                        IdUser = value.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();

                    var expertise = value.ToModel();
                    expertise.TbexpertisePointChoc = lstExpertisePointChoc;

                    await _service.Tbexpertise.CreateAsync(expertise);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION expertise standard :\n  {value.ToString()}");
                }
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

        public ObjetRetour MajExpertiseStandard(ExpertiseStandardModel value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {

                    var pointchocsExistant = _service.TbexpertisePointChoc.FindByCondition(epc => epc.Idexpert == value.IdExpert);
                    var lsidPs = pointchocsExistant.Select(p => p.Idpointchoc);

                    var pointchocsNvx = value.ExpertisePointChocs.Where(p =>
                    lsidPs.Contains(p.Idpointchoc)).ToList();

                    var expertiseExistant = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();

                    expertiseExistant.IdExpert = value.IdExpert;
                    expertiseExistant.NumExpert = value.NumExpert;
                    expertiseExistant.Kilometrage = value.Kilometrage;
                    expertiseExistant.VuAvT = value.VuAvT;
                    expertiseExistant.VuPdtT = value.VuPdtT;
                    expertiseExistant.VuApT = value.VuApT;
                    expertiseExistant.Duree = value.Duree;
                    expertiseExistant.LieuVisite = value.LieuVisite;
                    expertiseExistant.ValeurNeuve = value.ValeurNeuve;
                    expertiseExistant.Depreciation = value.Depreciation;
                    expertiseExistant.ValeurVenale = value.ValeurVenale;
                    expertiseExistant.Avd = value.Avd;
                    expertiseExistant.Avgp = value.Avgp;
                    expertiseExistant.Ard = value.Ard;
                    expertiseExistant.Arg = value.Arg;
                    expertiseExistant.Indep = value.Indep;
                    expertiseExistant.Reseau = value.Reseau;
                    expertiseExistant.Hreseau = value.Hreseau;
                    expertiseExistant.EuxMeme = value.EuxMeme;
                    expertiseExistant.Inconnu = value.Inconnu;
                    expertiseExistant.NonProf = value.NonProf;
                    expertiseExistant.IdVeh = value.IdVeh;
                    expertiseExistant.IdGara = value.IdGara;
                    expertiseExistant.IdEtatEntretien = value.IdEtatEntretien;
                    expertiseExistant.IdDoss = value.IdDoss;
                    expertiseExistant.Idtypnote = value.Idtypnote;
                    //expertiseExistant.DatEnreg = value.DatEnreg;
                    //expertiseExistant.HeurEnreg = value.HeurEnreg;
                    expertiseExistant.Typnote = value.Typnote;
                    expertiseExistant.Numero = value.Numero;
                    expertiseExistant.IdUser = value.IdUser;
                    expertiseExistant.Epave = value.Epave;
                    expertiseExistant.ValeurSauvetage = value.ValeurSauvetage;
                    expertiseExistant.EconoIrrep = value.EconoIrrep;
                    //expertiseExistant.DateCreation = value.DateCreation;
                    expertiseExistant.ModifieLe = value.ModifieLe;
                    expertiseExistant.ModifiePar = value.ModifiePar;
                    expertiseExistant.StateCode = value.StateCode;
                    expertiseExistant.StatusCode = value.StatusCode;

                    expertiseExistant.TbexpertisePointChoc = pointchocsNvx.Select(model => new TbexpertisePointChoc
                    {
                        Idexpert = model.Idexpert,
                        Idpointchoc = model.Idpointchoc,
                        IdFourn = model.IdFourn,
                        Ligne = model.Ligne,
                        IdUser = value.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();

                    _service.Tbexpertise.Update(expertiseExistant);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Expertise standard :\n  {value.ToString()}");
                }
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


        public ObjetRetour DeleteTbexpertise(TbexpertiseDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                   var expertise = _service.Tbexpertise.FindByCondition(e=> e.IdExpert == value.IdExpert).FirstOrDefault();
                    expertise.StatusCode = (int)StatutCode.Suppression_En_cours;
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS demande de  SUPPRESSION standard  :\n  {value.ToString()}");
                }
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

        public ObjetRetour ValiderDeleteTbexpertise(TbexpertiseDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
                    expertise.StatusCode = (int)StatutCode.Supprimer;
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS SUPPRESSION Expertise standard confirmée :\n  {value.ToString()}");
                }
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

        #region Expertise EI

        public async Task<ObjetRetour> GetExpertiseEIParDossier(int IdDossier, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
                {

                    var datas = await _service.Tbexpertise.FindByConditionAync(e => e.IdDoss == IdDossier && e.StateCode == (int)StateCode.Actif);
                    var expertise = datas.Select(model => new ExpertiseEIModel
                    {
                        IdExpert = model.IdExpert,
                        NumExpert = model.NumExpert,
                        Kilometrage = model.Kilometrage,
                        VuAvT = model.VuAvT,
                        VuPdtT = model.VuPdtT,
                        VuApT = model.VuApT,
                        Duree = model.Duree,
                        LieuVisite = model.LieuVisite,
                        ValeurNeuve = model.ValeurNeuve,
                        Depreciation = model.Depreciation,
                        ValeurVenale = model.ValeurVenale,
                        Avd = model.Avd,
                        Avgp = model.Avgp,
                        Ard = model.Ard,
                        Arg = model.Arg,
                        Indep = model.Indep,
                        Reseau = model.Reseau,
                        Hreseau = model.Hreseau,
                        EuxMeme = model.EuxMeme,
                        Inconnu = model.Inconnu,
                        NonProf = model.NonProf,
                        IdVeh = model.IdVeh,
                        IdGara = model.IdGara,
                        IdEtatEntretien = model.IdEtatEntretien,
                        IdDoss = model.IdDoss,
                        Idtypnote = model.Idtypnote,
                        DatEnreg = model.DatEnreg,
                        HeurEnreg = model.HeurEnreg,
                        Typnote = model.Typnote,
                        Numero = model.Numero,
                        IdUser = model.IdUser,
                        Epave = model.Epave,
                        ValeurSauvetage = model.ValeurSauvetage,
                        EconoIrrep = model.EconoIrrep,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).FirstOrDefault();

                    var lstIdPc = _service.TbexpertisePointChoc.FindByCondition(ep => ep.Idexpert == expertise.IdExpert).Select(ep => ep.Idpointchoc).ToList();
                    expertise.PointChocs = _service.TbpointChoc.FindByCondition(pc => lstIdPc.Contains(pc.IdPointChoc)).Select(model => new TbpointChocDto
                    {
                        IdPointChoc = model.IdPointChoc,
                        LibPointChoc = model.LibPointChoc,
                        IdUser = model.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();
                    retour.Contenu = expertise;
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


        public async Task<ObjetRetour> InsertExpertiseStandard(ExpertiseEIModel value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {
                    var lstExpertisePointChoc = value.ExpertisePointChocs.Select(model => new TbexpertisePointChoc
                    {
                        Idexpert = model.Idexpert,
                        Idpointchoc = model.Idpointchoc,
                        IdFourn = model.IdFourn,
                        Ligne = model.Ligne,
                        IdUser = value.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();

                    var expertise = value.ToModel();
                    expertise.TbexpertisePointChoc = lstExpertisePointChoc;

                    await _service.Tbexpertise.CreateAsync(expertise);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS INSERTION expertise standard :\n  {value.ToString()}");
                }
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

        public ObjetRetour MajExpertiseEI(ExpertiseEIModel value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
                {

                    var pointchocsExistant = _service.TbexpertisePointChoc.FindByCondition(epc => epc.Idexpert == value.IdExpert);
                    var lsidPs = pointchocsExistant.Select(p => p.Idpointchoc);

                    var pointchocsNvx = value.ExpertisePointChocs.Where(p =>
                    lsidPs.Contains(p.Idpointchoc)).ToList();

                    var expertiseExistant = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();

                    expertiseExistant.IdExpert = value.IdExpert;
                    expertiseExistant.NumExpert = value.NumExpert;
                    expertiseExistant.Kilometrage = value.Kilometrage;
                    expertiseExistant.VuAvT = value.VuAvT;
                    expertiseExistant.VuPdtT = value.VuPdtT;
                    expertiseExistant.VuApT = value.VuApT;
                    expertiseExistant.Duree = value.Duree;
                    expertiseExistant.LieuVisite = value.LieuVisite;
                    expertiseExistant.ValeurNeuve = value.ValeurNeuve;
                    expertiseExistant.Depreciation = value.Depreciation;
                    expertiseExistant.ValeurVenale = value.ValeurVenale;
                    expertiseExistant.Avd = value.Avd;
                    expertiseExistant.Avgp = value.Avgp;
                    expertiseExistant.Ard = value.Ard;
                    expertiseExistant.Arg = value.Arg;
                    expertiseExistant.Indep = value.Indep;
                    expertiseExistant.Reseau = value.Reseau;
                    expertiseExistant.Hreseau = value.Hreseau;
                    expertiseExistant.EuxMeme = value.EuxMeme;
                    expertiseExistant.Inconnu = value.Inconnu;
                    expertiseExistant.NonProf = value.NonProf;
                    expertiseExistant.IdVeh = value.IdVeh;
                    expertiseExistant.IdGara = value.IdGara;
                    expertiseExistant.IdEtatEntretien = value.IdEtatEntretien;
                    expertiseExistant.IdDoss = value.IdDoss;
                    expertiseExistant.Idtypnote = value.Idtypnote;
                    //expertiseExistant.DatEnreg = value.DatEnreg;
                    //expertiseExistant.HeurEnreg = value.HeurEnreg;
                    expertiseExistant.Typnote = value.Typnote;
                    expertiseExistant.Numero = value.Numero;
                    expertiseExistant.IdUser = value.IdUser;
                    expertiseExistant.Epave = value.Epave;
                    expertiseExistant.ValeurSauvetage = value.ValeurSauvetage;
                    expertiseExistant.EconoIrrep = value.EconoIrrep;
                    //expertiseExistant.DateCreation = value.DateCreation;
                    expertiseExistant.ModifieLe = value.ModifieLe;
                    expertiseExistant.ModifiePar = value.ModifiePar;
                    expertiseExistant.StateCode = value.StateCode;
                    expertiseExistant.StatusCode = value.StatusCode;

                    expertiseExistant.TbexpertisePointChoc = pointchocsNvx.Select(model => new TbexpertisePointChoc
                    {
                        Idexpert = model.Idexpert,
                        Idpointchoc = model.Idpointchoc,
                        IdFourn = model.IdFourn,
                        Ligne = model.Ligne,
                        IdUser = value.IdUser,
                        DateCreation = model.DateCreation,
                        ModifieLe = model.ModifieLe,
                        ModifiePar = model.ModifiePar,
                        StateCode = model.StateCode,
                        StatusCode = model.StatusCode
                    }).ToList();

                    _service.Tbexpertise.Update(expertiseExistant);
                    _service.Save();
                    retour.Etat = true;
                    _logger.LogInfo($"SUCCESS UPDATE Expertise standard :\n  {value.ToString()}");
                }
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

        //#region Expertise standard

        //public async Task<ObjetRetour> GetExpertiseParDossier(int IdDossier, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {

        //            var datas = await _service.Tbexpertise.FindByConditionAync(e => e.IdDoss == IdDossier && e.StateCode == (int)StateCode.Actif);
        //            var expertise = datas.Select(model => new ExpertiseStandardModel
        //            {
        //                IdExpert = model.IdExpert,
        //                NumExpert = model.NumExpert,
        //                Kilometrage = model.Kilometrage,
        //                VuAvT = model.VuAvT,
        //                VuPdtT = model.VuPdtT,
        //                VuApT = model.VuApT,
        //                Duree = model.Duree,
        //                LieuVisite = model.LieuVisite,
        //                ValeurNeuve = model.ValeurNeuve,
        //                Depreciation = model.Depreciation,
        //                ValeurVenale = model.ValeurVenale,
        //                Avd = model.Avd,
        //                Avgp = model.Avgp,
        //                Ard = model.Ard,
        //                Arg = model.Arg,
        //                Indep = model.Indep,
        //                Reseau = model.Reseau,
        //                Hreseau = model.Hreseau,
        //                EuxMeme = model.EuxMeme,
        //                Inconnu = model.Inconnu,
        //                NonProf = model.NonProf,
        //                IdVeh = model.IdVeh,
        //                IdGara = model.IdGara,
        //                IdEtatEntretien = model.IdEtatEntretien,
        //                IdDoss = model.IdDoss,
        //                Idtypnote = model.Idtypnote,
        //                DatEnreg = model.DatEnreg,
        //                HeurEnreg = model.HeurEnreg,
        //                Typnote = model.Typnote,
        //                Numero = model.Numero,
        //                IdUser = model.IdUser,
        //                Epave = model.Epave,
        //                ValeurSauvetage = model.ValeurSauvetage,
        //                EconoIrrep = model.EconoIrrep,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).FirstOrDefault();

        //            var lstIdPc = _service.TbexpertisePointChoc.FindByCondition(ep => ep.Idexpert == expertise.IdExpert).Select(ep => ep.Idpointchoc).ToList();
        //            expertise.PointChocs = _service.TbpointChoc.FindByCondition(pc => lstIdPc.Contains(pc.IdPointChoc)).Select(model => new TbpointChocDto
        //            {
        //                IdPointChoc = model.IdPointChoc,
        //                LibPointChoc = model.LibPointChoc,
        //                IdUser = model.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();
        //            retour.Contenu = expertise;
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public ObjetRetour GetAllTbassurance(string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            var datas = _service.Tbassurance.FindAll().ToList();

        //            var lstTbassuranceDtos = new List<TbassuranceDto>();

        //            foreach (var item in datas)
        //            {
        //                lstTbassuranceDtos.Add(TbassuranceDto.FromModel(item));
        //            }
        //            retour.Contenu = lstTbassuranceDtos;


        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public async Task<ObjetRetour> GetTbassurance(decimal id, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {

        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            retour.Contenu = await _service.Tbassurance.FindByConditionAync(a => a.IdAssur == id);
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }

        //    return retour;
        //}

        //public async Task<ObjetRetour> InsertExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var lstExpertisePointChoc = value.ExpertisePointChocs.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            var expertise = value.ToModel();
        //            expertise.TbexpertisePointChoc = lstExpertisePointChoc;

        //            await _service.Tbexpertise.CreateAsync(expertise);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS INSERTION expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return retour;
        //}

        //public ObjetRetour MajExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {

        //            var pointchocsExistant = _service.TbexpertisePointChoc.FindByCondition(epc => epc.Idexpert == value.IdExpert);
        //            var lsidPs = pointchocsExistant.Select(p => p.Idpointchoc);

        //            var pointchocsNvx = value.ExpertisePointChocs.Where(p =>
        //            lsidPs.Contains(p.Idpointchoc)).ToList();

        //            var expertiseExistant = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();

        //            expertiseExistant.IdExpert = value.IdExpert;
        //            expertiseExistant.NumExpert = value.NumExpert;
        //            expertiseExistant.Kilometrage = value.Kilometrage;
        //            expertiseExistant.VuAvT = value.VuAvT;
        //            expertiseExistant.VuPdtT = value.VuPdtT;
        //            expertiseExistant.VuApT = value.VuApT;
        //            expertiseExistant.Duree = value.Duree;
        //            expertiseExistant.LieuVisite = value.LieuVisite;
        //            expertiseExistant.ValeurNeuve = value.ValeurNeuve;
        //            expertiseExistant.Depreciation = value.Depreciation;
        //            expertiseExistant.ValeurVenale = value.ValeurVenale;
        //            expertiseExistant.Avd = value.Avd;
        //            expertiseExistant.Avgp = value.Avgp;
        //            expertiseExistant.Ard = value.Ard;
        //            expertiseExistant.Arg = value.Arg;
        //            expertiseExistant.Indep = value.Indep;
        //            expertiseExistant.Reseau = value.Reseau;
        //            expertiseExistant.Hreseau = value.Hreseau;
        //            expertiseExistant.EuxMeme = value.EuxMeme;
        //            expertiseExistant.Inconnu = value.Inconnu;
        //            expertiseExistant.NonProf = value.NonProf;
        //            expertiseExistant.IdVeh = value.IdVeh;
        //            expertiseExistant.IdGara = value.IdGara;
        //            expertiseExistant.IdEtatEntretien = value.IdEtatEntretien;
        //            expertiseExistant.IdDoss = value.IdDoss;
        //            expertiseExistant.Idtypnote = value.Idtypnote;
        //            //expertiseExistant.DatEnreg = value.DatEnreg;
        //            //expertiseExistant.HeurEnreg = value.HeurEnreg;
        //            expertiseExistant.Typnote = value.Typnote;
        //            expertiseExistant.Numero = value.Numero;
        //            expertiseExistant.IdUser = value.IdUser;
        //            expertiseExistant.Epave = value.Epave;
        //            expertiseExistant.ValeurSauvetage = value.ValeurSauvetage;
        //            expertiseExistant.EconoIrrep = value.EconoIrrep;
        //            //expertiseExistant.DateCreation = value.DateCreation;
        //            expertiseExistant.ModifieLe = value.ModifieLe;
        //            expertiseExistant.ModifiePar = value.ModifiePar;
        //            expertiseExistant.StateCode = value.StateCode;
        //            expertiseExistant.StatusCode = value.StatusCode;

        //            expertiseExistant.TbexpertisePointChoc = pointchocsNvx.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            _service.Tbexpertise.Update(expertiseExistant);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS UPDATE Expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}


        //public ObjetRetour DeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Suppression_En_cours;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS demande de  SUPPRESSION standard  :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //public ObjetRetour ValiderDeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Supprimer;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SUPPRESSION Expertise standard confirmée :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //#endregion

        //#region Expertise standard

        //public async Task<ObjetRetour> GetExpertiseParDossier(int IdDossier, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {

        //            var datas = await _service.Tbexpertise.FindByConditionAync(e => e.IdDoss == IdDossier && e.StateCode == (int)StateCode.Actif);
        //            var expertise = datas.Select(model => new ExpertiseStandardModel
        //            {
        //                IdExpert = model.IdExpert,
        //                NumExpert = model.NumExpert,
        //                Kilometrage = model.Kilometrage,
        //                VuAvT = model.VuAvT,
        //                VuPdtT = model.VuPdtT,
        //                VuApT = model.VuApT,
        //                Duree = model.Duree,
        //                LieuVisite = model.LieuVisite,
        //                ValeurNeuve = model.ValeurNeuve,
        //                Depreciation = model.Depreciation,
        //                ValeurVenale = model.ValeurVenale,
        //                Avd = model.Avd,
        //                Avgp = model.Avgp,
        //                Ard = model.Ard,
        //                Arg = model.Arg,
        //                Indep = model.Indep,
        //                Reseau = model.Reseau,
        //                Hreseau = model.Hreseau,
        //                EuxMeme = model.EuxMeme,
        //                Inconnu = model.Inconnu,
        //                NonProf = model.NonProf,
        //                IdVeh = model.IdVeh,
        //                IdGara = model.IdGara,
        //                IdEtatEntretien = model.IdEtatEntretien,
        //                IdDoss = model.IdDoss,
        //                Idtypnote = model.Idtypnote,
        //                DatEnreg = model.DatEnreg,
        //                HeurEnreg = model.HeurEnreg,
        //                Typnote = model.Typnote,
        //                Numero = model.Numero,
        //                IdUser = model.IdUser,
        //                Epave = model.Epave,
        //                ValeurSauvetage = model.ValeurSauvetage,
        //                EconoIrrep = model.EconoIrrep,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).FirstOrDefault();

        //            var lstIdPc = _service.TbexpertisePointChoc.FindByCondition(ep => ep.Idexpert == expertise.IdExpert).Select(ep => ep.Idpointchoc).ToList();
        //            expertise.PointChocs = _service.TbpointChoc.FindByCondition(pc => lstIdPc.Contains(pc.IdPointChoc)).Select(model => new TbpointChocDto
        //            {
        //                IdPointChoc = model.IdPointChoc,
        //                LibPointChoc = model.LibPointChoc,
        //                IdUser = model.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();
        //            retour.Contenu = expertise;
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public ObjetRetour GetAllTbassurance(string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            var datas = _service.Tbassurance.FindAll().ToList();

        //            var lstTbassuranceDtos = new List<TbassuranceDto>();

        //            foreach (var item in datas)
        //            {
        //                lstTbassuranceDtos.Add(TbassuranceDto.FromModel(item));
        //            }
        //            retour.Contenu = lstTbassuranceDtos;


        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public async Task<ObjetRetour> GetTbassurance(decimal id, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {

        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            retour.Contenu = await _service.Tbassurance.FindByConditionAync(a => a.IdAssur == id);
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }

        //    return retour;
        //}

        //public async Task<ObjetRetour> InsertExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var lstExpertisePointChoc = value.ExpertisePointChocs.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            var expertise = value.ToModel();
        //            expertise.TbexpertisePointChoc = lstExpertisePointChoc;

        //            await _service.Tbexpertise.CreateAsync(expertise);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS INSERTION expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return retour;
        //}

        //public ObjetRetour MajExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {

        //            var pointchocsExistant = _service.TbexpertisePointChoc.FindByCondition(epc => epc.Idexpert == value.IdExpert);
        //            var lsidPs = pointchocsExistant.Select(p => p.Idpointchoc);

        //            var pointchocsNvx = value.ExpertisePointChocs.Where(p =>
        //            lsidPs.Contains(p.Idpointchoc)).ToList();

        //            var expertiseExistant = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();

        //            expertiseExistant.IdExpert = value.IdExpert;
        //            expertiseExistant.NumExpert = value.NumExpert;
        //            expertiseExistant.Kilometrage = value.Kilometrage;
        //            expertiseExistant.VuAvT = value.VuAvT;
        //            expertiseExistant.VuPdtT = value.VuPdtT;
        //            expertiseExistant.VuApT = value.VuApT;
        //            expertiseExistant.Duree = value.Duree;
        //            expertiseExistant.LieuVisite = value.LieuVisite;
        //            expertiseExistant.ValeurNeuve = value.ValeurNeuve;
        //            expertiseExistant.Depreciation = value.Depreciation;
        //            expertiseExistant.ValeurVenale = value.ValeurVenale;
        //            expertiseExistant.Avd = value.Avd;
        //            expertiseExistant.Avgp = value.Avgp;
        //            expertiseExistant.Ard = value.Ard;
        //            expertiseExistant.Arg = value.Arg;
        //            expertiseExistant.Indep = value.Indep;
        //            expertiseExistant.Reseau = value.Reseau;
        //            expertiseExistant.Hreseau = value.Hreseau;
        //            expertiseExistant.EuxMeme = value.EuxMeme;
        //            expertiseExistant.Inconnu = value.Inconnu;
        //            expertiseExistant.NonProf = value.NonProf;
        //            expertiseExistant.IdVeh = value.IdVeh;
        //            expertiseExistant.IdGara = value.IdGara;
        //            expertiseExistant.IdEtatEntretien = value.IdEtatEntretien;
        //            expertiseExistant.IdDoss = value.IdDoss;
        //            expertiseExistant.Idtypnote = value.Idtypnote;
        //            //expertiseExistant.DatEnreg = value.DatEnreg;
        //            //expertiseExistant.HeurEnreg = value.HeurEnreg;
        //            expertiseExistant.Typnote = value.Typnote;
        //            expertiseExistant.Numero = value.Numero;
        //            expertiseExistant.IdUser = value.IdUser;
        //            expertiseExistant.Epave = value.Epave;
        //            expertiseExistant.ValeurSauvetage = value.ValeurSauvetage;
        //            expertiseExistant.EconoIrrep = value.EconoIrrep;
        //            //expertiseExistant.DateCreation = value.DateCreation;
        //            expertiseExistant.ModifieLe = value.ModifieLe;
        //            expertiseExistant.ModifiePar = value.ModifiePar;
        //            expertiseExistant.StateCode = value.StateCode;
        //            expertiseExistant.StatusCode = value.StatusCode;

        //            expertiseExistant.TbexpertisePointChoc = pointchocsNvx.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            _service.Tbexpertise.Update(expertiseExistant);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS UPDATE Expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}


        //public ObjetRetour DeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Suppression_En_cours;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS demande de  SUPPRESSION standard  :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //public ObjetRetour ValiderDeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Supprimer;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SUPPRESSION Expertise standard confirmée :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //#endregion

        //#region Expertise standard

        //public async Task<ObjetRetour> GetExpertiseParDossier(int IdDossier, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {

        //            var datas = await _service.Tbexpertise.FindByConditionAync(e => e.IdDoss == IdDossier && e.StateCode == (int)StateCode.Actif);
        //            var expertise = datas.Select(model => new ExpertiseStandardModel
        //            {
        //                IdExpert = model.IdExpert,
        //                NumExpert = model.NumExpert,
        //                Kilometrage = model.Kilometrage,
        //                VuAvT = model.VuAvT,
        //                VuPdtT = model.VuPdtT,
        //                VuApT = model.VuApT,
        //                Duree = model.Duree,
        //                LieuVisite = model.LieuVisite,
        //                ValeurNeuve = model.ValeurNeuve,
        //                Depreciation = model.Depreciation,
        //                ValeurVenale = model.ValeurVenale,
        //                Avd = model.Avd,
        //                Avgp = model.Avgp,
        //                Ard = model.Ard,
        //                Arg = model.Arg,
        //                Indep = model.Indep,
        //                Reseau = model.Reseau,
        //                Hreseau = model.Hreseau,
        //                EuxMeme = model.EuxMeme,
        //                Inconnu = model.Inconnu,
        //                NonProf = model.NonProf,
        //                IdVeh = model.IdVeh,
        //                IdGara = model.IdGara,
        //                IdEtatEntretien = model.IdEtatEntretien,
        //                IdDoss = model.IdDoss,
        //                Idtypnote = model.Idtypnote,
        //                DatEnreg = model.DatEnreg,
        //                HeurEnreg = model.HeurEnreg,
        //                Typnote = model.Typnote,
        //                Numero = model.Numero,
        //                IdUser = model.IdUser,
        //                Epave = model.Epave,
        //                ValeurSauvetage = model.ValeurSauvetage,
        //                EconoIrrep = model.EconoIrrep,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).FirstOrDefault();

        //            var lstIdPc = _service.TbexpertisePointChoc.FindByCondition(ep => ep.Idexpert == expertise.IdExpert).Select(ep => ep.Idpointchoc).ToList();
        //            expertise.PointChocs = _service.TbpointChoc.FindByCondition(pc => lstIdPc.Contains(pc.IdPointChoc)).Select(model => new TbpointChocDto
        //            {
        //                IdPointChoc = model.IdPointChoc,
        //                LibPointChoc = model.LibPointChoc,
        //                IdUser = model.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();
        //            retour.Contenu = expertise;
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public ObjetRetour GetAllTbassurance(string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            var datas = _service.Tbassurance.FindAll().ToList();

        //            var lstTbassuranceDtos = new List<TbassuranceDto>();

        //            foreach (var item in datas)
        //            {
        //                lstTbassuranceDtos.Add(TbassuranceDto.FromModel(item));
        //            }
        //            retour.Contenu = lstTbassuranceDtos;


        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;

        //}

        //public async Task<ObjetRetour> GetTbassurance(decimal id, string token = "")
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {

        //        if (_commun.ConnexionValide(token) == (int)enumEtat.Valide)
        //        {
        //            retour.Contenu = await _service.Tbassurance.FindByConditionAync(a => a.IdAssur == id);
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SELECT Tbassurance");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }

        //    return retour;
        //}

        //public async Task<ObjetRetour> InsertExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var lstExpertisePointChoc = value.ExpertisePointChocs.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            var expertise = value.ToModel();
        //            expertise.TbexpertisePointChoc = lstExpertisePointChoc;

        //            await _service.Tbexpertise.CreateAsync(expertise);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS INSERTION expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //        _logger.LogError(ex.Message);
        //    }
        //    return retour;
        //}

        //public ObjetRetour MajExpertiseStandard(ExpertiseStandardModel value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {

        //            var pointchocsExistant = _service.TbexpertisePointChoc.FindByCondition(epc => epc.Idexpert == value.IdExpert);
        //            var lsidPs = pointchocsExistant.Select(p => p.Idpointchoc);

        //            var pointchocsNvx = value.ExpertisePointChocs.Where(p =>
        //            lsidPs.Contains(p.Idpointchoc)).ToList();

        //            var expertiseExistant = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();

        //            expertiseExistant.IdExpert = value.IdExpert;
        //            expertiseExistant.NumExpert = value.NumExpert;
        //            expertiseExistant.Kilometrage = value.Kilometrage;
        //            expertiseExistant.VuAvT = value.VuAvT;
        //            expertiseExistant.VuPdtT = value.VuPdtT;
        //            expertiseExistant.VuApT = value.VuApT;
        //            expertiseExistant.Duree = value.Duree;
        //            expertiseExistant.LieuVisite = value.LieuVisite;
        //            expertiseExistant.ValeurNeuve = value.ValeurNeuve;
        //            expertiseExistant.Depreciation = value.Depreciation;
        //            expertiseExistant.ValeurVenale = value.ValeurVenale;
        //            expertiseExistant.Avd = value.Avd;
        //            expertiseExistant.Avgp = value.Avgp;
        //            expertiseExistant.Ard = value.Ard;
        //            expertiseExistant.Arg = value.Arg;
        //            expertiseExistant.Indep = value.Indep;
        //            expertiseExistant.Reseau = value.Reseau;
        //            expertiseExistant.Hreseau = value.Hreseau;
        //            expertiseExistant.EuxMeme = value.EuxMeme;
        //            expertiseExistant.Inconnu = value.Inconnu;
        //            expertiseExistant.NonProf = value.NonProf;
        //            expertiseExistant.IdVeh = value.IdVeh;
        //            expertiseExistant.IdGara = value.IdGara;
        //            expertiseExistant.IdEtatEntretien = value.IdEtatEntretien;
        //            expertiseExistant.IdDoss = value.IdDoss;
        //            expertiseExistant.Idtypnote = value.Idtypnote;
        //            //expertiseExistant.DatEnreg = value.DatEnreg;
        //            //expertiseExistant.HeurEnreg = value.HeurEnreg;
        //            expertiseExistant.Typnote = value.Typnote;
        //            expertiseExistant.Numero = value.Numero;
        //            expertiseExistant.IdUser = value.IdUser;
        //            expertiseExistant.Epave = value.Epave;
        //            expertiseExistant.ValeurSauvetage = value.ValeurSauvetage;
        //            expertiseExistant.EconoIrrep = value.EconoIrrep;
        //            //expertiseExistant.DateCreation = value.DateCreation;
        //            expertiseExistant.ModifieLe = value.ModifieLe;
        //            expertiseExistant.ModifiePar = value.ModifiePar;
        //            expertiseExistant.StateCode = value.StateCode;
        //            expertiseExistant.StatusCode = value.StatusCode;

        //            expertiseExistant.TbexpertisePointChoc = pointchocsNvx.Select(model => new TbexpertisePointChoc
        //            {
        //                Idexpert = model.Idexpert,
        //                Idpointchoc = model.Idpointchoc,
        //                IdFourn = model.IdFourn,
        //                Ligne = model.Ligne,
        //                IdUser = value.IdUser,
        //                DateCreation = model.DateCreation,
        //                ModifieLe = model.ModifieLe,
        //                ModifiePar = model.ModifiePar,
        //                StateCode = model.StateCode,
        //                StatusCode = model.StatusCode
        //            }).ToList();

        //            _service.Tbexpertise.Update(expertiseExistant);
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS UPDATE Expertise standard :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}


        //public ObjetRetour DeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Suppression_En_cours;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS demande de  SUPPRESSION standard  :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //public ObjetRetour ValiderDeleteTbexpertise(TbexpertiseDto value)
        //{
        //    var retour = new ObjetRetour();
        //    try
        //    {
        //        if (_commun.ConnexionValide(value?.Token) == (int)enumEtat.Valide)
        //        {
        //            var expertise = _service.Tbexpertise.FindByCondition(e => e.IdExpert == value.IdExpert).FirstOrDefault();
        //            expertise.StatusCode = (int)StatutCode.Supprimer;
        //            _service.Save();
        //            retour.Etat = true;
        //            _logger.LogInfo($"SUCCESS SUPPRESSION Expertise standard confirmée :\n  {value.ToString()}");
        //        }
        //        else
        //        {
        //            retour.Message = $"Token non valide!";
        //            retour.Etat = false;
        //            _logger.LogInfo($"Token non valide!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        retour.Etat = false;
        //        retour.Message = ex.Message;
        //    }

        //    return retour;
        //}

        //#endregion


    }
}
