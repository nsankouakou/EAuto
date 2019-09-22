using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbcommuneRepository : RepositoryBase<Tbcommune>, ITbcommuneRepository
    {
        public TbcommuneRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
