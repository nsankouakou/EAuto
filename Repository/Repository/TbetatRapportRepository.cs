using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbetatRapportRepository : RepositoryBase<TbetatRapport>, ITbetatRapportRepository
    {
        public TbetatRapportRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
