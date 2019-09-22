using System.Net.Http;
using System.Threading.Tasks;

namespace ClientWeb.Services
{
    public interface IConfigurationService
    {

        #region ACTE
        Task<HttpResponseMessage> AddActe(string jsonObject);
        Task<HttpResponseMessage> UpdateActe(string jsonObject);
        Task<HttpResponseMessage> GetActe(string jsonObject);
        Task<HttpResponseMessage> GetFiltreActe(string jsonObject);
        Task<HttpResponseMessage> GetAllActe();
        Task<HttpResponseMessage> DeleteActe(string jsonObject);
        #endregion

        #region ACTION
        Task<HttpResponseMessage> AddAction(string jsonObject);
        Task<HttpResponseMessage> UpdateAction(string jsonObject);
        Task<HttpResponseMessage> GetAction(string jsonObject);
        Task<HttpResponseMessage> GetFiltreAction(string jsonObject);
        Task<HttpResponseMessage> GetAllAction();
        Task<HttpResponseMessage> DeleteAction(string jsonObject);
        #endregion

        #region AGENT
        Task<HttpResponseMessage> AddAgent(string jsonObject);
        Task<HttpResponseMessage> UpdateAgent(string jsonObject);
        Task<HttpResponseMessage> GetAgent(string jsonObject);
        Task<HttpResponseMessage> GetFiltreAgent(string jsonObject);
        Task<HttpResponseMessage> GetAllAgent();
        Task<HttpResponseMessage> DeleteAgent(string jsonObject);

        #endregion

        #region COMMUNE
        Task<HttpResponseMessage> AddCommune(string jsonObject);
        Task<HttpResponseMessage> UpdateCommune(string jsonObject);
        Task<HttpResponseMessage> GetCommune(string jsonObject);
        Task<HttpResponseMessage> GetFiltreCommune(string jsonObject);
        Task<HttpResponseMessage> GetAllCommune();
        Task<HttpResponseMessage> DeleteCommune(string jsonObject);
        #endregion

        #region LIVRAISON_MODE
        Task<HttpResponseMessage> AddLivraison_Mode(string jsonObject);
        Task<HttpResponseMessage> UpdateLivraison_Mode(string jsonObject);
        Task<HttpResponseMessage> GetLivraison_Mode(string jsonObject);
        Task<HttpResponseMessage> GetFiltreLivraison_Mode(string jsonObject);
        Task<HttpResponseMessage> GetAllLivraison_Mode();
        Task<HttpResponseMessage> DeleteLivraison_Mode(string jsonObject);
        #endregion

        #region PAYS
        Task<HttpResponseMessage> AddPays(string jsonObject);
        Task<HttpResponseMessage> UpdatePays(string jsonObject);
        Task<HttpResponseMessage> GetPays(string jsonObject);
        Task<HttpResponseMessage> GetFiltrePays(string jsonObject);
        Task<HttpResponseMessage> GetAllPays();
        Task<HttpResponseMessage> DeletePays(string jsonObject);
        #endregion

        #region TYPE_ACTE
        Task<HttpResponseMessage> AddType_Acte(string jsonObject);
        Task<HttpResponseMessage> UpdateType_Acte(string jsonObject);
        Task<HttpResponseMessage> GetType_Acte(string jsonObject);
        Task<HttpResponseMessage> GetFiltreType_Acte(string jsonObject);
        Task<HttpResponseMessage> GetAllType_Acte();
        Task<HttpResponseMessage> DeleteType_Acte(string jsonObject);
        #endregion

        #region TYPE_ACTION
        Task<HttpResponseMessage> AddType_Action(string jsonObject);
        Task<HttpResponseMessage> UpdateType_Action(string jsonObject);
        Task<HttpResponseMessage> GetType_Action(string jsonObject);
        Task<HttpResponseMessage> GetFiltreType_Action(string jsonObject);
        Task<HttpResponseMessage> GetAllType_Action();
        Task<HttpResponseMessage> DeleteType_Action(string jsonObject);
        #endregion

        #region TYPE_AGENT
        Task<HttpResponseMessage> AddTypeAgent(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeAgent(string jsonObject);
        Task<HttpResponseMessage> GetTypeAgent(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeAgent(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeAgent();
        Task<HttpResponseMessage> DeleteTypeAgent(string jsonObject);
        #endregion

        #region TYPE_OBJET
        Task<HttpResponseMessage> AddType_Objet(string jsonObject);
        Task<HttpResponseMessage> UpdateType_Objet(string jsonObject);
        Task<HttpResponseMessage> GetType_Objet(string jsonObject);
        Task<HttpResponseMessage> GetFiltretype_Objet(string jsonObject);
        Task<HttpResponseMessage> GetAllType_Objet();
        Task<HttpResponseMessage> DeleteType_Objet(string jsonObject);
        #endregion

    }
}
