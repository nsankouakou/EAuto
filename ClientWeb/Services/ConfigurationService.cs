using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using Entities.Models.Dtos;
//using Entities.Dtos;

namespace ClientWeb.Services
{
    public class ConfigurationService : IConfigurationService
    {
        public ConfigurationService()
        {


        }

        #region ASSURANCE
        public async Task<HttpResponseMessage> GetAllAssurance()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbassurance");
        }
        public async Task<HttpResponseMessage> GetAssurance(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbassuranceUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreAssurance(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddAssurance(string jsonObject)
        {
            var assurance = JsonConvert.DeserializeObject<TbassuranceDto>(jsonObject);
            //assurance.IdAssur = 0;
            assurance.IdUser = 1;
            assurance.DateCreation = DateTime.Now;
            assurance.ModifiePar = 1;
            assurance.StateCode = 1;
            assurance.StatusCode = 1;
            assurance.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbassuranceDto>("/api/Config/InserTbassurance", assurance);
        }
        public async Task<HttpResponseMessage> UpdateAssurance(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var assurance = JsonConvert.DeserializeObject<TbassuranceDto>(ic.ToString());
            assurance.IdUser = 1;
            assurance.ModifieLe = DateTime.Now;
            assurance.ModifiePar = 1;
            assurance.StateCode = 1;
            assurance.StatusCode = 1;
            assurance.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbassuranceDto>("/api/Config/MajTbassurance", assurance);
        }
        public async Task<HttpResponseMessage> DeleteAssurance(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var assurance = JsonConvert.DeserializeObject<TbassuranceDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbassuranceDto>("/api/Config/DeleteTbassurance", assurance);
        }
        #endregion

        #region AUTRE RUBRIQUE
        public async Task<HttpResponseMessage> GetAllAutreRubrique()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbautreRubrique");
        }
        public async Task<HttpResponseMessage> GetAutreRubrique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbautreRubriqueUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreAutreRubrique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddAutreRubrique(string jsonObject)
        {
            var autreRubrique = JsonConvert.DeserializeObject<TbautreRubriqueDto>(jsonObject);
            //autreRubrique.IdAssur = 0;
            autreRubrique.IdUser = 1;
            autreRubrique.DateCreation = DateTime.Now;
            autreRubrique.ModifiePar = 1;
            autreRubrique.StateCode = 1;
            autreRubrique.StatusCode = 1;
            autreRubrique.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbautreRubriqueDto>("/api/Config/InserTbautreRubrique", autreRubrique);
        }
        public async Task<HttpResponseMessage> UpdateAutreRubrique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var autreRubrique = JsonConvert.DeserializeObject<TbautreRubriqueDto>(ic.ToString());
            autreRubrique.IdUser = 1;
            autreRubrique.ModifieLe = DateTime.Now;
            autreRubrique.ModifiePar = 1;
            autreRubrique.StateCode = 1;
            autreRubrique.StatusCode = 1;
            autreRubrique.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbautreRubriqueDto>("/api/Config/MajTbautreRubrique", autreRubrique);
        }
        public async Task<HttpResponseMessage> DeleteAutreRubrique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var autreRubrique = JsonConvert.DeserializeObject<TbautreRubriqueDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbautreRubriqueDto>("/api/Config/DeleteTbautreRubrique", autreRubrique);
        }
        #endregion

        #region TYPE VEHICULE
        public async Task<HttpResponseMessage> GetAllTypeVehicule()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbtypeVehicule");
        }
        public async Task<HttpResponseMessage> GetTypeVehicule(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbtypeVehiculeUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreTypeVehicule(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddTypeVehicule(string jsonObject)
        {
            var TypeVehicule = JsonConvert.DeserializeObject<TbtypeVehiculeDto>(jsonObject);
            //TypeVehicule.IdAssur = 0;
            TypeVehicule.IdUser = 1;
            TypeVehicule.DateCreation = DateTime.Now;
            TypeVehicule.ModifiePar = 1;
            TypeVehicule.StateCode = 1;
            TypeVehicule.StatusCode = 1;
            TypeVehicule.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbtypeVehiculeDto>("/api/Config/InserTbtypeVehicule", TypeVehicule);
        }
        public async Task<HttpResponseMessage> UpdateTypeVehicule(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var TypeVehicule = JsonConvert.DeserializeObject<TbtypeVehiculeDto>(ic.ToString());
            TypeVehicule.IdUser = 1;
            TypeVehicule.ModifieLe = DateTime.Now;
            TypeVehicule.ModifiePar = 1;
            TypeVehicule.StateCode = 1;
            TypeVehicule.StatusCode = 1;
            TypeVehicule.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeVehiculeDto>("/api/Config/MajTbtypeVehicule", TypeVehicule);
        }
        public async Task<HttpResponseMessage> DeleteTypeVehicule(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var TypeVehicule = JsonConvert.DeserializeObject<TbtypeVehiculeDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeVehiculeDto>("/api/Config/DeleteTbtypeVehicule", TypeVehicule);
        }
        #endregion

        #region TYPE UTILISATEUR
        public async Task<HttpResponseMessage> GetAllTypeUtilisateur()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbtypeUser");
        }
        public async Task<HttpResponseMessage> GetTypeUtilisateur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbtypeUserUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreTypeUtilisateur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddTypeUtilisateur(string jsonObject)
        {
            var assurance = JsonConvert.DeserializeObject<TbtypeUserDto>(jsonObject);
            //assurance.IdAssur = 0;
            assurance.IdUser = 1;
            assurance.DateCreation = DateTime.Now;
            assurance.ModifiePar = 1;
            assurance.StateCode = 1;
            assurance.StatusCode = 1;
            assurance.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbtypeUserDto>("/api/Config/InserTbtypeUser", assurance);
        }
        public async Task<HttpResponseMessage> UpdateTypeUtilisateur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var assurance = JsonConvert.DeserializeObject<TbtypeUserDto>(ic.ToString());
            assurance.IdUser = 1;
            assurance.ModifieLe = DateTime.Now;
            assurance.ModifiePar = 1;
            assurance.StateCode = 1;
            assurance.StatusCode = 1;
            assurance.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeUserDto>("/api/Config/MajTbtypeUser", assurance);
        }
        public async Task<HttpResponseMessage> DeleteTypeUtilisateur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var assurance = JsonConvert.DeserializeObject<TbtypeUserDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeUserDto>("/api/Config/DeleteTbtypeUser", assurance);
        }
        #endregion

        #region TYPE TRAVAUX
        public async Task<HttpResponseMessage> GetAllTypeTravaux()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbtypeTravaux");
        }
        public async Task<HttpResponseMessage> GetTypeTravaux(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbtypeTravauxUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreTypeTravaux(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddTypeTravaux(string jsonObject)
        {
            var TypeTravaux = JsonConvert.DeserializeObject<TbtypeTravauxDto>(jsonObject);
            //TypeTravaux.IdAssur = 0;
            TypeTravaux.IdUser = 1;
            TypeTravaux.DateCreation = DateTime.Now;
            TypeTravaux.ModifiePar = 1;
            TypeTravaux.StateCode = 1;
            TypeTravaux.StatusCode = 1;
            TypeTravaux.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbtypeTravauxDto>("/api/Config/InserTbtypeTravaux", TypeTravaux);
        }
        public async Task<HttpResponseMessage> UpdateTypeTravaux(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var TypeTravaux = JsonConvert.DeserializeObject<TbtypeTravauxDto>(ic.ToString());
            TypeTravaux.IdUser = 1;
            TypeTravaux.ModifieLe = DateTime.Now;
            TypeTravaux.ModifiePar = 1;
            TypeTravaux.StateCode = 1;
            TypeTravaux.StatusCode = 1;
            TypeTravaux.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeTravauxDto>("/api/Config/MajTbtypeTravaux", TypeTravaux);
        }
        public async Task<HttpResponseMessage> DeleteTypeTravaux(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var TypeTravaux = JsonConvert.DeserializeObject<TbtypeTravauxDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbtypeTravauxDto>("/api/Config/DeleteTbtypeTravaux", TypeTravaux);
        }
        #endregion

        #region FOURNITURE
        public async Task<HttpResponseMessage> GetAllFourniture()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbfourniture");
        }
        public async Task<HttpResponseMessage> GetFourniture(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbfournitureUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreFourniture(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddFourniture(string jsonObject)
        {
            var Fourniture = JsonConvert.DeserializeObject<TbfournitureDto>(jsonObject);
            //Fourniture.IdAssur = 0;
            Fourniture.IdUser = 1;
            Fourniture.DateCreation = DateTime.Now;
            Fourniture.ModifiePar = 1;
            Fourniture.StateCode = 1;
            Fourniture.StatusCode = 1;
            Fourniture.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbfournitureDto>("/api/Config/InserTbfourniture", Fourniture);
        }
        public async Task<HttpResponseMessage> UpdateFourniture(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Fourniture = JsonConvert.DeserializeObject<TbfournitureDto>(ic.ToString());
            Fourniture.IdUser = 1;
            Fourniture.ModifieLe = DateTime.Now;
            Fourniture.ModifiePar = 1;
            Fourniture.StateCode = 1;
            Fourniture.StatusCode = 1;
            Fourniture.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbfournitureDto>("/api/Config/MajTbfourniture", Fourniture);
        }
        public async Task<HttpResponseMessage> DeleteFourniture(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Fourniture = JsonConvert.DeserializeObject<TbfournitureDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbfournitureDto>("/api/Config/DeleteTbfourniture", Fourniture);
        }
        #endregion

        #region ENERGIE
        public async Task<HttpResponseMessage> GetAllEnergie()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbenergie");
        }
        public async Task<HttpResponseMessage> GetEnergie(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbenergieUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreEnergie(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddEnergie(string jsonObject)
        {
            var Energie = JsonConvert.DeserializeObject<TbenergieDto>(jsonObject);
            //Energie.IdAssur = 0;
            //Energie.IdUser = 1;
            Energie.DateCreation = DateTime.Now;
            Energie.ModifiePar = 1;
            Energie.StateCode = 1;
            Energie.StatusCode = 1;
            Energie.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbenergieDto>("/api/Config/InserTbenergie", Energie);
        }
        public async Task<HttpResponseMessage> UpdateEnergie(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Energie = JsonConvert.DeserializeObject<TbenergieDto>(ic.ToString());
            //Energie.IdUser = 1;
            Energie.ModifieLe = DateTime.Now;
            Energie.ModifiePar = 1;
            Energie.StateCode = 1;
            Energie.StatusCode = 1;
            Energie.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbenergieDto>("/api/Config/MajTbenergie", Energie);
        }
        public async Task<HttpResponseMessage> DeleteEnergie(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Energie = JsonConvert.DeserializeObject<TbenergieDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbenergieDto>("/api/Config/DeleteTbenergie", Energie);
        }
        #endregion

        #region DISCUSSION
        public async Task<HttpResponseMessage> GetChargAllTbexpertise()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetChargAllTbexpertise");
        }
        //=======================================
        public async Task<HttpResponseMessage> GetAllDiscussion()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbdiscussion");
        }
        public async Task<HttpResponseMessage> GetDiscussion(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbdiscussionUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreDiscussion(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddDiscussion(string jsonObject)
        {
            var Discussion = JsonConvert.DeserializeObject<TbdiscussionDto>(jsonObject);
            //Discussion.IdAssur = 0;
            Discussion.IdUser = 1;
            Discussion.DateCreation = DateTime.Now;
            Discussion.ModifiePar = 1;
            Discussion.StateCode = 1;
            Discussion.StatusCode = 1;
            Discussion.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbdiscussionDto>("/api/Config/InserTbdiscussion", Discussion);
        }
        public async Task<HttpResponseMessage> UpdateDiscussion(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Discussion = JsonConvert.DeserializeObject<TbdiscussionDto>(ic.ToString());
            Discussion.IdUser = 1;
            Discussion.ModifieLe = DateTime.Now;
            Discussion.ModifiePar = 1;
            Discussion.StateCode = 1;
            Discussion.StatusCode = 1;
            Discussion.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbdiscussionDto>("/api/Config/MajTbdiscussion", Discussion);
        }
        public async Task<HttpResponseMessage> DeleteDiscussion(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Discussion = JsonConvert.DeserializeObject<TbdiscussionDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbdiscussionDto>("/api/Config/DeleteTbdiscussion", Discussion);
        }
        #endregion

        #region COULEUR
        public async Task<HttpResponseMessage> GetAllCouleur()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbcouleur");
        }
        public async Task<HttpResponseMessage> GetCouleur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbcouleurUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreCouleur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddCouleur(string jsonObject)
        {
            var Couleur = JsonConvert.DeserializeObject<TbcouleurDto>(jsonObject);
            //Couleur.IdAssur = 0;
            Couleur.IdUser = 1;
            Couleur.DateCreation = DateTime.Now;
            Couleur.ModifiePar = 1;
            Couleur.StateCode = 1;
            Couleur.StatusCode = 1;
            Couleur.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbcouleurDto>("/api/Config/InserTbcouleur", Couleur);
        }
        public async Task<HttpResponseMessage> UpdateCouleur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Couleur = JsonConvert.DeserializeObject<TbcouleurDto>(ic.ToString());
            Couleur.IdUser = 1;
            Couleur.ModifieLe = DateTime.Now;
            Couleur.ModifiePar = 1;
            Couleur.StateCode = 1;
            Couleur.StatusCode = 1;
            Couleur.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbcouleurDto>("/api/Config/MajTbcouleur", Couleur);
        }
        public async Task<HttpResponseMessage> DeleteCouleur(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Couleur = JsonConvert.DeserializeObject<TbcouleurDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbcouleurDto>("/api/Config/DeleteTbcouleur", Couleur);
        }
        #endregion

        #region MODELE
        public async Task<HttpResponseMessage> GetAllModele()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbmodele");
        }
        public async Task<HttpResponseMessage> GetModele(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Config/GetTbmodeleUnique?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreModele(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> AddModele(string jsonObject)
        {
            var Modele = JsonConvert.DeserializeObject<TbmodeleDto>(jsonObject);
            //Modele.IdAssur = 0;
            Modele.IdUser = 1;
            Modele.DateCreation = DateTime.Now;
            Modele.ModifiePar = 1;
            Modele.StateCode = 1;
            Modele.StatusCode = 1;
            Modele.Token = "token";

            return await Utility.ClientApi().PostAsJsonAsync<TbmodeleDto>("/api/Config/InserTbmodele", Modele);
        }
        public async Task<HttpResponseMessage> UpdateModele(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Modele = JsonConvert.DeserializeObject<TbmodeleDto>(ic.ToString());
            Modele.IdUser = 1;
            Modele.ModifieLe = DateTime.Now;
            Modele.ModifiePar = 1;
            Modele.StateCode = 1;
            Modele.StatusCode = 1;
            Modele.Token = "token";
            return await Utility.ClientApi().PostAsJsonAsync<TbmodeleDto>("/api/Config/MajTbmodele", Modele);
        }
        public async Task<HttpResponseMessage> DeleteModele(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var Modele = JsonConvert.DeserializeObject<TbmodeleDto>(ic.ToString());
            return await Utility.ClientApi().PostAsJsonAsync<TbmodeleDto>("/api/Config/DeleteTbmodele", Modele);
        }
        #endregion

        #region TYPE PEINTURE
        public async Task<HttpResponseMessage> GetAllType_Peinture()
        {
            try
            {


                //List<TbtypePeintureDto> ListePeinture = new List<TbtypePeintureDto>();
                return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbtypePeinture?token=jj");

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<HttpResponseMessage> AddType_Peinture(string jsonObject)
        {
            try
            {
                var ic = JObject.Parse(jsonObject);
                var UnNouveauType_Peinture = JsonConvert.DeserializeObject<TbtypePeintureDto>(ic.ToString());
                return await Utility.ClientApi().PostAsJsonAsync<TbtypePeintureDto>("/api/Config/InserTbtypePeinture", UnNouveauType_Peinture);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<HttpResponseMessage> AddVehicule(string jsonObject)
        {
            try
            {
                var ic = JObject.Parse(jsonObject);
                var UnNouveauVehicule = JsonConvert.DeserializeObject<TbvehiculeDto>(ic.ToString());
                return await Utility.ClientApi().PostAsJsonAsync<TbvehiculeDto>("/api/Config/InserTbvehicule", UnNouveauVehicule);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        #endregion

        #region COMMUNE
        public async Task<HttpResponseMessage> AddCommune(string jsonObject)
        {
            try
            {
                TbcommuneDto UneCommune = new TbcommuneDto();
                UneCommune = JsonConvert.DeserializeObject<TbcommuneDto>(jsonObject);
                UneCommune.DateCreation = DateTime.UtcNow;
                UneCommune.IdUser = 1;
                UneCommune.StateCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StateCode.Actif);
                UneCommune.StatusCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StatutCode.Creation);
                UneCommune.Token = "dd";
                return await Utility.ClientApi().PostAsJsonAsync<TbcommuneDto>("/api/Config/InserTbcommune", UneCommune);
            }
            catch (Exception ex)
            {

                throw;
            }


        }



        public Task<HttpResponseMessage> UpdateCommune(string jsonObject)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetCommune(string jsonObject)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetFiltreCommune(string jsonObject)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAllCommune()
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteCommune(string jsonObject)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region CAROSSERIE

        public async Task<HttpResponseMessage> InsertCarosserie(string jsonObject)
        {
            try
            {

                if (!string.IsNullOrEmpty(jsonObject))
                {
                    jsonObject = jsonObject.Trim('"').Trim();
                    TbcarosserieDto UneNouvelleCarosserie = new TbcarosserieDto()
                    {
                        LibCarross = jsonObject,
                        DateCreation = DateTime.UtcNow,
                        IdUser = 1, // à modifier
                        ModifieLe = null,
                        ModifiePar = null,
                        StateCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StateCode.Actif),
                        StatusCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StatutCode.Creation),
                        Token = "123"

                    };

                    string url = "/api/Config/InserTbcarosserie";
                    return await Utility.ClientApi().PostAsJsonAsync<TbcarosserieDto>(url, UneNouvelleCarosserie);

                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<HttpResponseMessage> GetAllCarosserie()
        {

            try
            {
                return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbcarosserie?token=jj");
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        #endregion
        #region  TYPE NOTE
        public async Task<HttpResponseMessage> GetAllTypeNote()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbtypeNote");
        }

        public async Task<HttpResponseMessage> AddTypeNote(string JsonObject)
        {
            try
            {

                TbtypeNoteDto UnTypeNote = new TbtypeNoteDto()
                {
                    Libtypnote = JsonObject.Trim('"').Trim(),
                    DateCreation = DateTime.UtcNow,
                    IdUser = 1,
                    Token = "dd",
                    StateCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StateCode.Actif),
                    StatusCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StatutCode.Creation)

                };

                return await Utility.ClientApi().PostAsJsonAsync<TbtypeNoteDto>("/api/Config/InserTbtypeNote", UnTypeNote);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

        #region RUBRIQUE ESTIMATION
        public async Task<HttpResponseMessage> InsertRubriqueEstimation(string JsonObject)
        {
            try
            {

                TbrubriqueEstimationDto UneRubriqueEstimation = new TbrubriqueEstimationDto()
                {
                    LibRubEstim = JsonObject.Trim('"').Trim(),
                    DateCreation = DateTime.UtcNow,
                    IdUser = 1,
                    StateCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StateCode.Actif),
                    StatusCode = Convert.ToInt16(Entities.Enumeration.Enumeration.StatutCode.Creation),
                    Token = "dd"
                };
                return await Utility.ClientApi().PostAsJsonAsync<TbrubriqueEstimationDto>("/api/Config/InserTbrubriqueEstimation", UneRubriqueEstimation);
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public async Task<HttpResponseMessage> GetAllRubriqueEstimation()
        {
            return await Utility.ClientApi().GetAsync("/api/Config/GetALLTbrubriqueEstimation?token=dd");
        }

        #endregion
    }
}
