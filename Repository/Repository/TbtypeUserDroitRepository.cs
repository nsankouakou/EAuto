using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeUserDroitRepository : RepositoryBase<TbtypeUserDroit>, ITbtypeUserDroitRepository
    {
        public TbtypeUserDroitRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
