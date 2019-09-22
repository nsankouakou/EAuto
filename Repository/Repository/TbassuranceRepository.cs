using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbassuranceRepository : RepositoryBase<Tbassurance>, ITbassuranceRepository
    {
        public TbassuranceRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
