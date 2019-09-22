using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertisePointChocRepository : RepositoryBase<TbexpertisePointChoc>, ITbexpertisePointChocRepository
    {
        public TbexpertisePointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
