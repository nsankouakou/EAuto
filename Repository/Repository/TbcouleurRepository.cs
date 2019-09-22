using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbcouleurRepository : RepositoryBase<Tbcouleur>, ITbcouleurRepository
    {
        public TbcouleurRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
