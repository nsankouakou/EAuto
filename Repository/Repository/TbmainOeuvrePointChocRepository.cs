using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbmainOeuvrePointChocRepository : RepositoryBase<TbmainOeuvrePointChoc>, ITbmainOeuvrePointChocRepository
    {
        public TbmainOeuvrePointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
