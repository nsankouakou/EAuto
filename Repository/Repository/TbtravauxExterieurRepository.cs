using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtravauxExterieurRepository : RepositoryBase<TbtravauxExterieur>, ITbtravauxExterieurRepository
    {
        public TbtravauxExterieurRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
