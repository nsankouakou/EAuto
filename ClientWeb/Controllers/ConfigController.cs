using ClientWeb.Models;
using ClientWeb.Services;
using Entities.Enumeration;
using Entities.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWeb.Controllers
{
    public class ConfigController : Controller
    {
        private IConfigurationService _service { get; set; }
        protected HttpResponseMessage _response = new HttpResponseMessage();
        protected ObjetRetour Result = new ObjetRetour();

        public ConfigController(IConfigurationService service)
        {
            _service = service;

        }
        public IActionResult Index()
        {
            return View();
        }

        #region Agent
        public IActionResult Agent()
        {
            return View();
        }
        #endregion

        #region Assurance
        public IActionResult Assurance()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssurance()
        {
            try
            {
                _response = await _service.GetAllAssurance();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbassuranceDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAssurance(string jsonObject)
        {
            try
            {
                _response = await _service.GetAssurance(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbassuranceDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAssurance(string jsonObject)
        {
            try
            {
                _response = await _service.AddAssurance(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreAssurance(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreAssurance(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbassuranceDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAssurance(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateAssurance(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteAssurance(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteAssurance(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Autre Rubrique
        public IActionResult AutreRubrique()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAutreRubrique()
        {
            try
            {
                _response = await _service.GetAllAutreRubrique();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbautreRubriqueDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetAutreRubrique(string jsonObject)
        {
            try
            {
                _response = await _service.GetAutreRubrique(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbautreRubriqueDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAutreRubrique(string jsonObject)
        {
            try
            {
                _response = await _service.AddAutreRubrique(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreAutreRubrique(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreAutreRubrique(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbautreRubriqueDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAutreRubrique(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateAutreRubrique(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteAutreRubrique(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteAutreRubrique(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Carosserie
        public IActionResult Carosserie()
        {
            return View();
        }

        public async Task<JsonResult> AddCarosserie(string value)
        {
            try
            {
                bool state = false;
                string message = null;
                if (!string.IsNullOrEmpty(value))
                {
                    var retour = await _service.InsertCarosserie(value);
                    if (retour.IsSuccessStatusCode)
                    {
                        var result = new ObjetRetour();
                        result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                        if (result.Etat)
                        {
                            state = true;
                        }
                        else
                        {
                            state = false;
                            message = result.Message;
                        }
                    }
                }

                return Json(new { ok = state, message = message });
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region Commune
        public IActionResult Commune()
        {
            return View();
        }

        public async Task<JsonResult> AddCommune(string value)
        {
            bool state = false;
            string message = null;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {


                    var retour = await _service.AddCommune(value);
                    if (retour.IsSuccessStatusCode)
                    {
                        var result = new ObjetRetour();
                        result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                        if (result.Etat)
                            state = true;
                        else
                        {
                            state = false;
                            message = result.Message;
                        }

                    }


                }

                return Json(new { ok = state, message = message });
            }
            catch (Exception ex)
            {

                //statutOperation = false;
                //string message = ex.Message;
                return Json(new { etat = state, message = ex.Message });
            }

        }
        #endregion

        #region Couleur
        public IActionResult Couleur()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCouleur()
        {
            try
            {
                _response = await _service.GetAllCouleur();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbcouleurDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetCouleur(string jsonObject)
        {
            try
            {
                _response = await _service.GetCouleur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbcouleurDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddCouleur(string jsonObject)
        {
            try
            {
                _response = await _service.AddCouleur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreCouleur(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreCouleur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbcouleurDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCouleur(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateCouleur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteCouleur(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteCouleur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Discussion
        public IActionResult Discussion()
        {
            return View();
        }
        //============Chargement d'Expertise===================
        [HttpGet]
        public async Task<IActionResult> GetChargExpertise()
        {
            try
            {
                _response = await _service.GetChargAllTbexpertise();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        //var DecompressResult = JsonConvert.DeserializeObject<List<TbexpertiseDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }
        //=====================================
        [HttpGet]
        public async Task<IActionResult> GetAllDiscussion()
        {
            try
            {
                _response = await _service.GetAllDiscussion();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbdiscussionDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetDiscussion(string jsonObject)
        {
            try
            {
                _response = await _service.GetDiscussion(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbdiscussionDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddDiscussion(string jsonObject)
        {
            try
            {
                _response = await _service.AddDiscussion(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreDiscussion(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreDiscussion(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbdiscussionDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscussion(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateDiscussion(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteDiscussion(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteDiscussion(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Energie
        public IActionResult Energie()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEnergie()
        {
            try
            {
                _response = await _service.GetAllEnergie();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbenergieDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetEnergie(string jsonObject)
        {
            try
            {
                _response = await _service.GetEnergie(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbenergieDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEnergie(string jsonObject)
        {
            try
            {
                _response = await _service.AddEnergie(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreEnergie(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreEnergie(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbenergieDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEnergie(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateEnergie(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteEnergie(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteEnergie(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Fourniture
        public IActionResult Fourniture()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetAllFourniture()
        {
            try
            {
                _response = await _service.GetAllFourniture();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbfournitureDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFourniture(string jsonObject)
        {
            try
            {
                _response = await _service.GetFourniture(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbfournitureDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddFourniture(string jsonObject)
        {
            try
            {
                _response = await _service.AddFourniture(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreFourniture(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreFourniture(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbfournitureDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFourniture(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateFourniture(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteFourniture(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteFourniture(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region MODELE
        public IActionResult Modele()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllModele()
        {
            try
            {
                _response = await _service.GetAllModele();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbmodeleDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetModele(string jsonObject)
        {
            try
            {
                _response = await _service.GetModele(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbmodeleDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddModele(string jsonObject)
        {
            try
            {
                _response = await _service.AddModele(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreModele(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreModele(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbmodeleDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateModele(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateModele(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteModele(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteModele(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region Garage
        public IActionResult Garage()
        {
            return View();
        }
        #endregion

        #region VILLE
        public ActionResult Ville()
        {
            return View();
        }


        #endregion

        //#region ASSURANCE
        //public ActionResult Assurance()
        //{
        //    return View();
        //}


        //#endregion

        #region VEHICULE
        public ActionResult Vehicule()
        {
            return View();
        }


        #endregion

        #region UTILISATEUR
        public ActionResult Utilisateur()
        {
            return View();
        }


        #endregion


        #region TYPE VEHICULE
        public ActionResult TypeVehicule()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeVehicule()
        {
            try
            {
                _response = await _service.GetAllTypeVehicule();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeVehiculeDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetTypeVehicule(string jsonObject)
        {
            try
            {
                _response = await _service.GetTypeVehicule(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeVehiculeDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTypeVehicule(string jsonObject)
        {
            try
            {
                _response = await _service.AddTypeVehicule(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreTypeVehicule(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreTypeVehicule(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeVehiculeDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTypeVehicule(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateTypeVehicule(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteTypeVehicule(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteTypeVehicule(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        #endregion

        #region TYPE UTILISATEUR
        public ActionResult TypeUtilisateur()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeUtilisateur()
        {
            try
            {
                _response = await _service.GetAllTypeUtilisateur();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeUserDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetTypeUtilisateur(string jsonObject)
        {
            try
            {
                _response = await _service.GetTypeUtilisateur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeUserDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTypeUtilisateur(string jsonObject)
        {
            try
            {
                _response = await _service.AddTypeUtilisateur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreTypeUtilisateur(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreTypeUtilisateur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeUserDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTypeUtilisateur(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateTypeUtilisateur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteTypeUtilisateur(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteTypeUtilisateur(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region TYPE TRAVAUX
        public ActionResult TypeTravaux()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTypeTravaux()
        {
            try
            {
                _response = await _service.GetAllTypeTravaux();
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        //var DecompressResult = JsonConvert.DeserializeObject<List<ObjetParamModel>>(Result.Contenu.ToString());
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeTravauxDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetTypeTravaux(string jsonObject)
        {
            try
            {
                _response = await _service.GetTypeTravaux(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeTravauxDto>>(Result.Contenu.ToString());
                        return Json(DecompressResult);
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTypeTravaux(string jsonObject)
        {
            try
            {
                _response = await _service.AddTypeTravaux(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Insertion réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }

        }

        [HttpGet]
        public async Task<IActionResult> GetFiltreTypeTravaux(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreTypeTravaux(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TbtypeTravauxDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTypeTravaux(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateTypeTravaux(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à Jour réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> DeleteTypeTravaux(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteTypeTravaux(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return Json(new { ok = false, message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage) });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }
        #endregion

        #region TYPE PEINTURE
        public ActionResult TypePeinture()
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetListTypePeinture()
        {
            try
            {


                List<TbtypePeintureDto> ListePeinture = new List<TbtypePeintureDto>();
                var ListeDesPeintures = await _service.GetAllType_Peinture();
                if (ListeDesPeintures.IsSuccessStatusCode)
                {
                    var result = new ObjetRetour();
                    result = ListeDesPeintures.Content.ReadAsAsync<ObjetRetour>().Result;
                    if (result.Etat)
                    {
                        ListePeinture = JsonConvert.DeserializeObject<List<TbtypePeintureDto>>(result.Contenu.ToString());
                    }

                }
                return Json(ListePeinture.ToList());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        /// <summary>
        /// Insertion des types de peinture
        /// </summary>
        /// <returns></returns>
        public async Task<JsonResult> AddTypePeinture(string value)
        {
            bool statutOperation = false;
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Trim('"').Trim();
                    TbtypePeintureDto NewTypePeinture = new TbtypePeintureDto()
                    {
                        LibTypePein = value,
                        DateCreation = System.DateTime.UtcNow,
                        ModifiePar = null,
                        ModifieLe = null,
                        IdUser = 1,
                        StatusCode = Convert.ToInt16(Enumeration.StatutCode.Creation),
                        StateCode = Convert.ToInt16(Enumeration.StateCode.Actif)

                    };
                    string jsonObject = JsonConvert.SerializeObject(NewTypePeinture);
                    var retour = await _service.AddType_Peinture(jsonObject);
                    if (retour.IsSuccessStatusCode)
                    {
                        var result = new ObjetRetour();
                        result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                        if (result.Etat)
                            statutOperation = true;
                        else
                            statutOperation = false;
                    }


                }

                return Json(statutOperation);
            }
            catch (Exception ex)
            {

                //statutOperation = false;
                string message = ex.Message;
                return Json(new { etat = statutOperation, message = message.ToString() });
            }

        }


        #endregion
        #region TYPE NOTE
        public ActionResult TypeNote()
        {
            return View();
        }

        public async Task<JsonResult> InsertTypeNote(string value)
        {
            try
            {
                bool state = false;
                string message = null;
                if (!string.IsNullOrEmpty(value))
                {
                    var retour = await _service.AddTypeNote(value);
                    if (retour.IsSuccessStatusCode)
                    {
                        var result = new ObjetRetour();
                        result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                        if (result.Etat)
                        {
                            state = true;
                        }
                        else
                        {
                            state = false;
                            message = result.Message;
                        }
                    }
                }
                return Json(new { ok = state, message = message });
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        #endregion


        #region TYPE EXPERTISE
        public ActionResult TypeExpertise()
        {
            return View();
        }



        #endregion



        #region TYPE EXPERTISE
        //public ActionResult TypeExpertise()
        //{
        //    return View();
        //}

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region TYPE PEINTURE TARIF
        public ActionResult TypePeintureTarif()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region TYPE GARAGE
        public ActionResult TypeGarage()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region TVA
        public ActionResult Tva()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region SPECIALITE
        public ActionResult Specialite()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region SERVICE
        public ActionResult Service()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region RUBRIQUE EVALUATION
        public ActionResult RubriqueEvaluation()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion

        #region RUBRIQUE ESTIMATION
        public ActionResult RubriqueEstimation()
        {
            return View();
        }

        public async Task<JsonResult> AddRubriqueEstimation(string value)
        {
            try
            {
                bool state = false;
                string message = null;
                if (!string.IsNullOrEmpty(value))
                {
                    var retour = await _service.InsertRubriqueEstimation(value);
                    if (retour.IsSuccessStatusCode)
                    {
                        var result = new ObjetRetour();
                        result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                        if (result.Etat == true)
                        {
                            state = true;
                        }
                        else
                        {
                            state = false;
                            message = result.Message;
                        }
                    }
                }
                return Json(new { ok = state, message = message });
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<JsonResult> GetAllRubriqueEstimation()
        {
            try
            {
                bool state = false;
                string message = null;
                List<TbrubriqueEstimationDto> ListRubriqueEstimation = new List<TbrubriqueEstimationDto>();
                var retour = await _service.GetAllRubriqueEstimation();
                if (retour.IsSuccessStatusCode)
                {
                    var result = new ObjetRetour();
                    result = retour.Content.ReadAsAsync<ObjetRetour>().Result;
                    if (result.Etat == true)
                    {
                        state = true;
                        ListRubriqueEstimation = JsonConvert.DeserializeObject<List<TbrubriqueEstimationDto>>(result.Contenu.ToString());
                    }
                    else
                    {
                        state = false;
                        message = result.Message;
                    }
                }
                return Json(new { ok = state, liste = ListRubriqueEstimation });
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        #endregion
        #region RUBRIQUE ECONSTATION
        public ActionResult RubriqueConstation()
        {
            return View();
        }

        //[Authorize]
        //public async Task<JsonResult> GetAllTypeVehicule()
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.ListeDesTypeVehicules, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { data = liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //    //return Json(List, JsonRequestBehavior.AllowGet);

        //}

        //[HttpGet]
        //public async Task<JsonResult> GetTypeVehicule(string jsonObjet)
        //{
        //    string token = structure.GetToken(Session["User"]);

        //    var ic = JObject.Parse(jsonObjet);
        //    var val = (string)ic["id"];
        //    string completeUrl = structure.GetUrl(ClsUri.GetTypeVehicule + "?id=" + val, null, token);

        //    var liste = await _services.ON_GetListe<TypeVehiculeDto>(completeUrl);

        //    if (liste != null)
        //    {
        //        return Json(new { liste }, JsonRequestBehavior.AllowGet);
        //    }
        //    return null;
        //}

        //[HttpPost]
        //public async Task<JsonResult> SaveTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.PostTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    TypeVehicule.TypeVehiculeid = Guid.NewGuid();
        //    TypeVehicule.Createdby = CurrentUser.Login.UserId;
        //    TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Enregistré" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //[HttpPost]
        //public async Task<JsonResult> UpdateTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.UpdateTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    TypeVehicule.Modifiedon = DateTime.Now;
        //    TypeVehicule.Statecode = (int)StateCode.Actif;
        //    TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Type Abonnement Modifié" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Enregistrement Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        //public async Task<JsonResult> deleteTypeVehicule(string jsonObjet)
        //{
        //    CurrentUser = Session["User"] as InfoUserModel;//Reccuperation des infos du User
        //    //var userid = CurrentUser.Login.UserId;

        //    string token = structure.GetToken(Session["User"]);
        //    string completeUrl = structure.GetUrl(ClsUri.DeleteTypeVehicule, null, token);

        //    var TypeVehicule = JsonConvert.DeserializeObject<TypeVehiculeDto>(jsonObjet);
        //    //TypeVehicule.Createdon = DateTime.Now;
        //    TypeVehicule.Modifiedby = CurrentUser.Login.UserId;
        //    //TypeVehicule.Createdby = Guid.NewGuid();
        //    //TypeVehicule.Statecode = (int)StateCode.Actif;
        //    //TypeVehicule.Statuscode = (int)StatutCode.Actif;

        //    var retour = await _services.On_POST(completeUrl, TypeVehicule);
        //    if (retour == "ok")
        //    {
        //        return Json(new { etat = true, message = "Suppression réalisée avec succès!" }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { etat = false, message = "Suppression Echoué" }, JsonRequestBehavior.AllowGet);
        //    }

        //}

        #endregion




    }
}