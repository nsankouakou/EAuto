using ApiExpertAuto.IServices;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExpertAuto.Services
{
    public class CommunServices : ICommunServices
    {
        private IRepositoryWrapper _service { get; set; }
        private ILoggerManager _logger { get; set; }

        public CommunServices(IRepositoryWrapper service, ILoggerManager logger)
        {
            _service = service;
            _logger = logger;
        }

        public int ConnexionValide(string token)
        {
           return 1;
        }
    }
}
