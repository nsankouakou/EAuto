using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertisePourRecousPointChocRepository : RepositoryBase<TbexpertisePourRecousPointChoc>, ITbexpertisePourRecousPointChocRepository
    {
        public TbexpertisePourRecousPointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
