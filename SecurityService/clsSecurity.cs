using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Security.Cryptography;
using System.Text;

namespace SecurityService
{
    public static class clsSecurity
    {


        /// <summary>
        /// vérification de la conformité d'un mot de passe alpha numérique
        /// </summary>
        /// <param name="pass">mot de passe à vérifier</param>
        /// <returns></returns>
        public static bool getBConformitePass_alpha(string pass)
        {
            bool bValide = pass.Trim().Count() > 3;

            if(bValide)
                for(int i=1; i<pass.Count()-1;i++)
                {
                    if(pass[i]!=pass[i-1])
                    {
                        bValide = true;
                        break;
                    }
                    else
                    {
                        bValide = false;
                    }
                }

            return bValide;
        }

        /// <summary>
        /// réalisation d'un cryptage 3DES sans définir explicitement la clé privée
        /// </summary>
        /// <param name="strChaineACrypter">chaîne à crypter en mode 3DES</param>
        /// <returns>chaîne cryptée</returns>
        public static string getCryptage3DES(string strChaineACrypter)
        {
            string strKey = "";// "@5CMPP12";

            return getCryptage3DES(strChaineACrypter, strKey);
        }

        /// <summary>
        /// cryptage de chaîne de suivant l'algorithme 3DES
        /// </summary>
        /// <param name="strToCrypt">chaîne à crypter</param>
        /// <param name="strKey">clé privée de cryptage</param>
        /// <returns>chaîne cryptée</returns>
        public static string getCryptage3DES(string strToCrypt, string strKey)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(strToCrypt);


            keyArray = UTF8Encoding.UTF8.GetBytes(strKey);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            // définition de la clé privée
            tdes.Key = keyArray;

            
            //on utilisera le mode ECB
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            

            // transformation d'une partie du tableau de byte en tableau de résultat
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            
            // libération des ressources mobilisées par la méthode
            tdes.Clear();            

            // chaîne cryptée ramenée dans un format illisible
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        
        /// <summary>
        /// réalisation d'un décryptage d'une chaîne 3DES sans définir la clé privée utilisée
        /// </summary>
        /// <param name="strChaineADecrypter">chaîne à décrypter</param>
        /// <returns>chaîne décryptée</returns>
        public static string getDecryptage(string strChaineADecrypter)
        {
            string strKey = "";

            return getDecryptage(strChaineADecrypter, strKey);
        }

        /// <summary>
        /// décryptage d'une chaîne suivant l'algoritype 3DES
        /// </summary>
        /// <param name="strChaineADecrypter">chaîne à décrypter</param>
        /// <param name="strKey">clé privée de cryptage</param>
        /// <returns>chaîne décryptée</returns>
        public static string getDecryptage(string strChaineADecrypter, string strKey)
        {
            byte[] keyArray;


            byte[] toEncryptArray = Convert.FromBase64String(strChaineADecrypter);

                //convertir la clé en tableau de bit
                keyArray = UTF8Encoding.UTF8.GetBytes(strKey);
            

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //définition de la clé privée de l'algorithme

            tdes.Key = keyArray;
            
            //nou sutiliserons le mode EC
            tdes.Mode = CipherMode.ECB;

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            
            // libération des ressources utilisées par la méthode             
            tdes.Clear();

            // on ramène une chaîne de caractère lisible
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

    }
}