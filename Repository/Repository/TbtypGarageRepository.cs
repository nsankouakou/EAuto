using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypGarageRepository : RepositoryBase<TbtypGarage>, ITbtypGarageRepository
    {
        public TbtypGarageRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
