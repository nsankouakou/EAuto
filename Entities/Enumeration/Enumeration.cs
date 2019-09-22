using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Enumeration
{
    public class Enumeration
    {
       
        public enum StatutCodeDemande
        {

            DonneesClienteles = 1,
            Metre = 2,
            EnAttenteDePaiement = 3,
            CompteRendu = 4,
            DemandeComplete = 5,
            AucunStatus = 0

        }
        public enum enumEtat
        {
            Non_Valide = 0,
            Valide = 1
        }

        public enum enumTypeDonnees
        {
            NUMERIQUE = 1,
            ALPHABETIQUE = 2,
            BOOLEAN = 3,
            LISTE = 4,
            DATE = 5
        }

        #region StatusCompteUtilisateur 

        public enum StatusCompteUtilisateur
        {
            Actif = 1,
            Inactif,
            Verrouille,
            VerrouilleOuvertureSession
        };

        #endregion

        #region StatusEnvoiMail

        public enum StatusEnvoiMail
        {
            NonEnvoyer = 0,
            Envoyer
        };

        #endregion

        //  1 = FOURNIR PAR SNE, 
        //  2 = FOURNIR PAR L'ABONNE

        #region StatusComposant

        public enum StatusComposant
        {
            InclureDansDevis = 1,
            InclureDansBonCommande = 2,
            EstAvanceSurConso = 3
        };

        #endregion

        #region StatusEnvoiSms

        public enum StatusEnvoiSms
        {
            NonEnvoyer = 0,
            Envoyer
        };

        #endregion

        #region StatusRejet

        public enum StatusRejet
        {
            PasRejeter = 0,
            Rejeter = 1
        };

        #endregion

        #region Operation de Validation
        public enum OperationValidation
        {
            valider = 0,
            rejeter,
            envoyer
        }
        #endregion

        #region StatusCode

        public enum StatutCode
        {
            Actif = 1,
            Inactif = 0
        };

        public enum StateCode
        {
            Actif = 1,
            Inactif = 0,
            Transferer =3
        };

        public enum StatutCompteur
        {
            En_Stock = 1,
            Transferer = 2,
            Affecter = 3
            
        };

        #endregion

        #region StateCode


        public enum statutCodeStock
        {
            Transfere = 1,
            Affecte = 2
        };




        #endregion

        #region Agent

        public enum AgentFonction
        {
            AgentEtude = 1,
            AgentBranchement = 2,
            AgentCommercial = 3

        };

        public enum EtatAgent
        {
            EnFonction = 1,
            Suspendu = 2,
            EnConges = 3,
            Supprimer = 4

        };

        #endregion



    }
}
