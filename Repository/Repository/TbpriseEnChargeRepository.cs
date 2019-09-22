using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbpriseEnChargeRepository : RepositoryBase<TbpriseEnCharge>, ITbpriseEnChargeRepository
    {
        public TbpriseEnChargeRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
