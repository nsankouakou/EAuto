using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbmodeleRepository : RepositoryBase<Tbmodele>, ITbmodeleRepository
    {
        public TbmodeleRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
