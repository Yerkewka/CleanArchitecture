using System;
using Entities;
using Entities.Models;
using Contracts.Repositories;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
