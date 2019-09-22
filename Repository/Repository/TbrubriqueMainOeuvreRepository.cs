using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrubriqueMainOeuvreRepository : RepositoryBase<TbrubriqueMainOeuvre>, ITbrubriqueMainOeuvreRepository
    {
        public TbrubriqueMainOeuvreRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
