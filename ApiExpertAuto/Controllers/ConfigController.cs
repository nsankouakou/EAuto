using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExpertAuto.IServices;
using Contracts;
using Entities.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExpertAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private IParametreConfigService _service { get; set; }
        private ILoggerManager Logger { get; set; }

        public ConfigController(ILoggerManager logger, IParametreConfigService iConfigurationService)
        {
            Logger = logger;
            _service = iConfigurationService;
        }
        

        #region Tbville
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbville")]
        public IActionResult GetALLTbville(string token)
        {

            return Ok( _service.GetAllTbville(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbvilleUnique")]
        public async Task<IActionResult> GetTbvilleUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbville(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbville")]
        public async Task<IActionResult> InserTbville(TbvilleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbville(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbville")]
        public IActionResult MajTbville(TbvilleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbville(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbville")]
        public IActionResult DeleteTbville(TbvilleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbville(value));
        }


        #endregion

        #region Tbvehicule
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbvehicule")]
        public IActionResult GetALLTbvehicule(string token)
        {

            return Ok(_service.GetAllTbvehicule(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbvehiculeUnique")]
        public async Task<IActionResult> GetTbvehiculeUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbvehicule(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbvehicule")]
        public async Task<IActionResult> InserTbvehicule(TbvehiculeDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbvehicule(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbvehicule")]
        public IActionResult MajTbvehicule(TbvehiculeDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbvehicule(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbvehicule")]
        public IActionResult DeleteTbvehicule(TbvehiculeDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbvehicule(value));
        }


        #endregion

        #region TbtypeValeur
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeValeur")]
        public IActionResult GetALLTbtypeValeur(string token)
        {

            return Ok(_service.GetAllTbtypeValeur(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeValeurUnique")]
        public async Task<IActionResult> GetTbtypeValeurUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeValeur(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeValeur")]
        public async Task<IActionResult> InserTbtypeValeur(TbtypeValeurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeValeur(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeValeur")]
        public IActionResult MajTbtypeValeur(TbtypeValeurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeValeur(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeValeur")]
        public IActionResult DeleteTbtypeValeur(TbtypeValeurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeValeur(value));
        }


        #endregion

        #region TbtypeUserDroit
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeUserDroit")]
        public IActionResult GetALLTbtypeUserDroit(string token)
        {

            return Ok(_service.GetAllTbtypeUserDroit(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeUserDroitUnique")]
        public async Task<IActionResult> GetTbtypeUserDroitUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeUserDroit(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeUserDroit")]
        public async Task<IActionResult> InserTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeUserDroit(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeUserDroit")]
        public IActionResult MajTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeUserDroit(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeUserDroit")]
        public IActionResult DeleteTbtypeUserDroit(TbtypeUserDroitDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeUserDroit(value));
        }


        #endregion

        #region TbtypeUser
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeUser")]
        public IActionResult GetALLTbtypeUser(string token)
        {

            return Ok(_service.GetAllTbtypeUser(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeUserUnique")]
        public async Task<IActionResult> GetTbtypeUserUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeUser(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeUser")]
        public async Task<IActionResult> InserTbtypeUser(TbtypeUserDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeUser(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeUser")]
        public IActionResult MajTbtypeUser(TbtypeUserDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeUser(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeUser")]
        public IActionResult DeleteTbtypeUser(TbtypeUserDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeUser(value));
        }


        #endregion

        #region TbtypeTravaux
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeTravaux")]
        public IActionResult GetALLTbtypeTravaux(string token)
        {

            return Ok(_service.GetAllTbtypeTravaux(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeTravauxUnique")]
        public async Task<IActionResult> GetTbtypeTravauxUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeTravaux(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeTravaux")]
        public async Task<IActionResult> InserTbtypeTravaux(TbtypeTravauxDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeTravaux(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeTravaux")]
        public IActionResult MajTbtypeTravaux(TbtypeTravauxDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeTravaux(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeTravaux")]
        public IActionResult DeleteTbtypeTravaux(TbtypeTravauxDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeTravaux(value));
        }


        #endregion

        #region TbtypePeinture
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypePeinture")]
        public IActionResult GetALLTbtypePeinture(string token)
        {

            return Ok(_service.GetAllTbtypePeinture(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypePeintureUnique")]
        public async Task<IActionResult> GetTbtypePeintureUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypePeinture(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypePeinture")]
        public async Task<IActionResult> InserTbtypePeinture(TbtypePeintureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypePeinture(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypePeinture")]
        public IActionResult MajTbtypePeinture(TbtypePeintureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypePeinture(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypePeinture")]
        public IActionResult DeleteTbtypePeinture(TbtypePeintureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypePeinture(value));
        }


        #endregion

        #region TbtypeNote
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeNote")]
        public IActionResult GetALLTbtypeNote(string token)
        {

            return Ok(_service.GetAllTbtypeNote(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeNoteUnique")]
        public async Task<IActionResult> GetTbtypeNoteUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeNote(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeNote")]
        public async Task<IActionResult> InserTbtypeNote(TbtypeNoteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeNote(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeNote")]
        public IActionResult MajTbtypeNote(TbtypeNoteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeNote(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeNote")]
        public IActionResult DeleteTbtypeNote(TbtypeNoteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeNote(value));
        }


        #endregion

        #region TbtypeExpertise
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypeExpertise")]
        public IActionResult GetALLTbtypeExpertise(string token)
        {

            return Ok(_service.GetAllTbtypeExpertise(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypeExpertiseUnique")]
        public async Task<IActionResult> GetTbtypeExpertiseUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypeExpertise(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypeExpertise")]
        public async Task<IActionResult> InserTbtypeExpertise(TbtypeExpertiseDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypeExpertise(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypeExpertise")]
        public IActionResult MajTbtypeExpertise(TbtypeExpertiseDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypeExpertise(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypeExpertise")]
        public IActionResult DeleteTbtypeExpertise(TbtypeExpertiseDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypeExpertise(value));
        }


        #endregion

        #region TbtypTravauxMainOuvre
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypTravauxMainOuvre")]
        public IActionResult GetALLTbtypTravauxMainOuvre(string token)
        {

            return Ok(_service.GetAllTbtypTravauxMainOuvre(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypTravauxMainOuvreUnique")]
        public async Task<IActionResult> GetTbtypTravauxMainOuvreUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypTravauxMainOuvre(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypTravauxMainOuvre")]
        public async Task<IActionResult> InserTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypTravauxMainOuvre(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypTravauxMainOuvre")]
        public IActionResult MajTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypTravauxMainOuvre(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypTravauxMainOuvre")]
        public IActionResult DeleteTbtypTravauxMainOuvre(TbtypTravauxMainOuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypTravauxMainOuvre(value));
        }


        #endregion

        #region TbtypGarage
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtypGarage")]
        public IActionResult GetALLTbtypGarage(string token)
        {

            return Ok(_service.GetAllTbtypGarage(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtypGarageUnique")]
        public async Task<IActionResult> GetTbtypGarageUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtypGarage(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtypGarage")]
        public async Task<IActionResult> InserTbtypGarage(TbtypGarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtypGarage(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtypGarage")]
        public IActionResult MajTbtypGarage(TbtypGarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtypGarage(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtypGarage")]
        public IActionResult DeleteTbtypGarage(TbtypGarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtypGarage(value));
        }


        #endregion

        #region Tbtva
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbtva")]
        public IActionResult GetALLTbtva(string token)
        {

            return Ok(_service.GetAllTbtva(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbtvaUnique")]
        public async Task<IActionResult> GetTbtvaUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbtva(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbtva")]
        public async Task<IActionResult> InserTbtva(TbtvaDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbtva(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbtva")]
        public IActionResult MajTbtva(TbtvaDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbtva(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbtva")]
        public IActionResult DeleteTbtva(TbtvaDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbtva(value));
        }


        #endregion

        #region Tbparametre
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbparametre")]
        public IActionResult GetALLTbparametre(string token)
        {

            return Ok(_service.GetAllTbparametre(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbparametreUnique")]
        public async Task<IActionResult> GetTbparametreUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbparametre(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbparametre")]
        public async Task<IActionResult> InserTbparametre(TbparametreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbparametre(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbparametre")]
        public IActionResult MajTbparametre(TbparametreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbparametre(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbparametre")]
        public IActionResult DeleteTbparametre(TbparametreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbparametre(value));
        }


        #endregion

        #region Tbmodele
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbmodele")]
        public IActionResult GetALLTbmodele(string token)
        {

            return Ok(_service.GetAllTbmodele(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbmodeleUnique")]
        public async Task<IActionResult> GetTbmodeleUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbmodele(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbmodele")]
        public async Task<IActionResult> InserTbmodele(TbmodeleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbmodele(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbmodele")]
        public IActionResult MajTbmodele(TbmodeleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbmodele(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbmodele")]
        public IActionResult DeleteTbmodele(TbmodeleDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbmodele(value));
        }


        #endregion

        #region Tbmarque
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbmarque")]
        public IActionResult GetALLTbmarque(string token)
        {

            return Ok(_service.GetAllTbmarque(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbmarqueUnique")]
        public async Task<IActionResult> GetTbmarqueUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbmarque(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbmarque")]
        public async Task<IActionResult> InserTbmarque(TbmarqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbmarque(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbmarque")]
        public IActionResult MajTbmarque(TbmarqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbmarque(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbmarque")]
        public IActionResult DeleteTbmarque(TbmarqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbmarque(value));
        }


        #endregion

        #region Tbgenre
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbgenre")]
        public IActionResult GetALLTbgenre(string token)
        {

            return Ok(_service.GetAllTbgenre(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbgenreUnique")]
        public async Task<IActionResult> GetTbgenreUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbgenre(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbgenre")]
        public async Task<IActionResult> InserTbgenre(TbgenreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbgenre(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbgenre")]
        public IActionResult MajTbgenre(TbgenreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbgenre(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbgenre")]
        public IActionResult DeleteTbgenre(TbgenreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbgenre(value));
        }


        #endregion

        #region Tbgarage
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbgarage")]
        public IActionResult GetALLTbgarage(string token)
        {

            return Ok(_service.GetAllTbgarage(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbgarageUnique")]
        public async Task<IActionResult> GetTbgarageUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbgarage(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbgarage")]
        public async Task<IActionResult> InserTbgarage(TbgarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbgarage(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbgarage")]
        public IActionResult MajTbgarage(TbgarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbgarage(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbgarage")]
        public IActionResult DeleteTbgarage(TbgarageDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbgarage(value));
        }


        #endregion

        #region Tbassurance
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbassurance")]
        public IActionResult GetALLTbassurance(string token)
        {

            return Ok(_service.GetAllTbassurance(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbassuranceUnique")]
        public async Task<IActionResult> GetTbassuranceUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbassurance(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbassurance")]
        public async Task<IActionResult> InserTbassurance(TbassuranceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbassurance(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbassurance")]
        public IActionResult MajTbassurance(TbassuranceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbassurance(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbassurance")]
        public IActionResult DeleteTbassurance(TbassuranceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbassurance(value));
        }


        #endregion

        #region Tbagent
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbagent")]
        public IActionResult GetALLTbagent(string token)
        {

            return Ok(_service.GetAllTbagent(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbagentUnique")]
        public async Task<IActionResult> GetTbagentUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbagent(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbagent")]
        public async Task<IActionResult> InserTbagent(TbagentDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbagent(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbagent")]
        public IActionResult MajTbagent(TbagentDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbagent(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbagent")]
        public IActionResult DeleteTbagent(TbagentDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbagent(value));
        }


        #endregion

        #region TbautreRubrique
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbautreRubrique")]
        public IActionResult GetALLTbautreRubrique(string token)
        {

            return Ok(_service.GetAllTbautreRubrique(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbautreRubriqueUnique")]
        public async Task<IActionResult> GetTbautreRubriqueUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbautreRubrique(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbautreRubrique")]
        public async Task<IActionResult> InserTbautreRubrique(TbautreRubriqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbautreRubrique(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbautreRubrique")]
        public IActionResult MajTbautreRubrique(TbautreRubriqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbautreRubrique(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbautreRubrique")]
        public IActionResult DeleteTbautreRubrique(TbautreRubriqueDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbautreRubrique(value));
        }


        #endregion

        #region Tbcarosserie
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbcarosserie")]
        public IActionResult GetALLTbcarosserie(string token)
        {

            return Ok(_service.GetAllTbcarosserie(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbcarosserieUnique")]
        public async Task<IActionResult> GetTbcarosserieUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbcarosserie(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbcarosserie")]
        public async Task<IActionResult> InserTbcarosserie(TbcarosserieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbcarosserie(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbcarosserie")]
        public IActionResult MajTbcarosserie(TbcarosserieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbcarosserie(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbcarosserie")]
        public IActionResult DeleteTbcarosserie(TbcarosserieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbcarosserie(value));
        }


        #endregion

        #region Tbcommune
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbcommune")]
        public IActionResult GetALLTbcommune(string token)
        {

            return Ok(_service.GetAllTbcommune(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbcommuneUnique")]
        public async Task<IActionResult> GetTbcommuneUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbcommune(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbcommune")]
        public async Task<IActionResult> InserTbcommune(TbcommuneDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbcommune(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbcommune")]
        public IActionResult MajTbcommune(TbcommuneDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbcommune(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbcommune")]
        public IActionResult DeleteTbcommune(TbcommuneDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbcommune(value));
        }


        #endregion

        #region Tbcouleur
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbcouleur")]
        public IActionResult GetALLTbcouleur(string token)
        {

            return Ok(_service.GetAllTbcouleur(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbcouleurUnique")]
        public async Task<IActionResult> GetTbcouleurUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbcouleur(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbcouleur")]
        public async Task<IActionResult> InserTbcouleur(TbcouleurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbcouleur(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbcouleur")]
        public IActionResult MajTbcouleur(TbcouleurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbcouleur(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbcouleur")]
        public IActionResult DeleteTbcouleur(TbcouleurDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbcouleur(value));
        }


        #endregion

        #region Tbenergie
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbenergie")]
        public IActionResult GetALLTbenergie(string token)
        {

            return Ok(_service.GetAllTbenergie(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbenergieUnique")]
        public async Task<IActionResult> GetTbenergieUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbenergie(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbenergie")]
        public async Task<IActionResult> InserTbenergie(TbenergieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbenergie(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbenergie")]
        public IActionResult MajTbenergie(TbenergieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbenergie(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbenergie")]
        public IActionResult DeleteTbenergie(TbenergieDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbenergie(value));
        }


        #endregion

        #region Tbfourniture
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbfourniture")]
        public IActionResult GetALLTbfourniture(string token)
        {

            return Ok(_service.GetAllTbfourniture(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbfournitureUnique")]
        public async Task<IActionResult> GetTbfournitureUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbfourniture(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbfourniture")]
        public async Task<IActionResult> InserTbfourniture(TbfournitureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbfourniture(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbfourniture")]
        public IActionResult MajTbfourniture(TbfournitureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbfourniture(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbfourniture")]
        public IActionResult DeleteTbfourniture(TbfournitureDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbfourniture(value));
        }


        #endregion

        #region TbpointChoc
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbpointChoc")]
        public IActionResult GetALLTbpointChoc(string token)
        {

            return Ok(_service.GetAllTbpointChoc(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbpointChocUnique")]
        public async Task<IActionResult> GetTbpointChocUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbpointChoc(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbpointChoc")]
        public async Task<IActionResult> InserTbpointChoc(TbpointChocDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbpointChoc(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbpointChoc")]
        public IActionResult MajTbpointChoc(TbpointChocDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbpointChoc(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbpointChoc")]
        public IActionResult DeleteTbpointChoc(TbpointChocDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbpointChoc(value));
        }


        #endregion

        #region Tbproprietaire
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbproprietaire")]
        public IActionResult GetALLTbproprietaire(string token)
        {

            return Ok(_service.GetAllTbproprietaire(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbproprietaireUnique")]
        public async Task<IActionResult> GetTbproprietaireUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbproprietaire(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbproprietaire")]
        public async Task<IActionResult> InserTbproprietaire(TbproprietaireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbproprietaire(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbproprietaire")]
        public IActionResult MajTbproprietaire(TbproprietaireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbproprietaire(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbproprietaire")]
        public IActionResult DeleteTbproprietaire(TbproprietaireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbproprietaire(value));
        }


        #endregion

        #region TbrubriqueConstatation
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbrubriqueConstatation")]
        public IActionResult GetALLTbrubriqueConstatation(string token)
        {

            return Ok(_service.GetAllTbrubriqueConstatation(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbrubriqueConstatationUnique")]
        public async Task<IActionResult> GetTbrubriqueConstatationUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbrubriqueConstatation(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbrubriqueConstatation")]
        public async Task<IActionResult> InserTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbrubriqueConstatation(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbrubriqueConstatation")]
        public IActionResult MajTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbrubriqueConstatation(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbrubriqueConstatation")]
        public IActionResult DeleteTbrubriqueConstatation(TbrubriqueConstatationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbrubriqueConstatation(value));
        }


        #endregion

        #region TbrubriqueEstimation
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbrubriqueEstimation")]
        public IActionResult GetALLTbrubriqueEstimation(string token)
        {

            return Ok(_service.GetAllTbrubriqueEstimation(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbrubriqueEstimationUnique")]
        public async Task<IActionResult> GetTbrubriqueEstimationUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbrubriqueEstimation(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbrubriqueEstimation")]
        public async Task<IActionResult> InserTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbrubriqueEstimation(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbrubriqueEstimation")]
        public IActionResult MajTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbrubriqueEstimation(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbrubriqueEstimation")]
        public IActionResult DeleteTbrubriqueEstimation(TbrubriqueEstimationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbrubriqueEstimation(value));
        }


        #endregion

        #region TbrubriqueEvaluation
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbrubriqueEvaluation")]
        public IActionResult GetALLTbrubriqueEvaluation(string token)
        {

            return Ok(_service.GetAllTbrubriqueEvaluation(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbrubriqueEvaluationUnique")]
        public async Task<IActionResult> GetTbrubriqueEvaluationUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbrubriqueEvaluation(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbrubriqueEvaluation")]
        public async Task<IActionResult> InserTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbrubriqueEvaluation(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbrubriqueEvaluation")]
        public IActionResult MajTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbrubriqueEvaluation(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbrubriqueEvaluation")]
        public IActionResult DeleteTbrubriqueEvaluation(TbrubriqueEvaluationDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbrubriqueEvaluation(value));
        }


        #endregion

        #region TbrubriqueHonoraire
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbrubriqueHonoraire")]
        public IActionResult GetALLTbrubriqueHonoraire(string token)
        {

            return Ok(_service.GetAllTbrubriqueHonoraire(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbrubriqueHonoraireUnique")]
        public async Task<IActionResult> GetTbrubriqueHonoraireUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbrubriqueHonoraire(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbrubriqueHonoraire")]
        public async Task<IActionResult> InserTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbrubriqueHonoraire(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbrubriqueHonoraire")]
        public IActionResult MajTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbrubriqueHonoraire(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbrubriqueHonoraire")]
        public IActionResult DeleteTbrubriqueHonoraire(TbrubriqueHonoraireDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbrubriqueHonoraire(value));
        }


        #endregion

        #region TbrubriqueMainOeuvre
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbrubriqueMainOeuvre")]
        public IActionResult GetALLTbrubriqueMainOeuvre(string token)
        {

            return Ok(_service.GetAllTbrubriqueMainOeuvre(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbrubriqueMainOeuvreUnique")]
        public async Task<IActionResult> GetTbrubriqueMainOeuvreUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbrubriqueMainOeuvre(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbrubriqueMainOeuvre")]
        public async Task<IActionResult> InserTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbrubriqueMainOeuvre(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbrubriqueMainOeuvre")]
        public IActionResult MajTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbrubriqueMainOeuvre(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbrubriqueMainOeuvre")]
        public IActionResult DeleteTbrubriqueMainOeuvre(TbrubriqueMainOeuvreDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbrubriqueMainOeuvre(value));
        }


        #endregion

        #region Tbservice
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbservice")]
        public IActionResult GetALLTbservice(string token)
        {

            return Ok(_service.GetAllTbservice(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbserviceUnique")]
        public async Task<IActionResult> GetTbserviceUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbservice(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbservice")]
        public async Task<IActionResult> InserTbservice(TbserviceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbservice(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbservice")]
        public IActionResult MajTbservice(TbserviceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbservice(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbservice")]
        public IActionResult DeleteTbservice(TbserviceDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbservice(value));
        }


        #endregion

        #region Tbspecialite
        /// <summary>
        /// Retourne Toutes les villes
        /// </summary>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetALLTbspecialite")]
        public IActionResult GetALLTbspecialite(string token)
        {

            return Ok(_service.GetAllTbspecialite(token));
        }

        /// <summary>
        /// Retourne une ville par l'id
        /// </summary>
        /// <param name="id">Id de ville</param>
        /// <param name="token">Token d'authentification</param>
        /// <returns></returns>
        [HttpGet("GetTbspecialiteUnique")]
        public async Task<IActionResult> GetTbspecialiteUnique(decimal id, string token)
        {

            return Ok(await _service.GetTbspecialite(id, token));
        }

        /// <summary>
        /// Insertion de nouvelle ville
        /// </summary>
        /// <param name="value">Instance de ville à ajouter</param>
        /// <returns></returns>
        [HttpPost("InserTbspecialite")]
        public async Task<IActionResult> InserTbspecialite(TbspecialiteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(await _service.InsertTbspecialite(value));
        }

        /// <summary>
        /// Mise à jour de ville
        /// </summary>
        /// <param name="value">Instance de ville mise à jour</param>
        /// <returns></returns>
        [HttpPost("MajTbspecialite")]
        public IActionResult MajTbspecialite(TbspecialiteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.MajTbspecialite(value));
        }



        /// <summary>
        /// Suppression de ville
        /// </summary>
        /// <param name="value">Instance de ville à supprimer</param>
        /// <returns></returns>
        [HttpPost("DeleteTbspecialite")]
        public IActionResult DeleteTbspecialite(TbspecialiteDto value)
        {
            if (value != null)
            {
                return BadRequest();
            }
            return Ok(_service.DeleteTbspecialite(value));
        }


        #endregion
    }
}