using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrembourssementRepository : RepositoryBase<Tbrembourssement>, ITbrembourssementRepository
    {
        public TbrembourssementRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
