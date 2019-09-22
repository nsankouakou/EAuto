using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbpreambuleGenRepository : RepositoryBase<TbpreambuleGen>, ITbpreambuleGenRepository
    {
        public TbpreambuleGenRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
