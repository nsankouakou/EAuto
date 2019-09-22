using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrubriqueEstimationRepository : RepositoryBase<TbrubriqueEstimation>, ITbrubriqueEstimationRepository
    {
        public TbrubriqueEstimationRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
