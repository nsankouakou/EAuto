using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbnbreElementRepository : RepositoryBase<TbnbreElement>, ITbnbreElementRepository
    {
        public TbnbreElementRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
