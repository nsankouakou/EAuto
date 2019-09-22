using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypPeintureTarifActifTarifHonoraireNbreElemntRepository : RepositoryBase<TbtypPeintureTarifActifTarifHonoraireNbreElemnt>, ITbtypPeintureTarifActifTarifHonoraireNbreElemntRepository
    {
        public TbtypPeintureTarifActifTarifHonoraireNbreElemntRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
