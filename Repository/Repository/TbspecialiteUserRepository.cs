using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbspecialiteUserRepository : RepositoryBase<TbspecialiteUser>, ITbspecialiteUserRepository
    {
        public TbspecialiteUserRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
