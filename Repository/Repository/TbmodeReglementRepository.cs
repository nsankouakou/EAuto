using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbmodeReglementRepository : RepositoryBase<TbmodeReglement>, ITbmodeReglementRepository
    {
        public TbmodeReglementRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
