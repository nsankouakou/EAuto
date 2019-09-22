using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbpreambuleRepository : RepositoryBase<Tbpreambule>, ITbpreambuleRepository
    {
        public TbpreambuleRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
