using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWeb.Services
{
    public interface IConfigurationService
    {

        #region ASSURANCE
        Task<HttpResponseMessage> AddAssurance(string jsonObject);
        Task<HttpResponseMessage> UpdateAssurance(string jsonObject);
        Task<HttpResponseMessage> GetAssurance(string jsonObject);
        Task<HttpResponseMessage> GetFiltreAssurance(string jsonObject);
        Task<HttpResponseMessage> GetAllAssurance();
        Task<HttpResponseMessage> DeleteAssurance(string jsonObject);
        #endregion

        #region AUTRE RUBRIQUE
        Task<HttpResponseMessage> AddAutreRubrique(string jsonObject);
        Task<HttpResponseMessage> UpdateAutreRubrique(string jsonObject);
        Task<HttpResponseMessage> GetAutreRubrique(string jsonObject);
        Task<HttpResponseMessage> GetFiltreAutreRubrique(string jsonObject);
        Task<HttpResponseMessage> GetAllAutreRubrique();
        Task<HttpResponseMessage> DeleteAutreRubrique(string jsonObject);
        #endregion

        #region TYPE VEHICULE
        Task<HttpResponseMessage> AddTypeVehicule(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeVehicule(string jsonObject);
        Task<HttpResponseMessage> GetTypeVehicule(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeVehicule(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeVehicule();
        Task<HttpResponseMessage> DeleteTypeVehicule(string jsonObject);
        #endregion

        #region TYPE UTILISATEUR
        Task<HttpResponseMessage> AddTypeUtilisateur(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeUtilisateur(string jsonObject);
        Task<HttpResponseMessage> GetTypeUtilisateur(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeUtilisateur(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeUtilisateur();
        Task<HttpResponseMessage> DeleteTypeUtilisateur(string jsonObject);
        #endregion

        #region TYPE TRAVAUX
        Task<HttpResponseMessage> AddTypeTravaux(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeTravaux(string jsonObject);
        Task<HttpResponseMessage> GetTypeTravaux(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeTravaux(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeTravaux();
        Task<HttpResponseMessage> DeleteTypeTravaux(string jsonObject);
        #endregion

        #region FOURNITURE
        Task<HttpResponseMessage> AddFourniture(string jsonObject);
        Task<HttpResponseMessage> UpdateFourniture(string jsonObject);
        Task<HttpResponseMessage> GetFourniture(string jsonObject);
        Task<HttpResponseMessage> GetFiltreFourniture(string jsonObject);
        Task<HttpResponseMessage> GetAllFourniture();
        Task<HttpResponseMessage> DeleteFourniture(string jsonObject);
        #endregion

        #region ENERGIE
        Task<HttpResponseMessage> AddEnergie(string jsonObject);
        Task<HttpResponseMessage> UpdateEnergie(string jsonObject);
        Task<HttpResponseMessage> GetEnergie(string jsonObject);
        Task<HttpResponseMessage> GetFiltreEnergie(string jsonObject);
        Task<HttpResponseMessage> GetAllEnergie();
        Task<HttpResponseMessage> DeleteEnergie(string jsonObject);
        #endregion

        #region DISCUSSION
        Task<HttpResponseMessage> GetChargAllTbexpertise();
        //========================================================
        Task<HttpResponseMessage> AddDiscussion(string jsonObject);
        Task<HttpResponseMessage> UpdateDiscussion(string jsonObject);
        Task<HttpResponseMessage> GetDiscussion(string jsonObject);
        Task<HttpResponseMessage> GetFiltreDiscussion(string jsonObject);
        Task<HttpResponseMessage> GetAllDiscussion();
        Task<HttpResponseMessage> DeleteDiscussion(string jsonObject);
        #endregion

        #region COULEUR
        Task<HttpResponseMessage> AddCouleur(string jsonObject);
        Task<HttpResponseMessage> UpdateCouleur(string jsonObject);
        Task<HttpResponseMessage> GetCouleur(string jsonObject);
        Task<HttpResponseMessage> GetFiltreCouleur(string jsonObject);
        Task<HttpResponseMessage> GetAllCouleur();
        Task<HttpResponseMessage> DeleteCouleur(string jsonObject);
        #endregion

        #region MODELE
        Task<HttpResponseMessage> AddModele(string jsonObject);
        Task<HttpResponseMessage> UpdateModele(string jsonObject);
        Task<HttpResponseMessage> GetModele(string jsonObject);
        Task<HttpResponseMessage> GetFiltreModele(string jsonObject);
        Task<HttpResponseMessage> GetAllModele();
        Task<HttpResponseMessage> DeleteModele(string jsonObject);
        #endregion

        #region COMMUNE
        Task<HttpResponseMessage> AddCommune(string jsonObject);
        Task<HttpResponseMessage> UpdateCommune(string jsonObject);
        Task<HttpResponseMessage> GetCommune(string jsonObject);
        Task<HttpResponseMessage> GetFiltreCommune(string jsonObject);
        Task<HttpResponseMessage> GetAllCommune();
        Task<HttpResponseMessage> DeleteCommune(string jsonObject);
        #endregion

        #region TYPE_PEINTURE
        Task<HttpResponseMessage> GetAllType_Peinture();
        Task<HttpResponseMessage> AddType_Peinture(string JsonObject);
        #endregion

        #region CAROSSERIE
        Task<HttpResponseMessage> InsertCarosserie(string jsonObject);
        Task<HttpResponseMessage> GetAllCarosserie();
        #endregion

        #region TYPE_NOTE
        Task<HttpResponseMessage> GetAllTypeNote();
        Task<HttpResponseMessage> AddTypeNote(string JsonObject);
        #endregion

        #region RUBRIQUE ESTIMATION
        Task<HttpResponseMessage> GetAllRubriqueEstimation();
        Task<HttpResponseMessage> InsertRubriqueEstimation(string JsonObject);
        #endregion
    }
}
