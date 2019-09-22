using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdroitsRepository : RepositoryBase<Tbdroits>, ITbdroitsRepository
    {
        public TbdroitsRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
