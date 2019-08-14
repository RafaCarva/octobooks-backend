using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services.Interfaces
{
    public interface IClientServices
    {
        void Delete(Guid key);
        Client Insert(Client client);
        List<Client> GetAll();
        List<Client> GetByBrand(string brand);
    }
}
