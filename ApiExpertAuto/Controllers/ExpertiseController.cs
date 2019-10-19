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
    public class ExpertiseController : ControllerBase
    {
        private IExpertiseServices Service { get; set; }
        private ILoggerManager Logger { get; set; }

        public ExpertiseController(ILoggerManager logger, IExpertiseServices expertise)
        {
            Logger = logger;
            Service = expertise;
        }

       

    }
}