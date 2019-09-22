using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbspecialiteRepository : RepositoryBase<Tbspecialite>, ITbspecialiteRepository
    {
        public TbspecialiteRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
