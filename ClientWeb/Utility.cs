using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClientWeb
{
    public class Utility
    {
        public static int InactivityTimeBeforeReloading = Startup.InactivityTimeBeforeReloading;
        public static HttpClient ClientApi()
        {
            try
            {
               // string currentModule = moduleName;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Startup.ModuleServiceConfig);
                return client;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
        public static HttpClient ClientApiEtatCivil()
        {
            try
            {
                // string currentModule = moduleName;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(Startup.TraitementService);
                return client;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }

    }
}