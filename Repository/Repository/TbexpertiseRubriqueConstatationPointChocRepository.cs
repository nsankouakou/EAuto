using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseRubriqueConstatationPointChocRepository : RepositoryBase<TbexpertiseRubriqueConstatationPointChoc>, ITbexpertiseRubriqueConstatationPointChocRepository
    {
        public TbexpertiseRubriqueConstatationPointChocRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
