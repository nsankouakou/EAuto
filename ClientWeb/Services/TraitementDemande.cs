using System.Net.Http;
using System.Threading.Tasks;
//using Entities.Dtos;
using Newtonsoft.Json;

namespace ClientWeb.Services
{
    public class TraitementDemande// : ITraitementDemande
    {
        //public async Task<HttpResponseMessage> ConnexionAgent(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<AGENTDTO>(jsonObject);
            
        //    string url = "AGENT/CONNEXION?login=" + val.LOGIN + "&pass=" + val.PASS;

        //    //string url = "AGENT/CONNEXION?login=" + val.LOGIN + "&pass=" + val.PASS + "&peripherique=";

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> ChangerMotDePasse(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<AGENTDTO>(jsonObject);

        //    string url = "AGENT/CHANGEMENT_PASS?login=" + val.LOGIN + "&pass=" + val.PASS +
        //                 "&newPass=" + val.newPass + "&confirmPass=" + val.confirmPass;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetAllDemandes(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<ConnexionObject>(jsonObject);

        //    string url = "AGENT/LISTER_DEMANDE_TOUTES?strToken=" + val.Token;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, new { val.Token });
        //}
        //public async Task<HttpResponseMessage> GetAllDemandesAgent(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<ConnexionObject>(jsonObject);

        //    string url = "AGENT/LISTER_DEMANDE_QUI_ME_CONCERNENT?strToken=" + val.Token + "&IDAgent=" + val.IDAgent;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);
        //}
        //public async Task<HttpResponseMessage> SaveEtapeEffectiveDemande(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<EtapeDemande>(jsonObject);
            
        //    string url = "AGENT/DEMANDE_ENREGISTRER_ETAPE_EFFECTIVE_SIMPLE?strToken=" + val.strToken + "&IDAgent=" + val.IDAgent +
        //                 "&idDemande=" + val.idDemande + "&idEtape=" + val.idEtape + "&contenu=" + val.contenu + "&observation=" + val.observation +
        //                 "&bEtat="+ val.bEtat + "&fichierBase64=" + val.fichierBase64;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);
        //}
        //public async Task<HttpResponseMessage> GenererFormulaireDemandeSuivi(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<EtapeDemande>(jsonObject);

        //    string url = "AGENT/GENERER_FORMULAIRE_DEMANDE_SUIVI?strToken=" + val.strToken + "&idDemande=" + val.idDemande;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetInfosSuiviDemande(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<EtapeDemande>(jsonObject);

        //    string url = "AGENT/ETAT_DEMANDE?idDemande="+ val.idDemande;

        //    return await Utility.ClientApiEtatCivil().GetAsync(url);

        //    //return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetUrlNewDemande(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<ConnexionObject>(jsonObject);

        //    string url = "AGENT/INITIER_OPERATION_DEMANDE?TOKEN="+val.Token;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetListeRegitres(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<ConnexionObject>(jsonObject);

        //    string url = "AGENT/LISTER_REGISTRES?strToken=" + val.Token + "&IDCommune=" + val.IDCommune;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GenererInfosUtilesPourActe(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);

        //    string url = "AGENT/NUM_GENERER_INFOS_UTILES_POUR_ACTE?strToken=" + val.strToken + "&idActe=" + val.idActe +
        //                 "&idRegistre=" + val.ROWID_REGISTRE + "&NUMERO_ACTE=" + val.NumEnregistrement;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GenererInfosUtilesPourRechercheActe(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);

        //    string url = "AGENT/RETOURN_INFOS_UTILES_POUR_ACTE?strToken=" + val.strToken + "&idActe=" + val.idActe +
        //                 "&idRegistre=" + val.ROWID_REGISTRE + "&NUMERO_ACTE=" + val.NumEnregistrement;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> EnregisterInfosUtilesPourActe(string jsonObject, string values)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);
        //    var contentData = new StringContent(values, System.Text.Encoding.UTF8,"application/json");
        //    string url = "AGENT/NUM_ENREGISTRER_INFO_ACTE_OBJECT?strToken=" + val.strToken +
        //        "&ROWID_REGISTRE=" + val.ROWID_REGISTRE + "&NumEnregistrement=" + val.NumEnregistrement +
        //        "&idActe=" + val.idActe;

        //    return await Utility.ClientApiEtatCivil().PostAsync(url, contentData);
        //}
        //public async Task<HttpResponseMessage> RechercheActe(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<SearchObject>(jsonObject);

        //    string url = "AGENT/RECHERCHE_ACTE?strToken=" + val.strToken + "&IDCommune=" +
        //        val.IDCommune + "&IDActe=" + val.IDActe + "&Recherche=" + val.Recherche;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetAllActe()
        //{
        //    return await Utility.ClientApiEtatCivil().GetAsync("CLIENT/LISTER_ACTES");

        //}
        //public async Task<HttpResponseMessage> GetAllActePrincipaux()
        //{
        //    return await Utility.ClientApiEtatCivil().GetAsync("CLIENT/LISTER_ACTES_PRINCIPAUX");

        //}
        //public async Task<HttpResponseMessage> AddRegistre(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        //    string url = "AGENT/ENREGISTRER_REGISTRE?strToken=" + val.Token + "&IDCommune=" +
        //        val.IdCommune + "&numero_registre=" + val.Numero + "&annee_registre=" + val.Annee +
        //        "&nb_feuille=" + val.NbreFeuilles + "&decision_tribunal=" + val.DecisionTribunal +
        //        "&IdType_registre=" + val.IdTypeRegistre + "&datOuv=" + val.DateOuverture + "&numero_debut=" + val.NumeroDebut + "&numero_fin=" + val.NumeroFin;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> UpdateRegistre(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        //    string url = "AGENT/MODIFIER_REGISTRE?strToken=" + val.Token + "&IDCommune=" +
        //        val.IdCommune + "&numero_registre=" + val.Numero + "&annee_registre=" + val.Annee +
        //        "&nb_feuille=" + val.NbreFeuilles + "&decision_tribunal=" + val.DecisionTribunal +
        //        "&IdType_registre=" + val.IdTypeRegistre + "&datOuv=" + val.DateOuverture + "&numero_debut=" + val.NumeroDebut + "&numero_fin=" + val.NumeroFin;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> DeleteRegistre(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        //    string url = "=" + val + "&IDCommune=" +
        //        val + "&IDActe=" + val + "&Recherche=" + val;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetAllRegistres(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        //    string url = "AGENT/LISTER_REGISTRES_ALL?strToken=" + val.Token + "&IDCommune=" + val.IdCommune;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        ////public async Task<HttpResponseMessage> GetRegistre(string jsonObject)
        ////{
        ////    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        ////    string url = "AGENT/GET_REGISTRE?strToken=" + val.Token + "&IDRegistre=" +
        ////        val.RegistreId ;

        ////    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        ////}
        //public async Task<HttpResponseMessage> GetTypeRegistres(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<Registre>(jsonObject);

        //    string url = "AGENT/LISTER_TYPE_REGISTRES?strToken=" + val.Token + "&IDCommune=" + val.IdCommune;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GetRegistreByTypeActe(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);
        //    string url = "AGENT/LISTER_REGISTRES_PAR_TYPE_ACTE?strToken=" + val.strToken +
        //        "&IDCommune=" + val.IdCommune+ "&iDtypeActe=" + val.iDtypeActe;

        //    return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);

        //}
        //public async Task<HttpResponseMessage> GenererFormulaireDemande(string jsonObject)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);

        //    string url = "AGENT/GENERER_FORMULAIRE_DEMANDE_AGENT?idActe=" + val.idActe;
        //    //string url = "CLIENT/GENERER_FORMULAIRE_DEMANDE?idActe=" + val.idActe;

        //    // return await Utility.ClientApiEtatCivil().PostAsJsonAsync(url, val);
        //    return await Utility.ClientApiEtatCivil().GetAsync(url);

        //}
        //public async Task<HttpResponseMessage> EnregistrerDemande(string jsonObject, string values)
        //{
        //    var val = JsonConvert.DeserializeObject<InfoUtile>(jsonObject);
        //    var contentData = new StringContent(values, System.Text.Encoding.UTF8, "application/json");
        //    string url = "AGENT/TRANSMETTRE_FORMULAIRE_DEMANDE_AGENT?idActe=" + val.idActe +
        //                 "&idCommune=" + val.IdCommune + "&rowIdAgent=" + val.RowIdAgent + "&TOKEN=" + val.strToken;

        //    return await Utility.ClientApiEtatCivil().PostAsync(url, contentData);
        //}
    }
}
