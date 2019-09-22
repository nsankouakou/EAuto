using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbconclusionRepository : RepositoryBase<Tbconclusion>, ITbconclusionRepository
    {
        public TbconclusionRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
