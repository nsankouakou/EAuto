using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseRepository : RepositoryBase<Tbexpertise>, ITbexpertiseRepository
    {
        public TbexpertiseRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
