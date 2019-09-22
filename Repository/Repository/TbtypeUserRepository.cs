using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeUserRepository : RepositoryBase<TbtypeUser>, ITbtypeUserRepository
    {
        public TbtypeUserRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
