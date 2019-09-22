using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseEtatRapportRepository : RepositoryBase<TbexpertiseEtatRapport>, ITbexpertiseEtatRapportRepository
    {
        public TbexpertiseEtatRapportRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
