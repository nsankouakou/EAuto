using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbvehiculeRepository : RepositoryBase<Tbvehicule>, ITbvehiculeRepository
    {
        public TbvehiculeRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
