using Octobooks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Business.Interfaces
{
    public interface IClientBusiness
    {
        void Delete(Client client);
        Client Insert(Client client);
        List<Client> GetAll();
        Client GetById(int id);
    }
}
