using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecurityService
{
    public static class clsToken
    {

        /// <summary>
        /// génération d'une chaîne cryptée devant être utilisée pour suivre un utilisateur connecté
        /// </summary>
        /// <param name="login">identifiant de l'utilisateur connecté</param>
        /// <param name="pass">mot de passe associé à login utilisateur</param>
        /// <param name="strAdressIP">adresse ip de l'utilisateur</param>
        /// <returns>ramène une chaîne de caractère cryptée consitutée de (@ip, date, idUtilsiateur)</returns>
        public static string getTokenConnexionInterface(string login, string pass, string strAdressIP)
        {
            string dtDte = DateTime.Now.ToLongTimeString();

            string strACrypter = login + "," + pass +","+ dtDte + "," + strAdressIP;


            strACrypter = clsSecurityHash.getSHA256(strACrypter);// clsSecurity.getCryptage3DES(strACrypter);

            // retour de l'information pour utilisation
            return strACrypter;
        }
    }
}