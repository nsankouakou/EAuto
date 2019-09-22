using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeVehiculeRepository : RepositoryBase<TbtypeVehicule>, ITbtypeVehiculeRepository
    {
        public TbtypeVehiculeRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
