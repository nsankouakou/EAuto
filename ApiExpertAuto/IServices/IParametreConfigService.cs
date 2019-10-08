using ApiExpertAuto.Models;
using Entities.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.IServices
{
    public interface IParametreConfigService
    {
        #region Chargements
        Task<ObjetRetour> GetChargAllTbassurance(string token = "");


        Task<ObjetRetour> GetChargAllTbville(string token = "");


        Task<ObjetRetour> GetChargAllTbtypeVehicule(string token = "");


        Task<ObjetRetour> GetChargAllTbtypeValeur(string token = "");

        Task<ObjetRetour> GetChargAllTbtypeTravaux(string token = "");

        Task<ObjetRetour> GetChargAllTbtypePeinture(string token = "");


        Task<ObjetRetour> GetChargAllTbtypeNote(string token = "");


        Task<ObjetRetour> GetChargAllTbtypeExpertise(string token = "");


        Task<ObjetRetour> GetChargAllTbtypTravauxMainOuvre(string token = "");


        Task<ObjetRetour> GetChargAllTbtypGarage(string token = "");


        Task<ObjetRetour> GetChargAllTbtva(string token = "");


        Task<ObjetRetour> GetChargAllTbmodele(string token = "");


        Task<ObjetRetour> GetChargAllTbmarque(string token = "");


        Task<ObjetRetour> GetChargAllTbgenre(string token = "");


        Task<ObjetRetour> GetChargAllTbgarage(string token = "");






        #endregion

        #region Tbville

        ObjetRetour GetAllTbville(string token = "");

        Task<ObjetRetour> GetTbville(decimal id, string token = "");


        Task<ObjetRetour> InsertTbville(TbvilleDto value);


        ObjetRetour MajTbville(TbvilleDto value);


        ObjetRetour DeleteTbville(TbvilleDto value);

        #endregion

        #region Tbvehicule

        ObjetRetour GetAllTbvehicule(string token = "");

        Task<ObjetRetour> GetTbvehicule(decimal id, string token = "");


        Task<ObjetRetour> InsertTbvehicule(TbvehiculeDto value);


        ObjetRetour MajTbvehicule(TbvehiculeDto value);


        ObjetRetour DeleteTbvehicule(TbvehiculeDto value);

        #endregion

        #region TbtypeVehicule

        ObjetRetour GetAllTbtypeVehicule(string token = "");

        Task<ObjetRetour> GetTbtypeVehicule(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeVehicule(TbtypeVehiculeDto value);


        ObjetRetour MajTbtypeVehicule(TbtypeVehiculeDto value);


        ObjetRetour DeleteTbtypeVehicule(TbtypeVehiculeDto value);

        #endregion

        #region TbtypeValeur

        ObjetRetour GetAllTbtypeValeur(string token = "");

        Task<ObjetRetour> GetTbtypeValeur(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeValeur(TbtypeValeurDto value);


        ObjetRetour MajTbtypeValeur(TbtypeValeurDto value);


        ObjetRetour DeleteTbtypeValeur(TbtypeValeurDto value);

        #endregion

        #region TbtypeUserDroit

        ObjetRetour GetAllTbtypeUserDroit(string token = "");

        Task<ObjetRetour> GetTbtypeUserDroit(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeUserDroit(TbtypeUserDroitDto value);


        ObjetRetour MajTbtypeUserDroit(TbtypeUserDroitDto value);


        ObjetRetour DeleteTbtypeUserDroit(TbtypeUserDroitDto value);

        #endregion

        #region TbtypeUser

        ObjetRetour GetAllTbtypeUser(string token = "");

        Task<ObjetRetour> GetTbtypeUser(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeUser(TbtypeUserDto value);


        ObjetRetour MajTbtypeUser(TbtypeUserDto value);


        ObjetRetour DeleteTbtypeUser(TbtypeUserDto value);

        #endregion

        #region TbtypeTravaux

        ObjetRetour GetAllTbtypeTravaux(string token = "");

        Task<ObjetRetour> GetTbtypeTravaux(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeTravaux(TbtypeTravauxDto value);


        ObjetRetour MajTbtypeTravaux(TbtypeTravauxDto value);


        ObjetRetour DeleteTbtypeTravaux(TbtypeTravauxDto value);

        #endregion

        #region TbtypePeinture

        ObjetRetour GetAllTbtypePeinture(string token = "");

        Task<ObjetRetour> GetTbtypePeinture(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypePeinture(TbtypePeintureDto value);


        ObjetRetour MajTbtypePeinture(TbtypePeintureDto value);


        ObjetRetour DeleteTbtypePeinture(TbtypePeintureDto value);

        #endregion

        #region TbtypeNote

        ObjetRetour GetAllTbtypeNote(string token = "");

        Task<ObjetRetour> GetTbtypeNote(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeNote(TbtypeNoteDto value);


        ObjetRetour MajTbtypeNote(TbtypeNoteDto value);


        ObjetRetour DeleteTbtypeNote(TbtypeNoteDto value);

        #endregion

        #region TbtypeExpertise

        ObjetRetour GetAllTbtypeExpertise(string token = "");

        Task<ObjetRetour> GetTbtypeExpertise(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypeExpertise(TbtypeExpertiseDto value);


        ObjetRetour MajTbtypeExpertise(TbtypeExpertiseDto value);


        ObjetRetour DeleteTbtypeExpertise(TbtypeExpertiseDto value);

        #endregion

        #region TbtypTravauxMainOuvre

        ObjetRetour GetAllTbtypTravauxMainOuvre(string token = "");

        Task<ObjetRetour> GetTbtypTravauxMainOuvre(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value);


        ObjetRetour MajTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value);


        ObjetRetour DeleteTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value);

        #endregion

        #region TbtypGarage

        ObjetRetour GetAllTbtypGarage(string token = "");

        Task<ObjetRetour> GetTbtypGarage(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtypGarage(TbtypGarageDto value);


        ObjetRetour MajTbtypGarage(TbtypGarageDto value);


        ObjetRetour DeleteTbtypGarage(TbtypGarageDto value);

        #endregion

        #region Tbtva

        ObjetRetour GetAllTbtva(string token = "");

        Task<ObjetRetour> GetTbtva(decimal id, string token = "");


        Task<ObjetRetour> InsertTbtva(TbtvaDto value);


        ObjetRetour MajTbtva(TbtvaDto value);


        ObjetRetour DeleteTbtva(TbtvaDto value);

        #endregion

        #region Tbparametre

        ObjetRetour GetAllTbparametre(string token = "");

        Task<ObjetRetour> GetTbparametre(decimal id, string token = "");


        Task<ObjetRetour> InsertTbparametre(TbparametreDto value);


        ObjetRetour MajTbparametre(TbparametreDto value);


        ObjetRetour DeleteTbparametre(TbparametreDto value);

        #endregion

        #region Tbmodele

        ObjetRetour GetAllTbmodele(string token = "");

        Task<ObjetRetour> GetTbmodele(decimal id, string token = "");


        Task<ObjetRetour> InsertTbmodele(TbmodeleDto value);


        ObjetRetour MajTbmodele(TbmodeleDto value);


        ObjetRetour DeleteTbmodele(TbmodeleDto value);

        #endregion

        #region Tbmarque

        ObjetRetour GetAllTbmarque(string token = "");

        Task<ObjetRetour> GetTbmarque(decimal id, string token = "");


        Task<ObjetRetour> InsertTbmarque(TbmarqueDto value);


        ObjetRetour MajTbmarque(TbmarqueDto value);


        ObjetRetour DeleteTbmarque(TbmarqueDto value);

        #endregion

        #region Tbgenre

        ObjetRetour GetAllTbgenre(string token = "");

        Task<ObjetRetour> GetTbgenre(decimal id, string token = "");


        Task<ObjetRetour> InsertTbgenre(TbgenreDto value);


        ObjetRetour MajTbgenre(TbgenreDto value);


        ObjetRetour DeleteTbgenre(TbgenreDto value);

        #endregion

        #region Tbgarage

        ObjetRetour GetAllTbgarage(string token = "");

        Task<ObjetRetour> GetTbgarage(decimal id, string token = "");


        Task<ObjetRetour> InsertTbgarage(TbgarageDto value);


        ObjetRetour MajTbgarage(TbgarageDto value);


        ObjetRetour DeleteTbgarage(TbgarageDto value);

        #endregion

        #region Tbassurance


        ObjetRetour GetAllTbassurance(string token = "");

        Task<ObjetRetour> GetTbassurance(decimal id, string token = "");

        Task<ObjetRetour> InsertTbassurance(TbassuranceDto value);

        ObjetRetour MajTbassurance(TbassuranceDto value);

        ObjetRetour DeleteTbassurance(TbassuranceDto value);

        #endregion

        #region Tbagent


        ObjetRetour GetAllTbagent(string token = "");

        Task<ObjetRetour> GetTbagent(decimal id, string token = "");

        Task<ObjetRetour> InsertTbagent(TbagentDto value);

        ObjetRetour MajTbagent(TbagentDto value);

        ObjetRetour DeleteTbagent(TbagentDto value);

        #endregion

        #region TbautreRubrique

        Task<ObjetRetour> GetChargAllTbautreRubrique(string token = "");

        ObjetRetour GetAllTbautreRubrique(string token = "");

        Task<ObjetRetour> GetTbautreRubrique(decimal id, string token = "");

        Task<ObjetRetour> InsertTbautreRubrique(TbautreRubriqueDto value);

        ObjetRetour MajTbautreRubrique(TbautreRubriqueDto value);

        ObjetRetour DeleteTbautreRubrique(TbautreRubriqueDto value);

        #endregion

        #region Tbcarosserie

        Task<ObjetRetour> GetChargAllTbcarosserie(string token = "");

        ObjetRetour GetAllTbcarosserie(string token = "");

        Task<ObjetRetour> GetTbcarosserie(decimal id, string token = "");

        Task<ObjetRetour> InsertTbcarosserie(TbcarosserieDto value);

        ObjetRetour MajTbcarosserie(TbcarosserieDto value);

        ObjetRetour DeleteTbcarosserie(TbcarosserieDto value);

        #endregion

        #region Tbcommune

        Task<ObjetRetour> GetChargAllTbcommune(string token = "");

        ObjetRetour GetAllTbcommune(string token = "");

        Task<ObjetRetour> GetTbcommune(decimal id, string token = "");

        Task<ObjetRetour> InsertTbcommune(TbcommuneDto value);

        ObjetRetour MajTbcommune(TbcommuneDto value);

        ObjetRetour DeleteTbcommune(TbcommuneDto value);

        #endregion

        #region Tbcouleur

        Task<ObjetRetour> GetChargAllTbcouleur(string token = "");

        ObjetRetour GetAllTbcouleur(string token = "");

        Task<ObjetRetour> GetTbcouleur(decimal id, string token = "");

        Task<ObjetRetour> InsertTbcouleur(TbcouleurDto value);

        ObjetRetour MajTbcouleur(TbcouleurDto value);

        ObjetRetour DeleteTbcouleur(TbcouleurDto value);

        #endregion

        #region Tbenergie

        Task<ObjetRetour> GetChargAllTbenergie(string token = "");

        ObjetRetour GetAllTbenergie(string token = "");

        Task<ObjetRetour> GetTbenergie(decimal id, string token = "");

        Task<ObjetRetour> InsertTbenergie(TbenergieDto value);

        ObjetRetour MajTbenergie(TbenergieDto value);

        ObjetRetour DeleteTbenergie(TbenergieDto value);

        #endregion

        #region Tbfourniture

        Task<ObjetRetour> GetChargAllTbfourniture(string token = "");

        ObjetRetour GetAllTbfourniture(string token = "");

        Task<ObjetRetour> GetTbfourniture(decimal id, string token = "");

        Task<ObjetRetour> InsertTbfourniture(TbfournitureDto value);

        ObjetRetour MajTbfourniture(TbfournitureDto value);

        ObjetRetour DeleteTbfourniture(TbfournitureDto value);

        #endregion

        #region TbpointChoc

        Task<ObjetRetour> GetChargAllTbpointChoc(string token = "");

        ObjetRetour GetAllTbpointChoc(string token = "");

        Task<ObjetRetour> GetTbpointChoc(decimal id, string token = "");

        Task<ObjetRetour> InsertTbpointChoc(TbpointChocDto value);

        ObjetRetour MajTbpointChoc(TbpointChocDto value);

        ObjetRetour DeleteTbpointChoc(TbpointChocDto value);

        #endregion

        #region Tbproprietaire


        ObjetRetour GetAllTbproprietaire(string token = "");

        Task<ObjetRetour> GetTbproprietaire(decimal id, string token = "");

        Task<ObjetRetour> InsertTbproprietaire(TbproprietaireDto value);

        ObjetRetour MajTbproprietaire(TbproprietaireDto value);

        ObjetRetour DeleteTbproprietaire(TbproprietaireDto value);

        #endregion

        #region TbrubriqueConstatation

        Task<ObjetRetour> GetChargAllTbrubriqueConstatation(string token = "");

        ObjetRetour GetAllTbrubriqueConstatation(string token = "");

        Task<ObjetRetour> GetTbrubriqueConstatation(decimal id, string token = "");

        Task<ObjetRetour> InsertTbrubriqueConstatation(TbrubriqueConstatationDto value);

        ObjetRetour MajTbrubriqueConstatation(TbrubriqueConstatationDto value);

        ObjetRetour DeleteTbrubriqueConstatation(TbrubriqueConstatationDto value);

        #endregion

        #region TbrubriqueEstimation

        Task<ObjetRetour> GetChargAllTbrubriqueEstimation(string token = "");

        ObjetRetour GetAllTbrubriqueEstimation(string token = "");

        Task<ObjetRetour> GetTbrubriqueEstimation(decimal id, string token = "");

        Task<ObjetRetour> InsertTbrubriqueEstimation(TbrubriqueEstimationDto value);

        ObjetRetour MajTbrubriqueEstimation(TbrubriqueEstimationDto value);

        ObjetRetour DeleteTbrubriqueEstimation(TbrubriqueEstimationDto value);

        #endregion

        #region TbrubriqueEvaluation

        Task<ObjetRetour> GetChargAllTbrubriqueEvaluation(string token = "");

        ObjetRetour GetAllTbrubriqueEvaluation(string token = "");

        Task<ObjetRetour> GetTbrubriqueEvaluation(decimal id, string token = "");

        Task<ObjetRetour> InsertTbrubriqueEvaluation(TbrubriqueEvaluationDto value);

        ObjetRetour MajTbrubriqueEvaluation(TbrubriqueEvaluationDto value);

        ObjetRetour DeleteTbrubriqueEvaluation(TbrubriqueEvaluationDto value);

        #endregion

        #region TbrubriqueHonoraire

        Task<ObjetRetour> GetChargAllTbrubriqueHonoraire(string token = "");

        ObjetRetour GetAllTbrubriqueHonoraire(string token = "");

        Task<ObjetRetour> GetTbrubriqueHonoraire(decimal id, string token = "");

        Task<ObjetRetour> InsertTbrubriqueHonoraire(TbrubriqueHonoraireDto value);

        ObjetRetour MajTbrubriqueHonoraire(TbrubriqueHonoraireDto value);

        ObjetRetour DeleteTbrubriqueHonoraire(TbrubriqueHonoraireDto value);

        #endregion

        #region TbrubriqueMainOeuvre

        Task<ObjetRetour> GetChargAllTbrubriqueMainOeuvre(string token = "");

        ObjetRetour GetAllTbrubriqueMainOeuvre(string token = "");

        Task<ObjetRetour> GetTbrubriqueMainOeuvre(decimal id, string token = "");

        Task<ObjetRetour> InsertTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value);

        ObjetRetour MajTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value);

        ObjetRetour DeleteTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value);

        #endregion

        #region Tbservice

        Task<ObjetRetour> GetChargAllTbservice(string token = "");

        ObjetRetour GetAllTbservice(string token = "");

        Task<ObjetRetour> GetTbservice(decimal id, string token = "");

        Task<ObjetRetour> InsertTbservice(TbserviceDto value);

        ObjetRetour MajTbservice(TbserviceDto value);

        ObjetRetour DeleteTbservice(TbserviceDto value);

        #endregion

        #region Tbspecialite

        Task<ObjetRetour> GetChargAllTbspecialite(string token = "");

        ObjetRetour GetAllTbspecialite(string token = "");

        Task<ObjetRetour> GetTbspecialite(decimal id, string token = "");

        Task<ObjetRetour> InsertTbspecialite(TbspecialiteDto value);

        ObjetRetour MajTbspecialite(TbspecialiteDto value);

        ObjetRetour DeleteTbspecialite(TbspecialiteDto value);

        #endregion



    }
}
