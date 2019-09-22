using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbautreRubriqueRepository : RepositoryBase<TbautreRubrique>, ITbautreRubriqueRepository
    {
        public TbautreRubriqueRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
