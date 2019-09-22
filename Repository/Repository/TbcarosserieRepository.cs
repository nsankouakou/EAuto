using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbcarosserieRepository : RepositoryBase<Tbcarosserie>, ITbcarosserieRepository
    {
        public TbcarosserieRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
