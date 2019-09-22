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
        #region Assurance
        //Récupération des assurances
        Task<ObjetRetour> getAllAssurance(string token);

        Task<ObjetRetour> getSingleAssurance(string token, int id);

        Task<ObjetRetour> setSingleAssurance(string token, TbassuranceDto assurance);
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
    }
}
