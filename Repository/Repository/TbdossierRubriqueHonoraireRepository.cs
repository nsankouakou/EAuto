using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdossierRubriqueHonoraireRepository : RepositoryBase<TbdossierRubriqueHonoraire>, ITbdossierRubriqueHonoraireRepository
    {
        public TbdossierRubriqueHonoraireRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
