using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseRubriqueMoRepository : RepositoryBase<TbexpertiseRubriqueMo>, ITbexpertiseRubriqueMoRepository
    {
        public TbexpertiseRubriqueMoRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
