using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Enumeration
{
   public static  class Const_TypeFormulaire
    {
        public const string DepotDeFonds = "02";
        public const string RecensementCabinets = "03";
        public const string RecensementAvocats = "04";
        public const string DemandeReglement = "05";
        public const string ValidationCheque = "06";
    }

    public static class Tva
    {
        public const decimal Tva1 =decimal.Zero;

    }

    public static class Const_Security
   {
       public static String sCleCryptage = "SNEMIKIDIASERVICE";

   }
   public static class TypeCompteCarpa
   {
      public const string ComptePrincipal = "01";
      public const string CompteSequestre="02";
      public const string CompteEspèces="03";
      public const string CompteInvestissement = "04";
      public const string CompteExploitation = "05";
      public const string CompteCarpa = "06";
   }
   public static class Const_ParametresGeneraux
   {
       public const string MontantDepotMaxi = "01";
       public const string NombreJoursAvantRetrait = "02";
       public const string DomainName = "03";
       public const string Username = "04";
       public const string DomainAdminPassword = "05";
       public const string SiteCarpa = "06";
       public const string ChequeNumberDigits = "07";
       public const string LastChequeNumber = "08";
       public const string CodeChequePays = "09";
       public const string DomainServerIpAddress = "10";
       public const string ComptePourCheque = "11";
       public const string AdresseCompteCarpa = "12";
       public const string NumeroTelephoneCompteCarpa = "13";
       public const string NumeroFaxCompteCARPA = "14";
       public const string DelaiEnvoiSMS = "15";
       public const string EmailGestionnaire = "16";
       public const string NumeroGestionnaire = "17";
       public const string FrequenceEnvoiSMS = "18";
   }

   public static class Const_TypeEnregistrements
   {
       public const string Emetteur_AncienSolde = "01";
       public const string Emetteur_03 = "03";
       public const string Destinataire_Mouvement = "04";
       public const string Enregistrement_Details = "05";
       public const string Destinataire_06 = "06";
       public const string Total_NouveauSolde = "07";
       public const string Total_08 = "08";
   }



}
