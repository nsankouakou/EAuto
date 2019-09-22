using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbmarqueCarrosserieRepository : RepositoryBase<TbmarqueCarrosserie>, ITbmarqueCarrosserieRepository
    {
        public TbmarqueCarrosserieRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
