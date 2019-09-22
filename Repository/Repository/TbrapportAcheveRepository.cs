using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrapportAcheveRepository : RepositoryBase<TbrapportAcheve>, ITbrapportAcheveRepository
    {
        public TbrapportAcheveRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
