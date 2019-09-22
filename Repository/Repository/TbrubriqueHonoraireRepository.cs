using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrubriqueHonoraireRepository : RepositoryBase<TbrubriqueHonoraire>, ITbrubriqueHonoraireRepository
    {
        public TbrubriqueHonoraireRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
