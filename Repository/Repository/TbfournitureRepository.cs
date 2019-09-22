using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbfournitureRepository : RepositoryBase<Tbfourniture>, ITbfournitureRepository
    {
        public TbfournitureRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
