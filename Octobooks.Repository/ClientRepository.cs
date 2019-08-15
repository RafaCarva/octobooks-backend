using Microsoft.Extensions.Configuration;
using Octobooks.Domain.Models;
using Octobooks.Repository.Base;
using Octobooks.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(IConfiguration config) : base(config)
        {
        }
    }
}
