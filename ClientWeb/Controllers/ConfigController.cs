using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientWeb.Controllers
{
    public class ConfigController : Controller
    {
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
        #endregion

        #region Autre Rubrique
        public IActionResult AutreRubrique()
        {
            return View();
        }
        #endregion

        #region Carosserie
        public IActionResult Carosserie()
        {
            return View();
        }
        #endregion

        #region Commune
        public IActionResult Commune()
        {
            return View();
        }
        #endregion

        #region Couleur
        public IActionResult Couleur()
        {
            return View();
        }
        #endregion

        #region Discussion
        public IActionResult Discussion()
        {
            return View();
        }
        #endregion

        #region Energie
        public IActionResult Energie()
        {
            return View();
        }
        #endregion

        #region Fourniture
        public IActionResult Fourniture()
        {
            return View();
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

        

        #endregion

        #region TYPE UTILISATEUR
        public ActionResult TypeUtilisateur()
        {
            return View();
        }

        
        #endregion

        #region TYPE TRAVAUX
        public ActionResult TypeTravaux()
        {
            return View();
        }


        #endregion

        #region TYPE PEINTURE
        public ActionResult TypePeinture()
        {
            return View();
        }


        #endregion

        #region TYPE NOTE
        public ActionResult TypeNote()
        {
            return View();
        }

        

        #endregion


        #region TYPE EXPERTISE
        public ActionResult TypeExpertise()
        {
            return View();
        }

        

        #endregion
		
		
		
        #region TYPE EXPERTISE
        public ActionResult TypeExpertise()
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