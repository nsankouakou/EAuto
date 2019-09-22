using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
//using Entities.Dtos;

namespace ClientWeb.Services
{
    public class ConfigurationService //: IConfigurationService
    {
        public ConfigurationService()
        {


        }

        //#region AGENT
        //public async Task<HttpResponseMessage> AddAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> AddTypeAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteTypeAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetAllAgent()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetAllTypeAgent()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetFiltreAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltreTypeAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetTypeAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> UpdateAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> UpdateTypeAgent(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //#endregion

        //#region ACTE
        //public async Task<HttpResponseMessage> GetActe(string jsonObject)
        //{

        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> AddActe(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);

        //}
        //public async Task<HttpResponseMessage> AddType_Acte(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteActe(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);

        //}
        //public async Task<HttpResponseMessage> DeleteType_Acte(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAllActe()
        //{

        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/GetAll");

        //}
        //public async Task<HttpResponseMessage> GetAllType_Acte()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetFiltreType_Acte(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltreActe(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetType_Acte(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> UpdateActe(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);

        //}
        //public async Task<HttpResponseMessage> UpdateType_Acte(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //#endregion

        //#region ACTION
        //public async Task<HttpResponseMessage> AddAction(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteAction(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteType_Action(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAction(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetAllAction()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetAllType_Action()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> UpdateType_Action(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> UpdateAction(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetType_Action(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltreType_Action(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltreAction(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> AddType_Action(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}

        //#endregion

        //#region PAYS
        //public async Task<HttpResponseMessage> AddPays(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAllPays()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> DeletePays(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> UpdatePays(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetPays(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltrePays(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //#endregion

        //#region COMMUNE
        //public async Task<HttpResponseMessage> AddCommune(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAllCommune()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> DeleteCommune(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetCommune(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetFiltreCommune(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> UpdateCommune(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}

        //#endregion

        //#region OBJET
        //public async Task<HttpResponseMessage> AddType_Objet(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteType_Objet(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAllType_Objet()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetFiltretype_Objet(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetType_Objet(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> UpdateType_Objet(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //#endregion

        //#region MODE LIVRAISON
        //public async Task<HttpResponseMessage> AddLivraison_Mode(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());

        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> DeleteLivraison_Mode(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    return await Utility.ClientApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        //}
        //public async Task<HttpResponseMessage> GetAllLivraison_Mode()
        //{
        //    return await Utility.ClientApi().GetAsync("api/Configuration/Acte/Edit");
        //}
        //public async Task<HttpResponseMessage> GetFiltreLivraison_Mode(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (string)ic["strRech"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> GetLivraison_Mode(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = (int)ic["id"];
        //    string url = "api/Configuration/Acte/Get?id=" + val;
        //    return await Utility.ClientApi().GetAsync(url);
        //}
        //public async Task<HttpResponseMessage> UpdateLivraison_Mode(string jsonObject)
        //{
        //    var ic = JObject.Parse(jsonObject);
        //    var val = JsonConvert.DeserializeObject<ACTEDTO>(ic.ToString());
        //    return await Utility.ClientApi().PostAsJsonAsync<ACTEDTO>("api/Configuration/Acte/add", val);
        //}

        //#endregion
        
    }
}
