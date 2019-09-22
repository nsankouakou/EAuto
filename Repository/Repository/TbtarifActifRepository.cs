using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtarifActifRepository : RepositoryBase<TbtarifActif>, ITbtarifActifRepository
    {
        public TbtarifActifRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
