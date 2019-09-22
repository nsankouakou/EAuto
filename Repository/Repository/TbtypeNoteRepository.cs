using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbtypeNoteRepository : RepositoryBase<TbtypeNote>, ITbtypeNoteRepository
    {
        public TbtypeNoteRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
