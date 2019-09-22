using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdossierSortisRepository : RepositoryBase<TbdossierSortis>, ITbdossierSortisRepository
    {
        public TbdossierSortisRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
