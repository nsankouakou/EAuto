using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtarifHoraireGarageMarqueRepository : RepositoryBase<TbtarifHoraireGarageMarque>, ITbtarifHoraireGarageMarqueRepository
    {
        public TbtarifHoraireGarageMarqueRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
