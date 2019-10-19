using ApiExpertAuto.IServices;
using ApiExpertAuto.Models;
using Contracts;
using Entities.Models;
using Entities.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiExpertAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private ILoginService _service { get; set; }
        private ILoggerManager _logger { get; set; }
        public string _strIP { get; set; }

        public LoginController(ILoggerManager logger, ILoginService iLoginService)
        {
            _logger = logger;
            _service = iLoginService;
        }

        

        #region Login

        [HttpPost("Login")]
        public IActionResult Login(LoginModel login)
        {

             return Ok( _service.Login(login));
        }

        [HttpGet("LoginMobile")]
        public IActionResult LoginMobile(string codeEquipement)
        {

            return Ok(_service.LoginMobile(codeEquipement));
        }


        [HttpPost("ModifierMotDePasse")]
        public IActionResult ModifierMotDePasse(LoginModel login)
        {

            return Ok( _service.ModifierMotDePasse(login));
        }
        [HttpPost("InitialiserMotDePasse")]
        public IActionResult InitialiserMotDePasse(LoginModel login)
        {

            return Ok( _service.InitialiserMotDePasse(login));
        }
        #endregion

        #region Users


        [HttpGet("GetALLUsers")]
        public async Task<IActionResult> GetALLUsers(string token)
        {

            return Ok(await _service.GetAllUsers(token));
        }

        [HttpGet("GetALLUsersActif")]
       
        [HttpGet("GetUsersUnique")]
        public async Task<IActionResult> GetUsers(decimal id, string token)
        {

            return Ok(await _service.GetUsers(id, token));
        }


        [HttpPost("InsertUsers")]
        public async Task<IActionResult> InsertUsers(TbuserDto value)
        {

            return Ok(await _service.InsertUsers(value));
        }



        [HttpPost("InsertListUsers")]
        public async Task<IActionResult> InsertListUsers(List<TbuserDto> values)
        {
            return Ok(await InsertListUsers(values));
        }



        [HttpPost("MajUsers")]
        public IActionResult MajUsers(TbuserDto value)
        {

            return Ok(_service.MajUsers(value));
        }

       


        [HttpPost("DeleteUsers")]
        public IActionResult DeleteUsers(TbuserDto value)
        {
            return Ok(_service.DeleteUsers(value));
        }

        
        #endregion

    }
}