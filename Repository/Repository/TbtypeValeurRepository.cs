using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeValeurRepository : RepositoryBase<TbtypeValeur>, ITbtypeValeurRepository
    {
        public TbtypeValeurRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
