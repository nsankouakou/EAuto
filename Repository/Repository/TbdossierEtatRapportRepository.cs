using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdossierEtatRapportRepository : RepositoryBase<TbdossierEtatRapport>, ITbdossierEtatRapportRepository
    {
        public TbdossierEtatRapportRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
