using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbrecapPrejudiceRepository : RepositoryBase<TbrecapPrejudice>, ITbrecapPrejudiceRepository
    {
        public TbrecapPrejudiceRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
