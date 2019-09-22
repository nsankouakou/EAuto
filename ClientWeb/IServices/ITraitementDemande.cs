using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWeb.Services
{
    public interface ITraitementDemande
    {
        #region WNI 

        Task<HttpResponseMessage> ConnexionAgent(string jsonObject);
        Task<HttpResponseMessage> ChangerMotDePasse(string jsonObject);
        Task<HttpResponseMessage> GetAllDemandes(string jsonObject);

        Task<HttpResponseMessage> GetAllDemandesAgent(string jsonObject);

        Task<HttpResponseMessage> SaveEtapeEffectiveDemande(string jsonObject);

        Task<HttpResponseMessage> GenererFormulaireDemandeSuivi(string jsonObject);

        Task<HttpResponseMessage> GetInfosSuiviDemande(string jsonObject);
        Task<HttpResponseMessage> GetListeRegitres(string jsonObject);

        Task<HttpResponseMessage> GetUrlNewDemande(string jsonObject);
        Task<HttpResponseMessage> GenererInfosUtilesPourActe(string jsonObject);
        Task<HttpResponseMessage> GenererInfosUtilesPourRechercheActe(string jsonObject);
        Task<HttpResponseMessage> EnregisterInfosUtilesPourActe(string jsonObject, string values);
        Task<HttpResponseMessage>RechercheActe(string jsonObject);
        Task<HttpResponseMessage> GetAllActe();
        Task<HttpResponseMessage> GetAllActePrincipaux();
        Task<HttpResponseMessage> AddRegistre(string jsonObject);
        Task<HttpResponseMessage> UpdateRegistre(string jsonObject);
        Task<HttpResponseMessage> DeleteRegistre(string jsonObject);
        Task<HttpResponseMessage> GetAllRegistres(string jsonObject);
        //Task<HttpResponseMessage> GetRegistre(string jsonObject);
        Task<HttpResponseMessage> GetTypeRegistres(string jsonObject);
        Task<HttpResponseMessage> GetRegistreByTypeActe(string jsonObject);
        Task<HttpResponseMessage> EnregistrerDemande(string jsonObject, string values);
        Task<HttpResponseMessage> GenererFormulaireDemande(string jsonObject);


        #endregion
    }
}
