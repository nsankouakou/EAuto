using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseRubriqueEstimationRepository : RepositoryBase<TbexpertiseRubriqueEstimation>, ITbexpertiseRubriqueEstimationRepository
    {
        public TbexpertiseRubriqueEstimationRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
