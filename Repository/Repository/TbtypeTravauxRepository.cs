using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeTravauxRepository : RepositoryBase<TbtypeTravaux>, ITbtypeTravauxRepository
    {
        public TbtypeTravauxRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
