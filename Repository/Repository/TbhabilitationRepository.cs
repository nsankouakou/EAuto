using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbhabilitationRepository : RepositoryBase<Tbhabilitation>, ITbhabilitationRepository
    {
        public TbhabilitationRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
