using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbuserDossierRepository : RepositoryBase<TbuserDossier>, ITbuserDossierRepository
    {
        public TbuserDossierRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
