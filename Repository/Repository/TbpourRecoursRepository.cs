using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbpourRecoursRepository : RepositoryBase<TbpourRecours>, ITbpourRecoursRepository
    {
        public TbpourRecoursRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
