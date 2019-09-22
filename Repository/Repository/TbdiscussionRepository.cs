using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdiscussionRepository : RepositoryBase<Tbdiscussion>, ITbdiscussionRepository
    {
        public TbdiscussionRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
