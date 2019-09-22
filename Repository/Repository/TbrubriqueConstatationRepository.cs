using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrubriqueConstatationRepository : RepositoryBase<TbrubriqueConstatation>, ITbrubriqueConstatationRepository
    {
        public TbrubriqueConstatationRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
