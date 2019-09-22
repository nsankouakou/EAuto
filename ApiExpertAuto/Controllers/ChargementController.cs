using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExpertAuto.IServices;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExpertAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargementController : ControllerBase
    {
        private IParametreConfigService Service { get; set; }
        private ILoggerManager Logger { get; set; }

        public ChargementController(ILoggerManager logger, IParametreConfigService iConfigurationService)
        {
            Logger = logger;
            Service = iConfigurationService;
        }

        [HttpGet("assurance")]
        public IActionResult GetChargAllTbassurance(string token)
        {

            return Ok(Service.GetChargAllTbassurance(token));
        }

    }
}