using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        string Save();
        void Dispose();
       
        ITbautreRubriqueRepository TbautreRubrique { get; }

        ITbavanceRepository Tbavance { get; }

        ITbassuranceRepository Tbassurance { get; }


        ITbagentRepository Tbagent { get; }

        ITbcarosserieRepository Tbcarosserie { get; }

        ITbcommuneRepository Tbcommune { get; }

        ITbconclusionRepository Tbconclusion { get; }

        ITbconclusionGenRepository TbconclusionGen { get; }

        ITbcouleurRepository Tbcouleur { get; }

        ITbdiscussionRepository Tbdiscussion { get; }

        ITbdossierRepository Tbdossier { get; }

        ITbdossierEtatRapportRepository TbdossierEtatRapport { get; }

        ITbdossierRubriqueHonoraireRepository TbdossierRubriqueHonoraire { get; }

        ITbdossierSortisRepository TbdossierSortis { get; }

        ITbdroitsRepository Tbdroits { get; }

        ITbenergieRepository Tbenergie { get; }

        ITbetatRapportRepository TbetatRapport { get; }

        ITbexpertiseRepository Tbexpertise { get; }

        ITbexpertiseDepannagePointChocRepository TbexpertiseDepannagePointChoc { get; }

        ITbexpertiseEtatRapportRepository TbexpertiseEtatRapport { get; }

        ITbexpertiseFourniturePointChocRepository TbexpertiseFourniturePointChoc { get; }

        ITbexpertisePointChocRepository TbexpertisePointChoc { get; }

        ITbexpertisePourRecousPointChocRepository TbexpertisePourRecousPointChoc { get; }

        ITbexpertiseRubriqueConstatationPointChocRepository TbexpertiseRubriqueConstatationPointChoc { get; }

        ITbexpertiseRubriqueEstimationRepository TbexpertiseRubriqueEstimation { get; }

        ITbexpertiseRubriqueMoRepository TbexpertiseRubriqueMo { get; }

        ITbexpertiseTravauxExterieurPointChocRepository TbexpertiseTravauxExterieurPointChoc { get; }

        ITbexpertiseTypeNoteRepository TbexpertiseTypeNote { get; }

        ITbfactureRepository Tbfacture { get; }

        ITbfournitureRepository Tbfourniture { get; }

        ITbgarageRepository Tbgarage { get; }

        ITbgenreRepository Tbgenre { get; }

        ITbmainOeuvreRepository TbmainOeuvre { get; }

        ITbmainOeuvrePointChocRepository TbmainOeuvrePointChoc { get; }

        ITbmarqueRepository Tbmarque { get; }

        ITbmarqueCarrosserieRepository TbmarqueCarrosserie { get; }

        ITbmodeReglementRepository TbmodeReglement { get; }

        ITbmodeleRepository Tbmodele { get; }

        ITbnbreElementRepository TbnbreElement { get; }

        ITbnbreElementMainOeuvreTypePeintureRepository TbnbreElementMainOeuvreTypePeinture { get; }

        ITbnoteRepository Tbnote { get; }

        ITbparametreRepository Tbparametre { get; }

        ITbphotoRepository Tbphoto { get; }

        ITbpointChocRepository TbpointChoc { get; }

        ITbpourRecoursRepository TbpourRecours { get; }

        ITbpreambuleRepository Tbpreambule { get; }

        ITbpreambuleGenRepository TbpreambuleGen { get; }

        ITbpriseEnChargeRepository TbpriseEnCharge { get; }

        ITbproprietaireRepository Tbproprietaire { get; }

        ITbrapportAcheveRepository TbrapportAcheve { get; }

        ITbrecapPrejudiceRepository TbrecapPrejudice { get; }

        ITbreglementRepository Tbreglement { get; }

        ITbrembourssementRepository Tbrembourssement { get; }

        ITbrubriqueConstatationRepository TbrubriqueConstatation { get; }

        ITbrubriqueEstimationRepository TbrubriqueEstimation { get; }

        ITbrubriqueEvalExpertiseRepository TbrubriqueEvalExpertise { get; }

        ITbrubriqueEvaluationRepository TbrubriqueEvaluation { get; }

        ITbrubriqueHonoraireRepository TbrubriqueHonoraire { get; }

        ITbrubriqueMainOeuvreRepository TbrubriqueMainOeuvre { get; }

        ITbserviceRepository Tbservice { get; }

        ITbspecialiteRepository Tbspecialite { get; }

        ITbspecialiteUserRepository TbspecialiteUser { get; }

        ITbtarifActifRepository TbtarifActif { get; }

        ITbtarifHoraireRepository TbtarifHoraire { get; }

        ITbtarifHoraireGarageMarqueRepository TbtarifHoraireGarageMarque { get; }

        ITbtravauxExterieurRepository TbtravauxExterieur { get; }

        ITbtvaRepository Tbtva { get; }

        ITbtypGarageRepository TbtypGarage { get; }

        ITbtypPeintureTarifActifTarifHonoraireNbreElemntRepository TbtypPeintureTarifActifTarifHonoraireNbreElemnt { get; }

        ITbtypTravauxMainOuvreRepository TbtypTravauxMainOuvre { get; }

        ITbtypeExpertiseRepository TbtypeExpertise { get; }

        ITbtypeNoteRepository TbtypeNote { get; }

        ITbtypePeintureRepository TbtypePeinture { get; }

        ITbtypeTravauxRepository TbtypeTravaux { get; }

        ITbtypeUserRepository TbtypeUser { get; }

        ITbtypeUserDroitRepository TbtypeUserDroit { get; }

        ITbtypeValeurRepository TbtypeValeur { get; }

        ITbtypeVehiculeRepository TbtypeVehicule { get; }

        ITbuserRepository Tbuser { get; }

        ITbuserDossierRepository TbuserDossier { get; }

        ITbvehiculeRepository Tbvehicule { get; }

        ITbvehiculeAssuranceRepository TbvehiculeAssurance { get; }

        ITbvilleRepository Tbville { get; }


    }
}
