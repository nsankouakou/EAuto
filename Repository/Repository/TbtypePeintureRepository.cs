using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypePeintureRepository : RepositoryBase<TbtypePeinture>, ITbtypePeintureRepository
    {
        public TbtypePeintureRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
