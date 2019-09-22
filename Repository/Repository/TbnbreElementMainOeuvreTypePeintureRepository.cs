using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbnbreElementMainOeuvreTypePeintureRepository : RepositoryBase<TbnbreElementMainOeuvreTypePeinture>, ITbnbreElementMainOeuvreTypePeintureRepository
    {
        public TbnbreElementMainOeuvreTypePeintureRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
