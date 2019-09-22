using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbexpertiseTypeNoteRepository : RepositoryBase<TbexpertiseTypeNote>, ITbexpertiseTypeNoteRepository
    {
        public TbexpertiseTypeNoteRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
