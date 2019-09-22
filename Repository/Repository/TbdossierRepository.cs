﻿using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TbdossierRepository : RepositoryBase<Tbdossier>, ITbdossierRepository
    {
        public TbdossierRepository(DbExpertAutoContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
