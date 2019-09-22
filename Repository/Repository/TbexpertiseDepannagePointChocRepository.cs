using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseDepannagePointChocRepository : RepositoryBase<TbexpertiseDepannagePointChoc>, ITbexpertiseDepannagePointChocRepository
    {
        public TbexpertiseDepannagePointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
