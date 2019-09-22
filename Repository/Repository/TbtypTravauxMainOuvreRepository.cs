using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypTravauxMainOuvreRepository : RepositoryBase<TbtypTravauxMainOuvre>, ITbtypTravauxMainOuvreRepository
    {
        public TbtypTravauxMainOuvreRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
