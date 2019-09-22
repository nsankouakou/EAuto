using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbmainOeuvreRepository : RepositoryBase<TbmainOeuvre>, ITbmainOeuvreRepository
    {
        public TbmainOeuvreRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
