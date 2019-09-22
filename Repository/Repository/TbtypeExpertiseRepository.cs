using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeExpertiseRepository : RepositoryBase<TbtypeExpertise>, ITbtypeExpertiseRepository
    {
        public TbtypeExpertiseRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
