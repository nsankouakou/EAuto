using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrubriqueEvaluationRepository : RepositoryBase<TbrubriqueEvaluation>, ITbrubriqueEvaluationRepository
    {
        public TbrubriqueEvaluationRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
