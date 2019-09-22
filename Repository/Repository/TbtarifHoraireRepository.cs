using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtarifHoraireRepository : RepositoryBase<TbtarifHoraire>, ITbtarifHoraireRepository
    {
        public TbtarifHoraireRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
