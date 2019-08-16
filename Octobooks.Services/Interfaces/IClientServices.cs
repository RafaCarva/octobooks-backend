using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Services.Interfaces
{
    public interface IClientServices
    {
        void Delete(Client client);
        Client Insert(Client client);
        List<Client> GetAll();
        Client GetById(int id);
    }
}
