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
        private ILoggerManager _logger { get; set; }

        public ConfigController(ILoggerManager logger, IParametreConfigService iConfigurationService)
        {
            _logger = logger;
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
        [HttpGet("GeTbvilleUnique")]
        public async Task<IActionResult> GeTbvilleUnique(decimal id, string token)
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
    }
}