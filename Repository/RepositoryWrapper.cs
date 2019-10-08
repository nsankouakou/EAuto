using Contracts;
using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DbExpertAutoContext _repoContext;
        IDbContextTransaction _transaction = null;

        public RepositoryWrapper(DbExpertAutoContext repositoryContext)
        {
            _repoContext = repositoryContext;
            _transaction = _repoContext.Database.BeginTransaction();
        }


        
        private bool _disposed = false;


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                
                if (disposing)
                {
                    _transaction.Dispose();
                    _repoContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public string Save()
        {
            
                _repoContext.SaveChanges();
                _transaction.Commit();

            return "";
        }
       

       

        private ITbassuranceRepository _Tbassurance;

        public ITbassuranceRepository Tbassurance
        {
            get
            {
                if (_Tbassurance == null)
                {
                     _Tbassurance = new TbassuranceRepository(_repoContext);
                }

                return _Tbassurance;
            }
        }

        private ITbagentRepository _Tbagent;

        public ITbagentRepository Tbagent
        {
            get
            {
                if (_Tbagent == null)
                {
                    _Tbagent = new TbagentRepository(_repoContext);
                }

                return _Tbagent;
            }
        }


        private ITbautreRubriqueRepository _TbautreRubrique;

        public ITbautreRubriqueRepository TbautreRubrique
        {
            get
            {
                if (_TbautreRubrique == null)
                {
                    _TbautreRubrique = new TbautreRubriqueRepository(_repoContext);
                }

                return _TbautreRubrique;
            }
        }

        private ITbavanceRepository _Tbavance;

        public ITbavanceRepository Tbavance
        {
            get
            {
                if (_Tbavance == null)
                {
                    _Tbavance = new TbavanceRepository(_repoContext);
                }

                return _Tbavance;
            }
        }

        private ITbcarosserieRepository _Tbcarosserie;

        public ITbcarosserieRepository Tbcarosserie
        {
            get
            {
                if (_Tbcarosserie == null)
                {
                    _Tbcarosserie = new TbcarosserieRepository(_repoContext);
                }

                return _Tbcarosserie;
            }
        }

        private ITbcommuneRepository _Tbcommune;

        public ITbcommuneRepository Tbcommune
        {
            get
            {
                if (_Tbcommune == null)
                {
                    _Tbcommune = new TbcommuneRepository(_repoContext);
                }

                return _Tbcommune;
            }
        }

        private ITbconclusionRepository _Tbconclusion;

        public ITbconclusionRepository Tbconclusion
        {
            get
            {
                if (_Tbconclusion == null)
                {
                    _Tbconclusion = new TbconclusionRepository(_repoContext);
                }

                return _Tbconclusion;
            }
        }
        private ITbconclusionGenRepository _TbconclusionGen;

        public ITbconclusionGenRepository TbconclusionGen
        {
            get
            {
                if (_TbconclusionGen == null)
                {
                    _TbconclusionGen = new TbconclusionGenRepository(_repoContext);
                }

                return _TbconclusionGen;
            }
        }
        private ITbcouleurRepository _Tbcouleur;

        public ITbcouleurRepository Tbcouleur
        {
            get
            {
                if (_Tbcouleur == null)
                {
                    _Tbcouleur = new TbcouleurRepository(_repoContext);
                }

                return _Tbcouleur;
            }
        }
        private ITbdiscussionRepository _Tbdiscussion;

        public ITbdiscussionRepository Tbdiscussion
        {
            get
            {
                if (_Tbdiscussion == null)
                {
                    _Tbdiscussion = new TbdiscussionRepository(_repoContext);
                }

                return _Tbdiscussion;
            }
        }
        private ITbdossierRepository _Tbdossier;

        public ITbdossierRepository Tbdossier
        {
            get
            {
                if (_Tbdossier == null)
                {
                    _Tbdossier = new TbdossierRepository(_repoContext);
                }

                return _Tbdossier;
            }
        }
        private ITbdossierEtatRapportRepository _TbdossierEtatRapport;

        public ITbdossierEtatRapportRepository TbdossierEtatRapport
        {
            get
            {
                if (_TbdossierEtatRapport == null)
                {
                    _TbdossierEtatRapport = new TbdossierEtatRapportRepository(_repoContext);
                }

                return _TbdossierEtatRapport;
            }
        }



        private ITbdossierRubriqueHonoraireRepository _TbdossierRubriqueHonoraire;

        public ITbdossierRubriqueHonoraireRepository TbdossierRubriqueHonoraire
        {
            get
            {
                if (_TbdossierRubriqueHonoraire == null)
                {
                    _TbdossierRubriqueHonoraire = new TbdossierRubriqueHonoraireRepository(_repoContext);
                }

                return _TbdossierRubriqueHonoraire;
            }
        }


        private ITbdossierSortisRepository _TbdossierSortis;

        public ITbdossierSortisRepository TbdossierSortis
        {
            get
            {
                if (_TbdossierSortis == null)
                {
                    _TbdossierSortis = new TbdossierSortisRepository(_repoContext);
                }

                return _TbdossierSortis;
            }
        }

        private ITbdroitsRepository _Tbdroits;

        public ITbdroitsRepository Tbdroits
        {
            get
            {
                if (_Tbdroits == null)
                {
                    _Tbdroits = new TbdroitsRepository(_repoContext);
                }

                return _Tbdroits;
            }
        }

        private ITbenergieRepository _Tbenergie;

        public ITbenergieRepository Tbenergie
        {
            get
            {
                if (_Tbenergie == null)
                {
                    _Tbenergie = new TbenergieRepository(_repoContext);
                }

                return _Tbenergie;
            }
        }

        private ITbetatRapportRepository _TbetatRapport;

        public ITbetatRapportRepository TbetatRapport
        {
            get
            {
                if (_TbetatRapport == null)
                {
                    _TbetatRapport = new TbetatRapportRepository(_repoContext);
                }

                return _TbetatRapport;
            }
        }

        private ITbexpertiseRepository _Tbexpertise;

        public ITbexpertiseRepository Tbexpertise
        {
            get
            {
                if (_Tbexpertise == null)
                {
                    _Tbexpertise = new TbexpertiseRepository(_repoContext);
                }

                return _Tbexpertise;
            }
        }
        private ITbexpertiseDepannagePointChocRepository _TbexpertiseDepannagePointChoc;

        public ITbexpertiseDepannagePointChocRepository TbexpertiseDepannagePointChoc
        {
            get
            {
                if (_TbexpertiseDepannagePointChoc == null)
                {
                    _TbexpertiseDepannagePointChoc = new TbexpertiseDepannagePointChocRepository(_repoContext);
                }

                return _TbexpertiseDepannagePointChoc;
            }
        }
        private ITbexpertiseEtatRapportRepository _TbexpertiseEtatRapport;

        public ITbexpertiseEtatRapportRepository TbexpertiseEtatRapport
        {
            get
            {
                if (_TbexpertiseEtatRapport == null)
                {
                    _TbexpertiseEtatRapport = new TbexpertiseEtatRapportRepository(_repoContext);
                }

                return _TbexpertiseEtatRapport;
            }
        }
        private ITbexpertiseFourniturePointChocRepository _TbexpertiseFourniturePointChoc;

        public ITbexpertiseFourniturePointChocRepository TbexpertiseFourniturePointChoc
        {
            get
            {
                if (_TbexpertiseFourniturePointChoc == null)
                {
                    _TbexpertiseFourniturePointChoc = new TbexpertiseFourniturePointChocRepository(_repoContext);
                }

                return _TbexpertiseFourniturePointChoc;
            }
        }
        private ITbexpertisePointChocRepository _TbexpertisePointChoc;

        public ITbexpertisePointChocRepository TbexpertisePointChoc
        {
            get
            {
                if (_TbexpertisePointChoc == null)
                {
                    _TbexpertisePointChoc = new TbexpertisePointChocRepository(_repoContext);
                }

                return _TbexpertisePointChoc;
            }
        }
        private ITbexpertisePourRecousPointChocRepository _TbexpertisePourRecousPointChoc;

        public ITbexpertisePourRecousPointChocRepository TbexpertisePourRecousPointChoc
        {
            get
            {
                if (_TbexpertisePourRecousPointChoc == null)
                {
                    _TbexpertisePourRecousPointChoc = new TbexpertisePourRecousPointChocRepository(_repoContext);
                }

                return _TbexpertisePourRecousPointChoc;
            }
        }



        private ITbexpertiseRubriqueConstatationPointChocRepository _TbexpertiseRubriqueConstatationPointChoc;

        public ITbexpertiseRubriqueConstatationPointChocRepository TbexpertiseRubriqueConstatationPointChoc
        {
            get
            {
                if (_TbexpertiseRubriqueConstatationPointChoc == null)
                {
                    _TbexpertiseRubriqueConstatationPointChoc = new TbexpertiseRubriqueConstatationPointChocRepository(_repoContext);
                }

                return _TbexpertiseRubriqueConstatationPointChoc;
            }
        }


        private ITbexpertiseRubriqueEstimationRepository _TbexpertiseRubriqueEstimation;

        public ITbexpertiseRubriqueEstimationRepository TbexpertiseRubriqueEstimation
        {
            get
            {
                if (_TbexpertiseRubriqueEstimation == null)
                {
                    _TbexpertiseRubriqueEstimation = new TbexpertiseRubriqueEstimationRepository(_repoContext);
                }

                return _TbexpertiseRubriqueEstimation;
            }
        }

        private ITbexpertiseRubriqueMoRepository _TbexpertiseRubriqueMo;

        public ITbexpertiseRubriqueMoRepository TbexpertiseRubriqueMo
        {
            get
            {
                if (_TbexpertiseRubriqueMo == null)
                {
                    _TbexpertiseRubriqueMo = new TbexpertiseRubriqueMoRepository(_repoContext);
                }

                return _TbexpertiseRubriqueMo;
            }
        }

        private ITbexpertiseTravauxExterieurPointChocRepository _TbexpertiseTravauxExterieurPointChoc;

        public ITbexpertiseTravauxExterieurPointChocRepository TbexpertiseTravauxExterieurPointChoc
        {
            get
            {
                if (_TbexpertiseTravauxExterieurPointChoc == null)
                {
                    _TbexpertiseTravauxExterieurPointChoc = new TbexpertiseTravauxExterieurPointChocRepository(_repoContext);
                }

                return _TbexpertiseTravauxExterieurPointChoc;
            }
        }

        private ITbexpertiseTypeNoteRepository _TbexpertiseTypeNote;

        public ITbexpertiseTypeNoteRepository TbexpertiseTypeNote
        {
            get
            {
                if (_TbexpertiseTypeNote == null)
                {
                    _TbexpertiseTypeNote = new TbexpertiseTypeNoteRepository(_repoContext);
                }

                return _TbexpertiseTypeNote;
            }
        }

        private ITbfactureRepository _Tbfacture;

        public ITbfactureRepository Tbfacture
        {
            get
            {
                if (_Tbfacture == null)
                {
                    _Tbfacture = new TbfactureRepository(_repoContext);
                }

                return _Tbfacture;
            }
        }
        private ITbfournitureRepository _Tbfourniture;

        public ITbfournitureRepository Tbfourniture
        {
            get
            {
                if (_Tbfourniture == null)
                {
                    _Tbfourniture = new TbfournitureRepository(_repoContext);
                }

                return _Tbfourniture;
            }
        }
        private ITbgarageRepository _Tbgarage;

        public ITbgarageRepository Tbgarage
        {
            get
            {
                if (_Tbgarage == null)
                {
                    _Tbgarage = new TbgarageRepository(_repoContext);
                }

                return _Tbgarage;
            }
        }
        private ITbgenreRepository _Tbgenre;

        public ITbgenreRepository Tbgenre
        {
            get
            {
                if (_Tbgenre == null)
                {
                    _Tbgenre = new TbgenreRepository(_repoContext);
                }

                return _Tbgenre;
            }
        }
        private ITbmainOeuvreRepository _TbmainOeuvre;

        public ITbmainOeuvreRepository TbmainOeuvre
        {
            get
            {
                if (_TbmainOeuvre == null)
                {
                    _TbmainOeuvre = new TbmainOeuvreRepository(_repoContext);
                }

                return _TbmainOeuvre;
            }
        }
        private ITbmainOeuvrePointChocRepository _TbmainOeuvrePointChoc;

        public ITbmainOeuvrePointChocRepository TbmainOeuvrePointChoc
        {
            get
            {
                if (_TbmainOeuvrePointChoc == null)
                {
                    _TbmainOeuvrePointChoc = new TbmainOeuvrePointChocRepository(_repoContext);
                }

                return _TbmainOeuvrePointChoc;
            }
        }



        private ITbmarqueRepository _Tbmarque;

        public ITbmarqueRepository Tbmarque
        {
            get
            {
                if (_Tbmarque == null)
                {
                    _Tbmarque = new TbmarqueRepository(_repoContext);
                }

                return _Tbmarque;
            }
        }


        private ITbmarqueCarrosserieRepository _TbmarqueCarrosserie;

        public ITbmarqueCarrosserieRepository TbmarqueCarrosserie
        {
            get
            {
                if (_TbmarqueCarrosserie == null)
                {
                    _TbmarqueCarrosserie = new TbmarqueCarrosserieRepository(_repoContext);
                }

                return _TbmarqueCarrosserie;
            }
        }

        private ITbmodeReglementRepository _TbmodeReglement;

        public ITbmodeReglementRepository TbmodeReglement
        {
            get
            {
                if (_TbmodeReglement == null)
                {
                    _TbmodeReglement = new TbmodeReglementRepository(_repoContext);
                }

                return _TbmodeReglement;
            }
        }

        private ITbmodeleRepository _Tbmodele;

        public ITbmodeleRepository Tbmodele
        {
            get
            {
                if (_Tbmodele == null)
                {
                    _Tbmodele = new TbmodeleRepository(_repoContext);
                }

                return _Tbmodele;
            }
        }

        private ITbnbreElementRepository _TbnbreElement;

        public ITbnbreElementRepository TbnbreElement
        {
            get
            {
                if (_TbnbreElement == null)
                {
                    _TbnbreElement = new TbnbreElementRepository(_repoContext);
                }

                return _TbnbreElement;
            }
        }

        private ITbnbreElementMainOeuvreTypePeintureRepository _TbnbreElementMainOeuvreTypePeinture;

        public ITbnbreElementMainOeuvreTypePeintureRepository TbnbreElementMainOeuvreTypePeinture
        {
            get
            {
                if (_TbnbreElementMainOeuvreTypePeinture == null)
                {
                    _TbnbreElementMainOeuvreTypePeinture = new TbnbreElementMainOeuvreTypePeintureRepository(_repoContext);
                }

                return _TbnbreElementMainOeuvreTypePeinture;
            }
        }
        private ITbnoteRepository _Tbnote;

        public ITbnoteRepository Tbnote
        {
            get
            {
                if (_Tbnote == null)
                {
                    _Tbnote = new TbnoteRepository(_repoContext);
                }

                return _Tbnote;
            }
        }
        private ITbparametreRepository _Tbparametre;

        public ITbparametreRepository Tbparametre
        {
            get
            {
                if (_Tbparametre == null)
                {
                    _Tbparametre = new TbparametreRepository(_repoContext);
                }

                return _Tbparametre;
            }
        }
        private ITbphotoRepository _Tbphoto;

        public ITbphotoRepository Tbphoto
        {
            get
            {
                if (_Tbphoto == null)
                {
                    _Tbphoto = new TbphotoRepository(_repoContext);
                }

                return _Tbphoto;
            }
        }
        private ITbpointChocRepository _TbpointChoc;

        public ITbpointChocRepository TbpointChoc
        {
            get
            {
                if (_TbpointChoc == null)
                {
                    _TbpointChoc = new TbpointChocRepository(_repoContext);
                }

                return _TbpointChoc;
            }
        }
        private ITbpourRecoursRepository _TbpourRecours;

        public ITbpourRecoursRepository TbpourRecours
        {
            get
            {
                if (_TbpourRecours == null)
                {
                    _TbpourRecours = new TbpourRecoursRepository(_repoContext);
                }

                return _TbpourRecours;
            }
        }



        private ITbpreambuleRepository _Tbpreambule;

        public ITbpreambuleRepository Tbpreambule
        {
            get
            {
                if (_Tbpreambule == null)
                {
                    _Tbpreambule = new TbpreambuleRepository(_repoContext);
                }

                return _Tbpreambule;
            }
        }


        private ITbpreambuleGenRepository _TbpreambuleGen;

        public ITbpreambuleGenRepository TbpreambuleGen
        {
            get
            {
                if (_TbpreambuleGen == null)
                {
                    _TbpreambuleGen = new TbpreambuleGenRepository(_repoContext);
                }

                return _TbpreambuleGen;
            }
        }

        private ITbpriseEnChargeRepository _TbpriseEnCharge;

        public ITbpriseEnChargeRepository TbpriseEnCharge
        {
            get
            {
                if (_TbpriseEnCharge == null)
                {
                    _TbpriseEnCharge = new TbpriseEnChargeRepository(_repoContext);
                }

                return _TbpriseEnCharge;
            }
        }

        private ITbproprietaireRepository _Tbproprietaire;

        public ITbproprietaireRepository Tbproprietaire
        {
            get
            {
                if (_Tbproprietaire == null)
                {
                    _Tbproprietaire = new TbproprietaireRepository(_repoContext);
                }

                return _Tbproprietaire;
            }
        }

        private ITbrapportAcheveRepository _TbrapportAcheve;

        public ITbrapportAcheveRepository TbrapportAcheve
        {
            get
            {
                if (_TbrapportAcheve == null)
                {
                    _TbrapportAcheve = new TbrapportAcheveRepository(_repoContext);
                }

                return _TbrapportAcheve;
            }
        }

        private ITbrecapPrejudiceRepository _TbrecapPrejudice;

        public ITbrecapPrejudiceRepository TbrecapPrejudice
        {
            get
            {
                if (_TbrecapPrejudice == null)
                {
                    _TbrecapPrejudice = new TbrecapPrejudiceRepository(_repoContext);
                }

                return _TbrecapPrejudice;
            }
        }
        private ITbreglementRepository _Tbreglement;

        public ITbreglementRepository Tbreglement
        {
            get
            {
                if (_Tbreglement == null)
                {
                    _Tbreglement = new TbreglementRepository(_repoContext);
                }

                return _Tbreglement;
            }
        }
        private ITbrembourssementRepository _Tbrembourssement;

        public ITbrembourssementRepository Tbrembourssement
        {
            get
            {
                if (_Tbrembourssement == null)
                {
                    _Tbrembourssement = new TbrembourssementRepository(_repoContext);
                }

                return _Tbrembourssement;
            }
        }
        private ITbrubriqueConstatationRepository _TbrubriqueConstatation;

        public ITbrubriqueConstatationRepository TbrubriqueConstatation
        {
            get
            {
                if (_TbrubriqueConstatation == null)
                {
                    _TbrubriqueConstatation = new TbrubriqueConstatationRepository(_repoContext);
                }

                return _TbrubriqueConstatation;
            }
        }
        private ITbrubriqueEstimationRepository _TbrubriqueEstimation;

        public ITbrubriqueEstimationRepository TbrubriqueEstimation
        {
            get
            {
                if (_TbrubriqueEstimation == null)
                {
                    _TbrubriqueEstimation = new TbrubriqueEstimationRepository(_repoContext);
                }

                return _TbrubriqueEstimation;
            }
        }
        private ITbrubriqueEvalExpertiseRepository _TbrubriqueEvalExpertise;

        public ITbrubriqueEvalExpertiseRepository TbrubriqueEvalExpertise
        {
            get
            {
                if (_TbrubriqueEvalExpertise == null)
                {
                    _TbrubriqueEvalExpertise = new TbrubriqueEvalExpertiseRepository(_repoContext);
                }

                return _TbrubriqueEvalExpertise;
            }
        }



        private ITbrubriqueEvaluationRepository _TbrubriqueEvaluation;

        public ITbrubriqueEvaluationRepository TbrubriqueEvaluation
        {
            get
            {
                if (_TbrubriqueEvaluation == null)
                {
                    _TbrubriqueEvaluation = new TbrubriqueEvaluationRepository(_repoContext);
                }

                return _TbrubriqueEvaluation;
            }
        }


        private ITbrubriqueHonoraireRepository _TbrubriqueHonoraire;

        public ITbrubriqueHonoraireRepository TbrubriqueHonoraire
        {
            get
            {
                if (_TbrubriqueHonoraire == null)
                {
                    _TbrubriqueHonoraire = new TbrubriqueHonoraireRepository(_repoContext);
                }

                return _TbrubriqueHonoraire;
            }
        }

        private ITbrubriqueMainOeuvreRepository _TbrubriqueMainOeuvre;

        public ITbrubriqueMainOeuvreRepository TbrubriqueMainOeuvre
        {
            get
            {
                if (_TbrubriqueMainOeuvre == null)
                {
                    _TbrubriqueMainOeuvre = new TbrubriqueMainOeuvreRepository(_repoContext);
                }

                return _TbrubriqueMainOeuvre;
            }
        }

        private ITbserviceRepository _Tbservice;

        public ITbserviceRepository Tbservice
        {
            get
            {
                if (_Tbservice == null)
                {
                    _Tbservice = new TbserviceRepository(_repoContext);
                }

                return _Tbservice;
            }
        }

        private ITbspecialiteRepository _Tbspecialite;

        public ITbspecialiteRepository Tbspecialite
        {
            get
            {
                if (_Tbspecialite == null)
                {
                    _Tbspecialite = new TbspecialiteRepository(_repoContext);
                }

                return _Tbspecialite;
            }
        }

        private ITbspecialiteUserRepository _TbspecialiteUser;

        public ITbspecialiteUserRepository TbspecialiteUser
        {
            get
            {
                if (_TbspecialiteUser == null)
                {
                    _TbspecialiteUser = new TbspecialiteUserRepository(_repoContext);
                }

                return _TbspecialiteUser;
            }
        }
        private ITbtarifActifRepository _TbtarifActif;

        public ITbtarifActifRepository TbtarifActif
        {
            get
            {
                if (_TbtarifActif == null)
                {
                    _TbtarifActif = new TbtarifActifRepository(_repoContext);
                }

                return _TbtarifActif;
            }
        }
        private ITbtarifHoraireRepository _TbtarifHoraire;

        public ITbtarifHoraireRepository TbtarifHoraire
        {
            get
            {
                if (_TbtarifHoraire == null)
                {
                    _TbtarifHoraire = new TbtarifHoraireRepository(_repoContext);
                }

                return _TbtarifHoraire;
            }
        }
        private ITbtarifHoraireGarageMarqueRepository _TbtarifHoraireGarageMarque;

        public ITbtarifHoraireGarageMarqueRepository TbtarifHoraireGarageMarque
        {
            get
            {
                if (_TbtarifHoraireGarageMarque == null)
                {
                    _TbtarifHoraireGarageMarque = new TbtarifHoraireGarageMarqueRepository(_repoContext);
                }

                return _TbtarifHoraireGarageMarque;
            }
        }
        private ITbtravauxExterieurRepository _TbtravauxExterieur;

        public ITbtravauxExterieurRepository TbtravauxExterieur
        {
            get
            {
                if (_TbtravauxExterieur == null)
                {
                    _TbtravauxExterieur = new TbtravauxExterieurRepository(_repoContext);
                }

                return _TbtravauxExterieur;
            }
        }
        private ITbtvaRepository _Tbtva;

        public ITbtvaRepository Tbtva
        {
            get
            {
                if (_Tbtva == null)
                {
                    _Tbtva = new TbtvaRepository(_repoContext);
                }

                return _Tbtva;
            }
        }



        private ITbtypGarageRepository _TbtypGarage;

        public ITbtypGarageRepository TbtypGarage
        {
            get
            {
                if (_TbtypGarage == null)
                {
                    _TbtypGarage = new TbtypGarageRepository(_repoContext);
                }

                return _TbtypGarage;
            }
        }


        private ITbtypPeintureTarifActifTarifHonoraireNbreElemntRepository _TbtypPeintureTarifActifTarifHonoraireNbreElemnt;

        public ITbtypPeintureTarifActifTarifHonoraireNbreElemntRepository TbtypPeintureTarifActifTarifHonoraireNbreElemnt
        {
            get
            {
                if (_TbtypPeintureTarifActifTarifHonoraireNbreElemnt == null)
                {
                    _TbtypPeintureTarifActifTarifHonoraireNbreElemnt = new TbtypPeintureTarifActifTarifHonoraireNbreElemntRepository(_repoContext);
                }

                return _TbtypPeintureTarifActifTarifHonoraireNbreElemnt;
            }
        }

        private ITbtypTravauxMainOuvreRepository _TbtypTravauxMainOuvre;

        public ITbtypTravauxMainOuvreRepository TbtypTravauxMainOuvre
        {
            get
            {
                if (_TbtypTravauxMainOuvre == null)
                {
                    _TbtypTravauxMainOuvre = new TbtypTravauxMainOuvreRepository(_repoContext);
                }

                return _TbtypTravauxMainOuvre;
            }
        }

        private ITbtypeExpertiseRepository _TbtypeExpertise;

        public ITbtypeExpertiseRepository TbtypeExpertise
        {
            get
            {
                if (_TbtypeExpertise == null)
                {
                    _TbtypeExpertise = new TbtypeExpertiseRepository(_repoContext);
                }

                return _TbtypeExpertise;
            }
        }

        private ITbtypeNoteRepository _TbtypeNote;

        public ITbtypeNoteRepository TbtypeNote
        {
            get
            {
                if (_TbtypeNote == null)
                {
                    _TbtypeNote = new TbtypeNoteRepository(_repoContext);
                }

                return _TbtypeNote;
            }
        }

        private ITbtypePeintureRepository _TbtypePeinture;

        public ITbtypePeintureRepository TbtypePeinture
        {
            get
            {
                if (_TbtypePeinture == null)
                {
                    _TbtypePeinture = new TbtypePeintureRepository(_repoContext);
                }

                return _TbtypePeinture;
            }
        }
        private ITbtypeTravauxRepository _TbtypeTravaux;

        public ITbtypeTravauxRepository TbtypeTravaux
        {
            get
            {
                if (_TbtypeTravaux == null)
                {
                    _TbtypeTravaux = new TbtypeTravauxRepository(_repoContext);
                }

                return _TbtypeTravaux;
            }
        }
        private ITbtypeUserRepository _TbtypeUser;

        public ITbtypeUserRepository TbtypeUser
        {
            get
            {
                if (_TbtypeUser == null)
                {
                    _TbtypeUser = new TbtypeUserRepository(_repoContext);
                }

                return _TbtypeUser;
            }
        }
        private ITbtypeUserDroitRepository _TbtypeUserDroit;

        public ITbtypeUserDroitRepository TbtypeUserDroit
        {
            get
            {
                if (_TbtypeUserDroit == null)
                {
                    _TbtypeUserDroit = new TbtypeUserDroitRepository(_repoContext);
                }

                return _TbtypeUserDroit;
            }
        }
        private ITbtypeValeurRepository _TbtypeValeur;

        public ITbtypeValeurRepository TbtypeValeur
        {
            get
            {
                if (_TbtypeValeur == null)
                {
                    _TbtypeValeur = new TbtypeValeurRepository(_repoContext);
                }

                return _TbtypeValeur;
            }
        }
        private ITbtypeVehiculeRepository _TbtypeVehicule;

        public ITbtypeVehiculeRepository TbtypeVehicule
        {
            get
            {
                if (_TbtypeVehicule == null)
                {
                    _TbtypeVehicule = new TbtypeVehiculeRepository(_repoContext);
                }

                return _TbtypeVehicule;
            }
        }



        private ITbuserRepository _Tbuser;

        public ITbuserRepository Tbuser
        {
            get
            {
                if (_Tbuser == null)
                {
                    _Tbuser = new TbuserRepository(_repoContext);
                }

                return _Tbuser;
            }
        }


        private ITbuserDossierRepository _TbuserDossier;

        public ITbuserDossierRepository TbuserDossier
        {
            get
            {
                if (_TbuserDossier == null)
                {
                    _TbuserDossier = new TbuserDossierRepository(_repoContext);
                }

                return _TbuserDossier;
            }
        }

        private ITbvehiculeRepository _Tbvehicule;

        public ITbvehiculeRepository Tbvehicule
        {
            get
            {
                if (_Tbvehicule == null)
                {
                    _Tbvehicule = new TbvehiculeRepository(_repoContext);
                }

                return _Tbvehicule;
            }
        }

        private ITbvehiculeAssuranceRepository _TbvehiculeAssurance;

        public ITbvehiculeAssuranceRepository TbvehiculeAssurance
        {
            get
            {
                if (_TbvehiculeAssurance == null)
                {
                    _TbvehiculeAssurance = new TbvehiculeAssuranceRepository(_repoContext);
                }

                return _TbvehiculeAssurance;
            }
        }

        private ITbvilleRepository _Tbville;

        public ITbvilleRepository Tbville
        {
            get
            {
                if (_Tbville == null)
                {
                    _Tbville = new TbvilleRepository(_repoContext);
                }

                return _Tbville;
            }
        }



    }
}
