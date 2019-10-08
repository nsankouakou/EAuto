using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbagentRepository : RepositoryBase<Tbagent>, ITbagentRepository
    {
        public TbagentRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
