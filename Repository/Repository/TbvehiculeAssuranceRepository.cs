using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbvehiculeAssuranceRepository : RepositoryBase<TbvehiculeAssurance>, ITbvehiculeAssuranceRepository
    {
        public TbvehiculeAssuranceRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
