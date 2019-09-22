using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseTravauxExterieurPointChocRepository : RepositoryBase<TbexpertiseTravauxExterieurPointChoc>, ITbexpertiseTravauxExterieurPointChocRepository
    {
        public TbexpertiseTravauxExterieurPointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
